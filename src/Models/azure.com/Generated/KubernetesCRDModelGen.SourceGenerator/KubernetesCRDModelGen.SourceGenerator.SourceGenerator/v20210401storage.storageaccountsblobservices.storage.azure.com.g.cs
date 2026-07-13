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
/// Storage version of v20210401.StorageAccountsBlobService
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2021-04-01/blob.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210401storageStorageAccountsBlobServiceList : IKubernetesObject<V1ListMeta>, IItems<V20210401storageStorageAccountsBlobService>
{
    public const string KubeApiVersion = "v20210401storage";
    public const string KubeKind = "StorageAccountsBlobServiceList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20210401storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20210401storageStorageAccountsBlobService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20210401storageStorageAccountsBlobService> Items { get; set; }
}

/// <summary>
/// Storage version of v20210401.ChangeFeed
/// The blob service properties for change feed events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecChangeFeed
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }
}

/// <summary>
/// Storage version of v20210401.DeleteRetentionPolicy
/// The service properties for soft delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecContainerDeleteRetentionPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20210401.CorsRule
/// Specifies a CORS rule for the Blob service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecCorsCorsRules
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
/// Storage version of v20210401.CorsRules
/// Sets the CORS rules. You can include up to five CorsRule elements in the request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("corsRules")]
    public IList<V20210401storageStorageAccountsBlobServiceSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>
/// Storage version of v20210401.DeleteRetentionPolicy
/// The service properties for soft delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecDeleteRetentionPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20210401.LastAccessTimeTrackingPolicy
/// The blob service properties for Last access time based tracking policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobType")]
    public IList<string>? BlobType { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("trackingGranularityInDays")]
    public int? TrackingGranularityInDays { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecOperatorSpecConfigMapExpressions
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
public partial class V20210401storageStorageAccountsBlobServiceSpecOperatorSpecSecretExpressions
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
/// Storage version of v20210401.StorageAccountsBlobServiceOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20210401storageStorageAccountsBlobServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20210401storageStorageAccountsBlobServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20210401.RestorePolicyProperties
/// The blob service properties for blob restore policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpecRestorePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v20210401.StorageAccountsBlobService_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("automaticSnapshotPolicyEnabled")]
    public bool? AutomaticSnapshotPolicyEnabled { get; set; }

    /// <summary>
    /// Storage version of v20210401.ChangeFeed
    /// The blob service properties for change feed events.
    /// </summary>
    [JsonPropertyName("changeFeed")]
    public V20210401storageStorageAccountsBlobServiceSpecChangeFeed? ChangeFeed { get; set; }

    /// <summary>
    /// Storage version of v20210401.DeleteRetentionPolicy
    /// The service properties for soft delete.
    /// </summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public V20210401storageStorageAccountsBlobServiceSpecContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>
    /// Storage version of v20210401.CorsRules
    /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20210401storageStorageAccountsBlobServiceSpecCors? Cors { get; set; }

    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>
    /// Storage version of v20210401.DeleteRetentionPolicy
    /// The service properties for soft delete.
    /// </summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public V20210401storageStorageAccountsBlobServiceSpecDeleteRetentionPolicy? DeleteRetentionPolicy { get; set; }

    [JsonPropertyName("isVersioningEnabled")]
    public bool? IsVersioningEnabled { get; set; }

    /// <summary>
    /// Storage version of v20210401.LastAccessTimeTrackingPolicy
    /// The blob service properties for Last access time based tracking policy.
    /// </summary>
    [JsonPropertyName("lastAccessTimeTrackingPolicy")]
    public V20210401storageStorageAccountsBlobServiceSpecLastAccessTimeTrackingPolicy? LastAccessTimeTrackingPolicy { get; set; }

    /// <summary>
    /// Storage version of v20210401.StorageAccountsBlobServiceOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20210401storageStorageAccountsBlobServiceSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20210401storageStorageAccountsBlobServiceSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20210401.RestorePolicyProperties
    /// The blob service properties for blob restore policy
    /// </summary>
    [JsonPropertyName("restorePolicy")]
    public V20210401storageStorageAccountsBlobServiceSpecRestorePolicy? RestorePolicy { get; set; }
}

/// <summary>
/// Storage version of v20210401.ChangeFeed_STATUS
/// The blob service properties for change feed events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusChangeFeed
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusConditions
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
/// Storage version of v20210401.DeleteRetentionPolicy_STATUS
/// The service properties for soft delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusContainerDeleteRetentionPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20210401.CorsRule_STATUS
/// Specifies a CORS rule for the Blob service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusCorsCorsRules
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
/// Storage version of v20210401.CorsRules_STATUS
/// Sets the CORS rules. You can include up to five CorsRule elements in the request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("corsRules")]
    public IList<V20210401storageStorageAccountsBlobServiceStatusCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>
/// Storage version of v20210401.DeleteRetentionPolicy_STATUS
/// The service properties for soft delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusDeleteRetentionPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v20210401.LastAccessTimeTrackingPolicy_STATUS
/// The blob service properties for Last access time based tracking policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusLastAccessTimeTrackingPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobType")]
    public IList<string>? BlobType { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("trackingGranularityInDays")]
    public int? TrackingGranularityInDays { get; set; }
}

/// <summary>
/// Storage version of v20210401.RestorePolicyProperties_STATUS
/// The blob service properties for blob restore policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusRestorePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("days")]
    public int? Days { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }

    [JsonPropertyName("minRestoreTime")]
    public string? MinRestoreTime { get; set; }
}

/// <summary>
/// Storage version of v20210401.Sku_STATUS
/// The SKU of the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatusSku
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

/// <summary>Storage version of v20210401.StorageAccountsBlobService_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210401storageStorageAccountsBlobServiceStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("automaticSnapshotPolicyEnabled")]
    public bool? AutomaticSnapshotPolicyEnabled { get; set; }

    /// <summary>
    /// Storage version of v20210401.ChangeFeed_STATUS
    /// The blob service properties for change feed events.
    /// </summary>
    [JsonPropertyName("changeFeed")]
    public V20210401storageStorageAccountsBlobServiceStatusChangeFeed? ChangeFeed { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20210401storageStorageAccountsBlobServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20210401.DeleteRetentionPolicy_STATUS
    /// The service properties for soft delete.
    /// </summary>
    [JsonPropertyName("containerDeleteRetentionPolicy")]
    public V20210401storageStorageAccountsBlobServiceStatusContainerDeleteRetentionPolicy? ContainerDeleteRetentionPolicy { get; set; }

    /// <summary>
    /// Storage version of v20210401.CorsRules_STATUS
    /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
    /// </summary>
    [JsonPropertyName("cors")]
    public V20210401storageStorageAccountsBlobServiceStatusCors? Cors { get; set; }

    [JsonPropertyName("defaultServiceVersion")]
    public string? DefaultServiceVersion { get; set; }

    /// <summary>
    /// Storage version of v20210401.DeleteRetentionPolicy_STATUS
    /// The service properties for soft delete.
    /// </summary>
    [JsonPropertyName("deleteRetentionPolicy")]
    public V20210401storageStorageAccountsBlobServiceStatusDeleteRetentionPolicy? DeleteRetentionPolicy { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isVersioningEnabled")]
    public bool? IsVersioningEnabled { get; set; }

    /// <summary>
    /// Storage version of v20210401.LastAccessTimeTrackingPolicy_STATUS
    /// The blob service properties for Last access time based tracking policy.
    /// </summary>
    [JsonPropertyName("lastAccessTimeTrackingPolicy")]
    public V20210401storageStorageAccountsBlobServiceStatusLastAccessTimeTrackingPolicy? LastAccessTimeTrackingPolicy { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20210401.RestorePolicyProperties_STATUS
    /// The blob service properties for blob restore policy
    /// </summary>
    [JsonPropertyName("restorePolicy")]
    public V20210401storageStorageAccountsBlobServiceStatusRestorePolicy? RestorePolicy { get; set; }

    /// <summary>
    /// Storage version of v20210401.Sku_STATUS
    /// The SKU of the storage account.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20210401storageStorageAccountsBlobServiceStatusSku? Sku { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20210401.StorageAccountsBlobService
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2021-04-01/blob.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210401storageStorageAccountsBlobService : IKubernetesObject<V1ObjectMeta>, ISpec<V20210401storageStorageAccountsBlobServiceSpec?>, IStatus<V20210401storageStorageAccountsBlobServiceStatus?>
{
    public const string KubeApiVersion = "v20210401storage";
    public const string KubeKind = "StorageAccountsBlobService";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20210401storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20210401.StorageAccountsBlobService_Spec</summary>
    [JsonPropertyName("spec")]
    public V20210401storageStorageAccountsBlobServiceSpec? Spec { get; set; }

    /// <summary>Storage version of v20210401.StorageAccountsBlobService_STATUS</summary>
    [JsonPropertyName("status")]
    public V20210401storageStorageAccountsBlobServiceStatus? Status { get; set; }
}