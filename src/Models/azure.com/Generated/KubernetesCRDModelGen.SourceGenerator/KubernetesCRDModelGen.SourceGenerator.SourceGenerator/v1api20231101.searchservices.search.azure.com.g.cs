#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.search.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /search/resource-manager/Microsoft.Search/Search/stable/2023-11-01/search.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101SearchServiceList : IKubernetesObject<V1ListMeta>, IItems<V1api20231101SearchService>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "SearchServiceList";
    public const string KubeGroup = "search.azure.com";
    public const string KubePluralName = "searchservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "search.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SearchServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231101SearchService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231101SearchService> Items { get; set; }
}

/// <summary>
/// AadAuthFailureMode: Describes what response the data plane API of a search service would send for requests that failed
/// authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecAuthOptionsAadOrApiKeyAadAuthFailureModeEnum>))]
public enum V1api20231101SearchServiceSpecAuthOptionsAadOrApiKeyAadAuthFailureModeEnum
{
    [EnumMember(Value = "http401WithBearerChallenge"), JsonStringEnumMemberName("http401WithBearerChallenge")]
    Http401WithBearerChallenge,
    [EnumMember(Value = "http403"), JsonStringEnumMemberName("http403")]
    Http403
}

/// <summary>
/// AadOrApiKey: Indicates that either the API key or an access token from a Microsoft Entra ID tenant can be used for
/// authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecAuthOptionsAadOrApiKey
{
    /// <summary>
    /// AadAuthFailureMode: Describes what response the data plane API of a search service would send for requests that failed
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadAuthFailureMode")]
    public V1api20231101SearchServiceSpecAuthOptionsAadOrApiKeyAadAuthFailureModeEnum? AadAuthFailureMode { get; set; }
}

/// <summary>
/// AuthOptions: Defines the options for how the data plane API of a search service authenticates requests. This cannot be
/// set if &apos;disableLocalAuth&apos; is set to true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecAuthOptions
{
    /// <summary>
    /// AadOrApiKey: Indicates that either the API key or an access token from a Microsoft Entra ID tenant can be used for
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadOrApiKey")]
    public V1api20231101SearchServiceSpecAuthOptionsAadOrApiKey? AadOrApiKey { get; set; }
}

/// <summary>Enforcement: Describes how a search service should enforce having one or more non-customer-encrypted resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecEncryptionWithCmkEnforcementEnum>))]
public enum V1api20231101SearchServiceSpecEncryptionWithCmkEnforcementEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Unspecified"), JsonStringEnumMemberName("Unspecified")]
    Unspecified
}

/// <summary>
/// EncryptionWithCmk: Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys
/// within a search service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecEncryptionWithCmk
{
    /// <summary>Enforcement: Describes how a search service should enforce having one or more non-customer-encrypted resources.</summary>
    [JsonPropertyName("enforcement")]
    public V1api20231101SearchServiceSpecEncryptionWithCmkEnforcementEnum? Enforcement { get; set; }
}

/// <summary>
/// HostingMode: Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions
/// that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the
/// standard3 SKU, the value is either &apos;default&apos; or &apos;highDensity&apos;. For all other SKUs, this value must be &apos;default&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecHostingModeEnum>))]
public enum V1api20231101SearchServiceSpecHostingModeEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "highDensity"), JsonStringEnumMemberName("highDensity")]
    HighDensity
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecIdentityTypeEnum>))]
public enum V1api20231101SearchServiceSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public required V1api20231101SearchServiceSpecIdentityTypeEnum Type { get; set; }
}

/// <summary>The IP restriction rule of the search service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecNetworkRuleSetIpRules
{
    /// <summary>
    /// Value: Value corresponding to a single IPv4 address (for example, 123.1.2.3) or an IP range in CIDR format (for example,
    /// 123.1.2.3/24) to be allowed.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>NetworkRuleSet: Network-specific rules that determine how the search service may be reached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecNetworkRuleSet
{
    /// <summary>
    /// IpRules: A list of IP restriction rules used for an IP firewall. Any IPs that do not match the rules are blocked by the
    /// firewall. These rules are only applied when the &apos;publicNetworkAccess&apos; of the search service is &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20231101SearchServiceSpecNetworkRuleSetIpRules>? IpRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecConfigMapExpressions
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
/// IdentityPrincipalId: indicates where the IdentityPrincipalId config map should be placed. If omitted, no config map will
/// be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecConfigMapsIdentityPrincipalId
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// IdentityTenantId: indicates where the IdentityTenantId config map should be placed. If omitted, no config map will be
/// created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecConfigMapsIdentityTenantId
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// IdentityPrincipalId: indicates where the IdentityPrincipalId config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("identityPrincipalId")]
    public V1api20231101SearchServiceSpecOperatorSpecConfigMapsIdentityPrincipalId? IdentityPrincipalId { get; set; }

    /// <summary>
    /// IdentityTenantId: indicates where the IdentityTenantId config map should be placed. If omitted, no config map will be
    /// created.
    /// </summary>
    [JsonPropertyName("identityTenantId")]
    public V1api20231101SearchServiceSpecOperatorSpecConfigMapsIdentityTenantId? IdentityTenantId { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecSecretExpressions
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
/// AdminPrimaryKey: indicates where the AdminPrimaryKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecSecretsAdminPrimaryKey
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
/// AdminSecondaryKey: indicates where the AdminSecondaryKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecSecretsAdminSecondaryKey
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

/// <summary>QueryKey: indicates where the QueryKey secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecSecretsQueryKey
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpecSecrets
{
    /// <summary>
    /// AdminPrimaryKey: indicates where the AdminPrimaryKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("adminPrimaryKey")]
    public V1api20231101SearchServiceSpecOperatorSpecSecretsAdminPrimaryKey? AdminPrimaryKey { get; set; }

    /// <summary>
    /// AdminSecondaryKey: indicates where the AdminSecondaryKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("adminSecondaryKey")]
    public V1api20231101SearchServiceSpecOperatorSpecSecretsAdminSecondaryKey? AdminSecondaryKey { get; set; }

    /// <summary>QueryKey: indicates where the QueryKey secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("queryKey")]
    public V1api20231101SearchServiceSpecOperatorSpecSecretsQueryKey? QueryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231101SearchServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20231101SearchServiceSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231101SearchServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20231101SearchServiceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PublicNetworkAccess: This value can be set to &apos;enabled&apos; to avoid breaking changes on existing customer resources and
/// templates. If set to &apos;disabled&apos;, traffic over public interface is not allowed, and private endpoint connections would be
/// the exclusive access method.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecPublicNetworkAccessEnum>))]
public enum V1api20231101SearchServiceSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>
/// SemanticSearch: Sets options that control the availability of semantic search. This configuration is only possible for
/// certain search SKUs in certain locations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecSemanticSearchEnum>))]
public enum V1api20231101SearchServiceSpecSemanticSearchEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "free"), JsonStringEnumMemberName("free")]
    Free,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard
}

/// <summary>
/// Name: The SKU of the search service. Valid values include: &apos;free&apos;: Shared service. &apos;basic&apos;: Dedicated service with up to
/// 3 replicas. &apos;standard&apos;: Dedicated service with up to 12 partitions and 12 replicas. &apos;standard2&apos;: Similar to standard,
/// but with more capacity per search unit. &apos;standard3&apos;: The largest Standard offering with up to 12 partitions and 12
/// replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to &apos;highDensity&apos;).
/// &apos;storage_optimized_l1&apos;: Supports 1TB per partition, up to 12 partitions. &apos;storage_optimized_l2&apos;: Supports 2TB per
/// partition, up to 12 partitions.&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231101SearchServiceSpecSkuNameEnum>))]
public enum V1api20231101SearchServiceSpecSkuNameEnum
{
    [EnumMember(Value = "basic"), JsonStringEnumMemberName("basic")]
    Basic,
    [EnumMember(Value = "free"), JsonStringEnumMemberName("free")]
    Free,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard,
    [EnumMember(Value = "standard2"), JsonStringEnumMemberName("standard2")]
    Standard2,
    [EnumMember(Value = "standard3"), JsonStringEnumMemberName("standard3")]
    Standard3,
    [EnumMember(Value = "storage_optimized_l1"), JsonStringEnumMemberName("storage_optimized_l1")]
    StorageOptimizedL1,
    [EnumMember(Value = "storage_optimized_l2"), JsonStringEnumMemberName("storage_optimized_l2")]
    StorageOptimizedL2
}

/// <summary>
/// Sku: The SKU of the search service, which determines billing rate and capacity limits. This property is required when
/// creating a new search service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpecSku
{
    /// <summary>
    /// Name: The SKU of the search service. Valid values include: &apos;free&apos;: Shared service. &apos;basic&apos;: Dedicated service with up to
    /// 3 replicas. &apos;standard&apos;: Dedicated service with up to 12 partitions and 12 replicas. &apos;standard2&apos;: Similar to standard,
    /// but with more capacity per search unit. &apos;standard3&apos;: The largest Standard offering with up to 12 partitions and 12
    /// replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to &apos;highDensity&apos;).
    /// &apos;storage_optimized_l1&apos;: Supports 1TB per partition, up to 12 partitions. &apos;storage_optimized_l2&apos;: Supports 2TB per
    /// partition, up to 12 partitions.&apos;
    /// </summary>
    [JsonPropertyName("name")]
    public V1api20231101SearchServiceSpecSkuNameEnum? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceSpec
{
    /// <summary>
    /// AuthOptions: Defines the options for how the data plane API of a search service authenticates requests. This cannot be
    /// set if &apos;disableLocalAuth&apos; is set to true.
    /// </summary>
    [JsonPropertyName("authOptions")]
    public V1api20231101SearchServiceSpecAuthOptions? AuthOptions { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// DisableLocalAuth: When set to true, calls to the search service will not be permitted to utilize API keys for
    /// authentication. This cannot be set to true if &apos;dataPlaneAuthOptions&apos; are defined.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// EncryptionWithCmk: Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys
    /// within a search service.
    /// </summary>
    [JsonPropertyName("encryptionWithCmk")]
    public V1api20231101SearchServiceSpecEncryptionWithCmk? EncryptionWithCmk { get; set; }

    /// <summary>
    /// HostingMode: Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions
    /// that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the
    /// standard3 SKU, the value is either &apos;default&apos; or &apos;highDensity&apos;. For all other SKUs, this value must be &apos;default&apos;.
    /// </summary>
    [JsonPropertyName("hostingMode")]
    public V1api20231101SearchServiceSpecHostingModeEnum? HostingMode { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20231101SearchServiceSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NetworkRuleSet: Network-specific rules that determine how the search service may be reached.</summary>
    [JsonPropertyName("networkRuleSet")]
    public V1api20231101SearchServiceSpecNetworkRuleSet? NetworkRuleSet { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101SearchServiceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231101SearchServiceSpecOwner Owner { get; set; }

    /// <summary>
    /// PartitionCount: The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values
    /// greater than 1 are only valid for standard SKUs. For &apos;standard3&apos; services with hostingMode set to &apos;highDensity&apos;, the
    /// allowed values are between 1 and 3.
    /// </summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    /// <summary>
    /// PublicNetworkAccess: This value can be set to &apos;enabled&apos; to avoid breaking changes on existing customer resources and
    /// templates. If set to &apos;disabled&apos;, traffic over public interface is not allowed, and private endpoint connections would be
    /// the exclusive access method.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20231101SearchServiceSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>
    /// ReplicaCount: The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive
    /// for standard SKUs or between 1 and 3 inclusive for basic SKU.
    /// </summary>
    [JsonPropertyName("replicaCount")]
    public int? ReplicaCount { get; set; }

    /// <summary>
    /// SemanticSearch: Sets options that control the availability of semantic search. This configuration is only possible for
    /// certain search SKUs in certain locations.
    /// </summary>
    [JsonPropertyName("semanticSearch")]
    public V1api20231101SearchServiceSpecSemanticSearchEnum? SemanticSearch { get; set; }

    /// <summary>
    /// Sku: The SKU of the search service, which determines billing rate and capacity limits. This property is required when
    /// creating a new search service.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20231101SearchServiceSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// AadOrApiKey: Indicates that either the API key or an access token from a Microsoft Entra ID tenant can be used for
/// authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusAuthOptionsAadOrApiKey
{
    /// <summary>
    /// AadAuthFailureMode: Describes what response the data plane API of a search service would send for requests that failed
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadAuthFailureMode")]
    public string? AadAuthFailureMode { get; set; }
}

/// <summary>
/// AuthOptions: Defines the options for how the data plane API of a search service authenticates requests. This cannot be
/// set if &apos;disableLocalAuth&apos; is set to true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusAuthOptions
{
    /// <summary>
    /// AadOrApiKey: Indicates that either the API key or an access token from a Microsoft Entra ID tenant can be used for
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadOrApiKey")]
    public V1api20231101SearchServiceStatusAuthOptionsAadOrApiKey? AadOrApiKey { get; set; }

    /// <summary>ApiKeyOnly: Indicates that only the API key can be used for authentication.</summary>
    [JsonPropertyName("apiKeyOnly")]
    public IDictionary<string, JsonNode>? ApiKeyOnly { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusConditions
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
/// EncryptionWithCmk: Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys
/// within a search service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusEncryptionWithCmk
{
    /// <summary>
    /// EncryptionComplianceStatus: Describes whether the search service is compliant or not with respect to having
    /// non-customer-encrypted resources. If a service has more than one non-customer-encrypted resource and &apos;Enforcement&apos; is
    /// &apos;enabled&apos; then the service will be marked as &apos;nonCompliant&apos;.
    /// </summary>
    [JsonPropertyName("encryptionComplianceStatus")]
    public string? EncryptionComplianceStatus { get; set; }

    /// <summary>Enforcement: Describes how a search service should enforce having one or more non-customer-encrypted resources.</summary>
    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of the system-assigned identity of the search service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of the system-assigned identity of the search service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The IP restriction rule of the search service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusNetworkRuleSetIpRules
{
    /// <summary>
    /// Value: Value corresponding to a single IPv4 address (for example, 123.1.2.3) or an IP range in CIDR format (for example,
    /// 123.1.2.3/24) to be allowed.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>NetworkRuleSet: Network-specific rules that determine how the search service may be reached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusNetworkRuleSet
{
    /// <summary>
    /// IpRules: A list of IP restriction rules used for an IP firewall. Any IPs that do not match the rules are blocked by the
    /// firewall. These rules are only applied when the &apos;publicNetworkAccess&apos; of the search service is &apos;enabled&apos;.
    /// </summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20231101SearchServiceStatusNetworkRuleSetIpRules>? IpRules { get; set; }
}

/// <summary>Describes an existing private endpoint connection to the search service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a Shared Private Link Resource managed by the search service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusSharedPrivateLinkResources
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Sku: The SKU of the search service, which determines billing rate and capacity limits. This property is required when
/// creating a new search service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatusSku
{
    /// <summary>
    /// Name: The SKU of the search service. Valid values include: &apos;free&apos;: Shared service. &apos;basic&apos;: Dedicated service with up to
    /// 3 replicas. &apos;standard&apos;: Dedicated service with up to 12 partitions and 12 replicas. &apos;standard2&apos;: Similar to standard,
    /// but with more capacity per search unit. &apos;standard3&apos;: The largest Standard offering with up to 12 partitions and 12
    /// replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to &apos;highDensity&apos;).
    /// &apos;storage_optimized_l1&apos;: Supports 1TB per partition, up to 12 partitions. &apos;storage_optimized_l2&apos;: Supports 2TB per
    /// partition, up to 12 partitions.&apos;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Describes a search service and its current state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101SearchServiceStatus
{
    /// <summary>
    /// AuthOptions: Defines the options for how the data plane API of a search service authenticates requests. This cannot be
    /// set if &apos;disableLocalAuth&apos; is set to true.
    /// </summary>
    [JsonPropertyName("authOptions")]
    public V1api20231101SearchServiceStatusAuthOptions? AuthOptions { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101SearchServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DisableLocalAuth: When set to true, calls to the search service will not be permitted to utilize API keys for
    /// authentication. This cannot be set to true if &apos;dataPlaneAuthOptions&apos; are defined.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// EncryptionWithCmk: Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys
    /// within a search service.
    /// </summary>
    [JsonPropertyName("encryptionWithCmk")]
    public V1api20231101SearchServiceStatusEncryptionWithCmk? EncryptionWithCmk { get; set; }

    /// <summary>
    /// HostingMode: Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions
    /// that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the
    /// standard3 SKU, the value is either &apos;default&apos; or &apos;highDensity&apos;. For all other SKUs, this value must be &apos;default&apos;.
    /// </summary>
    [JsonPropertyName("hostingMode")]
    public string? HostingMode { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20231101SearchServiceStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkRuleSet: Network-specific rules that determine how the search service may be reached.</summary>
    [JsonPropertyName("networkRuleSet")]
    public V1api20231101SearchServiceStatusNetworkRuleSet? NetworkRuleSet { get; set; }

    /// <summary>
    /// PartitionCount: The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values
    /// greater than 1 are only valid for standard SKUs. For &apos;standard3&apos; services with hostingMode set to &apos;highDensity&apos;, the
    /// allowed values are between 1 and 3.
    /// </summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    /// <summary>PrivateEndpointConnections: The list of private endpoint connections to the search service.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20231101SearchServiceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>
    /// ProvisioningState: The state of the last provisioning operation performed on the search service. Provisioning is an
    /// intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState
    /// changes to either &apos;succeeded&apos; or &apos;failed&apos;. Client applications can poll provisioning status (the recommended polling
    /// interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is
    /// completed. If you are using the free service, this value tends to come back as &apos;succeeded&apos; directly in the call to
    /// Create search service. This is because the free service uses capacity that is already set up.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicNetworkAccess: This value can be set to &apos;enabled&apos; to avoid breaking changes on existing customer resources and
    /// templates. If set to &apos;disabled&apos;, traffic over public interface is not allowed, and private endpoint connections would be
    /// the exclusive access method.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// ReplicaCount: The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive
    /// for standard SKUs or between 1 and 3 inclusive for basic SKU.
    /// </summary>
    [JsonPropertyName("replicaCount")]
    public int? ReplicaCount { get; set; }

    /// <summary>
    /// SemanticSearch: Sets options that control the availability of semantic search. This configuration is only possible for
    /// certain search SKUs in certain locations.
    /// </summary>
    [JsonPropertyName("semanticSearch")]
    public string? SemanticSearch { get; set; }

    /// <summary>SharedPrivateLinkResources: The list of shared private link resources managed by the search service.</summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20231101SearchServiceStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>
    /// Sku: The SKU of the search service, which determines billing rate and capacity limits. This property is required when
    /// creating a new search service.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20231101SearchServiceStatusSku? Sku { get; set; }

    /// <summary>
    /// Status: The status of the search service. Possible values include: &apos;running&apos;: The search service is running and no
    /// provisioning operations are underway. &apos;provisioning&apos;: The search service is being provisioned or scaled up or down.
    /// &apos;deleting&apos;: The search service is being deleted. &apos;degraded&apos;: The search service is degraded. This can occur when the
    /// underlying search units are not healthy. The search service is most likely operational, but performance might be slow
    /// and some requests might be dropped. &apos;disabled&apos;: The search service is disabled. In this state, the service will reject
    /// all API requests. &apos;error&apos;: The search service is in an error state. If your service is in the degraded, disabled, or
    /// error states, Microsoft is actively investigating the underlying issue. Dedicated services in these states are still
    /// chargeable based on the number of search units provisioned.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>StatusDetails: The details of the search service status.</summary>
    [JsonPropertyName("statusDetails")]
    public string? StatusDetails { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /search/resource-manager/Microsoft.Search/Search/stable/2023-11-01/search.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101SearchService : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101SearchServiceSpec?>, IStatus<V1api20231101SearchServiceStatus?>
{
    public const string KubeApiVersion = "v1api20231101";
    public const string KubeKind = "SearchService";
    public const string KubeGroup = "search.azure.com";
    public const string KubePluralName = "searchservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "search.azure.com/v1api20231101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SearchService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231101SearchServiceSpec? Spec { get; set; }

    /// <summary>Describes a search service and its current state.</summary>
    [JsonPropertyName("status")]
    public V1api20231101SearchServiceStatus? Status { get; set; }
}