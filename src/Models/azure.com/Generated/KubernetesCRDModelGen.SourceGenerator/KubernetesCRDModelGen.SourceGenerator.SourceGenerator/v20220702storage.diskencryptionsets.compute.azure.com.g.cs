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
/// Storage version of v20220702.DiskEncryptionSet
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/diskEncryptionSet.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220702storageDiskEncryptionSetList : IKubernetesObject<V1ListMeta>, IItems<V20220702storageDiskEncryptionSet>
{
    public const string KubeApiVersion = "v20220702storage";
    public const string KubeKind = "DiskEncryptionSetList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "diskencryptionsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220702storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiskEncryptionSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220702storageDiskEncryptionSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220702storageDiskEncryptionSet> Items { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecActiveKeyKeyUrlFromConfig
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
public partial class V20220702storageDiskEncryptionSetSpecActiveKeySourceVaultReference
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
/// Storage version of v20220702.SourceVault
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecActiveKeySourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220702storageDiskEncryptionSetSpecActiveKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20220702.KeyForDiskEncryptionSet
/// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecActiveKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("keyUrlFromConfig")]
    public V20220702storageDiskEncryptionSetSpecActiveKeyKeyUrlFromConfig? KeyUrlFromConfig { get; set; }

    /// <summary>
    /// Storage version of v20220702.SourceVault
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V20220702storageDiskEncryptionSetSpecActiveKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecFederatedClientIdFromConfig
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20220702.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20220702storageDiskEncryptionSetSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20220702.EncryptionSetIdentity
/// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used
/// to encrypt disks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20220702storageDiskEncryptionSetSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecOperatorSpecConfigMapExpressions
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
public partial class V20220702storageDiskEncryptionSetSpecOperatorSpecSecretExpressions
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
/// Storage version of v20220702.DiskEncryptionSetOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20220702storageDiskEncryptionSetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20220702storageDiskEncryptionSetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20220702.DiskEncryptionSet_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220702.KeyForDiskEncryptionSet
    /// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
    /// </summary>
    [JsonPropertyName("activeKey")]
    public V20220702storageDiskEncryptionSetSpecActiveKey? ActiveKey { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("federatedClientIdFromConfig")]
    public V20220702storageDiskEncryptionSetSpecFederatedClientIdFromConfig? FederatedClientIdFromConfig { get; set; }

    /// <summary>
    /// Storage version of v20220702.EncryptionSetIdentity
    /// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used
    /// to encrypt disks.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20220702storageDiskEncryptionSetSpecIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20220702.DiskEncryptionSetOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220702storageDiskEncryptionSetSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220702storageDiskEncryptionSetSpecOwner Owner { get; set; }

    [JsonPropertyName("rotationToLatestKeyVersionEnabled")]
    public bool? RotationToLatestKeyVersionEnabled { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v20220702.SourceVault_STATUS
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusActiveKeySourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20220702.KeyForDiskEncryptionSet_STATUS
/// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusActiveKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// Storage version of v20220702.SourceVault_STATUS
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V20220702storageDiskEncryptionSetStatusActiveKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v20220702.ApiErrorBase_STATUS
/// Api error base.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusAutoKeyRotationErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v20220702.InnerError_STATUS
/// Inner error details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusAutoKeyRotationErrorInnererror
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}

/// <summary>
/// Storage version of v20220702.ApiError_STATUS
/// Api error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusAutoKeyRotationError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V20220702storageDiskEncryptionSetStatusAutoKeyRotationErrorDetails>? Details { get; set; }

    /// <summary>
    /// Storage version of v20220702.InnerError_STATUS
    /// Inner error details.
    /// </summary>
    [JsonPropertyName("innererror")]
    public V20220702storageDiskEncryptionSetStatusAutoKeyRotationErrorInnererror? Innererror { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusConditions
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

/// <summary>Storage version of v20220702.UserAssignedIdentitiesValue_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v20220702.EncryptionSetIdentity_STATUS
/// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used
/// to encrypt disks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20220702storageDiskEncryptionSetStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20220702.SourceVault_STATUS
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusPreviousKeysSourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20220702.KeyForDiskEncryptionSet_STATUS
/// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatusPreviousKeys
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// Storage version of v20220702.SourceVault_STATUS
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V20220702storageDiskEncryptionSetStatusPreviousKeysSourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v20220702.DiskEncryptionSet_STATUS
/// disk encryption set resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220702storageDiskEncryptionSetStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20220702.KeyForDiskEncryptionSet_STATUS
    /// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
    /// </summary>
    [JsonPropertyName("activeKey")]
    public V20220702storageDiskEncryptionSetStatusActiveKey? ActiveKey { get; set; }

    /// <summary>
    /// Storage version of v20220702.ApiError_STATUS
    /// Api error.
    /// </summary>
    [JsonPropertyName("autoKeyRotationError")]
    public V20220702storageDiskEncryptionSetStatusAutoKeyRotationError? AutoKeyRotationError { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20220702storageDiskEncryptionSetStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("federatedClientId")]
    public string? FederatedClientId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20220702.EncryptionSetIdentity_STATUS
    /// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used
    /// to encrypt disks.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20220702storageDiskEncryptionSetStatusIdentity? Identity { get; set; }

    [JsonPropertyName("lastKeyRotationTimestamp")]
    public string? LastKeyRotationTimestamp { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("previousKeys")]
    public IList<V20220702storageDiskEncryptionSetStatusPreviousKeys>? PreviousKeys { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("rotationToLatestKeyVersionEnabled")]
    public bool? RotationToLatestKeyVersionEnabled { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20220702.DiskEncryptionSet
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/diskEncryptionSet.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{diskEncryptionSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220702storageDiskEncryptionSet : IKubernetesObject<V1ObjectMeta>, ISpec<V20220702storageDiskEncryptionSetSpec?>, IStatus<V20220702storageDiskEncryptionSetStatus?>
{
    public const string KubeApiVersion = "v20220702storage";
    public const string KubeKind = "DiskEncryptionSet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "diskencryptionsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220702storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiskEncryptionSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20220702.DiskEncryptionSet_Spec</summary>
    [JsonPropertyName("spec")]
    public V20220702storageDiskEncryptionSetSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20220702.DiskEncryptionSet_STATUS
    /// disk encryption set resource.
    /// </summary>
    [JsonPropertyName("status")]
    public V20220702storageDiskEncryptionSetStatus? Status { get; set; }
}