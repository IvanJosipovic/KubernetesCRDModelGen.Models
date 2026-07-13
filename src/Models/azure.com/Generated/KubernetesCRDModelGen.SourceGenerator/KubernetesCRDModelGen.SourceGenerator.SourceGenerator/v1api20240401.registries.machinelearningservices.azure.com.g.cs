#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/registries.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401RegistryList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401Registry>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "RegistryList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "registries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegistryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240401Registry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240401Registry> Items { get; set; }
}

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401RegistrySpecIdentityTypeEnum>))]
public enum V1api20240401RegistrySpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20240401RegistrySpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240401RegistrySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Managed service identity (system assigned and/or user assigned identities)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V1api20240401RegistrySpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240401RegistrySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// ResourceReference: Arm ResourceId is in the format
/// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}&quot;
/// or
/// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecManagedResourceGroupResourceReference
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

/// <summary>ManagedResourceGroup: ResourceId of the managed RG if the registry has system created resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecManagedResourceGroup
{
    /// <summary>
    /// ResourceReference: Arm ResourceId is in the format
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}&quot;
    /// or
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}&quot;
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401RegistrySpecManagedResourceGroupResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecOperatorSpecConfigMapExpressions
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

/// <summary>DiscoveryUrl: indicates where the DiscoveryUrl config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecOperatorSpecConfigMapsDiscoveryUrl
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// MlFlowRegistryUri: indicates where the MlFlowRegistryUri config map should be placed. If omitted, no config map will be
/// created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecOperatorSpecConfigMapsMlFlowRegistryUri
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecOperatorSpecConfigMaps
{
    /// <summary>DiscoveryUrl: indicates where the DiscoveryUrl config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("discoveryUrl")]
    public V1api20240401RegistrySpecOperatorSpecConfigMapsDiscoveryUrl? DiscoveryUrl { get; set; }

    /// <summary>
    /// MlFlowRegistryUri: indicates where the MlFlowRegistryUri config map should be placed. If omitted, no config map will be
    /// created.
    /// </summary>
    [JsonPropertyName("mlFlowRegistryUri")]
    public V1api20240401RegistrySpecOperatorSpecConfigMapsMlFlowRegistryUri? MlFlowRegistryUri { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecOperatorSpecSecretExpressions
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
public partial class V1api20240401RegistrySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401RegistrySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20240401RegistrySpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401RegistrySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SystemCreatedAcrAccount: Details of system created ACR account to be used for the Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegionDetailsAcrDetailsSystemCreatedAcrAccount
{
    /// <summary>AcrAccountName: Name of the ACR account</summary>
    [JsonPropertyName("acrAccountName")]
    public string? AcrAccountName { get; set; }

    /// <summary>AcrAccountSku: SKU of the ACR account</summary>
    [JsonPropertyName("acrAccountSku")]
    public string? AcrAccountSku { get; set; }
}

/// <summary>Details of ACR account to be used for the Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegionDetailsAcrDetails
{
    /// <summary>SystemCreatedAcrAccount: Details of system created ACR account to be used for the Registry</summary>
    [JsonPropertyName("systemCreatedAcrAccount")]
    public V1api20240401RegistrySpecRegionDetailsAcrDetailsSystemCreatedAcrAccount? SystemCreatedAcrAccount { get; set; }
}

/// <summary>SystemCreatedStorageAccount: Details of system created storage account to be used for the registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegionDetailsStorageAccountDetailsSystemCreatedStorageAccount
{
    /// <summary>AllowBlobPublicAccess: Public blob access allowed</summary>
    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    /// <summary>StorageAccountHnsEnabled: HNS enabled for storage account</summary>
    [JsonPropertyName("storageAccountHnsEnabled")]
    public bool? StorageAccountHnsEnabled { get; set; }

    /// <summary>StorageAccountName: Name of the storage account</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>
    /// StorageAccountType: Allowed values:
    /// &quot;Standard_LRS&quot;,
    /// &quot;Standard_GRS&quot;,
    /// &quot;Standard_RAGRS&quot;,
    /// &quot;Standard_ZRS&quot;,
    /// &quot;Standard_GZRS&quot;,
    /// &quot;Standard_RAGZRS&quot;,
    /// &quot;Premium_LRS&quot;,
    /// &quot;Premium_ZRS&quot;
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Details of storage account to be used for the Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegionDetailsStorageAccountDetails
{
    /// <summary>SystemCreatedStorageAccount: Details of system created storage account to be used for the registry</summary>
    [JsonPropertyName("systemCreatedStorageAccount")]
    public V1api20240401RegistrySpecRegionDetailsStorageAccountDetailsSystemCreatedStorageAccount? SystemCreatedStorageAccount { get; set; }
}

/// <summary>Details for each region the registry is in</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegionDetails
{
    /// <summary>AcrDetails: List of ACR accounts</summary>
    [JsonPropertyName("acrDetails")]
    public IList<V1api20240401RegistrySpecRegionDetailsAcrDetails>? AcrDetails { get; set; }

    /// <summary>Location: The location where the registry exists</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>StorageAccountDetails: List of storage accounts</summary>
    [JsonPropertyName("storageAccountDetails")]
    public IList<V1api20240401RegistrySpecRegionDetailsStorageAccountDetails>? StorageAccountDetails { get; set; }
}

/// <summary>SubnetArmReference: The subnetId that the private endpoint is connected to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsPrivateEndpointSubnetArmReference
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

/// <summary>PrivateEndpoint: The PE network resource that is linked to this PE connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsPrivateEndpoint
{
    /// <summary>SubnetArmReference: The subnetId that the private endpoint is connected to.</summary>
    [JsonPropertyName("subnetArmReference")]
    public V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsPrivateEndpointSubnetArmReference? SubnetArmReference { get; set; }
}

/// <summary>
/// Reference: This is the private endpoint connection name created on SRP
/// Full resource id:
/// /subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.MachineLearningServices/{resourceType}/{resourceName}/registryPrivateEndpointConnections/{peConnectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsReference
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

/// <summary>Status: Connection status of the service consumer with the service provider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionStateStatusEnum>))]
public enum V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionStateStatusEnum
{
    [EnumMember(Value = "Approved"), JsonStringEnumMemberName("Approved")]
    Approved,
    [EnumMember(Value = "Disconnected"), JsonStringEnumMemberName("Disconnected")]
    Disconnected,
    [EnumMember(Value = "Pending"), JsonStringEnumMemberName("Pending")]
    Pending,
    [EnumMember(Value = "Rejected"), JsonStringEnumMemberName("Rejected")]
    Rejected
}

/// <summary>RegistryPrivateLinkServiceConnectionState: The connection state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: Some RP chose &quot;None&quot;. Other RPs use this for region expansion.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: User-defined message that, per NRP doc, may be used for approval-related message.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Connection status of the service consumer with the service provider</summary>
    [JsonPropertyName("status")]
    public V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionStateStatusEnum? Status { get; set; }
}

/// <summary>Private endpoint connection definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecRegistryPrivateEndpointConnections
{
    /// <summary>GroupIds: The group ids</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>Location: Same as workspace location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>PrivateEndpoint: The PE network resource that is linked to this PE connection.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>ProvisioningState: One of null, &quot;Succeeded&quot;, &quot;Provisioning&quot;, &quot;Failed&quot;. While not approved, it&apos;s null.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Reference: This is the private endpoint connection name created on SRP
    /// Full resource id:
    /// /subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.MachineLearningServices/{resourceType}/{resourceName}/registryPrivateEndpointConnections/{peConnectionName}
    /// </summary>
    [JsonPropertyName("reference")]
    public V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsReference? Reference { get; set; }

    /// <summary>RegistryPrivateLinkServiceConnectionState: The connection state.</summary>
    [JsonPropertyName("registryPrivateLinkServiceConnectionState")]
    public V1api20240401RegistrySpecRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionState? RegistryPrivateLinkServiceConnectionState { get; set; }
}

/// <summary>
/// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
/// not  required on a PUT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401RegistrySpecSkuTierEnum>))]
public enum V1api20240401RegistrySpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: Sku details required for ARM contract for Autoscaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpecSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not  required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20240401RegistrySpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistrySpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DiscoveryUrl: Discovery URL for the Registry</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Identity: Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20240401RegistrySpecIdentity? Identity { get; set; }

    /// <summary>IntellectualPropertyPublisher: IntellectualPropertyPublisher for the registry</summary>
    [JsonPropertyName("intellectualPropertyPublisher")]
    public string? IntellectualPropertyPublisher { get; set; }

    /// <summary>Kind: Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>ManagedResourceGroup: ResourceId of the managed RG if the registry has system created resources</summary>
    [JsonPropertyName("managedResourceGroup")]
    public V1api20240401RegistrySpecManagedResourceGroup? ManagedResourceGroup { get; set; }

    /// <summary>MlFlowRegistryUri: MLFlow Registry URI for the Registry</summary>
    [JsonPropertyName("mlFlowRegistryUri")]
    public string? MlFlowRegistryUri { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401RegistrySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240401RegistrySpecOwner Owner { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Is the Registry accessible from the internet?
    /// Possible values: &quot;Enabled&quot; or &quot;Disabled&quot;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>RegionDetails: Details of each region the registry is in</summary>
    [JsonPropertyName("regionDetails")]
    public IList<V1api20240401RegistrySpecRegionDetails>? RegionDetails { get; set; }

    /// <summary>RegistryPrivateEndpointConnections: Private endpoint connections info used for pending connections in private link portal</summary>
    [JsonPropertyName("registryPrivateEndpointConnections")]
    public IList<V1api20240401RegistrySpecRegistryPrivateEndpointConnections>? RegistryPrivateEndpointConnections { get; set; }

    /// <summary>Sku: Sku details required for ARM contract for Autoscaling.</summary>
    [JsonPropertyName("sku")]
    public V1api20240401RegistrySpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusConditions
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

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Managed service identity (system assigned and/or user assigned identities)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240401RegistryStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ManagedResourceGroup: ResourceId of the managed RG if the registry has system created resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusManagedResourceGroup
{
    /// <summary>
    /// ResourceId: Arm ResourceId is in the format
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}&quot;
    /// or
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}&quot;
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>ArmResourceId: This is populated once the ACR account is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetailsAcrDetailsSystemCreatedAcrAccountArmResourceId
{
    /// <summary>
    /// ResourceId: Arm ResourceId is in the format
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}&quot;
    /// or
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}&quot;
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>SystemCreatedAcrAccount: Details of system created ACR account to be used for the Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetailsAcrDetailsSystemCreatedAcrAccount
{
    /// <summary>AcrAccountName: Name of the ACR account</summary>
    [JsonPropertyName("acrAccountName")]
    public string? AcrAccountName { get; set; }

    /// <summary>AcrAccountSku: SKU of the ACR account</summary>
    [JsonPropertyName("acrAccountSku")]
    public string? AcrAccountSku { get; set; }

    /// <summary>ArmResourceId: This is populated once the ACR account is created.</summary>
    [JsonPropertyName("armResourceId")]
    public V1api20240401RegistryStatusRegionDetailsAcrDetailsSystemCreatedAcrAccountArmResourceId? ArmResourceId { get; set; }
}

/// <summary>Details of ACR account to be used for the Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetailsAcrDetails
{
    /// <summary>SystemCreatedAcrAccount: Details of system created ACR account to be used for the Registry</summary>
    [JsonPropertyName("systemCreatedAcrAccount")]
    public V1api20240401RegistryStatusRegionDetailsAcrDetailsSystemCreatedAcrAccount? SystemCreatedAcrAccount { get; set; }
}

/// <summary>ArmResourceId: This is populated once the storage account is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetailsStorageAccountDetailsSystemCreatedStorageAccountArmResourceId
{
    /// <summary>
    /// ResourceId: Arm ResourceId is in the format
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}&quot;
    /// or
    /// &quot;/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}&quot;
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>SystemCreatedStorageAccount: Details of system created storage account to be used for the registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetailsStorageAccountDetailsSystemCreatedStorageAccount
{
    /// <summary>AllowBlobPublicAccess: Public blob access allowed</summary>
    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    /// <summary>ArmResourceId: This is populated once the storage account is created.</summary>
    [JsonPropertyName("armResourceId")]
    public V1api20240401RegistryStatusRegionDetailsStorageAccountDetailsSystemCreatedStorageAccountArmResourceId? ArmResourceId { get; set; }

    /// <summary>StorageAccountHnsEnabled: HNS enabled for storage account</summary>
    [JsonPropertyName("storageAccountHnsEnabled")]
    public bool? StorageAccountHnsEnabled { get; set; }

    /// <summary>StorageAccountName: Name of the storage account</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>
    /// StorageAccountType: Allowed values:
    /// &quot;Standard_LRS&quot;,
    /// &quot;Standard_GRS&quot;,
    /// &quot;Standard_RAGRS&quot;,
    /// &quot;Standard_ZRS&quot;,
    /// &quot;Standard_GZRS&quot;,
    /// &quot;Standard_RAGZRS&quot;,
    /// &quot;Premium_LRS&quot;,
    /// &quot;Premium_ZRS&quot;
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Details of storage account to be used for the Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetailsStorageAccountDetails
{
    /// <summary>SystemCreatedStorageAccount: Details of system created storage account to be used for the registry</summary>
    [JsonPropertyName("systemCreatedStorageAccount")]
    public V1api20240401RegistryStatusRegionDetailsStorageAccountDetailsSystemCreatedStorageAccount? SystemCreatedStorageAccount { get; set; }
}

/// <summary>Details for each region the registry is in</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegionDetails
{
    /// <summary>AcrDetails: List of ACR accounts</summary>
    [JsonPropertyName("acrDetails")]
    public IList<V1api20240401RegistryStatusRegionDetailsAcrDetails>? AcrDetails { get; set; }

    /// <summary>Location: The location where the registry exists</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>StorageAccountDetails: List of storage accounts</summary>
    [JsonPropertyName("storageAccountDetails")]
    public IList<V1api20240401RegistryStatusRegionDetailsStorageAccountDetails>? StorageAccountDetails { get; set; }
}

/// <summary>PrivateEndpoint: The PE network resource that is linked to this PE connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegistryPrivateEndpointConnectionsPrivateEndpoint
{
    /// <summary>Id: The ARM identifier for Private Endpoint</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>SubnetArmId: The subnetId that the private endpoint is connected to.</summary>
    [JsonPropertyName("subnetArmId")]
    public string? SubnetArmId { get; set; }
}

/// <summary>RegistryPrivateLinkServiceConnectionState: The connection state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: Some RP chose &quot;None&quot;. Other RPs use this for region expansion.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: User-defined message that, per NRP doc, may be used for approval-related message.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Connection status of the service consumer with the service provider</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Private endpoint connection definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusRegistryPrivateEndpointConnections
{
    /// <summary>GroupIds: The group ids</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>
    /// Id: This is the private endpoint connection name created on SRP
    /// Full resource id:
    /// /subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.MachineLearningServices/{resourceType}/{resourceName}/registryPrivateEndpointConnections/{peConnectionName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Same as workspace location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>PrivateEndpoint: The PE network resource that is linked to this PE connection.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240401RegistryStatusRegistryPrivateEndpointConnectionsPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>ProvisioningState: One of null, &quot;Succeeded&quot;, &quot;Provisioning&quot;, &quot;Failed&quot;. While not approved, it&apos;s null.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RegistryPrivateLinkServiceConnectionState: The connection state.</summary>
    [JsonPropertyName("registryPrivateLinkServiceConnectionState")]
    public V1api20240401RegistryStatusRegistryPrivateEndpointConnectionsRegistryPrivateLinkServiceConnectionState? RegistryPrivateLinkServiceConnectionState { get; set; }
}

/// <summary>Sku: Sku details required for ARM contract for Autoscaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not  required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401RegistryStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401RegistryStatusConditions>? Conditions { get; set; }

    /// <summary>DiscoveryUrl: Discovery URL for the Registry</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed service identity (system assigned and/or user assigned identities)</summary>
    [JsonPropertyName("identity")]
    public V1api20240401RegistryStatusIdentity? Identity { get; set; }

    /// <summary>IntellectualPropertyPublisher: IntellectualPropertyPublisher for the registry</summary>
    [JsonPropertyName("intellectualPropertyPublisher")]
    public string? IntellectualPropertyPublisher { get; set; }

    /// <summary>Kind: Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedResourceGroup: ResourceId of the managed RG if the registry has system created resources</summary>
    [JsonPropertyName("managedResourceGroup")]
    public V1api20240401RegistryStatusManagedResourceGroup? ManagedResourceGroup { get; set; }

    /// <summary>MlFlowRegistryUri: MLFlow Registry URI for the Registry</summary>
    [JsonPropertyName("mlFlowRegistryUri")]
    public string? MlFlowRegistryUri { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Is the Registry accessible from the internet?
    /// Possible values: &quot;Enabled&quot; or &quot;Disabled&quot;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>RegionDetails: Details of each region the registry is in</summary>
    [JsonPropertyName("regionDetails")]
    public IList<V1api20240401RegistryStatusRegionDetails>? RegionDetails { get; set; }

    /// <summary>RegistryPrivateEndpointConnections: Private endpoint connections info used for pending connections in private link portal</summary>
    [JsonPropertyName("registryPrivateEndpointConnections")]
    public IList<V1api20240401RegistryStatusRegistryPrivateEndpointConnections>? RegistryPrivateEndpointConnections { get; set; }

    /// <summary>Sku: Sku details required for ARM contract for Autoscaling.</summary>
    [JsonPropertyName("sku")]
    public V1api20240401RegistryStatusSku? Sku { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401RegistryStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/registries.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401Registry : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401RegistrySpec?>, IStatus<V1api20240401RegistryStatus?>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "Registry";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "registries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Registry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240401RegistrySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240401RegistryStatus? Status { get; set; }
}