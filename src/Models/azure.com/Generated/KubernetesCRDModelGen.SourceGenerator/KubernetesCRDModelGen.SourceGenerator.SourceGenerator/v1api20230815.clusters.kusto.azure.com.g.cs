#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kusto.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/Kusto/stable/2023-08-15/kusto.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230815ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1api20230815Cluster>
{
    public const string KubeApiVersion = "v1api20230815";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.com/v1api20230815";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230815Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230815Cluster> Items { get; set; }
}

/// <summary>Represents an accepted audience trusted by the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecAcceptedAudiences
{
    /// <summary>Value: GUID or valid URL representing an accepted audience.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>EngineType: The engine type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecEngineTypeEnum>))]
public enum V1api20230815ClusterSpecEngineTypeEnum
{
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2,
    [EnumMember(Value = "V3"), JsonStringEnumMemberName("V3")]
    V3
}

/// <summary>
/// Type: The type of managed identity used. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created
/// identity and a set of user-assigned identities. The type &apos;None&apos; will remove all identities.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecIdentityTypeEnum>))]
public enum V1api20230815ClusterSpecIdentityTypeEnum
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
public partial class V1api20230815ClusterSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20230815ClusterSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230815ClusterSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecIdentity
{
    /// <summary>
    /// Type: The type of managed identity used. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created
    /// identity and a set of user-assigned identities. The type &apos;None&apos; will remove all identities.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1api20230815ClusterSpecIdentityTypeEnum Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Kusto cluster. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20230815ClusterSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>UserIdentityReference: The user assigned identity (ARM resource id) that has access to the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecKeyVaultPropertiesUserIdentityReference
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

/// <summary>KeyVaultProperties: KeyVault properties for the cluster encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecKeyVaultProperties
{
    /// <summary>KeyName: The name of the key vault key.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>KeyVaultUri: The Uri of the key vault.</summary>
    [JsonPropertyName("keyVaultUri")]
    public string? KeyVaultUri { get; set; }

    /// <summary>KeyVersion: The version of the key vault key.</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary>UserIdentityReference: The user assigned identity (ARM resource id) that has access to the key.</summary>
    [JsonPropertyName("userIdentityReference")]
    public V1api20230815ClusterSpecKeyVaultPropertiesUserIdentityReference? UserIdentityReference { get; set; }
}

/// <summary>LanguageExtensionImageName: The language extension image name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecLanguageExtensionsValueLanguageExtensionImageNameEnum>))]
public enum V1api20230815ClusterSpecLanguageExtensionsValueLanguageExtensionImageNameEnum
{
    [EnumMember(Value = "Python3_10_8"), JsonStringEnumMemberName("Python3_10_8")]
    Python3108,
    [EnumMember(Value = "Python3_10_8_DL"), JsonStringEnumMemberName("Python3_10_8_DL")]
    Python3108DL,
    [EnumMember(Value = "Python3_6_5"), JsonStringEnumMemberName("Python3_6_5")]
    Python365,
    [EnumMember(Value = "PythonCustomImage"), JsonStringEnumMemberName("PythonCustomImage")]
    PythonCustomImage,
    [EnumMember(Value = "R"), JsonStringEnumMemberName("R")]
    R
}

/// <summary>LanguageExtensionName: The language extension name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecLanguageExtensionsValueLanguageExtensionNameEnum>))]
public enum V1api20230815ClusterSpecLanguageExtensionsValueLanguageExtensionNameEnum
{
    [EnumMember(Value = "PYTHON"), JsonStringEnumMemberName("PYTHON")]
    PYTHON,
    [EnumMember(Value = "R"), JsonStringEnumMemberName("R")]
    R
}

/// <summary>The language extension object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecLanguageExtensionsValue
{
    /// <summary>LanguageExtensionCustomImageName: The language extension custom image name.</summary>
    [JsonPropertyName("languageExtensionCustomImageName")]
    public string? LanguageExtensionCustomImageName { get; set; }

    /// <summary>LanguageExtensionImageName: The language extension image name.</summary>
    [JsonPropertyName("languageExtensionImageName")]
    public V1api20230815ClusterSpecLanguageExtensionsValueLanguageExtensionImageNameEnum? LanguageExtensionImageName { get; set; }

    /// <summary>LanguageExtensionName: The language extension name.</summary>
    [JsonPropertyName("languageExtensionName")]
    public V1api20230815ClusterSpecLanguageExtensionsValueLanguageExtensionNameEnum? LanguageExtensionName { get; set; }
}

/// <summary>LanguageExtensions: List of the cluster&apos;s language extensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecLanguageExtensions
{
    /// <summary>Value: The list of language extensions.</summary>
    [JsonPropertyName("value")]
    public IList<V1api20230815ClusterSpecLanguageExtensionsValue>? Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230815ClusterSpecOperatorSpecSecretExpressions
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
public partial class V1api20230815ClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230815ClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230815ClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OptimizedAutoscale: Optimized auto scale definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecOptimizedAutoscale
{
    /// <summary>IsEnabled: A boolean value that indicate if the optimized autoscale feature is enabled or not.</summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    /// <summary>Maximum: Maximum allowed instances count.</summary>
    [JsonPropertyName("maximum")]
    public required int Maximum { get; set; }

    /// <summary>Minimum: Minimum allowed instances count.</summary>
    [JsonPropertyName("minimum")]
    public required int Minimum { get; set; }

    /// <summary>Version: The version of the template defined, for instance 1.</summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicIPType: Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecPublicIPTypeEnum>))]
public enum V1api20230815ClusterSpecPublicIPTypeEnum
{
    [EnumMember(Value = "DualStack"), JsonStringEnumMemberName("DualStack")]
    DualStack,
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4
}

/// <summary>
/// PublicNetworkAccess: Public network access to the cluster is enabled by default. When disabled, only private endpoint
/// connection to the cluster is allowed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecPublicNetworkAccessEnum>))]
public enum V1api20230815ClusterSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// RestrictOutboundNetworkAccess: Whether or not to restrict outbound network access.  Value is optional but if passed in,
/// must be &apos;Enabled&apos; or &apos;Disabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecRestrictOutboundNetworkAccessEnum>))]
public enum V1api20230815ClusterSpecRestrictOutboundNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Name: SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecSkuNameEnum>))]
public enum V1api20230815ClusterSpecSkuNameEnum
{
    [EnumMember(Value = "Dev(No SLA)_Standard_D11_v2"), JsonStringEnumMemberName("Dev(No SLA)_Standard_D11_v2")]
    DevNoSLAStandardD11V2,
    [EnumMember(Value = "Dev(No SLA)_Standard_E2a_v4"), JsonStringEnumMemberName("Dev(No SLA)_Standard_E2a_v4")]
    DevNoSLAStandardE2aV4,
    [EnumMember(Value = "Standard_D11_v2"), JsonStringEnumMemberName("Standard_D11_v2")]
    StandardD11V2,
    [EnumMember(Value = "Standard_D12_v2"), JsonStringEnumMemberName("Standard_D12_v2")]
    StandardD12V2,
    [EnumMember(Value = "Standard_D13_v2"), JsonStringEnumMemberName("Standard_D13_v2")]
    StandardD13V2,
    [EnumMember(Value = "Standard_D14_v2"), JsonStringEnumMemberName("Standard_D14_v2")]
    StandardD14V2,
    [EnumMember(Value = "Standard_D16d_v5"), JsonStringEnumMemberName("Standard_D16d_v5")]
    StandardD16dV5,
    [EnumMember(Value = "Standard_D32d_v4"), JsonStringEnumMemberName("Standard_D32d_v4")]
    StandardD32dV4,
    [EnumMember(Value = "Standard_D32d_v5"), JsonStringEnumMemberName("Standard_D32d_v5")]
    StandardD32dV5,
    [EnumMember(Value = "Standard_DS13_v2+1TB_PS"), JsonStringEnumMemberName("Standard_DS13_v2+1TB_PS")]
    StandardDS13V21TBPS,
    [EnumMember(Value = "Standard_DS13_v2+2TB_PS"), JsonStringEnumMemberName("Standard_DS13_v2+2TB_PS")]
    StandardDS13V22TBPS,
    [EnumMember(Value = "Standard_DS14_v2+3TB_PS"), JsonStringEnumMemberName("Standard_DS14_v2+3TB_PS")]
    StandardDS14V23TBPS,
    [EnumMember(Value = "Standard_DS14_v2+4TB_PS"), JsonStringEnumMemberName("Standard_DS14_v2+4TB_PS")]
    StandardDS14V24TBPS,
    [EnumMember(Value = "Standard_E16a_v4"), JsonStringEnumMemberName("Standard_E16a_v4")]
    StandardE16aV4,
    [EnumMember(Value = "Standard_E16ads_v5"), JsonStringEnumMemberName("Standard_E16ads_v5")]
    StandardE16adsV5,
    [EnumMember(Value = "Standard_E16as_v4+3TB_PS"), JsonStringEnumMemberName("Standard_E16as_v4+3TB_PS")]
    StandardE16asV43TBPS,
    [EnumMember(Value = "Standard_E16as_v4+4TB_PS"), JsonStringEnumMemberName("Standard_E16as_v4+4TB_PS")]
    StandardE16asV44TBPS,
    [EnumMember(Value = "Standard_E16as_v5+3TB_PS"), JsonStringEnumMemberName("Standard_E16as_v5+3TB_PS")]
    StandardE16asV53TBPS,
    [EnumMember(Value = "Standard_E16as_v5+4TB_PS"), JsonStringEnumMemberName("Standard_E16as_v5+4TB_PS")]
    StandardE16asV54TBPS,
    [EnumMember(Value = "Standard_E16d_v4"), JsonStringEnumMemberName("Standard_E16d_v4")]
    StandardE16dV4,
    [EnumMember(Value = "Standard_E16d_v5"), JsonStringEnumMemberName("Standard_E16d_v5")]
    StandardE16dV5,
    [EnumMember(Value = "Standard_E16s_v4+3TB_PS"), JsonStringEnumMemberName("Standard_E16s_v4+3TB_PS")]
    StandardE16sV43TBPS,
    [EnumMember(Value = "Standard_E16s_v4+4TB_PS"), JsonStringEnumMemberName("Standard_E16s_v4+4TB_PS")]
    StandardE16sV44TBPS,
    [EnumMember(Value = "Standard_E16s_v5+3TB_PS"), JsonStringEnumMemberName("Standard_E16s_v5+3TB_PS")]
    StandardE16sV53TBPS,
    [EnumMember(Value = "Standard_E16s_v5+4TB_PS"), JsonStringEnumMemberName("Standard_E16s_v5+4TB_PS")]
    StandardE16sV54TBPS,
    [EnumMember(Value = "Standard_E2a_v4"), JsonStringEnumMemberName("Standard_E2a_v4")]
    StandardE2aV4,
    [EnumMember(Value = "Standard_E2ads_v5"), JsonStringEnumMemberName("Standard_E2ads_v5")]
    StandardE2adsV5,
    [EnumMember(Value = "Standard_E2d_v4"), JsonStringEnumMemberName("Standard_E2d_v4")]
    StandardE2dV4,
    [EnumMember(Value = "Standard_E2d_v5"), JsonStringEnumMemberName("Standard_E2d_v5")]
    StandardE2dV5,
    [EnumMember(Value = "Standard_E4a_v4"), JsonStringEnumMemberName("Standard_E4a_v4")]
    StandardE4aV4,
    [EnumMember(Value = "Standard_E4ads_v5"), JsonStringEnumMemberName("Standard_E4ads_v5")]
    StandardE4adsV5,
    [EnumMember(Value = "Standard_E4d_v4"), JsonStringEnumMemberName("Standard_E4d_v4")]
    StandardE4dV4,
    [EnumMember(Value = "Standard_E4d_v5"), JsonStringEnumMemberName("Standard_E4d_v5")]
    StandardE4dV5,
    [EnumMember(Value = "Standard_E64i_v3"), JsonStringEnumMemberName("Standard_E64i_v3")]
    StandardE64iV3,
    [EnumMember(Value = "Standard_E80ids_v4"), JsonStringEnumMemberName("Standard_E80ids_v4")]
    StandardE80idsV4,
    [EnumMember(Value = "Standard_E8a_v4"), JsonStringEnumMemberName("Standard_E8a_v4")]
    StandardE8aV4,
    [EnumMember(Value = "Standard_E8ads_v5"), JsonStringEnumMemberName("Standard_E8ads_v5")]
    StandardE8adsV5,
    [EnumMember(Value = "Standard_E8as_v4+1TB_PS"), JsonStringEnumMemberName("Standard_E8as_v4+1TB_PS")]
    StandardE8asV41TBPS,
    [EnumMember(Value = "Standard_E8as_v4+2TB_PS"), JsonStringEnumMemberName("Standard_E8as_v4+2TB_PS")]
    StandardE8asV42TBPS,
    [EnumMember(Value = "Standard_E8as_v5+1TB_PS"), JsonStringEnumMemberName("Standard_E8as_v5+1TB_PS")]
    StandardE8asV51TBPS,
    [EnumMember(Value = "Standard_E8as_v5+2TB_PS"), JsonStringEnumMemberName("Standard_E8as_v5+2TB_PS")]
    StandardE8asV52TBPS,
    [EnumMember(Value = "Standard_E8d_v4"), JsonStringEnumMemberName("Standard_E8d_v4")]
    StandardE8dV4,
    [EnumMember(Value = "Standard_E8d_v5"), JsonStringEnumMemberName("Standard_E8d_v5")]
    StandardE8dV5,
    [EnumMember(Value = "Standard_E8s_v4+1TB_PS"), JsonStringEnumMemberName("Standard_E8s_v4+1TB_PS")]
    StandardE8sV41TBPS,
    [EnumMember(Value = "Standard_E8s_v4+2TB_PS"), JsonStringEnumMemberName("Standard_E8s_v4+2TB_PS")]
    StandardE8sV42TBPS,
    [EnumMember(Value = "Standard_E8s_v5+1TB_PS"), JsonStringEnumMemberName("Standard_E8s_v5+1TB_PS")]
    StandardE8sV51TBPS,
    [EnumMember(Value = "Standard_E8s_v5+2TB_PS"), JsonStringEnumMemberName("Standard_E8s_v5+2TB_PS")]
    StandardE8sV52TBPS,
    [EnumMember(Value = "Standard_EC16ads_v5"), JsonStringEnumMemberName("Standard_EC16ads_v5")]
    StandardEC16adsV5,
    [EnumMember(Value = "Standard_EC16as_v5+3TB_PS"), JsonStringEnumMemberName("Standard_EC16as_v5+3TB_PS")]
    StandardEC16asV53TBPS,
    [EnumMember(Value = "Standard_EC16as_v5+4TB_PS"), JsonStringEnumMemberName("Standard_EC16as_v5+4TB_PS")]
    StandardEC16asV54TBPS,
    [EnumMember(Value = "Standard_EC8ads_v5"), JsonStringEnumMemberName("Standard_EC8ads_v5")]
    StandardEC8adsV5,
    [EnumMember(Value = "Standard_EC8as_v5+1TB_PS"), JsonStringEnumMemberName("Standard_EC8as_v5+1TB_PS")]
    StandardEC8asV51TBPS,
    [EnumMember(Value = "Standard_EC8as_v5+2TB_PS"), JsonStringEnumMemberName("Standard_EC8as_v5+2TB_PS")]
    StandardEC8asV52TBPS,
    [EnumMember(Value = "Standard_L16as_v3"), JsonStringEnumMemberName("Standard_L16as_v3")]
    StandardL16asV3,
    [EnumMember(Value = "Standard_L16s"), JsonStringEnumMemberName("Standard_L16s")]
    StandardL16s,
    [EnumMember(Value = "Standard_L16s_v2"), JsonStringEnumMemberName("Standard_L16s_v2")]
    StandardL16sV2,
    [EnumMember(Value = "Standard_L16s_v3"), JsonStringEnumMemberName("Standard_L16s_v3")]
    StandardL16sV3,
    [EnumMember(Value = "Standard_L32as_v3"), JsonStringEnumMemberName("Standard_L32as_v3")]
    StandardL32asV3,
    [EnumMember(Value = "Standard_L32s_v3"), JsonStringEnumMemberName("Standard_L32s_v3")]
    StandardL32sV3,
    [EnumMember(Value = "Standard_L4s"), JsonStringEnumMemberName("Standard_L4s")]
    StandardL4s,
    [EnumMember(Value = "Standard_L8as_v3"), JsonStringEnumMemberName("Standard_L8as_v3")]
    StandardL8asV3,
    [EnumMember(Value = "Standard_L8s"), JsonStringEnumMemberName("Standard_L8s")]
    StandardL8s,
    [EnumMember(Value = "Standard_L8s_v2"), JsonStringEnumMemberName("Standard_L8s_v2")]
    StandardL8sV2,
    [EnumMember(Value = "Standard_L8s_v3"), JsonStringEnumMemberName("Standard_L8s_v3")]
    StandardL8sV3
}

/// <summary>Tier: SKU tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecSkuTierEnum>))]
public enum V1api20230815ClusterSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The SKU of the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecSku
{
    /// <summary>Capacity: The number of instances of the cluster.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: SKU name.</summary>
    [JsonPropertyName("name")]
    public required V1api20230815ClusterSpecSkuNameEnum Name { get; set; }

    /// <summary>Tier: SKU tier.</summary>
    [JsonPropertyName("tier")]
    public required V1api20230815ClusterSpecSkuTierEnum Tier { get; set; }
}

/// <summary>Represents a tenant ID that is trusted by the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecTrustedExternalTenants
{
    /// <summary>Value: GUID representing an external tenant.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>VirtualClusterGraduationProperties: Virtual Cluster graduation properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecVirtualClusterGraduationProperties
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DataManagementPublicIpReference: Data management&apos;s service public IP address resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecVirtualNetworkConfigurationDataManagementPublicIpReference
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

/// <summary>EnginePublicIpReference: Engine service&apos;s public IP address resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecVirtualNetworkConfigurationEnginePublicIpReference
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
/// State: When enabled, the cluster is deployed into the configured subnet, when disabled it will be removed from the
/// subnet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230815ClusterSpecVirtualNetworkConfigurationStateEnum>))]
public enum V1api20230815ClusterSpecVirtualNetworkConfigurationStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SubnetReference: The subnet resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecVirtualNetworkConfigurationSubnetReference
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

/// <summary>VirtualNetworkConfiguration: Virtual network definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpecVirtualNetworkConfiguration
{
    /// <summary>DataManagementPublicIpReference: Data management&apos;s service public IP address resource id.</summary>
    [JsonPropertyName("dataManagementPublicIpReference")]
    public required V1api20230815ClusterSpecVirtualNetworkConfigurationDataManagementPublicIpReference DataManagementPublicIpReference { get; set; }

    /// <summary>EnginePublicIpReference: Engine service&apos;s public IP address resource id.</summary>
    [JsonPropertyName("enginePublicIpReference")]
    public required V1api20230815ClusterSpecVirtualNetworkConfigurationEnginePublicIpReference EnginePublicIpReference { get; set; }

    /// <summary>
    /// State: When enabled, the cluster is deployed into the configured subnet, when disabled it will be removed from the
    /// subnet.
    /// </summary>
    [JsonPropertyName("state")]
    public V1api20230815ClusterSpecVirtualNetworkConfigurationStateEnum? State { get; set; }

    /// <summary>SubnetReference: The subnet resource id.</summary>
    [JsonPropertyName("subnetReference")]
    public required V1api20230815ClusterSpecVirtualNetworkConfigurationSubnetReference SubnetReference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterSpec
{
    /// <summary>AcceptedAudiences: The cluster&apos;s accepted audiences.</summary>
    [JsonPropertyName("acceptedAudiences")]
    public IList<V1api20230815ClusterSpecAcceptedAudiences>? AcceptedAudiences { get; set; }

    /// <summary>AllowedFqdnList: List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    /// <summary>AllowedIpRangeList: The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRangeList")]
    public IList<string>? AllowedIpRangeList { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// EnableAutoStop: A boolean value that indicates if the cluster could be automatically stopped (due to lack of data or no
    /// activity for many days).
    /// </summary>
    [JsonPropertyName("enableAutoStop")]
    public bool? EnableAutoStop { get; set; }

    /// <summary>EnableDiskEncryption: A boolean value that indicates if the cluster&apos;s disks are encrypted.</summary>
    [JsonPropertyName("enableDiskEncryption")]
    public bool? EnableDiskEncryption { get; set; }

    /// <summary>EnableDoubleEncryption: A boolean value that indicates if double encryption is enabled.</summary>
    [JsonPropertyName("enableDoubleEncryption")]
    public bool? EnableDoubleEncryption { get; set; }

    /// <summary>EnablePurge: A boolean value that indicates if the purge operations are enabled.</summary>
    [JsonPropertyName("enablePurge")]
    public bool? EnablePurge { get; set; }

    /// <summary>EnableStreamingIngest: A boolean value that indicates if the streaming ingest is enabled.</summary>
    [JsonPropertyName("enableStreamingIngest")]
    public bool? EnableStreamingIngest { get; set; }

    /// <summary>EngineType: The engine type</summary>
    [JsonPropertyName("engineType")]
    public V1api20230815ClusterSpecEngineTypeEnum? EngineType { get; set; }

    /// <summary>Identity: The identity of the cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20230815ClusterSpecIdentity? Identity { get; set; }

    /// <summary>KeyVaultProperties: KeyVault properties for the cluster encryption.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20230815ClusterSpecKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary>LanguageExtensions: List of the cluster&apos;s language extensions.</summary>
    [JsonPropertyName("languageExtensions")]
    public V1api20230815ClusterSpecLanguageExtensions? LanguageExtensions { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230815ClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OptimizedAutoscale: Optimized auto scale definition.</summary>
    [JsonPropertyName("optimizedAutoscale")]
    public V1api20230815ClusterSpecOptimizedAutoscale? OptimizedAutoscale { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230815ClusterSpecOwner Owner { get; set; }

    /// <summary>PublicIPType: Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6)</summary>
    [JsonPropertyName("publicIPType")]
    public V1api20230815ClusterSpecPublicIPTypeEnum? PublicIPType { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Public network access to the cluster is enabled by default. When disabled, only private endpoint
    /// connection to the cluster is allowed
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20230815ClusterSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RestrictOutboundNetworkAccess: Whether or not to restrict outbound network access.  Value is optional but if passed in,
    /// must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public V1api20230815ClusterSpecRestrictOutboundNetworkAccessEnum? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>Sku: The SKU of the cluster.</summary>
    [JsonPropertyName("sku")]
    public required V1api20230815ClusterSpecSku Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TrustedExternalTenants: The cluster&apos;s external tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<V1api20230815ClusterSpecTrustedExternalTenants>? TrustedExternalTenants { get; set; }

    /// <summary>VirtualClusterGraduationProperties: Virtual Cluster graduation properties</summary>
    [JsonPropertyName("virtualClusterGraduationProperties")]
    public V1api20230815ClusterSpecVirtualClusterGraduationProperties? VirtualClusterGraduationProperties { get; set; }

    /// <summary>VirtualNetworkConfiguration: Virtual network definition.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20230815ClusterSpecVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Zones: The availability zones of the cluster.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Represents an accepted audience trusted by the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusAcceptedAudiences
{
    /// <summary>Value: GUID or valid URL representing an accepted audience.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusConditions
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
public partial class V1api20230815ClusterStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of managed identity used. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly created
    /// identity and a set of user-assigned identities. The type &apos;None&apos; will remove all identities.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the Kusto cluster. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20230815ClusterStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyVaultProperties: KeyVault properties for the cluster encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusKeyVaultProperties
{
    /// <summary>KeyName: The name of the key vault key.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>KeyVaultUri: The Uri of the key vault.</summary>
    [JsonPropertyName("keyVaultUri")]
    public string? KeyVaultUri { get; set; }

    /// <summary>KeyVersion: The version of the key vault key.</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary>UserIdentity: The user assigned identity (ARM resource id) that has access to the key.</summary>
    [JsonPropertyName("userIdentity")]
    public string? UserIdentity { get; set; }
}

/// <summary>The language extension object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusLanguageExtensionsValue
{
    /// <summary>LanguageExtensionCustomImageName: The language extension custom image name.</summary>
    [JsonPropertyName("languageExtensionCustomImageName")]
    public string? LanguageExtensionCustomImageName { get; set; }

    /// <summary>LanguageExtensionImageName: The language extension image name.</summary>
    [JsonPropertyName("languageExtensionImageName")]
    public string? LanguageExtensionImageName { get; set; }

    /// <summary>LanguageExtensionName: The language extension name.</summary>
    [JsonPropertyName("languageExtensionName")]
    public string? LanguageExtensionName { get; set; }
}

/// <summary>LanguageExtensions: List of the cluster&apos;s language extensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusLanguageExtensions
{
    /// <summary>Value: The list of language extensions.</summary>
    [JsonPropertyName("value")]
    public IList<V1api20230815ClusterStatusLanguageExtensionsValue>? Value { get; set; }
}

/// <summary>MigrationCluster: Properties of the peer cluster involved in a migration to/from this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusMigrationCluster
{
    /// <summary>DataIngestionUri: The public data ingestion URL of the cluster.</summary>
    [JsonPropertyName("dataIngestionUri")]
    public string? DataIngestionUri { get; set; }

    /// <summary>Id: The resource ID of the cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Role: The role of the cluster in the migration process.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Uri: The public URL of the cluster.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>OptimizedAutoscale: Optimized auto scale definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusOptimizedAutoscale
{
    /// <summary>IsEnabled: A boolean value that indicate if the optimized autoscale feature is enabled or not.</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>Maximum: Maximum allowed instances count.</summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary>Minimum: Minimum allowed instances count.</summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary>Version: The version of the template defined, for instance 1.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>A private endpoint connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The SKU of the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusSku
{
    /// <summary>Capacity: The number of instances of the cluster.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: SKU name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: SKU tier.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusSystemData
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

/// <summary>Represents a tenant ID that is trusted by the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusTrustedExternalTenants
{
    /// <summary>Value: GUID representing an external tenant.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>VirtualNetworkConfiguration: Virtual network definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatusVirtualNetworkConfiguration
{
    /// <summary>DataManagementPublicIpId: Data management&apos;s service public IP address resource id.</summary>
    [JsonPropertyName("dataManagementPublicIpId")]
    public string? DataManagementPublicIpId { get; set; }

    /// <summary>EnginePublicIpId: Engine service&apos;s public IP address resource id.</summary>
    [JsonPropertyName("enginePublicIpId")]
    public string? EnginePublicIpId { get; set; }

    /// <summary>
    /// State: When enabled, the cluster is deployed into the configured subnet, when disabled it will be removed from the
    /// subnet.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>SubnetId: The subnet resource id.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>Class representing a Kusto cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230815ClusterStatus
{
    /// <summary>AcceptedAudiences: The cluster&apos;s accepted audiences.</summary>
    [JsonPropertyName("acceptedAudiences")]
    public IList<V1api20230815ClusterStatusAcceptedAudiences>? AcceptedAudiences { get; set; }

    /// <summary>AllowedFqdnList: List of allowed FQDNs(Fully Qualified Domain Name) for egress from Cluster.</summary>
    [JsonPropertyName("allowedFqdnList")]
    public IList<string>? AllowedFqdnList { get; set; }

    /// <summary>AllowedIpRangeList: The list of ips in the format of CIDR allowed to connect to the cluster.</summary>
    [JsonPropertyName("allowedIpRangeList")]
    public IList<string>? AllowedIpRangeList { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230815ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>DataIngestionUri: The cluster data ingestion URI.</summary>
    [JsonPropertyName("dataIngestionUri")]
    public string? DataIngestionUri { get; set; }

    /// <summary>
    /// EnableAutoStop: A boolean value that indicates if the cluster could be automatically stopped (due to lack of data or no
    /// activity for many days).
    /// </summary>
    [JsonPropertyName("enableAutoStop")]
    public bool? EnableAutoStop { get; set; }

    /// <summary>EnableDiskEncryption: A boolean value that indicates if the cluster&apos;s disks are encrypted.</summary>
    [JsonPropertyName("enableDiskEncryption")]
    public bool? EnableDiskEncryption { get; set; }

    /// <summary>EnableDoubleEncryption: A boolean value that indicates if double encryption is enabled.</summary>
    [JsonPropertyName("enableDoubleEncryption")]
    public bool? EnableDoubleEncryption { get; set; }

    /// <summary>EnablePurge: A boolean value that indicates if the purge operations are enabled.</summary>
    [JsonPropertyName("enablePurge")]
    public bool? EnablePurge { get; set; }

    /// <summary>EnableStreamingIngest: A boolean value that indicates if the streaming ingest is enabled.</summary>
    [JsonPropertyName("enableStreamingIngest")]
    public bool? EnableStreamingIngest { get; set; }

    /// <summary>EngineType: The engine type</summary>
    [JsonPropertyName("engineType")]
    public string? EngineType { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20230815ClusterStatusIdentity? Identity { get; set; }

    /// <summary>KeyVaultProperties: KeyVault properties for the cluster encryption.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20230815ClusterStatusKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary>LanguageExtensions: List of the cluster&apos;s language extensions.</summary>
    [JsonPropertyName("languageExtensions")]
    public V1api20230815ClusterStatusLanguageExtensions? LanguageExtensions { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MigrationCluster: Properties of the peer cluster involved in a migration to/from this cluster.</summary>
    [JsonPropertyName("migrationCluster")]
    public V1api20230815ClusterStatusMigrationCluster? MigrationCluster { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OptimizedAutoscale: Optimized auto scale definition.</summary>
    [JsonPropertyName("optimizedAutoscale")]
    public V1api20230815ClusterStatusOptimizedAutoscale? OptimizedAutoscale { get; set; }

    /// <summary>PrivateEndpointConnections: A list of private endpoint connections.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230815ClusterStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicIPType: Indicates what public IP type to create - IPv4 (default), or DualStack (both IPv4 and IPv6)</summary>
    [JsonPropertyName("publicIPType")]
    public string? PublicIPType { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Public network access to the cluster is enabled by default. When disabled, only private endpoint
    /// connection to the cluster is allowed
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// RestrictOutboundNetworkAccess: Whether or not to restrict outbound network access.  Value is optional but if passed in,
    /// must be &apos;Enabled&apos; or &apos;Disabled&apos;
    /// </summary>
    [JsonPropertyName("restrictOutboundNetworkAccess")]
    public string? RestrictOutboundNetworkAccess { get; set; }

    /// <summary>Sku: The SKU of the cluster.</summary>
    [JsonPropertyName("sku")]
    public V1api20230815ClusterStatusSku? Sku { get; set; }

    /// <summary>State: The state of the resource.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>StateReason: The reason for the cluster&apos;s current state.</summary>
    [JsonPropertyName("stateReason")]
    public string? StateReason { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230815ClusterStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TrustedExternalTenants: The cluster&apos;s external tenants.</summary>
    [JsonPropertyName("trustedExternalTenants")]
    public IList<V1api20230815ClusterStatusTrustedExternalTenants>? TrustedExternalTenants { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Uri: The cluster URI.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>VirtualNetworkConfiguration: Virtual network definition.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20230815ClusterStatusVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Zones: The availability zones of the cluster.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/Kusto/stable/2023-08-15/kusto.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230815Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230815ClusterSpec?>, IStatus<V1api20230815ClusterStatus?>
{
    public const string KubeApiVersion = "v1api20230815";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.com/v1api20230815";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230815ClusterSpec? Spec { get; set; }

    /// <summary>Class representing a Kusto cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20230815ClusterStatus? Status { get; set; }
}