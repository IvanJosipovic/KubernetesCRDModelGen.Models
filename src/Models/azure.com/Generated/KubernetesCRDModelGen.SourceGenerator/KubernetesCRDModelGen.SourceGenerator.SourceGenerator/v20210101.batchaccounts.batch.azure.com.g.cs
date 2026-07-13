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
/// - Generated from: /batch/resource-manager/Microsoft.Batch/Batch/stable/2021-01-01/BatchManagement.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210101BatchAccountList : IKubernetesObject<V1ListMeta>, IItems<V20210101BatchAccount>
{
    public const string KubeApiVersion = "v20210101";
    public const string KubeKind = "BatchAccountList";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.azure.com/v20210101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BatchAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20210101BatchAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20210101BatchAccount> Items { get; set; }
}

/// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecAutoStorageStorageAccountReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecAutoStorage
{
    /// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
    [JsonPropertyName("storageAccountReference")]
    public required V20210101BatchAccountSpecAutoStorageStorageAccountReference StorageAccountReference { get; set; }
}

/// <summary>KeySource: Type of the key source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210101BatchAccountSpecEncryptionKeySourceEnum>))]
public enum V20210101BatchAccountSpecEncryptionKeySourceEnum
{
    [EnumMember(Value = "Microsoft.Batch"), JsonStringEnumMemberName("Microsoft.Batch")]
    MicrosoftBatch,
    [EnumMember(Value = "Microsoft.KeyVault"), JsonStringEnumMemberName("Microsoft.KeyVault")]
    MicrosoftKeyVault
}

/// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecEncryptionKeyVaultProperties
{
    /// <summary>
    /// KeyIdentifier: Full path to the versioned secret. Example
    /// https://mykeyvault.vault.azure.net/keys/testkey/6e34a81fef704045975661e297a4c053. To be usable the following
    /// prerequisites must be met:
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecEncryption
{
    /// <summary>KeySource: Type of the key source.</summary>
    [JsonPropertyName("keySource")]
    public V20210101BatchAccountSpecEncryptionKeySourceEnum? KeySource { get; set; }

    /// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V20210101BatchAccountSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>Type: The type of identity used for the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210101BatchAccountSpecIdentityTypeEnum>))]
public enum V20210101BatchAccountSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20210101BatchAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20210101BatchAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecIdentity
{
    /// <summary>Type: The type of identity used for the Batch account.</summary>
    [JsonPropertyName("type")]
    public required V20210101BatchAccountSpecIdentityTypeEnum Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Batch account. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20210101BatchAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecKeyVaultReferenceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecKeyVaultReference
{
    /// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("reference")]
    public required V20210101BatchAccountSpecKeyVaultReferenceReference Reference { get; set; }

    /// <summary>Url: The URL of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecOperatorSpecConfigMapExpressions
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
public partial class V20210101BatchAccountSpecOperatorSpecSecretExpressions
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
public partial class V20210101BatchAccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20210101BatchAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20210101BatchAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PoolAllocationMode: The pool allocation mode also affects how clients may authenticate to the Batch Service API. If the
/// mode is BatchService, clients may authenticate using access keys or Azure Active Directory. If the mode is
/// UserSubscription, clients must use Azure Active Directory. The default is BatchService.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210101BatchAccountSpecPoolAllocationModeEnum>))]
public enum V20210101BatchAccountSpecPoolAllocationModeEnum
{
    [EnumMember(Value = "BatchService"), JsonStringEnumMemberName("BatchService")]
    BatchService,
    [EnumMember(Value = "UserSubscription"), JsonStringEnumMemberName("UserSubscription")]
    UserSubscription
}

/// <summary>PublicNetworkAccess: If not specified, the default value is &apos;enabled&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210101BatchAccountSpecPublicNetworkAccessEnum>))]
public enum V20210101BatchAccountSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountSpec
{
    /// <summary>AutoStorage: The properties related to the auto-storage account.</summary>
    [JsonPropertyName("autoStorage")]
    public V20210101BatchAccountSpecAutoStorage? AutoStorage { get; set; }

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
    public V20210101BatchAccountSpecEncryption? Encryption { get; set; }

    /// <summary>Identity: The identity of the Batch account.</summary>
    [JsonPropertyName("identity")]
    public V20210101BatchAccountSpecIdentity? Identity { get; set; }

    /// <summary>KeyVaultReference: A reference to the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V20210101BatchAccountSpecKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>Location: The region in which to create the account.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20210101BatchAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20210101BatchAccountSpecOwner Owner { get; set; }

    /// <summary>
    /// PoolAllocationMode: The pool allocation mode also affects how clients may authenticate to the Batch Service API. If the
    /// mode is BatchService, clients may authenticate using access keys or Azure Active Directory. If the mode is
    /// UserSubscription, clients must use Azure Active Directory. The default is BatchService.
    /// </summary>
    [JsonPropertyName("poolAllocationMode")]
    public V20210101BatchAccountSpecPoolAllocationModeEnum? PoolAllocationMode { get; set; }

    /// <summary>PublicNetworkAccess: If not specified, the default value is &apos;enabled&apos;.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20210101BatchAccountSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>Tags: The user-specified tags associated with the account.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>AutoStorage: Contains information about the auto-storage account associated with a Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusAutoStorage
{
    /// <summary>LastKeySync: The UTC time at which storage keys were last synchronized with the Batch account.</summary>
    [JsonPropertyName("lastKeySync")]
    public string? LastKeySync { get; set; }

    /// <summary>StorageAccountId: The resource ID of the storage account to be used for auto-storage account.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusDedicatedCoreQuotaPerVMFamily
{
    /// <summary>CoreQuota: The core quota for the VM family for the Batch account.</summary>
    [JsonPropertyName("coreQuota")]
    public int? CoreQuota { get; set; }

    /// <summary>Name: The Virtual Machine family name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusEncryptionKeyVaultProperties
{
    /// <summary>
    /// KeyIdentifier: Full path to the versioned secret. Example
    /// https://mykeyvault.vault.azure.net/keys/testkey/6e34a81fef704045975661e297a4c053. To be usable the following
    /// prerequisites must be met:
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusEncryption
{
    /// <summary>KeySource: Type of the key source.</summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>KeyVaultProperties: Additional details when using Microsoft.KeyVault</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V20210101BatchAccountStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusIdentity
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

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Batch account. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20210101BatchAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyVaultReference: Identifies the Azure key vault associated with a Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusKeyVaultReference
{
    /// <summary>Id: The resource ID of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Url: The URL of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Contains information about a private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatusPrivateEndpointConnections
{
    /// <summary>Id: The ID of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Contains information about an Azure Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210101BatchAccountStatus
{
    /// <summary>AccountEndpoint: The account endpoint used to interact with the Batch service.</summary>
    [JsonPropertyName("accountEndpoint")]
    public string? AccountEndpoint { get; set; }

    [JsonPropertyName("activeJobAndJobScheduleQuota")]
    public int? ActiveJobAndJobScheduleQuota { get; set; }

    /// <summary>AutoStorage: Contains information about the auto-storage account associated with a Batch account.</summary>
    [JsonPropertyName("autoStorage")]
    public V20210101BatchAccountStatusAutoStorage? AutoStorage { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20210101BatchAccountStatusConditions>? Conditions { get; set; }

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
    public IList<V20210101BatchAccountStatusDedicatedCoreQuotaPerVMFamily>? DedicatedCoreQuotaPerVMFamily { get; set; }

    /// <summary>
    /// DedicatedCoreQuotaPerVMFamilyEnforced: Batch is transitioning its core quota system for dedicated cores to be enforced
    /// per Virtual Machine family. During this transitional phase, the dedicated core quota per Virtual Machine family may not
    /// yet be enforced. If this flag is false, dedicated core quota is enforced via the old dedicatedCoreQuota property on the
    /// account and does not consider Virtual Machine family. If this flag is true, dedicated core quota is enforced via the
    /// dedicatedCoreQuotaPerVMFamily property on the account, and the old dedicatedCoreQuota does not apply.
    /// </summary>
    [JsonPropertyName("dedicatedCoreQuotaPerVMFamilyEnforced")]
    public bool? DedicatedCoreQuotaPerVMFamilyEnforced { get; set; }

    /// <summary>
    /// Encryption: Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using
    /// a Microsoft managed key. For additional control, a customer-managed key can be used instead.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20210101BatchAccountStatusEncryption? Encryption { get; set; }

    /// <summary>Id: The ID of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the Batch account.</summary>
    [JsonPropertyName("identity")]
    public V20210101BatchAccountStatusIdentity? Identity { get; set; }

    /// <summary>KeyVaultReference: Identifies the Azure key vault associated with a Batch account.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V20210101BatchAccountStatusKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>Location: The location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// LowPriorityCoreQuota: For accounts with PoolAllocationMode set to UserSubscription, quota is managed on the subscription
    /// so this value is not returned.
    /// </summary>
    [JsonPropertyName("lowPriorityCoreQuota")]
    public int? LowPriorityCoreQuota { get; set; }

    /// <summary>Name: The name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PoolAllocationMode: The allocation mode for creating pools in the Batch account.</summary>
    [JsonPropertyName("poolAllocationMode")]
    public string? PoolAllocationMode { get; set; }

    [JsonPropertyName("poolQuota")]
    public int? PoolQuota { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections associated with the Batch account</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20210101BatchAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: If not specified, the default value is &apos;enabled&apos;.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Tags: The tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /batch/resource-manager/Microsoft.Batch/Batch/stable/2021-01-01/BatchManagement.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210101BatchAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V20210101BatchAccountSpec?>, IStatus<V20210101BatchAccountStatus?>
{
    public const string KubeApiVersion = "v20210101";
    public const string KubeKind = "BatchAccount";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.azure.com/v20210101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BatchAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20210101BatchAccountSpec? Spec { get; set; }

    /// <summary>Contains information about an Azure Batch account.</summary>
    [JsonPropertyName("status")]
    public V20210101BatchAccountStatus? Status { get; set; }
}