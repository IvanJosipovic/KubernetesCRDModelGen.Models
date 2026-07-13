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
/// Storage version of v1api20240501.Api
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240501storageApiList : IKubernetesObject<V1ListMeta>, IItems<V1api20240501storageApi>
{
    public const string KubeApiVersion = "v1api20240501storage";
    public const string KubeKind = "ApiList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v1api20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApiList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240501storageApi objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240501storageApi> Items { get; set; }
}

/// <summary>Reference: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecApiVersionSetReference
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
/// Storage version of v1api20240501.ApiVersionSetContractDetails
/// An API Version Set contains the common configuration for a set of API Versions relating
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecApiVersionSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Identifier for existing API Version Set. Omit this value to create a new Version Set.</summary>
    [JsonPropertyName("reference")]
    public V1api20240501storageApiSpecApiVersionSetReference? Reference { get; set; }

    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    [JsonPropertyName("versioningScheme")]
    public string? VersioningScheme { get; set; }
}

/// <summary>ApiVersionSetReference: A resource identifier for the related ApiVersionSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecApiVersionSetReference1
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
/// Storage version of v1api20240501.OAuth2AuthenticationSettingsContract
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecAuthenticationSettingsOAuth2
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OAuth2AuthenticationSettingsContract
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecAuthenticationSettingsOAuth2AuthenticationSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OpenIdAuthenticationSettingsContract
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecAuthenticationSettingsOpenid
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OpenIdAuthenticationSettingsContract
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecAuthenticationSettingsOpenidAuthenticationSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.AuthenticationSettingsContract
/// API Authentication Settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecAuthenticationSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.OAuth2AuthenticationSettingsContract
    /// API OAuth2 Authentication settings details.
    /// </summary>
    [JsonPropertyName("oAuth2")]
    public V1api20240501storageApiSpecAuthenticationSettingsOAuth2? OAuth2 { get; set; }

    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public IList<V1api20240501storageApiSpecAuthenticationSettingsOAuth2AuthenticationSettings>? OAuth2AuthenticationSettings { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.OpenIdAuthenticationSettingsContract
    /// API OAuth2 Authentication settings details.
    /// </summary>
    [JsonPropertyName("openid")]
    public V1api20240501storageApiSpecAuthenticationSettingsOpenid? Openid { get; set; }

    [JsonPropertyName("openidAuthenticationSettings")]
    public IList<V1api20240501storageApiSpecAuthenticationSettingsOpenidAuthenticationSettings>? OpenidAuthenticationSettings { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.ApiContactInformation
/// API contact information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecContact
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.ApiLicenseInformation
/// API license information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecLicense
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
public partial class V1api20240501storageApiSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240501storageApiSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240501.ApiOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240501storageApiSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240501storageApiSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a apimanagement.azure.com/Service resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SourceApiReference: API identifier of the source API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecSourceApiReference
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
/// Storage version of v1api20240501.SubscriptionKeyParameterNamesContract
/// Subscription key parameter names details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecSubscriptionKeyParameterNames
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("header")]
    public string? Header { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>Storage version of v1api20240501.ApiCreateOrUpdateProperties_WsdlSelector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpecWsdlSelector
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("wsdlEndpointName")]
    public string? WsdlEndpointName { get; set; }

    [JsonPropertyName("wsdlServiceName")]
    public string? WsdlServiceName { get; set; }
}

/// <summary>Storage version of v1api20240501.Api_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    [JsonPropertyName("apiType")]
    public string? ApiType { get; set; }

    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiVersionSetContractDetails
    /// An API Version Set contains the common configuration for a set of API Versions relating
    /// </summary>
    [JsonPropertyName("apiVersionSet")]
    public V1api20240501storageApiSpecApiVersionSet? ApiVersionSet { get; set; }

    /// <summary>ApiVersionSetReference: A resource identifier for the related ApiVersionSet.</summary>
    [JsonPropertyName("apiVersionSetReference")]
    public V1api20240501storageApiSpecApiVersionSetReference1? ApiVersionSetReference { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.AuthenticationSettingsContract
    /// API Authentication Settings.
    /// </summary>
    [JsonPropertyName("authenticationSettings")]
    public V1api20240501storageApiSpecAuthenticationSettings? AuthenticationSettings { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiContactInformation
    /// API contact information
    /// </summary>
    [JsonPropertyName("contact")]
    public V1api20240501storageApiSpecContact? Contact { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiLicenseInformation
    /// API license information
    /// </summary>
    [JsonPropertyName("license")]
    public V1api20240501storageApiSpecLicense? License { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240501storageApiSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a apimanagement.azure.com/Service resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240501storageApiSpecOwner Owner { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>SourceApiReference: API identifier of the source API.</summary>
    [JsonPropertyName("sourceApiReference")]
    public V1api20240501storageApiSpecSourceApiReference? SourceApiReference { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.SubscriptionKeyParameterNamesContract
    /// Subscription key parameter names details.
    /// </summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1api20240501storageApiSpecSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    [JsonPropertyName("translateRequiredQueryParameters")]
    public string? TranslateRequiredQueryParameters { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Storage version of v1api20240501.ApiCreateOrUpdateProperties_WsdlSelector</summary>
    [JsonPropertyName("wsdlSelector")]
    public V1api20240501storageApiSpecWsdlSelector? WsdlSelector { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.ApiVersionSetContractDetails_STATUS
/// An API Version Set contains the common configuration for a set of API Versions relating
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusApiVersionSet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("versionHeaderName")]
    public string? VersionHeaderName { get; set; }

    [JsonPropertyName("versionQueryName")]
    public string? VersionQueryName { get; set; }

    [JsonPropertyName("versioningScheme")]
    public string? VersioningScheme { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OAuth2AuthenticationSettingsContract_STATUS
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusAuthenticationSettingsOAuth2
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OAuth2AuthenticationSettingsContract_STATUS
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusAuthenticationSettingsOAuth2AuthenticationSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authorizationServerId")]
    public string? AuthorizationServerId { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OpenIdAuthenticationSettingsContract_STATUS
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusAuthenticationSettingsOpenid
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.OpenIdAuthenticationSettingsContract_STATUS
/// API OAuth2 Authentication settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusAuthenticationSettingsOpenidAuthenticationSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bearerTokenSendingMethods")]
    public IList<string>? BearerTokenSendingMethods { get; set; }

    [JsonPropertyName("openidProviderId")]
    public string? OpenidProviderId { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.AuthenticationSettingsContract_STATUS
/// API Authentication Settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusAuthenticationSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.OAuth2AuthenticationSettingsContract_STATUS
    /// API OAuth2 Authentication settings details.
    /// </summary>
    [JsonPropertyName("oAuth2")]
    public V1api20240501storageApiStatusAuthenticationSettingsOAuth2? OAuth2 { get; set; }

    [JsonPropertyName("oAuth2AuthenticationSettings")]
    public IList<V1api20240501storageApiStatusAuthenticationSettingsOAuth2AuthenticationSettings>? OAuth2AuthenticationSettings { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.OpenIdAuthenticationSettingsContract_STATUS
    /// API OAuth2 Authentication settings details.
    /// </summary>
    [JsonPropertyName("openid")]
    public V1api20240501storageApiStatusAuthenticationSettingsOpenid? Openid { get; set; }

    [JsonPropertyName("openidAuthenticationSettings")]
    public IList<V1api20240501storageApiStatusAuthenticationSettingsOpenidAuthenticationSettings>? OpenidAuthenticationSettings { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusConditions
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
/// Storage version of v1api20240501.ApiContactInformation_STATUS
/// API contact information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusContact
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.ApiLicenseInformation_STATUS
/// API license information
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusLicense
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.SubscriptionKeyParameterNamesContract_STATUS
/// Subscription key parameter names details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatusSubscriptionKeyParameterNames
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("header")]
    public string? Header { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>Storage version of v1api20240501.Api_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240501storageApiStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("apiRevision")]
    public string? ApiRevision { get; set; }

    [JsonPropertyName("apiRevisionDescription")]
    public string? ApiRevisionDescription { get; set; }

    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("apiVersionDescription")]
    public string? ApiVersionDescription { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiVersionSetContractDetails_STATUS
    /// An API Version Set contains the common configuration for a set of API Versions relating
    /// </summary>
    [JsonPropertyName("apiVersionSet")]
    public V1api20240501storageApiStatusApiVersionSet? ApiVersionSet { get; set; }

    [JsonPropertyName("apiVersionSetId")]
    public string? ApiVersionSetId { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.AuthenticationSettingsContract_STATUS
    /// API Authentication Settings.
    /// </summary>
    [JsonPropertyName("authenticationSettings")]
    public V1api20240501storageApiStatusAuthenticationSettings? AuthenticationSettings { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240501storageApiStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiContactInformation_STATUS
    /// API contact information
    /// </summary>
    [JsonPropertyName("contact")]
    public V1api20240501storageApiStatusContact? Contact { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isCurrent")]
    public bool? IsCurrent { get; set; }

    [JsonPropertyName("isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.ApiLicenseInformation_STATUS
    /// API license information
    /// </summary>
    [JsonPropertyName("license")]
    public V1api20240501storageApiStatusLicense? License { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("protocols")]
    public IList<string>? Protocols { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    [JsonPropertyName("sourceApiId")]
    public string? SourceApiId { get; set; }

    /// <summary>
    /// Storage version of v1api20240501.SubscriptionKeyParameterNamesContract_STATUS
    /// Subscription key parameter names details.
    /// </summary>
    [JsonPropertyName("subscriptionKeyParameterNames")]
    public V1api20240501storageApiStatusSubscriptionKeyParameterNames? SubscriptionKeyParameterNames { get; set; }

    [JsonPropertyName("subscriptionRequired")]
    public bool? SubscriptionRequired { get; set; }

    [JsonPropertyName("termsOfServiceUrl")]
    public string? TermsOfServiceUrl { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240501.Api
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/stable/2024-05-01/apimapis.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240501storageApi : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240501storageApiSpec?>, IStatus<V1api20240501storageApiStatus?>
{
    public const string KubeApiVersion = "v1api20240501storage";
    public const string KubeKind = "Api";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "apis";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v1api20240501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Api";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240501.Api_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240501storageApiSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240501.Api_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240501storageApiStatus? Status { get; set; }
}