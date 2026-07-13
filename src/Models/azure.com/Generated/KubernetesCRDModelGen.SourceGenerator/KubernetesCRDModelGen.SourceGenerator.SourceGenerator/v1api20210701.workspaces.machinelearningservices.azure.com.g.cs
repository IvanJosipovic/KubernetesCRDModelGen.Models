#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2021-07-01/machineLearningServices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210701WorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1api20210701Workspace>
{
    public const string KubeApiVersion = "v1api20210701";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20210701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210701Workspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210701Workspace> Items { get; set; }
}

/// <summary>
/// ApplicationInsightsReference: ARM id of the application insights associated with this workspace. This cannot be changed
/// once the workspace has been created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecApplicationInsightsReference
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
/// ContainerRegistryReference: ARM id of the container registry associated with this workspace. This cannot be changed once
/// the workspace has been created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecContainerRegistryReference
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
/// UserAssignedIdentityReference: The ArmId of the user assigned identity that will be used to access the customer managed
/// key vault
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecEncryptionIdentityUserAssignedIdentityReference
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

/// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecEncryptionIdentity
{
    /// <summary>UserAssignedIdentity: The ArmId of the user assigned identity that will be used to access the customer managed key vault</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }

    /// <summary>
    /// UserAssignedIdentityReference: The ArmId of the user assigned identity that will be used to access the customer managed
    /// key vault
    /// </summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20210701WorkspaceSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>KeyVaultArmReference: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecEncryptionKeyVaultPropertiesKeyVaultArmReference
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

/// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecEncryptionKeyVaultProperties
{
    /// <summary>IdentityClientId: For future use - The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>KeyIdentifier: Key vault uri to access the encryption key.</summary>
    [JsonPropertyName("keyIdentifier")]
    public required string KeyIdentifier { get; set; }

    /// <summary>KeyVaultArmId: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
    [JsonPropertyName("keyVaultArmId")]
    public required string KeyVaultArmId { get; set; }

    /// <summary>KeyVaultArmReference: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
    [JsonPropertyName("keyVaultArmReference")]
    public required V1api20210701WorkspaceSpecEncryptionKeyVaultPropertiesKeyVaultArmReference KeyVaultArmReference { get; set; }
}

/// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecEncryption
{
    /// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701WorkspaceSpecEncryptionIdentity? Identity { get; set; }

    /// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public required V1api20210701WorkspaceSpecEncryptionKeyVaultProperties KeyVaultProperties { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspaceSpecIdentityTypeEnum>))]
public enum V1api20210701WorkspaceSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20210701WorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210701WorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public V1api20210701WorkspaceSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The user assigned identities associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210701WorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has
/// been created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecKeyVaultReference
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretExpressions
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
/// AppInsightsInstrumentationKey: indicates where the AppInsightsInstrumentationKey secret should be placed. If omitted,
/// the secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ContainerRegistryPassword: indicates where the ContainerRegistryPassword secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ContainerRegistryPassword2: indicates where the ContainerRegistryPassword2 secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ContainerRegistryUserName: indicates where the ContainerRegistryUserName secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsContainerRegistryUserName
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PrimaryNotebookAccessKey: indicates where the PrimaryNotebookAccessKey secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecondaryNotebookAccessKey: indicates where the SecondaryNotebookAccessKey secret should be placed. If omitted, the
/// secret will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// UserStorageKey: indicates where the UserStorageKey secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecretsUserStorageKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpecSecrets
{
    /// <summary>
    /// AppInsightsInstrumentationKey: indicates where the AppInsightsInstrumentationKey secret should be placed. If omitted,
    /// the secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("appInsightsInstrumentationKey")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey? AppInsightsInstrumentationKey { get; set; }

    /// <summary>
    /// ContainerRegistryPassword: indicates where the ContainerRegistryPassword secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("containerRegistryPassword")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword? ContainerRegistryPassword { get; set; }

    /// <summary>
    /// ContainerRegistryPassword2: indicates where the ContainerRegistryPassword2 secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("containerRegistryPassword2")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2? ContainerRegistryPassword2 { get; set; }

    /// <summary>
    /// ContainerRegistryUserName: indicates where the ContainerRegistryUserName secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("containerRegistryUserName")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsContainerRegistryUserName? ContainerRegistryUserName { get; set; }

    /// <summary>
    /// PrimaryNotebookAccessKey: indicates where the PrimaryNotebookAccessKey secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryNotebookAccessKey")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey? PrimaryNotebookAccessKey { get; set; }

    /// <summary>
    /// SecondaryNotebookAccessKey: indicates where the SecondaryNotebookAccessKey secret should be placed. If omitted, the
    /// secret will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryNotebookAccessKey")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey? SecondaryNotebookAccessKey { get; set; }

    /// <summary>
    /// UserStorageKey: indicates where the UserStorageKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("userStorageKey")]
    public V1api20210701WorkspaceSpecOperatorSpecSecretsUserStorageKey? UserStorageKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210701WorkspaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210701WorkspaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20210701WorkspaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecPrimaryUserAssignedIdentityReference
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

/// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspaceSpecPublicNetworkAccessEnum>))]
public enum V1api20210701WorkspaceSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>CollectionsThroughput: The throughput of the collections in cosmosdb database</summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecServiceManagedResourcesSettings
{
    /// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20210701WorkspaceSpecServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

/// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference
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

/// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspaceSpecSharedPrivateLinkResourcesStatusEnum>))]
public enum V1api20210701WorkspaceSpecSharedPrivateLinkResourcesStatusEnum
{
    [EnumMember(Value = "Approved"), JsonStringEnumMemberName("Approved")]
    Approved,
    [EnumMember(Value = "Disconnected"), JsonStringEnumMemberName("Disconnected")]
    Disconnected,
    [EnumMember(Value = "Pending"), JsonStringEnumMemberName("Pending")]
    Pending,
    [EnumMember(Value = "Rejected"), JsonStringEnumMemberName("Rejected")]
    Rejected,
    [EnumMember(Value = "Timeout"), JsonStringEnumMemberName("Timeout")]
    Timeout
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecSharedPrivateLinkResources
{
    /// <summary>GroupId: The private link resource group id.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: Unique name of the private link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
    [JsonPropertyName("privateLinkResourceReference")]
    public V1api20210701WorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference? PrivateLinkResourceReference { get; set; }

    /// <summary>RequestMessage: Request message.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public V1api20210701WorkspaceSpecSharedPrivateLinkResourcesStatusEnum? Status { get; set; }
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecSku
{
    /// <summary>Name: Name of the sku</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of the sku like Basic or Enterprise</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the
/// workspace has been created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecStorageAccountReference
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

/// <summary>CreatedByType: The type of identity that created the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspaceSpecSystemDataCreatedByTypeEnum>))]
public enum V1api20210701WorkspaceSpecSystemDataCreatedByTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspaceSpecSystemDataLastModifiedByTypeEnum>))]
public enum V1api20210701WorkspaceSpecSystemDataLastModifiedByTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>SystemData: System data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpecSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public V1api20210701WorkspaceSpecSystemDataCreatedByTypeEnum? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public V1api20210701WorkspaceSpecSystemDataLastModifiedByTypeEnum? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceSpec
{
    /// <summary>AllowPublicAccessWhenBehindVnet: The flag to indicate whether to allow public access when behind VNet.</summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary>
    /// ApplicationInsightsReference: ARM id of the application insights associated with this workspace. This cannot be changed
    /// once the workspace has been created
    /// </summary>
    [JsonPropertyName("applicationInsightsReference")]
    public V1api20210701WorkspaceSpecApplicationInsightsReference? ApplicationInsightsReference { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ContainerRegistryReference: ARM id of the container registry associated with this workspace. This cannot be changed once
    /// the workspace has been created
    /// </summary>
    [JsonPropertyName("containerRegistryReference")]
    public V1api20210701WorkspaceSpecContainerRegistryReference? ContainerRegistryReference { get; set; }

    /// <summary>Description: The description of this workspace.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DiscoveryUrl: Url for the discovery service to identify regional endpoints for machine learning experimentation services</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210701WorkspaceSpecEncryption? Encryption { get; set; }

    /// <summary>FriendlyName: The friendly name for this workspace. This name in mutable</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>HbiWorkspace: The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service</summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701WorkspaceSpecIdentity? Identity { get; set; }

    /// <summary>ImageBuildCompute: The compute name for image build</summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary>
    /// KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has
    /// been created
    /// </summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20210701WorkspaceSpecKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210701WorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210701WorkspaceSpecOwner Owner { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20210701WorkspaceSpecPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20210701WorkspaceSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20210701WorkspaceSpecServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary>SharedPrivateLinkResources: The list of shared private link resources in this workspace.</summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20210701WorkspaceSpecSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20210701WorkspaceSpecSku? Sku { get; set; }

    /// <summary>
    /// StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the
    /// workspace has been created
    /// </summary>
    [JsonPropertyName("storageAccountReference")]
    public V1api20210701WorkspaceSpecStorageAccountReference? StorageAccountReference { get; set; }

    /// <summary>SystemData: System data</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701WorkspaceSpecSystemData? SystemData { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusConditions
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

/// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusEncryptionIdentity
{
    /// <summary>UserAssignedIdentity: The ArmId of the user assigned identity that will be used to access the customer managed key vault</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusEncryptionKeyVaultProperties
{
    /// <summary>IdentityClientId: For future use - The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>KeyIdentifier: Key vault uri to access the encryption key.</summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary>KeyVaultArmId: The ArmId of the keyVault where the customer owned encryption key is present.</summary>
    [JsonPropertyName("keyVaultArmId")]
    public string? KeyVaultArmId { get; set; }
}

/// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusEncryption
{
    /// <summary>Identity: The identity that will be used to access the key vault for encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701WorkspaceStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>KeyVaultProperties: Customer Key vault properties.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210701WorkspaceStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary>Status: Indicates whether or not the encryption is enabled for the workspace.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>User Assigned Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The clientId(aka appId) of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of the user assigned identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The user assigned identities associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210701WorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>NotebookPreparationError: The error that occurs when preparing notebook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusNotebookInfoNotebookPreparationError
{
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>NotebookInfo: The notebook info of Azure ML workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusNotebookInfo
{
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>NotebookPreparationError: The error that occurs when preparing notebook.</summary>
    [JsonPropertyName("notebookPreparationError")]
    public V1api20210701WorkspaceStatusNotebookInfoNotebookPreparationError? NotebookPreparationError { get; set; }

    /// <summary>ResourceId: the data plane resourceId that used to initialize notebook component</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>The Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>CollectionsThroughput: The throughput of the collections in cosmosdb database</summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusServiceManagedResourcesSettings
{
    /// <summary>CosmosDb: The settings for the service managed cosmosdb account.</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20210701WorkspaceStatusServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusSharedPrivateLinkResources
{
    /// <summary>GroupId: The private link resource group id.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: Unique name of the private link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkResourceId: The resource id that private link links to.</summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary>RequestMessage: Request message.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusSku
{
    /// <summary>Name: Name of the sku</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of the sku like Basic or Enterprise</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: System data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatusSystemData
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

/// <summary>An object that represents a machine learning workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspaceStatus
{
    /// <summary>AllowPublicAccessWhenBehindVnet: The flag to indicate whether to allow public access when behind VNet.</summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary>
    /// ApplicationInsights: ARM id of the application insights associated with this workspace. This cannot be changed once the
    /// workspace has been created
    /// </summary>
    [JsonPropertyName("applicationInsights")]
    public string? ApplicationInsights { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210701WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ContainerRegistry: ARM id of the container registry associated with this workspace. This cannot be changed once the
    /// workspace has been created
    /// </summary>
    [JsonPropertyName("containerRegistry")]
    public string? ContainerRegistry { get; set; }

    /// <summary>Description: The description of this workspace.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DiscoveryUrl: Url for the discovery service to identify regional endpoints for machine learning experimentation services</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Encryption: The encryption settings of Azure ML workspace.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210701WorkspaceStatusEncryption? Encryption { get; set; }

    /// <summary>FriendlyName: The friendly name for this workspace. This name in mutable</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>HbiWorkspace: The flag to signal HBI data in the workspace and reduce diagnostic data collected by the service</summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701WorkspaceStatusIdentity? Identity { get; set; }

    /// <summary>ImageBuildCompute: The compute name for image build</summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary>
    /// KeyVault: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been
    /// created
    /// </summary>
    [JsonPropertyName("keyVault")]
    public string? KeyVault { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MlFlowTrackingUri: The URI associated with this workspace that machine learning flow must point at to set up tracking.</summary>
    [JsonPropertyName("mlFlowTrackingUri")]
    public string? MlFlowTrackingUri { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NotebookInfo: The notebook info of Azure ML workspace.</summary>
    [JsonPropertyName("notebookInfo")]
    public V1api20210701WorkspaceStatusNotebookInfo? NotebookInfo { get; set; }

    /// <summary>PrimaryUserAssignedIdentity: The user assigned identity resource id that represents the workspace identity.</summary>
    [JsonPropertyName("primaryUserAssignedIdentity")]
    public string? PrimaryUserAssignedIdentity { get; set; }

    /// <summary>PrivateEndpointConnections: The list of private endpoint connections in the workspace.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210701WorkspaceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>PrivateLinkCount: Count of private connections in the workspace</summary>
    [JsonPropertyName("privateLinkCount")]
    public int? PrivateLinkCount { get; set; }

    /// <summary>
    /// ProvisioningState: The current deployment state of workspace resource. The provisioningState is to indicate states for
    /// resource provisioning.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether requests from Public Network are allowed.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>ServiceManagedResourcesSettings: The service managed resource settings.</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20210701WorkspaceStatusServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary>
    /// ServiceProvisionedResourceGroup: The name of the managed resource group created by workspace RP in customer subscription
    /// if the workspace is CMK workspace
    /// </summary>
    [JsonPropertyName("serviceProvisionedResourceGroup")]
    public string? ServiceProvisionedResourceGroup { get; set; }

    /// <summary>SharedPrivateLinkResources: The list of shared private link resources in this workspace.</summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20210701WorkspaceStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20210701WorkspaceStatusSku? Sku { get; set; }

    /// <summary>
    /// StorageAccount: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace
    /// has been created
    /// </summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }

    /// <summary>StorageHnsEnabled: If the storage associated with the workspace has hierarchical namespace(HNS) enabled.</summary>
    [JsonPropertyName("storageHnsEnabled")]
    public bool? StorageHnsEnabled { get; set; }

    /// <summary>SystemData: System data</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701WorkspaceStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TenantId: The tenant id associated with this workspace.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkspaceId: The immutable id associated with this workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2021-07-01/machineLearningServices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210701Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210701WorkspaceSpec?>, IStatus<V1api20210701WorkspaceStatus?>
{
    public const string KubeApiVersion = "v1api20210701";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20210701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210701WorkspaceSpec? Spec { get; set; }

    /// <summary>An object that represents a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20210701WorkspaceStatus? Status { get; set; }
}