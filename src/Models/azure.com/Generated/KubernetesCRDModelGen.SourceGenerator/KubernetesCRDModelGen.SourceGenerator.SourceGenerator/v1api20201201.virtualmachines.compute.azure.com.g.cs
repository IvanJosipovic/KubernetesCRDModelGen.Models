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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201201VirtualMachineList : IKubernetesObject<V1ListMeta>, IItems<V1api20201201VirtualMachine>
{
    public const string KubeApiVersion = "v1api20201201";
    public const string KubeKind = "VirtualMachineList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20201201";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201201VirtualMachine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201201VirtualMachine> Items { get; set; }
}

/// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecAdditionalCapabilities
{
    /// <summary>
    /// UltraSSDEnabled: The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS
    /// storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual
    /// machine or virtual machine scale set only if this property is enabled.
    /// </summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecAvailabilitySetReference
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
/// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
/// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
/// more information about availability sets, see [Manage the availability of virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in
/// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
/// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
/// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
/// availability set.
/// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecAvailabilitySet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecAvailabilitySetReference? Reference { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecBillingProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecDiagnosticsProfileBootDiagnostics
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecDiagnosticsProfile
{
    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20201201VirtualMachineSpecDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
/// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
/// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
/// 2017-10-30-preview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecEvictionPolicyEnum>))]
public enum V1api20201201VirtualMachineSpecEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecExtendedLocationTypeEnum>))]
public enum V1api20201201VirtualMachineSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20201201VirtualMachineSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>HardwareProfile: Specifies the hardware settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecHardwareProfile
{
    /// <summary>
    /// VmSize: Specifies the size of the virtual machine.
    /// The enum data type is currently deprecated and will be removed by December 23rd 2023.
    /// Recommended way to get the list of available sizes is using these APIs:
    /// [List all available virtual machine sizes in an availability
    /// set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes)
    /// [List all available virtual machine sizes in a region](
    /// https://docs.microsoft.com/en-us/rest/api/compute/resourceskus/list)
    /// [List all available virtual machine sizes for
    /// resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes). For more information about
    /// virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/en-us/azure/virtual-machines/sizes).
    /// The available VM sizes depend on region and availability set.
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecHostReference
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
/// Host: Specifies information about the dedicated host that the virtual machine resides in.
/// Minimum api-version: 2018-10-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecHost
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecHostReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecHostGroupReference
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
/// HostGroup: Specifies information about the dedicated host group that the virtual machine resides in.
/// Minimum api-version: 2020-06-01.
/// NOTE: User cannot specify both host and hostGroup properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecHostGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecHostGroupReference? Reference { get; set; }
}

/// <summary>
/// Type: The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
/// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
/// virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecIdentityTypeEnum>))]
public enum V1api20201201VirtualMachineSpecIdentityTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the virtual machine, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
    /// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
    /// virtual machine.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20201201VirtualMachineSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Virtual Machine. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20201201VirtualMachineSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecNetworkProfileNetworkInterfacesReference
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

/// <summary>Describes a network interface reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecNetworkProfileNetworkInterfaces
{
    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecNetworkProfileNetworkInterfacesReference? Reference { get; set; }
}

/// <summary>NetworkProfile: Specifies the network interfaces of the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecNetworkProfile
{
    /// <summary>NetworkInterfaces: Specifies the list of resource Ids for the network interfaces associated with the virtual machine.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20201201VirtualMachineSpecNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20201201VirtualMachineSpecOperatorSpecSecretExpressions
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
public partial class V1api20201201VirtualMachineSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201201VirtualMachineSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201201VirtualMachineSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileAdminPassword
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsPatchModeEnum>))]
public enum V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsPatchModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - The virtual machine&apos;s default patching configuration is used.
    /// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
    /// must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V1api20201201VirtualMachineSpecOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileSecretsSourceVaultReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileSecretsSourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileSecretsVaultCertificates
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201VirtualMachineSpecOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20201201VirtualMachineSpecOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum>))]
public enum V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum
{
    [EnumMember(Value = "Microsoft-Windows-Shell-Setup"), JsonStringEnumMemberName("Microsoft-Windows-Shell-Setup")]
    MicrosoftWindowsShellSetup
}

/// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum>))]
public enum V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum
{
    [EnumMember(Value = "OobeSystem"), JsonStringEnumMemberName("OobeSystem")]
    OobeSystem
}

/// <summary>
/// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
/// AutoLogon.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum>))]
public enum V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
    [JsonPropertyName("componentName")]
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum? ComponentName { get; set; }

    /// <summary>
    /// Content: Specifies the XML formatted content that is added to the unattend.xml file for the specified path and
    /// component. The XML must be less than 4KB and must include the root element for the setting or feature that is being
    /// inserted.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
    [JsonPropertyName("passName")]
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum? PassName { get; set; }

    /// <summary>
    /// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
    /// AutoLogon.
    /// </summary>
    [JsonPropertyName("settingName")]
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum? SettingName { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsPatchModeEnum>))]
public enum V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsPatchModeEnum
{
    [EnumMember(Value = "AutomaticByOS"), JsonStringEnumMemberName("AutomaticByOS")]
    AutomaticByOS,
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationPatchSettings
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
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>
/// Protocol: Specifies the protocol of WinRM listener.
/// Possible values are:
/// http
/// https
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRMListenersProtocolEnum>))]
public enum V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRMListenersProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

/// <summary>Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners
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
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRMListenersProtocolEnum? Protocol { get; set; }
}

/// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

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
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
/// be changed once VM is provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOsProfile
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
    public V1api20201201VirtualMachineSpecOsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// This property cannot be updated after the VM is created.
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
    /// AllowExtensionOperations: Specifies whether extension operations should be allowed on the virtual machine.
    /// This may only be set to False when no extensions are present on the virtual machine.
    /// </summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary>
    /// ComputerName: Specifies the host OS name of the virtual machine.
    /// This name cannot be updated after the VM is created.
    /// Max-length (Windows): 15 characters
    /// Max-length (Linux): 64 characters.
    /// For naming conventions and restrictions see [Azure infrastructure services implementation
    /// guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions).
    /// </summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>
    /// CustomData: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array
    /// that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.
    /// Note: Do not pass any secrets or passwords in customData property
    /// This property cannot be updated after the VM is created.
    /// customData is passed to the VM to be saved as a file, for more information see [Custom Data on Azure
    /// VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/)
    /// For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during
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
    public V1api20201201VirtualMachineSpecOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>
    /// RequireGuestProvisionSignal: Specifies whether the guest provision signal is required to infer provision success of the
    /// virtual machine.  Note: This property is for private testing only, and all customers must not set the property to false.
    /// </summary>
    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    /// <summary>Secrets: Specifies set of certificates that should be installed onto the virtual machine.</summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20201201VirtualMachineSpecOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20201201VirtualMachineSpecOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecOwner
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecPlan
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
/// Priority: Specifies the priority for the virtual machine.
/// Minimum api-version: 2019-03-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecPriorityEnum>))]
public enum V1api20201201VirtualMachineSpecPriorityEnum
{
    [EnumMember(Value = "Low"), JsonStringEnumMemberName("Low")]
    Low,
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecProximityPlacementGroupReference
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
/// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine should be
/// assigned to.
/// Minimum api-version: 2018-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecProximityPlacementGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>
/// SecurityType: Specifies the SecurityType of the virtual machine. It is set as TrustedLaunch to enable UefiSettings.
/// Default: UefiSettings will not be enabled unless this property is set as TrustedLaunch.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecSecurityProfileSecurityTypeEnum>))]
public enum V1api20201201VirtualMachineSpecSecurityProfileSecurityTypeEnum
{
    [EnumMember(Value = "TrustedLaunch"), JsonStringEnumMemberName("TrustedLaunch")]
    TrustedLaunch
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecSecurityProfileUefiSettings
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

/// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecSecurityProfile
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
    public V1api20201201VirtualMachineSpecSecurityProfileSecurityTypeEnum? SecurityType { get; set; }

    /// <summary>
    /// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V1api20201201VirtualMachineSpecSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>
/// Caching: Specifies the caching requirements.
/// Possible values are:
/// None
/// ReadOnly
/// ReadWrite
/// Default: None for Standard storage. ReadOnly for Premium storage
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileDataDisksCachingEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileDataDisksCachingEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "ReadWrite"), JsonStringEnumMemberName("ReadWrite")]
    ReadWrite
}

/// <summary>
/// CreateOption: Specifies how the virtual machine should be created.
/// Possible values are:
/// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
/// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
/// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
/// use the plan element previously described.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileDataDisksCreateOptionEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileDataDisksCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>
/// DetachOption: Specifies the detach behavior to be used while detaching a disk or which is already in the process of
/// detachment from the virtual machine. Supported values: ForceDetach.
/// detachOption: ForceDetach is applicable only for managed data disks. If a previous detachment attempt of the data disk
/// did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use
/// force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed
/// when using this detach behavior.
/// This feature is still in preview mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk
/// update toBeDetached to &apos;true&apos; along with setting detachOption: &apos;ForceDetach&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileDataDisksDetachOptionEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileDataDisksDetachOptionEnum
{
    [EnumMember(Value = "ForceDetach"), JsonStringEnumMemberName("ForceDetach")]
    ForceDetach
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisksImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskReference
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
/// StorageAccountType: Specifies the storage account type for the managed disk. Managed OS disk storage account type can
/// only be set when you create the scale set. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with
/// OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskStorageAccountTypeEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskStorageAccountTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskReference? Reference { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. Managed OS disk storage account type can
    /// only be set when you create the scale set. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with
    /// OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisksVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileDataDisks
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
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksCachingEnum? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machine should be created.
    /// Possible values are:
    /// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
    /// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
    /// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
    /// use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public required V1api20201201VirtualMachineSpecStorageProfileDataDisksCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DetachOption: Specifies the detach behavior to be used while detaching a disk or which is already in the process of
    /// detachment from the virtual machine. Supported values: ForceDetach.
    /// detachOption: ForceDetach is applicable only for managed data disks. If a previous detachment attempt of the data disk
    /// did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use
    /// force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed
    /// when using this detach behavior.
    /// This feature is still in preview mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk
    /// update toBeDetached to &apos;true&apos; along with setting detachOption: &apos;ForceDetach&apos;.
    /// </summary>
    [JsonPropertyName("detachOption")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksDetachOptionEnum? DetachOption { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
    /// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksImage? Image { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public required int Lun { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ToBeDetached: Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset</summary>
    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20201201VirtualMachineSpecStorageProfileDataDisksVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileImageReferenceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileImageReference
{
    /// <summary>Offer: Specifies the offer of the platform image or marketplace image used to create the virtual machine.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Publisher: The image publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileImageReferenceReference? Reference { get; set; }

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
/// Default: None for Standard storage. ReadOnly for Premium storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileOsDiskCachingEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileOsDiskCachingEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "ReadWrite"), JsonStringEnumMemberName("ReadWrite")]
    ReadWrite
}

/// <summary>
/// CreateOption: Specifies how the virtual machine should be created.
/// Possible values are:
/// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
/// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
/// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
/// use the plan element previously described.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileOsDiskCreateOptionEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileOsDiskCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsOptionEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsOptionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsPlacementEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsPlacementEnum
{
    [EnumMember(Value = "CacheDisk"), JsonStringEnumMemberName("CacheDisk")]
    CacheDisk,
    [EnumMember(Value = "ResourceDisk"), JsonStringEnumMemberName("ResourceDisk")]
    ResourceDisk
}

/// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
    [JsonPropertyName("option")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsOptionEnum? Option { get; set; }

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
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsPlacementEnum? Placement { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public required string SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference
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

/// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: The URL referencing a key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyUrl")]
    public required string KeyUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>
/// EncryptionSettings: Specifies the encryption settings for the OS Disk.
/// Minimum api-version: 2015-06-15
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Enabled: Specifies whether disk encryption should be enabled on the virtual machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskReference
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
/// StorageAccountType: Specifies the storage account type for the managed disk. Managed OS disk storage account type can
/// only be set when you create the scale set. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with
/// OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskStorageAccountTypeEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskStorageAccountTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskReference? Reference { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. Managed OS disk storage account type can
    /// only be set when you create the scale set. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with
    /// OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>
/// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from
/// user-image or a specialized VHD.
/// Possible values are:
/// Windows
/// Linux
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201201VirtualMachineSpecStorageProfileOsDiskOsTypeEnum>))]
public enum V1api20201201VirtualMachineSpecStorageProfileOsDiskOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDiskVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machine.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfileOsDisk
{
    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage.
    /// </summary>
    [JsonPropertyName("caching")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskCachingEnum? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machine should be created.
    /// Possible values are:
    /// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
    /// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
    /// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
    /// use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public required V1api20201201VirtualMachineSpecStorageProfileOsDiskCreateOptionEnum CreateOption { get; set; }

    /// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// EncryptionSettings: Specifies the encryption settings for the OS Disk.
    /// Minimum api-version: 2015-06-15
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
    /// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

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
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskOsTypeEnum? OsType { get; set; }

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDiskVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add a data disk to a virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20201201VirtualMachineSpecStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20201201VirtualMachineSpecStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V1api20201201VirtualMachineSpecStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecVirtualMachineScaleSetReference
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
/// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
/// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
/// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
/// cannot be added to a virtual machine scale set.
/// This property cannot exist along with a non-null properties.availabilitySet reference.
/// Minimum api‐version: 2019‐03‐01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpecVirtualMachineScaleSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201VirtualMachineSpecVirtualMachineScaleSetReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineSpec
{
    /// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20201201VirtualMachineSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>
    /// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
    /// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
    /// more information about availability sets, see [Manage the availability of virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
    /// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
    /// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
    /// availability set.
    /// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
    /// </summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20201201VirtualMachineSpecAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V1api20201201VirtualMachineSpecBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20201201VirtualMachineSpecDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary>
    /// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
    /// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
    /// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
    /// 2017-10-30-preview.
    /// </summary>
    [JsonPropertyName("evictionPolicy")]
    public V1api20201201VirtualMachineSpecEvictionPolicyEnum? EvictionPolicy { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201201VirtualMachineSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// ExtensionsTimeBudget: Specifies the time alloted for all extensions to start. The time duration should be between 15
    /// minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes
    /// (PT1H30M).
    /// Minimum api-version: 2020-06-01
    /// </summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>HardwareProfile: Specifies the hardware settings for the virtual machine.</summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20201201VirtualMachineSpecHardwareProfile? HardwareProfile { get; set; }

    /// <summary>
    /// Host: Specifies information about the dedicated host that the virtual machine resides in.
    /// Minimum api-version: 2018-10-01.
    /// </summary>
    [JsonPropertyName("host")]
    public V1api20201201VirtualMachineSpecHost? Host { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine resides in.
    /// Minimum api-version: 2020-06-01.
    /// NOTE: User cannot specify both host and hostGroup properties.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V1api20201201VirtualMachineSpecHostGroup? HostGroup { get; set; }

    /// <summary>Identity: The identity of the virtual machine, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20201201VirtualMachineSpecIdentity? Identity { get; set; }

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

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NetworkProfile: Specifies the network interfaces of the virtual machine.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20201201VirtualMachineSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201201VirtualMachineSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
    /// be changed once VM is provisioned.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V1api20201201VirtualMachineSpecOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201201VirtualMachineSpecOwner Owner { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V1api20201201VirtualMachineSpecPlan? Plan { get; set; }

    /// <summary>
    /// PlatformFaultDomain: Specifies the scale set logical fault domain into which the Virtual Machine will be created. By
    /// default, the Virtual Machine will by automatically assigned to a fault domain that best maintains balance across
    /// available fault domains.
    /// &lt;li&gt;This is applicable only if the &apos;virtualMachineScaleSet&apos; property of this Virtual Machine is set.&lt;li&gt;The Virtual
    /// Machine Scale Set that is referenced, must have &apos;platformFaultDomainCount&apos; &amp;gt; 1.&lt;li&gt;This property cannot be updated
    /// once the Virtual Machine is created.&lt;li&gt;Fault domain assignment can be viewed in the Virtual Machine Instance View.
    /// Minimum api‐version: 2020‐12‐01
    /// </summary>
    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    /// <summary>
    /// Priority: Specifies the priority for the virtual machine.
    /// Minimum api-version: 2019-03-01
    /// </summary>
    [JsonPropertyName("priority")]
    public V1api20201201VirtualMachineSpecPriorityEnum? Priority { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine should be
    /// assigned to.
    /// Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20201201VirtualMachineSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machine.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20201201VirtualMachineSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20201201VirtualMachineSpecStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
    /// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
    /// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
    /// cannot be added to a virtual machine scale set.
    /// This property cannot exist along with a non-null properties.availabilitySet reference.
    /// Minimum api‐version: 2019‐03‐01
    /// </summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20201201VirtualMachineSpecVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    /// <summary>Zones: The virtual machine zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusAdditionalCapabilities
{
    /// <summary>
    /// UltraSSDEnabled: The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS
    /// storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual
    /// machine or virtual machine scale set only if this property is enabled.
    /// </summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>
/// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
/// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
/// more information about availability sets, see [Manage the availability of virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in
/// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
/// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
/// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
/// availability set.
/// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusAvailabilitySet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusBillingProfile
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

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusConditions
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
/// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
/// diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusDiagnosticsProfileBootDiagnostics
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusDiagnosticsProfile
{
    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20201201VirtualMachineStatusDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HardwareProfile: Specifies the hardware settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusHardwareProfile
{
    /// <summary>
    /// VmSize: Specifies the size of the virtual machine.
    /// The enum data type is currently deprecated and will be removed by December 23rd 2023.
    /// Recommended way to get the list of available sizes is using these APIs:
    /// [List all available virtual machine sizes in an availability
    /// set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes)
    /// [List all available virtual machine sizes in a region](
    /// https://docs.microsoft.com/en-us/rest/api/compute/resourceskus/list)
    /// [List all available virtual machine sizes for
    /// resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes). For more information about
    /// virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/en-us/azure/virtual-machines/sizes).
    /// The available VM sizes depend on region and availability set.
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>
/// Host: Specifies information about the dedicated host that the virtual machine resides in.
/// Minimum api-version: 2018-10-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusHost
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// HostGroup: Specifies information about the dedicated host group that the virtual machine resides in.
/// Minimum api-version: 2020-06-01.
/// NOTE: User cannot specify both host and hostGroup properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusHostGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the virtual machine, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of virtual machine identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id associated with the virtual machine. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
    /// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
    /// virtual machine.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Virtual Machine. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20201201VirtualMachineStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Status: The boot diagnostics status information for the VM.
/// NOTE: It will be set only if there are errors encountered in enabling boot diagnostics.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewBootDiagnosticsStatus
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

/// <summary>
/// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
/// diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewBootDiagnostics
{
    /// <summary>
    /// ConsoleScreenshotBlobUri: The console screenshot blob URI.
    /// NOTE: This will not be set if boot diagnostics is currently enabled with managed storage.
    /// </summary>
    [JsonPropertyName("consoleScreenshotBlobUri")]
    public string? ConsoleScreenshotBlobUri { get; set; }

    /// <summary>
    /// SerialConsoleLogBlobUri: The serial console log blob Uri.
    /// NOTE: This will not be set if boot diagnostics is currently enabled with managed storage.
    /// </summary>
    [JsonPropertyName("serialConsoleLogBlobUri")]
    public string? SerialConsoleLogBlobUri { get; set; }

    /// <summary>
    /// Status: The boot diagnostics status information for the VM.
    /// NOTE: It will be set only if there are errors encountered in enabling boot diagnostics.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20201201VirtualMachineStatusInstanceViewBootDiagnosticsStatus? Status { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: The URL referencing a key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Describes a Encryption Settings for a Disk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Enabled: Specifies whether disk encryption should be enabled on the virtual machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisksStatuses
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

/// <summary>The instance view of the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewDisks
{
    /// <summary>
    /// EncryptionSettings: Specifies the encryption settings for the OS Disk.
    /// Minimum api-version: 2015-06-15
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewDisksEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewDisksStatuses>? Statuses { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewExtensionsStatuses
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

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewExtensionsSubstatuses
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

/// <summary>The instance view of a virtual machine extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewExtensions
{
    /// <summary>Name: The virtual machine extension name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewExtensionsStatuses>? Statuses { get; set; }

    /// <summary>Substatuses: The resource status information.</summary>
    [JsonPropertyName("substatuses")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewExtensionsSubstatuses>? Substatuses { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>MaintenanceRedeployStatus: The Maintenance Operation status on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewMaintenanceRedeployStatus
{
    /// <summary>IsCustomerInitiatedMaintenanceAllowed: True, if customer is allowed to perform Maintenance.</summary>
    [JsonPropertyName("isCustomerInitiatedMaintenanceAllowed")]
    public bool? IsCustomerInitiatedMaintenanceAllowed { get; set; }

    /// <summary>LastOperationMessage: Message returned for the last Maintenance Operation.</summary>
    [JsonPropertyName("lastOperationMessage")]
    public string? LastOperationMessage { get; set; }

    /// <summary>LastOperationResultCode: The Last Maintenance Operation Result Code.</summary>
    [JsonPropertyName("lastOperationResultCode")]
    public string? LastOperationResultCode { get; set; }

    /// <summary>MaintenanceWindowEndTime: End Time for the Maintenance Window.</summary>
    [JsonPropertyName("maintenanceWindowEndTime")]
    public string? MaintenanceWindowEndTime { get; set; }

    /// <summary>MaintenanceWindowStartTime: Start Time for the Maintenance Window.</summary>
    [JsonPropertyName("maintenanceWindowStartTime")]
    public string? MaintenanceWindowStartTime { get; set; }

    /// <summary>PreMaintenanceWindowEndTime: End Time for the Pre Maintenance Window.</summary>
    [JsonPropertyName("preMaintenanceWindowEndTime")]
    public string? PreMaintenanceWindowEndTime { get; set; }

    /// <summary>PreMaintenanceWindowStartTime: Start Time for the Pre Maintenance Window.</summary>
    [JsonPropertyName("preMaintenanceWindowStartTime")]
    public string? PreMaintenanceWindowStartTime { get; set; }
}

/// <summary>Api error base.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Innererror: The Api inner error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror
{
    /// <summary>Errordetail: The internal error message or exception dump.</summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary>Exceptiontype: The exception type.</summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The Api error details</summary>
    [JsonPropertyName("details")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails>? Details { get; set; }

    /// <summary>Innererror: The Api inner error</summary>
    [JsonPropertyName("innererror")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror? Innererror { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>AvailablePatchSummary: The available patch summary of the latest assessment operation for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary
{
    /// <summary>
    /// AssessmentActivityId: The activity ID of the operation that produced this result. It is used to correlate across CRP and
    /// extension logs.
    /// </summary>
    [JsonPropertyName("assessmentActivityId")]
    public string? AssessmentActivityId { get; set; }

    /// <summary>
    /// CriticalAndSecurityPatchCount: The number of critical or security patches that have been detected as available and not
    /// yet installed.
    /// </summary>
    [JsonPropertyName("criticalAndSecurityPatchCount")]
    public int? CriticalAndSecurityPatchCount { get; set; }

    /// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
    [JsonPropertyName("error")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError? Error { get; set; }

    /// <summary>LastModifiedTime: The UTC timestamp when the operation began.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>OtherPatchCount: The number of all available patches excluding critical and security.</summary>
    [JsonPropertyName("otherPatchCount")]
    public int? OtherPatchCount { get; set; }

    /// <summary>
    /// RebootPending: The overall reboot status of the VM. It will be true when partially installed patches require a reboot to
    /// complete installation but the reboot has not yet occurred.
    /// </summary>
    [JsonPropertyName("rebootPending")]
    public bool? RebootPending { get; set; }

    /// <summary>StartTime: The UTC timestamp when the operation began.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Status: The overall success or failure status of the operation. It remains &quot;InProgress&quot; until the operation completes.
    /// At that point it will become &quot;Unknown&quot;, &quot;Failed&quot;, &quot;Succeeded&quot;, or &quot;CompletedWithWarnings.&quot;
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses
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

/// <summary>Api error base.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Innererror: The Api inner error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror
{
    /// <summary>Errordetail: The internal error message or exception dump.</summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary>Exceptiontype: The exception type.</summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The Api error details</summary>
    [JsonPropertyName("details")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails>? Details { get; set; }

    /// <summary>Innererror: The Api inner error</summary>
    [JsonPropertyName("innererror")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror? Innererror { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>LastPatchInstallationSummary: The installation summary of the latest installation operation for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary
{
    /// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
    [JsonPropertyName("error")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError? Error { get; set; }

    /// <summary>
    /// ExcludedPatchCount: The number of all available patches but excluded explicitly by a customer-specified exclusion list
    /// match.
    /// </summary>
    [JsonPropertyName("excludedPatchCount")]
    public int? ExcludedPatchCount { get; set; }

    /// <summary>FailedPatchCount: The count of patches that failed installation.</summary>
    [JsonPropertyName("failedPatchCount")]
    public int? FailedPatchCount { get; set; }

    /// <summary>
    /// InstallationActivityId: The activity ID of the operation that produced this result. It is used to correlate across CRP
    /// and extension logs.
    /// </summary>
    [JsonPropertyName("installationActivityId")]
    public string? InstallationActivityId { get; set; }

    /// <summary>InstalledPatchCount: The count of patches that successfully installed.</summary>
    [JsonPropertyName("installedPatchCount")]
    public int? InstalledPatchCount { get; set; }

    /// <summary>LastModifiedTime: The UTC timestamp when the operation began.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>MaintenanceWindowExceeded: Describes whether the operation ran out of time before it completed all its intended actions</summary>
    [JsonPropertyName("maintenanceWindowExceeded")]
    public bool? MaintenanceWindowExceeded { get; set; }

    /// <summary>
    /// NotSelectedPatchCount: The number of all available patches but not going to be installed because it didn&apos;t match a
    /// classification or inclusion list entry.
    /// </summary>
    [JsonPropertyName("notSelectedPatchCount")]
    public int? NotSelectedPatchCount { get; set; }

    /// <summary>
    /// PendingPatchCount: The number of all available patches expected to be installed over the course of the patch
    /// installation operation.
    /// </summary>
    [JsonPropertyName("pendingPatchCount")]
    public int? PendingPatchCount { get; set; }

    /// <summary>StartTime: The UTC timestamp when the operation began.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// Status: The overall success or failure status of the operation. It remains &quot;InProgress&quot; until the operation completes.
    /// At that point it will become &quot;Unknown&quot;, &quot;Failed&quot;, &quot;Succeeded&quot;, or &quot;CompletedWithWarnings.&quot;
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PatchStatus: [Preview Feature] The status of virtual machine patch operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewPatchStatus
{
    /// <summary>AvailablePatchSummary: The available patch summary of the latest assessment operation for the virtual machine.</summary>
    [JsonPropertyName("availablePatchSummary")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary? AvailablePatchSummary { get; set; }

    /// <summary>ConfigurationStatuses: The enablement status of the specified patchMode</summary>
    [JsonPropertyName("configurationStatuses")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses>? ConfigurationStatuses { get; set; }

    /// <summary>LastPatchInstallationSummary: The installation summary of the latest installation operation for the virtual machine.</summary>
    [JsonPropertyName("lastPatchInstallationSummary")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary? LastPatchInstallationSummary { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewStatuses
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

/// <summary>Status: The extension handler status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus
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

/// <summary>The instance view of a virtual machine extension handler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewVmAgentExtensionHandlers
{
    /// <summary>Status: The extension handler status.</summary>
    [JsonPropertyName("status")]
    public V1api20201201VirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus? Status { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewVmAgentStatuses
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

/// <summary>VmAgent: The VM Agent running on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewVmAgent
{
    /// <summary>ExtensionHandlers: The virtual machine extension handler instance view.</summary>
    [JsonPropertyName("extensionHandlers")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewVmAgentExtensionHandlers>? ExtensionHandlers { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewVmAgentStatuses>? Statuses { get; set; }

    /// <summary>VmAgentVersion: The VM Agent full version.</summary>
    [JsonPropertyName("vmAgentVersion")]
    public string? VmAgentVersion { get; set; }
}

/// <summary>Status: The health status information for the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewVmHealthStatus
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

/// <summary>VmHealth: The health status for the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceViewVmHealth
{
    /// <summary>Status: The health status information for the VM.</summary>
    [JsonPropertyName("status")]
    public V1api20201201VirtualMachineStatusInstanceViewVmHealthStatus? Status { get; set; }
}

/// <summary>InstanceView: The virtual machine instance view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusInstanceView
{
    /// <summary>
    /// AssignedHost: Resource id of the dedicated host, on which the virtual machine is allocated through automatic placement,
    /// when the virtual machine is associated with a dedicated host group that has automatic placement enabled.
    /// Minimum api-version: 2020-06-01.
    /// </summary>
    [JsonPropertyName("assignedHost")]
    public string? AssignedHost { get; set; }

    /// <summary>
    /// BootDiagnostics: Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to
    /// diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20201201VirtualMachineStatusInstanceViewBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>ComputerName: The computer name assigned to the virtual machine.</summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>Disks: The virtual machine disk information.</summary>
    [JsonPropertyName("disks")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewDisks>? Disks { get; set; }

    /// <summary>Extensions: The extensions information.</summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewExtensions>? Extensions { get; set; }

    /// <summary>HyperVGeneration: Specifies the HyperVGeneration Type associated with a resource</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>MaintenanceRedeployStatus: The Maintenance Operation status on the virtual machine.</summary>
    [JsonPropertyName("maintenanceRedeployStatus")]
    public V1api20201201VirtualMachineStatusInstanceViewMaintenanceRedeployStatus? MaintenanceRedeployStatus { get; set; }

    /// <summary>OsName: The Operating System running on the virtual machine.</summary>
    [JsonPropertyName("osName")]
    public string? OsName { get; set; }

    /// <summary>OsVersion: The version of Operating System running on the virtual machine.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }

    /// <summary>PatchStatus: [Preview Feature] The status of virtual machine patch operations.</summary>
    [JsonPropertyName("patchStatus")]
    public V1api20201201VirtualMachineStatusInstanceViewPatchStatus? PatchStatus { get; set; }

    /// <summary>PlatformFaultDomain: Specifies the fault domain of the virtual machine.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    /// <summary>PlatformUpdateDomain: Specifies the update domain of the virtual machine.</summary>
    [JsonPropertyName("platformUpdateDomain")]
    public int? PlatformUpdateDomain { get; set; }

    /// <summary>RdpThumbPrint: The Remote desktop certificate thumbprint.</summary>
    [JsonPropertyName("rdpThumbPrint")]
    public string? RdpThumbPrint { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20201201VirtualMachineStatusInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>VmAgent: The VM Agent running on the virtual machine.</summary>
    [JsonPropertyName("vmAgent")]
    public V1api20201201VirtualMachineStatusInstanceViewVmAgent? VmAgent { get; set; }

    /// <summary>VmHealth: The health status for the VM.</summary>
    [JsonPropertyName("vmHealth")]
    public V1api20201201VirtualMachineStatusInstanceViewVmHealth? VmHealth { get; set; }
}

/// <summary>Describes a network interface reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusNetworkProfileNetworkInterfaces
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>NetworkProfile: Specifies the network interfaces of the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusNetworkProfile
{
    /// <summary>NetworkInterfaces: Specifies the list of resource Ids for the network interfaces associated with the virtual machine.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20201201VirtualMachineStatusNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileLinuxConfigurationPatchSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20201201VirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201VirtualMachineStatusOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V1api20201201VirtualMachineStatusOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileSecretsSourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileSecretsVaultCertificates
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201VirtualMachineStatusOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20201201VirtualMachineStatusOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationPatchSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

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
    public V1api20201201VirtualMachineStatusOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
/// be changed once VM is provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusOsProfile
{
    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// This property cannot be updated after the VM is created.
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
    /// AllowExtensionOperations: Specifies whether extension operations should be allowed on the virtual machine.
    /// This may only be set to False when no extensions are present on the virtual machine.
    /// </summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary>
    /// ComputerName: Specifies the host OS name of the virtual machine.
    /// This name cannot be updated after the VM is created.
    /// Max-length (Windows): 15 characters
    /// Max-length (Linux): 64 characters.
    /// For naming conventions and restrictions see [Azure infrastructure services implementation
    /// guidelines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-infrastructure-subscription-accounts-guidelines?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json#1-naming-conventions).
    /// </summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>
    /// CustomData: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array
    /// that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.
    /// Note: Do not pass any secrets or passwords in customData property
    /// This property cannot be updated after the VM is created.
    /// customData is passed to the VM to be saved as a file, for more information see [Custom Data on Azure
    /// VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/)
    /// For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during
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
    public V1api20201201VirtualMachineStatusOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>
    /// RequireGuestProvisionSignal: Specifies whether the guest provision signal is required to infer provision success of the
    /// virtual machine.  Note: This property is for private testing only, and all customers must not set the property to false.
    /// </summary>
    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    /// <summary>Secrets: Specifies set of certificates that should be installed onto the virtual machine.</summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20201201VirtualMachineStatusOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20201201VirtualMachineStatusOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
/// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
/// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
/// programmatically, Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusPlan
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
/// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine should be
/// assigned to.
/// Minimum api-version: 2018-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusProximityPlacementGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusResourcesInstanceViewStatuses
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

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusResourcesInstanceViewSubstatuses
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

/// <summary>InstanceView: The virtual machine extension instance view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusResourcesInstanceView
{
    /// <summary>Name: The virtual machine extension name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20201201VirtualMachineStatusResourcesInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>Substatuses: The resource status information.</summary>
    [JsonPropertyName("substatuses")]
    public IList<V1api20201201VirtualMachineStatusResourcesInstanceViewSubstatuses>? Substatuses { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Describes a Virtual Machine Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusResources
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

    /// <summary>ForceUpdateTag: How the extension handler should be forced to update even if the extension configuration has not changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InstanceView: The virtual machine extension instance view.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20201201VirtualMachineStatusResourcesInstanceView? InstanceView { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PropertiesType: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>ProvisioningState: The provisioning state, which only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Publisher: The name of the extension handler publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Settings: Json formatted public settings for the extension.</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusSecurityProfileUefiSettings
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

/// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusSecurityProfile
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
    public V1api20201201VirtualMachineStatusSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileDataDisksImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201VirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. Managed OS disk storage account type can
    /// only be set when you create the scale set. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with
    /// OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileDataDisksVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileDataDisks
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
    /// CreateOption: Specifies how the virtual machine should be created.
    /// Possible values are:
    /// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
    /// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
    /// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
    /// use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// DetachOption: Specifies the detach behavior to be used while detaching a disk or which is already in the process of
    /// detachment from the virtual machine. Supported values: ForceDetach.
    /// detachOption: ForceDetach is applicable only for managed data disks. If a previous detachment attempt of the data disk
    /// did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use
    /// force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed
    /// when using this detach behavior.
    /// This feature is still in preview mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk
    /// update toBeDetached to &apos;true&apos; along with setting detachOption: &apos;ForceDetach&apos;.
    /// </summary>
    [JsonPropertyName("detachOption")]
    public string? DetachOption { get; set; }

    /// <summary>
    /// DiskIOPSReadWrite: Specifies the Read-Write IOPS for the managed disk when StorageAccountType is UltraSSD_LRS. Returned
    /// only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine Scale Set.
    /// </summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary>
    /// DiskMBpsReadWrite: Specifies the bandwidth in MB per second for the managed disk when StorageAccountType is
    /// UltraSSD_LRS. Returned only for VirtualMachine ScaleSet VM disks. Can be updated only via updates to the VirtualMachine
    /// Scale Set.
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
    /// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
    /// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201VirtualMachineStatusStorageProfileDataDisksImage? Image { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201VirtualMachineStatusStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ToBeDetached: Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset</summary>
    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20201201VirtualMachineStatusStorageProfileDataDisksVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// ImageReference: Specifies information about the image to use. You can specify information about platform images,
/// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
/// marketplace image, or virtual machine image, but is not used in other creation operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileImageReference
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

/// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskDiffDiskSettings
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

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: The URL referencing a key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// EncryptionSettings: Specifies the encryption settings for the OS Disk.
/// Minimum api-version: 2015-06-15
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Enabled: Specifies whether disk encryption should be enabled on the virtual machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedDisk: The managed disk parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. Managed OS disk storage account type can
    /// only be set when you create the scale set. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with
    /// OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDiskVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machine.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfileOsDisk
{
    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage.
    /// </summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machine should be created.
    /// Possible values are:
    /// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
    /// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
    /// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
    /// use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// EncryptionSettings: Specifies the encryption settings for the OS Disk.
    /// Minimum api-version: 2015-06-15
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
    /// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

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

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDiskVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add a data disk to a virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20201201VirtualMachineStatusStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20201201VirtualMachineStatusStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V1api20201201VirtualMachineStatusStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>
/// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
/// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
/// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
/// cannot be added to a virtual machine scale set.
/// This property cannot exist along with a non-null properties.availabilitySet reference.
/// Minimum api‐version: 2019‐03‐01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatusVirtualMachineScaleSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201VirtualMachineStatus
{
    /// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20201201VirtualMachineStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>
    /// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
    /// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
    /// more information about availability sets, see [Manage the availability of virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
    /// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
    /// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
    /// availability set.
    /// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
    /// </summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20201201VirtualMachineStatusAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V1api20201201VirtualMachineStatusBillingProfile? BillingProfile { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201201VirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20201201VirtualMachineStatusDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary>
    /// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
    /// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
    /// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
    /// 2017-10-30-preview.
    /// </summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201201VirtualMachineStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// ExtensionsTimeBudget: Specifies the time alloted for all extensions to start. The time duration should be between 15
    /// minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes
    /// (PT1H30M).
    /// Minimum api-version: 2020-06-01
    /// </summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>HardwareProfile: Specifies the hardware settings for the virtual machine.</summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20201201VirtualMachineStatusHardwareProfile? HardwareProfile { get; set; }

    /// <summary>
    /// Host: Specifies information about the dedicated host that the virtual machine resides in.
    /// Minimum api-version: 2018-10-01.
    /// </summary>
    [JsonPropertyName("host")]
    public V1api20201201VirtualMachineStatusHost? Host { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine resides in.
    /// Minimum api-version: 2020-06-01.
    /// NOTE: User cannot specify both host and hostGroup properties.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V1api20201201VirtualMachineStatusHostGroup? HostGroup { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the virtual machine, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20201201VirtualMachineStatusIdentity? Identity { get; set; }

    /// <summary>InstanceView: The virtual machine instance view.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20201201VirtualMachineStatusInstanceView? InstanceView { get; set; }

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

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: Specifies the network interfaces of the virtual machine.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20201201VirtualMachineStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
    /// be changed once VM is provisioned.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V1api20201201VirtualMachineStatusOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V1api20201201VirtualMachineStatusPlan? Plan { get; set; }

    /// <summary>
    /// PlatformFaultDomain: Specifies the scale set logical fault domain into which the Virtual Machine will be created. By
    /// default, the Virtual Machine will by automatically assigned to a fault domain that best maintains balance across
    /// available fault domains.
    /// &lt;li&gt;This is applicable only if the &apos;virtualMachineScaleSet&apos; property of this Virtual Machine is set.&lt;li&gt;The Virtual
    /// Machine Scale Set that is referenced, must have &apos;platformFaultDomainCount&apos; &amp;gt; 1.&lt;li&gt;This property cannot be updated
    /// once the Virtual Machine is created.&lt;li&gt;Fault domain assignment can be viewed in the Virtual Machine Instance View.
    /// Minimum api‐version: 2020‐12‐01
    /// </summary>
    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    /// <summary>
    /// Priority: Specifies the priority for the virtual machine.
    /// Minimum api-version: 2019-03-01
    /// </summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>ProvisioningState: The provisioning state, which only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine should be
    /// assigned to.
    /// Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20201201VirtualMachineStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>Resources: The virtual machine child extension resources.</summary>
    [JsonPropertyName("resources")]
    public IList<V1api20201201VirtualMachineStatusResources>? Resources { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machine.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20201201VirtualMachineStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20201201VirtualMachineStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
    /// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
    /// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
    /// cannot be added to a virtual machine scale set.
    /// This property cannot exist along with a non-null properties.availabilitySet reference.
    /// Minimum api‐version: 2019‐03‐01
    /// </summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20201201VirtualMachineStatusVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    /// <summary>
    /// VmId: Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS
    /// and can be read using platform BIOS commands.
    /// </summary>
    [JsonPropertyName("vmId")]
    public string? VmId { get; set; }

    /// <summary>Zones: The virtual machine zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201201VirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201201VirtualMachineSpec?>, IStatus<V1api20201201VirtualMachineStatus?>
{
    public const string KubeApiVersion = "v1api20201201";
    public const string KubeKind = "VirtualMachine";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20201201";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20201201VirtualMachineSpec? Spec { get; set; }

    /// <summary>Describes a Virtual Machine.</summary>
    [JsonPropertyName("status")]
    public V1api20201201VirtualMachineStatus? Status { get; set; }
}