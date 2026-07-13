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
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/file.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230101StorageAccountsFileServicesShareList : IKubernetesObject<V1ListMeta>, IItems<V20230101StorageAccountsFileServicesShare>
{
    public const string KubeApiVersion = "v20230101";
    public const string KubeKind = "StorageAccountsFileServicesShareList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservicesshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileServicesShareList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20230101StorageAccountsFileServicesShare objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20230101StorageAccountsFileServicesShare> Items { get; set; }
}

/// <summary>
/// AccessTier: Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and
/// Cool. FileStorage account can choose Premium.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230101StorageAccountsFileServicesShareSpecAccessTierEnum>))]
public enum V20230101StorageAccountsFileServicesShareSpecAccessTierEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V20230101StorageAccountsFileServicesShareSpecEnabledProtocolsEnum>))]
public enum V20230101StorageAccountsFileServicesShareSpecEnabledProtocolsEnum
{
    [EnumMember(Value = "NFS"), JsonStringEnumMemberName("NFS")]
    NFS,
    [EnumMember(Value = "SMB"), JsonStringEnumMemberName("SMB")]
    SMB
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsFileServicesShareSpecOperatorSpecConfigMapExpressions
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
public partial class V20230101StorageAccountsFileServicesShareSpecOperatorSpecSecretExpressions
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
public partial class V20230101StorageAccountsFileServicesShareSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20230101StorageAccountsFileServicesShareSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20230101StorageAccountsFileServicesShareSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccountsFileService resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsFileServicesShareSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RootSquash: The property is for NFS share only. The default is NoRootSquash.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20230101StorageAccountsFileServicesShareSpecRootSquashEnum>))]
public enum V20230101StorageAccountsFileServicesShareSpecRootSquashEnum
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
public partial class V20230101StorageAccountsFileServicesShareSpecSignedIdentifiersAccessPolicy
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
public partial class V20230101StorageAccountsFileServicesShareSpecSignedIdentifiersReference
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
public partial class V20230101StorageAccountsFileServicesShareSpecSignedIdentifiers
{
    /// <summary>AccessPolicy: Access policy</summary>
    [JsonPropertyName("accessPolicy")]
    public V20230101StorageAccountsFileServicesShareSpecSignedIdentifiersAccessPolicy? AccessPolicy { get; set; }

    /// <summary>Reference: An unique identifier of the stored access policy.</summary>
    [JsonPropertyName("reference")]
    public V20230101StorageAccountsFileServicesShareSpecSignedIdentifiersReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsFileServicesShareSpec
{
    /// <summary>
    /// AccessTier: Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and
    /// Cool. FileStorage account can choose Premium.
    /// </summary>
    [JsonPropertyName("accessTier")]
    public V20230101StorageAccountsFileServicesShareSpecAccessTierEnum? AccessTier { get; set; }

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
    public V20230101StorageAccountsFileServicesShareSpecEnabledProtocolsEnum? EnabledProtocols { get; set; }

    /// <summary>Metadata: A name-value pair to associate with the share as metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20230101StorageAccountsFileServicesShareSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccountsFileService resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20230101StorageAccountsFileServicesShareSpecOwner Owner { get; set; }

    /// <summary>RootSquash: The property is for NFS share only. The default is NoRootSquash.</summary>
    [JsonPropertyName("rootSquash")]
    public V20230101StorageAccountsFileServicesShareSpecRootSquashEnum? RootSquash { get; set; }

    /// <summary>
    /// ShareQuota: The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120).
    /// For Large File Shares, the maximum size is 102400.
    /// </summary>
    [JsonPropertyName("shareQuota")]
    public int? ShareQuota { get; set; }

    /// <summary>SignedIdentifiers: List of stored access policies specified on the share.</summary>
    [JsonPropertyName("signedIdentifiers")]
    public IList<V20230101StorageAccountsFileServicesShareSpecSignedIdentifiers>? SignedIdentifiers { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsFileServicesShareStatusConditions
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

/// <summary>AccessPolicy: Access policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsFileServicesShareStatusSignedIdentifiersAccessPolicy
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
public partial class V20230101StorageAccountsFileServicesShareStatusSignedIdentifiers
{
    /// <summary>AccessPolicy: Access policy</summary>
    [JsonPropertyName("accessPolicy")]
    public V20230101StorageAccountsFileServicesShareStatusSignedIdentifiersAccessPolicy? AccessPolicy { get; set; }

    /// <summary>Id: An unique identifier of the stored access policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20230101StorageAccountsFileServicesShareStatus
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
    public IList<V20230101StorageAccountsFileServicesShareStatusConditions>? Conditions { get; set; }

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

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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

    /// <summary>Metadata: A name-value pair to associate with the share as metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RemainingRetentionDays: Remaining retention days for share that was soft deleted.</summary>
    [JsonPropertyName("remainingRetentionDays")]
    public int? RemainingRetentionDays { get; set; }

    /// <summary>RootSquash: The property is for NFS share only. The default is NoRootSquash.</summary>
    [JsonPropertyName("rootSquash")]
    public string? RootSquash { get; set; }

    /// <summary>
    /// ShareQuota: The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120).
    /// For Large File Shares, the maximum size is 102400.
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
    public IList<V20230101StorageAccountsFileServicesShareStatusSignedIdentifiers>? SignedIdentifiers { get; set; }

    /// <summary>SnapshotTime: Creation time of share snapshot returned in the response of list shares with expand param &quot;snapshots&quot;.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: The version of the share.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/file.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20230101StorageAccountsFileServicesShare : IKubernetesObject<V1ObjectMeta>, ISpec<V20230101StorageAccountsFileServicesShareSpec?>, IStatus<V20230101StorageAccountsFileServicesShareStatus?>
{
    public const string KubeApiVersion = "v20230101";
    public const string KubeKind = "StorageAccountsFileServicesShare";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservicesshares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileServicesShare";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20230101StorageAccountsFileServicesShareSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20230101StorageAccountsFileServicesShareStatus? Status { get; set; }
}