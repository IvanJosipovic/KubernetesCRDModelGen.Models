#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/diskEncryptionSet.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220702DiskEncryptionSetList : IKubernetesObject<V1ListMeta>, IItems<V20220702DiskEncryptionSet>
{
    public const string KubeApiVersion = "v20220702";
    public const string KubeKind = "DiskEncryptionSetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "diskencryptionsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220702";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiskEncryptionSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220702DiskEncryptionSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220702DiskEncryptionSet> Items { get; set; }
}

/// <summary>
/// KeyUrlFromConfig: Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required
/// regardless of rotationToLatestKeyVersionEnabled value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecActiveKeyKeyUrlFromConfig
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

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecActiveKeySourceVaultReference
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
/// SourceVault: Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if
/// the KeyVault subscription is not the same as the Disk Encryption Set subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecActiveKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220702DiskEncryptionSetSpecActiveKeySourceVaultReference? Reference { get; set; }
}

/// <summary>ActiveKey: The key vault key which is currently used by this disk encryption set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecActiveKey
{
    /// <summary>
    /// KeyUrl: Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of
    /// rotationToLatestKeyVersionEnabled value.
    /// </summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// KeyUrlFromConfig: Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required
    /// regardless of rotationToLatestKeyVersionEnabled value.
    /// </summary>
    [JsonPropertyName("keyUrlFromConfig")]
    public V20220702DiskEncryptionSetSpecActiveKeyKeyUrlFromConfig? KeyUrlFromConfig { get; set; }

    /// <summary>
    /// SourceVault: Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if
    /// the KeyVault subscription is not the same as the Disk Encryption Set subscription.
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V20220702DiskEncryptionSetSpecActiveKeySourceVault? SourceVault { get; set; }
}

/// <summary>EncryptionType: The type of key used to encrypt the data of the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220702DiskEncryptionSetSpecEncryptionTypeEnum>))]
public enum V20220702DiskEncryptionSetSpecEncryptionTypeEnum
{
    [EnumMember(Value = "ConfidentialVmEncryptedWithCustomerKey"), JsonStringEnumMemberName("ConfidentialVmEncryptedWithCustomerKey")]
    ConfidentialVmEncryptedWithCustomerKey,
    [EnumMember(Value = "EncryptionAtRestWithCustomerKey"), JsonStringEnumMemberName("EncryptionAtRestWithCustomerKey")]
    EncryptionAtRestWithCustomerKey,
    [EnumMember(Value = "EncryptionAtRestWithPlatformAndCustomerKeys"), JsonStringEnumMemberName("EncryptionAtRestWithPlatformAndCustomerKeys")]
    EncryptionAtRestWithPlatformAndCustomerKeys
}

/// <summary>
/// FederatedClientIdFromConfig: Multi-tenant application client id to access key vault in a different tenant. Setting the
/// value to &apos;None&apos; will clear the property.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecFederatedClientIdFromConfig
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

/// <summary>
/// Type: The type of Managed Identity used by the DiskEncryptionSet. Only SystemAssigned is supported for new creations.
/// Disk Encryption Sets can be updated with Identity type None during migration of subscription to a new Azure Active
/// Directory tenant; it will cause the encrypted resources to lose access to the keys.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220702DiskEncryptionSetSpecIdentityTypeEnum>))]
public enum V20220702DiskEncryptionSetSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecIdentityUserAssignedIdentitiesReference
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
public partial class V20220702DiskEncryptionSetSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20220702DiskEncryptionSetSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Identity: The managed identity for the disk encryption set. It should be given permission on the key vault before it can
/// be used  to encrypt disks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecIdentity
{
    /// <summary>
    /// Type: The type of Managed Identity used by the DiskEncryptionSet. Only SystemAssigned is supported for new creations.
    /// Disk Encryption Sets can be updated with Identity type None during migration of subscription to a new Azure Active
    /// Directory tenant; it will cause the encrypted resources to lose access to the keys.
    /// </summary>
    [JsonPropertyName("type")]
    public V20220702DiskEncryptionSetSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the disk encryption set. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20220702DiskEncryptionSetSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecOperatorSpecConfigMapExpressions
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
public partial class V20220702DiskEncryptionSetSpecOperatorSpecSecretExpressions
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
public partial class V20220702DiskEncryptionSetSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20220702DiskEncryptionSetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20220702DiskEncryptionSetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetSpec
{
    /// <summary>ActiveKey: The key vault key which is currently used by this disk encryption set.</summary>
    [JsonPropertyName("activeKey")]
    public V20220702DiskEncryptionSetSpecActiveKey? ActiveKey { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>EncryptionType: The type of key used to encrypt the data of the disk.</summary>
    [JsonPropertyName("encryptionType")]
    public V20220702DiskEncryptionSetSpecEncryptionTypeEnum? EncryptionType { get; set; }

    /// <summary>
    /// FederatedClientId: Multi-tenant application client id to access key vault in a different tenant. Setting the value to
    /// &apos;None&apos; will clear the property.
    /// </summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>
    /// FederatedClientIdFromConfig: Multi-tenant application client id to access key vault in a different tenant. Setting the
    /// value to &apos;None&apos; will clear the property.
    /// </summary>
    [JsonPropertyName("federatedClientIdFromConfig")]
    public V20220702DiskEncryptionSetSpecFederatedClientIdFromConfig? FederatedClientIdFromConfig { get; set; }

    /// <summary>
    /// Identity: The managed identity for the disk encryption set. It should be given permission on the key vault before it can
    /// be used  to encrypt disks.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20220702DiskEncryptionSetSpecIdentity? Identity { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220702DiskEncryptionSetSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220702DiskEncryptionSetSpecOwner Owner { get; set; }

    /// <summary>
    /// RotationToLatestKeyVersionEnabled: Set this flag to true to enable auto-updating of this disk encryption set to the
    /// latest key version.
    /// </summary>
    [JsonPropertyName("rotationToLatestKeyVersionEnabled")]
    public bool? RotationToLatestKeyVersionEnabled { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// SourceVault: Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if
/// the KeyVault subscription is not the same as the Disk Encryption Set subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusActiveKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ActiveKey: The key vault key which is currently used by this disk encryption set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusActiveKey
{
    /// <summary>
    /// KeyUrl: Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of
    /// rotationToLatestKeyVersionEnabled value.
    /// </summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// SourceVault: Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if
    /// the KeyVault subscription is not the same as the Disk Encryption Set subscription.
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V20220702DiskEncryptionSetStatusActiveKeySourceVault? SourceVault { get; set; }
}

/// <summary>Api error base.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusAutoKeyRotationErrorDetails
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Innererror: The Api inner error</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusAutoKeyRotationErrorInnererror
{
    /// <summary>Errordetail: The internal error message or exception dump.</summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary>Exceptiontype: The exception type.</summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>
/// AutoKeyRotationError: The error that was encountered during auto-key rotation. If an error is present, then auto-key
/// rotation will not be attempted until the error on this disk encryption set is fixed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusAutoKeyRotationError
{
    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The Api error details</summary>
    [JsonPropertyName("details")]
    public IList<V20220702DiskEncryptionSetStatusAutoKeyRotationErrorDetails>? Details { get; set; }

    /// <summary>Innererror: The Api inner error</summary>
    [JsonPropertyName("innererror")]
    public V20220702DiskEncryptionSetStatusAutoKeyRotationErrorInnererror? Innererror { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Identity: The managed identity for the disk encryption set. It should be given permission on the key vault before it can
/// be used  to encrypt disks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusIdentity
{
    /// <summary>
    /// PrincipalId: The object id of the Managed Identity Resource. This will be sent to the RP from ARM via the
    /// x-ms-identity-principal-id header in the PUT request if the resource has a systemAssigned(implicit) identity
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the Managed Identity Resource. This will be sent to the RP from ARM via the
    /// x-ms-client-tenant-id header in the PUT request if the resource has a systemAssigned(implicit) identity
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of Managed Identity used by the DiskEncryptionSet. Only SystemAssigned is supported for new creations.
    /// Disk Encryption Sets can be updated with Identity type None during migration of subscription to a new Azure Active
    /// Directory tenant; it will cause the encrypted resources to lose access to the keys.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the disk encryption set. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20220702DiskEncryptionSetStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// SourceVault: Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if
/// the KeyVault subscription is not the same as the Disk Encryption Set subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusPreviousKeysSourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatusPreviousKeys
{
    /// <summary>
    /// KeyUrl: Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of
    /// rotationToLatestKeyVersionEnabled value.
    /// </summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// SourceVault: Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if
    /// the KeyVault subscription is not the same as the Disk Encryption Set subscription.
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V20220702DiskEncryptionSetStatusPreviousKeysSourceVault? SourceVault { get; set; }
}

/// <summary>disk encryption set resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702DiskEncryptionSetStatus
{
    /// <summary>ActiveKey: The key vault key which is currently used by this disk encryption set.</summary>
    [JsonPropertyName("activeKey")]
    public V20220702DiskEncryptionSetStatusActiveKey? ActiveKey { get; set; }

    /// <summary>
    /// AutoKeyRotationError: The error that was encountered during auto-key rotation. If an error is present, then auto-key
    /// rotation will not be attempted until the error on this disk encryption set is fixed.
    /// </summary>
    [JsonPropertyName("autoKeyRotationError")]
    public V20220702DiskEncryptionSetStatusAutoKeyRotationError? AutoKeyRotationError { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20220702DiskEncryptionSetStatusConditions>? Conditions { get; set; }

    /// <summary>EncryptionType: The type of key used to encrypt the data of the disk.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>
    /// FederatedClientId: Multi-tenant application client id to access key vault in a different tenant. Setting the value to
    /// &apos;None&apos; will clear the property.
    /// </summary>
    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Identity: The managed identity for the disk encryption set. It should be given permission on the key vault before it can
    /// be used  to encrypt disks.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20220702DiskEncryptionSetStatusIdentity? Identity { get; set; }

    /// <summary>LastKeyRotationTimestamp: The time when the active key of this disk encryption set was updated.</summary>
    [JsonPropertyName("lastKeyRotationTimestamp")]
    public string? LastKeyRotationTimestamp { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PreviousKeys: A readonly collection of key vault keys previously used by this disk encryption set while a key rotation
    /// is in progress. It will be empty if there is no ongoing key rotation.
    /// </summary>
    [JsonPropertyName("previousKeys")]
    public IList<V20220702DiskEncryptionSetStatusPreviousKeys>? PreviousKeys { get; set; }

    /// <summary>ProvisioningState: The disk encryption set provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RotationToLatestKeyVersionEnabled: Set this flag to true to enable auto-updating of this disk encryption set to the
    /// latest key version.
    /// </summary>
    [JsonPropertyName("rotationToLatestKeyVersionEnabled")]
    public bool? RotationToLatestKeyVersionEnabled { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/diskEncryptionSet.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220702DiskEncryptionSet : IKubernetesObject<V1ObjectMeta>, ISpec<V20220702DiskEncryptionSetSpec?>, IStatus<V20220702DiskEncryptionSetStatus?>
{
    public const string KubeApiVersion = "v20220702";
    public const string KubeKind = "DiskEncryptionSet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "diskencryptionsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220702";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiskEncryptionSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20220702DiskEncryptionSetSpec? Spec { get; set; }

    /// <summary>disk encryption set resource.</summary>
    [JsonPropertyName("status")]
    public V20220702DiskEncryptionSetStatus? Status { get; set; }
}