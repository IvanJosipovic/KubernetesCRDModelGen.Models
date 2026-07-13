#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501RouteList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501Route>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "RouteList";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "routes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RouteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501Route objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501Route> Items { get; set; }
}

/// <summary>CompressionSettings: compression settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecCacheConfigurationCompressionSettings
{
    /// <summary>ContentTypesToCompress: List of content types on which compression applies. The value should be a valid MIME type.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If
    /// compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be
    /// compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }
}

/// <summary>
/// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
/// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
/// strings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RouteSpecCacheConfigurationQueryStringCachingBehaviorEnum>))]
public enum V1api20230501RouteSpecCacheConfigurationQueryStringCachingBehaviorEnum
{
    [EnumMember(Value = "IgnoreQueryString"), JsonStringEnumMemberName("IgnoreQueryString")]
    IgnoreQueryString,
    [EnumMember(Value = "IgnoreSpecifiedQueryStrings"), JsonStringEnumMemberName("IgnoreSpecifiedQueryStrings")]
    IgnoreSpecifiedQueryStrings,
    [EnumMember(Value = "IncludeSpecifiedQueryStrings"), JsonStringEnumMemberName("IncludeSpecifiedQueryStrings")]
    IncludeSpecifiedQueryStrings,
    [EnumMember(Value = "UseQueryString"), JsonStringEnumMemberName("UseQueryString")]
    UseQueryString
}

/// <summary>
/// CacheConfiguration: The caching configuration for this route. To disable caching, do not provide a cacheConfiguration
/// object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecCacheConfiguration
{
    /// <summary>CompressionSettings: compression settings.</summary>
    [JsonPropertyName("compressionSettings")]
    public V1api20230501RouteSpecCacheConfigurationCompressionSettings? CompressionSettings { get; set; }

    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
    /// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
    /// strings.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public V1api20230501RouteSpecCacheConfigurationQueryStringCachingBehaviorEnum? QueryStringCachingBehavior { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecCustomDomainsReference
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

/// <summary>Reference to another resource along with its state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecCustomDomains
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501RouteSpecCustomDomainsReference? Reference { get; set; }
}

/// <summary>EnabledState: Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RouteSpecEnabledStateEnum>))]
public enum V1api20230501RouteSpecEnabledStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RouteSpecForwardingProtocolEnum>))]
public enum V1api20230501RouteSpecForwardingProtocolEnum
{
    [EnumMember(Value = "HttpOnly"), JsonStringEnumMemberName("HttpOnly")]
    HttpOnly,
    [EnumMember(Value = "HttpsOnly"), JsonStringEnumMemberName("HttpsOnly")]
    HttpsOnly,
    [EnumMember(Value = "MatchRequest"), JsonStringEnumMemberName("MatchRequest")]
    MatchRequest
}

/// <summary>
/// HttpsRedirect: Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up
/// this rule and it will be the first rule that gets executed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RouteSpecHttpsRedirectEnum>))]
public enum V1api20230501RouteSpecHttpsRedirectEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>LinkToDefaultDomain: whether this route will be linked to the default endpoint domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RouteSpecLinkToDefaultDomainEnum>))]
public enum V1api20230501RouteSpecLinkToDefaultDomainEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230501RouteSpecOperatorSpecSecretExpressions
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
public partial class V1api20230501RouteSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501RouteSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501RouteSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecOriginGroupReference
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

/// <summary>OriginGroup: A reference to the origin group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecOriginGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501RouteSpecOriginGroupReference? Reference { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cdn.azure.com/AfdEndpoint resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecRuleSetsReference
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

/// <summary>Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpecRuleSets
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501RouteSpecRuleSetsReference? Reference { get; set; }
}

/// <summary>Supported protocols for the customer&apos;s endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501RouteSpecSupportedProtocolsEnum>))]
public enum V1api20230501RouteSpecSupportedProtocolsEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// CacheConfiguration: The caching configuration for this route. To disable caching, do not provide a cacheConfiguration
    /// object.
    /// </summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501RouteSpecCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>CustomDomains: Domains referenced by this endpoint.</summary>
    [JsonPropertyName("customDomains")]
    public IList<V1api20230501RouteSpecCustomDomains>? CustomDomains { get; set; }

    /// <summary>EnabledState: Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;</summary>
    [JsonPropertyName("enabledState")]
    public V1api20230501RouteSpecEnabledStateEnum? EnabledState { get; set; }

    /// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public V1api20230501RouteSpecForwardingProtocolEnum? ForwardingProtocol { get; set; }

    /// <summary>
    /// HttpsRedirect: Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up
    /// this rule and it will be the first rule that gets executed.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public V1api20230501RouteSpecHttpsRedirectEnum? HttpsRedirect { get; set; }

    /// <summary>LinkToDefaultDomain: whether this route will be linked to the default endpoint domain.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public V1api20230501RouteSpecLinkToDefaultDomainEnum? LinkToDefaultDomain { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501RouteSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OriginGroup: A reference to the origin group.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501RouteSpecOriginGroup? OriginGroup { get; set; }

    /// <summary>
    /// OriginPath: A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g.
    /// contoso.cloudapp.net/originpath.
    /// </summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cdn.azure.com/AfdEndpoint resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501RouteSpecOwner Owner { get; set; }

    /// <summary>PatternsToMatch: The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>RuleSets: rule sets referenced by this endpoint.</summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1api20230501RouteSpecRuleSets>? RuleSets { get; set; }

    /// <summary>SupportedProtocols: List of supported protocols for this route.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<V1api20230501RouteSpecSupportedProtocolsEnum>? SupportedProtocols { get; set; }
}

/// <summary>CompressionSettings: compression settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusCacheConfigurationCompressionSettings
{
    /// <summary>ContentTypesToCompress: List of content types on which compression applies. The value should be a valid MIME type.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>
    /// IsCompressionEnabled: Indicates whether content compression is enabled on AzureFrontDoor. Default value is false. If
    /// compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be
    /// compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.
    /// </summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }
}

/// <summary>
/// CacheConfiguration: The caching configuration for this route. To disable caching, do not provide a cacheConfiguration
/// object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusCacheConfiguration
{
    /// <summary>CompressionSettings: compression settings.</summary>
    [JsonPropertyName("compressionSettings")]
    public V1api20230501RouteStatusCacheConfigurationCompressionSettings? CompressionSettings { get; set; }

    /// <summary>QueryParameters: query parameters to include or exclude (comma separated).</summary>
    [JsonPropertyName("queryParameters")]
    public string? QueryParameters { get; set; }

    /// <summary>
    /// QueryStringCachingBehavior: Defines how Frontdoor caches requests that include query strings. You can ignore any query
    /// strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query
    /// strings.
    /// </summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusConditions
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

/// <summary>Reference to another resource along with its state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusCustomDomains
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OriginGroup: A reference to the origin group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusOriginGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusRuleSets
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SystemData: Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC)</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: An identifier for the identity that created the resource</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: An identifier for the identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501RouteStatus
{
    /// <summary>
    /// CacheConfiguration: The caching configuration for this route. To disable caching, do not provide a cacheConfiguration
    /// object.
    /// </summary>
    [JsonPropertyName("cacheConfiguration")]
    public V1api20230501RouteStatusCacheConfiguration? CacheConfiguration { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501RouteStatusConditions>? Conditions { get; set; }

    /// <summary>CustomDomains: Domains referenced by this endpoint.</summary>
    [JsonPropertyName("customDomains")]
    public IList<V1api20230501RouteStatusCustomDomains>? CustomDomains { get; set; }

    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary>EnabledState: Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;</summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary>EndpointName: The name of the endpoint which holds the route.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>ForwardingProtocol: Protocol this rule will use when forwarding traffic to backends.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>
    /// HttpsRedirect: Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up
    /// this rule and it will be the first rule that gets executed.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public string? HttpsRedirect { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LinkToDefaultDomain: whether this route will be linked to the default endpoint domain.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public string? LinkToDefaultDomain { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OriginGroup: A reference to the origin group.</summary>
    [JsonPropertyName("originGroup")]
    public V1api20230501RouteStatusOriginGroup? OriginGroup { get; set; }

    /// <summary>
    /// OriginPath: A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g.
    /// contoso.cloudapp.net/originpath.
    /// </summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>PatternsToMatch: The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>ProvisioningState: Provisioning status</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RuleSets: rule sets referenced by this endpoint.</summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1api20230501RouteStatusRuleSets>? RuleSets { get; set; }

    /// <summary>SupportedProtocols: List of supported protocols for this route.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }

    /// <summary>SystemData: Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501RouteStatusSystemData? SystemData { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/afdEndpoints/{endpointName}/routes/{routeName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501Route : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501RouteSpec?>, IStatus<V1api20230501RouteStatus?>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "Route";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "routes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Route";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230501RouteSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230501RouteStatus? Status { get; set; }
}