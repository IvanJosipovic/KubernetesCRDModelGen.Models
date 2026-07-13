#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerregistry.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /containerregistry/resource-manager/Microsoft.ContainerRegistry/Registry/stable/2021-09-01/containerregistry.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210901RegistryList : IKubernetesObject<V1ListMeta>, IItems<V1api20210901Registry>
{
    public const string KubeApiVersion = "v1api20210901";
    public const string KubeKind = "RegistryList";
    public const string KubeGroup = "containerregistry.azure.com";
    public const string KubePluralName = "registries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerregistry.azure.com/v1api20210901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegistryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210901Registry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210901Registry> Items { get; set; }
}

/// <summary>KeyVaultProperties: Key vault properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecEncryptionKeyVaultProperties
{
    /// <summary>Identity: The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>KeyIdentifier: Key vault uri to access the encryption key.</summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>Status: Indicates whether or not the encryption is enabled for container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecEncryptionStatusEnum>))]
public enum V1api20210901RegistrySpecEncryptionStatusEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>Encryption: The encryption settings of container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecEncryption
{
    /// <summary>KeyVaultProperties: Key vault properties.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210901RegistrySpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary>Status: Indicates whether or not the encryption is enabled for container registry.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistrySpecEncryptionStatusEnum? Status { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecIdentityTypeEnum>))]
public enum V1api20210901RegistrySpecIdentityTypeEnum
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
public partial class V1api20210901RegistrySpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20210901RegistrySpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210901RegistrySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public V1api20210901RegistrySpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
    /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210901RegistrySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>NetworkRuleBypassOptions: Whether to allow trusted Azure services to access a network restricted registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecNetworkRuleBypassOptionsEnum>))]
public enum V1api20210901RegistrySpecNetworkRuleBypassOptionsEnum
{
    [EnumMember(Value = "AzureServices"), JsonStringEnumMemberName("AzureServices")]
    AzureServices,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>DefaultAction: The default action of allow or deny when no other rules match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecNetworkRuleSetDefaultActionEnum>))]
public enum V1api20210901RegistrySpecNetworkRuleSetDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: The action of IP ACL rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecNetworkRuleSetIpRulesActionEnum>))]
public enum V1api20210901RegistrySpecNetworkRuleSetIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecNetworkRuleSetIpRules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public V1api20210901RegistrySpecNetworkRuleSetIpRulesActionEnum? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>NetworkRuleSet: The network rule set for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecNetworkRuleSet
{
    /// <summary>DefaultAction: The default action of allow or deny when no other rules match.</summary>
    [JsonPropertyName("defaultAction")]
    public required V1api20210901RegistrySpecNetworkRuleSetDefaultActionEnum DefaultAction { get; set; }

    /// <summary>IpRules: The IP ACL rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210901RegistrySpecNetworkRuleSetIpRules>? IpRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210901RegistrySpecOperatorSpecSecretExpressions
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
public partial class V1api20210901RegistrySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210901RegistrySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210901RegistrySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecPoliciesExportPolicyStatusEnum>))]
public enum V1api20210901RegistrySpecPoliciesExportPolicyStatusEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>ExportPolicy: The export policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecPoliciesExportPolicy
{
    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistrySpecPoliciesExportPolicyStatusEnum? Status { get; set; }
}

/// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecPoliciesQuarantinePolicyStatusEnum>))]
public enum V1api20210901RegistrySpecPoliciesQuarantinePolicyStatusEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>QuarantinePolicy: The quarantine policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecPoliciesQuarantinePolicy
{
    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistrySpecPoliciesQuarantinePolicyStatusEnum? Status { get; set; }
}

/// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecPoliciesRetentionPolicyStatusEnum>))]
public enum V1api20210901RegistrySpecPoliciesRetentionPolicyStatusEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>RetentionPolicy: The retention policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecPoliciesRetentionPolicy
{
    /// <summary>Days: The number of days to retain an untagged manifest after which it gets purged.</summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistrySpecPoliciesRetentionPolicyStatusEnum? Status { get; set; }
}

/// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecPoliciesTrustPolicyStatusEnum>))]
public enum V1api20210901RegistrySpecPoliciesTrustPolicyStatusEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>Type: The type of trust policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecPoliciesTrustPolicyTypeEnum>))]
public enum V1api20210901RegistrySpecPoliciesTrustPolicyTypeEnum
{
    [EnumMember(Value = "Notary"), JsonStringEnumMemberName("Notary")]
    Notary
}

/// <summary>TrustPolicy: The content trust policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecPoliciesTrustPolicy
{
    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistrySpecPoliciesTrustPolicyStatusEnum? Status { get; set; }

    /// <summary>Type: The type of trust policy.</summary>
    [JsonPropertyName("type")]
    public V1api20210901RegistrySpecPoliciesTrustPolicyTypeEnum? Type { get; set; }
}

/// <summary>Policies: The policies for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecPolicies
{
    /// <summary>ExportPolicy: The export policy for a container registry.</summary>
    [JsonPropertyName("exportPolicy")]
    public V1api20210901RegistrySpecPoliciesExportPolicy? ExportPolicy { get; set; }

    /// <summary>QuarantinePolicy: The quarantine policy for a container registry.</summary>
    [JsonPropertyName("quarantinePolicy")]
    public V1api20210901RegistrySpecPoliciesQuarantinePolicy? QuarantinePolicy { get; set; }

    /// <summary>RetentionPolicy: The retention policy for a container registry.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1api20210901RegistrySpecPoliciesRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>TrustPolicy: The content trust policy for a container registry.</summary>
    [JsonPropertyName("trustPolicy")]
    public V1api20210901RegistrySpecPoliciesTrustPolicy? TrustPolicy { get; set; }
}

/// <summary>PublicNetworkAccess: Whether or not public network access is allowed for the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecPublicNetworkAccessEnum>))]
public enum V1api20210901RegistrySpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Name: The SKU name of the container registry. Required for registry creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecSkuNameEnum>))]
public enum V1api20210901RegistrySpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Classic"), JsonStringEnumMemberName("Classic")]
    Classic,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The SKU of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpecSku
{
    /// <summary>Name: The SKU name of the container registry. Required for registry creation.</summary>
    [JsonPropertyName("name")]
    public required V1api20210901RegistrySpecSkuNameEnum Name { get; set; }
}

/// <summary>ZoneRedundancy: Whether or not zone redundancy is enabled for this container registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210901RegistrySpecZoneRedundancyEnum>))]
public enum V1api20210901RegistrySpecZoneRedundancyEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistrySpec
{
    /// <summary>AdminUserEnabled: The value that indicates whether the admin user is enabled.</summary>
    [JsonPropertyName("adminUserEnabled")]
    public bool? AdminUserEnabled { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DataEndpointEnabled: Enable a single data endpoint per region for serving data.</summary>
    [JsonPropertyName("dataEndpointEnabled")]
    public bool? DataEndpointEnabled { get; set; }

    /// <summary>Encryption: The encryption settings of container registry.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210901RegistrySpecEncryption? Encryption { get; set; }

    /// <summary>Identity: The identity of the container registry.</summary>
    [JsonPropertyName("identity")]
    public V1api20210901RegistrySpecIdentity? Identity { get; set; }

    /// <summary>Location: The location of the resource. This cannot be changed after the resource is created.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NetworkRuleBypassOptions: Whether to allow trusted Azure services to access a network restricted registry.</summary>
    [JsonPropertyName("networkRuleBypassOptions")]
    public V1api20210901RegistrySpecNetworkRuleBypassOptionsEnum? NetworkRuleBypassOptions { get; set; }

    /// <summary>NetworkRuleSet: The network rule set for a container registry.</summary>
    [JsonPropertyName("networkRuleSet")]
    public V1api20210901RegistrySpecNetworkRuleSet? NetworkRuleSet { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210901RegistrySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210901RegistrySpecOwner Owner { get; set; }

    /// <summary>Policies: The policies for a container registry.</summary>
    [JsonPropertyName("policies")]
    public V1api20210901RegistrySpecPolicies? Policies { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public network access is allowed for the container registry.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20210901RegistrySpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>Sku: The SKU of the container registry.</summary>
    [JsonPropertyName("sku")]
    public required V1api20210901RegistrySpecSku Sku { get; set; }

    /// <summary>Tags: The tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ZoneRedundancy: Whether or not zone redundancy is enabled for this container registry</summary>
    [JsonPropertyName("zoneRedundancy")]
    public V1api20210901RegistrySpecZoneRedundancyEnum? ZoneRedundancy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusConditions
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

/// <summary>KeyVaultProperties: Key vault properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusEncryptionKeyVaultProperties
{
    /// <summary>Identity: The client id of the identity which will be used to access key vault.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>KeyIdentifier: Key vault uri to access the encryption key.</summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary>KeyRotationEnabled: Auto key rotation status for a CMK enabled registry.</summary>
    [JsonPropertyName("keyRotationEnabled")]
    public bool? KeyRotationEnabled { get; set; }

    /// <summary>LastKeyRotationTimestamp: Timestamp of the last successful key rotation.</summary>
    [JsonPropertyName("lastKeyRotationTimestamp")]
    public string? LastKeyRotationTimestamp { get; set; }

    /// <summary>
    /// VersionedKeyIdentifier: The fully qualified key identifier that includes the version of the key that is actually used
    /// for encryption.
    /// </summary>
    [JsonPropertyName("versionedKeyIdentifier")]
    public string? VersionedKeyIdentifier { get; set; }
}

/// <summary>Encryption: The encryption settings of container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusEncryption
{
    /// <summary>KeyVaultProperties: Key vault properties.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210901RegistryStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary>Status: Indicates whether or not the encryption is enabled for container registry.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusIdentity
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

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
    /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210901RegistryStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusNetworkRuleSetIpRules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>NetworkRuleSet: The network rule set for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusNetworkRuleSet
{
    /// <summary>DefaultAction: The default action of allow or deny when no other rules match.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: The IP ACL rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210901RegistryStatusNetworkRuleSetIpRules>? IpRules { get; set; }
}

/// <summary>ExportPolicy: The export policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusPoliciesExportPolicy
{
    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>QuarantinePolicy: The quarantine policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusPoliciesQuarantinePolicy
{
    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>RetentionPolicy: The retention policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusPoliciesRetentionPolicy
{
    /// <summary>Days: The number of days to retain an untagged manifest after which it gets purged.</summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>LastUpdatedTime: The timestamp when the policy was last updated.</summary>
    [JsonPropertyName("lastUpdatedTime")]
    public string? LastUpdatedTime { get; set; }

    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>TrustPolicy: The content trust policy for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusPoliciesTrustPolicy
{
    /// <summary>Status: The value that indicates whether the policy is enabled or not.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type: The type of trust policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies: The policies for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusPolicies
{
    /// <summary>ExportPolicy: The export policy for a container registry.</summary>
    [JsonPropertyName("exportPolicy")]
    public V1api20210901RegistryStatusPoliciesExportPolicy? ExportPolicy { get; set; }

    /// <summary>QuarantinePolicy: The quarantine policy for a container registry.</summary>
    [JsonPropertyName("quarantinePolicy")]
    public V1api20210901RegistryStatusPoliciesQuarantinePolicy? QuarantinePolicy { get; set; }

    /// <summary>RetentionPolicy: The retention policy for a container registry.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1api20210901RegistryStatusPoliciesRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>TrustPolicy: The content trust policy for a container registry.</summary>
    [JsonPropertyName("trustPolicy")]
    public V1api20210901RegistryStatusPoliciesTrustPolicy? TrustPolicy { get; set; }
}

/// <summary>An object that represents a private endpoint connection for a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusPrivateEndpointConnections
{
    /// <summary>Id: The resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The SKU of the container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusSku
{
    /// <summary>Name: The SKU name of the container registry. Required for registry creation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The SKU tier based on the SKU name.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Status: The status of the container registry at the time the operation was called.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusStatus
{
    /// <summary>DisplayStatus: The short label for the status.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Message: The detailed message for the status, including alerts and error messages.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Timestamp: The timestamp when the status was changed to the current value.</summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatusSystemData
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

    /// <summary>LastModifiedAt: The timestamp of resource modification (UTC).</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>An object that represents a container registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210901RegistryStatus
{
    /// <summary>AdminUserEnabled: The value that indicates whether the admin user is enabled.</summary>
    [JsonPropertyName("adminUserEnabled")]
    public bool? AdminUserEnabled { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210901RegistryStatusConditions>? Conditions { get; set; }

    /// <summary>CreationDate: The creation date of the container registry in ISO8601 format.</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>DataEndpointEnabled: Enable a single data endpoint per region for serving data.</summary>
    [JsonPropertyName("dataEndpointEnabled")]
    public bool? DataEndpointEnabled { get; set; }

    /// <summary>DataEndpointHostNames: List of host names that will serve data when dataEndpointEnabled is true.</summary>
    [JsonPropertyName("dataEndpointHostNames")]
    public IList<string>? DataEndpointHostNames { get; set; }

    /// <summary>Encryption: The encryption settings of container registry.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210901RegistryStatusEncryption? Encryption { get; set; }

    /// <summary>Id: The resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the container registry.</summary>
    [JsonPropertyName("identity")]
    public V1api20210901RegistryStatusIdentity? Identity { get; set; }

    /// <summary>Location: The location of the resource. This cannot be changed after the resource is created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>LoginServer: The URL that can be used to log into the container registry.</summary>
    [JsonPropertyName("loginServer")]
    public string? LoginServer { get; set; }

    /// <summary>Name: The name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkRuleBypassOptions: Whether to allow trusted Azure services to access a network restricted registry.</summary>
    [JsonPropertyName("networkRuleBypassOptions")]
    public string? NetworkRuleBypassOptions { get; set; }

    /// <summary>NetworkRuleSet: The network rule set for a container registry.</summary>
    [JsonPropertyName("networkRuleSet")]
    public V1api20210901RegistryStatusNetworkRuleSet? NetworkRuleSet { get; set; }

    /// <summary>Policies: The policies for a container registry.</summary>
    [JsonPropertyName("policies")]
    public V1api20210901RegistryStatusPolicies? Policies { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections for a container registry.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210901RegistryStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the container registry at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public network access is allowed for the container registry.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Sku: The SKU of the container registry.</summary>
    [JsonPropertyName("sku")]
    public V1api20210901RegistryStatusSku? Sku { get; set; }

    /// <summary>Status: The status of the container registry at the time the operation was called.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistryStatusStatus? Status { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210901RegistryStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: The tags of the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>ZoneRedundancy: Whether or not zone redundancy is enabled for this container registry</summary>
    [JsonPropertyName("zoneRedundancy")]
    public string? ZoneRedundancy { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerregistry/resource-manager/Microsoft.ContainerRegistry/Registry/stable/2021-09-01/containerregistry.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210901Registry : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210901RegistrySpec?>, IStatus<V1api20210901RegistryStatus?>
{
    public const string KubeApiVersion = "v1api20210901";
    public const string KubeKind = "Registry";
    public const string KubeGroup = "containerregistry.azure.com";
    public const string KubePluralName = "registries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerregistry.azure.com/v1api20210901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Registry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210901RegistrySpec? Spec { get; set; }

    /// <summary>An object that represents a container registry.</summary>
    [JsonPropertyName("status")]
    public V1api20210901RegistryStatus? Status { get; set; }
}