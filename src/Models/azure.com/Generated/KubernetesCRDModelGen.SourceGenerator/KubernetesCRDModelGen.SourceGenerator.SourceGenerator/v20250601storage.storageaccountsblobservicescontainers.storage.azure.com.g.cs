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
/// Storage version of v20250601.StorageAccountsBlobServicesContainer
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601storageStorageAccountsBlobServicesContainerList : IKubernetesObject<V1ListMeta>, IItems<V20250601storageStorageAccountsBlobServicesContainer>
{
    public const string KubeApiVersion = "v20250601storage";
    public const string KubeKind = "StorageAccountsBlobServicesContainerList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservicescontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobServicesContainerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250601storageStorageAccountsBlobServicesContainer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250601storageStorageAccountsBlobServicesContainer> Items { get; set; }
}

/// <summary>
/// Storage version of v20250601.ImmutableStorageWithVersioning
/// Object level immutability properties of the container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerSpecImmutableStorageWithVersioning
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerSpecOperatorSpecConfigMapExpressions
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
public partial class V20250601storageStorageAccountsBlobServicesContainerSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250601.StorageAccountsBlobServicesContainerOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250601storageStorageAccountsBlobServicesContainerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250601storageStorageAccountsBlobServicesContainerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccountsBlobService resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20250601.StorageAccountsBlobServicesContainer_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("defaultEncryptionScope")]
    public string? DefaultEncryptionScope { get; set; }

    [JsonPropertyName("denyEncryptionScopeOverride")]
    public bool? DenyEncryptionScopeOverride { get; set; }

    [JsonPropertyName("enableNfsV3AllSquash")]
    public bool? EnableNfsV3AllSquash { get; set; }

    [JsonPropertyName("enableNfsV3RootSquash")]
    public bool? EnableNfsV3RootSquash { get; set; }

    /// <summary>
    /// Storage version of v20250601.ImmutableStorageWithVersioning
    /// Object level immutability properties of the container.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20250601storageStorageAccountsBlobServicesContainerSpecImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountsBlobServicesContainerOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250601storageStorageAccountsBlobServicesContainerSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccountsBlobService resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250601storageStorageAccountsBlobServicesContainerSpecOwner Owner { get; set; }

    [JsonPropertyName("publicAccess")]
    public string? PublicAccess { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusConditions
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
/// Storage version of v20250601.UpdateHistoryProperty_STATUS
/// An update history of the ImmutabilityPolicy of a blob container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicyUpdateHistory
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    [JsonPropertyName("update")]
    public string? Update { get; set; }

    [JsonPropertyName("upn")]
    public string? Upn { get; set; }
}

/// <summary>
/// Storage version of v20250601.ImmutabilityPolicyProperties_STATUS
/// The properties of an ImmutabilityPolicy of a blob container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("updateHistory")]
    public IList<V20250601storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicyUpdateHistory>? UpdateHistory { get; set; }
}

/// <summary>
/// Storage version of v20250601.ImmutableStorageWithVersioning_STATUS
/// Object level immutability properties of the container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusImmutableStorageWithVersioning
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("migrationState")]
    public string? MigrationState { get; set; }

    [JsonPropertyName("timeStamp")]
    public string? TimeStamp { get; set; }
}

/// <summary>
/// Storage version of v20250601.ProtectedAppendWritesHistory_STATUS
/// Protected append writes history setting for the blob container with Legal holds.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusLegalHoldProtectedAppendWritesHistory
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary>
/// Storage version of v20250601.TagProperty_STATUS
/// A tag of the LegalHold of a blob container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusLegalHoldTags
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    [JsonPropertyName("upn")]
    public string? Upn { get; set; }
}

/// <summary>
/// Storage version of v20250601.LegalHoldProperties_STATUS
/// The LegalHold property of a blob container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusLegalHold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("hasLegalHold")]
    public bool? HasLegalHold { get; set; }

    /// <summary>
    /// Storage version of v20250601.ProtectedAppendWritesHistory_STATUS
    /// Protected append writes history setting for the blob container with Legal holds.
    /// </summary>
    [JsonPropertyName("protectedAppendWritesHistory")]
    public V20250601storageStorageAccountsBlobServicesContainerStatusLegalHoldProtectedAppendWritesHistory? ProtectedAppendWritesHistory { get; set; }

    [JsonPropertyName("tags")]
    public IList<V20250601storageStorageAccountsBlobServicesContainerStatusLegalHoldTags>? Tags { get; set; }
}

/// <summary>
/// Storage version of v20250601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v20250601.StorageAccountsBlobServicesContainer_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountsBlobServicesContainerStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250601storageStorageAccountsBlobServicesContainerStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("defaultEncryptionScope")]
    public string? DefaultEncryptionScope { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("deletedTime")]
    public string? DeletedTime { get; set; }

    [JsonPropertyName("denyEncryptionScopeOverride")]
    public bool? DenyEncryptionScopeOverride { get; set; }

    [JsonPropertyName("enableNfsV3AllSquash")]
    public bool? EnableNfsV3AllSquash { get; set; }

    [JsonPropertyName("enableNfsV3RootSquash")]
    public bool? EnableNfsV3RootSquash { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("hasImmutabilityPolicy")]
    public bool? HasImmutabilityPolicy { get; set; }

    [JsonPropertyName("hasLegalHold")]
    public bool? HasLegalHold { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250601.ImmutabilityPolicyProperties_STATUS
    /// The properties of an ImmutabilityPolicy of a blob container.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V20250601storageStorageAccountsBlobServicesContainerStatusImmutabilityPolicy? ImmutabilityPolicy { get; set; }

    /// <summary>
    /// Storage version of v20250601.ImmutableStorageWithVersioning_STATUS
    /// Object level immutability properties of the container.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20250601storageStorageAccountsBlobServicesContainerStatusImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    [JsonPropertyName("leaseDuration")]
    public string? LeaseDuration { get; set; }

    [JsonPropertyName("leaseState")]
    public string? LeaseState { get; set; }

    [JsonPropertyName("leaseStatus")]
    public string? LeaseStatus { get; set; }

    /// <summary>
    /// Storage version of v20250601.LegalHoldProperties_STATUS
    /// The LegalHold property of a blob container.
    /// </summary>
    [JsonPropertyName("legalHold")]
    public V20250601storageStorageAccountsBlobServicesContainerStatusLegalHold? LegalHold { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("publicAccess")]
    public string? PublicAccess { get; set; }

    [JsonPropertyName("remainingRetentionDays")]
    public int? RemainingRetentionDays { get; set; }

    /// <summary>
    /// Storage version of v20250601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250601storageStorageAccountsBlobServicesContainerStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountsBlobServicesContainer
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601storageStorageAccountsBlobServicesContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V20250601storageStorageAccountsBlobServicesContainerSpec?>, IStatus<V20250601storageStorageAccountsBlobServicesContainerStatus?>
{
    public const string KubeApiVersion = "v20250601storage";
    public const string KubeKind = "StorageAccountsBlobServicesContainer";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservicescontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobServicesContainer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250601.StorageAccountsBlobServicesContainer_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250601storageStorageAccountsBlobServicesContainerSpec? Spec { get; set; }

    /// <summary>Storage version of v20250601.StorageAccountsBlobServicesContainer_STATUS</summary>
    [JsonPropertyName("status")]
    public V20250601storageStorageAccountsBlobServicesContainerStatus? Status { get; set; }
}