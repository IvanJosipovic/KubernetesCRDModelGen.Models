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
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401WorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401Workspace>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240401Workspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240401Workspace> Items { get; set; }
}

/// <summary>ApplicationInsightsReference: ARM id of the application insights associated with this workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecApplicationInsightsReference
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

/// <summary>ContainerRegistryReference: ARM id of the container registry associated with this workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecContainerRegistryReference
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
/// UserAssignedIdentityReference: The ArmId of the user assigned identity that will be used to access the customer managed
/// key vault
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecEncryptionIdentityUserAssignedIdentityReference
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

/// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecEncryptionIdentity
{
    /// <summary>
    /// UserAssignedIdentityReference: The ArmId of the user assigned identity that will be used to access the customer managed
    /// key vault
    /// </summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20240401WorkspaceSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>IdentityClientIdFromConfig: For future use - The client id of the identity which will be used to access key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecEncryptionKeyVaultPropertiesIdentityClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>KeyVaultArmReference: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecEncryptionKeyVaultPropertiesKeyVaultArmReference
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

/// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecEncryptionKeyVaultProperties
{
    /// <summary>IdentityClientId: For future use - The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>IdentityClientIdFromConfig: For future use - The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identityClientIdFromConfig")]
    public V1api20240401WorkspaceSpecEncryptionKeyVaultPropertiesIdentityClientIdFromConfig? IdentityClientIdFromConfig { get; set; }

    /// <summary>KeyIdentifier: Key vault uri to access the encryption key.</summary>
    [JsonPropertyName("keyIdentifier")]
    public required string KeyIdentifier { get; set; }

    /// <summary>KeyVaultArmReference: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
    [JsonPropertyName("keyVaultArmReference")]
    public required V1api20240401WorkspaceSpecEncryptionKeyVaultPropertiesKeyVaultArmReference KeyVaultArmReference { get; set; }
}

/// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecEncryption
{
    /// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V1api20240401WorkspaceSpecEncryptionIdentity? Identity { get; set; }

    /// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public required V1api20240401WorkspaceSpecEncryptionKeyVaultProperties KeyVaultProperties { get; set; }
}

/// <summary>ComputeRuntime: Compute runtime config for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecFeatureStoreSettingsComputeRuntime
{
    [JsonPropertyName("sparkRuntimeVersion")]
    public string? SparkRuntimeVersion { get; set; }
}

/// <summary>FeatureStoreSettings: Settings for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecFeatureStoreSettings
{
    /// <summary>ComputeRuntime: Compute runtime config for feature store type workspace.</summary>
    [JsonPropertyName("computeRuntime")]
    public V1api20240401WorkspaceSpecFeatureStoreSettingsComputeRuntime? ComputeRuntime { get; set; }

    [JsonPropertyName("offlineStoreConnectionName")]
    public string? OfflineStoreConnectionName { get; set; }

    [JsonPropertyName("onlineStoreConnectionName")]
    public string? OnlineStoreConnectionName { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecHubResourceReference
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

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecIdentityTypeEnum>))]
public enum V1api20240401WorkspaceSpecIdentityTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20240401WorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240401WorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V1api20240401WorkspaceSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240401WorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has
/// been created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecKeyVaultReference
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

/// <summary>IsolationMode: Isolation mode for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkIsolationModeEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkIsolationModeEnum
{
    [EnumMember(Value = "AllowInternetOutbound"), JsonStringEnumMemberName("AllowInternetOutbound")]
    AllowInternetOutbound,
    [EnumMember(Value = "AllowOnlyApprovedOutbound"), JsonStringEnumMemberName("AllowOnlyApprovedOutbound")]
    AllowOnlyApprovedOutbound,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnCategoryEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnCategoryEnum
{
    [EnumMember(Value = "Dependency"), JsonStringEnumMemberName("Dependency")]
    Dependency,
    [EnumMember(Value = "Recommended"), JsonStringEnumMemberName("Recommended")]
    Recommended,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "UserDefined"), JsonStringEnumMemberName("UserDefined")]
    UserDefined
}

/// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnStatusEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnStatusEnum
{
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnTypeEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnTypeEnum
{
    [EnumMember(Value = "FQDN"), JsonStringEnumMemberName("FQDN")]
    FQDN
}

/// <summary>FQDN: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdn
{
    /// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnCategoryEnum? Category { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnStatusEnum? Status { get; set; }

    [JsonPropertyName("type")]
    public required V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdnTypeEnum Type { get; set; }
}

/// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointCategoryEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointCategoryEnum
{
    [EnumMember(Value = "Dependency"), JsonStringEnumMemberName("Dependency")]
    Dependency,
    [EnumMember(Value = "Recommended"), JsonStringEnumMemberName("Recommended")]
    Recommended,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "UserDefined"), JsonStringEnumMemberName("UserDefined")]
    UserDefined
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationServiceResourceReference
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

/// <summary>SparkStatus: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSparkStatusEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSparkStatusEnum
{
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSubresourceTargetReference
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
/// Destination: Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine
/// learning  workspace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestination
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("serviceResourceReference")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationServiceResourceReference? ServiceResourceReference { get; set; }

    [JsonPropertyName("sparkEnabled")]
    public bool? SparkEnabled { get; set; }

    /// <summary>SparkStatus: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("sparkStatus")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSparkStatusEnum? SparkStatus { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("subresourceTargetReference")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestinationSubresourceTargetReference? SubresourceTargetReference { get; set; }
}

/// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointStatusEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointStatusEnum
{
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointTypeEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointTypeEnum
{
    [EnumMember(Value = "PrivateEndpoint"), JsonStringEnumMemberName("PrivateEndpoint")]
    PrivateEndpoint
}

/// <summary>PrivateEndpoint: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpoint
{
    /// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointCategoryEnum? Category { get; set; }

    /// <summary>
    /// Destination: Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine
    /// learning  workspace.
    /// </summary>
    [JsonPropertyName("destination")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointDestination? Destination { get; set; }

    /// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointStatusEnum? Status { get; set; }

    [JsonPropertyName("type")]
    public required V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpointTypeEnum Type { get; set; }
}

/// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagCategoryEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagCategoryEnum
{
    [EnumMember(Value = "Dependency"), JsonStringEnumMemberName("Dependency")]
    Dependency,
    [EnumMember(Value = "Recommended"), JsonStringEnumMemberName("Recommended")]
    Recommended,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "UserDefined"), JsonStringEnumMemberName("UserDefined")]
    UserDefined
}

/// <summary>Action: The action enum for networking rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagDestinationActionEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagDestinationActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>
/// Destination: Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning
/// workspace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagDestination
{
    /// <summary>Action: The action enum for networking rule.</summary>
    [JsonPropertyName("action")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagDestinationActionEnum? Action { get; set; }

    [JsonPropertyName("portRanges")]
    public string? PortRanges { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }
}

/// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagStatusEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagStatusEnum
{
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagTypeEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagTypeEnum
{
    [EnumMember(Value = "ServiceTag"), JsonStringEnumMemberName("ServiceTag")]
    ServiceTag
}

/// <summary>ServiceTag: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTag
{
    /// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("category")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagCategoryEnum? Category { get; set; }

    /// <summary>
    /// Destination: Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning
    /// workspace.
    /// </summary>
    [JsonPropertyName("destination")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagDestination? Destination { get; set; }

    /// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagStatusEnum? Status { get; set; }

    [JsonPropertyName("type")]
    public required V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTagTypeEnum Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkOutboundRules
{
    /// <summary>FQDN: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("fqdn")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesFqdn? Fqdn { get; set; }

    /// <summary>PrivateEndpoint: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>ServiceTag: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceTag")]
    public V1api20240401WorkspaceSpecManagedNetworkOutboundRulesServiceTag? ServiceTag { get; set; }
}

/// <summary>Status: Status for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecManagedNetworkStatusStatusEnum>))]
public enum V1api20240401WorkspaceSpecManagedNetworkStatusStatusEnum
{
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive
}

/// <summary>Status: Status of the Provisioning for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetworkStatus
{
    [JsonPropertyName("sparkReady")]
    public bool? SparkReady { get; set; }

    /// <summary>Status: Status for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceSpecManagedNetworkStatusStatusEnum? Status { get; set; }
}

/// <summary>ManagedNetwork: Managed Network settings for a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecManagedNetwork
{
    /// <summary>IsolationMode: Isolation mode for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public V1api20240401WorkspaceSpecManagedNetworkIsolationModeEnum? IsolationMode { get; set; }

    [JsonPropertyName("outboundRules")]
    public IDictionary<string, V1api20240401WorkspaceSpecManagedNetworkOutboundRules>? OutboundRules { get; set; }

    /// <summary>Status: Status of the Provisioning for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceSpecManagedNetworkStatus? Status { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretExpressions
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
/// AppInsightsInstrumentationKey: indicates where the AppInsightsInstrumentationKey secret should be placed. If omitted,
/// the secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ContainerRegistryPassword: indicates where the ContainerRegistryPassword secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ContainerRegistryPassword2: indicates where the ContainerRegistryPassword2 secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ContainerRegistryUserName: indicates where the ContainerRegistryUserName secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsContainerRegistryUserName
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PrimaryNotebookAccessKey: indicates where the PrimaryNotebookAccessKey secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecondaryNotebookAccessKey: indicates where the SecondaryNotebookAccessKey secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// UserStorageKey: indicates where the UserStorageKey secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecretsUserStorageKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpecSecrets
{
    /// <summary>
    /// AppInsightsInstrumentationKey: indicates where the AppInsightsInstrumentationKey secret should be placed. If omitted,
    /// the secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("appInsightsInstrumentationKey")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey? AppInsightsInstrumentationKey { get; set; }

    /// <summary>
    /// ContainerRegistryPassword: indicates where the ContainerRegistryPassword secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("containerRegistryPassword")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword? ContainerRegistryPassword { get; set; }

    /// <summary>
    /// ContainerRegistryPassword2: indicates where the ContainerRegistryPassword2 secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("containerRegistryPassword2")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2? ContainerRegistryPassword2 { get; set; }

    /// <summary>
    /// ContainerRegistryUserName: indicates where the ContainerRegistryUserName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("containerRegistryUserName")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsContainerRegistryUserName? ContainerRegistryUserName { get; set; }

    /// <summary>
    /// PrimaryNotebookAccessKey: indicates where the PrimaryNotebookAccessKey secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryNotebookAccessKey")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey? PrimaryNotebookAccessKey { get; set; }

    /// <summary>
    /// SecondaryNotebookAccessKey: indicates where the SecondaryNotebookAccessKey secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryNotebookAccessKey")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey? SecondaryNotebookAccessKey { get; set; }

    /// <summary>
    /// UserStorageKey: indicates where the UserStorageKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("userStorageKey")]
    public V1api20240401WorkspaceSpecOperatorSpecSecretsUserStorageKey? UserStorageKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401WorkspaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401WorkspaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20240401WorkspaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecPrimaryUserAssignedIdentityReference
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

/// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecPublicNetworkAccessEnum>))]
public enum V1api20240401WorkspaceSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// ServerlessComputeCustomSubnetReference: The resource ID of an existing virtual network subnet in which serverless
/// compute nodes should be deployed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecServerlessComputeSettingsServerlessComputeCustomSubnetReference
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

/// <summary>ServerlessComputeSettings: Settings for serverless compute created in the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecServerlessComputeSettings
{
    /// <summary>
    /// ServerlessComputeCustomSubnetReference: The resource ID of an existing virtual network subnet in which serverless
    /// compute nodes should be deployed
    /// </summary>
    [JsonPropertyName("serverlessComputeCustomSubnetReference")]
    public V1api20240401WorkspaceSpecServerlessComputeSettingsServerlessComputeCustomSubnetReference? ServerlessComputeCustomSubnetReference { get; set; }

    /// <summary>
    /// ServerlessComputeNoPublicIP: The flag to signal if serverless compute nodes deployed in custom vNet would have no public
    /// IP addresses for a workspace with private endpoint
    /// </summary>
    [JsonPropertyName("serverlessComputeNoPublicIP")]
    public bool? ServerlessComputeNoPublicIP { get; set; }
}

/// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>CollectionsThroughput: The throughput of the collections in cosmosdb database</summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecServiceManagedResourcesSettings
{
    /// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20240401WorkspaceSpecServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

/// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference
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

/// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecSharedPrivateLinkResourcesStatusEnum>))]
public enum V1api20240401WorkspaceSpecSharedPrivateLinkResourcesStatusEnum
{
    [EnumMember(Value = "Approved"), JsonStringEnumMemberName("Approved")]
    Approved,
    [EnumMember(Value = "Disconnected"), JsonStringEnumMemberName("Disconnected")]
    Disconnected,
    [EnumMember(Value = "Pending"), JsonStringEnumMemberName("Pending")]
    Pending,
    [EnumMember(Value = "Rejected"), JsonStringEnumMemberName("Rejected")]
    Rejected,
    [EnumMember(Value = "Timeout"), JsonStringEnumMemberName("Timeout")]
    Timeout
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecSharedPrivateLinkResources
{
    /// <summary>GroupId: The private link resource group id.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: Unique name of the private link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
    [JsonPropertyName("privateLinkResourceReference")]
    public V1api20240401WorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference? PrivateLinkResourceReference { get; set; }

    /// <summary>RequestMessage: Request message.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceSpecSharedPrivateLinkResourcesStatusEnum? Status { get; set; }
}

/// <summary>
/// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
/// not  required on a PUT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspaceSpecSkuTierEnum>))]
public enum V1api20240401WorkspaceSpecSkuTierEnum
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

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecSku
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
    public V1api20240401WorkspaceSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>
/// StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the
/// workspace has been created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecStorageAccountReference
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

/// <summary>WorkspaceHubConfig: WorkspaceHub&apos;s configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpecWorkspaceHubConfig
{
    [JsonPropertyName("additionalWorkspaceStorageAccounts")]
    public IList<string>? AdditionalWorkspaceStorageAccounts { get; set; }

    [JsonPropertyName("defaultWorkspaceResourceGroup")]
    public string? DefaultWorkspaceResourceGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceSpec
{
    /// <summary>AllowPublicAccessWhenBehindVnet: The flag to indicate whether to allow public access when behind VNet.</summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary>ApplicationInsightsReference: ARM id of the application insights associated with this workspace.</summary>
    [JsonPropertyName("applicationInsightsReference")]
    public V1api20240401WorkspaceSpecApplicationInsightsReference? ApplicationInsightsReference { get; set; }

    [JsonPropertyName("associatedWorkspaces")]
    public IList<string>? AssociatedWorkspaces { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ContainerRegistryReference: ARM id of the container registry associated with this workspace.</summary>
    [JsonPropertyName("containerRegistryReference")]
    public V1api20240401WorkspaceSpecContainerRegistryReference? ContainerRegistryReference { get; set; }

    /// <summary>Description: The description of this workspace.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DiscoveryUrl: Url for the discovery service to identify regional endpoints for machine learning experimentation services</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    [JsonPropertyName("enableDataIsolation")]
    public bool? EnableDataIsolation { get; set; }

    /// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
    [JsonPropertyName("encryption")]
    public V1api20240401WorkspaceSpecEncryption? Encryption { get; set; }

    /// <summary>FeatureStoreSettings: Settings for feature store type workspace.</summary>
    [JsonPropertyName("featureStoreSettings")]
    public V1api20240401WorkspaceSpecFeatureStoreSettings? FeatureStoreSettings { get; set; }

    /// <summary>FriendlyName: The friendly name for this workspace. This name in mutable</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>HbiWorkspace: The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service</summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("hubResourceReference")]
    public V1api20240401WorkspaceSpecHubResourceReference? HubResourceReference { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240401WorkspaceSpecIdentity? Identity { get; set; }

    /// <summary>ImageBuildCompute: The compute name for image build</summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary>
    /// KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has
    /// been created
    /// </summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20240401WorkspaceSpecKeyVaultReference? KeyVaultReference { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedNetwork: Managed Network settings for a machine learning workspace.</summary>
    [JsonPropertyName("managedNetwork")]
    public V1api20240401WorkspaceSpecManagedNetwork? ManagedNetwork { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401WorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240401WorkspaceSpecOwner Owner { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20240401WorkspaceSpecPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20240401WorkspaceSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>ServerlessComputeSettings: Settings for serverless compute created in the workspace</summary>
    [JsonPropertyName("serverlessComputeSettings")]
    public V1api20240401WorkspaceSpecServerlessComputeSettings? ServerlessComputeSettings { get; set; }

    /// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20240401WorkspaceSpecServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary>SharedPrivateLinkResources: The list of shared private link resources in this workspace.</summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20240401WorkspaceSpecSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20240401WorkspaceSpecSku? Sku { get; set; }

    /// <summary>
    /// StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the
    /// workspace has been created
    /// </summary>
    [JsonPropertyName("storageAccountReference")]
    public V1api20240401WorkspaceSpecStorageAccountReference? StorageAccountReference { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>V1LegacyMode: Enabling v1_legacy_mode may prevent you from using features provided by the v2 API.</summary>
    [JsonPropertyName("v1LegacyMode")]
    public bool? V1LegacyMode { get; set; }

    /// <summary>WorkspaceHubConfig: WorkspaceHub&apos;s configuration object.</summary>
    [JsonPropertyName("workspaceHubConfig")]
    public V1api20240401WorkspaceSpecWorkspaceHubConfig? WorkspaceHubConfig { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusConditions
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

/// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusEncryptionIdentity
{
    /// <summary>UserAssignedIdentity: The ArmId of the user assigned identity that will be used to access the customer managed key vault</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusEncryptionKeyVaultProperties
{
    /// <summary>IdentityClientId: For future use - The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>KeyIdentifier: Key vault uri to access the encryption key.</summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary>KeyVaultArmId: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
    [JsonPropertyName("keyVaultArmId")]
    public string? KeyVaultArmId { get; set; }
}

/// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusEncryption
{
    /// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V1api20240401WorkspaceStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20240401WorkspaceStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary>Status: Indicates whether or not the encryption is enabled for the workspace.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ComputeRuntime: Compute runtime config for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusFeatureStoreSettingsComputeRuntime
{
    [JsonPropertyName("sparkRuntimeVersion")]
    public string? SparkRuntimeVersion { get; set; }
}

/// <summary>FeatureStoreSettings: Settings for feature store type workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusFeatureStoreSettings
{
    /// <summary>ComputeRuntime: Compute runtime config for feature store type workspace.</summary>
    [JsonPropertyName("computeRuntime")]
    public V1api20240401WorkspaceStatusFeatureStoreSettingsComputeRuntime? ComputeRuntime { get; set; }

    [JsonPropertyName("offlineStoreConnectionName")]
    public string? OfflineStoreConnectionName { get; set; }

    [JsonPropertyName("onlineStoreConnectionName")]
    public string? OnlineStoreConnectionName { get; set; }
}

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusIdentity
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
    public IDictionary<string, V1api20240401WorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>FQDN: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkOutboundRulesFqdn
{
    /// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Destination: Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine
/// learning  workspace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkOutboundRulesPrivateEndpointDestination
{
    [JsonPropertyName("serviceResourceId")]
    public string? ServiceResourceId { get; set; }

    [JsonPropertyName("sparkEnabled")]
    public bool? SparkEnabled { get; set; }

    /// <summary>SparkStatus: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("sparkStatus")]
    public string? SparkStatus { get; set; }

    [JsonPropertyName("subresourceTarget")]
    public string? SubresourceTarget { get; set; }
}

/// <summary>PrivateEndpoint: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkOutboundRulesPrivateEndpoint
{
    /// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Destination: Private Endpoint destination for a Private Endpoint Outbound Rule for the managed network of a machine
    /// learning  workspace.
    /// </summary>
    [JsonPropertyName("destination")]
    public V1api20240401WorkspaceStatusManagedNetworkOutboundRulesPrivateEndpointDestination? Destination { get; set; }

    /// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Destination: Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning
/// workspace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkOutboundRulesServiceTagDestination
{
    /// <summary>Action: The action enum for networking rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>AddressPrefixes: Optional, if provided, the ServiceTag property will be ignored.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    [JsonPropertyName("portRanges")]
    public string? PortRanges { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }
}

/// <summary>ServiceTag: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkOutboundRulesServiceTag
{
    /// <summary>Category: Category of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Destination: Service Tag destination for a Service Tag Outbound Rule for the managed network of a machine learning
    /// workspace.
    /// </summary>
    [JsonPropertyName("destination")]
    public V1api20240401WorkspaceStatusManagedNetworkOutboundRulesServiceTagDestination? Destination { get; set; }

    /// <summary>Status: Type of a managed network Outbound Rule of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkOutboundRules
{
    /// <summary>FQDN: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("fqdn")]
    public V1api20240401WorkspaceStatusManagedNetworkOutboundRulesFqdn? Fqdn { get; set; }

    /// <summary>PrivateEndpoint: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240401WorkspaceStatusManagedNetworkOutboundRulesPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>ServiceTag: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceTag")]
    public V1api20240401WorkspaceStatusManagedNetworkOutboundRulesServiceTag? ServiceTag { get; set; }
}

/// <summary>Status: Status of the Provisioning for the managed network of a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetworkStatus
{
    [JsonPropertyName("sparkReady")]
    public bool? SparkReady { get; set; }

    /// <summary>Status: Status for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ManagedNetwork: Managed Network settings for a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusManagedNetwork
{
    /// <summary>IsolationMode: Isolation mode for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    [JsonPropertyName("outboundRules")]
    public IDictionary<string, V1api20240401WorkspaceStatusManagedNetworkOutboundRules>? OutboundRules { get; set; }

    /// <summary>Status: Status of the Provisioning for the managed network of a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceStatusManagedNetworkStatus? Status { get; set; }
}

/// <summary>NotebookPreparationError: The error that occurs when preparing notebook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusNotebookInfoNotebookPreparationError
{
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>NotebookInfo: The notebook info of Azure ML workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusNotebookInfo
{
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>NotebookPreparationError: The error that occurs when preparing notebook.</summary>
    [JsonPropertyName("notebookPreparationError")]
    public V1api20240401WorkspaceStatusNotebookInfoNotebookPreparationError? NotebookPreparationError { get; set; }

    /// <summary>ResourceId: the data plane resourceId that used to initialize notebook component</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>The Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ServerlessComputeSettings: Settings for serverless compute created in the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusServerlessComputeSettings
{
    /// <summary>
    /// ServerlessComputeCustomSubnet: The resource ID of an existing virtual network subnet in which serverless compute nodes
    /// should be deployed
    /// </summary>
    [JsonPropertyName("serverlessComputeCustomSubnet")]
    public string? ServerlessComputeCustomSubnet { get; set; }

    /// <summary>
    /// ServerlessComputeNoPublicIP: The flag to signal if serverless compute nodes deployed in custom vNet would have no public
    /// IP addresses for a workspace with private endpoint
    /// </summary>
    [JsonPropertyName("serverlessComputeNoPublicIP")]
    public bool? ServerlessComputeNoPublicIP { get; set; }
}

/// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>CollectionsThroughput: The throughput of the collections in cosmosdb database</summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusServiceManagedResourcesSettings
{
    /// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20240401WorkspaceStatusServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusSharedPrivateLinkResources
{
    /// <summary>GroupId: The private link resource group id.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: Unique name of the private link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkResourceId: The resource id that private link links to.</summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary>RequestMessage: Request message.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusSku
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusSystemData
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

/// <summary>WorkspaceHubConfig: WorkspaceHub&apos;s configuration object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatusWorkspaceHubConfig
{
    [JsonPropertyName("additionalWorkspaceStorageAccounts")]
    public IList<string>? AdditionalWorkspaceStorageAccounts { get; set; }

    [JsonPropertyName("defaultWorkspaceResourceGroup")]
    public string? DefaultWorkspaceResourceGroup { get; set; }
}

/// <summary>An object that represents a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspaceStatus
{
    /// <summary>AllowPublicAccessWhenBehindVnet: The flag to indicate whether to allow public access when behind VNet.</summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary>ApplicationInsights: ARM id of the application insights associated with this workspace.</summary>
    [JsonPropertyName("applicationInsights")]
    public string? ApplicationInsights { get; set; }

    [JsonPropertyName("associatedWorkspaces")]
    public IList<string>? AssociatedWorkspaces { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>ContainerRegistry: ARM id of the container registry associated with this workspace.</summary>
    [JsonPropertyName("containerRegistry")]
    public string? ContainerRegistry { get; set; }

    /// <summary>Description: The description of this workspace.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DiscoveryUrl: Url for the discovery service to identify regional endpoints for machine learning experimentation services</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    [JsonPropertyName("enableDataIsolation")]
    public bool? EnableDataIsolation { get; set; }

    /// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
    [JsonPropertyName("encryption")]
    public V1api20240401WorkspaceStatusEncryption? Encryption { get; set; }

    /// <summary>FeatureStoreSettings: Settings for feature store type workspace.</summary>
    [JsonPropertyName("featureStoreSettings")]
    public V1api20240401WorkspaceStatusFeatureStoreSettings? FeatureStoreSettings { get; set; }

    /// <summary>FriendlyName: The friendly name for this workspace. This name in mutable</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>HbiWorkspace: The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service</summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    [JsonPropertyName("hubResourceId")]
    public string? HubResourceId { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240401WorkspaceStatusIdentity? Identity { get; set; }

    /// <summary>ImageBuildCompute: The compute name for image build</summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary>
    /// KeyVault: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been
    /// created
    /// </summary>
    [JsonPropertyName("keyVault")]
    public string? KeyVault { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedNetwork: Managed Network settings for a machine learning workspace.</summary>
    [JsonPropertyName("managedNetwork")]
    public V1api20240401WorkspaceStatusManagedNetwork? ManagedNetwork { get; set; }

    /// <summary>MlFlowTrackingUri: The URI associated with this workspace that machine learning flow must point at to set up tracking.</summary>
    [JsonPropertyName("mlFlowTrackingUri")]
    public string? MlFlowTrackingUri { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NotebookInfo: The notebook info of Azure ML workspace.</summary>
    [JsonPropertyName("notebookInfo")]
    public V1api20240401WorkspaceStatusNotebookInfo? NotebookInfo { get; set; }

    /// <summary>PrimaryUserAssignedIdentity: The user assigned identity resource id that represents the workspace identity.</summary>
    [JsonPropertyName("primaryUserAssignedIdentity")]
    public string? PrimaryUserAssignedIdentity { get; set; }

    /// <summary>PrivateEndpointConnections: The list of private endpoint connections in the workspace.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240401WorkspaceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>PrivateLinkCount: Count of private connections in the workspace</summary>
    [JsonPropertyName("privateLinkCount")]
    public int? PrivateLinkCount { get; set; }

    /// <summary>
    /// ProvisioningState: The current deployment state of workspace resource. The provisioningState is to indicate states for
    /// resource provisioning.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>ServerlessComputeSettings: Settings for serverless compute created in the workspace</summary>
    [JsonPropertyName("serverlessComputeSettings")]
    public V1api20240401WorkspaceStatusServerlessComputeSettings? ServerlessComputeSettings { get; set; }

    /// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20240401WorkspaceStatusServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary>
    /// ServiceProvisionedResourceGroup: The name of the managed resource group created by workspace RP in customer subscription
    /// if the workspace is CMK workspace
    /// </summary>
    [JsonPropertyName("serviceProvisionedResourceGroup")]
    public string? ServiceProvisionedResourceGroup { get; set; }

    /// <summary>SharedPrivateLinkResources: The list of shared private link resources in this workspace.</summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20240401WorkspaceStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20240401WorkspaceStatusSku? Sku { get; set; }

    /// <summary>
    /// StorageAccount: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace
    /// has been created
    /// </summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }

    /// <summary>StorageHnsEnabled: If the storage associated with the workspace has hierarchical namespace(HNS) enabled.</summary>
    [JsonPropertyName("storageHnsEnabled")]
    public bool? StorageHnsEnabled { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401WorkspaceStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TenantId: The tenant id associated with this workspace.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>V1LegacyMode: Enabling v1_legacy_mode may prevent you from using features provided by the v2 API.</summary>
    [JsonPropertyName("v1LegacyMode")]
    public bool? V1LegacyMode { get; set; }

    /// <summary>WorkspaceHubConfig: WorkspaceHub&apos;s configuration object.</summary>
    [JsonPropertyName("workspaceHubConfig")]
    public V1api20240401WorkspaceStatusWorkspaceHubConfig? WorkspaceHubConfig { get; set; }

    /// <summary>WorkspaceId: The immutable id associated with this workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/workspaceRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401WorkspaceSpec?>, IStatus<V1api20240401WorkspaceStatus?>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240401WorkspaceSpec? Spec { get; set; }

    /// <summary>An object that represents a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspaceStatus? Status { get; set; }
}