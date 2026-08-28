#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2025-05-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250501ServerFarmList : IKubernetesObject<V1ListMeta>, IItems<V20250501ServerFarm>
{
    public const string KubeApiVersion = "v20250501";
    public const string KubeKind = "ServerFarmList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "serverfarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v20250501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerFarmList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250501ServerFarm objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250501ServerFarm> Items { get; set; }
}

/// <summary>ExtendedLocation: Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecExtendedLocation
{
    /// <summary>Name: Name of extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID of the App Service Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecHostingEnvironmentProfileReference
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

/// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecHostingEnvironmentProfile
{
    /// <summary>Reference: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("reference")]
    public V20250501ServerFarmSpecHostingEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>Type: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250501ServerFarmSpecIdentityTypeEnum>))]
public enum V20250501ServerFarmSpecIdentityTypeEnum
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
public partial class V20250501ServerFarmSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20250501ServerFarmSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250501ServerFarmSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecIdentity
{
    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public V20250501ServerFarmSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user assigned identities associated with the resource. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250501ServerFarmSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Type: Type of the install script.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250501ServerFarmSpecInstallScriptsSourceTypeEnum>))]
public enum V20250501ServerFarmSpecInstallScriptsSourceTypeEnum
{
    [EnumMember(Value = "PlatformStorage"), JsonStringEnumMemberName("PlatformStorage")]
    PlatformStorage,
    [EnumMember(Value = "RemoteAzureBlob"), JsonStringEnumMemberName("RemoteAzureBlob")]
    RemoteAzureBlob
}

/// <summary>Source: Source of the install script.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecInstallScriptsSource
{
    /// <summary>SourceUri: Install script source URI where the install script file will be fetched from.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>Type: Type of the install script.</summary>
    [JsonPropertyName("type")]
    public V20250501ServerFarmSpecInstallScriptsSourceTypeEnum? Type { get; set; }
}

/// <summary>Server farm install script configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecInstallScripts
{
    /// <summary>Name: Name of the install script.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: Source of the install script.</summary>
    [JsonPropertyName("source")]
    public V20250501ServerFarmSpecInstallScriptsSource? Source { get; set; }
}

/// <summary>Reference: Resource ID of the Kubernetes Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecKubeEnvironmentProfileReference
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

/// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecKubeEnvironmentProfile
{
    /// <summary>Reference: Resource ID of the Kubernetes Environment.</summary>
    [JsonPropertyName("reference")]
    public V20250501ServerFarmSpecKubeEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>
/// VirtualNetworkSubnetReference: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
/// Integration. This must be of the form
/// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecNetworkVirtualNetworkSubnetReference
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

/// <summary>Network: All network settings for the server farm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecNetwork
{
    /// <summary>
    /// VirtualNetworkSubnetReference: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
    /// Integration. This must be of the form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetReference")]
    public V20250501ServerFarmSpecNetworkVirtualNetworkSubnetReference? VirtualNetworkSubnetReference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecOperatorSpecConfigMapExpressions
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
public partial class V20250501ServerFarmSpecOperatorSpecSecretExpressions
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
public partial class V20250501ServerFarmSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250501ServerFarmSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250501ServerFarmSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>IdentityType: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250501ServerFarmSpecPlanDefaultIdentityIdentityTypeEnum>))]
public enum V20250501ServerFarmSpecPlanDefaultIdentityIdentityTypeEnum
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
public partial class V20250501ServerFarmSpecPlanDefaultIdentityUserAssignedIdentityResourceReference
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

/// <summary>PlanDefaultIdentity: Identity to use by platform for various features and integrations using managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecPlanDefaultIdentity
{
    /// <summary>IdentityType: Type of managed service identity.</summary>
    [JsonPropertyName("identityType")]
    public V20250501ServerFarmSpecPlanDefaultIdentityIdentityTypeEnum? IdentityType { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("userAssignedIdentityResourceReference")]
    public V20250501ServerFarmSpecPlanDefaultIdentityUserAssignedIdentityResourceReference? UserAssignedIdentityResourceReference { get; set; }
}

/// <summary>KeyVaultSecretReference: Key vault reference to the value that will be placed in the registry location</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecRegistryAdaptersKeyVaultSecretReference
{
    /// <summary>ReferenceStatus: Reference status of the key vault secret.</summary>
    [JsonPropertyName("referenceStatus")]
    public string? ReferenceStatus { get; set; }

    /// <summary>SecretUri: Key vault secret URI.</summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary>Type: Type of the registry adapter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250501ServerFarmSpecRegistryAdaptersTypeEnum>))]
public enum V20250501ServerFarmSpecRegistryAdaptersTypeEnum
{
    [EnumMember(Value = "Binary"), JsonStringEnumMemberName("Binary")]
    Binary,
    [EnumMember(Value = "DWord"), JsonStringEnumMemberName("DWord")]
    DWord,
    [EnumMember(Value = "Expand_String"), JsonStringEnumMemberName("Expand_String")]
    ExpandString,
    [EnumMember(Value = "Multi_String"), JsonStringEnumMemberName("Multi_String")]
    MultiString,
    [EnumMember(Value = "QWord"), JsonStringEnumMemberName("QWord")]
    QWord,
    [EnumMember(Value = "String"), JsonStringEnumMemberName("String")]
    String
}

/// <summary>Server farm registry adapter configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecRegistryAdapters
{
    /// <summary>KeyVaultSecretReference: Key vault reference to the value that will be placed in the registry location</summary>
    [JsonPropertyName("keyVaultSecretReference")]
    public V20250501ServerFarmSpecRegistryAdaptersKeyVaultSecretReference? KeyVaultSecretReference { get; set; }

    /// <summary>RegistryKey: Registry key for the adapter.</summary>
    [JsonPropertyName("registryKey")]
    public string? RegistryKey { get; set; }

    /// <summary>Type: Type of the registry adapter.</summary>
    [JsonPropertyName("type")]
    public V20250501ServerFarmSpecRegistryAdaptersTypeEnum? Type { get; set; }
}

/// <summary>Describes the capabilities/features allowed for a specific SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecSkuCapabilities
{
    /// <summary>Name: Name of the SKU capability.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reason: Reason of the SKU capability.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Value: Value of the SKU capability.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecSkuSkuCapacity
{
    /// <summary>Default: Default number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("default")]
    public int? Default { get; set; }

    /// <summary>ElasticMaximum: Maximum number of Elastic workers for this App Service plan SKU.</summary>
    [JsonPropertyName("elasticMaximum")]
    public int? ElasticMaximum { get; set; }

    /// <summary>Maximum: Maximum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary>Minimum: Minimum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary>ScaleType: Available scale configurations for an App Service plan.</summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Sku: Description of a SKU for a scalable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecSku
{
    /// <summary>Capabilities: Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
    [JsonPropertyName("capabilities")]
    public IList<V20250501ServerFarmSpecSkuCapabilities>? Capabilities { get; set; }

    /// <summary>Capacity: Current number of instances assigned to the resource.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Family code of the resource SKU.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Locations: Locations of the SKU.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Name: Name of the resource SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size specifier of the resource SKU.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
    [JsonPropertyName("skuCapacity")]
    public V20250501ServerFarmSpecSkuSkuCapacity? SkuCapacity { get; set; }

    /// <summary>Tier: Service tier of the resource SKU.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>CredentialsKeyVaultReference: KV reference to the credentials to connect to the share.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecStorageMountsCredentialsKeyVaultReference
{
    /// <summary>ReferenceStatus: Reference status of the key vault secret.</summary>
    [JsonPropertyName("referenceStatus")]
    public string? ReferenceStatus { get; set; }

    /// <summary>SecretUri: Key vault secret URI.</summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary>Type: Type of the storage mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250501ServerFarmSpecStorageMountsTypeEnum>))]
public enum V20250501ServerFarmSpecStorageMountsTypeEnum
{
    [EnumMember(Value = "AzureFiles"), JsonStringEnumMemberName("AzureFiles")]
    AzureFiles,
    [EnumMember(Value = "FileShare"), JsonStringEnumMemberName("FileShare")]
    FileShare,
    [EnumMember(Value = "LocalStorage"), JsonStringEnumMemberName("LocalStorage")]
    LocalStorage
}

/// <summary>Server farm storage mount configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpecStorageMounts
{
    /// <summary>CredentialsKeyVaultReference: KV reference to the credentials to connect to the share.</summary>
    [JsonPropertyName("credentialsKeyVaultReference")]
    public V20250501ServerFarmSpecStorageMountsCredentialsKeyVaultReference? CredentialsKeyVaultReference { get; set; }

    /// <summary>DestinationPath: Path on worker where storage will be mounted.</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>Name: Name of the storage mount.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: Source of the fileshare/storage.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Type: Type of the storage mount.</summary>
    [JsonPropertyName("type")]
    public V20250501ServerFarmSpecStorageMountsTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmSpec
{
    /// <summary>
    /// AsyncScalingEnabled: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will attempt to scale asynchronously if there are
    /// insufficient workers to scale synchronously.
    /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will only attempt sync scaling.
    /// </summary>
    [JsonPropertyName("asyncScalingEnabled")]
    public bool? AsyncScalingEnabled { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ElasticScaleEnabled: ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was
    /// ElasticPremium sku
    /// </summary>
    [JsonPropertyName("elasticScaleEnabled")]
    public bool? ElasticScaleEnabled { get; set; }

    /// <summary>ExtendedLocation: Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250501ServerFarmSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FreeOfferExpirationTime: The time when the server farm free offer expires.</summary>
    [JsonPropertyName("freeOfferExpirationTime")]
    public string? FreeOfferExpirationTime { get; set; }

    /// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V20250501ServerFarmSpecHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary>HyperV: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>Identity: Managed service identity.</summary>
    [JsonPropertyName("identity")]
    public V20250501ServerFarmSpecIdentity? Identity { get; set; }

    /// <summary>InstallScripts: Install scripts associated with this App Service plan.</summary>
    [JsonPropertyName("installScripts")]
    public IList<V20250501ServerFarmSpecInstallScripts>? InstallScripts { get; set; }

    /// <summary>IsCustomMode: Whether this server farm is in custom mode.</summary>
    [JsonPropertyName("isCustomMode")]
    public bool? IsCustomMode { get; set; }

    /// <summary>IsSpot: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan owns spot instances.</summary>
    [JsonPropertyName("isSpot")]
    public bool? IsSpot { get; set; }

    /// <summary>IsXenon: Obsolete: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary>
    /// Kind: Kind of resource. If the resource is an app, you can refer to
    /// https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference
    /// for details supported values for kind.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
    [JsonPropertyName("kubeEnvironmentProfile")]
    public V20250501ServerFarmSpecKubeEnvironmentProfile? KubeEnvironmentProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaximumElasticWorkerCount: Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan</summary>
    [JsonPropertyName("maximumElasticWorkerCount")]
    public int? MaximumElasticWorkerCount { get; set; }

    /// <summary>Network: All network settings for the server farm.</summary>
    [JsonPropertyName("network")]
    public V20250501ServerFarmSpecNetwork? Network { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250501ServerFarmSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250501ServerFarmSpecOwner Owner { get; set; }

    /// <summary>
    /// PerSiteScaling: If &lt;code&gt;true&lt;/code&gt;, apps assigned to this App Service plan can be scaled independently.
    /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App Service plan will scale to all instances of the plan.
    /// </summary>
    [JsonPropertyName("perSiteScaling")]
    public bool? PerSiteScaling { get; set; }

    /// <summary>PlanDefaultIdentity: Identity to use by platform for various features and integrations using managed identity.</summary>
    [JsonPropertyName("planDefaultIdentity")]
    public V20250501ServerFarmSpecPlanDefaultIdentity? PlanDefaultIdentity { get; set; }

    /// <summary>
    /// RdpEnabled: If &lt;code&gt;true&lt;/code&gt;, RDP access is enabled for this App Service plan. Only applicable for IsCustomMode ASPs.
    /// If &lt;code&gt;false&lt;/code&gt;, RDP access is disabled.
    /// </summary>
    [JsonPropertyName("rdpEnabled")]
    public bool? RdpEnabled { get; set; }

    /// <summary>RegistryAdapters: Registry adapters associated with this App Service plan.</summary>
    [JsonPropertyName("registryAdapters")]
    public IList<V20250501ServerFarmSpecRegistryAdapters>? RegistryAdapters { get; set; }

    /// <summary>Reserved: If Linux app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>Sku: Description of a SKU for a scalable resource.</summary>
    [JsonPropertyName("sku")]
    public V20250501ServerFarmSpecSku? Sku { get; set; }

    /// <summary>SpotExpirationTime: The time when the server farm expires. Valid only if it is a spot server farm.</summary>
    [JsonPropertyName("spotExpirationTime")]
    public string? SpotExpirationTime { get; set; }

    /// <summary>StorageMounts: Storage mounts associated with this App Service plan.</summary>
    [JsonPropertyName("storageMounts")]
    public IList<V20250501ServerFarmSpecStorageMounts>? StorageMounts { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetWorkerCount: Scaling worker count.</summary>
    [JsonPropertyName("targetWorkerCount")]
    public int? TargetWorkerCount { get; set; }

    /// <summary>TargetWorkerSizeId: Scaling worker size ID.</summary>
    [JsonPropertyName("targetWorkerSizeId")]
    public int? TargetWorkerSizeId { get; set; }

    /// <summary>WorkerTierName: Target worker tier assigned to the App Service plan.</summary>
    [JsonPropertyName("workerTierName")]
    public string? WorkerTierName { get; set; }

    /// <summary>
    /// ZoneRedundant: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will perform availability zone balancing.
    /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will not perform availability zone balancing.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusConditions
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

/// <summary>ExtendedLocation: Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusExtendedLocation
{
    /// <summary>Name: Name of extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusHostingEnvironmentProfile
{
    /// <summary>Id: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Name of the App Service Environment.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Resource type of the App Service Environment.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>User Assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Client Id of user assigned identity</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Principal Id of user assigned identity</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusIdentity
{
    /// <summary>PrincipalId: Principal Id of managed service identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: Tenant of managed service identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user assigned identities associated with the resource. The user identity dictionary
    /// key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250501ServerFarmStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Source: Source of the install script.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusInstallScriptsSource
{
    /// <summary>SourceUri: Install script source URI where the install script file will be fetched from.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>Type: Type of the install script.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Server farm install script configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusInstallScripts
{
    /// <summary>Name: Name of the install script.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: Source of the install script.</summary>
    [JsonPropertyName("source")]
    public V20250501ServerFarmStatusInstallScriptsSource? Source { get; set; }
}

/// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusKubeEnvironmentProfile
{
    /// <summary>Id: Resource ID of the Kubernetes Environment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Name of the Kubernetes Environment.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Resource type of the Kubernetes Environment.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Network: All network settings for the server farm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusNetwork
{
    /// <summary>
    /// VirtualNetworkSubnetId: Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET
    /// Integration. This must be of the form
    /// /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>PlanDefaultIdentity: Identity to use by platform for various features and integrations using managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusPlanDefaultIdentity
{
    /// <summary>IdentityType: Type of managed service identity.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    [JsonPropertyName("userAssignedIdentityResourceId")]
    public string? UserAssignedIdentityResourceId { get; set; }
}

/// <summary>KeyVaultSecretReference: Key vault reference to the value that will be placed in the registry location</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusRegistryAdaptersKeyVaultSecretReference
{
    /// <summary>ReferenceStatus: Reference status of the key vault secret.</summary>
    [JsonPropertyName("referenceStatus")]
    public string? ReferenceStatus { get; set; }

    /// <summary>SecretUri: Key vault secret URI.</summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary>Server farm registry adapter configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusRegistryAdapters
{
    /// <summary>KeyVaultSecretReference: Key vault reference to the value that will be placed in the registry location</summary>
    [JsonPropertyName("keyVaultSecretReference")]
    public V20250501ServerFarmStatusRegistryAdaptersKeyVaultSecretReference? KeyVaultSecretReference { get; set; }

    /// <summary>RegistryKey: Registry key for the adapter.</summary>
    [JsonPropertyName("registryKey")]
    public string? RegistryKey { get; set; }

    /// <summary>Type: Type of the registry adapter.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Describes the capabilities/features allowed for a specific SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusSkuCapabilities
{
    /// <summary>Name: Name of the SKU capability.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reason: Reason of the SKU capability.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Value: Value of the SKU capability.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusSkuSkuCapacity
{
    /// <summary>Default: Default number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("default")]
    public int? Default { get; set; }

    /// <summary>ElasticMaximum: Maximum number of Elastic workers for this App Service plan SKU.</summary>
    [JsonPropertyName("elasticMaximum")]
    public int? ElasticMaximum { get; set; }

    /// <summary>Maximum: Maximum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary>Minimum: Minimum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary>ScaleType: Available scale configurations for an App Service plan.</summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Sku: Description of a SKU for a scalable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusSku
{
    /// <summary>Capabilities: Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
    [JsonPropertyName("capabilities")]
    public IList<V20250501ServerFarmStatusSkuCapabilities>? Capabilities { get; set; }

    /// <summary>Capacity: Current number of instances assigned to the resource.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Family code of the resource SKU.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Locations: Locations of the SKU.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Name: Name of the resource SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size specifier of the resource SKU.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
    [JsonPropertyName("skuCapacity")]
    public V20250501ServerFarmStatusSkuSkuCapacity? SkuCapacity { get; set; }

    /// <summary>Tier: Service tier of the resource SKU.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>CredentialsKeyVaultReference: KV reference to the credentials to connect to the share.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusStorageMountsCredentialsKeyVaultReference
{
    /// <summary>ReferenceStatus: Reference status of the key vault secret.</summary>
    [JsonPropertyName("referenceStatus")]
    public string? ReferenceStatus { get; set; }

    /// <summary>SecretUri: Key vault secret URI.</summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary>Server farm storage mount configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusStorageMounts
{
    /// <summary>CredentialsKeyVaultReference: KV reference to the credentials to connect to the share.</summary>
    [JsonPropertyName("credentialsKeyVaultReference")]
    public V20250501ServerFarmStatusStorageMountsCredentialsKeyVaultReference? CredentialsKeyVaultReference { get; set; }

    /// <summary>DestinationPath: Path on worker where storage will be mounted.</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>Name: Name of the storage mount.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Source: Source of the fileshare/storage.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Type: Type of the storage mount.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250501ServerFarmStatusSystemData
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
public partial class V20250501ServerFarmStatus
{
    /// <summary>
    /// AsyncScalingEnabled: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will attempt to scale asynchronously if there are
    /// insufficient workers to scale synchronously.
    /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will only attempt sync scaling.
    /// </summary>
    [JsonPropertyName("asyncScalingEnabled")]
    public bool? AsyncScalingEnabled { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250501ServerFarmStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ElasticScaleEnabled: ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was
    /// ElasticPremium sku
    /// </summary>
    [JsonPropertyName("elasticScaleEnabled")]
    public bool? ElasticScaleEnabled { get; set; }

    /// <summary>ExtendedLocation: Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250501ServerFarmStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FreeOfferExpirationTime: The time when the server farm free offer expires.</summary>
    [JsonPropertyName("freeOfferExpirationTime")]
    public string? FreeOfferExpirationTime { get; set; }

    /// <summary>GeoRegion: Geographical location for the App Service plan.</summary>
    [JsonPropertyName("geoRegion")]
    public string? GeoRegion { get; set; }

    /// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V20250501ServerFarmStatusHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary>HyperV: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed service identity.</summary>
    [JsonPropertyName("identity")]
    public V20250501ServerFarmStatusIdentity? Identity { get; set; }

    /// <summary>InstallScripts: Install scripts associated with this App Service plan.</summary>
    [JsonPropertyName("installScripts")]
    public IList<V20250501ServerFarmStatusInstallScripts>? InstallScripts { get; set; }

    /// <summary>IsCustomMode: Whether this server farm is in custom mode.</summary>
    [JsonPropertyName("isCustomMode")]
    public bool? IsCustomMode { get; set; }

    /// <summary>IsSpot: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan owns spot instances.</summary>
    [JsonPropertyName("isSpot")]
    public bool? IsSpot { get; set; }

    /// <summary>IsXenon: Obsolete: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary>
    /// Kind: Kind of resource. If the resource is an app, you can refer to
    /// https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference
    /// for details supported values for kind.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
    [JsonPropertyName("kubeEnvironmentProfile")]
    public V20250501ServerFarmStatusKubeEnvironmentProfile? KubeEnvironmentProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaximumElasticWorkerCount: Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan</summary>
    [JsonPropertyName("maximumElasticWorkerCount")]
    public int? MaximumElasticWorkerCount { get; set; }

    /// <summary>MaximumNumberOfWorkers: Maximum number of instances that can be assigned to this App Service plan.</summary>
    [JsonPropertyName("maximumNumberOfWorkers")]
    public int? MaximumNumberOfWorkers { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Network: All network settings for the server farm.</summary>
    [JsonPropertyName("network")]
    public V20250501ServerFarmStatusNetwork? Network { get; set; }

    /// <summary>NumberOfSites: Number of apps assigned to this App Service plan.</summary>
    [JsonPropertyName("numberOfSites")]
    public int? NumberOfSites { get; set; }

    /// <summary>NumberOfWorkers: The number of instances that are assigned to this App Service plan.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    /// <summary>
    /// PerSiteScaling: If &lt;code&gt;true&lt;/code&gt;, apps assigned to this App Service plan can be scaled independently.
    /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App Service plan will scale to all instances of the plan.
    /// </summary>
    [JsonPropertyName("perSiteScaling")]
    public bool? PerSiteScaling { get; set; }

    /// <summary>PlanDefaultIdentity: Identity to use by platform for various features and integrations using managed identity.</summary>
    [JsonPropertyName("planDefaultIdentity")]
    public V20250501ServerFarmStatusPlanDefaultIdentity? PlanDefaultIdentity { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the App Service Plan.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RdpEnabled: If &lt;code&gt;true&lt;/code&gt;, RDP access is enabled for this App Service plan. Only applicable for IsCustomMode ASPs.
    /// If &lt;code&gt;false&lt;/code&gt;, RDP access is disabled.
    /// </summary>
    [JsonPropertyName("rdpEnabled")]
    public bool? RdpEnabled { get; set; }

    /// <summary>RegistryAdapters: Registry adapters associated with this App Service plan.</summary>
    [JsonPropertyName("registryAdapters")]
    public IList<V20250501ServerFarmStatusRegistryAdapters>? RegistryAdapters { get; set; }

    /// <summary>Reserved: If Linux app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>ResourceGroup: Resource group of the App Service plan.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Sku: Description of a SKU for a scalable resource.</summary>
    [JsonPropertyName("sku")]
    public V20250501ServerFarmStatusSku? Sku { get; set; }

    /// <summary>SpotExpirationTime: The time when the server farm expires. Valid only if it is a spot server farm.</summary>
    [JsonPropertyName("spotExpirationTime")]
    public string? SpotExpirationTime { get; set; }

    /// <summary>Status: App Service plan status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>StorageMounts: Storage mounts associated with this App Service plan.</summary>
    [JsonPropertyName("storageMounts")]
    public IList<V20250501ServerFarmStatusStorageMounts>? StorageMounts { get; set; }

    /// <summary>Subscription: App Service plan subscription.</summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250501ServerFarmStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetWorkerCount: Scaling worker count.</summary>
    [JsonPropertyName("targetWorkerCount")]
    public int? TargetWorkerCount { get; set; }

    /// <summary>TargetWorkerSizeId: Scaling worker size ID.</summary>
    [JsonPropertyName("targetWorkerSizeId")]
    public int? TargetWorkerSizeId { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkerTierName: Target worker tier assigned to the App Service plan.</summary>
    [JsonPropertyName("workerTierName")]
    public string? WorkerTierName { get; set; }

    /// <summary>
    /// ZoneRedundant: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will perform availability zone balancing.
    /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will not perform availability zone balancing.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2025-05-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250501ServerFarm : IKubernetesObject<V1ObjectMeta>, ISpec<V20250501ServerFarmSpec?>, IStatus<V20250501ServerFarmStatus?>
{
    public const string KubeApiVersion = "v20250501";
    public const string KubeKind = "ServerFarm";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "serverfarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v20250501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerFarm";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250501ServerFarmSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250501ServerFarmStatus? Status { get; set; }
}