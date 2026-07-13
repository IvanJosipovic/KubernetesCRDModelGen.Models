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
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/blob.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220901StorageAccountsBlobServicesContainerList : IKubernetesObject<V1ListMeta>, IItems<V20220901StorageAccountsBlobServicesContainer>
{
    public const string KubeApiVersion = "v20220901";
    public const string KubeKind = "StorageAccountsBlobServicesContainerList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservicescontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20220901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobServicesContainerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220901StorageAccountsBlobServicesContainer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220901StorageAccountsBlobServicesContainer> Items { get; set; }
}

/// <summary>
/// ImmutableStorageWithVersioning: The object level immutability property of the container. The property is immutable and
/// can only be set to true at the container creation time. Existing containers must undergo a migration process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerSpecImmutableStorageWithVersioning
{
    /// <summary>Enabled: This is an immutable property, when set to true it enables object level immutability at the container level.</summary>
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
public partial class V20220901StorageAccountsBlobServicesContainerSpecOperatorSpecConfigMapExpressions
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
public partial class V20220901StorageAccountsBlobServicesContainerSpecOperatorSpecSecretExpressions
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
public partial class V20220901StorageAccountsBlobServicesContainerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20220901StorageAccountsBlobServicesContainerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20220901StorageAccountsBlobServicesContainerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccountsBlobService resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicAccess: Specifies whether data in the container may be accessed publicly and the level of access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220901StorageAccountsBlobServicesContainerSpecPublicAccessEnum>))]
public enum V20220901StorageAccountsBlobServicesContainerSpecPublicAccessEnum
{
    [EnumMember(Value = "Blob"), JsonStringEnumMemberName("Blob")]
    Blob,
    [EnumMember(Value = "Container"), JsonStringEnumMemberName("Container")]
    Container,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DefaultEncryptionScope: Default the container to use specified encryption scope for all writes.</summary>
    [JsonPropertyName("defaultEncryptionScope")]
    public string? DefaultEncryptionScope { get; set; }

    /// <summary>DenyEncryptionScopeOverride: Block override of encryption scope from the container default.</summary>
    [JsonPropertyName("denyEncryptionScopeOverride")]
    public bool? DenyEncryptionScopeOverride { get; set; }

    /// <summary>EnableNfsV3AllSquash: Enable NFSv3 all squash on blob container.</summary>
    [JsonPropertyName("enableNfsV3AllSquash")]
    public bool? EnableNfsV3AllSquash { get; set; }

    /// <summary>EnableNfsV3RootSquash: Enable NFSv3 root squash on blob container.</summary>
    [JsonPropertyName("enableNfsV3RootSquash")]
    public bool? EnableNfsV3RootSquash { get; set; }

    /// <summary>
    /// ImmutableStorageWithVersioning: The object level immutability property of the container. The property is immutable and
    /// can only be set to true at the container creation time. Existing containers must undergo a migration process.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20220901StorageAccountsBlobServicesContainerSpecImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    /// <summary>Metadata: A name-value pair to associate with the container as metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220901StorageAccountsBlobServicesContainerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccountsBlobService resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220901StorageAccountsBlobServicesContainerSpecOwner Owner { get; set; }

    /// <summary>PublicAccess: Specifies whether data in the container may be accessed publicly and the level of access.</summary>
    [JsonPropertyName("publicAccess")]
    public V20220901StorageAccountsBlobServicesContainerSpecPublicAccessEnum? PublicAccess { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusConditions
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

/// <summary>An update history of the ImmutabilityPolicy of a blob container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusImmutabilityPolicyUpdateHistory
{
    /// <summary>
    /// AllowProtectedAppendWrites: This property can only be changed for unlocked time-based retention policies. When enabled,
    /// new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks
    /// can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with
    /// ExtendImmutabilityPolicy API.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// AllowProtectedAppendWritesAll: This property can only be changed for unlocked time-based retention policies. When
    /// enabled, new blocks can be written to both &apos;Append and Bock Blobs&apos; while maintaining immutability protection and
    /// compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be
    /// changed with ExtendImmutabilityPolicy API. The &apos;allowProtectedAppendWrites&apos; and &apos;allowProtectedAppendWritesAll&apos;
    /// properties are mutually exclusive.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    /// <summary>
    /// ImmutabilityPeriodSinceCreationInDays: The immutability period for the blobs in the container since the policy creation,
    /// in days.
    /// </summary>
    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    /// <summary>ObjectIdentifier: Returns the Object ID of the user who updated the ImmutabilityPolicy.</summary>
    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    /// <summary>TenantId: Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Timestamp: Returns the date and time the ImmutabilityPolicy was updated.</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>Update: The ImmutabilityPolicy update type of a blob container, possible values include: put, lock and extend.</summary>
    [JsonPropertyName("update")]
    public string? Update { get; set; }

    /// <summary>Upn: Returns the User Principal Name of the user who updated the ImmutabilityPolicy.</summary>
    [JsonPropertyName("upn")]
    public string? Upn { get; set; }
}

/// <summary>ImmutabilityPolicy: The ImmutabilityPolicy property of the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusImmutabilityPolicy
{
    /// <summary>
    /// AllowProtectedAppendWrites: This property can only be changed for unlocked time-based retention policies. When enabled,
    /// new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks
    /// can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with
    /// ExtendImmutabilityPolicy API.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// AllowProtectedAppendWritesAll: This property can only be changed for unlocked time-based retention policies. When
    /// enabled, new blocks can be written to both &apos;Append and Bock Blobs&apos; while maintaining immutability protection and
    /// compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be
    /// changed with ExtendImmutabilityPolicy API. The &apos;allowProtectedAppendWrites&apos; and &apos;allowProtectedAppendWritesAll&apos;
    /// properties are mutually exclusive.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    /// <summary>Etag: ImmutabilityPolicy Etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// ImmutabilityPeriodSinceCreationInDays: The immutability period for the blobs in the container since the policy creation,
    /// in days.
    /// </summary>
    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    /// <summary>State: The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>UpdateHistory: The ImmutabilityPolicy update history of the blob container.</summary>
    [JsonPropertyName("updateHistory")]
    public IList<V20220901StorageAccountsBlobServicesContainerStatusImmutabilityPolicyUpdateHistory>? UpdateHistory { get; set; }
}

/// <summary>
/// ImmutableStorageWithVersioning: The object level immutability property of the container. The property is immutable and
/// can only be set to true at the container creation time. Existing containers must undergo a migration process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusImmutableStorageWithVersioning
{
    /// <summary>Enabled: This is an immutable property, when set to true it enables object level immutability at the container level.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>MigrationState: This property denotes the container level immutability to object level immutability migration state.</summary>
    [JsonPropertyName("migrationState")]
    public string? MigrationState { get; set; }

    /// <summary>TimeStamp: Returns the date and time the object level immutability was enabled.</summary>
    [JsonPropertyName("timeStamp")]
    public string? TimeStamp { get; set; }
}

/// <summary>ProtectedAppendWritesHistory: Protected append blob writes history.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusLegalHoldProtectedAppendWritesHistory
{
    /// <summary>
    /// AllowProtectedAppendWritesAll: When enabled, new blocks can be written to both &apos;Append and Bock Blobs&apos; while maintaining
    /// legal hold protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWritesAll")]
    public bool? AllowProtectedAppendWritesAll { get; set; }

    /// <summary>Timestamp: Returns the date and time the tag was added.</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary>A tag of the LegalHold of a blob container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusLegalHoldTags
{
    /// <summary>ObjectIdentifier: Returns the Object ID of the user who added the tag.</summary>
    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    /// <summary>Tag: The tag value.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>TenantId: Returns the Tenant ID that issued the token for the user who added the tag.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Timestamp: Returns the date and time the tag was added.</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>Upn: Returns the User Principal Name of the user who added the tag.</summary>
    [JsonPropertyName("upn")]
    public string? Upn { get; set; }
}

/// <summary>LegalHold: The LegalHold property of the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatusLegalHold
{
    /// <summary>
    /// HasLegalHold: The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The
    /// hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a
    /// maximum of 1000 blob containers with hasLegalHold=true for a given account.
    /// </summary>
    [JsonPropertyName("hasLegalHold")]
    public bool? HasLegalHold { get; set; }

    /// <summary>ProtectedAppendWritesHistory: Protected append blob writes history.</summary>
    [JsonPropertyName("protectedAppendWritesHistory")]
    public V20220901StorageAccountsBlobServicesContainerStatusLegalHoldProtectedAppendWritesHistory? ProtectedAppendWritesHistory { get; set; }

    /// <summary>Tags: The list of LegalHold tags of a blob container.</summary>
    [JsonPropertyName("tags")]
    public IList<V20220901StorageAccountsBlobServicesContainerStatusLegalHoldTags>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220901StorageAccountsBlobServicesContainerStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20220901StorageAccountsBlobServicesContainerStatusConditions>? Conditions { get; set; }

    /// <summary>DefaultEncryptionScope: Default the container to use specified encryption scope for all writes.</summary>
    [JsonPropertyName("defaultEncryptionScope")]
    public string? DefaultEncryptionScope { get; set; }

    /// <summary>Deleted: Indicates whether the blob container was deleted.</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>DeletedTime: Blob container deletion time.</summary>
    [JsonPropertyName("deletedTime")]
    public string? DeletedTime { get; set; }

    /// <summary>DenyEncryptionScopeOverride: Block override of encryption scope from the container default.</summary>
    [JsonPropertyName("denyEncryptionScopeOverride")]
    public bool? DenyEncryptionScopeOverride { get; set; }

    /// <summary>EnableNfsV3AllSquash: Enable NFSv3 all squash on blob container.</summary>
    [JsonPropertyName("enableNfsV3AllSquash")]
    public bool? EnableNfsV3AllSquash { get; set; }

    /// <summary>EnableNfsV3RootSquash: Enable NFSv3 root squash on blob container.</summary>
    [JsonPropertyName("enableNfsV3RootSquash")]
    public bool? EnableNfsV3RootSquash { get; set; }

    /// <summary>Etag: Resource Etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// HasImmutabilityPolicy: The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been
    /// created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has
    /// not been created for this container.
    /// </summary>
    [JsonPropertyName("hasImmutabilityPolicy")]
    public bool? HasImmutabilityPolicy { get; set; }

    /// <summary>
    /// HasLegalHold: The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The
    /// hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a
    /// maximum of 1000 blob containers with hasLegalHold=true for a given account.
    /// </summary>
    [JsonPropertyName("hasLegalHold")]
    public bool? HasLegalHold { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ImmutabilityPolicy: The ImmutabilityPolicy property of the container.</summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V20220901StorageAccountsBlobServicesContainerStatusImmutabilityPolicy? ImmutabilityPolicy { get; set; }

    /// <summary>
    /// ImmutableStorageWithVersioning: The object level immutability property of the container. The property is immutable and
    /// can only be set to true at the container creation time. Existing containers must undergo a migration process.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20220901StorageAccountsBlobServicesContainerStatusImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    /// <summary>LastModifiedTime: Returns the date and time the container was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>
    /// LeaseDuration: Specifies whether the lease on a container is of infinite or fixed duration, only when the container is
    /// leased.
    /// </summary>
    [JsonPropertyName("leaseDuration")]
    public string? LeaseDuration { get; set; }

    /// <summary>LeaseState: Lease state of the container.</summary>
    [JsonPropertyName("leaseState")]
    public string? LeaseState { get; set; }

    /// <summary>LeaseStatus: The lease status of the container.</summary>
    [JsonPropertyName("leaseStatus")]
    public string? LeaseStatus { get; set; }

    /// <summary>LegalHold: The LegalHold property of the container.</summary>
    [JsonPropertyName("legalHold")]
    public V20220901StorageAccountsBlobServicesContainerStatusLegalHold? LegalHold { get; set; }

    /// <summary>Metadata: A name-value pair to associate with the container as metadata.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PublicAccess: Specifies whether data in the container may be accessed publicly and the level of access.</summary>
    [JsonPropertyName("publicAccess")]
    public string? PublicAccess { get; set; }

    /// <summary>RemainingRetentionDays: Remaining retention days for soft deleted blob container.</summary>
    [JsonPropertyName("remainingRetentionDays")]
    public int? RemainingRetentionDays { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: The version of the deleted blob container.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/blob.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220901StorageAccountsBlobServicesContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V20220901StorageAccountsBlobServicesContainerSpec?>, IStatus<V20220901StorageAccountsBlobServicesContainerStatus?>
{
    public const string KubeApiVersion = "v20220901";
    public const string KubeKind = "StorageAccountsBlobServicesContainer";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsblobservicescontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20220901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsBlobServicesContainer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20220901StorageAccountsBlobServicesContainerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20220901StorageAccountsBlobServicesContainerStatus? Status { get; set; }
}