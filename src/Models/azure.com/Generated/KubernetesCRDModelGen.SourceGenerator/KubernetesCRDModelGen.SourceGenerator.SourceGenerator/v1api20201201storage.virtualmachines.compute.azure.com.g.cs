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
/// Storage version of v1api20201201.VirtualMachine
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201201storageVirtualMachineList : IKubernetesObject<V1ListMeta>, IItems<V1api20201201storageVirtualMachine>
{
    public const string KubeApiVersion = "v1api20201201storage";
    public const string KubeKind = "VirtualMachineList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20201201storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201201storageVirtualMachine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201201storageVirtualMachine> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.AdditionalCapabilities
/// Enables or disables a capability on the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecAdditionalCapabilities
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

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecAvailabilitySetReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecAvailabilitySet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecAvailabilitySetReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.BillingProfile
/// Specifies the billing related details of a Azure Spot VM or VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecBillingProfile
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
/// Storage version of v1api20201201.BootDiagnostics
/// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the
/// VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecDiagnosticsProfileBootDiagnostics
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
/// Storage version of v1api20201201.DiagnosticsProfile
/// Specifies the boot diagnostic settings state.
/// Minimum api-version: 2015-06-15.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecDiagnosticsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.BootDiagnostics
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the
    /// VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20201201storageVirtualMachineSpecDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.ExtendedLocation
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecExtendedLocation
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

/// <summary>
/// Storage version of v1api20201201.HardwareProfile
/// Specifies the hardware settings for the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecHardwareProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecHostReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecHost
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecHostReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecHostGroupReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecHostGroup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecHostGroupReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20201201.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualMachineIdentity
/// Identity for the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecIdentity
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
    public IList<V1api20201201storageVirtualMachineSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecNetworkProfileNetworkInterfacesReference
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
/// Storage version of v1api20201201.NetworkInterfaceReference
/// Describes a network interface reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecNetworkProfileNetworkInterfaces
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecNetworkProfileNetworkInterfacesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.NetworkProfile
/// Specifies the network interfaces of the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20201201storageVirtualMachineSpecNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20201201storageVirtualMachineSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20201201.VirtualMachineOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201201storageVirtualMachineSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201201storageVirtualMachineSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileAdminPassword
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
/// Storage version of v1api20201201.LinuxPatchSettings
/// Specifies settings related to VM Guest Patching on Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileLinuxConfigurationPatchSettings
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
/// Storage version of v1api20201201.SshPublicKeySpec
/// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys
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
/// Storage version of v1api20201201.SshConfiguration
/// SSH configuration for Linux based VMs running on Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileLinuxConfigurationSsh
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicKeys")]
    public IList<V1api20201201storageVirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.LinuxConfiguration
/// Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux
/// distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileLinuxConfiguration
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
    /// Storage version of v1api20201201.LinuxPatchSettings
    /// Specifies settings related to VM Guest Patching on Linux.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201storageVirtualMachineSpecOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.SshConfiguration
    /// SSH configuration for Linux based VMs running on Azure
    /// </summary>
    [JsonPropertyName("ssh")]
    public V1api20201201storageVirtualMachineSpecOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileSecretsSourceVaultReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileSecretsSourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VaultCertificate
/// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileSecretsVaultCertificates
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
/// Storage version of v1api20201201.VaultSecretGroup
/// Describes a set of certificates which are all in the same Key Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineSpecOsProfileSecretsSourceVault? SourceVault { get; set; }

    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20201201storageVirtualMachineSpecOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.AdditionalUnattendContent
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent
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
/// Storage version of v1api20201201.PatchSettings
/// Specifies settings related to VM Guest Patching on Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationPatchSettings
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
/// Storage version of v1api20201201.WinRMListener
/// Describes Protocol and thumbprint of Windows Remote Management listener
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners
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
/// Storage version of v1api20201201.WinRMConfiguration
/// Describes Windows Remote Management configuration of the VM
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationWinRM
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("listeners")]
    public IList<V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.WindowsConfiguration
/// Specifies Windows operating system settings on the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfileWindowsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.PatchSettings
    /// Specifies settings related to VM Guest Patching on Windows.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.WinRMConfiguration
    /// Describes Windows Remote Management configuration of the VM
    /// </summary>
    [JsonPropertyName("winRM")]
    public V1api20201201storageVirtualMachineSpecOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.OSProfile
/// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is
/// provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOsProfile
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
    public V1api20201201storageVirtualMachineSpecOsProfileAdminPassword? AdminPassword { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.LinuxConfiguration
    /// Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux
    /// distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// For running non-endorsed distributions, see [Information for Non-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1api20201201storageVirtualMachineSpecOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V1api20201201storageVirtualMachineSpecOsProfileSecrets>? Secrets { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.WindowsConfiguration
    /// Specifies Windows operating system settings on the virtual machine.
    /// </summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20201201storageVirtualMachineSpecOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.Plan
/// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
/// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
/// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
/// Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecPlan
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
public partial class V1api20201201storageVirtualMachineSpecProximityPlacementGroupReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecProximityPlacementGroup
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.UefiSettings
/// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum
/// api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecSecurityProfileUefiSettings
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
/// Storage version of v1api20201201.SecurityProfile
/// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecSecurityProfile
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
    /// Storage version of v1api20201201.UefiSettings
    /// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum
    /// api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V1api20201201storageVirtualMachineSpecSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisksImage
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
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDiskReference
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
/// Storage version of v1api20201201.ManagedDiskParameters
/// The parameters of a managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDiskReference? Reference { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisksVhd
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

/// <summary>
/// Storage version of v1api20201201.DataDisk
/// Describes a data disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileDataDisks
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

    [JsonPropertyName("detachOption")]
    public string? DetachOption { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201storageVirtualMachineSpecStorageProfileDataDisksImage? Image { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ManagedDiskParameters
    /// The parameters of a managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201storageVirtualMachineSpecStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("vhd")]
    public V1api20201201storageVirtualMachineSpecStorageProfileDataDisksVhd? Vhd { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileImageReferenceReference
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
/// Storage version of v1api20201201.ImageReference
/// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
/// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
/// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
/// when you create the scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileImageReference
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
    public V1api20201201storageVirtualMachineSpecStorageProfileImageReferenceReference? Reference { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.DiffDiskSettings
/// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
/// NOTE: The
/// ephemeral disk settings can only be specified for managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskDiffDiskSettings
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

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.KeyVaultSecretReference
/// Describes a reference to Key Vault Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.KeyVaultKeyReference
/// Describes a reference to Key Vault Key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.DiskEncryptionSettings
/// Describes a Encryption Settings for a Disk
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.KeyVaultSecretReference
    /// Describes a reference to Key Vault Secret
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.KeyVaultKeyReference
    /// Describes a reference to Key Vault Key
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskImage
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
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDiskReference
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
/// Storage version of v1api20201201.ManagedDiskParameters
/// The parameters of a managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDiskReference? Reference { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDiskVhd
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

/// <summary>
/// Storage version of v1api20201201.OSDisk
/// Specifies information about the operating system disk used by the virtual machine.
/// For more information about
/// disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfileOsDisk
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
    /// Storage version of v1api20201201.DiffDiskSettings
    /// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
    /// NOTE: The
    /// ephemeral disk settings can only be specified for managed disk.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.DiskEncryptionSettings
    /// Describes a Encryption Settings for a Disk
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ManagedDiskParameters
    /// The parameters of a managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("vhd")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDiskVhd? Vhd { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.StorageProfile
/// Specifies the storage settings for the virtual machine disks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecStorageProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataDisks")]
    public IList<V1api20201201storageVirtualMachineSpecStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ImageReference
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20201201storageVirtualMachineSpecStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.OSDisk
    /// Specifies information about the operating system disk used by the virtual machine.
    /// For more information about
    /// disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V1api20201201storageVirtualMachineSpecStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecVirtualMachineScaleSetReference
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

/// <summary>Storage version of v1api20201201.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpecVirtualMachineScaleSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20201201storageVirtualMachineSpecVirtualMachineScaleSetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20201201.VirtualMachine_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.AdditionalCapabilities
    /// Enables or disables a capability on the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20201201storageVirtualMachineSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20201201storageVirtualMachineSpecAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.BillingProfile
    /// Specifies the billing related details of a Azure Spot VM or VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V1api20201201storageVirtualMachineSpecBillingProfile? BillingProfile { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.DiagnosticsProfile
    /// Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20201201storageVirtualMachineSpecDiagnosticsProfile? DiagnosticsProfile { get; set; }

    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ExtendedLocation
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201201storageVirtualMachineSpecExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.HardwareProfile
    /// Specifies the hardware settings for the virtual machine.
    /// </summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20201201storageVirtualMachineSpecHardwareProfile? HardwareProfile { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("host")]
    public V1api20201201storageVirtualMachineSpecHost? Host { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("hostGroup")]
    public V1api20201201storageVirtualMachineSpecHostGroup? HostGroup { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineIdentity
    /// Identity for the virtual machine.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20201201storageVirtualMachineSpecIdentity? Identity { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.NetworkProfile
    /// Specifies the network interfaces of the virtual machine.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V1api20201201storageVirtualMachineSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201201storageVirtualMachineSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.OSProfile
    /// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is
    /// provisioned.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V1api20201201storageVirtualMachineSpecOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201201storageVirtualMachineSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.Plan
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
    /// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
    /// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
    /// Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V1api20201201storageVirtualMachineSpecPlan? Plan { get; set; }

    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20201201storageVirtualMachineSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.SecurityProfile
    /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V1api20201201storageVirtualMachineSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.StorageProfile
    /// Specifies the storage settings for the virtual machine disks.
    /// </summary>
    [JsonPropertyName("storageProfile")]
    public V1api20201201storageVirtualMachineSpecStorageProfile? StorageProfile { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource</summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20201201storageVirtualMachineSpecVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.AdditionalCapabilities_STATUS
/// Enables or disables a capability on the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusAdditionalCapabilities
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

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusAvailabilitySet
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
/// Storage version of v1api20201201.BillingProfile_STATUS
/// Specifies the billing related details of a Azure Spot VM or VMSS.
/// Minimum api-version: 2019-03-01.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusBillingProfile
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

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusConditions
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
/// Storage version of v1api20201201.BootDiagnostics_STATUS
/// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
/// You can easily view the output of your console log.
/// Azure also enables you to see a screenshot of the
/// VM from the hypervisor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusDiagnosticsProfileBootDiagnostics
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
/// Storage version of v1api20201201.DiagnosticsProfile_STATUS
/// Specifies the boot diagnostic settings state.
/// Minimum api-version: 2015-06-15.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusDiagnosticsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.BootDiagnostics_STATUS
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status.
    /// You can easily view the output of your console log.
    /// Azure also enables you to see a screenshot of the
    /// VM from the hypervisor.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20201201storageVirtualMachineStatusDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.ExtendedLocation_STATUS
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusExtendedLocation
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

/// <summary>
/// Storage version of v1api20201201.HardwareProfile_STATUS
/// Specifies the hardware settings for the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusHardwareProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusHost
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

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusHostGroup
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

/// <summary>Storage version of v1api20201201.VirtualMachineIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusIdentityUserAssignedIdentities
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
/// Storage version of v1api20201201.VirtualMachineIdentity_STATUS
/// Identity for the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusIdentity
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
    public IDictionary<string, V1api20201201storageVirtualMachineStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewBootDiagnosticsStatus
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
/// Storage version of v1api20201201.BootDiagnosticsInstanceView_STATUS
/// The instance view of a virtual machine boot diagnostics.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewBootDiagnostics
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consoleScreenshotBlobUri")]
    public string? ConsoleScreenshotBlobUri { get; set; }

    [JsonPropertyName("serialConsoleLogBlobUri")]
    public string? SerialConsoleLogBlobUri { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.InstanceViewStatus_STATUS
    /// Instance view status.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20201201storageVirtualMachineStatusInstanceViewBootDiagnosticsStatus? Status { get; set; }
}

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault
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
/// Storage version of v1api20201201.KeyVaultSecretReference_STATUS
/// Describes a reference to Key Vault Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault
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
/// Storage version of v1api20201201.KeyVaultKeyReference_STATUS
/// Describes a reference to Key Vault Key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.DiskEncryptionSettings_STATUS
/// Describes a Encryption Settings for a Disk
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.KeyVaultSecretReference_STATUS
    /// Describes a reference to Key Vault Secret
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.KeyVaultKeyReference_STATUS
    /// Describes a reference to Key Vault Key
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisksStatuses
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
/// Storage version of v1api20201201.DiskInstanceView_STATUS
/// The instance view of the disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewDisks
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewDisksEncryptionSettings>? EncryptionSettings { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewDisksStatuses>? Statuses { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewExtensionsStatuses
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
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewExtensionsSubstatuses
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
/// Storage version of v1api20201201.VirtualMachineExtensionInstanceView_STATUS
/// The instance view of a virtual machine extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewExtensions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewExtensionsStatuses>? Statuses { get; set; }

    [JsonPropertyName("substatuses")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewExtensionsSubstatuses>? Substatuses { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.MaintenanceRedeployStatus_STATUS
/// Maintenance Operation Status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewMaintenanceRedeployStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isCustomerInitiatedMaintenanceAllowed")]
    public bool? IsCustomerInitiatedMaintenanceAllowed { get; set; }

    [JsonPropertyName("lastOperationMessage")]
    public string? LastOperationMessage { get; set; }

    [JsonPropertyName("lastOperationResultCode")]
    public string? LastOperationResultCode { get; set; }

    [JsonPropertyName("maintenanceWindowEndTime")]
    public string? MaintenanceWindowEndTime { get; set; }

    [JsonPropertyName("maintenanceWindowStartTime")]
    public string? MaintenanceWindowStartTime { get; set; }

    [JsonPropertyName("preMaintenanceWindowEndTime")]
    public string? PreMaintenanceWindowEndTime { get; set; }

    [JsonPropertyName("preMaintenanceWindowStartTime")]
    public string? PreMaintenanceWindowStartTime { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.ApiErrorBase_STATUS
/// Api error base.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InnerError_STATUS
/// Inner error details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.ApiError_STATUS
/// Api error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails>? Details { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.InnerError_STATUS
    /// Inner error details.
    /// </summary>
    [JsonPropertyName("innererror")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror? Innererror { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.AvailablePatchSummary_STATUS
/// Describes the properties of an virtual machine instance view for available patch summary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("assessmentActivityId")]
    public string? AssessmentActivityId { get; set; }

    [JsonPropertyName("criticalAndSecurityPatchCount")]
    public int? CriticalAndSecurityPatchCount { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ApiError_STATUS
    /// Api error.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError? Error { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    [JsonPropertyName("otherPatchCount")]
    public int? OtherPatchCount { get; set; }

    [JsonPropertyName("rebootPending")]
    public bool? RebootPending { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses
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
/// Storage version of v1api20201201.ApiErrorBase_STATUS
/// Api error base.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InnerError_STATUS
/// Inner error details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.ApiError_STATUS
/// Api error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails>? Details { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.InnerError_STATUS
    /// Inner error details.
    /// </summary>
    [JsonPropertyName("innererror")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror? Innererror { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.LastPatchInstallationSummary_STATUS
/// Describes the properties of the last installed patch summary.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ApiError_STATUS
    /// Api error.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError? Error { get; set; }

    [JsonPropertyName("excludedPatchCount")]
    public int? ExcludedPatchCount { get; set; }

    [JsonPropertyName("failedPatchCount")]
    public int? FailedPatchCount { get; set; }

    [JsonPropertyName("installationActivityId")]
    public string? InstallationActivityId { get; set; }

    [JsonPropertyName("installedPatchCount")]
    public int? InstalledPatchCount { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    [JsonPropertyName("maintenanceWindowExceeded")]
    public bool? MaintenanceWindowExceeded { get; set; }

    [JsonPropertyName("notSelectedPatchCount")]
    public int? NotSelectedPatchCount { get; set; }

    [JsonPropertyName("pendingPatchCount")]
    public int? PendingPatchCount { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualMachinePatchStatus_STATUS
/// The status of virtual machine patch operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewPatchStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.AvailablePatchSummary_STATUS
    /// Describes the properties of an virtual machine instance view for available patch summary.
    /// </summary>
    [JsonPropertyName("availablePatchSummary")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary? AvailablePatchSummary { get; set; }

    [JsonPropertyName("configurationStatuses")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses>? ConfigurationStatuses { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.LastPatchInstallationSummary_STATUS
    /// Describes the properties of the last installed patch summary.
    /// </summary>
    [JsonPropertyName("lastPatchInstallationSummary")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary? LastPatchInstallationSummary { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewStatuses
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
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus
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
/// Storage version of v1api20201201.VirtualMachineExtensionHandlerInstanceView_STATUS
/// The instance view of a virtual machine extension handler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.InstanceViewStatus_STATUS
    /// Instance view status.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20201201storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewVmAgentStatuses
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
/// Storage version of v1api20201201.VirtualMachineAgentInstanceView_STATUS
/// The instance view of the VM Agent running on the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewVmAgent
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("extensionHandlers")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlers>? ExtensionHandlers { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewVmAgentStatuses>? Statuses { get; set; }

    [JsonPropertyName("vmAgentVersion")]
    public string? VmAgentVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewVmHealthStatus
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
/// Storage version of v1api20201201.VirtualMachineHealthStatus_STATUS
/// The health status of the VM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceViewVmHealth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.InstanceViewStatus_STATUS
    /// Instance view status.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20201201storageVirtualMachineStatusInstanceViewVmHealthStatus? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualMachineInstanceView_STATUS
/// The instance view of a virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusInstanceView
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("assignedHost")]
    public string? AssignedHost { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.BootDiagnosticsInstanceView_STATUS
    /// The instance view of a virtual machine boot diagnostics.
    /// </summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20201201storageVirtualMachineStatusInstanceViewBootDiagnostics? BootDiagnostics { get; set; }

    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    [JsonPropertyName("disks")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewDisks>? Disks { get; set; }

    [JsonPropertyName("extensions")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewExtensions>? Extensions { get; set; }

    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.MaintenanceRedeployStatus_STATUS
    /// Maintenance Operation Status.
    /// </summary>
    [JsonPropertyName("maintenanceRedeployStatus")]
    public V1api20201201storageVirtualMachineStatusInstanceViewMaintenanceRedeployStatus? MaintenanceRedeployStatus { get; set; }

    [JsonPropertyName("osName")]
    public string? OsName { get; set; }

    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachinePatchStatus_STATUS
    /// The status of virtual machine patch operations.
    /// </summary>
    [JsonPropertyName("patchStatus")]
    public V1api20201201storageVirtualMachineStatusInstanceViewPatchStatus? PatchStatus { get; set; }

    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    [JsonPropertyName("platformUpdateDomain")]
    public int? PlatformUpdateDomain { get; set; }

    [JsonPropertyName("rdpThumbPrint")]
    public string? RdpThumbPrint { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20201201storageVirtualMachineStatusInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineAgentInstanceView_STATUS
    /// The instance view of the VM Agent running on the virtual machine.
    /// </summary>
    [JsonPropertyName("vmAgent")]
    public V1api20201201storageVirtualMachineStatusInstanceViewVmAgent? VmAgent { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineHealthStatus_STATUS
    /// The health status of the VM.
    /// </summary>
    [JsonPropertyName("vmHealth")]
    public V1api20201201storageVirtualMachineStatusInstanceViewVmHealth? VmHealth { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.NetworkInterfaceReference_STATUS
/// Describes a network interface reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusNetworkProfileNetworkInterfaces
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.NetworkProfile_STATUS
/// Specifies the network interfaces of the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20201201storageVirtualMachineStatusNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.LinuxPatchSettings_STATUS
/// Specifies settings related to VM Guest Patching on Linux.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileLinuxConfigurationPatchSettings
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
/// Storage version of v1api20201201.SshPublicKey_STATUS
/// Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys
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
/// Storage version of v1api20201201.SshConfiguration_STATUS
/// SSH configuration for Linux based VMs running on Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileLinuxConfigurationSsh
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publicKeys")]
    public IList<V1api20201201storageVirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.LinuxConfiguration_STATUS
/// Specifies the Linux operating system settings on the virtual machine.
/// For a list of supported Linux
/// distributions, see [Linux on Azure-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
/// For running non-endorsed distributions, see [Information for Non-Endorsed
/// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileLinuxConfiguration
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
    /// Storage version of v1api20201201.LinuxPatchSettings_STATUS
    /// Specifies settings related to VM Guest Patching on Linux.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201storageVirtualMachineStatusOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.SshConfiguration_STATUS
    /// SSH configuration for Linux based VMs running on Azure
    /// </summary>
    [JsonPropertyName("ssh")]
    public V1api20201201storageVirtualMachineStatusOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileSecretsSourceVault
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
/// Storage version of v1api20201201.VaultCertificate_STATUS
/// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileSecretsVaultCertificates
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
/// Storage version of v1api20201201.VaultSecretGroup_STATUS
/// Describes a set of certificates which are all in the same Key Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineStatusOsProfileSecretsSourceVault? SourceVault { get; set; }

    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20201201storageVirtualMachineStatusOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.AdditionalUnattendContent_STATUS
/// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows
/// Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent
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
/// Storage version of v1api20201201.PatchSettings_STATUS
/// Specifies settings related to VM Guest Patching on Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationPatchSettings
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
/// Storage version of v1api20201201.WinRMListener_STATUS
/// Describes Protocol and thumbprint of Windows Remote Management listener
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners
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
/// Storage version of v1api20201201.WinRMConfiguration_STATUS
/// Describes Windows Remote Management configuration of the VM
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationWinRM
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("listeners")]
    public IList<V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.WindowsConfiguration_STATUS
/// Specifies Windows operating system settings on the virtual machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfileWindowsConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.PatchSettings_STATUS
    /// Specifies settings related to VM Guest Patching on Windows.
    /// </summary>
    [JsonPropertyName("patchSettings")]
    public V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.WinRMConfiguration_STATUS
    /// Describes Windows Remote Management configuration of the VM
    /// </summary>
    [JsonPropertyName("winRM")]
    public V1api20201201storageVirtualMachineStatusOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.OSProfile_STATUS
/// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is
/// provisioned.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusOsProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.LinuxConfiguration_STATUS
    /// Specifies the Linux operating system settings on the virtual machine.
    /// For a list of supported Linux
    /// distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
    /// For running non-endorsed distributions, see [Information for Non-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// </summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1api20201201storageVirtualMachineStatusOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V1api20201201storageVirtualMachineStatusOsProfileSecrets>? Secrets { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.WindowsConfiguration_STATUS
    /// Specifies Windows operating system settings on the virtual machine.
    /// </summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20201201storageVirtualMachineStatusOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.Plan_STATUS
/// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
/// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
/// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
/// Get Started -&gt;. Enter any required information and then click Save.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusPlan
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

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusProximityPlacementGroup
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
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusResourcesInstanceViewStatuses
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
/// Storage version of v1api20201201.InstanceViewStatus_STATUS
/// Instance view status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusResourcesInstanceViewSubstatuses
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
/// Storage version of v1api20201201.VirtualMachineExtensionInstanceView_STATUS
/// The instance view of a virtual machine extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusResourcesInstanceView
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("statuses")]
    public IList<V1api20201201storageVirtualMachineStatusResourcesInstanceViewStatuses>? Statuses { get; set; }

    [JsonPropertyName("substatuses")]
    public IList<V1api20201201storageVirtualMachineStatusResourcesInstanceViewSubstatuses>? Substatuses { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualMachineExtension_STATUS
/// Describes a Virtual Machine Extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusResources
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

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineExtensionInstanceView_STATUS
    /// The instance view of a virtual machine extension.
    /// </summary>
    [JsonPropertyName("instanceView")]
    public V1api20201201storageVirtualMachineStatusResourcesInstanceView? InstanceView { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.UefiSettings_STATUS
/// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
/// Minimum
/// api-version: 2020-12-01
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusSecurityProfileUefiSettings
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
/// Storage version of v1api20201201.SecurityProfile_STATUS
/// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusSecurityProfile
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
    /// Storage version of v1api20201201.UefiSettings_STATUS
    /// Specifies the security settings like secure boot and vTPM used while creating the virtual machine.
    /// Minimum
    /// api-version: 2020-12-01
    /// </summary>
    [JsonPropertyName("uefiSettings")]
    public V1api20201201storageVirtualMachineStatusSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk_STATUS
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileDataDisksImage
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

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet
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
/// Storage version of v1api20201201.ManagedDiskParameters_STATUS
/// The parameters of a managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileDataDisksManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201storageVirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk_STATUS
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileDataDisksVhd
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

/// <summary>
/// Storage version of v1api20201201.DataDisk_STATUS
/// Describes a data disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileDataDisks
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

    [JsonPropertyName("detachOption")]
    public string? DetachOption { get; set; }

    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk_STATUS
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201storageVirtualMachineStatusStorageProfileDataDisksImage? Image { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ManagedDiskParameters_STATUS
    /// The parameters of a managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201storageVirtualMachineStatusStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk_STATUS
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("vhd")]
    public V1api20201201storageVirtualMachineStatusStorageProfileDataDisksVhd? Vhd { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.ImageReference_STATUS
/// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
/// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
/// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
/// when you create the scale set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileImageReference
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
/// Storage version of v1api20201201.DiffDiskSettings_STATUS
/// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
/// NOTE: The
/// ephemeral disk settings can only be specified for managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskDiffDiskSettings
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

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
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
/// Storage version of v1api20201201.KeyVaultSecretReference_STATUS
/// Describes a reference to Key Vault Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
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
/// Storage version of v1api20201201.KeyVaultKeyReference_STATUS
/// Describes a reference to Key Vault Key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.DiskEncryptionSettings_STATUS
/// Describes a Encryption Settings for a Disk
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.KeyVaultSecretReference_STATUS
    /// Describes a reference to Key Vault Secret
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.KeyVaultKeyReference_STATUS
    /// Describes a reference to Key Vault Key
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk_STATUS
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskImage
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

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet
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
/// Storage version of v1api20201201.ManagedDiskParameters_STATUS
/// The parameters of a managed disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskManagedDisk
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualHardDisk_STATUS
/// Describes the uri of a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDiskVhd
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

/// <summary>
/// Storage version of v1api20201201.OSDisk_STATUS
/// Specifies information about the operating system disk used by the virtual machine.
/// For more information about
/// disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfileOsDisk
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
    /// Storage version of v1api20201201.DiffDiskSettings_STATUS
    /// Describes the parameters of ephemeral disk settings that can be specified for operating system disk.
    /// NOTE: The
    /// ephemeral disk settings can only be specified for managed disk.
    /// </summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.DiskEncryptionSettings_STATUS
    /// Describes a Encryption Settings for a Disk
    /// </summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk_STATUS
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("image")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ManagedDiskParameters_STATUS
    /// The parameters of a managed disk.
    /// </summary>
    [JsonPropertyName("managedDisk")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualHardDisk_STATUS
    /// Describes the uri of a disk.
    /// </summary>
    [JsonPropertyName("vhd")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDiskVhd? Vhd { get; set; }

    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.StorageProfile_STATUS
/// Specifies the storage settings for the virtual machine disks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusStorageProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataDisks")]
    public IList<V1api20201201storageVirtualMachineStatusStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ImageReference_STATUS
    /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or
    /// virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual
    /// machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set
    /// when you create the scale set.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20201201storageVirtualMachineStatusStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.OSDisk_STATUS
    /// Specifies information about the operating system disk used by the virtual machine.
    /// For more information about
    /// disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V1api20201201storageVirtualMachineStatusStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatusVirtualMachineScaleSet
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
/// Storage version of v1api20201201.VirtualMachine_STATUS
/// Describes a Virtual Machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201201storageVirtualMachineStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.AdditionalCapabilities_STATUS
    /// Enables or disables a capability on the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20201201storageVirtualMachineStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20201201storageVirtualMachineStatusAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.BillingProfile_STATUS
    /// Specifies the billing related details of a Azure Spot VM or VMSS.
    /// Minimum api-version: 2019-03-01.
    /// </summary>
    [JsonPropertyName("billingProfile")]
    public V1api20201201storageVirtualMachineStatusBillingProfile? BillingProfile { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20201201storageVirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.DiagnosticsProfile_STATUS
    /// Specifies the boot diagnostic settings state.
    /// Minimum api-version: 2015-06-15.
    /// </summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20201201storageVirtualMachineStatusDiagnosticsProfile? DiagnosticsProfile { get; set; }

    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.ExtendedLocation_STATUS
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201201storageVirtualMachineStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.HardwareProfile_STATUS
    /// Specifies the hardware settings for the virtual machine.
    /// </summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20201201storageVirtualMachineStatusHardwareProfile? HardwareProfile { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("host")]
    public V1api20201201storageVirtualMachineStatusHost? Host { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("hostGroup")]
    public V1api20201201storageVirtualMachineStatusHostGroup? HostGroup { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineIdentity_STATUS
    /// Identity for the virtual machine.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20201201storageVirtualMachineStatusIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachineInstanceView_STATUS
    /// The instance view of a virtual machine.
    /// </summary>
    [JsonPropertyName("instanceView")]
    public V1api20201201storageVirtualMachineStatusInstanceView? InstanceView { get; set; }

    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.NetworkProfile_STATUS
    /// Specifies the network interfaces of the virtual machine.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V1api20201201storageVirtualMachineStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.OSProfile_STATUS
    /// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is
    /// provisioned.
    /// </summary>
    [JsonPropertyName("osProfile")]
    public V1api20201201storageVirtualMachineStatusOsProfile? OsProfile { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.Plan_STATUS
    /// Specifies information about the marketplace image used to create the virtual machine. This element is only used for
    /// marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.
    /// In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically,
    /// Get Started -&gt;. Enter any required information and then click Save.
    /// </summary>
    [JsonPropertyName("plan")]
    public V1api20201201storageVirtualMachineStatusPlan? Plan { get; set; }

    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20201201storageVirtualMachineStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    [JsonPropertyName("resources")]
    public IList<V1api20201201storageVirtualMachineStatusResources>? Resources { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.SecurityProfile_STATUS
    /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public V1api20201201storageVirtualMachineStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.StorageProfile_STATUS
    /// Specifies the storage settings for the virtual machine disks.
    /// </summary>
    [JsonPropertyName("storageProfile")]
    public V1api20201201storageVirtualMachineStatusStorageProfile? StorageProfile { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20201201.SubResource_STATUS</summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20201201storageVirtualMachineStatusVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    [JsonPropertyName("vmId")]
    public string? VmId { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v1api20201201.VirtualMachine
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201201storageVirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201201storageVirtualMachineSpec?>, IStatus<V1api20201201storageVirtualMachineStatus?>
{
    public const string KubeApiVersion = "v1api20201201storage";
    public const string KubeKind = "VirtualMachine";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20201201storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20201201.VirtualMachine_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20201201storageVirtualMachineSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20201201.VirtualMachine_STATUS
    /// Describes a Virtual Machine.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20201201storageVirtualMachineStatus? Status { get; set; }
}