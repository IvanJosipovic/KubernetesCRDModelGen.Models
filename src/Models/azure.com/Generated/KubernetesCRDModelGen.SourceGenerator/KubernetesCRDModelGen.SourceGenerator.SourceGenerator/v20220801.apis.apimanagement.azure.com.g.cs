#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2022-08-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220801ApiList : IKubernetesObject<V1ListMeta>, IItems<V20220801Api>
{
    public const string KubeApiVersion = "v20220801";
    public const string KubeKind = "ApiList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20220801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220801Api objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220801Api> Items { get; set; }
}

/// <summary>
/// ApiType: Type of API to create.
/// * `http` creates a REST API
/// * `soap` creates a SOAP pass-through API
/// * `websocket` creates websocket API
/// * `graphql` creates GraphQL API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecApiTypeEnum>))]
public enum V20220801ApiSpecApiTypeEnum
{
    [EnumMember(Value = "graphql"), JsonStringEnumMemberName("graphql")]
    Graphql,
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "soap"), JsonStringEnumMemberName("soap")]
    Soap,
    [EnumMember(Value = "websocket"), JsonStringEnumMemberName("websocket")]
    Websocket
}

/// <summary>Reference: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecApiVersionSetReference
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

/// <summary>VersioningScheme: An value that determines where the API Version identifier will be located in a HTTP request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecApiVersionSetVersioningSchemeEnum>))]
public enum V20220801ApiSpecApiVersionSetVersioningSchemeEnum
{
    [EnumMember(Value = "Header"), JsonStringEnumMemberName("Header")]
    Header,
    [EnumMember(Value = "Query"), JsonStringEnumMemberName("Query")]
    Query,
    [EnumMember(Value = "Segment"), JsonStringEnumMemberName("Segment")]
    Segment
}

/// <summary>ApiVersionSet: Version set details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecApiVersionSet
{
    /// <summary>Description: Description of API Version Set.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Name: The display Name of the API Version Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
    [JsonPropertyName("reference")]
    public V20220801ApiSpecApiVersionSetReference? Reference { get; set; }

    /// <summary>VersionHeaderName: Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`.</summary>
    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    /// <summary>VersionQueryName: Name of query parameter that indicates the API Version if versioningScheme is set to `query`.</summary>
    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    /// <summary>VersioningScheme: An value that determines where the API Version identifier will be located in a HTTP request.</summary>
    [JsonPropertyName("versioningScheme")]
    public V20220801ApiSpecApiVersionSetVersioningSchemeEnum? VersioningScheme { get; set; }
}

/// <summary>ApiVersionSetReference: A resource identifier for the related ApiVersionSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecApiVersionSetReference1
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

/// <summary>OAuth2: OAuth2 Authentication settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecAuthenticationSettingsOAuth2
{
    /// <summary>AuthorizationServerId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary>Scope: operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecAuthenticationSettingsOAuth2AuthenticationSettings
{
    /// <summary>AuthorizationServerId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary>Scope: operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Form of an authorization grant, which the client uses to request the access token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecAuthenticationSettingsOpenidBearerTokenSendingMethodsEnum>))]
public enum V20220801ApiSpecAuthenticationSettingsOpenidBearerTokenSendingMethodsEnum
{
    [EnumMember(Value = "authorizationHeader"), JsonStringEnumMemberName("authorizationHeader")]
    AuthorizationHeader,
    [EnumMember(Value = "query"), JsonStringEnumMemberName("query")]
    Query
}

/// <summary>Openid: OpenID Connect Authentication Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecAuthenticationSettingsOpenid
{
    /// <summary>BearerTokenSendingMethods: How to send token to the server.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<V20220801ApiSpecAuthenticationSettingsOpenidBearerTokenSendingMethodsEnum>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenidProviderId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>Form of an authorization grant, which the client uses to request the access token.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecAuthenticationSettingsOpenidAuthenticationSettingsBearerTokenSendingMethodsEnum>))]
public enum V20220801ApiSpecAuthenticationSettingsOpenidAuthenticationSettingsBearerTokenSendingMethodsEnum
{
    [EnumMember(Value = "authorizationHeader"), JsonStringEnumMemberName("authorizationHeader")]
    AuthorizationHeader,
    [EnumMember(Value = "query"), JsonStringEnumMemberName("query")]
    Query
}

/// <summary>API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecAuthenticationSettingsOpenidAuthenticationSettings
{
    /// <summary>BearerTokenSendingMethods: How to send token to the server.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<V20220801ApiSpecAuthenticationSettingsOpenidAuthenticationSettingsBearerTokenSendingMethodsEnum>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenidProviderId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>AuthenticationSettings: Collection of authentication settings included into this API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecAuthenticationSettings
{
    /// <summary>OAuth2: OAuth2 Authentication settings</summary>
    [JsonPropertyName("oAuth2")]
    public V20220801ApiSpecAuthenticationSettingsOAuth2? OAuth2 { get; set; }

    /// <summary>OAuth2AuthenticationSettings: Collection of OAuth2 authentication settings included into this API.</summary>
    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public IList<V20220801ApiSpecAuthenticationSettingsOAuth2AuthenticationSettings>? OAuth2AuthenticationSettings { get; set; }

    /// <summary>Openid: OpenID Connect Authentication Settings</summary>
    [JsonPropertyName("openid")]
    public V20220801ApiSpecAuthenticationSettingsOpenid? Openid { get; set; }

    /// <summary>OpenidAuthenticationSettings: Collection of Open ID Connect authentication settings included into this API.</summary>
    [JsonPropertyName("openidAuthenticationSettings")]
    public IList<V20220801ApiSpecAuthenticationSettingsOpenidAuthenticationSettings>? OpenidAuthenticationSettings { get; set; }
}

/// <summary>Contact: Contact information for the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecContact
{
    /// <summary>Email: The email address of the contact person/organization. MUST be in the format of an email address</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Name: The identifying name of the contact person/organization</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Url: The URL pointing to the contact information. MUST be in the format of a URL</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Format: Format of the Content in which the API is getting imported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecFormatEnum>))]
public enum V20220801ApiSpecFormatEnum
{
    [EnumMember(Value = "graphql-link"), JsonStringEnumMemberName("graphql-link")]
    GraphqlLink,
    [EnumMember(Value = "openapi"), JsonStringEnumMemberName("openapi")]
    Openapi,
    [EnumMember(Value = "openapi+json"), JsonStringEnumMemberName("openapi+json")]
    OpenapiJson,
    [EnumMember(Value = "openapi+json-link"), JsonStringEnumMemberName("openapi+json-link")]
    OpenapijsonLink,
    [EnumMember(Value = "openapi-link"), JsonStringEnumMemberName("openapi-link")]
    OpenapiLink,
    [EnumMember(Value = "swagger-json"), JsonStringEnumMemberName("swagger-json")]
    SwaggerJson,
    [EnumMember(Value = "swagger-link-json"), JsonStringEnumMemberName("swagger-link-json")]
    SwaggerLinkJson,
    [EnumMember(Value = "wadl-link-json"), JsonStringEnumMemberName("wadl-link-json")]
    WadlLinkJson,
    [EnumMember(Value = "wadl-xml"), JsonStringEnumMemberName("wadl-xml")]
    WadlXml,
    [EnumMember(Value = "wsdl"), JsonStringEnumMemberName("wsdl")]
    Wsdl,
    [EnumMember(Value = "wsdl-link"), JsonStringEnumMemberName("wsdl-link")]
    WsdlLink
}

/// <summary>License: License information for the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecLicense
{
    /// <summary>Name: The license name used for the API</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Url: A URL to the license used for the API. MUST be in the format of a URL</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20220801ApiSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20220801ApiSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecProtocolsEnum>))]
public enum V20220801ApiSpecProtocolsEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "https"), JsonStringEnumMemberName("https")]
    Https,
    [EnumMember(Value = "ws"), JsonStringEnumMemberName("ws")]
    Ws,
    [EnumMember(Value = "wss"), JsonStringEnumMemberName("wss")]
    Wss
}

/// <summary>SourceApiReference: API identifier of the source API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecSourceApiReference
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

/// <summary>SubscriptionKeyParameterNames: Protocols over which API is made available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecSubscriptionKeyParameterNames
{
    /// <summary>Header: Subscription key header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Query: Subscription key query string parameter name.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>
/// TranslateRequiredQueryParameters: Strategy of translating required query parameters to template ones. By default has
/// value &apos;template&apos;. Possible values: &apos;template&apos;, &apos;query&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecTranslateRequiredQueryParametersEnum>))]
public enum V20220801ApiSpecTranslateRequiredQueryParametersEnum
{
    [EnumMember(Value = "query"), JsonStringEnumMemberName("query")]
    Query,
    [EnumMember(Value = "template"), JsonStringEnumMemberName("template")]
    Template
}

/// <summary>Type: Type of API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220801ApiSpecTypeEnum>))]
public enum V20220801ApiSpecTypeEnum
{
    [EnumMember(Value = "graphql"), JsonStringEnumMemberName("graphql")]
    Graphql,
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "soap"), JsonStringEnumMemberName("soap")]
    Soap,
    [EnumMember(Value = "websocket"), JsonStringEnumMemberName("websocket")]
    Websocket
}

/// <summary>WsdlSelector: Criteria to limit import of WSDL to a subset of the document.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpecWsdlSelector
{
    /// <summary>WsdlEndpointName: Name of endpoint(port) to import from WSDL</summary>
    [JsonPropertyName("wsdlEndpointName")]
    public string? WsdlEndpointName { get; set; }

    /// <summary>WsdlServiceName: Name of service to import from WSDL</summary>
    [JsonPropertyName("wsdlServiceName")]
    public string? WsdlServiceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiSpec
{
    /// <summary>ApiRevision: Describes the revision of the API. If no value is provided, default revision 1 is created</summary>
    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    /// <summary>ApiRevisionDescription: Description of the API Revision.</summary>
    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    /// <summary>
    /// ApiType: Type of API to create.
    /// * `http` creates a REST API
    /// * `soap` creates a SOAP pass-through API
    /// * `websocket` creates websocket API
    /// * `graphql` creates GraphQL API.
    /// </summary>
    [JsonPropertyName("apiType")]
    public V20220801ApiSpecApiTypeEnum? ApiType { get; set; }

    /// <summary>APIVersion: Indicates the version identifier of the API if the API is versioned</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>ApiVersionDescription: Description of the API Version.</summary>
    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    /// <summary>ApiVersionSet: Version set details</summary>
    [JsonPropertyName("apiVersionSet")]
    public V20220801ApiSpecApiVersionSet? ApiVersionSet { get; set; }

    /// <summary>ApiVersionSetReference: A resource identifier for the related ApiVersionSet.</summary>
    [JsonPropertyName("apiVersionSetReference")]
    public V20220801ApiSpecApiVersionSetReference1? ApiVersionSetReference { get; set; }

    /// <summary>AuthenticationSettings: Collection of authentication settings included into this API.</summary>
    [JsonPropertyName("authenticationSettings")]
    public V20220801ApiSpecAuthenticationSettings? AuthenticationSettings { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Contact: Contact information for the API.</summary>
    [JsonPropertyName("contact")]
    public V20220801ApiSpecContact? Contact { get; set; }

    /// <summary>Description: Description of the API. May include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: API name. Must be 1 to 300 characters long.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Format: Format of the Content in which the API is getting imported.</summary>
    [JsonPropertyName("format")]
    public V20220801ApiSpecFormatEnum? Format { get; set; }

    /// <summary>IsCurrent: Indicates if API revision is current api revision.</summary>
    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>License: License information for the API.</summary>
    [JsonPropertyName("license")]
    public V20220801ApiSpecLicense? License { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220801ApiSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220801ApiSpecOwner Owner { get; set; }

    /// <summary>
    /// Path: Relative URL uniquely identifying this API and all of its resource paths within the API Management service
    /// instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public
    /// URL for this API.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>Protocols: Describes on which protocols the operations in this API can be invoked.</summary>
    [JsonPropertyName("protocols")]
    public IList<V20220801ApiSpecProtocolsEnum>? Protocols { get; set; }

    /// <summary>ServiceUrl: Absolute URL of the backend service implementing this API. Cannot be more than 2000 characters long.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>SourceApiReference: API identifier of the source API.</summary>
    [JsonPropertyName("sourceApiReference")]
    public V20220801ApiSpecSourceApiReference? SourceApiReference { get; set; }

    /// <summary>SubscriptionKeyParameterNames: Protocols over which API is made available.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V20220801ApiSpecSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary>SubscriptionRequired: Specifies whether an API or Product subscription is required for accessing the API.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>TermsOfServiceUrl:  A URL to the Terms of Service for the API. MUST be in the format of a URL.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>
    /// TranslateRequiredQueryParameters: Strategy of translating required query parameters to template ones. By default has
    /// value &apos;template&apos;. Possible values: &apos;template&apos;, &apos;query&apos;
    /// </summary>
    [JsonPropertyName("translateRequiredQueryParameters")]
    public V20220801ApiSpecTranslateRequiredQueryParametersEnum? TranslateRequiredQueryParameters { get; set; }

    /// <summary>Type: Type of API.</summary>
    [JsonPropertyName("type")]
    public V20220801ApiSpecTypeEnum? Type { get; set; }

    /// <summary>Value: Content value when Importing an API.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>WsdlSelector: Criteria to limit import of WSDL to a subset of the document.</summary>
    [JsonPropertyName("wsdlSelector")]
    public V20220801ApiSpecWsdlSelector? WsdlSelector { get; set; }
}

/// <summary>ApiVersionSet: Version set details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusApiVersionSet
{
    /// <summary>Description: Description of API Version Set.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Id: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The display Name of the API Version Set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>VersionHeaderName: Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`.</summary>
    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    /// <summary>VersionQueryName: Name of query parameter that indicates the API Version if versioningScheme is set to `query`.</summary>
    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    /// <summary>VersioningScheme: An value that determines where the API Version identifier will be located in a HTTP request.</summary>
    [JsonPropertyName("versioningScheme")]
    public string? VersioningScheme { get; set; }
}

/// <summary>OAuth2: OAuth2 Authentication settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusAuthenticationSettingsOAuth2
{
    /// <summary>AuthorizationServerId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary>Scope: operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusAuthenticationSettingsOAuth2AuthenticationSettings
{
    /// <summary>AuthorizationServerId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    /// <summary>Scope: operations scope.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Openid: OpenID Connect Authentication Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusAuthenticationSettingsOpenid
{
    /// <summary>BearerTokenSendingMethods: How to send token to the server.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenidProviderId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>API OAuth2 Authentication settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusAuthenticationSettingsOpenidAuthenticationSettings
{
    /// <summary>BearerTokenSendingMethods: How to send token to the server.</summary>
    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    /// <summary>OpenidProviderId: OAuth authorization server identifier.</summary>
    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>AuthenticationSettings: Collection of authentication settings included into this API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusAuthenticationSettings
{
    /// <summary>OAuth2: OAuth2 Authentication settings</summary>
    [JsonPropertyName("oAuth2")]
    public V20220801ApiStatusAuthenticationSettingsOAuth2? OAuth2 { get; set; }

    /// <summary>OAuth2AuthenticationSettings: Collection of OAuth2 authentication settings included into this API.</summary>
    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public IList<V20220801ApiStatusAuthenticationSettingsOAuth2AuthenticationSettings>? OAuth2AuthenticationSettings { get; set; }

    /// <summary>Openid: OpenID Connect Authentication Settings</summary>
    [JsonPropertyName("openid")]
    public V20220801ApiStatusAuthenticationSettingsOpenid? Openid { get; set; }

    /// <summary>OpenidAuthenticationSettings: Collection of Open ID Connect authentication settings included into this API.</summary>
    [JsonPropertyName("openidAuthenticationSettings")]
    public IList<V20220801ApiStatusAuthenticationSettingsOpenidAuthenticationSettings>? OpenidAuthenticationSettings { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusConditions
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

/// <summary>Contact: Contact information for the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusContact
{
    /// <summary>Email: The email address of the contact person/organization. MUST be in the format of an email address</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Name: The identifying name of the contact person/organization</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Url: The URL pointing to the contact information. MUST be in the format of a URL</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>License: License information for the API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusLicense
{
    /// <summary>Name: The license name used for the API</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Url: A URL to the license used for the API. MUST be in the format of a URL</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>SubscriptionKeyParameterNames: Protocols over which API is made available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatusSubscriptionKeyParameterNames
{
    /// <summary>Header: Subscription key header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Query: Subscription key query string parameter name.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220801ApiStatus
{
    /// <summary>ApiRevision: Describes the revision of the API. If no value is provided, default revision 1 is created</summary>
    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    /// <summary>ApiRevisionDescription: Description of the API Revision.</summary>
    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    /// <summary>APIVersion: Indicates the version identifier of the API if the API is versioned</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>ApiVersionDescription: Description of the API Version.</summary>
    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    /// <summary>ApiVersionSet: Version set details</summary>
    [JsonPropertyName("apiVersionSet")]
    public V20220801ApiStatusApiVersionSet? ApiVersionSet { get; set; }

    /// <summary>ApiVersionSetId: A resource identifier for the related ApiVersionSet.</summary>
    [JsonPropertyName("apiVersionSetId")]
    public string? ApiVersionSetId { get; set; }

    /// <summary>AuthenticationSettings: Collection of authentication settings included into this API.</summary>
    [JsonPropertyName("authenticationSettings")]
    public V20220801ApiStatusAuthenticationSettings? AuthenticationSettings { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20220801ApiStatusConditions>? Conditions { get; set; }

    /// <summary>Contact: Contact information for the API.</summary>
    [JsonPropertyName("contact")]
    public V20220801ApiStatusContact? Contact { get; set; }

    /// <summary>Description: Description of the API. May include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: API name. Must be 1 to 300 characters long.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsCurrent: Indicates if API revision is current api revision.</summary>
    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>IsOnline: Indicates if API revision is accessible via the gateway.</summary>
    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>License: License information for the API.</summary>
    [JsonPropertyName("license")]
    public V20220801ApiStatusLicense? License { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path: Relative URL uniquely identifying this API and all of its resource paths within the API Management service
    /// instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public
    /// URL for this API.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>PropertiesType: Type of API.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>Protocols: Describes on which protocols the operations in this API can be invoked.</summary>
    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    /// <summary>ServiceUrl: Absolute URL of the backend service implementing this API. Cannot be more than 2000 characters long.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>SourceApiId: API identifier of the source API.</summary>
    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>SubscriptionKeyParameterNames: Protocols over which API is made available.</summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V20220801ApiStatusSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    /// <summary>SubscriptionRequired: Specifies whether an API or Product subscription is required for accessing the API.</summary>
    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    /// <summary>TermsOfServiceUrl:  A URL to the Terms of Service for the API. MUST be in the format of a URL.</summary>
    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2022-08-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220801Api : IKubernetesObject<V1ObjectMeta>, ISpec<V20220801ApiSpec?>, IStatus<V20220801ApiStatus?>
{
    public const string KubeApiVersion = "v20220801";
    public const string KubeKind = "Api";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v20220801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Api";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20220801ApiSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20220801ApiStatus? Status { get; set; }
}