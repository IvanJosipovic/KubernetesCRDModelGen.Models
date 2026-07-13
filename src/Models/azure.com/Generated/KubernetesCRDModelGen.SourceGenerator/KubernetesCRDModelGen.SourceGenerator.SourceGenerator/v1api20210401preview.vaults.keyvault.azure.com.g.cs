#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyvault.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /keyvault/resource-manager/Microsoft.KeyVault/preview/2021-04-01-preview/keyvault.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210401previewVaultList : IKubernetesObject<V1ListMeta>, IItems<V1api20210401previewVault>
{
    public const string KubeApiVersion = "v1api20210401preview";
    public const string KubeKind = "VaultList";
    public const string KubeGroup = "keyvault.azure.com";
    public const string KubePluralName = "vaults";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyvault.azure.com/v1api20210401preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VaultList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210401previewVault objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210401previewVault> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210401previewVaultSpecOperatorSpecSecretExpressions
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
public partial class V1api20210401previewVaultSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210401previewVaultSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210401previewVaultSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ApplicationIdFromConfig:  Application ID of the client making request on behalf of a principal</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesAccessPoliciesApplicationIdFromConfig
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
/// ObjectIdFromConfig: The object ID of a user, service principal or security group in the Azure Active Directory tenant
/// for the vault. The object ID must be unique for the list of access policies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesAccessPoliciesObjectIdFromConfig
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsCertificatesEnum>))]
public enum V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsCertificatesEnum
{
    [EnumMember(Value = "backup"), JsonStringEnumMemberName("backup")]
    Backup,
    [EnumMember(Value = "create"), JsonStringEnumMemberName("create")]
    Create,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "deleteissuers"), JsonStringEnumMemberName("deleteissuers")]
    Deleteissuers,
    [EnumMember(Value = "get"), JsonStringEnumMemberName("get")]
    Get,
    [EnumMember(Value = "getissuers"), JsonStringEnumMemberName("getissuers")]
    Getissuers,
    [EnumMember(Value = "import"), JsonStringEnumMemberName("import")]
    Import,
    [EnumMember(Value = "list"), JsonStringEnumMemberName("list")]
    List,
    [EnumMember(Value = "listissuers"), JsonStringEnumMemberName("listissuers")]
    Listissuers,
    [EnumMember(Value = "managecontacts"), JsonStringEnumMemberName("managecontacts")]
    Managecontacts,
    [EnumMember(Value = "manageissuers"), JsonStringEnumMemberName("manageissuers")]
    Manageissuers,
    [EnumMember(Value = "purge"), JsonStringEnumMemberName("purge")]
    Purge,
    [EnumMember(Value = "recover"), JsonStringEnumMemberName("recover")]
    Recover,
    [EnumMember(Value = "restore"), JsonStringEnumMemberName("restore")]
    Restore,
    [EnumMember(Value = "setissuers"), JsonStringEnumMemberName("setissuers")]
    Setissuers,
    [EnumMember(Value = "update"), JsonStringEnumMemberName("update")]
    Update
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsKeysEnum>))]
public enum V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsKeysEnum
{
    [EnumMember(Value = "backup"), JsonStringEnumMemberName("backup")]
    Backup,
    [EnumMember(Value = "create"), JsonStringEnumMemberName("create")]
    Create,
    [EnumMember(Value = "decrypt"), JsonStringEnumMemberName("decrypt")]
    Decrypt,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "encrypt"), JsonStringEnumMemberName("encrypt")]
    Encrypt,
    [EnumMember(Value = "get"), JsonStringEnumMemberName("get")]
    Get,
    [EnumMember(Value = "import"), JsonStringEnumMemberName("import")]
    Import,
    [EnumMember(Value = "list"), JsonStringEnumMemberName("list")]
    List,
    [EnumMember(Value = "purge"), JsonStringEnumMemberName("purge")]
    Purge,
    [EnumMember(Value = "recover"), JsonStringEnumMemberName("recover")]
    Recover,
    [EnumMember(Value = "release"), JsonStringEnumMemberName("release")]
    Release,
    [EnumMember(Value = "restore"), JsonStringEnumMemberName("restore")]
    Restore,
    [EnumMember(Value = "sign"), JsonStringEnumMemberName("sign")]
    Sign,
    [EnumMember(Value = "unwrapKey"), JsonStringEnumMemberName("unwrapKey")]
    UnwrapKey,
    [EnumMember(Value = "update"), JsonStringEnumMemberName("update")]
    Update,
    [EnumMember(Value = "verify"), JsonStringEnumMemberName("verify")]
    Verify,
    [EnumMember(Value = "wrapKey"), JsonStringEnumMemberName("wrapKey")]
    WrapKey
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsSecretsEnum>))]
public enum V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsSecretsEnum
{
    [EnumMember(Value = "backup"), JsonStringEnumMemberName("backup")]
    Backup,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "get"), JsonStringEnumMemberName("get")]
    Get,
    [EnumMember(Value = "list"), JsonStringEnumMemberName("list")]
    List,
    [EnumMember(Value = "purge"), JsonStringEnumMemberName("purge")]
    Purge,
    [EnumMember(Value = "recover"), JsonStringEnumMemberName("recover")]
    Recover,
    [EnumMember(Value = "restore"), JsonStringEnumMemberName("restore")]
    Restore,
    [EnumMember(Value = "set"), JsonStringEnumMemberName("set")]
    Set
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsStorageEnum>))]
public enum V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsStorageEnum
{
    [EnumMember(Value = "backup"), JsonStringEnumMemberName("backup")]
    Backup,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "deletesas"), JsonStringEnumMemberName("deletesas")]
    Deletesas,
    [EnumMember(Value = "get"), JsonStringEnumMemberName("get")]
    Get,
    [EnumMember(Value = "getsas"), JsonStringEnumMemberName("getsas")]
    Getsas,
    [EnumMember(Value = "list"), JsonStringEnumMemberName("list")]
    List,
    [EnumMember(Value = "listsas"), JsonStringEnumMemberName("listsas")]
    Listsas,
    [EnumMember(Value = "purge"), JsonStringEnumMemberName("purge")]
    Purge,
    [EnumMember(Value = "recover"), JsonStringEnumMemberName("recover")]
    Recover,
    [EnumMember(Value = "regeneratekey"), JsonStringEnumMemberName("regeneratekey")]
    Regeneratekey,
    [EnumMember(Value = "restore"), JsonStringEnumMemberName("restore")]
    Restore,
    [EnumMember(Value = "set"), JsonStringEnumMemberName("set")]
    Set,
    [EnumMember(Value = "setsas"), JsonStringEnumMemberName("setsas")]
    Setsas,
    [EnumMember(Value = "update"), JsonStringEnumMemberName("update")]
    Update
}

/// <summary>Permissions: Permissions the identity has for keys, secrets and certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissions
{
    /// <summary>Certificates: Permissions to certificates</summary>
    [JsonPropertyName("certificates")]
    public IList<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsCertificatesEnum>? Certificates { get; set; }

    /// <summary>Keys: Permissions to keys</summary>
    [JsonPropertyName("keys")]
    public IList<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsKeysEnum>? Keys { get; set; }

    /// <summary>Secrets: Permissions to secrets</summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsSecretsEnum>? Secrets { get; set; }

    /// <summary>Storage: Permissions to storage accounts</summary>
    [JsonPropertyName("storage")]
    public IList<V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissionsStorageEnum>? Storage { get; set; }
}

/// <summary>
/// TenantIdFromConfig: The Azure Active Directory tenant ID that should be used for authenticating requests to the key
/// vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesAccessPoliciesTenantIdFromConfig
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
/// An identity that have access to the key vault. All identities in the array must use the same tenant ID as the key
/// vault&apos;s tenant ID.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesAccessPolicies
{
    /// <summary>ApplicationId:  Application ID of the client making request on behalf of a principal</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>ApplicationIdFromConfig:  Application ID of the client making request on behalf of a principal</summary>
    [JsonPropertyName("applicationIdFromConfig")]
    public V1api20210401previewVaultSpecPropertiesAccessPoliciesApplicationIdFromConfig? ApplicationIdFromConfig { get; set; }

    /// <summary>
    /// ObjectId: The object ID of a user, service principal or security group in the Azure Active Directory tenant for the
    /// vault. The object ID must be unique for the list of access policies.
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// ObjectIdFromConfig: The object ID of a user, service principal or security group in the Azure Active Directory tenant
    /// for the vault. The object ID must be unique for the list of access policies.
    /// </summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20210401previewVaultSpecPropertiesAccessPoliciesObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>Permissions: Permissions the identity has for keys, secrets and certificates.</summary>
    [JsonPropertyName("permissions")]
    public required V1api20210401previewVaultSpecPropertiesAccessPoliciesPermissions Permissions { get; set; }

    /// <summary>TenantId: The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// TenantIdFromConfig: The Azure Active Directory tenant ID that should be used for authenticating requests to the key
    /// vault.
    /// </summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20210401previewVaultSpecPropertiesAccessPoliciesTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>CreateMode: The vault&apos;s create mode to indicate whether the vault need to be recovered or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesCreateModeEnum>))]
public enum V1api20210401previewVaultSpecPropertiesCreateModeEnum
{
    [EnumMember(Value = "createOrRecover"), JsonStringEnumMemberName("createOrRecover")]
    CreateOrRecover,
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "purgeThenCreate"), JsonStringEnumMemberName("purgeThenCreate")]
    PurgeThenCreate,
    [EnumMember(Value = "recover"), JsonStringEnumMemberName("recover")]
    Recover
}

/// <summary>
/// Bypass: Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the
/// default is &apos;AzureServices&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesNetworkAclsBypassEnum>))]
public enum V1api20210401previewVaultSpecPropertiesNetworkAclsBypassEnum
{
    [EnumMember(Value = "AzureServices"), JsonStringEnumMemberName("AzureServices")]
    AzureServices,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// DefaultAction: The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after
/// the bypass property has been evaluated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesNetworkAclsDefaultActionEnum>))]
public enum V1api20210401previewVaultSpecPropertiesNetworkAclsDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>A rule governing the accessibility of a vault from a specific ip address or ip range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesNetworkAclsIpRules
{
    /// <summary>
    /// Value: An IPv4 address range in CIDR notation, such as &apos;124.56.78.91&apos; (simple IP address) or &apos;124.56.78.0/24&apos; (all
    /// addresses that start with 124.56.78).
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Reference: Full resource id of a vnet subnet, such as
/// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesNetworkAclsVirtualNetworkRulesReference
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

/// <summary>A rule governing the accessibility of a vault from a specific virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesNetworkAclsVirtualNetworkRules
{
    /// <summary>
    /// IgnoreMissingVnetServiceEndpoint: Property to specify whether NRP will ignore the check if parent subnet has
    /// serviceEndpoints configured.
    /// </summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }

    /// <summary>
    /// Reference: Full resource id of a vnet subnet, such as
    /// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
    /// </summary>
    [JsonPropertyName("reference")]
    public required V1api20210401previewVaultSpecPropertiesNetworkAclsVirtualNetworkRulesReference Reference { get; set; }
}

/// <summary>NetworkAcls: Rules governing the accessibility of the key vault from specific network locations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesNetworkAcls
{
    /// <summary>
    /// Bypass: Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the
    /// default is &apos;AzureServices&apos;.
    /// </summary>
    [JsonPropertyName("bypass")]
    public V1api20210401previewVaultSpecPropertiesNetworkAclsBypassEnum? Bypass { get; set; }

    /// <summary>
    /// DefaultAction: The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after
    /// the bypass property has been evaluated.
    /// </summary>
    [JsonPropertyName("defaultAction")]
    public V1api20210401previewVaultSpecPropertiesNetworkAclsDefaultActionEnum? DefaultAction { get; set; }

    /// <summary>IpRules: The list of IP address rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210401previewVaultSpecPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>VirtualNetworkRules: The list of virtual network rules.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20210401previewVaultSpecPropertiesNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>ProvisioningState: Provisioning state of the vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesProvisioningStateEnum>))]
public enum V1api20210401previewVaultSpecPropertiesProvisioningStateEnum
{
    [EnumMember(Value = "RegisteringDns"), JsonStringEnumMemberName("RegisteringDns")]
    RegisteringDns,
    [EnumMember(Value = "Succeeded"), JsonStringEnumMemberName("Succeeded")]
    Succeeded
}

/// <summary>Family: SKU family name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesSkuFamilyEnum>))]
public enum V1api20210401previewVaultSpecPropertiesSkuFamilyEnum
{
    [EnumMember(Value = "A"), JsonStringEnumMemberName("A")]
    A
}

/// <summary>Name: SKU name to specify whether the key vault is a standard vault or a premium vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401previewVaultSpecPropertiesSkuNameEnum>))]
public enum V1api20210401previewVaultSpecPropertiesSkuNameEnum
{
    [EnumMember(Value = "premium"), JsonStringEnumMemberName("premium")]
    Premium,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard
}

/// <summary>Sku: SKU details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesSku
{
    /// <summary>Family: SKU family name</summary>
    [JsonPropertyName("family")]
    public required V1api20210401previewVaultSpecPropertiesSkuFamilyEnum Family { get; set; }

    /// <summary>Name: SKU name to specify whether the key vault is a standard vault or a premium vault.</summary>
    [JsonPropertyName("name")]
    public required V1api20210401previewVaultSpecPropertiesSkuNameEnum Name { get; set; }
}

/// <summary>
/// TenantIdFromConfig: The Azure Active Directory tenant ID that should be used for authenticating requests to the key
/// vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecPropertiesTenantIdFromConfig
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

/// <summary>Properties: Properties of the vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpecProperties
{
    /// <summary>
    /// AccessPolicies: An array of 0 to 1024 identities that have access to the key vault. All identities in the array must use
    /// the same tenant ID as the key vault&apos;s tenant ID. When `createMode` is set to `recover`, access policies are not
    /// required. Otherwise, access policies are required.
    /// </summary>
    [JsonPropertyName("accessPolicies")]
    public IList<V1api20210401previewVaultSpecPropertiesAccessPolicies>? AccessPolicies { get; set; }

    /// <summary>CreateMode: The vault&apos;s create mode to indicate whether the vault need to be recovered or not.</summary>
    [JsonPropertyName("createMode")]
    public V1api20210401previewVaultSpecPropertiesCreateModeEnum? CreateMode { get; set; }

    /// <summary>
    /// EnablePurgeProtection: Property specifying whether protection against purge is enabled for this vault. Setting this
    /// property to true activates protection against purge for this vault and its content - only the Key Vault service may
    /// initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this
    /// functionality is irreversible - that is, the property does not accept false as its value.
    /// </summary>
    [JsonPropertyName("enablePurgeProtection")]
    public bool? EnablePurgeProtection { get; set; }

    /// <summary>
    /// EnableRbacAuthorization: Property that controls how data actions are authorized. When true, the key vault will use Role
    /// Based Access Control (RBAC) for authorization of data actions, and the access policies specified in vault properties
    /// will be  ignored. When false, the key vault will use the access policies specified in vault properties, and any policy
    /// stored on Azure Resource Manager will be ignored. If null or not specified, the vault is created with the default value
    /// of false. Note that management actions are always authorized with RBAC.
    /// </summary>
    [JsonPropertyName("enableRbacAuthorization")]
    public bool? EnableRbacAuthorization { get; set; }

    /// <summary>
    /// EnableSoftDelete: Property to specify whether the &apos;soft delete&apos; functionality is enabled for this key vault. If it&apos;s not
    /// set to any value(true or false) when creating new key vault, it will be set to true by default. Once set to true, it
    /// cannot be reverted to false.
    /// </summary>
    [JsonPropertyName("enableSoftDelete")]
    public bool? EnableSoftDelete { get; set; }

    /// <summary>
    /// EnabledForDeployment: Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored
    /// as secrets from the key vault.
    /// </summary>
    [JsonPropertyName("enabledForDeployment")]
    public bool? EnabledForDeployment { get; set; }

    /// <summary>
    /// EnabledForDiskEncryption: Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the
    /// vault and unwrap keys.
    /// </summary>
    [JsonPropertyName("enabledForDiskEncryption")]
    public bool? EnabledForDiskEncryption { get; set; }

    /// <summary>
    /// EnabledForTemplateDeployment: Property to specify whether Azure Resource Manager is permitted to retrieve secrets from
    /// the key vault.
    /// </summary>
    [JsonPropertyName("enabledForTemplateDeployment")]
    public bool? EnabledForTemplateDeployment { get; set; }

    /// <summary>NetworkAcls: Rules governing the accessibility of the key vault from specific network locations.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20210401previewVaultSpecPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the vault.</summary>
    [JsonPropertyName("provisioningState")]
    public V1api20210401previewVaultSpecPropertiesProvisioningStateEnum? ProvisioningState { get; set; }

    /// <summary>Sku: SKU details</summary>
    [JsonPropertyName("sku")]
    public required V1api20210401previewVaultSpecPropertiesSku Sku { get; set; }

    /// <summary>SoftDeleteRetentionInDays: softDelete data retention days. It accepts &gt;=7 and &lt;=90.</summary>
    [JsonPropertyName("softDeleteRetentionInDays")]
    public int? SoftDeleteRetentionInDays { get; set; }

    /// <summary>TenantId: The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// TenantIdFromConfig: The Azure Active Directory tenant ID that should be used for authenticating requests to the key
    /// vault.
    /// </summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20210401previewVaultSpecPropertiesTenantIdFromConfig? TenantIdFromConfig { get; set; }

    /// <summary>VaultUri: The URI of the vault for performing operations on keys and secrets.</summary>
    [JsonPropertyName("vaultUri")]
    public string? VaultUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The supported Azure location where the key vault should be created.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210401previewVaultSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210401previewVaultSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of the vault</summary>
    [JsonPropertyName("properties")]
    public required V1api20210401previewVaultSpecProperties Properties { get; set; }

    /// <summary>Tags: The tags that will be assigned to the key vault.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusConditions
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

/// <summary>Permissions: Permissions the identity has for keys, secrets and certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesAccessPoliciesPermissions
{
    /// <summary>Certificates: Permissions to certificates</summary>
    [JsonPropertyName("certificates")]
    public IList<string>? Certificates { get; set; }

    /// <summary>Keys: Permissions to keys</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }

    /// <summary>Secrets: Permissions to secrets</summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }

    /// <summary>Storage: Permissions to storage accounts</summary>
    [JsonPropertyName("storage")]
    public IList<string>? Storage { get; set; }
}

/// <summary>
/// An identity that have access to the key vault. All identities in the array must use the same tenant ID as the key
/// vault&apos;s tenant ID.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesAccessPolicies
{
    /// <summary>ApplicationId:  Application ID of the client making request on behalf of a principal</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// ObjectId: The object ID of a user, service principal or security group in the Azure Active Directory tenant for the
    /// vault. The object ID must be unique for the list of access policies.
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Permissions: Permissions the identity has for keys, secrets and certificates.</summary>
    [JsonPropertyName("permissions")]
    public V1api20210401previewVaultStatusPropertiesAccessPoliciesPermissions? Permissions { get; set; }

    /// <summary>TenantId: The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A rule governing the accessibility of a vault from a specific ip address or ip range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesNetworkAclsIpRules
{
    /// <summary>
    /// Value: An IPv4 address range in CIDR notation, such as &apos;124.56.78.91&apos; (simple IP address) or &apos;124.56.78.0/24&apos; (all
    /// addresses that start with 124.56.78).
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A rule governing the accessibility of a vault from a specific virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesNetworkAclsVirtualNetworkRules
{
    /// <summary>
    /// Id: Full resource id of a vnet subnet, such as
    /// &apos;/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1&apos;.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IgnoreMissingVnetServiceEndpoint: Property to specify whether NRP will ignore the check if parent subnet has
    /// serviceEndpoints configured.
    /// </summary>
    [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
    public bool? IgnoreMissingVnetServiceEndpoint { get; set; }
}

/// <summary>NetworkAcls: Rules governing the accessibility of the key vault from specific network locations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesNetworkAcls
{
    /// <summary>
    /// Bypass: Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the
    /// default is &apos;AzureServices&apos;.
    /// </summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary>
    /// DefaultAction: The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after
    /// the bypass property has been evaluated.
    /// </summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: The list of IP address rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210401previewVaultStatusPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>VirtualNetworkRules: The list of virtual network rules.</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20210401previewVaultStatusPropertiesNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>PrivateEndpoint: Properties of the private endpoint object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesPrivateEndpointConnectionsPrivateEndpoint
{
    /// <summary>Id: Full identifier of the private endpoint resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PrivateLinkServiceConnectionState: Approval state of the private link connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesPrivateEndpointConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: A message indicating if changes on the service provider require any updates on the consumer.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The reason for approval or rejection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Indicates whether the connection has been approved, rejected or removed by the key vault owner.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Private endpoint connection item.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesPrivateEndpointConnections
{
    /// <summary>Etag: Modified whenever there is a change in the state of private endpoint connection.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Id of private endpoint connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>PrivateEndpoint: Properties of the private endpoint object.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20210401previewVaultStatusPropertiesPrivateEndpointConnectionsPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>PrivateLinkServiceConnectionState: Approval state of the private link connection.</summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20210401previewVaultStatusPropertiesPrivateEndpointConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the private endpoint connection.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Sku: SKU details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusPropertiesSku
{
    /// <summary>Family: SKU family name</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: SKU name to specify whether the key vault is a standard vault or a premium vault.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Properties: Properties of the vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusProperties
{
    /// <summary>
    /// AccessPolicies: An array of 0 to 1024 identities that have access to the key vault. All identities in the array must use
    /// the same tenant ID as the key vault&apos;s tenant ID. When `createMode` is set to `recover`, access policies are not
    /// required. Otherwise, access policies are required.
    /// </summary>
    [JsonPropertyName("accessPolicies")]
    public IList<V1api20210401previewVaultStatusPropertiesAccessPolicies>? AccessPolicies { get; set; }

    /// <summary>CreateMode: The vault&apos;s create mode to indicate whether the vault need to be recovered or not.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>
    /// EnablePurgeProtection: Property specifying whether protection against purge is enabled for this vault. Setting this
    /// property to true activates protection against purge for this vault and its content - only the Key Vault service may
    /// initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this
    /// functionality is irreversible - that is, the property does not accept false as its value.
    /// </summary>
    [JsonPropertyName("enablePurgeProtection")]
    public bool? EnablePurgeProtection { get; set; }

    /// <summary>
    /// EnableRbacAuthorization: Property that controls how data actions are authorized. When true, the key vault will use Role
    /// Based Access Control (RBAC) for authorization of data actions, and the access policies specified in vault properties
    /// will be  ignored. When false, the key vault will use the access policies specified in vault properties, and any policy
    /// stored on Azure Resource Manager will be ignored. If null or not specified, the vault is created with the default value
    /// of false. Note that management actions are always authorized with RBAC.
    /// </summary>
    [JsonPropertyName("enableRbacAuthorization")]
    public bool? EnableRbacAuthorization { get; set; }

    /// <summary>
    /// EnableSoftDelete: Property to specify whether the &apos;soft delete&apos; functionality is enabled for this key vault. If it&apos;s not
    /// set to any value(true or false) when creating new key vault, it will be set to true by default. Once set to true, it
    /// cannot be reverted to false.
    /// </summary>
    [JsonPropertyName("enableSoftDelete")]
    public bool? EnableSoftDelete { get; set; }

    /// <summary>
    /// EnabledForDeployment: Property to specify whether Azure Virtual Machines are permitted to retrieve certificates stored
    /// as secrets from the key vault.
    /// </summary>
    [JsonPropertyName("enabledForDeployment")]
    public bool? EnabledForDeployment { get; set; }

    /// <summary>
    /// EnabledForDiskEncryption: Property to specify whether Azure Disk Encryption is permitted to retrieve secrets from the
    /// vault and unwrap keys.
    /// </summary>
    [JsonPropertyName("enabledForDiskEncryption")]
    public bool? EnabledForDiskEncryption { get; set; }

    /// <summary>
    /// EnabledForTemplateDeployment: Property to specify whether Azure Resource Manager is permitted to retrieve secrets from
    /// the key vault.
    /// </summary>
    [JsonPropertyName("enabledForTemplateDeployment")]
    public bool? EnabledForTemplateDeployment { get; set; }

    /// <summary>HsmPoolResourceId: The resource id of HSM Pool.</summary>
    [JsonPropertyName("hsmPoolResourceId")]
    public string? HsmPoolResourceId { get; set; }

    /// <summary>NetworkAcls: Rules governing the accessibility of the key vault from specific network locations.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20210401previewVaultStatusPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections associated with the key vault.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210401previewVaultStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the vault.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Sku: SKU details</summary>
    [JsonPropertyName("sku")]
    public V1api20210401previewVaultStatusPropertiesSku? Sku { get; set; }

    /// <summary>SoftDeleteRetentionInDays: softDelete data retention days. It accepts &gt;=7 and &lt;=90.</summary>
    [JsonPropertyName("softDeleteRetentionInDays")]
    public int? SoftDeleteRetentionInDays { get; set; }

    /// <summary>TenantId: The Azure Active Directory tenant ID that should be used for authenticating requests to the key vault.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>VaultUri: The URI of the vault for performing operations on keys and secrets.</summary>
    [JsonPropertyName("vaultUri")]
    public string? VaultUri { get; set; }
}

/// <summary>SystemData: System metadata for the key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of the key vault resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the key vault resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the key vault resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of the key vault resource last modification (UTC).</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the key vault resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the key vault resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Resource information with extended details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401previewVaultStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210401previewVaultStatusConditions>? Conditions { get; set; }

    /// <summary>Id: Fully qualified identifier of the key vault resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Azure location of the key vault resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Name of the key vault resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Properties of the vault</summary>
    [JsonPropertyName("properties")]
    public V1api20210401previewVaultStatusProperties? Properties { get; set; }

    /// <summary>SystemData: System metadata for the key vault.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210401previewVaultStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Tags assigned to the key vault resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type of the key vault resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /keyvault/resource-manager/Microsoft.KeyVault/preview/2021-04-01-preview/keyvault.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210401previewVault : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210401previewVaultSpec?>, IStatus<V1api20210401previewVaultStatus?>
{
    public const string KubeApiVersion = "v1api20210401preview";
    public const string KubeKind = "Vault";
    public const string KubeGroup = "keyvault.azure.com";
    public const string KubePluralName = "vaults";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyvault.azure.com/v1api20210401preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Vault";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210401previewVaultSpec? Spec { get; set; }

    /// <summary>Resource information with extended details.</summary>
    [JsonPropertyName("status")]
    public V1api20210401previewVaultStatus? Status { get; set; }
}