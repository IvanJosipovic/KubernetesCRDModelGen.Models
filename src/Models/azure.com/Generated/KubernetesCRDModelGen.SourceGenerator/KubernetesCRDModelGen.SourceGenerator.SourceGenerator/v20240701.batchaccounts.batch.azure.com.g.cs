#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /batch/resource-manager/Microsoft.Batch/Batch/stable/2024-07-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240701BatchAccountList : IKubernetesObject<V1ListMeta>, IItems<V20240701BatchAccount>
{
    public const string KubeApiVersion = "v20240701";
    public const string KubeKind = "BatchAccountList";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.azure.com/v20240701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BatchAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240701BatchAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240701BatchAccount> Items { get; set; }
}

/// <summary>The authentication mode for the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecAllowedAuthenticationModesEnum>))]
public enum V20240701BatchAccountSpecAllowedAuthenticationModesEnum
{
    [EnumMember(Value = "AAD"), JsonStringEnumMemberName("AAD")]
    AAD,
    [EnumMember(Value = "SharedKey"), JsonStringEnumMemberName("SharedKey")]
    SharedKey,
    [EnumMember(Value = "TaskAuthenticationToken"), JsonStringEnumMemberName("TaskAuthenticationToken")]
    TaskAuthenticationToken
}

/// <summary>AuthenticationMode: The authentication mode which the Batch service will use to manage the auto-storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecAutoStorageAuthenticationModeEnum>))]
public enum V20240701BatchAccountSpecAutoStorageAuthenticationModeEnum
{
    [EnumMember(Value = "BatchAccountManagedIdentity"), JsonStringEnumMemberName("BatchAccountManagedIdentity")]
    BatchAccountManagedIdentity,
    [EnumMember(Value = "StorageKeys"), JsonStringEnumMemberName("StorageKeys")]
    StorageKeys
}

/// <summary>ResourceReference: The ARM resource id of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecAutoStorageNodeIdentityReferenceResourceReference
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
/// NodeIdentityReference: The identity referenced here must be assigned to pools which have compute nodes that need access
/// to auto-storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecAutoStorageNodeIdentityReference
{
    /// <summary>ResourceReference: The ARM resource id of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20240701BatchAccountSpecAutoStorageNodeIdentityReferenceResourceReference? ResourceReference { get; set; }
}

/// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecAutoStorageStorageAccountReference
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

/// <summary>AutoStorage: The properties related to the auto-storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecAutoStorage
{
    /// <summary>AuthenticationMode: The authentication mode which the Batch service will use to manage the auto-storage account.</summary>
    [JsonPropertyName("authenticationMode")]
    public V20240701BatchAccountSpecAutoStorageAuthenticationModeEnum? AuthenticationMode { get; set; }

    /// <summary>
    /// NodeIdentityReference: The identity referenced here must be assigned to pools which have compute nodes that need access
    /// to auto-storage.
    /// </summary>
    [JsonPropertyName("nodeIdentityReference")]
    public V20240701BatchAccountSpecAutoStorageNodeIdentityReference? NodeIdentityReference { get; set; }

    /// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
    [JsonPropertyName("storageAccountReference")]
    public required V20240701BatchAccountSpecAutoStorageStorageAccountReference StorageAccountReference { get; set; }
}

/// <summary>KeySource: Type of the key source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecEncryptionKeySourceEnum>))]
public enum V20240701BatchAccountSpecEncryptionKeySourceEnum
{
    [EnumMember(Value = "Microsoft.Batch"), JsonStringEnumMemberName("Microsoft.Batch")]
    MicrosoftBatch,
    [EnumMember(Value = "Microsoft.KeyVault"), JsonStringEnumMemberName("Microsoft.KeyVault")]
    MicrosoftKeyVault
}

/// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecEncryptionKeyVaultProperties
{
    /// <summary>
    /// KeyIdentifier: Full path to the secret with or without version. Example
    /// https://mykeyvault.vault.azure.net/keys/testkey/6e34a81fef704045975661e297a4c053. or
    /// https://mykeyvault.vault.azure.net/keys/testkey. To be usable the following prerequisites must be met:
    /// The Batch Account has a System Assigned identity
    /// The account identity has been granted Key/Get, Key/Unwrap and Key/Wrap permissions
    /// The KeyVault has soft-delete and purge protection enabled
    /// </summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>
/// Encryption: Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using
/// a Microsoft managed key. For additional control, a customer-managed key can be used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecEncryption
{
    /// <summary>KeySource: Type of the key source.</summary>
    [JsonPropertyName("keySource")]
    public V20240701BatchAccountSpecEncryptionKeySourceEnum? KeySource { get; set; }

    /// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V20240701BatchAccountSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>Type: The type of identity used for the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecIdentityTypeEnum>))]
public enum V20240701BatchAccountSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20240701BatchAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20240701BatchAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecIdentity
{
    /// <summary>Type: The type of identity used for the Batch account.</summary>
    [JsonPropertyName("type")]
    public required V20240701BatchAccountSpecIdentityTypeEnum Type { get; set; }

    /// <summary>UserAssignedIdentities: The list of user identities associated with the Batch account.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20240701BatchAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecKeyVaultReferenceReference
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

/// <summary>KeyVaultReference: A reference to the Azure key vault associated with the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecKeyVaultReference
{
    /// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("reference")]
    public required V20240701BatchAccountSpecKeyVaultReferenceReference Reference { get; set; }

    /// <summary>Url: The URL of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>DefaultAction: Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecNetworkProfileAccountAccessDefaultActionEnum>))]
public enum V20240701BatchAccountSpecNetworkProfileAccountAccessDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: Action when client IP address is matched.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecNetworkProfileAccountAccessIpRulesActionEnum>))]
public enum V20240701BatchAccountSpecNetworkProfileAccountAccessIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>Rule to filter client IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecNetworkProfileAccountAccessIpRules
{
    /// <summary>Action: Action when client IP address is matched.</summary>
    [JsonPropertyName("action")]
    public required V20240701BatchAccountSpecNetworkProfileAccountAccessIpRulesActionEnum Action { get; set; }

    /// <summary>Value: IPv4 address, or IPv4 address range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>AccountAccess: Network access profile for batchAccount endpoint (Batch account data plane API).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecNetworkProfileAccountAccess
{
    /// <summary>DefaultAction: Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled.</summary>
    [JsonPropertyName("defaultAction")]
    public required V20240701BatchAccountSpecNetworkProfileAccountAccessDefaultActionEnum DefaultAction { get; set; }

    /// <summary>IpRules: Array of IP ranges to filter client IP address.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V20240701BatchAccountSpecNetworkProfileAccountAccessIpRules>? IpRules { get; set; }
}

/// <summary>DefaultAction: Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecNetworkProfileNodeManagementAccessDefaultActionEnum>))]
public enum V20240701BatchAccountSpecNetworkProfileNodeManagementAccessDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: Action when client IP address is matched.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecNetworkProfileNodeManagementAccessIpRulesActionEnum>))]
public enum V20240701BatchAccountSpecNetworkProfileNodeManagementAccessIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>Rule to filter client IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecNetworkProfileNodeManagementAccessIpRules
{
    /// <summary>Action: Action when client IP address is matched.</summary>
    [JsonPropertyName("action")]
    public required V20240701BatchAccountSpecNetworkProfileNodeManagementAccessIpRulesActionEnum Action { get; set; }

    /// <summary>Value: IPv4 address, or IPv4 address range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// NodeManagementAccess: Network access profile for nodeManagement endpoint (Batch service managing compute nodes for Batch
/// pools).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecNetworkProfileNodeManagementAccess
{
    /// <summary>DefaultAction: Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled.</summary>
    [JsonPropertyName("defaultAction")]
    public required V20240701BatchAccountSpecNetworkProfileNodeManagementAccessDefaultActionEnum DefaultAction { get; set; }

    /// <summary>IpRules: Array of IP ranges to filter client IP address.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V20240701BatchAccountSpecNetworkProfileNodeManagementAccessIpRules>? IpRules { get; set; }
}

/// <summary>NetworkProfile: The network profile only takes effect when publicNetworkAccess is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecNetworkProfile
{
    /// <summary>AccountAccess: Network access profile for batchAccount endpoint (Batch account data plane API).</summary>
    [JsonPropertyName("accountAccess")]
    public V20240701BatchAccountSpecNetworkProfileAccountAccess? AccountAccess { get; set; }

    /// <summary>
    /// NodeManagementAccess: Network access profile for nodeManagement endpoint (Batch service managing compute nodes for Batch
    /// pools).
    /// </summary>
    [JsonPropertyName("nodeManagementAccess")]
    public V20240701BatchAccountSpecNetworkProfileNodeManagementAccess? NodeManagementAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecOperatorSpecConfigMapExpressions
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
public partial class V20240701BatchAccountSpecOperatorSpecSecretExpressions
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
public partial class V20240701BatchAccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240701BatchAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240701BatchAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PoolAllocationMode: The pool allocation mode also affects how clients may authenticate to the Batch Service API. If the
/// mode is BatchService, clients may authenticate using access keys or Microsoft Entra ID. If the mode is UserSubscription,
/// clients must use Microsoft Entra ID. The default is BatchService.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecPoolAllocationModeEnum>))]
public enum V20240701BatchAccountSpecPoolAllocationModeEnum
{
    [EnumMember(Value = "BatchService"), JsonStringEnumMemberName("BatchService")]
    BatchService,
    [EnumMember(Value = "UserSubscription"), JsonStringEnumMemberName("UserSubscription")]
    UserSubscription
}

/// <summary>PublicNetworkAccess: The network access type for operating on the resources in the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240701BatchAccountSpecPublicNetworkAccessEnum>))]
public enum V20240701BatchAccountSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "SecuredByPerimeter"), JsonStringEnumMemberName("SecuredByPerimeter")]
    SecuredByPerimeter
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountSpec
{
    /// <summary>
    /// AllowedAuthenticationModes: List of allowed authentication modes for the Batch account that can be used to authenticate
    /// with the data plane. This does not affect authentication with the control plane.
    /// </summary>
    [JsonPropertyName("allowedAuthenticationModes")]
    public IList<V20240701BatchAccountSpecAllowedAuthenticationModesEnum>? AllowedAuthenticationModes { get; set; }

    /// <summary>AutoStorage: The properties related to the auto-storage account.</summary>
    [JsonPropertyName("autoStorage")]
    public V20240701BatchAccountSpecAutoStorage? AutoStorage { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Encryption: Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using
    /// a Microsoft managed key. For additional control, a customer-managed key can be used instead.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20240701BatchAccountSpecEncryption? Encryption { get; set; }

    /// <summary>Identity: The identity of the Batch account.</summary>
    [JsonPropertyName("identity")]
    public V20240701BatchAccountSpecIdentity? Identity { get; set; }

    /// <summary>KeyVaultReference: A reference to the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V20240701BatchAccountSpecKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>Location: The region in which to create the account.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NetworkProfile: The network profile only takes effect when publicNetworkAccess is enabled.</summary>
    [JsonPropertyName("networkProfile")]
    public V20240701BatchAccountSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240701BatchAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240701BatchAccountSpecOwner Owner { get; set; }

    /// <summary>
    /// PoolAllocationMode: The pool allocation mode also affects how clients may authenticate to the Batch Service API. If the
    /// mode is BatchService, clients may authenticate using access keys or Microsoft Entra ID. If the mode is UserSubscription,
    /// clients must use Microsoft Entra ID. The default is BatchService.
    /// </summary>
    [JsonPropertyName("poolAllocationMode")]
    public V20240701BatchAccountSpecPoolAllocationModeEnum? PoolAllocationMode { get; set; }

    /// <summary>PublicNetworkAccess: The network access type for operating on the resources in the Batch account.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20240701BatchAccountSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>Tags: The user-specified tags associated with the account.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// NodeIdentityReference: The identity referenced here must be assigned to pools which have compute nodes that need access
/// to auto-storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusAutoStorageNodeIdentityReference
{
    /// <summary>ResourceId: The ARM resource id of the user assigned identity.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>AutoStorage: Contains information about the auto-storage account associated with a Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusAutoStorage
{
    /// <summary>AuthenticationMode: The authentication mode which the Batch service will use to manage the auto-storage account.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>LastKeySync: The UTC time at which storage keys were last synchronized with the Batch account.</summary>
    [JsonPropertyName("lastKeySync")]
    public string? LastKeySync { get; set; }

    /// <summary>
    /// NodeIdentityReference: The identity referenced here must be assigned to pools which have compute nodes that need access
    /// to auto-storage.
    /// </summary>
    [JsonPropertyName("nodeIdentityReference")]
    public V20240701BatchAccountStatusAutoStorageNodeIdentityReference? NodeIdentityReference { get; set; }

    /// <summary>StorageAccountId: The resource ID of the storage account to be used for auto-storage account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusConditions
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

/// <summary>A VM Family and its associated core quota for the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusDedicatedCoreQuotaPerVMFamily
{
    /// <summary>CoreQuota: The core quota for the VM family for the Batch account.</summary>
    [JsonPropertyName("coreQuota")]
    public int? CoreQuota { get; set; }

    /// <summary>Name: The Virtual Machine family name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusEncryptionKeyVaultProperties
{
    /// <summary>
    /// KeyIdentifier: Full path to the secret with or without version. Example
    /// https://mykeyvault.vault.azure.net/keys/testkey/6e34a81fef704045975661e297a4c053. or
    /// https://mykeyvault.vault.azure.net/keys/testkey. To be usable the following prerequisites must be met:
    /// The Batch Account has a System Assigned identity
    /// The account identity has been granted Key/Get, Key/Unwrap and Key/Wrap permissions
    /// The KeyVault has soft-delete and purge protection enabled
    /// </summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>
/// Encryption: Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using
/// a Microsoft managed key. For additional control, a customer-managed key can be used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusEncryption
{
    /// <summary>KeySource: Type of the key source.</summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V20240701BatchAccountStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>The list of associated user identities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusIdentity
{
    /// <summary>PrincipalId: The principal id of the Batch account. This property will only be provided for a system assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id associated with the Batch account. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The type of identity used for the Batch account.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The list of user identities associated with the Batch account.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20240701BatchAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyVaultReference: Identifies the Azure key vault associated with a Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusKeyVaultReference
{
    /// <summary>Id: The resource ID of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Url: The URL of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Rule to filter client IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusNetworkProfileAccountAccessIpRules
{
    /// <summary>Action: Action when client IP address is matched.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Value: IPv4 address, or IPv4 address range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>AccountAccess: Network access profile for batchAccount endpoint (Batch account data plane API).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusNetworkProfileAccountAccess
{
    /// <summary>DefaultAction: Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: Array of IP ranges to filter client IP address.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V20240701BatchAccountStatusNetworkProfileAccountAccessIpRules>? IpRules { get; set; }
}

/// <summary>Rule to filter client IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusNetworkProfileNodeManagementAccessIpRules
{
    /// <summary>Action: Action when client IP address is matched.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Value: IPv4 address, or IPv4 address range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// NodeManagementAccess: Network access profile for nodeManagement endpoint (Batch service managing compute nodes for Batch
/// pools).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusNetworkProfileNodeManagementAccess
{
    /// <summary>DefaultAction: Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: Array of IP ranges to filter client IP address.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V20240701BatchAccountStatusNetworkProfileNodeManagementAccessIpRules>? IpRules { get; set; }
}

/// <summary>NetworkProfile: The network profile only takes effect when publicNetworkAccess is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusNetworkProfile
{
    /// <summary>AccountAccess: Network access profile for batchAccount endpoint (Batch account data plane API).</summary>
    [JsonPropertyName("accountAccess")]
    public V20240701BatchAccountStatusNetworkProfileAccountAccess? AccountAccess { get; set; }

    /// <summary>
    /// NodeManagementAccess: Network access profile for nodeManagement endpoint (Batch service managing compute nodes for Batch
    /// pools).
    /// </summary>
    [JsonPropertyName("nodeManagementAccess")]
    public V20240701BatchAccountStatusNetworkProfileNodeManagementAccess? NodeManagementAccess { get; set; }
}

/// <summary>Contains information about a private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatusSystemData
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

/// <summary>Contains information about an Azure Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701BatchAccountStatus
{
    /// <summary>AccountEndpoint: The account endpoint used to interact with the Batch service.</summary>
    [JsonPropertyName("accountEndpoint")]
    public string? AccountEndpoint { get; set; }

    /// <summary>ActiveJobAndJobScheduleQuota: The active job and job schedule quota for the Batch account.</summary>
    [JsonPropertyName("activeJobAndJobScheduleQuota")]
    public int? ActiveJobAndJobScheduleQuota { get; set; }

    /// <summary>
    /// AllowedAuthenticationModes: List of allowed authentication modes for the Batch account that can be used to authenticate
    /// with the data plane. This does not affect authentication with the control plane.
    /// </summary>
    [JsonPropertyName("allowedAuthenticationModes")]
    public IList<string>? AllowedAuthenticationModes { get; set; }

    /// <summary>AutoStorage: Contains information about the auto-storage account associated with a Batch account.</summary>
    [JsonPropertyName("autoStorage")]
    public V20240701BatchAccountStatusAutoStorage? AutoStorage { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240701BatchAccountStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DedicatedCoreQuota: For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription
    /// so this value is not returned.
    /// </summary>
    [JsonPropertyName("dedicatedCoreQuota")]
    public int? DedicatedCoreQuota { get; set; }

    /// <summary>
    /// DedicatedCoreQuotaPerVMFamily: A list of the dedicated core quota per Virtual Machine family for the Batch account. For
    /// accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription so this value is not
    /// returned.
    /// </summary>
    [JsonPropertyName("dedicatedCoreQuotaPerVMFamily")]
    public IList<V20240701BatchAccountStatusDedicatedCoreQuotaPerVMFamily>? DedicatedCoreQuotaPerVMFamily { get; set; }

    /// <summary>
    /// DedicatedCoreQuotaPerVMFamilyEnforced: If this flag is true, dedicated core quota is enforced via both the
    /// dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the account. If this flag is false, dedicated core
    /// quota is enforced only via the dedicatedCoreQuota property on the account and does not consider Virtual Machine family.
    /// </summary>
    [JsonPropertyName("dedicatedCoreQuotaPerVMFamilyEnforced")]
    public bool? DedicatedCoreQuotaPerVMFamilyEnforced { get; set; }

    /// <summary>
    /// Encryption: Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using
    /// a Microsoft managed key. For additional control, a customer-managed key can be used instead.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20240701BatchAccountStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the Batch account.</summary>
    [JsonPropertyName("identity")]
    public V20240701BatchAccountStatusIdentity? Identity { get; set; }

    /// <summary>KeyVaultReference: Identifies the Azure key vault associated with a Batch account.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V20240701BatchAccountStatusKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// LowPriorityCoreQuota: For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription
    /// so this value is not returned.
    /// </summary>
    [JsonPropertyName("lowPriorityCoreQuota")]
    public int? LowPriorityCoreQuota { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: The network profile only takes effect when publicNetworkAccess is enabled.</summary>
    [JsonPropertyName("networkProfile")]
    public V20240701BatchAccountStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeManagementEndpoint: The endpoint used by compute node to connect to the Batch node management service.</summary>
    [JsonPropertyName("nodeManagementEndpoint")]
    public string? NodeManagementEndpoint { get; set; }

    /// <summary>PoolAllocationMode: The allocation mode for creating pools in the Batch account.</summary>
    [JsonPropertyName("poolAllocationMode")]
    public string? PoolAllocationMode { get; set; }

    /// <summary>PoolQuota: The pool quota for the Batch account.</summary>
    [JsonPropertyName("poolQuota")]
    public int? PoolQuota { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections associated with the Batch account</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20240701BatchAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: The network access type for operating on the resources in the Batch account.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20240701BatchAccountStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /batch/resource-manager/Microsoft.Batch/Batch/stable/2024-07-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240701BatchAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V20240701BatchAccountSpec?>, IStatus<V20240701BatchAccountStatus?>
{
    public const string KubeApiVersion = "v20240701";
    public const string KubeKind = "BatchAccount";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.azure.com/v20240701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BatchAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240701BatchAccountSpec? Spec { get; set; }

    /// <summary>Contains information about an Azure Batch account.</summary>
    [JsonPropertyName("status")]
    public V20240701BatchAccountStatus? Status { get; set; }
}