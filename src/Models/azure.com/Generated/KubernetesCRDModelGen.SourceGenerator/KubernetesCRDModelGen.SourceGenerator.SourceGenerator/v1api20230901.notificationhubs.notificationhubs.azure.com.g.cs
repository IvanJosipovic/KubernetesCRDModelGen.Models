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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230901NotificationHubList : IKubernetesObject<V1ListMeta>, IItems<V1api20230901NotificationHub>
{
    public const string KubeApiVersion = "v1api20230901";
    public const string KubeKind = "NotificationHubList";
    public const string KubeGroup = "notificationhubs.azure.com";
    public const string KubePluralName = "notificationhubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notificationhubs.azure.com/v1api20230901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotificationHubList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230901NotificationHub objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230901NotificationHub> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230901NotificationHubSpecOperatorSpecSecretExpressions
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
public partial class V1api20230901NotificationHubSpecOperatorSpecSecretsPrimaryConnectionString
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
public partial class V1api20230901NotificationHubSpecOperatorSpecSecretsPrimaryKey
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
public partial class V1api20230901NotificationHubSpecOperatorSpecSecretsSecondaryConnectionString
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
public partial class V1api20230901NotificationHubSpecOperatorSpecSecretsSecondaryKey
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
public partial class V1api20230901NotificationHubSpecOperatorSpecSecrets
{
    /// <summary>
    /// PrimaryConnectionString: indicates where the PrimaryConnectionString secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20230901NotificationHubSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>
    /// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20230901NotificationHubSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecondaryConnectionString: indicates where the SecondaryConnectionString secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20230901NotificationHubSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>
    /// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20230901NotificationHubSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230901NotificationHubSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230901NotificationHubSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20230901NotificationHubSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a notificationhubs.azure.com/Namespace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>AuthTokenUrl: Gets or sets the URL of the authorization token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesAdmCredentialPropertiesAuthTokenUrl
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
public partial class V1api20230901NotificationHubSpecPropertiesAdmCredentialPropertiesClientId
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
public partial class V1api20230901NotificationHubSpecPropertiesAdmCredentialPropertiesClientSecret
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
public partial class V1api20230901NotificationHubSpecPropertiesAdmCredentialProperties
{
    /// <summary>AuthTokenUrl: Gets or sets the URL of the authorization token.</summary>
    [JsonPropertyName("authTokenUrl")]
    public required V1api20230901NotificationHubSpecPropertiesAdmCredentialPropertiesAuthTokenUrl AuthTokenUrl { get; set; }

    /// <summary>ClientId: Gets or sets the client identifier.</summary>
    [JsonPropertyName("clientId")]
    public required V1api20230901NotificationHubSpecPropertiesAdmCredentialPropertiesClientId ClientId { get; set; }

    /// <summary>ClientSecret: Gets or sets the credential secret access key.</summary>
    [JsonPropertyName("clientSecret")]
    public required V1api20230901NotificationHubSpecPropertiesAdmCredentialPropertiesClientSecret ClientSecret { get; set; }
}

/// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesAdmCredential
{
    /// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesAdmCredentialProperties Properties { get; set; }
}

/// <summary>ApnsCertificate: Gets or sets the APNS certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesApnsCertificate
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesAppId
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesAppName
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesCertificateKey
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesEndpoint
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesKeyId
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesThumbprint
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesToken
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
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredentialProperties
{
    /// <summary>ApnsCertificate: Gets or sets the APNS certificate.</summary>
    [JsonPropertyName("apnsCertificate")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesApnsCertificate? ApnsCertificate { get; set; }

    /// <summary>
    /// AppId: Gets or sets the issuer (iss) registered claim key, whose value is
    /// your 10-character Team ID, obtained from your developer account
    /// </summary>
    [JsonPropertyName("appId")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesAppId? AppId { get; set; }

    /// <summary>AppName: Gets or sets the name of the application</summary>
    [JsonPropertyName("appName")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesAppName? AppName { get; set; }

    /// <summary>CertificateKey: Gets or sets the certificate key.</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>Endpoint: Gets or sets the endpoint of this credential.</summary>
    [JsonPropertyName("endpoint")]
    public required V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesEndpoint Endpoint { get; set; }

    /// <summary>
    /// KeyId: Gets or sets a 10-character key identifier (kid) key, obtained from
    /// your developer account
    /// </summary>
    [JsonPropertyName("keyId")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesKeyId? KeyId { get; set; }

    /// <summary>Thumbprint: Gets or sets the APNS certificate Thumbprint</summary>
    [JsonPropertyName("thumbprint")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesThumbprint? Thumbprint { get; set; }

    /// <summary>
    /// Token: Gets or sets provider Authentication Token, obtained through your
    /// developer account
    /// </summary>
    [JsonPropertyName("token")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredentialPropertiesToken? Token { get; set; }
}

/// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesApnsCredential
{
    /// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesApnsCredentialProperties Properties { get; set; }
}

/// <summary>BaiduApiKey: Gets or sets baidu Api Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesBaiduCredentialPropertiesBaiduApiKey
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
public partial class V1api20230901NotificationHubSpecPropertiesBaiduCredentialPropertiesBaiduEndPoint
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
public partial class V1api20230901NotificationHubSpecPropertiesBaiduCredentialPropertiesBaiduSecretKey
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
public partial class V1api20230901NotificationHubSpecPropertiesBaiduCredentialProperties
{
    /// <summary>BaiduApiKey: Gets or sets baidu Api Key.</summary>
    [JsonPropertyName("baiduApiKey")]
    public required V1api20230901NotificationHubSpecPropertiesBaiduCredentialPropertiesBaiduApiKey BaiduApiKey { get; set; }

    /// <summary>BaiduEndPoint: Gets or sets baidu Endpoint.</summary>
    [JsonPropertyName("baiduEndPoint")]
    public required V1api20230901NotificationHubSpecPropertiesBaiduCredentialPropertiesBaiduEndPoint BaiduEndPoint { get; set; }

    /// <summary>BaiduSecretKey: Gets or sets baidu Secret Key</summary>
    [JsonPropertyName("baiduSecretKey")]
    public required V1api20230901NotificationHubSpecPropertiesBaiduCredentialPropertiesBaiduSecretKey BaiduSecretKey { get; set; }
}

/// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesBaiduCredential
{
    /// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesBaiduCredentialProperties Properties { get; set; }
}

/// <summary>Subject: Gets or sets web push subject.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesBrowserCredentialPropertiesSubject
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
public partial class V1api20230901NotificationHubSpecPropertiesBrowserCredentialPropertiesVapidPrivateKey
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
public partial class V1api20230901NotificationHubSpecPropertiesBrowserCredentialPropertiesVapidPublicKey
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
public partial class V1api20230901NotificationHubSpecPropertiesBrowserCredentialProperties
{
    /// <summary>Subject: Gets or sets web push subject.</summary>
    [JsonPropertyName("subject")]
    public required V1api20230901NotificationHubSpecPropertiesBrowserCredentialPropertiesSubject Subject { get; set; }

    /// <summary>VapidPrivateKey: Gets or sets VAPID private key.</summary>
    [JsonPropertyName("vapidPrivateKey")]
    public required V1api20230901NotificationHubSpecPropertiesBrowserCredentialPropertiesVapidPrivateKey VapidPrivateKey { get; set; }

    /// <summary>VapidPublicKey: Gets or sets VAPID public key.</summary>
    [JsonPropertyName("vapidPublicKey")]
    public required V1api20230901NotificationHubSpecPropertiesBrowserCredentialPropertiesVapidPublicKey VapidPublicKey { get; set; }
}

/// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesBrowserCredential
{
    /// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesBrowserCredentialProperties Properties { get; set; }
}

/// <summary>GcmEndpoint: Gets or sets the GCM endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesGcmCredentialPropertiesGcmEndpoint
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
public partial class V1api20230901NotificationHubSpecPropertiesGcmCredentialPropertiesGoogleApiKey
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
public partial class V1api20230901NotificationHubSpecPropertiesGcmCredentialProperties
{
    /// <summary>GcmEndpoint: Gets or sets the GCM endpoint.</summary>
    [JsonPropertyName("gcmEndpoint")]
    public V1api20230901NotificationHubSpecPropertiesGcmCredentialPropertiesGcmEndpoint? GcmEndpoint { get; set; }

    /// <summary>GoogleApiKey: Gets or sets the Google API key.</summary>
    [JsonPropertyName("googleApiKey")]
    public required V1api20230901NotificationHubSpecPropertiesGcmCredentialPropertiesGoogleApiKey GoogleApiKey { get; set; }
}

/// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesGcmCredential
{
    /// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesGcmCredentialProperties Properties { get; set; }
}

/// <summary>CertificateKey: Gets or sets the certificate key for this credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesMpnsCredentialPropertiesCertificateKey
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
public partial class V1api20230901NotificationHubSpecPropertiesMpnsCredentialPropertiesMpnsCertificate
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
public partial class V1api20230901NotificationHubSpecPropertiesMpnsCredentialPropertiesThumbprint
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
public partial class V1api20230901NotificationHubSpecPropertiesMpnsCredentialProperties
{
    /// <summary>CertificateKey: Gets or sets the certificate key for this credential.</summary>
    [JsonPropertyName("certificateKey")]
    public required V1api20230901NotificationHubSpecPropertiesMpnsCredentialPropertiesCertificateKey CertificateKey { get; set; }

    /// <summary>MpnsCertificate: Gets or sets the MPNS certificate.</summary>
    [JsonPropertyName("mpnsCertificate")]
    public required V1api20230901NotificationHubSpecPropertiesMpnsCredentialPropertiesMpnsCertificate MpnsCertificate { get; set; }

    /// <summary>Thumbprint: Gets or sets the MPNS certificate Thumbprint</summary>
    [JsonPropertyName("thumbprint")]
    public required V1api20230901NotificationHubSpecPropertiesMpnsCredentialPropertiesThumbprint Thumbprint { get; set; }
}

/// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesMpnsCredential
{
    /// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesMpnsCredentialProperties Properties { get; set; }
}

/// <summary>CertificateKey: Ges or sets the WNS Certificate Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesCertificateKey
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
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesPackageSid
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
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesSecretKey
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
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesWindowsLiveEndpoint
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
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesWnsCertificate
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
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredentialProperties
{
    /// <summary>CertificateKey: Ges or sets the WNS Certificate Key.</summary>
    [JsonPropertyName("certificateKey")]
    public V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesCertificateKey? CertificateKey { get; set; }

    /// <summary>PackageSid: Gets or sets the package ID for this credential.</summary>
    [JsonPropertyName("packageSid")]
    public V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesPackageSid? PackageSid { get; set; }

    /// <summary>SecretKey: Gets or sets the secret key.</summary>
    [JsonPropertyName("secretKey")]
    public V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesSecretKey? SecretKey { get; set; }

    /// <summary>WindowsLiveEndpoint: Gets or sets the Windows Live endpoint.</summary>
    [JsonPropertyName("windowsLiveEndpoint")]
    public V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesWindowsLiveEndpoint? WindowsLiveEndpoint { get; set; }

    /// <summary>WnsCertificate: Gets or sets the WNS Certificate.</summary>
    [JsonPropertyName("wnsCertificate")]
    public V1api20230901NotificationHubSpecPropertiesWnsCredentialPropertiesWnsCertificate? WnsCertificate { get; set; }
}

/// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesWnsCredential
{
    /// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesWnsCredentialProperties Properties { get; set; }
}

/// <summary>AppSecret: Gets or sets app secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesXiaomiCredentialPropertiesAppSecret
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
public partial class V1api20230901NotificationHubSpecPropertiesXiaomiCredentialPropertiesEndpoint
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
public partial class V1api20230901NotificationHubSpecPropertiesXiaomiCredentialProperties
{
    /// <summary>AppSecret: Gets or sets app secret.</summary>
    [JsonPropertyName("appSecret")]
    public V1api20230901NotificationHubSpecPropertiesXiaomiCredentialPropertiesAppSecret? AppSecret { get; set; }

    /// <summary>Endpoint: Gets or sets xiaomi service endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public V1api20230901NotificationHubSpecPropertiesXiaomiCredentialPropertiesEndpoint? Endpoint { get; set; }
}

/// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecPropertiesXiaomiCredential
{
    /// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
    [JsonPropertyName("properties")]
    public required V1api20230901NotificationHubSpecPropertiesXiaomiCredentialProperties Properties { get; set; }
}

/// <summary>Properties: NotificationHub properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpecProperties
{
    /// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("admCredential")]
    public V1api20230901NotificationHubSpecPropertiesAdmCredential? AdmCredential { get; set; }

    /// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1api20230901NotificationHubSpecPropertiesApnsCredential? ApnsCredential { get; set; }

    /// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("baiduCredential")]
    public V1api20230901NotificationHubSpecPropertiesBaiduCredential? BaiduCredential { get; set; }

    /// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("browserCredential")]
    public V1api20230901NotificationHubSpecPropertiesBrowserCredential? BrowserCredential { get; set; }

    /// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1api20230901NotificationHubSpecPropertiesGcmCredential? GcmCredential { get; set; }

    /// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("mpnsCredential")]
    public V1api20230901NotificationHubSpecPropertiesMpnsCredential? MpnsCredential { get; set; }

    /// <summary>Name: Gets or sets the NotificationHub name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RegistrationTtl: Gets or sets the RegistrationTtl of the created NotificationHub</summary>
    [JsonPropertyName("registrationTtl")]
    public string? RegistrationTtl { get; set; }

    /// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("wnsCredential")]
    public V1api20230901NotificationHubSpecPropertiesWnsCredential? WnsCredential { get; set; }

    /// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
    [JsonPropertyName("xiaomiCredential")]
    public V1api20230901NotificationHubSpecPropertiesXiaomiCredential? XiaomiCredential { get; set; }
}

/// <summary>Name: Namespace SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230901NotificationHubSpecSkuNameEnum>))]
public enum V1api20230901NotificationHubSpecSkuNameEnum
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
public partial class V1api20230901NotificationHubSpecSku
{
    /// <summary>Capacity: Gets or sets the capacity of the resource</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Gets or sets the Sku Family</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: Namespace SKU name.</summary>
    [JsonPropertyName("name")]
    public required V1api20230901NotificationHubSpecSkuNameEnum Name { get; set; }

    /// <summary>Size: Gets or sets the Sku size</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: Gets or sets the tier of particular sku</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubSpec
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
    public V1api20230901NotificationHubSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a notificationhubs.azure.com/Namespace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230901NotificationHubSpecOwner Owner { get; set; }

    /// <summary>Properties: NotificationHub properties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubSpecProperties? Properties { get; set; }

    /// <summary>Sku: The Sku description for a namespace</summary>
    [JsonPropertyName("sku")]
    public V1api20230901NotificationHubSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusConditions
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

/// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesAdmCredentialProperties
{
}

/// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesAdmCredential
{
    /// <summary>Properties: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesAdmCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesApnsCredentialProperties
{
}

/// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesApnsCredential
{
    /// <summary>Properties: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesApnsCredentialProperties? Properties { get; set; }
}

/// <summary>SharedAccessAuthorizationRule properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesAuthorizationRules
{
    /// <summary>ClaimType: Gets a string that describes the claim type</summary>
    [JsonPropertyName("claimType")]
    public string? ClaimType { get; set; }

    /// <summary>ClaimValue: Gets a string that describes the claim value</summary>
    [JsonPropertyName("claimValue")]
    public string? ClaimValue { get; set; }

    /// <summary>CreatedTime: Gets the created time for this rule</summary>
    [JsonPropertyName("createdTime")]
    public string? CreatedTime { get; set; }

    /// <summary>KeyName: Gets a string that describes the authorization rule.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>ModifiedTime: Gets the last modified time for this rule</summary>
    [JsonPropertyName("modifiedTime")]
    public string? ModifiedTime { get; set; }

    /// <summary>Revision: Gets the revision number for the rule</summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>Rights: Gets or sets the rights associated with the rule.</summary>
    [JsonPropertyName("rights")]
    public IList<string>? Rights { get; set; }
}

/// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesBaiduCredentialProperties
{
}

/// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesBaiduCredential
{
    /// <summary>Properties: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesBaiduCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesBrowserCredentialProperties
{
}

/// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesBrowserCredential
{
    /// <summary>Properties: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesBrowserCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesGcmCredentialProperties
{
}

/// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesGcmCredential
{
    /// <summary>Properties: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesGcmCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesMpnsCredentialProperties
{
}

/// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesMpnsCredential
{
    /// <summary>Properties: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesMpnsCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesWnsCredentialProperties
{
}

/// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesWnsCredential
{
    /// <summary>Properties: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesWnsCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesXiaomiCredentialProperties
{
}

/// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusPropertiesXiaomiCredential
{
    /// <summary>Properties: Description of a NotificationHub XiaomiCredentialProperties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusPropertiesXiaomiCredentialProperties? Properties { get; set; }
}

/// <summary>Properties: NotificationHub properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusProperties
{
    /// <summary>AdmCredential: Description of a NotificationHub AdmCredential.</summary>
    [JsonPropertyName("admCredential")]
    public V1api20230901NotificationHubStatusPropertiesAdmCredential? AdmCredential { get; set; }

    /// <summary>ApnsCredential: Description of a NotificationHub ApnsCredential.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1api20230901NotificationHubStatusPropertiesApnsCredential? ApnsCredential { get; set; }

    /// <summary>AuthorizationRules: Gets or sets the AuthorizationRules of the created NotificationHub</summary>
    [JsonPropertyName("authorizationRules")]
    public IList<V1api20230901NotificationHubStatusPropertiesAuthorizationRules>? AuthorizationRules { get; set; }

    /// <summary>BaiduCredential: Description of a NotificationHub BaiduCredential.</summary>
    [JsonPropertyName("baiduCredential")]
    public V1api20230901NotificationHubStatusPropertiesBaiduCredential? BaiduCredential { get; set; }

    /// <summary>BrowserCredential: Description of a NotificationHub BrowserCredential.</summary>
    [JsonPropertyName("browserCredential")]
    public V1api20230901NotificationHubStatusPropertiesBrowserCredential? BrowserCredential { get; set; }

    [JsonPropertyName("dailyMaxActiveDevices")]
    public int? DailyMaxActiveDevices { get; set; }

    /// <summary>GcmCredential: Description of a NotificationHub GcmCredential.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1api20230901NotificationHubStatusPropertiesGcmCredential? GcmCredential { get; set; }

    /// <summary>MpnsCredential: Description of a NotificationHub MpnsCredential.</summary>
    [JsonPropertyName("mpnsCredential")]
    public V1api20230901NotificationHubStatusPropertiesMpnsCredential? MpnsCredential { get; set; }

    /// <summary>Name: Gets or sets the NotificationHub name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RegistrationTtl: Gets or sets the RegistrationTtl of the created NotificationHub</summary>
    [JsonPropertyName("registrationTtl")]
    public string? RegistrationTtl { get; set; }

    /// <summary>WnsCredential: Description of a NotificationHub WnsCredential.</summary>
    [JsonPropertyName("wnsCredential")]
    public V1api20230901NotificationHubStatusPropertiesWnsCredential? WnsCredential { get; set; }

    /// <summary>XiaomiCredential: Description of a NotificationHub XiaomiCredential.</summary>
    [JsonPropertyName("xiaomiCredential")]
    public V1api20230901NotificationHubStatusPropertiesXiaomiCredential? XiaomiCredential { get; set; }
}

/// <summary>Sku: The Sku description for a namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230901NotificationHubStatusSku
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
public partial class V1api20230901NotificationHubStatusSystemData
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
public partial class V1api20230901NotificationHubStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230901NotificationHubStatusConditions>? Conditions { get; set; }

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

    /// <summary>Properties: NotificationHub properties.</summary>
    [JsonPropertyName("properties")]
    public V1api20230901NotificationHubStatusProperties? Properties { get; set; }

    /// <summary>Sku: The Sku description for a namespace</summary>
    [JsonPropertyName("sku")]
    public V1api20230901NotificationHubStatusSku? Sku { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230901NotificationHubStatusSystemData? SystemData { get; set; }

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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NotificationHubs/namespaces/{namespaceName}/notificationHubs/{notificationHubName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230901NotificationHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230901NotificationHubSpec?>, IStatus<V1api20230901NotificationHubStatus?>
{
    public const string KubeApiVersion = "v1api20230901";
    public const string KubeKind = "NotificationHub";
    public const string KubeGroup = "notificationhubs.azure.com";
    public const string KubePluralName = "notificationhubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "notificationhubs.azure.com/v1api20230901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotificationHub";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230901NotificationHubSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230901NotificationHubStatus? Status { get; set; }
}