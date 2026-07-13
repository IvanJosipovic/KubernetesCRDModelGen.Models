#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /datafactory/resource-manager/Microsoft.DataFactory/DataFactory/stable/2018-06-01/datafactory.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180601FactoryList : IKubernetesObject<V1ListMeta>, IItems<V1api20180601Factory>
{
    public const string KubeApiVersion = "v1api20180601";
    public const string KubeKind = "FactoryList";
    public const string KubeGroup = "datafactory.azure.com";
    public const string KubePluralName = "factories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.com/v1api20180601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FactoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20180601Factory objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20180601Factory> Items { get; set; }
}

/// <summary>UserAssignedIdentityReference: The resource id of the user assigned identity to authenticate to customer&apos;s key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecEncryptionIdentityUserAssignedIdentityReference
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
/// Identity: User assigned identity to use to authenticate to customer&apos;s key vault. If not provided Managed Service
/// Identity will be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecEncryptionIdentity
{
    /// <summary>UserAssignedIdentityReference: The resource id of the user assigned identity to authenticate to customer&apos;s key vault.</summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20180601FactorySpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>Encryption: Properties to enable Customer Managed Key for the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecEncryption
{
    /// <summary>
    /// Identity: User assigned identity to use to authenticate to customer&apos;s key vault. If not provided Managed Service
    /// Identity will be used.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20180601FactorySpecEncryptionIdentity? Identity { get; set; }

    /// <summary>KeyName: The name of the key in Azure Key Vault to use as Customer Managed Key.</summary>
    [JsonPropertyName("keyName")]
    public required string KeyName { get; set; }

    /// <summary>KeyVersion: The version of the key used for CMK. If not provided, latest version will be used.</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary>VaultBaseUrl: The url of the Azure Key Vault used for CMK.</summary>
    [JsonPropertyName("vaultBaseUrl")]
    public required string VaultBaseUrl { get; set; }
}

/// <summary>Type: Global Parameter type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601FactorySpecGlobalParametersTypeEnum>))]
public enum V1api20180601FactorySpecGlobalParametersTypeEnum
{
    [EnumMember(Value = "Array"), JsonStringEnumMemberName("Array")]
    Array,
    [EnumMember(Value = "Bool"), JsonStringEnumMemberName("Bool")]
    Bool,
    [EnumMember(Value = "Float"), JsonStringEnumMemberName("Float")]
    Float,
    [EnumMember(Value = "Int"), JsonStringEnumMemberName("Int")]
    Int,
    [EnumMember(Value = "Object"), JsonStringEnumMemberName("Object")]
    Object,
    [EnumMember(Value = "String"), JsonStringEnumMemberName("String")]
    String
}

/// <summary>Definition of a single parameter for an entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecGlobalParameters
{
    /// <summary>Type: Global Parameter type.</summary>
    [JsonPropertyName("type")]
    public required V1api20180601FactorySpecGlobalParametersTypeEnum Type { get; set; }

    /// <summary>Value: Value of parameter.</summary>
    [JsonPropertyName("value")]
    public required IDictionary<string, JsonNode> Value { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601FactorySpecIdentityTypeEnum>))]
public enum V1api20180601FactorySpecIdentityTypeEnum
{
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
public partial class V1api20180601FactorySpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20180601FactorySpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20180601FactorySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Managed service identity of the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public required V1api20180601FactorySpecIdentityTypeEnum Type { get; set; }

    /// <summary>UserAssignedIdentities: List of user assigned identities for the factory.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20180601FactorySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20180601FactorySpecOperatorSpecSecretExpressions
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
public partial class V1api20180601FactorySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20180601FactorySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20180601FactorySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccess: Whether or not public network access is allowed for the data factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601FactorySpecPublicNetworkAccessEnum>))]
public enum V1api20180601FactorySpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PurviewResourceReference: Purview resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecPurviewConfigurationPurviewResourceReference
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

/// <summary>PurviewConfiguration: Purview information of the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecPurviewConfiguration
{
    /// <summary>PurviewResourceReference: Purview resource id.</summary>
    [JsonPropertyName("purviewResourceReference")]
    public V1api20180601FactorySpecPurviewConfigurationPurviewResourceReference? PurviewResourceReference { get; set; }
}

/// <summary>ClientSecret: GitHub bring your own app client secret information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfigurationClientSecret
{
    /// <summary>ByoaSecretAkvUrl: Bring your own app client secret AKV URL.</summary>
    [JsonPropertyName("byoaSecretAkvUrl")]
    public string? ByoaSecretAkvUrl { get; set; }

    /// <summary>ByoaSecretName: Bring your own app client secret name in AKV.</summary>
    [JsonPropertyName("byoaSecretName")]
    public string? ByoaSecretName { get; set; }
}

/// <summary>Type: Type of repo configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfigurationTypeEnum>))]
public enum V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfigurationTypeEnum
{
    [EnumMember(Value = "FactoryGitHubConfiguration"), JsonStringEnumMemberName("FactoryGitHubConfiguration")]
    FactoryGitHubConfiguration
}

/// <summary>FactoryGitHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfiguration
{
    /// <summary>AccountName: Account name.</summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; set; }

    /// <summary>ClientId: GitHub bring your own app client id.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecret: GitHub bring your own app client secret information.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfigurationClientSecret? ClientSecret { get; set; }

    /// <summary>CollaborationBranch: Collaboration branch.</summary>
    [JsonPropertyName("collaborationBranch")]
    public required string CollaborationBranch { get; set; }

    /// <summary>DisablePublish: Disable manual publish operation in ADF studio to favor automated publish.</summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary>HostName: GitHub Enterprise host name. For example: `https://github.mydomain.com`</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>LastCommitId: Last commit id.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>RepositoryName: Repository name.</summary>
    [JsonPropertyName("repositoryName")]
    public required string RepositoryName { get; set; }

    /// <summary>RootFolder: Root folder.</summary>
    [JsonPropertyName("rootFolder")]
    public required string RootFolder { get; set; }

    /// <summary>Type: Type of repo configuration.</summary>
    [JsonPropertyName("type")]
    public required V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfigurationTypeEnum Type { get; set; }
}

/// <summary>Type: Type of repo configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180601FactorySpecRepoConfigurationFactoryVSTSConfigurationTypeEnum>))]
public enum V1api20180601FactorySpecRepoConfigurationFactoryVSTSConfigurationTypeEnum
{
    [EnumMember(Value = "FactoryVSTSConfiguration"), JsonStringEnumMemberName("FactoryVSTSConfiguration")]
    FactoryVSTSConfiguration
}

/// <summary>FactoryVSTS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecRepoConfigurationFactoryVSTSConfiguration
{
    /// <summary>AccountName: Account name.</summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; set; }

    /// <summary>CollaborationBranch: Collaboration branch.</summary>
    [JsonPropertyName("collaborationBranch")]
    public required string CollaborationBranch { get; set; }

    /// <summary>DisablePublish: Disable manual publish operation in ADF studio to favor automated publish.</summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary>LastCommitId: Last commit id.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>ProjectName: VSTS project name.</summary>
    [JsonPropertyName("projectName")]
    public required string ProjectName { get; set; }

    /// <summary>RepositoryName: Repository name.</summary>
    [JsonPropertyName("repositoryName")]
    public required string RepositoryName { get; set; }

    /// <summary>RootFolder: Root folder.</summary>
    [JsonPropertyName("rootFolder")]
    public required string RootFolder { get; set; }

    /// <summary>TenantId: VSTS tenant id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of repo configuration.</summary>
    [JsonPropertyName("type")]
    public required V1api20180601FactorySpecRepoConfigurationFactoryVSTSConfigurationTypeEnum Type { get; set; }
}

/// <summary>RepoConfiguration: Git repo information of the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpecRepoConfiguration
{
    /// <summary>FactoryGitHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("factoryGitHubConfiguration")]
    public V1api20180601FactorySpecRepoConfigurationFactoryGitHubConfiguration? FactoryGitHubConfiguration { get; set; }

    /// <summary>FactoryVSTS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("factoryVSTSConfiguration")]
    public V1api20180601FactorySpecRepoConfigurationFactoryVSTSConfiguration? FactoryVSTSConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactorySpec
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Encryption: Properties to enable Customer Managed Key for the factory.</summary>
    [JsonPropertyName("encryption")]
    public V1api20180601FactorySpecEncryption? Encryption { get; set; }

    /// <summary>GlobalParameters: List of parameters for factory.</summary>
    [JsonPropertyName("globalParameters")]
    public IDictionary<string, V1api20180601FactorySpecGlobalParameters>? GlobalParameters { get; set; }

    /// <summary>Identity: Managed service identity of the factory.</summary>
    [JsonPropertyName("identity")]
    public V1api20180601FactorySpecIdentity? Identity { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20180601FactorySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20180601FactorySpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public network access is allowed for the data factory.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20180601FactorySpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>PurviewConfiguration: Purview information of the factory.</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V1api20180601FactorySpecPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary>RepoConfiguration: Git repo information of the factory.</summary>
    [JsonPropertyName("repoConfiguration")]
    public V1api20180601FactorySpecRepoConfiguration? RepoConfiguration { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusConditions
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
/// Identity: User assigned identity to use to authenticate to customer&apos;s key vault. If not provided Managed Service
/// Identity will be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusEncryptionIdentity
{
    /// <summary>UserAssignedIdentity: The resource id of the user assigned identity to authenticate to customer&apos;s key vault.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Encryption: Properties to enable Customer Managed Key for the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusEncryption
{
    /// <summary>
    /// Identity: User assigned identity to use to authenticate to customer&apos;s key vault. If not provided Managed Service
    /// Identity will be used.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20180601FactoryStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>KeyName: The name of the key in Azure Key Vault to use as Customer Managed Key.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>KeyVersion: The version of the key used for CMK. If not provided, latest version will be used.</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary>VaultBaseUrl: The url of the Azure Key Vault used for CMK.</summary>
    [JsonPropertyName("vaultBaseUrl")]
    public string? VaultBaseUrl { get; set; }
}

/// <summary>Definition of a single parameter for an entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusGlobalParameters
{
    /// <summary>Type: Global Parameter type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of parameter.</summary>
    [JsonPropertyName("value")]
    public IDictionary<string, JsonNode>? Value { get; set; }
}

/// <summary>Identity: Managed service identity of the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusIdentity
{
    /// <summary>PrincipalId: The principal id of the identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The client tenant id of the identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: List of user assigned identities for the factory.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, JsonNode>? UserAssignedIdentities { get; set; }
}

/// <summary>PurviewConfiguration: Purview information of the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusPurviewConfiguration
{
    /// <summary>PurviewResourceId: Purview resource id.</summary>
    [JsonPropertyName("purviewResourceId")]
    public string? PurviewResourceId { get; set; }
}

/// <summary>ClientSecret: GitHub bring your own app client secret information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusRepoConfigurationFactoryGitHubConfigurationClientSecret
{
    /// <summary>ByoaSecretAkvUrl: Bring your own app client secret AKV URL.</summary>
    [JsonPropertyName("byoaSecretAkvUrl")]
    public string? ByoaSecretAkvUrl { get; set; }

    /// <summary>ByoaSecretName: Bring your own app client secret name in AKV.</summary>
    [JsonPropertyName("byoaSecretName")]
    public string? ByoaSecretName { get; set; }
}

/// <summary>FactoryGitHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusRepoConfigurationFactoryGitHubConfiguration
{
    /// <summary>AccountName: Account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>ClientId: GitHub bring your own app client id.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientSecret: GitHub bring your own app client secret information.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20180601FactoryStatusRepoConfigurationFactoryGitHubConfigurationClientSecret? ClientSecret { get; set; }

    /// <summary>CollaborationBranch: Collaboration branch.</summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary>DisablePublish: Disable manual publish operation in ADF studio to favor automated publish.</summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary>HostName: GitHub Enterprise host name. For example: `https://github.mydomain.com`</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>LastCommitId: Last commit id.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>RepositoryName: Repository name.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>RootFolder: Root folder.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>Type: Type of repo configuration.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>FactoryVSTS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusRepoConfigurationFactoryVSTSConfiguration
{
    /// <summary>AccountName: Account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>CollaborationBranch: Collaboration branch.</summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary>DisablePublish: Disable manual publish operation in ADF studio to favor automated publish.</summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary>LastCommitId: Last commit id.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>ProjectName: VSTS project name.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>RepositoryName: Repository name.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>RootFolder: Root folder.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>TenantId: VSTS tenant id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of repo configuration.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>RepoConfiguration: Git repo information of the factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatusRepoConfiguration
{
    /// <summary>FactoryGitHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("factoryGitHubConfiguration")]
    public V1api20180601FactoryStatusRepoConfigurationFactoryGitHubConfiguration? FactoryGitHubConfiguration { get; set; }

    /// <summary>FactoryVSTS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("factoryVSTSConfiguration")]
    public V1api20180601FactoryStatusRepoConfigurationFactoryVSTSConfiguration? FactoryVSTSConfiguration { get; set; }
}

/// <summary>Factory resource type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180601FactoryStatus
{
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180601FactoryStatusConditions>? Conditions { get; set; }

    /// <summary>CreateTime: Time the factory was created in ISO8601 format.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ETag: Etag identifies change in the resource.</summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>Encryption: Properties to enable Customer Managed Key for the factory.</summary>
    [JsonPropertyName("encryption")]
    public V1api20180601FactoryStatusEncryption? Encryption { get; set; }

    /// <summary>GlobalParameters: List of parameters for factory.</summary>
    [JsonPropertyName("globalParameters")]
    public IDictionary<string, V1api20180601FactoryStatusGlobalParameters>? GlobalParameters { get; set; }

    /// <summary>Id: The resource identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed service identity of the factory.</summary>
    [JsonPropertyName("identity")]
    public V1api20180601FactoryStatusIdentity? Identity { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: Factory provisioning state, example Succeeded.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public network access is allowed for the data factory.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PurviewConfiguration: Purview information of the factory.</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V1api20180601FactoryStatusPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary>RepoConfiguration: Git repo information of the factory.</summary>
    [JsonPropertyName("repoConfiguration")]
    public V1api20180601FactoryStatusRepoConfiguration? RepoConfiguration { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: Version of the factory.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /datafactory/resource-manager/Microsoft.DataFactory/DataFactory/stable/2018-06-01/datafactory.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180601Factory : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180601FactorySpec?>, IStatus<V1api20180601FactoryStatus?>
{
    public const string KubeApiVersion = "v1api20180601";
    public const string KubeKind = "Factory";
    public const string KubeGroup = "datafactory.azure.com";
    public const string KubePluralName = "factories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datafactory.azure.com/v1api20180601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Factory";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20180601FactorySpec? Spec { get; set; }

    /// <summary>Factory resource type.</summary>
    [JsonPropertyName("status")]
    public V1api20180601FactoryStatus? Status { get; set; }
}