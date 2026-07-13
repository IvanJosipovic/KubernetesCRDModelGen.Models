#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601StorageAccountsFileServicesShareList : IKubernetesObject<V1ListMeta>, IItems<V20250601StorageAccountsFileServicesShare>
{
    public const string KubeApiVersion = "v20250601";
    public const string KubeKind = "StorageAccountsFileServicesShareList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservicesshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileServicesShareList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250601StorageAccountsFileServicesShare objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250601StorageAccountsFileServicesShare> Items { get; set; }
}

/// <summary>
/// AccessTier: Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and
/// Cool. FileStorage account can choose Premium.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountsFileServicesShareSpecAccessTierEnum>))]
public enum V20250601StorageAccountsFileServicesShareSpecAccessTierEnum
{
    [EnumMember(Value = "Cool"), JsonStringEnumMemberName("Cool")]
    Cool,
    [EnumMember(Value = "Hot"), JsonStringEnumMemberName("Hot")]
    Hot,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "TransactionOptimized"), JsonStringEnumMemberName("TransactionOptimized")]
    TransactionOptimized
}

/// <summary>
/// EnabledProtocols: The authentication protocol that is used for the file share. Can only be specified when creating a
/// share.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountsFileServicesShareSpecEnabledProtocolsEnum>))]
public enum V20250601StorageAccountsFileServicesShareSpecEnabledProtocolsEnum
{
    [EnumMember(Value = "NFS"), JsonStringEnumMemberName("NFS")]
    NFS,
    [EnumMember(Value = "SMB"), JsonStringEnumMemberName("SMB")]
    SMB
}

/// <summary>FileSharePaidBursting: File Share Paid Bursting properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareSpecFileSharePaidBursting
{
    /// <summary>
    /// PaidBurstingEnabled: Indicates whether paid bursting is enabled for the share. This property is only for file shares
    /// created under Files Provisioned v1 SSD account type.
    /// </summary>
    [JsonPropertyName("paidBurstingEnabled")]
    public bool? PaidBurstingEnabled { get; set; }

    /// <summary>
    /// PaidBurstingMaxBandwidthMibps: The maximum paid bursting bandwidth for the share, in mebibytes per second. This property
    /// is only for file shares created under Files Provisioned v1 SSD account type. The maximum allowed value is 10340 which is
    /// the maximum allowed bandwidth for a share.
    /// </summary>
    [JsonPropertyName("paidBurstingMaxBandwidthMibps")]
    public int? PaidBurstingMaxBandwidthMibps { get; set; }

    /// <summary>
    /// PaidBurstingMaxIops: The maximum paid bursting IOPS for the share. This property is only for file shares created under
    /// Files Provisioned v1 SSD account type. The maximum allowed value is 102400 which is the maximum allowed IOPS for a share.
    /// </summary>
    [JsonPropertyName("paidBurstingMaxIops")]
    public int? PaidBurstingMaxIops { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareSpecOperatorSpecConfigMapExpressions
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
public partial class V20250601StorageAccountsFileServicesShareSpecOperatorSpecSecretExpressions
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
public partial class V20250601StorageAccountsFileServicesShareSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250601StorageAccountsFileServicesShareSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250601StorageAccountsFileServicesShareSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccountsFileService resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RootSquash: The property is for NFS share only. The default is NoRootSquash.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountsFileServicesShareSpecRootSquashEnum>))]
public enum V20250601StorageAccountsFileServicesShareSpecRootSquashEnum
{
    [EnumMember(Value = "AllSquash"), JsonStringEnumMemberName("AllSquash")]
    AllSquash,
    [EnumMember(Value = "NoRootSquash"), JsonStringEnumMemberName("NoRootSquash")]
    NoRootSquash,
    [EnumMember(Value = "RootSquash"), JsonStringEnumMemberName("RootSquash")]
    RootSquash
}

/// <summary>AccessPolicy: Access policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareSpecSignedIdentifiersAccessPolicy
{
    /// <summary>ExpiryTime: Expiry time of the access policy</summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Permission: List of abbreviated permissions.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>StartTime: Start time of the access policy</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Reference: An unique identifier of the stored access policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareSpecSignedIdentifiersReference
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
public partial class V20250601StorageAccountsFileServicesShareSpecSignedIdentifiers
{
    /// <summary>AccessPolicy: Access policy</summary>
    [JsonPropertyName("accessPolicy")]
    public V20250601StorageAccountsFileServicesShareSpecSignedIdentifiersAccessPolicy? AccessPolicy { get; set; }

    /// <summary>Reference: An unique identifier of the stored access policy.</summary>
    [JsonPropertyName("reference")]
    public V20250601StorageAccountsFileServicesShareSpecSignedIdentifiersReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareSpec
{
    /// <summary>
    /// AccessTier: Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and
    /// Cool. FileStorage account can choose Premium.
    /// </summary>
    [JsonPropertyName("accessTier")]
    public V20250601StorageAccountsFileServicesShareSpecAccessTierEnum? AccessTier { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// EnabledProtocols: The authentication protocol that is used for the file share. Can only be specified when creating a
    /// share.
    /// </summary>
    [JsonPropertyName("enabledProtocols")]
    public V20250601StorageAccountsFileServicesShareSpecEnabledProtocolsEnum? EnabledProtocols { get; set; }

    /// <summary>FileSharePaidBursting: File Share Paid Bursting properties.</summary>
    [JsonPropertyName("fileSharePaidBursting")]
    public V20250601StorageAccountsFileServicesShareSpecFileSharePaidBursting? FileSharePaidBursting { get; set; }

    /// <summary>Metadata: A name-value pair to associate with the share as metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250601StorageAccountsFileServicesShareSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccountsFileService resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250601StorageAccountsFileServicesShareSpecOwner Owner { get; set; }

    /// <summary>
    /// ProvisionedBandwidthMibps: The provisioned bandwidth of the share, in mebibytes per second. This property is only for
    /// file shares created under Files Provisioned v2 account type. Please refer to the GetFileServiceUsage API response for
    /// the minimum and maximum allowed value for provisioned bandwidth.
    /// </summary>
    [JsonPropertyName("provisionedBandwidthMibps")]
    public int? ProvisionedBandwidthMibps { get; set; }

    /// <summary>
    /// ProvisionedIops: The provisioned IOPS of the share. This property is only for file shares created under Files
    /// Provisioned v2 account type. Please refer to the GetFileServiceUsage API response for the minimum and maximum allowed
    /// value for provisioned IOPS.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public int? ProvisionedIops { get; set; }

    /// <summary>RootSquash: The property is for NFS share only. The default is NoRootSquash.</summary>
    [JsonPropertyName("rootSquash")]
    public V20250601StorageAccountsFileServicesShareSpecRootSquashEnum? RootSquash { get; set; }

    /// <summary>
    /// ShareQuota: The provisioned size of the share, in gibibytes. Must be greater than 0, and less than or equal to 5TB
    /// (5120). For Large File Shares, the maximum size is 102400. For file shares created under Files Provisioned v2 account
    /// type, please refer to the GetFileServiceUsage API response for the minimum and maximum allowed provisioned storage size.
    /// </summary>
    [JsonPropertyName("shareQuota")]
    public int? ShareQuota { get; set; }

    /// <summary>SignedIdentifiers: List of stored access policies specified on the share.</summary>
    [JsonPropertyName("signedIdentifiers")]
    public IList<V20250601StorageAccountsFileServicesShareSpecSignedIdentifiers>? SignedIdentifiers { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareStatusConditions
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

/// <summary>FileSharePaidBursting: File Share Paid Bursting properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareStatusFileSharePaidBursting
{
    /// <summary>
    /// PaidBurstingEnabled: Indicates whether paid bursting is enabled for the share. This property is only for file shares
    /// created under Files Provisioned v1 SSD account type.
    /// </summary>
    [JsonPropertyName("paidBurstingEnabled")]
    public bool? PaidBurstingEnabled { get; set; }

    /// <summary>
    /// PaidBurstingMaxBandwidthMibps: The maximum paid bursting bandwidth for the share, in mebibytes per second. This property
    /// is only for file shares created under Files Provisioned v1 SSD account type. The maximum allowed value is 10340 which is
    /// the maximum allowed bandwidth for a share.
    /// </summary>
    [JsonPropertyName("paidBurstingMaxBandwidthMibps")]
    public int? PaidBurstingMaxBandwidthMibps { get; set; }

    /// <summary>
    /// PaidBurstingMaxIops: The maximum paid bursting IOPS for the share. This property is only for file shares created under
    /// Files Provisioned v1 SSD account type. The maximum allowed value is 102400 which is the maximum allowed IOPS for a share.
    /// </summary>
    [JsonPropertyName("paidBurstingMaxIops")]
    public int? PaidBurstingMaxIops { get; set; }
}

/// <summary>AccessPolicy: Access policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareStatusSignedIdentifiersAccessPolicy
{
    /// <summary>ExpiryTime: Expiry time of the access policy</summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Permission: List of abbreviated permissions.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }

    /// <summary>StartTime: Start time of the access policy</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareStatusSignedIdentifiers
{
    /// <summary>AccessPolicy: Access policy</summary>
    [JsonPropertyName("accessPolicy")]
    public V20250601StorageAccountsFileServicesShareStatusSignedIdentifiersAccessPolicy? AccessPolicy { get; set; }

    /// <summary>Id: An unique identifier of the stored access policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountsFileServicesShareStatusSystemData
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
public partial class V20250601StorageAccountsFileServicesShareStatus
{
    /// <summary>
    /// AccessTier: Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and
    /// Cool. FileStorage account can choose Premium.
    /// </summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>AccessTierChangeTime: Indicates the last modification time for share access tier.</summary>
    [JsonPropertyName("accessTierChangeTime")]
    public string? AccessTierChangeTime { get; set; }

    /// <summary>AccessTierStatus: Indicates if there is a pending transition for access tier.</summary>
    [JsonPropertyName("accessTierStatus")]
    public string? AccessTierStatus { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250601StorageAccountsFileServicesShareStatusConditions>? Conditions { get; set; }

    /// <summary>Deleted: Indicates whether the share was deleted.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>DeletedTime: The deleted time if the share was deleted.</summary>
    [JsonPropertyName("deletedTime")]
    public string? DeletedTime { get; set; }

    /// <summary>
    /// EnabledProtocols: The authentication protocol that is used for the file share. Can only be specified when creating a
    /// share.
    /// </summary>
    [JsonPropertyName("enabledProtocols")]
    public string? EnabledProtocols { get; set; }

    /// <summary>Etag: Resource Etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FileSharePaidBursting: File Share Paid Bursting properties.</summary>
    [JsonPropertyName("fileSharePaidBursting")]
    public V20250601StorageAccountsFileServicesShareStatusFileSharePaidBursting? FileSharePaidBursting { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IncludedBurstIops: The calculated burst IOPS of the share. This property is only for file shares created under Files
    /// Provisioned v2 account type.
    /// </summary>
    [JsonPropertyName("includedBurstIops")]
    public int? IncludedBurstIops { get; set; }

    /// <summary>LastModifiedTime: Returns the date and time the share was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>LeaseDuration: Specifies whether the lease on a share is of infinite or fixed duration, only when the share is leased.</summary>
    [JsonPropertyName("leaseDuration")]
    public string? LeaseDuration { get; set; }

    /// <summary>LeaseState: Lease state of the share.</summary>
    [JsonPropertyName("leaseState")]
    public string? LeaseState { get; set; }

    /// <summary>LeaseStatus: The lease status of the share.</summary>
    [JsonPropertyName("leaseStatus")]
    public string? LeaseStatus { get; set; }

    /// <summary>
    /// MaxBurstCreditsForIops: The calculated maximum burst credits for the share. This property is only for file shares
    /// created under Files Provisioned v2 account type.
    /// </summary>
    [JsonPropertyName("maxBurstCreditsForIops")]
    public int? MaxBurstCreditsForIops { get; set; }

    /// <summary>Metadata: A name-value pair to associate with the share as metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// NextAllowedProvisionedBandwidthDowngradeTime: Returns the next allowed provisioned bandwidth downgrade time for the
    /// share. This property is only for file shares created under Files Provisioned v2 account type.
    /// </summary>
    [JsonPropertyName("nextAllowedProvisionedBandwidthDowngradeTime")]
    public string? NextAllowedProvisionedBandwidthDowngradeTime { get; set; }

    /// <summary>
    /// NextAllowedProvisionedIopsDowngradeTime: Returns the next allowed provisioned IOPS downgrade time for the share. This
    /// property is only for file shares created under Files Provisioned v2 account type.
    /// </summary>
    [JsonPropertyName("nextAllowedProvisionedIopsDowngradeTime")]
    public string? NextAllowedProvisionedIopsDowngradeTime { get; set; }

    /// <summary>
    /// NextAllowedQuotaDowngradeTime: Returns the next allowed provisioned storage size downgrade time for the share. This
    /// property is only for file shares created under Files Provisioned v1 SSD and Files Provisioned v2 account type
    /// </summary>
    [JsonPropertyName("nextAllowedQuotaDowngradeTime")]
    public string? NextAllowedQuotaDowngradeTime { get; set; }

    /// <summary>
    /// ProvisionedBandwidthMibps: The provisioned bandwidth of the share, in mebibytes per second. This property is only for
    /// file shares created under Files Provisioned v2 account type. Please refer to the GetFileServiceUsage API response for
    /// the minimum and maximum allowed value for provisioned bandwidth.
    /// </summary>
    [JsonPropertyName("provisionedBandwidthMibps")]
    public int? ProvisionedBandwidthMibps { get; set; }

    /// <summary>
    /// ProvisionedIops: The provisioned IOPS of the share. This property is only for file shares created under Files
    /// Provisioned v2 account type. Please refer to the GetFileServiceUsage API response for the minimum and maximum allowed
    /// value for provisioned IOPS.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public int? ProvisionedIops { get; set; }

    /// <summary>RemainingRetentionDays: Remaining retention days for share that was soft deleted.</summary>
    [JsonPropertyName("remainingRetentionDays")]
    public int? RemainingRetentionDays { get; set; }

    /// <summary>RootSquash: The property is for NFS share only. The default is NoRootSquash.</summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }

    /// <summary>
    /// ShareQuota: The provisioned size of the share, in gibibytes. Must be greater than 0, and less than or equal to 5TB
    /// (5120). For Large File Shares, the maximum size is 102400. For file shares created under Files Provisioned v2 account
    /// type, please refer to the GetFileServiceUsage API response for the minimum and maximum allowed provisioned storage size.
    /// </summary>
    [JsonPropertyName("shareQuota")]
    public int? ShareQuota { get; set; }

    /// <summary>
    /// ShareUsageBytes: The approximate size of the data stored on the share. Note that this value may not include all recently
    /// created or recently resized files.
    /// </summary>
    [JsonPropertyName("shareUsageBytes")]
    public int? ShareUsageBytes { get; set; }

    /// <summary>SignedIdentifiers: List of stored access policies specified on the share.</summary>
    [JsonPropertyName("signedIdentifiers")]
    public IList<V20250601StorageAccountsFileServicesShareStatusSignedIdentifiers>? SignedIdentifiers { get; set; }

    /// <summary>SnapshotTime: Creation time of share snapshot returned in the response of list shares with expand param &quot;snapshots&quot;.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250601StorageAccountsFileServicesShareStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: The version of the share.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601StorageAccountsFileServicesShare : IKubernetesObject<V1ObjectMeta>, ISpec<V20250601StorageAccountsFileServicesShareSpec?>, IStatus<V20250601StorageAccountsFileServicesShareStatus?>
{
    public const string KubeApiVersion = "v20250601";
    public const string KubeKind = "StorageAccountsFileServicesShare";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservicesshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileServicesShare";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250601StorageAccountsFileServicesShareSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250601StorageAccountsFileServicesShareStatus? Status { get; set; }
}