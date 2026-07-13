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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachine.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301VirtualMachineList : IKubernetesObject<V1ListMeta>, IItems<V1api20220301VirtualMachine>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "VirtualMachineList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220301VirtualMachine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220301VirtualMachine> Items { get; set; }
}

/// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecAdditionalCapabilities
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
/// PackageReferenceReference: Specifies the GalleryApplicationVersion resource id on the form of
/// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecApplicationProfileGalleryApplicationsPackageReferenceReference
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
public partial class V1api20220301VirtualMachineSpecApplicationProfileGalleryApplications
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
    public required V1api20220301VirtualMachineSpecApplicationProfileGalleryApplicationsPackageReferenceReference PackageReferenceReference { get; set; }

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
public partial class V1api20220301VirtualMachineSpecApplicationProfile
{
    /// <summary>GalleryApplications: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1api20220301VirtualMachineSpecApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecAvailabilitySetReference
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
/// more information about availability sets, see [Availability sets
/// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview).
/// For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in
/// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates)
/// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
/// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
/// availability set.
/// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecAvailabilitySet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecAvailabilitySetReference? Reference { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecBillingProfile
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
public partial class V1api20220301VirtualMachineSpecCapacityReservationCapacityReservationGroupReference
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
public partial class V1api20220301VirtualMachineSpecCapacityReservationCapacityReservationGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecCapacityReservationCapacityReservationGroupReference? Reference { get; set; }
}

/// <summary>
/// CapacityReservation: Specifies information about the capacity reservation that is used to allocate virtual machine.
/// Minimum api-version: 2021-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecCapacityReservation
{
    /// <summary>
    /// CapacityReservationGroup: Specifies the capacity reservation group resource id that should be used for allocating the
    /// virtual machine or scaleset vm instances provided enough capacity has been reserved. Please refer to
    /// https://aka.ms/CapacityReservation for more details.
    /// </summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V1api20220301VirtualMachineSpecCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
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
public partial class V1api20220301VirtualMachineSpecDiagnosticsProfileBootDiagnostics
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
public partial class V1api20220301VirtualMachineSpecDiagnosticsProfile
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
    public V1api20220301VirtualMachineSpecDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
/// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
/// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
/// 2017-10-30-preview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecEvictionPolicyEnum>))]
public enum V1api20220301VirtualMachineSpecEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecExtendedLocationTypeEnum>))]
public enum V1api20220301VirtualMachineSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20220301VirtualMachineSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>
/// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
/// 2021-07-01.
/// This feature is still in preview mode and is not supported for VirtualMachineScaleSet.
/// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecHardwareProfileVmSizeProperties
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

/// <summary>HardwareProfile: Specifies the hardware settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecHardwareProfile
{
    /// <summary>
    /// VmSize: Specifies the size of the virtual machine.
    /// The enum data type is currently deprecated and will be removed by December 23rd 2023.
    /// Recommended way to get the list of available sizes is using these APIs:
    /// [List all available virtual machine sizes in an availability
    /// set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes)
    /// [List all available virtual machine sizes in a region]( https://docs.microsoft.com/rest/api/compute/resourceskus/list)
    /// [List all available virtual machine sizes for
    /// resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes). For more information about
    /// virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/azure/virtual-machines/sizes).
    /// The available VM sizes depend on region and availability set.
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
    /// 2021-07-01.
    /// This feature is still in preview mode and is not supported for VirtualMachineScaleSet.
    /// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
    /// </summary>
    [JsonPropertyName("vmSizeProperties")]
    public V1api20220301VirtualMachineSpecHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecHostReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecHost
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecHostReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecHostGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecHostGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecHostGroupReference? Reference { get; set; }
}

/// <summary>
/// Type: The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
/// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
/// virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecIdentityTypeEnum>))]
public enum V1api20220301VirtualMachineSpecIdentityTypeEnum
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
public partial class V1api20220301VirtualMachineSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20220301VirtualMachineSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the virtual machine, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the virtual machine. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
    /// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
    /// virtual machine.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20220301VirtualMachineSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Virtual Machine. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220301VirtualMachineSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// NetworkApiVersion: specifies the Microsoft.Network API version used when creating networking resources in the Network
/// Interface Configurations
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkApiVersionEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkApiVersionEnum
{
    [EnumMember(Value = "2020-11-01"), JsonStringEnumMemberName("2020-11-01")]
    _20201101
}

/// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDeleteOptionEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>DnsServers: List of DNS servers IP addresses</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfigurationReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>
/// PrivateIPAddressVersion: Available from Api-Version 2017-03-30 onwards, it represents whether the specific
/// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>DeleteOption: Specify what happens to the public IP address when the VM is deleted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDeleteOptionEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>
    /// DomainNameLabel: The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name
    /// label is the concatenation of the domain name label and vm network profile unique ID.
    /// </summary>
    [JsonPropertyName("domainNameLabel")]
    public required string DomainNameLabel { get; set; }
}

/// <summary>Contains the IP tag associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>PublicIPAllocationMethod: Specify the public IP allocation type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAllocationMethodEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Name: Specify public IP sku name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuNameEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Tier: Specify public IP sku tier</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuTierEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuTierEnum
{
    [EnumMember(Value = "Global"), JsonStringEnumMemberName("Global")]
    Global,
    [EnumMember(Value = "Regional"), JsonStringEnumMemberName("Regional")]
    Regional
}

/// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
{
    /// <summary>Name: Specify public IP sku name</summary>
    [JsonPropertyName("name")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Specify public IP sku tier</summary>
    [JsonPropertyName("tier")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSkuTierEnum? Tier { get; set; }
}

/// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>DeleteOption: Specify what happens to the public IP address when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpTags: The list of IP tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary>Name: The publicIP address configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// PublicIPAddressVersion: Available from Api-Version 2019-07-01 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAddressVersionEnum? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPAllocationMethod: Specify the public IP allocation type</summary>
    [JsonPropertyName("publicIPAllocationMethod")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPAllocationMethodEnum? PublicIPAllocationMethod { get; set; }

    /// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Describes a virtual machine network profile&apos;s IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// ApplicationGatewayBackendAddressPools: Specifies an array of references to backend address pools of application
    /// gateways. A virtual machine can reference backend address pools of multiple application gateways. Multiple virtual
    /// machines cannot use the same application gateway.
    /// </summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Specifies an array of references to application security group.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>
    /// LoadBalancerBackendAddressPools: Specifies an array of references to backend address pools of load balancers. A virtual
    /// machine can reference backend address pools of one public and one internal load balancer. [Multiple virtual machines
    /// cannot use the same basic sku load balancer].
    /// </summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

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
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPrivateIPAddressVersionEnum? PrivateIPAddressVersion { get; set; }

    /// <summary>PublicIPAddressConfiguration: The publicIPAddressConfiguration.</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Subnet: Specifies the identifier of the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference
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
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>Describes a virtual machine network interface configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("dscpConfiguration")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration? DscpConfiguration { get; set; }

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
    public required IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurations> IpConfigurations { get; set; }

    /// <summary>Name: The network interface configuration name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NetworkSecurityGroup: The network security group.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfacesDeleteOptionEnum>))]
public enum V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfacesDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfacesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaces
{
    /// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfacesDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfacesReference? Reference { get; set; }
}

/// <summary>NetworkProfile: Specifies the network interfaces of the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecNetworkProfile
{
    /// <summary>
    /// NetworkApiVersion: specifies the Microsoft.Network API version used when creating networking resources in the Network
    /// Interface Configurations
    /// </summary>
    [JsonPropertyName("networkApiVersion")]
    public V1api20220301VirtualMachineSpecNetworkProfileNetworkApiVersionEnum? NetworkApiVersion { get; set; }

    /// <summary>
    /// NetworkInterfaceConfigurations: Specifies the networking configurations that will be used to create the virtual machine
    /// networking resources.
    /// </summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }

    /// <summary>NetworkInterfaces: Specifies the list of resource Ids for the network interfaces associated with the virtual machine.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20220301VirtualMachineSpecNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220301VirtualMachineSpecOperatorSpecSecretExpressions
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
public partial class V1api20220301VirtualMachineSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220301VirtualMachineSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220301VirtualMachineSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
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
public partial class V1api20220301VirtualMachineSpecOsProfileAdminPassword
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAssessmentModeEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAssessmentModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum
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
public partial class V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum? RebootSetting { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsPatchModeEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsPatchModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>
    /// AssessmentMode: Specifies the mode of VM Guest Patch Assessment for the IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - You control the timing of patch assessments on a virtual machine.
    /// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
    /// </summary>
    [JsonPropertyName("assessmentMode")]
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAssessmentModeEnum? AssessmentMode { get; set; }

    /// <summary>
    /// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
    /// Linux.
    /// </summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary>
    /// PatchMode: Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual machines associated to virtual
    /// machine scale set with OrchestrationMode as Flexible.
    /// Possible values are:
    /// ImageDefault - The virtual machine&apos;s default patching configuration is used.
    /// AutomaticByPlatform - The virtual machine will be automatically updated by the platform. The property provisionVMAgent
    /// must be true
    /// </summary>
    [JsonPropertyName("patchMode")]
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys
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
public partial class V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileSecretsSourceVaultReference
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
public partial class V1api20220301VirtualMachineSpecOsProfileSecretsSourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileSecretsVaultCertificates
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
public partial class V1api20220301VirtualMachineSpecOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineSpecOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20220301VirtualMachineSpecOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum
{
    [EnumMember(Value = "Microsoft-Windows-Shell-Setup"), JsonStringEnumMemberName("Microsoft-Windows-Shell-Setup")]
    MicrosoftWindowsShellSetup
}

/// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum
{
    [EnumMember(Value = "OobeSystem"), JsonStringEnumMemberName("OobeSystem")]
    OobeSystem
}

/// <summary>
/// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
/// AutoLogon.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum
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
public partial class V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>ComponentName: The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.</summary>
    [JsonPropertyName("componentName")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentComponentNameEnum? ComponentName { get; set; }

    /// <summary>
    /// Content: Specifies the XML formatted content that is added to the unattend.xml file for the specified path and
    /// component. The XML must be less than 4KB and must include the root element for the setting or feature that is being
    /// inserted.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>PassName: The pass name. Currently, the only allowable value is OobeSystem.</summary>
    [JsonPropertyName("passName")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentPassNameEnum? PassName { get; set; }

    /// <summary>
    /// SettingName: Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and
    /// AutoLogon.
    /// </summary>
    [JsonPropertyName("settingName")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContentSettingNameEnum? SettingName { get; set; }
}

/// <summary>
/// AssessmentMode: Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.
/// Possible values are:
/// ImageDefault - You control the timing of patch assessments on a virtual machine.
/// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAssessmentModeEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAssessmentModeEnum
{
    [EnumMember(Value = "AutomaticByPlatform"), JsonStringEnumMemberName("AutomaticByPlatform")]
    AutomaticByPlatform,
    [EnumMember(Value = "ImageDefault"), JsonStringEnumMemberName("ImageDefault")]
    ImageDefault
}

/// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum
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
public partial class V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSettingEnum? RebootSetting { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsPatchModeEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsPatchModeEnum
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
public partial class V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>
    /// AssessmentMode: Specifies the mode of VM Guest patch assessment for the IaaS virtual machine.
    /// Possible values are:
    /// ImageDefault - You control the timing of patch assessments on a virtual machine.
    /// AutomaticByPlatform - The platform will trigger periodic patch assessments. The property provisionVMAgent must be true.
    /// </summary>
    [JsonPropertyName("assessmentMode")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAssessmentModeEnum? AssessmentMode { get; set; }

    /// <summary>
    /// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
    /// Windows.
    /// </summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

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
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsPatchModeEnum? PatchMode { get; set; }
}

/// <summary>
/// Protocol: Specifies the protocol of WinRM listener.
/// Possible values are:
/// http
/// https
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRMListenersProtocolEnum>))]
public enum V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRMListenersProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

/// <summary>Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners
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
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRMListenersProtocolEnum? Protocol { get; set; }
}

/// <summary>WinRM: Specifies the Windows Remote Management listeners. This enables remote Windows PowerShell.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

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
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
/// be changed once VM is provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOsProfile
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
    public V1api20220301VirtualMachineSpecOsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// This property cannot be updated after the VM is created.
    /// Windows-only restriction: Cannot end in &quot;.&quot;
    /// Disallowed values: &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;,
    /// &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;,
    /// &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;.
    /// Minimum-length (Linux): 1  character
    /// Max-length (Linux): 64 characters
    /// Max-length (Windows): 20 characters.
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
    /// guidelines](https://docs.microsoft.com/azure/azure-resource-manager/management/resource-name-rules).
    /// </summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>
    /// CustomData: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array
    /// that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.
    /// Note: Do not pass any secrets or passwords in customData property
    /// This property cannot be updated after the VM is created.
    /// customData is passed to the VM to be saved as a file, for more information see [Custom Data on Azure
    /// VMs](https://azure.microsoft.com/blog/custom-data-and-cloud-init-on-windows-azure/)
    /// For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during
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
    public V1api20220301VirtualMachineSpecOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>RequireGuestProvisionSignal: Optional property which must either be set to True or omitted.</summary>
    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    /// <summary>
    /// Secrets: Specifies set of certificates that should be installed onto the virtual machine. To install certificates on a
    /// virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20220301VirtualMachineSpecOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20220301VirtualMachineSpecOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecOwner
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
public partial class V1api20220301VirtualMachineSpecPlan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecPriorityEnum>))]
public enum V1api20220301VirtualMachineSpecPriorityEnum
{
    [EnumMember(Value = "Low"), JsonStringEnumMemberName("Low")]
    Low,
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecProximityPlacementGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecProximityPlacementGroup
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecScheduledEventsProfileTerminateNotificationProfile
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
public partial class V1api20220301VirtualMachineSpecScheduledEventsProfile
{
    /// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V1api20220301VirtualMachineSpecScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// SecurityType: Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable
/// UefiSettings.
/// Default: UefiSettings will not be enabled unless this property is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecSecurityProfileSecurityTypeEnum>))]
public enum V1api20220301VirtualMachineSpecSecurityProfileSecurityTypeEnum
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
public partial class V1api20220301VirtualMachineSpecSecurityProfileUefiSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecSecurityProfile
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
    public V1api20220301VirtualMachineSpecSecurityProfileSecurityTypeEnum? SecurityType { get; set; }

    /// <summary>
    /// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V1api20220301VirtualMachineSpecSecurityProfileUefiSettings? UefiSettings { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileDataDisksCachingEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileDataDisksCachingEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileDataDisksCreateOptionEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileDataDisksCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>
/// DeleteOption: Specifies whether data disk should be deleted or detached upon VM deletion.
/// Possible values:
/// Delete If this value is used, the data disk is deleted when VM is deleted.
/// Detach If this value is used, the data disk is retained after VM is deleted.
/// The default value is set to detach
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileDataDisksDeleteOptionEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileDataDisksDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileDataDisksDetachOptionEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileDataDisksDetachOptionEnum
{
    [EnumMember(Value = "ForceDetach"), JsonStringEnumMemberName("ForceDetach")]
    ForceDetach
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskReference
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

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference
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
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
/// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
/// for encryption of just the VMGuestState blob.
/// NOTE: It can be set for only Confidential VMs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileSecurityEncryptionTypeEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileSecurityEncryptionTypeEnum
{
    [EnumMember(Value = "DiskWithVMGuestState"), JsonStringEnumMemberName("DiskWithVMGuestState")]
    DiskWithVMGuestState,
    [EnumMember(Value = "VMGuestStateOnly"), JsonStringEnumMemberName("VMGuestStateOnly")]
    VMGuestStateOnly
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
    /// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
    /// for encryption of just the VMGuestState blob.
    /// NOTE: It can be set for only Confidential VMs.
    /// </summary>
    [JsonPropertyName("securityEncryptionType")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileSecurityEncryptionTypeEnum? SecurityEncryptionType { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskStorageAccountTypeEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskStorageAccountTypeEnum
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
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskReference? Reference { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisksVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileDataDisks
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
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksCachingEnum? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machine should be created.
    /// Possible values are:
    /// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
    /// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
    /// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
    /// use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public required V1api20220301VirtualMachineSpecStorageProfileDataDisksCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DeleteOption: Specifies whether data disk should be deleted or detached upon VM deletion.
    /// Possible values:
    /// Delete If this value is used, the data disk is deleted when VM is deleted.
    /// Detach If this value is used, the data disk is retained after VM is deleted.
    /// The default value is set to detach
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksDeleteOptionEnum? DeleteOption { get; set; }

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
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksDetachOptionEnum? DetachOption { get; set; }

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
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksImage? Image { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public required int Lun { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ToBeDetached: Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset</summary>
    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301VirtualMachineSpecStorageProfileDataDisksVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileImageReferenceReference
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
public partial class V1api20220301VirtualMachineSpecStorageProfileImageReference
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
    public V1api20220301VirtualMachineSpecStorageProfileImageReferenceReference? Reference { get; set; }

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
/// Default: None for Standard storage. ReadOnly for Premium storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskCachingEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskCachingEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskCreateOptionEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage
}

/// <summary>
/// DeleteOption: Specifies whether OS Disk should be deleted or detached upon VM deletion.
/// Possible values:
/// Delete If this value is used, the OS disk is deleted when VM is deleted.
/// Detach If this value is used, the os disk is retained after VM is deleted.
/// The default value is set to detach. For an ephemeral OS Disk, the default value is set to Delete. User cannot change the
/// delete option for ephemeral OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskDeleteOptionEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsOptionEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsOptionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsPlacementEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsPlacementEnum
{
    [EnumMember(Value = "CacheDisk"), JsonStringEnumMemberName("CacheDisk")]
    CacheDisk,
    [EnumMember(Value = "ResourceDisk"), JsonStringEnumMemberName("ResourceDisk")]
    ResourceDisk
}

/// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>Option: Specifies the ephemeral disk settings for operating system disk.</summary>
    [JsonPropertyName("option")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsOptionEnum? Option { get; set; }

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
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettingsPlacementEnum? Placement { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference
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
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public required string SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: The URL referencing a key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyUrl")]
    public required string KeyUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>
/// EncryptionSettings: Specifies the encryption settings for the OS Disk.
/// Minimum api-version: 2015-06-15
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Enabled: Specifies whether disk encryption should be enabled on the virtual machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskReference
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

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference
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
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>
/// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
/// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
/// for encryption of just the VMGuestState blob.
/// NOTE: It can be set for only Confidential VMs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileSecurityEncryptionTypeEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileSecurityEncryptionTypeEnum
{
    [EnumMember(Value = "DiskWithVMGuestState"), JsonStringEnumMemberName("DiskWithVMGuestState")]
    DiskWithVMGuestState,
    [EnumMember(Value = "VMGuestStateOnly"), JsonStringEnumMemberName("VMGuestStateOnly")]
    VMGuestStateOnly
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// SecurityEncryptionType: Specifies the EncryptionType of the managed disk.
    /// It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly
    /// for encryption of just the VMGuestState blob.
    /// NOTE: It can be set for only Confidential VMs.
    /// </summary>
    [JsonPropertyName("securityEncryptionType")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileSecurityEncryptionTypeEnum? SecurityEncryptionType { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskStorageAccountTypeEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskStorageAccountTypeEnum
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
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskReference? Reference { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>
/// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from
/// user-image or a specialized VHD.
/// Possible values are:
/// Windows
/// Linux
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220301VirtualMachineSpecStorageProfileOsDiskOsTypeEnum>))]
public enum V1api20220301VirtualMachineSpecStorageProfileOsDiskOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDiskVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machine.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfileOsDisk
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
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskCachingEnum? Caching { get; set; }

    /// <summary>
    /// CreateOption: Specifies how the virtual machine should be created.
    /// Possible values are:
    /// Attach \u2013 This value is used when you are using a specialized disk to create the virtual machine.
    /// FromImage \u2013 This value is used when you are using an image to create the virtual machine. If you are using a
    /// platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also
    /// use the plan element previously described.
    /// </summary>
    [JsonPropertyName("createOption")]
    public required V1api20220301VirtualMachineSpecStorageProfileOsDiskCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// DeleteOption: Specifies whether OS Disk should be deleted or detached upon VM deletion.
    /// Possible values:
    /// Delete If this value is used, the OS disk is deleted when VM is deleted.
    /// Detach If this value is used, the os disk is retained after VM is deleted.
    /// The default value is set to detach. For an ephemeral OS Disk, the default value is set to Delete. User cannot change the
    /// delete option for ephemeral OS Disk.
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

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
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
    /// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

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
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskOsTypeEnum? OsType { get; set; }

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDiskVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add a data disk to a virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20220301VirtualMachineSpecStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20220301VirtualMachineSpecStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V1api20220301VirtualMachineSpecStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecVirtualMachineScaleSetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpecVirtualMachineScaleSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301VirtualMachineSpecVirtualMachineScaleSetReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineSpec
{
    /// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20220301VirtualMachineSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>ApplicationProfile: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V1api20220301VirtualMachineSpecApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>
    /// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
    /// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
    /// more information about availability sets, see [Availability sets
    /// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview).
    /// For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates)
    /// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
    /// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
    /// availability set.
    /// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
    /// </summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20220301VirtualMachineSpecAvailabilitySet? AvailabilitySet { get; set; }

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
    public V1api20220301VirtualMachineSpecBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// CapacityReservation: Specifies information about the capacity reservation that is used to allocate virtual machine.
    /// Minimum api-version: 2021-04-01.
    /// </summary>
    [JsonPropertyName("capacityReservation")]
    public V1api20220301VirtualMachineSpecCapacityReservation? CapacityReservation { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20220301VirtualMachineSpecDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary>
    /// EvictionPolicy: Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set.
    /// For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01.
    /// For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is
    /// 2017-10-30-preview.
    /// </summary>
    [JsonPropertyName("evictionPolicy")]
    public V1api20220301VirtualMachineSpecEvictionPolicyEnum? EvictionPolicy { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301VirtualMachineSpecExtendedLocation? ExtendedLocation { get; set; }

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
    public V1api20220301VirtualMachineSpecHardwareProfile? HardwareProfile { get; set; }

    /// <summary>
    /// Host: Specifies information about the dedicated host that the virtual machine resides in.
    /// Minimum api-version: 2018-10-01.
    /// </summary>
    [JsonPropertyName("host")]
    public V1api20220301VirtualMachineSpecHost? Host { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine resides in.
    /// Minimum api-version: 2020-06-01.
    /// NOTE: User cannot specify both host and hostGroup properties.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V1api20220301VirtualMachineSpecHostGroup? HostGroup { get; set; }

    /// <summary>Identity: The identity of the virtual machine, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301VirtualMachineSpecIdentity? Identity { get; set; }

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
    public V1api20220301VirtualMachineSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220301VirtualMachineSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
    /// be changed once VM is provisioned.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V1api20220301VirtualMachineSpecOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220301VirtualMachineSpecOwner Owner { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V1api20220301VirtualMachineSpecPlan? Plan { get; set; }

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
    public V1api20220301VirtualMachineSpecPriorityEnum? Priority { get; set; }

    /// <summary>
    /// ProximityPlacementGroup: Specifies information about the proximity placement group that the virtual machine should be
    /// assigned to.
    /// Minimum api-version: 2018-04-01.
    /// </summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20220301VirtualMachineSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V1api20220301VirtualMachineSpecScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machine.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301VirtualMachineSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20220301VirtualMachineSpecStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// UserData: UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here.
    /// Minimum api-version: 2021-03-01
    /// </summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>
    /// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
    /// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
    /// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
    /// cannot be added to a virtual machine scale set.
    /// This property cannot exist along with a non-null properties.availabilitySet reference.
    /// Minimum api‐version: 2019‐03‐01
    /// </summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20220301VirtualMachineSpecVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    /// <summary>Zones: The virtual machine zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusAdditionalCapabilities
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

/// <summary>Specifies the required information to reference a compute gallery application version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusApplicationProfileGalleryApplications
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
public partial class V1api20220301VirtualMachineStatusApplicationProfile
{
    /// <summary>GalleryApplications: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1api20220301VirtualMachineStatusApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}

/// <summary>
/// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
/// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
/// more information about availability sets, see [Availability sets
/// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview).
/// For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in
/// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates)
/// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
/// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
/// availability set.
/// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusAvailabilitySet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusBillingProfile
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
public partial class V1api20220301VirtualMachineStatusCapacityReservationCapacityReservationGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// CapacityReservation: Specifies information about the capacity reservation that is used to allocate virtual machine.
/// Minimum api-version: 2021-04-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusCapacityReservation
{
    /// <summary>
    /// CapacityReservationGroup: Specifies the capacity reservation group resource id that should be used for allocating the
    /// virtual machine or scaleset vm instances provided enough capacity has been reserved. Please refer to
    /// https://aka.ms/CapacityReservation for more details.
    /// </summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V1api20220301VirtualMachineStatusCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusConditions
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
/// NOTE: If storageUri is being specified then ensure that the storage account is in the same region and subscription as
/// the VM.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusDiagnosticsProfileBootDiagnostics
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
public partial class V1api20220301VirtualMachineStatusDiagnosticsProfile
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
    public V1api20220301VirtualMachineStatusDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
/// 2021-07-01.
/// This feature is still in preview mode and is not supported for VirtualMachineScaleSet.
/// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusHardwareProfileVmSizeProperties
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

/// <summary>HardwareProfile: Specifies the hardware settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusHardwareProfile
{
    /// <summary>
    /// VmSize: Specifies the size of the virtual machine.
    /// The enum data type is currently deprecated and will be removed by December 23rd 2023.
    /// Recommended way to get the list of available sizes is using these APIs:
    /// [List all available virtual machine sizes in an availability
    /// set](https://docs.microsoft.com/rest/api/compute/availabilitysets/listavailablesizes)
    /// [List all available virtual machine sizes in a region]( https://docs.microsoft.com/rest/api/compute/resourceskus/list)
    /// [List all available virtual machine sizes for
    /// resizing](https://docs.microsoft.com/rest/api/compute/virtualmachines/listavailablesizes). For more information about
    /// virtual machine sizes, see [Sizes for virtual machines](https://docs.microsoft.com/azure/virtual-machines/sizes).
    /// The available VM sizes depend on region and availability set.
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VmSizeProperties: Specifies the properties for customizing the size of the virtual machine. Minimum api-version:
    /// 2021-07-01.
    /// This feature is still in preview mode and is not supported for VirtualMachineScaleSet.
    /// Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details.
    /// </summary>
    [JsonPropertyName("vmSizeProperties")]
    public V1api20220301VirtualMachineStatusHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}

/// <summary>
/// Host: Specifies information about the dedicated host that the virtual machine resides in.
/// Minimum api-version: 2018-10-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusHost
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusHostGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the virtual machine, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusIdentity
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
    public IDictionary<string, V1api20220301VirtualMachineStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Status: The boot diagnostics status information for the VM.
/// NOTE: It will be set only if there are errors encountered in enabling boot diagnostics.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewBootDiagnosticsStatus
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewBootDiagnostics
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
    public V1api20220301VirtualMachineStatusInstanceViewBootDiagnosticsStatus? Status { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: The URL referencing a key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Describes a Encryption Settings for a Disk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Enabled: Specifies whether disk encryption should be enabled on the virtual machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisksStatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewDisks
{
    /// <summary>
    /// EncryptionSettings: Specifies the encryption settings for the OS Disk.
    /// Minimum api-version: 2015-06-15
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewDisksEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewDisksStatuses>? Statuses { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewExtensionsStatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewExtensionsSubstatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewExtensions
{
    /// <summary>Name: The virtual machine extension name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewExtensionsStatuses>? Statuses { get; set; }

    /// <summary>Substatuses: The resource status information.</summary>
    [JsonPropertyName("substatuses")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewExtensionsSubstatuses>? Substatuses { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>MaintenanceRedeployStatus: The Maintenance Operation status on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewMaintenanceRedeployStatus
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror
{
    /// <summary>Errordetail: The internal error message or exception dump.</summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary>Exceptiontype: The exception type.</summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The Api error details</summary>
    [JsonPropertyName("details")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails>? Details { get; set; }

    /// <summary>Innererror: The Api inner error</summary>
    [JsonPropertyName("innererror")]
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror? Innererror { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>AvailablePatchSummary: The available patch summary of the latest assessment operation for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary
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
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError? Error { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror
{
    /// <summary>Errordetail: The internal error message or exception dump.</summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary>Exceptiontype: The exception type.</summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The Api error details</summary>
    [JsonPropertyName("details")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails>? Details { get; set; }

    /// <summary>Innererror: The Api inner error</summary>
    [JsonPropertyName("innererror")]
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror? Innererror { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>LastPatchInstallationSummary: The installation summary of the latest installation operation for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary
{
    /// <summary>Error: The errors that were encountered during execution of the operation. The details array contains the list of them.</summary>
    [JsonPropertyName("error")]
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError? Error { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewPatchStatus
{
    /// <summary>AvailablePatchSummary: The available patch summary of the latest assessment operation for the virtual machine.</summary>
    [JsonPropertyName("availablePatchSummary")]
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary? AvailablePatchSummary { get; set; }

    /// <summary>ConfigurationStatuses: The enablement status of the specified patchMode</summary>
    [JsonPropertyName("configurationStatuses")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses>? ConfigurationStatuses { get; set; }

    /// <summary>LastPatchInstallationSummary: The installation summary of the latest installation operation for the virtual machine.</summary>
    [JsonPropertyName("lastPatchInstallationSummary")]
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary? LastPatchInstallationSummary { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewStatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewVmAgentExtensionHandlers
{
    /// <summary>Status: The extension handler status.</summary>
    [JsonPropertyName("status")]
    public V1api20220301VirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus? Status { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewVmAgentStatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewVmAgent
{
    /// <summary>ExtensionHandlers: The virtual machine extension handler instance view.</summary>
    [JsonPropertyName("extensionHandlers")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewVmAgentExtensionHandlers>? ExtensionHandlers { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewVmAgentStatuses>? Statuses { get; set; }

    /// <summary>VmAgentVersion: The VM Agent full version.</summary>
    [JsonPropertyName("vmAgentVersion")]
    public string? VmAgentVersion { get; set; }
}

/// <summary>Status: The health status information for the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewVmHealthStatus
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceViewVmHealth
{
    /// <summary>Status: The health status information for the VM.</summary>
    [JsonPropertyName("status")]
    public V1api20220301VirtualMachineStatusInstanceViewVmHealthStatus? Status { get; set; }
}

/// <summary>InstanceView: The virtual machine instance view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusInstanceView
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
    public V1api20220301VirtualMachineStatusInstanceViewBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary>ComputerName: The computer name assigned to the virtual machine.</summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>Disks: The virtual machine disk information.</summary>
    [JsonPropertyName("disks")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewDisks>? Disks { get; set; }

    /// <summary>Extensions: The extensions information.</summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20220301VirtualMachineStatusInstanceViewExtensions>? Extensions { get; set; }

    /// <summary>HyperVGeneration: Specifies the HyperVGeneration Type associated with a resource</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>MaintenanceRedeployStatus: The Maintenance Operation status on the virtual machine.</summary>
    [JsonPropertyName("maintenanceRedeployStatus")]
    public V1api20220301VirtualMachineStatusInstanceViewMaintenanceRedeployStatus? MaintenanceRedeployStatus { get; set; }

    /// <summary>OsName: The Operating System running on the virtual machine.</summary>
    [JsonPropertyName("osName")]
    public string? OsName { get; set; }

    /// <summary>OsVersion: The version of Operating System running on the virtual machine.</summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }

    /// <summary>PatchStatus: [Preview Feature] The status of virtual machine patch operations.</summary>
    [JsonPropertyName("patchStatus")]
    public V1api20220301VirtualMachineStatusInstanceViewPatchStatus? PatchStatus { get; set; }

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
    public IList<V1api20220301VirtualMachineStatusInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>VmAgent: The VM Agent running on the virtual machine.</summary>
    [JsonPropertyName("vmAgent")]
    public V1api20220301VirtualMachineStatusInstanceViewVmAgent? VmAgent { get; set; }

    /// <summary>VmHealth: The health status for the VM.</summary>
    [JsonPropertyName("vmHealth")]
    public V1api20220301VirtualMachineStatusInstanceViewVmHealth? VmHealth { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>DnsServers: List of DNS servers IP addresses</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>
    /// DomainNameLabel: The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name
    /// label is the concatenation of the domain name label and vm network profile unique ID.
    /// </summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}

/// <summary>Contains the IP tag associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
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
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
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
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>DeleteOption: Specify what happens to the public IP address when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the publicIP addresses .</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpTags: The list of IP tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary>Name: The publicIP address configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PublicIPAddressVersion: Available from Api-Version 2019-07-01 onwards, it represents whether the specific
    /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;.
    /// </summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPAllocationMethod: Specify the public IP allocation type</summary>
    [JsonPropertyName("publicIPAllocationMethod")]
    public string? PublicIPAllocationMethod { get; set; }

    /// <summary>PublicIPPrefix: The PublicIPPrefix from which to allocate publicIP addresses.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Sku: Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}

/// <summary>Subnet: Specifies the identifier of the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a virtual machine network profile&apos;s IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>
    /// ApplicationGatewayBackendAddressPools: Specifies an array of references to backend address pools of application
    /// gateways. A virtual machine can reference backend address pools of multiple application gateways. Multiple virtual
    /// machines cannot use the same application gateway.
    /// </summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Specifies an array of references to application security group.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>
    /// LoadBalancerBackendAddressPools: Specifies an array of references to backend address pools of load balancers. A virtual
    /// machine can reference backend address pools of one public and one internal load balancer. [Multiple virtual machines
    /// cannot use the same basic sku load balancer].
    /// </summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

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
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Subnet: Specifies the identifier of the subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>NetworkSecurityGroup: The network security group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a virtual machine network interface configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>DnsSettings: The dns settings to be applied on the network interfaces.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("dscpConfiguration")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration? DscpConfiguration { get; set; }

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
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Name: The network interface configuration name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkSecurityGroup: The network security group.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>Describes a network interface reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaces
{
    /// <summary>DeleteOption: Specify what happens to the network interface when the VM is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Primary: Specifies the primary network interface in case the virtual machine has more than 1 network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>NetworkProfile: Specifies the network interfaces of the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusNetworkProfile
{
    /// <summary>
    /// NetworkApiVersion: specifies the Microsoft.Network API version used when creating networking resources in the Network
    /// Interface Configurations
    /// </summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary>
    /// NetworkInterfaceConfigurations: Specifies the networking configurations that will be used to create the virtual machine
    /// networking resources.
    /// </summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }

    /// <summary>NetworkInterfaces: Specifies the list of resource Ids for the network interfaces associated with the virtual machine.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20220301VirtualMachineStatusNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>
/// AutomaticByPlatformSettings: Specifies additional settings for patch mode AutomaticByPlatform in VM Guest Patching on
/// Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationPatchSettings
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
    public V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

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
public partial class V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys
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
public partial class V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with linux based VMs.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// LinuxConfiguration: Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileLinuxConfiguration
{
    /// <summary>DisablePasswordAuthentication: Specifies whether password authentication should be disabled.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary>
    /// ProvisionVMAgent: Indicates whether virtual machine agent should be provisioned on the virtual machine.
    /// When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that
    /// VM Agent is installed on the VM so that extensions can be added to the VM later.
    /// </summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Ssh: Specifies the ssh key configuration for a Linux OS.</summary>
    [JsonPropertyName("ssh")]
    public V1api20220301VirtualMachineStatusOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileSecretsSourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileSecretsVaultCertificates
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
public partial class V1api20220301VirtualMachineStatusOsProfileSecrets
{
    /// <summary>SourceVault: The relative URL of the Key Vault containing all of the certificates in VaultCertificates.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineStatusOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary>VaultCertificates: The list of key vault references in SourceVault which contain certificates.</summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20220301VirtualMachineStatusOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent
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
public partial class V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>RebootSetting: Specifies the reboot setting for all AutomaticByPlatform patch installation operations.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationPatchSettings
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
    public V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

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
public partial class V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners
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
public partial class V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationWinRM
{
    /// <summary>Listeners: The list of Windows Remote Management listeners</summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfileWindowsConfiguration
{
    /// <summary>
    /// AdditionalUnattendContent: Specifies additional base-64 encoded XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup.
    /// </summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// EnableAutomaticUpdates: Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is
    /// true.
    /// For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>PatchSettings: [Preview Feature] Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

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
    public V1api20220301VirtualMachineStatusOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
/// be changed once VM is provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusOsProfile
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
    /// Max-length (Windows): 20 characters.
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
    /// guidelines](https://docs.microsoft.com/azure/azure-resource-manager/management/resource-name-rules).
    /// </summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>
    /// CustomData: Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array
    /// that is saved as a file on the Virtual Machine. The maximum length of the binary array is 65535 bytes.
    /// Note: Do not pass any secrets or passwords in customData property
    /// This property cannot be updated after the VM is created.
    /// customData is passed to the VM to be saved as a file, for more information see [Custom Data on Azure
    /// VMs](https://azure.microsoft.com/blog/custom-data-and-cloud-init-on-windows-azure/)
    /// For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during
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
    public V1api20220301VirtualMachineStatusOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary>RequireGuestProvisionSignal: Optional property which must either be set to True or omitted.</summary>
    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    /// <summary>
    /// Secrets: Specifies set of certificates that should be installed onto the virtual machine. To install certificates on a
    /// virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for
    /// Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual
    /// machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows).
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20220301VirtualMachineStatusOsProfileSecrets>? Secrets { get; set; }

    /// <summary>WindowsConfiguration: Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20220301VirtualMachineStatusOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
/// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
/// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
/// programmatically, Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusPlan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusProximityPlacementGroup
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusResourcesInstanceViewStatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusResourcesInstanceViewSubstatuses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusResourcesInstanceView
{
    /// <summary>Name: The virtual machine extension name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301VirtualMachineStatusResourcesInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>Substatuses: The resource status information.</summary>
    [JsonPropertyName("substatuses")]
    public IList<V1api20220301VirtualMachineStatusResourcesInstanceViewSubstatuses>? Substatuses { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusResourcesProtectedSettingsFromKeyVaultSourceVault
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
public partial class V1api20220301VirtualMachineStatusResourcesProtectedSettingsFromKeyVault
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineStatusResourcesProtectedSettingsFromKeyVaultSourceVault? SourceVault { get; set; }
}

/// <summary>Describes a Virtual Machine Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusResources
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
    public V1api20220301VirtualMachineStatusResourcesInstanceView? InstanceView { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
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
    public V1api20220301VirtualMachineStatusResourcesProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

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

/// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusScheduledEventsProfileTerminateNotificationProfile
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
public partial class V1api20220301VirtualMachineStatusScheduledEventsProfile
{
    /// <summary>TerminateNotificationProfile: Specifies Terminate Scheduled Event related configurations.</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V1api20220301VirtualMachineStatusScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>
/// UefiSettings: Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusSecurityProfileUefiSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusSecurityProfile
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
    public V1api20220301VirtualMachineStatusSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisksImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet
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
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

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
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisksVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileDataDisks
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
    /// DeleteOption: Specifies whether data disk should be deleted or detached upon VM deletion.
    /// Possible values:
    /// Delete If this value is used, the data disk is deleted when VM is deleted.
    /// Detach If this value is used, the data disk is retained after VM is deleted.
    /// The default value is set to detach
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

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
    public V1api20220301VirtualMachineStatusStorageProfileDataDisksImage? Image { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301VirtualMachineStatusStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Name: The disk name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ToBeDetached: Specifies whether the data disk is in process of detachment from the VirtualMachine/VirtualMachineScaleset</summary>
    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>Vhd: The virtual hard disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301VirtualMachineStatusStorageProfileDataDisksVhd? Vhd { get; set; }

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
public partial class V1api20220301VirtualMachineStatusStorageProfileImageReference
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

/// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskDiffDiskSettings
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

/// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: The URL referencing a secret in a Key Vault.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the secret.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: The URL referencing a key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: The relative URL of the Key Vault containing the key.</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// EncryptionSettings: Specifies the encryption settings for the OS Disk.
/// Minimum api-version: 2015-06-15
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Specifies the location of the disk encryption key, which is a Key Vault Secret.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>Enabled: Specifies whether disk encryption should be enabled on the virtual machine.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KeyEncryptionKey: Specifies the location of the key encryption key in Key Vault.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
/// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskImage
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet
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
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>
    /// DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk that is used for
    /// Customer Managed Key encrypted ConfidentialVM OS Disk and VMGuest blob.
    /// </summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

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
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDisk
{
    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SecurityProfile: Specifies the security profile for the managed disk.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Vhd: The virtual hard disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDiskVhd
{
    /// <summary>Uri: Specifies the virtual hard disk&apos;s uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machine.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfileOsDisk
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

    /// <summary>
    /// DeleteOption: Specifies whether OS Disk should be deleted or detached upon VM deletion.
    /// Possible values:
    /// Delete If this value is used, the OS disk is deleted when VM is deleted.
    /// Detach If this value is used, the os disk is retained after VM is deleted.
    /// The default value is set to detach. For an ephemeral OS Disk, the default value is set to Delete. User cannot change the
    /// delete option for ephemeral OS Disk.
    /// </summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>DiffDiskSettings: Specifies the ephemeral Disk Settings for the operating system disk used by the virtual machine.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

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
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Image: The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the
    /// virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>ManagedDisk: The managed disk parameters.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

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
    public V1api20220301VirtualMachineStatusStorageProfileOsDiskVhd? Vhd { get; set; }

    /// <summary>WriteAcceleratorEnabled: Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add a data disk to a virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20220301VirtualMachineStatusStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// ImageReference: Specifies information about the image to use. You can specify information about platform images,
    /// marketplace images, or virtual machine images. This element is required when you want to use a platform image,
    /// marketplace image, or virtual machine image, but is not used in other creation operations.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20220301VirtualMachineStatusStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V1api20220301VirtualMachineStatusStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>
/// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
/// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
/// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
/// cannot be added to a virtual machine scale set.
/// This property cannot exist along with a non-null properties.availabilitySet reference.
/// Minimum api‐version: 2019‐03‐01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatusVirtualMachineScaleSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301VirtualMachineStatus
{
    /// <summary>AdditionalCapabilities: Specifies additional capabilities enabled or disabled on the virtual machine.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20220301VirtualMachineStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>ApplicationProfile: Specifies the gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V1api20220301VirtualMachineStatusApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>
    /// AvailabilitySet: Specifies information about the availability set that the virtual machine should be assigned to.
    /// Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For
    /// more information about availability sets, see [Availability sets
    /// overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview).
    /// For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in
    /// Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates)
    /// Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being
    /// added should be under the same resource group as the availability set resource. An existing VM cannot be added to an
    /// availability set.
    /// This property cannot exist along with a non-null properties.virtualMachineScaleSet reference.
    /// </summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20220301VirtualMachineStatusAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>
    /// BillingProfile: Specifies the billing related details of a Azure Spot virtual machine.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V1api20220301VirtualMachineStatusBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// CapacityReservation: Specifies information about the capacity reservation that is used to allocate virtual machine.
    /// Minimum api-version: 2021-04-01.
    /// </summary>
    [JsonPropertyName("capacityReservation")]
    public V1api20220301VirtualMachineStatusCapacityReservation? CapacityReservation { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301VirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DiagnosticsProfile: Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20220301VirtualMachineStatusDiagnosticsProfile? DiagnosticsProfile { get; set; }

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
    public V1api20220301VirtualMachineStatusExtendedLocation? ExtendedLocation { get; set; }

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
    public V1api20220301VirtualMachineStatusHardwareProfile? HardwareProfile { get; set; }

    /// <summary>
    /// Host: Specifies information about the dedicated host that the virtual machine resides in.
    /// Minimum api-version: 2018-10-01.
    /// </summary>
    [JsonPropertyName("host")]
    public V1api20220301VirtualMachineStatusHost? Host { get; set; }

    /// <summary>
    /// HostGroup: Specifies information about the dedicated host group that the virtual machine resides in.
    /// Minimum api-version: 2020-06-01.
    /// NOTE: User cannot specify both host and hostGroup properties.
    /// </summary>
    [JsonPropertyName("hostGroup")]
    public V1api20220301VirtualMachineStatusHostGroup? HostGroup { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the virtual machine, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301VirtualMachineStatusIdentity? Identity { get; set; }

    /// <summary>InstanceView: The virtual machine instance view.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20220301VirtualMachineStatusInstanceView? InstanceView { get; set; }

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
    public V1api20220301VirtualMachineStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// OsProfile: Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot
    /// be changed once VM is provisioned.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V1api20220301VirtualMachineStatusOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Plan: Specifies information about the marketplace image used to create the virtual machine. This element is only used
    /// for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic
    /// use.  In the Azure portal, find the marketplace image that you want to use and then click Want to deploy
    /// programmatically, Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V1api20220301VirtualMachineStatusPlan? Plan { get; set; }

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
    public V1api20220301VirtualMachineStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>Resources: The virtual machine child extension resources.</summary>
    [JsonPropertyName("resources")]
    public IList<V1api20220301VirtualMachineStatusResources>? Resources { get; set; }

    /// <summary>ScheduledEventsProfile: Specifies Scheduled Event related configurations.</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V1api20220301VirtualMachineStatusScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>SecurityProfile: Specifies the Security related profile settings for the virtual machine.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301VirtualMachineStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20220301VirtualMachineStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TimeCreated: Specifies the time at which the Virtual Machine resource was created.
    /// Minimum api-version: 2022-03-01.
    /// </summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserData: UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here.
    /// Minimum api-version: 2021-03-01
    /// </summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>
    /// VirtualMachineScaleSet: Specifies information about the virtual machine scale set that the virtual machine should be
    /// assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to
    /// maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM
    /// cannot be added to a virtual machine scale set.
    /// This property cannot exist along with a non-null properties.availabilitySet reference.
    /// Minimum api‐version: 2019‐03‐01
    /// </summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20220301VirtualMachineStatusVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachine.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301VirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301VirtualMachineSpec?>, IStatus<V1api20220301VirtualMachineStatus?>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "VirtualMachine";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220301VirtualMachineSpec? Spec { get; set; }

    /// <summary>Describes a Virtual Machine.</summary>
    [JsonPropertyName("status")]
    public V1api20220301VirtualMachineStatus? Status { get; set; }
}