#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notificationhubs.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /notificationhubs/resource-manager/Microsoft.NotificationHubs/NotificationHubs/stable/2023-09-01/notificationhubs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230901NamespaceList : IKubernetesObject<V1ListMeta>, IItems<V1api20230901Namespace>
{
    public const string KubeApiVersion = "v1api20230901";
    public const string KubeKind = "NamespaceList";
    public const string KubeGroup = "notificationhubs.azure.com";
    public const string KubePluralName = "namespaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notificationhubs.azure.com/v1api20230901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230901Namespace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230901Namespace> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecConfigMapExpressions
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
/// ServiceBusEndpoint: indicates where the ServiceBusEndpoint config map should be placed. If omitted, no config map will
/// be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecConfigMapsServiceBusEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// ServiceBusEndpoint: indicates where the ServiceBusEndpoint config map should be placed. If omitted, no config map will
    /// be created.
    /// </summary>
    [JsonPropertyName("serviceBusEndpoint")]
    public V1api20230901NamespaceSpecOperatorSpecConfigMapsServiceBusEndpoint? ServiceBusEndpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecSecretExpressions
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
/// PrimaryConnectionString: indicates where the PrimaryConnectionString secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecSecretsPrimaryConnectionString
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
/// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
/// Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecSecretsPrimaryKey
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
/// SecondaryConnectionString: indicates where the SecondaryConnectionString secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecSecretsSecondaryConnectionString
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
/// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpecSecretsSecondaryKey
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
public partial class V1api20230901NamespaceSpecOperatorSpecSecrets
{
    /// <summary>
    /// PrimaryConnectionString: indicates where the PrimaryConnectionString secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20230901NamespaceSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>
    /// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20230901NamespaceSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecondaryConnectionString: indicates where the SecondaryConnectionString secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20230901NamespaceSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>
    /// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20230901NamespaceSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230901NamespaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20230901NamespaceSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230901NamespaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20230901NamespaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>NamespaceType: Defines values for NamespaceType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecPropertiesNamespaceTypeEnum>))]
public enum V1api20230901NamespaceSpecPropertiesNamespaceTypeEnum
{
    [EnumMember(Value = "Messaging"), JsonStringEnumMemberName("Messaging")]
    Messaging,
    [EnumMember(Value = "NotificationHub"), JsonStringEnumMemberName("NotificationHub")]
    NotificationHub
}

/// <summary>Defines values for AccessRights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecPropertiesNetworkAclsIpRulesRightsEnum>))]
public enum V1api20230901NamespaceSpecPropertiesNetworkAclsIpRulesRightsEnum
{
    [EnumMember(Value = "Listen"), JsonStringEnumMemberName("Listen")]
    Listen,
    [EnumMember(Value = "Manage"), JsonStringEnumMemberName("Manage")]
    Manage,
    [EnumMember(Value = "Send"), JsonStringEnumMemberName("Send")]
    Send
}

/// <summary>A network authorization rule that filters traffic based on IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesNetworkAclsIpRules
{
    /// <summary>IpMask: IP mask.</summary>
    [JsonPropertyName("ipMask")]
    public required string IpMask { get; set; }

    /// <summary>Rights: List of access rights.</summary>
    [JsonPropertyName("rights")]
    public required IList<V1api20230901NamespaceSpecPropertiesNetworkAclsIpRulesRightsEnum> Rights { get; set; }
}

/// <summary>Defines values for AccessRights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecPropertiesNetworkAclsPublicNetworkRuleRightsEnum>))]
public enum V1api20230901NamespaceSpecPropertiesNetworkAclsPublicNetworkRuleRightsEnum
{
    [EnumMember(Value = "Listen"), JsonStringEnumMemberName("Listen")]
    Listen,
    [EnumMember(Value = "Manage"), JsonStringEnumMemberName("Manage")]
    Manage,
    [EnumMember(Value = "Send"), JsonStringEnumMemberName("Send")]
    Send
}

/// <summary>
/// PublicNetworkRule: A default (public Internet) network authorization rule, which contains rights if no other network
/// rule matches.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesNetworkAclsPublicNetworkRule
{
    /// <summary>Rights: List of access rights.</summary>
    [JsonPropertyName("rights")]
    public required IList<V1api20230901NamespaceSpecPropertiesNetworkAclsPublicNetworkRuleRightsEnum> Rights { get; set; }
}

/// <summary>NetworkAcls: A collection of network authorization rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesNetworkAcls
{
    /// <summary>IpRules: List of IP rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20230901NamespaceSpecPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>
    /// PublicNetworkRule: A default (public Internet) network authorization rule, which contains rights if no other network
    /// rule matches.
    /// </summary>
    [JsonPropertyName("publicNetworkRule")]
    public V1api20230901NamespaceSpecPropertiesNetworkAclsPublicNetworkRule? PublicNetworkRule { get; set; }
}

/// <summary>AuthTokenUrl: Gets or sets the URL of the authorization token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesAuthTokenUrl
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

/// <summary>ClientId: Gets or sets the client identifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientId
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

/// <summary>ClientSecret: Gets or sets the credential secret access key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientSecret
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

/// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialProperties
{
    /// <summary>AuthTokenUrl: Gets or sets the URL of the authorization token.</summary>
    [JsonPropertyName("authTokenUrl")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesAuthTokenUrl AuthTokenUrl { get; set; }

    /// <summary>ClientId: Gets or sets the client identifier.</summary>
    [JsonPropertyName("clientId")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientId ClientId { get; set; }

    /// <summary>ClientSecret: Gets or sets the credential secret access key.</summary>
    [JsonPropertyName("clientSecret")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialPropertiesClientSecret ClientSecret { get; set; }
}

/// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredential
{
    /// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredentialProperties Properties { get; set; }
}

/// <summary>ApnsCertificate: Gets or sets the APNS certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesApnsCertificate
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

/// <summary>
/// AppId: Gets or sets the issuer (iss) registered claim key, whose value is
/// your 10-character Team ID, obtained from your developer account
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppId
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

/// <summary>AppName: Gets or sets the name of the application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppName
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

/// <summary>CertificateKey: Gets or sets the certificate key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesCertificateKey
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

/// <summary>Endpoint: Gets or sets the endpoint of this credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesEndpoint
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

/// <summary>
/// KeyId: Gets or sets a 10-character key identifier (kid) key, obtained from
/// your developer account
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesKeyId
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

/// <summary>Thumbprint: Gets or sets the APNS certificate Thumbprint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesThumbprint
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

/// <summary>
/// Token: Gets or sets provider Authentication Token, obtained through your
/// developer account
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesToken
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

/// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialProperties
{
    /// <summary>ApnsCertificate: Gets or sets the APNS certificate.</summary>
    [JsonPropertyName("apnsCertificate")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesApnsCertificate? ApnsCertificate { get; set; }

    /// <summary>
    /// AppId: Gets or sets the issuer (iss) registered claim key, whose value is
    /// your 10-character Team ID, obtained from your developer account
    /// </summary>
    [JsonPropertyName("appId")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppId? AppId { get; set; }

    /// <summary>AppName: Gets or sets the name of the application</summary>
    [JsonPropertyName("appName")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesAppName? AppName { get; set; }

    /// <summary>CertificateKey: Gets or sets the certificate key.</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>Endpoint: Gets or sets the endpoint of this credential.</summary>
    [JsonPropertyName("endpoint")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesEndpoint Endpoint { get; set; }

    /// <summary>
    /// KeyId: Gets or sets a 10-character key identifier (kid) key, obtained from
    /// your developer account
    /// </summary>
    [JsonPropertyName("keyId")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesKeyId? KeyId { get; set; }

    /// <summary>Thumbprint: Gets or sets the APNS certificate Thumbprint</summary>
    [JsonPropertyName("thumbprint")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesThumbprint? Thumbprint { get; set; }

    /// <summary>
    /// Token: Gets or sets provider Authentication Token, obtained through your
    /// developer account
    /// </summary>
    [JsonPropertyName("token")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialPropertiesToken? Token { get; set; }
}

/// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredential
{
    /// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredentialProperties Properties { get; set; }
}

/// <summary>BaiduApiKey: Gets or sets baidu Api Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduApiKey
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

/// <summary>BaiduEndPoint: Gets or sets baidu Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduEndPoint
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

/// <summary>BaiduSecretKey: Gets or sets baidu Secret Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduSecretKey
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

/// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialProperties
{
    /// <summary>BaiduApiKey: Gets or sets baidu Api Key.</summary>
    [JsonPropertyName("baiduApiKey")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduApiKey BaiduApiKey { get; set; }

    /// <summary>BaiduEndPoint: Gets or sets baidu Endpoint.</summary>
    [JsonPropertyName("baiduEndPoint")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduEndPoint BaiduEndPoint { get; set; }

    /// <summary>BaiduSecretKey: Gets or sets baidu Secret Key</summary>
    [JsonPropertyName("baiduSecretKey")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialPropertiesBaiduSecretKey BaiduSecretKey { get; set; }
}

/// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredential
{
    /// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredentialProperties Properties { get; set; }
}

/// <summary>Subject: Gets or sets web push subject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesSubject
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

/// <summary>VapidPrivateKey: Gets or sets VAPID private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPrivateKey
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

/// <summary>VapidPublicKey: Gets or sets VAPID public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPublicKey
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

/// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialProperties
{
    /// <summary>Subject: Gets or sets web push subject.</summary>
    [JsonPropertyName("subject")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesSubject Subject { get; set; }

    /// <summary>VapidPrivateKey: Gets or sets VAPID private key.</summary>
    [JsonPropertyName("vapidPrivateKey")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPrivateKey VapidPrivateKey { get; set; }

    /// <summary>VapidPublicKey: Gets or sets VAPID public key.</summary>
    [JsonPropertyName("vapidPublicKey")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialPropertiesVapidPublicKey VapidPublicKey { get; set; }
}

/// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredential
{
    /// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredentialProperties Properties { get; set; }
}

/// <summary>GcmEndpoint: Gets or sets the GCM endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGcmEndpoint
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

/// <summary>GoogleApiKey: Gets or sets the Google API key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGoogleApiKey
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

/// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredentialProperties
{
    /// <summary>GcmEndpoint: Gets or sets the GCM endpoint.</summary>
    [JsonPropertyName("gcmEndpoint")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGcmEndpoint? GcmEndpoint { get; set; }

    /// <summary>GoogleApiKey: Gets or sets the Google API key.</summary>
    [JsonPropertyName("googleApiKey")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredentialPropertiesGoogleApiKey GoogleApiKey { get; set; }
}

/// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredential
{
    /// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredentialProperties Properties { get; set; }
}

/// <summary>CertificateKey: Gets or sets the certificate key for this credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesCertificateKey
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

/// <summary>MpnsCertificate: Gets or sets the MPNS certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesMpnsCertificate
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

/// <summary>Thumbprint: Gets or sets the MPNS certificate Thumbprint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesThumbprint
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

/// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialProperties
{
    /// <summary>CertificateKey: Gets or sets the certificate key for this credential.</summary>
    [JsonPropertyName("certificateKey")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesCertificateKey CertificateKey { get; set; }

    /// <summary>MpnsCertificate: Gets or sets the MPNS certificate.</summary>
    [JsonPropertyName("mpnsCertificate")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesMpnsCertificate MpnsCertificate { get; set; }

    /// <summary>Thumbprint: Gets or sets the MPNS certificate Thumbprint</summary>
    [JsonPropertyName("thumbprint")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialPropertiesThumbprint Thumbprint { get; set; }
}

/// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredential
{
    /// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredentialProperties Properties { get; set; }
}

/// <summary>CertificateKey: Ges or sets the WNS Certificate Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesCertificateKey
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

/// <summary>PackageSid: Gets or sets the package ID for this credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesPackageSid
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

/// <summary>SecretKey: Gets or sets the secret key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesSecretKey
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

/// <summary>WindowsLiveEndpoint: Gets or sets the Windows Live endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWindowsLiveEndpoint
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

/// <summary>WnsCertificate: Gets or sets the WNS Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWnsCertificate
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

/// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialProperties
{
    /// <summary>CertificateKey: Ges or sets the WNS Certificate Key.</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>PackageSid: Gets or sets the package ID for this credential.</summary>
    [JsonPropertyName("packageSid")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesPackageSid? PackageSid { get; set; }

    /// <summary>SecretKey: Gets or sets the secret key.</summary>
    [JsonPropertyName("secretKey")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesSecretKey? SecretKey { get; set; }

    /// <summary>WindowsLiveEndpoint: Gets or sets the Windows Live endpoint.</summary>
    [JsonPropertyName("windowsLiveEndpoint")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWindowsLiveEndpoint? WindowsLiveEndpoint { get; set; }

    /// <summary>WnsCertificate: Gets or sets the WNS Certificate.</summary>
    [JsonPropertyName("wnsCertificate")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialPropertiesWnsCertificate? WnsCertificate { get; set; }
}

/// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredential
{
    /// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredentialProperties Properties { get; set; }
}

/// <summary>AppSecret: Gets or sets app secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesAppSecret
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

/// <summary>Endpoint: Gets or sets xiaomi service endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesEndpoint
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

/// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredentialProperties
{
    /// <summary>AppSecret: Gets or sets app secret.</summary>
    [JsonPropertyName("appSecret")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesAppSecret? AppSecret { get; set; }

    /// <summary>Endpoint: Gets or sets xiaomi service endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredentialPropertiesEndpoint? Endpoint { get; set; }
}

/// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredential
{
    /// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredentialProperties Properties { get; set; }
}

/// <summary>PnsCredentials: Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecPropertiesPnsCredentials
{
    /// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("admCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsAdmCredential? AdmCredential { get; set; }

    /// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsApnsCredential? ApnsCredential { get; set; }

    /// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("baiduCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsBaiduCredential? BaiduCredential { get; set; }

    /// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("browserCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsBrowserCredential? BrowserCredential { get; set; }

    /// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsGcmCredential? GcmCredential { get; set; }

    /// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("mpnsCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsMpnsCredential? MpnsCredential { get; set; }

    /// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("wnsCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsWnsCredential? WnsCredential { get; set; }

    /// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
    [JsonPropertyName("xiaomiCredential")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentialsXiaomiCredential? XiaomiCredential { get; set; }
}

/// <summary>PublicNetworkAccess: Type of public network access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecPropertiesPublicNetworkAccessEnum>))]
public enum V1api20230901NamespaceSpecPropertiesPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>ReplicationRegion: Allowed replication region</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecPropertiesReplicationRegionEnum>))]
public enum V1api20230901NamespaceSpecPropertiesReplicationRegionEnum
{
    [EnumMember(Value = "AustraliaEast"), JsonStringEnumMemberName("AustraliaEast")]
    AustraliaEast,
    [EnumMember(Value = "BrazilSouth"), JsonStringEnumMemberName("BrazilSouth")]
    BrazilSouth,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "NorthEurope"), JsonStringEnumMemberName("NorthEurope")]
    NorthEurope,
    [EnumMember(Value = "SouthAfricaNorth"), JsonStringEnumMemberName("SouthAfricaNorth")]
    SouthAfricaNorth,
    [EnumMember(Value = "SouthEastAsia"), JsonStringEnumMemberName("SouthEastAsia")]
    SouthEastAsia,
    [EnumMember(Value = "WestUs2"), JsonStringEnumMemberName("WestUs2")]
    WestUs2
}

/// <summary>ZoneRedundancy: Namespace SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecPropertiesZoneRedundancyEnum>))]
public enum V1api20230901NamespaceSpecPropertiesZoneRedundancyEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Properties: Represents namespace properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecProperties
{
    /// <summary>DataCenter: Deprecated.</summary>
    [JsonPropertyName("dataCenter")]
    public string? DataCenter { get; set; }

    /// <summary>NamespaceType: Defines values for NamespaceType.</summary>
    [JsonPropertyName("namespaceType")]
    public V1api20230901NamespaceSpecPropertiesNamespaceTypeEnum? NamespaceType { get; set; }

    /// <summary>NetworkAcls: A collection of network authorization rules.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230901NamespaceSpecPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary>PnsCredentials: Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
    [JsonPropertyName("pnsCredentials")]
    public V1api20230901NamespaceSpecPropertiesPnsCredentials? PnsCredentials { get; set; }

    /// <summary>PublicNetworkAccess: Type of public network access.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20230901NamespaceSpecPropertiesPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>ReplicationRegion: Allowed replication region</summary>
    [JsonPropertyName("replicationRegion")]
    public V1api20230901NamespaceSpecPropertiesReplicationRegionEnum? ReplicationRegion { get; set; }

    /// <summary>ScaleUnit: Gets or sets scaleUnit where the namespace gets created</summary>
    [JsonPropertyName("scaleUnit")]
    public string? ScaleUnit { get; set; }

    /// <summary>ZoneRedundancy: Namespace SKU name.</summary>
    [JsonPropertyName("zoneRedundancy")]
    public V1api20230901NamespaceSpecPropertiesZoneRedundancyEnum? ZoneRedundancy { get; set; }
}

/// <summary>Name: Namespace SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NamespaceSpecSkuNameEnum>))]
public enum V1api20230901NamespaceSpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The Sku description for a namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpecSku
{
    /// <summary>Capacity: Gets or sets the capacity of the resource</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Gets or sets the Sku Family</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: Namespace SKU name.</summary>
    [JsonPropertyName("name")]
    public required V1api20230901NamespaceSpecSkuNameEnum Name { get; set; }

    /// <summary>Size: Gets or sets the Sku size</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: Gets or sets the tier of particular sku</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230901NamespaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230901NamespaceSpecOwner Owner { get; set; }

    /// <summary>Properties: Represents namespace properties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceSpecProperties? Properties { get; set; }

    /// <summary>Sku: The Sku description for a namespace</summary>
    [JsonPropertyName("sku")]
    public required V1api20230901NamespaceSpecSku Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusConditions
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

/// <summary>A network authorization rule that filters traffic based on IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesNetworkAclsIpRules
{
    /// <summary>IpMask: IP mask.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>Rights: List of access rights.</summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>
/// PublicNetworkRule: A default (public Internet) network authorization rule, which contains rights if no other network
/// rule matches.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesNetworkAclsPublicNetworkRule
{
    /// <summary>Rights: List of access rights.</summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>NetworkAcls: A collection of network authorization rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesNetworkAcls
{
    /// <summary>IpRules: List of IP rules.</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20230901NamespaceStatusPropertiesNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>
    /// PublicNetworkRule: A default (public Internet) network authorization rule, which contains rights if no other network
    /// rule matches.
    /// </summary>
    [JsonPropertyName("publicNetworkRule")]
    public V1api20230901NamespaceStatusPropertiesNetworkAclsPublicNetworkRule? PublicNetworkRule { get; set; }
}

/// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsAdmCredentialProperties
{
}

/// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsAdmCredential
{
    /// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsAdmCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsApnsCredentialProperties
{
}

/// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsApnsCredential
{
    /// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsApnsCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsBaiduCredentialProperties
{
}

/// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsBaiduCredential
{
    /// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsBaiduCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsBrowserCredentialProperties
{
}

/// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsBrowserCredential
{
    /// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsBrowserCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsGcmCredentialProperties
{
}

/// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsGcmCredential
{
    /// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsGcmCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsMpnsCredentialProperties
{
}

/// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsMpnsCredential
{
    /// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsMpnsCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsWnsCredentialProperties
{
}

/// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsWnsCredential
{
    /// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsWnsCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsXiaomiCredentialProperties
{
}

/// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentialsXiaomiCredential
{
    /// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsXiaomiCredentialProperties? Properties { get; set; }
}

/// <summary>PnsCredentials: Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPnsCredentials
{
    /// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("admCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsAdmCredential? AdmCredential { get; set; }

    /// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsApnsCredential? ApnsCredential { get; set; }

    /// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("baiduCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsBaiduCredential? BaiduCredential { get; set; }

    /// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("browserCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsBrowserCredential? BrowserCredential { get; set; }

    /// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsGcmCredential? GcmCredential { get; set; }

    /// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("mpnsCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsMpnsCredential? MpnsCredential { get; set; }

    /// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("wnsCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsWnsCredential? WnsCredential { get; set; }

    /// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
    [JsonPropertyName("xiaomiCredential")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentialsXiaomiCredential? XiaomiCredential { get; set; }
}

/// <summary>Represents a Private Endpoint Connection ARM resource - a sub-resource of Notification Hubs namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusPropertiesPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Properties: Represents namespace properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusProperties
{
    /// <summary>CreatedAt: Time when the namespace was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Critical: Gets or sets whether or not the namespace is set as Critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>DataCenter: Deprecated.</summary>
    [JsonPropertyName("dataCenter")]
    public string? DataCenter { get; set; }

    /// <summary>Enabled: Gets or sets whether or not the namespace is currently enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>MetricId: Azure Insights Metrics id.</summary>
    [JsonPropertyName("metricId")]
    public string? MetricId { get; set; }

    /// <summary>
    /// Name: Name of the Notification Hubs namespace. This is immutable property, set automatically
    /// by the service when the namespace is created.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NamespaceType: Defines values for NamespaceType.</summary>
    [JsonPropertyName("namespaceType")]
    public string? NamespaceType { get; set; }

    /// <summary>NetworkAcls: A collection of network authorization rules.</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230901NamespaceStatusPropertiesNetworkAcls? NetworkAcls { get; set; }

    /// <summary>PnsCredentials: Collection of Notification Hub or Notification Hub Namespace PNS credentials.</summary>
    [JsonPropertyName("pnsCredentials")]
    public V1api20230901NamespaceStatusPropertiesPnsCredentials? PnsCredentials { get; set; }

    /// <summary>PrivateEndpointConnections: Private Endpoint Connections for namespace</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230901NamespaceStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Defines values for OperationProvisioningState.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Type of public network access.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Region: Region. The value is always set to the same value as Namespace.Location, so we are deprecating
    /// this property.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ReplicationRegion: Allowed replication region</summary>
    [JsonPropertyName("replicationRegion")]
    public string? ReplicationRegion { get; set; }

    /// <summary>ScaleUnit: Gets or sets scaleUnit where the namespace gets created</summary>
    [JsonPropertyName("scaleUnit")]
    public string? ScaleUnit { get; set; }

    /// <summary>
    /// ServiceBusEndpoint: Gets or sets endpoint you can use to perform NotificationHub
    /// operations.
    /// </summary>
    [JsonPropertyName("serviceBusEndpoint")]
    public string? ServiceBusEndpoint { get; set; }

    /// <summary>Status: Namespace status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SubscriptionId: Namespace subscription id.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>UpdatedAt: Time when the namespace was updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }

    /// <summary>ZoneRedundancy: Namespace SKU name.</summary>
    [JsonPropertyName("zoneRedundancy")]
    public string? ZoneRedundancy { get; set; }
}

/// <summary>Sku: The Sku description for a namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusSku
{
    /// <summary>Capacity: Gets or sets the capacity of the resource</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Gets or sets the Sku Family</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: Namespace SKU name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Gets or sets the Sku size</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: Gets or sets the tier of particular sku</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NamespaceStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230901NamespaceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Represents namespace properties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NamespaceStatusProperties? Properties { get; set; }

    /// <summary>Sku: The Sku description for a namespace</summary>
    [JsonPropertyName("sku")]
    public V1api20230901NamespaceStatusSku? Sku { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230901NamespaceStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /notificationhubs/resource-manager/Microsoft.NotificationHubs/NotificationHubs/stable/2023-09-01/notificationhubs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230901Namespace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230901NamespaceSpec?>, IStatus<V1api20230901NamespaceStatus?>
{
    public const string KubeApiVersion = "v1api20230901";
    public const string KubeKind = "Namespace";
    public const string KubeGroup = "notificationhubs.azure.com";
    public const string KubePluralName = "namespaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notificationhubs.azure.com/v1api20230901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Namespace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230901NamespaceSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230901NamespaceStatus? Status { get; set; }
}