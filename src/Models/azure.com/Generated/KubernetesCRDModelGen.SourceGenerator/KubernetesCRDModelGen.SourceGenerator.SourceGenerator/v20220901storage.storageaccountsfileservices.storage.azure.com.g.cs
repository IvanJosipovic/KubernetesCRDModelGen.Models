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
/// Storage version of v20220901.StorageAccountsFileService
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/file.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220901storageStorageAccountsFileServiceList : IKubernetesObject<V1ListMeta>, IItems<V20220901storageStorageAccountsFileService>
{
    public const string KubeApiVersion = "v20220901storage";
    public const string KubeKind = "StorageAccountsFileServiceList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20220901storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220901storageStorageAccountsFileService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220901storageStorageAccountsFileService> Items { get; set; }
}

/// <summary>
/// Storage version of v20220901.CorsRule
/// Specifies a CORS rule for the Blob service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecCorsCorsRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>
/// Storage version of v20220901.CorsRules
/// Sets the CORS rules. You can include up to five CorsRule elements in the request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("corsRules")]
    public IList<V20220901storageStorageAccountsFileServiceSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecOperatorSpecConfigMapExpressions
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
public partial class V20220901storageStorageAccountsFileServiceSpecOperatorSpecSecretExpressions
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
/// Storage version of v20220901.StorageAccountsFileServiceOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20220901storageStorageAccountsFileServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20220901storageStorageAccountsFileServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20220901.Multichannel
/// Multichannel setting. Applies to Premium FileStorage only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecProtocolSettingsSmbMultichannel
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20220901.SmbSetting
/// Setting for SMB protocol
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecProtocolSettingsSmb
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationMethods")]
    public string? AuthenticationMethods { get; set; }

    [JsonPropertyName("channelEncryption")]
    public string? ChannelEncryption { get; set; }

    [JsonPropertyName("kerberosTicketEncryption")]
    public string? KerberosTicketEncryption { get; set; }

    /// <summary>
    /// Storage version of v20220901.Multichannel
    /// Multichannel setting. Applies to Premium FileStorage only.
    /// </summary>
    [JsonPropertyName("multichannel")]
    public V20220901storageStorageAccountsFileServiceSpecProtocolSettingsSmbMultichannel? Multichannel { get; set; }

    [JsonPropertyName("versions")]
    public string? Versions { get; set; }
}

/// <summary>
/// Storage version of v20220901.ProtocolSettings
/// Protocol settings for file service
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecProtocolSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220901.SmbSetting
    /// Setting for SMB protocol
    /// </summary>
    [JsonPropertyName("smb")]
    public V20220901storageStorageAccountsFileServiceSpecProtocolSettingsSmb? Smb { get; set; }
}

/// <summary>
/// Storage version of v20220901.DeleteRetentionPolicy
/// The service properties for soft delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpecShareDeleteRetentionPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v20220901.StorageAccountsFileService_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220901.CorsRules
    /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20220901storageStorageAccountsFileServiceSpecCors? Cors { get; set; }

    /// <summary>
    /// Storage version of v20220901.StorageAccountsFileServiceOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220901storageStorageAccountsFileServiceSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220901storageStorageAccountsFileServiceSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20220901.ProtocolSettings
    /// Protocol settings for file service
    /// </summary>
    [JsonPropertyName("protocolSettings")]
    public V20220901storageStorageAccountsFileServiceSpecProtocolSettings? ProtocolSettings { get; set; }

    /// <summary>
    /// Storage version of v20220901.DeleteRetentionPolicy
    /// The service properties for soft delete.
    /// </summary>
    [JsonPropertyName("shareDeleteRetentionPolicy")]
    public V20220901storageStorageAccountsFileServiceSpecShareDeleteRetentionPolicy? ShareDeleteRetentionPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusConditions
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
/// Storage version of v20220901.CorsRule_STATUS
/// Specifies a CORS rule for the Blob service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusCorsCorsRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    [JsonPropertyName("maxAgeInSeconds")]
    public int? MaxAgeInSeconds { get; set; }
}

/// <summary>
/// Storage version of v20220901.CorsRules_STATUS
/// Sets the CORS rules. You can include up to five CorsRule elements in the request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("corsRules")]
    public IList<V20220901storageStorageAccountsFileServiceStatusCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>
/// Storage version of v20220901.Multichannel_STATUS
/// Multichannel setting. Applies to Premium FileStorage only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusProtocolSettingsSmbMultichannel
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20220901.SmbSetting_STATUS
/// Setting for SMB protocol
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusProtocolSettingsSmb
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationMethods")]
    public string? AuthenticationMethods { get; set; }

    [JsonPropertyName("channelEncryption")]
    public string? ChannelEncryption { get; set; }

    [JsonPropertyName("kerberosTicketEncryption")]
    public string? KerberosTicketEncryption { get; set; }

    /// <summary>
    /// Storage version of v20220901.Multichannel_STATUS
    /// Multichannel setting. Applies to Premium FileStorage only.
    /// </summary>
    [JsonPropertyName("multichannel")]
    public V20220901storageStorageAccountsFileServiceStatusProtocolSettingsSmbMultichannel? Multichannel { get; set; }

    [JsonPropertyName("versions")]
    public string? Versions { get; set; }
}

/// <summary>
/// Storage version of v20220901.ProtocolSettings_STATUS
/// Protocol settings for file service
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusProtocolSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220901.SmbSetting_STATUS
    /// Setting for SMB protocol
    /// </summary>
    [JsonPropertyName("smb")]
    public V20220901storageStorageAccountsFileServiceStatusProtocolSettingsSmb? Smb { get; set; }
}

/// <summary>
/// Storage version of v20220901.DeleteRetentionPolicy_STATUS
/// The service properties for soft delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusShareDeleteRetentionPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowPermanentDelete")]
    public bool? AllowPermanentDelete { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20220901.Sku_STATUS
/// The SKU of the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v20220901.StorageAccountsFileService_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901storageStorageAccountsFileServiceStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20220901storageStorageAccountsFileServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20220901.CorsRules_STATUS
    /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20220901storageStorageAccountsFileServiceStatusCors? Cors { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20220901.ProtocolSettings_STATUS
    /// Protocol settings for file service
    /// </summary>
    [JsonPropertyName("protocolSettings")]
    public V20220901storageStorageAccountsFileServiceStatusProtocolSettings? ProtocolSettings { get; set; }

    /// <summary>
    /// Storage version of v20220901.DeleteRetentionPolicy_STATUS
    /// The service properties for soft delete.
    /// </summary>
    [JsonPropertyName("shareDeleteRetentionPolicy")]
    public V20220901storageStorageAccountsFileServiceStatusShareDeleteRetentionPolicy? ShareDeleteRetentionPolicy { get; set; }

    /// <summary>
    /// Storage version of v20220901.Sku_STATUS
    /// The SKU of the storage account.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20220901storageStorageAccountsFileServiceStatusSku? Sku { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220901.StorageAccountsFileService
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/file.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220901storageStorageAccountsFileService : IKubernetesObject<V1ObjectMeta>, ISpec<V20220901storageStorageAccountsFileServiceSpec?>, IStatus<V20220901storageStorageAccountsFileServiceStatus?>
{
    public const string KubeApiVersion = "v20220901storage";
    public const string KubeKind = "StorageAccountsFileService";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsfileservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20220901storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsFileService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20220901.StorageAccountsFileService_Spec</summary>
    [JsonPropertyName("spec")]
    public V20220901storageStorageAccountsFileServiceSpec? Spec { get; set; }

    /// <summary>Storage version of v20220901.StorageAccountsFileService_STATUS</summary>
    [JsonPropertyName("status")]
    public V20220901storageStorageAccountsFileServiceStatus? Status { get; set; }
}