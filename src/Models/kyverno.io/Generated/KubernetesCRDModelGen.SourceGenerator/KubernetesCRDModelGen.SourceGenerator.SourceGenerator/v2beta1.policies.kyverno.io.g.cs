#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kyverno.io;
/// <summary>
/// Policy declares validation, mutation, and generation behaviors for matching resources.
/// See: https://kyverno.io/docs/writing-policies/ for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2beta1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V2beta1Policy>
{
    public const string KubeApiVersion = "v2beta1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2beta1Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2beta1Policy> Items { get; set; }
}

/// <summary>
/// ApplyRules controls how rules in a policy are applied. Rule are processed in
/// the order of declaration. When set to `One` processing stops after a rule has
/// been applied i.e. the rule matches and results in a pass, fail, or error. When
/// set to `All` all rules in the policy are processed. The default is `All`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecApplyRulesEnum>))]
public enum V2beta1PolicySpecApplyRulesEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "One"), JsonStringEnumMemberName("One")]
    One
}

/// <summary>Deprecated, use failurePolicy under the webhookConfiguration instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecFailurePolicyEnum>))]
public enum V2beta1PolicySpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesCelPreconditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesContextApiCallMethodEnum>))]
public enum V2beta1PolicySpecRulesContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicySpecRulesContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicySpecRulesContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicySpecRulesContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicySpecRulesContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicySpecRulesContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicySpecRulesContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicySpecRulesContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicySpecRulesContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicySpecRulesContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicySpecRulesContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAllResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesExcludeAllResourcesOperationsEnum>))]
public enum V2beta1PolicySpecRulesExcludeAllResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAllResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAllResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicySpecRulesExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicySpecRulesExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAllSubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicySpecRulesExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicySpecRulesExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesExcludeAnyResourcesOperationsEnum>))]
public enum V2beta1PolicySpecRulesExcludeAnyResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAnyResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAnyResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicySpecRulesExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicySpecRulesExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAnySubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicySpecRulesExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicySpecRulesExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// ExcludeResources defines when this policy rule should not be applied. The exclude
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the name or role.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicySpecRulesExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicySpecRulesExcludeAny>? Any { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateClone
{
    /// <summary>Name specifies name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateCloneListSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels`.
/// wildcard characters are not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesGenerateCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateCloneList
{
    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels`.
    /// wildcard characters are not supported.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesGenerateCloneListSelector? Selector { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachClone
{
    /// <summary>Name specifies name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachCloneListSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels`.
/// wildcard characters are not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesGenerateForeachCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachCloneList
{
    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels`.
    /// wildcard characters are not supported.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesGenerateForeachCloneListSelector? Selector { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesGenerateForeachContextApiCallMethodEnum>))]
public enum V2beta1PolicySpecRulesGenerateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicySpecRulesGenerateForeachContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicySpecRulesGenerateForeachContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicySpecRulesGenerateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicySpecRulesGenerateForeachContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicySpecRulesGenerateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicySpecRulesGenerateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicySpecRulesGenerateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicySpecRulesGenerateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicySpecRulesGenerateForeachContextVariable? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerateForeach
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Clone specifies the source resource used to populate each generated resource.
    /// At most one of Data or Clone can be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("clone")]
    public V2beta1PolicySpecRulesGenerateForeachClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1PolicySpecRulesGenerateForeachCloneList? CloneList { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicySpecRulesGenerateForeachContext>? Context { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// List specifies a JMESPath expression that results in one or more elements
    /// to which the validation logic is applied.
    /// </summary>
    [JsonPropertyName("list")]
    public string? List { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// AnyAllConditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Generation is used to create new resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesGenerate
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Clone specifies the source resource used to populate each generated resource.
    /// At most one of Data or Clone can be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("clone")]
    public V2beta1PolicySpecRulesGenerateClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1PolicySpecRulesGenerateCloneList? CloneList { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>ForEach applies generate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1PolicySpecRulesGenerateForeach>? Foreach { get; set; }

    /// <summary>
    /// GenerateExisting controls whether to trigger the rule in existing resources
    /// If is set to &quot;true&quot; the rule will be triggered and applied to existing matched resources.
    /// </summary>
    [JsonPropertyName("generateExisting")]
    public bool? GenerateExisting { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// OrphanDownstreamOnPolicyDelete controls whether generated resources should be deleted when the rule that generated
    /// them is deleted with synchronization enabled. This option is only applicable to generate rules of the data type.
    /// See https://kyverno.io/docs/writing-policies/generate/#data-examples.
    /// Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("orphanDownstreamOnPolicyDelete")]
    public bool? OrphanDownstreamOnPolicyDelete { get; set; }

    /// <summary>
    /// Synchronize controls if generated resources should be kept in-sync with their source resource.
    /// If Synchronize is set to &quot;true&quot; changes to generated resources will be overwritten with resource
    /// data from Data or the resource specified in the Clone declaration.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("synchronize")]
    public bool? Synchronize { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesImageExtractors
{
    /// <summary>
    /// JMESPath is an optional JMESPath expression to apply to the image value.
    /// This is useful when the extracted image begins with a prefix like &apos;docker://&apos;.
    /// The &apos;trim_prefix&apos; function may be used to trim the prefix: trim_prefix(@, &apos;docker://&apos;).
    /// Note - Image digest mutation may not be used when applying a JMESPAth to an image.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Key is an optional name of the field within &apos;path&apos; that will be used to uniquely identify an image.
    /// Note - this field MUST be unique.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Name is the entry the image will be available under &apos;images.&lt;name&gt; &apos; in the context.
    /// If this field is not defined, image entries will appear under &apos;images.custom&apos;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path is the path to the object containing the image field in a custom resource.
    /// It should be slash-separated. Each slash-separated key must be a valid YAML key or a wildcard &apos;*&apos;.
    /// Wildcard keys are expanded in case of arrays or objects.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>
    /// Value is an optional name of the field within &apos;path&apos; that points to the image URI.
    /// This is useful when a custom &apos;key&apos; is also defined.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAllResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMatchAllResourcesOperationsEnum>))]
public enum V2beta1PolicySpecRulesMatchAllResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAllResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAllResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicySpecRulesMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicySpecRulesMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAllSubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicySpecRulesMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicySpecRulesMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAnyResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMatchAnyResourcesOperationsEnum>))]
public enum V2beta1PolicySpecRulesMatchAnyResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAnyResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAnyResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicySpecRulesMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicySpecRulesMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAnySubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicySpecRulesMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicySpecRulesMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// MatchResources defines when this policy rule should be applied. The match
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the user name or role.
/// At least one kind is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicySpecRulesMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicySpecRulesMatchAny>? Any { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMutateForeachContextApiCallMethodEnum>))]
public enum V2beta1PolicySpecRulesMutateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicySpecRulesMutateForeachContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicySpecRulesMutateForeachContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicySpecRulesMutateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicySpecRulesMutateForeachContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicySpecRulesMutateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicySpecRulesMutateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicySpecRulesMutateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicySpecRulesMutateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicySpecRulesMutateForeachContextVariable? Variable { get; set; }
}

/// <summary>
/// Order defines the iteration order on the list.
/// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMutateForeachOrderEnum>))]
public enum V2beta1PolicySpecRulesMutateForeachOrderEnum
{
    [EnumMember(Value = "Ascending"), JsonStringEnumMemberName("Ascending")]
    Ascending,
    [EnumMember(Value = "Descending"), JsonStringEnumMemberName("Descending")]
    Descending
}

/// <summary>ForEachMutation applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateForeach
{
    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicySpecRulesMutateForeachContext>? Context { get; set; }

    /// <summary>Foreach declares a nested foreach iterator</summary>
    [JsonPropertyName("foreach")]
    public JsonNode? Foreach { get; set; }

    /// <summary>
    /// List specifies a JMESPath expression that results in one or more elements
    /// to which the validation logic is applied.
    /// </summary>
    [JsonPropertyName("list")]
    public string? List { get; set; }

    /// <summary>
    /// Order defines the iteration order on the list.
    /// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
    /// </summary>
    [JsonPropertyName("order")]
    public V2beta1PolicySpecRulesMutateForeachOrderEnum? Order { get; set; }

    /// <summary>
    /// PatchStrategicMerge is a strategic merge patch used to modify resources.
    /// See https://kubernetes.io/docs/tasks/manage-kubernetes-objects/update-api-object-kubectl-patch/
    /// and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesstrategicmerge/.
    /// </summary>
    [JsonPropertyName("patchStrategicMerge")]
    public JsonNode? PatchStrategicMerge { get; set; }

    /// <summary>
    /// PatchesJSON6902 is a list of RFC 6902 JSON Patch declarations used to modify resources.
    /// See https://tools.ietf.org/html/rfc6902 and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesjson6902/.
    /// </summary>
    [JsonPropertyName("patchesJson6902")]
    public string? PatchesJson6902 { get; set; }

    /// <summary>
    /// AnyAllConditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMutateTargetsContextApiCallMethodEnum>))]
public enum V2beta1PolicySpecRulesMutateTargetsContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicySpecRulesMutateTargetsContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicySpecRulesMutateTargetsContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicySpecRulesMutateTargetsContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicySpecRulesMutateTargetsContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicySpecRulesMutateTargetsContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicySpecRulesMutateTargetsContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicySpecRulesMutateTargetsContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicySpecRulesMutateTargetsContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicySpecRulesMutateTargetsContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Selector allows you to select target resources with their labels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargetsSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesMutateTargetsSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>TargetResourceSpec defines targets for mutating existing resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutateTargets
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicySpecRulesMutateTargetsContext>? Context { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Preconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements. A direct list
    /// of conditions (without `any` or `all` statements is supported for backwards compatibility but
    /// will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }

    /// <summary>Selector allows you to select target resources with their labels.</summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesMutateTargetsSelector? Selector { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Mutation is used to modify matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesMutate
{
    /// <summary>ForEach applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1PolicySpecRulesMutateForeach>? Foreach { get; set; }

    /// <summary>MutateExistingOnPolicyUpdate controls if the mutateExisting rule will be applied on policy events.</summary>
    [JsonPropertyName("mutateExistingOnPolicyUpdate")]
    public bool? MutateExistingOnPolicyUpdate { get; set; }

    /// <summary>
    /// PatchStrategicMerge is a strategic merge patch used to modify resources.
    /// See https://kubernetes.io/docs/tasks/manage-kubernetes-objects/update-api-object-kubectl-patch/
    /// and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesstrategicmerge/.
    /// </summary>
    [JsonPropertyName("patchStrategicMerge")]
    public JsonNode? PatchStrategicMerge { get; set; }

    /// <summary>
    /// PatchesJSON6902 is a list of RFC 6902 JSON Patch declarations used to modify resources.
    /// See https://tools.ietf.org/html/rfc6902 and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesjson6902/.
    /// </summary>
    [JsonPropertyName("patchesJson6902")]
    public string? PatchesJson6902 { get; set; }

    /// <summary>Targets defines the target resources to be mutated.</summary>
    [JsonPropertyName("targets")]
    public IList<V2beta1PolicySpecRulesMutateTargets>? Targets { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesPreconditionsAllOperatorEnum>))]
public enum V2beta1PolicySpecRulesPreconditionsAllOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesPreconditionsAll
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicySpecRulesPreconditionsAllOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesPreconditionsAnyOperatorEnum>))]
public enum V2beta1PolicySpecRulesPreconditionsAnyOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesPreconditionsAny
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicySpecRulesPreconditionsAnyOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// Preconditions are used to determine if a policy rule should be applied by evaluating a
/// set of conditions. The declaration can contain nested `any` or `all` statements.
/// See: https://kyverno.io/docs/writing-policies/preconditions/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesPreconditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicySpecRulesPreconditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicySpecRulesPreconditionsAny>? Any { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelAuditAnnotations
{
    /// <summary>
    /// key specifies the audit annotation key. The audit annotation keys of
    /// a ValidatingAdmissionPolicy must be unique. The key must be a qualified
    /// name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
    /// 
    /// The key is combined with the resource name of the
    /// ValidatingAdmissionPolicy to construct an audit annotation key:
    /// &quot;{ValidatingAdmissionPolicy name}/{key}&quot;.
    /// 
    /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy
    /// and the same audit annotation key, the annotation key will be identical.
    /// In this case, the first annotation written with the key will be included
    /// in the audit event and all subsequent annotations with the same key
    /// will be discarded.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// valueExpression represents the expression which is evaluated by CEL to
    /// produce an audit annotation value. The expression must evaluate to either
    /// a string or null value. If the expression evaluates to a string, the
    /// audit annotation is included with the string value. If the expression
    /// evaluates to null or empty string the audit annotation will be omitted.
    /// The valueExpression may be no longer than 5kb in length.
    /// If the result of the valueExpression is more than 10kb in length, it
    /// will be truncated to 10kb.
    /// 
    /// If multiple ValidatingAdmissionPolicyBinding resources match an
    /// API request, then the valueExpression will be evaluated for
    /// each binding. All unique values produced by the valueExpressions
    /// will be joined together in a comma-separated list.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; set; }
}

/// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelExpressions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL.
    /// ref: https://github.com/google/cel-spec
    /// CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
    /// 
    /// - &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// - &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// - &apos;request&apos; - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)).
    /// - &apos;params&apos; - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind.
    /// - &apos;namespaceObject&apos; - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources.
    /// - &apos;variables&apos; - Map of composited variables, from its name to its lazily evaluated value.
    ///   For example, a variable named &apos;foo&apos; can be accessed as &apos;variables.foo&apos;.
    /// - &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// - &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// 
    /// The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the
    /// object. No other metadata properties are accessible.
    /// 
    /// Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible.
    /// Accessible property names are escaped according to the following rules when accessed in the expression:
    /// - &apos;__&apos; escapes to &apos;__underscores__&apos;
    /// - &apos;.&apos; escapes to &apos;__dot__&apos;
    /// - &apos;-&apos; escapes to &apos;__dash__&apos;
    /// - &apos;/&apos; escapes to &apos;__slash__&apos;
    /// - Property names that exactly match a CEL RESERVED keyword escape to &apos;__{keyword}__&apos;. The keywords are:
    /// 	  &quot;true&quot;, &quot;false&quot;, &quot;null&quot;, &quot;in&quot;, &quot;as&quot;, &quot;break&quot;, &quot;const&quot;, &quot;continue&quot;, &quot;else&quot;, &quot;for&quot;, &quot;function&quot;, &quot;if&quot;,
    /// 	  &quot;import&quot;, &quot;let&quot;, &quot;loop&quot;, &quot;package&quot;, &quot;namespace&quot;, &quot;return&quot;.
    /// Examples:
    ///   - Expression accessing a property named &quot;namespace&quot;: {&quot;Expression&quot;: &quot;object.__namespace__ &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;x-prop&quot;: {&quot;Expression&quot;: &quot;object.x__dash__prop &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;redact__d&quot;: {&quot;Expression&quot;: &quot;object.redact__underscores__d &gt; 0&quot;}
    /// 
    /// Equality on arrays with list type of &apos;set&apos; or &apos;map&apos; ignores element order, i.e. [1, 2] == [2, 1].
    /// Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
    ///   - &apos;set&apos;: `X + Y` performs a union where the array positions of all elements in `X` are preserved and
    ///     non-intersecting elements in `Y` are appended, retaining their partial order.
    ///   - &apos;map&apos;: `X + Y` performs a merge where the array positions of all keys in `X` are preserved but the values
    ///     are overwritten by values in `Y` when the key sets of `X` and `Y` intersect. Elements in `Y` with
    ///     non-intersecting keys are appended, retaining their partial order.
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Message represents the message displayed when validation fails. The message is required if the Expression contains
    /// line breaks. The message must not contain line breaks.
    /// If unset, the message is &quot;failed rule: {Rule}&quot;.
    /// e.g. &quot;must be a URL with the host matching spec.host&quot;
    /// If the Expression contains line breaks. Message is required.
    /// The message must not contain line breaks.
    /// If unset, the message is &quot;failed Expression: {Expression}&quot;.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.
    /// Since messageExpression is used as a failure message, it must evaluate to a string.
    /// If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails.
    /// If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced
    /// as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string
    /// that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and
    /// the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged.
    /// messageExpression has access to all the same variables as the `expression` except for &apos;authorizer&apos; and &apos;authorizer.requestResource&apos;.
    /// Example:
    /// &quot;object.x must be less than max (&quot;+string(params.max)+&quot;)&quot;
    /// </summary>
    [JsonPropertyName("messageExpression")]
    public string? MessageExpression { get; set; }

    /// <summary>
    /// Reason represents a machine-readable description of why this validation failed.
    /// If this is the first validation in the list to fail, this reason, as well as the
    /// corresponding HTTP response code, are used in the
    /// HTTP response to the client.
    /// The currently supported reasons are: &quot;Unauthorized&quot;, &quot;Forbidden&quot;, &quot;Invalid&quot;, &quot;RequestEntityTooLarge&quot;.
    /// If not set, StatusReasonInvalid is used in the response to the client.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelParamKind
{
    /// <summary>
    /// APIVersion is the API group version the resources belong to.
    /// In format of &quot;group/version&quot;.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Kind is the API kind the resources belong to.
    /// Required.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelParamRefSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// selector can be used to match multiple param objects based on their labels.
/// Supply selector: {} to match all resources of the ParamKind.
/// 
/// If multiple params are found, they are all evaluated with the policy expressions
/// and the results are ANDed together.
/// 
/// One of `name` or `selector` must be set, but `name` and `selector` are
/// mutually exclusive properties. If one is set, the other must be unset.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelParamRefSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesValidateCelParamRefSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ParamRef references a parameter resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelParamRef
{
    /// <summary>
    /// name is the name of the resource being referenced.
    /// 
    /// One of `name` or `selector` must be set, but `name` and `selector` are
    /// mutually exclusive properties. If one is set, the other must be unset.
    /// 
    /// A single parameter used for all admission requests can be configured
    /// by setting the `name` field, leaving `selector` blank, and setting namespace
    /// if `paramKind` is namespace-scoped.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// namespace is the namespace of the referenced resource. Allows limiting
    /// the search for params to a specific namespace. Applies to both `name` and
    /// `selector` fields.
    /// 
    /// A per-namespace parameter may be used by specifying a namespace-scoped
    /// `paramKind` in the policy and leaving this field empty.
    /// 
    /// - If `paramKind` is cluster-scoped, this field MUST be unset. Setting this
    /// field results in a configuration error.
    /// 
    /// - If `paramKind` is namespace-scoped, the namespace of the object being
    /// evaluated for admission will be used when this field is left unset. Take
    /// care that if this is left empty the binding must not match any cluster-scoped
    /// resources, which will result in an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// `parameterNotFoundAction` controls the behavior of the binding when the resource
    /// exists, and name or selector is valid, but there are no parameters
    /// matched by the binding. If the value is set to `Allow`, then no
    /// matched parameters will be treated as successful validation by the binding.
    /// If set to `Deny`, then no matched parameters will be subject to the
    /// `failurePolicy` of the policy.
    /// 
    /// Allowed values are `Allow` or `Deny`
    /// 
    /// Required
    /// </summary>
    [JsonPropertyName("parameterNotFoundAction")]
    public string? ParameterNotFoundAction { get; set; }

    /// <summary>
    /// selector can be used to match multiple param objects based on their labels.
    /// Supply selector: {} to match all resources of the ParamKind.
    /// 
    /// If multiple params are found, they are all evaluated with the policy expressions
    /// and the results are ANDed together.
    /// 
    /// One of `name` or `selector` must be set, but `name` and `selector` are
    /// mutually exclusive properties. If one is set, the other must be unset.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicySpecRulesValidateCelParamRefSelector? Selector { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCelVariables
{
    /// <summary>
    /// Expression is the expression that will be evaluated as the value of the variable.
    /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is the name of the variable. The name must be a valid CEL identifier and unique among all variables.
    /// The variable can be accessed in other expressions through `variables`
    /// For example, if name is &quot;foo&quot;, the variable will be available as `variables.foo`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CEL allows validation checks using the Common Expression Language (https://kubernetes.io/docs/reference/using-api/cel/).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateCel
{
    /// <summary>AuditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V2beta1PolicySpecRulesValidateCelAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>Expressions is a list of CELExpression types.</summary>
    [JsonPropertyName("expressions")]
    public IList<V2beta1PolicySpecRulesValidateCelExpressions>? Expressions { get; set; }

    /// <summary>
    /// Generate specifies whether to generate a Kubernetes ValidatingAdmissionPolicy from the rule.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("generate")]
    public bool? Generate { get; set; }

    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    [JsonPropertyName("paramKind")]
    public V2beta1PolicySpecRulesValidateCelParamKind? ParamKind { get; set; }

    /// <summary>ParamRef references a parameter resource.</summary>
    [JsonPropertyName("paramRef")]
    public V2beta1PolicySpecRulesValidateCelParamRef? ParamRef { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V2beta1PolicySpecRulesValidateCelVariables>? Variables { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidateDenyConditionsAllOperatorEnum>))]
public enum V2beta1PolicySpecRulesValidateDenyConditionsAllOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateDenyConditionsAll
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicySpecRulesValidateDenyConditionsAllOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidateDenyConditionsAnyOperatorEnum>))]
public enum V2beta1PolicySpecRulesValidateDenyConditionsAnyOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateDenyConditionsAny
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicySpecRulesValidateDenyConditionsAnyOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// Multiple conditions can be declared under an `any` or `all` statement.
/// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateDenyConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicySpecRulesValidateDenyConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicySpecRulesValidateDenyConditionsAny>? Any { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public V2beta1PolicySpecRulesValidateDenyConditions? Conditions { get; set; }
}

/// <summary>
/// FailureAction defines if a validation policy rule violation should block
/// the admission review request (Enforce), or allow (Audit) the admission review request
/// and report an error in a policy report. Optional.
/// Allowed values are Audit or Enforce.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidateFailureActionEnum>))]
public enum V2beta1PolicySpecRulesValidateFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidateFailureActionOverridesActionEnum>))]
public enum V2beta1PolicySpecRulesValidateFailureActionOverridesActionEnum
{
    [EnumMember(Value = "audit"), JsonStringEnumMemberName("audit")]
    Audit,
    [EnumMember(Value = "enforce"), JsonStringEnumMemberName("enforce")]
    Enforce,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit1,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce1
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label selector is a label query over a set of resources. The result of matchLabels and
/// matchExpressions are ANDed. An empty label selector matches all objects. A null
/// label selector matches no objects.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V2beta1PolicySpecRulesValidateFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicySpecRulesValidateFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidateForeachContextApiCallMethodEnum>))]
public enum V2beta1PolicySpecRulesValidateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicySpecRulesValidateForeachContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicySpecRulesValidateForeachContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicySpecRulesValidateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicySpecRulesValidateForeachContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicySpecRulesValidateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicySpecRulesValidateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicySpecRulesValidateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicySpecRulesValidateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicySpecRulesValidateForeachContextVariable? Variable { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeachDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement. A direct list
    /// of conditions (without `any` or `all` statements) is also supported for backwards compatibility
    /// but will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public JsonNode? Conditions { get; set; }
}

/// <summary>ForEachValidation applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateForeach
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicySpecRulesValidateForeachContext>? Context { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1PolicySpecRulesValidateForeachDeny? Deny { get; set; }

    /// <summary>
    /// ElementScope specifies whether to use the current list element as the scope for validation. Defaults to &quot;true&quot; if not specified.
    /// When set to &quot;false&quot;, &quot;request.object&quot; is used as the validation scope within the foreach
    /// block to allow referencing other elements in the subtree.
    /// </summary>
    [JsonPropertyName("elementScope")]
    public bool? ElementScope { get; set; }

    /// <summary>Foreach declares a nested foreach iterator</summary>
    [JsonPropertyName("foreach")]
    public JsonNode? Foreach { get; set; }

    /// <summary>
    /// List specifies a JMESPath expression that results in one or more elements
    /// to which the validation logic is applied.
    /// </summary>
    [JsonPropertyName("list")]
    public string? List { get; set; }

    /// <summary>Pattern specifies an overlay-style pattern used to check resources.</summary>
    [JsonPropertyName("pattern")]
    public JsonNode? Pattern { get; set; }

    /// <summary>
    /// AnyAllConditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Certificates specifies one or more certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesCertificates
{
    /// <summary>Cert is an optional PEM-encoded public certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>CertChain is an optional PEM encoded set of certificates used to verify.</summary>
    [JsonPropertyName("certChain")]
    public string? CertChain { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
/// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

    /// <summary>Issuer is the certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp is the regular expression to match certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessRekor? Rekor { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>Subject is the verified identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp is the regular expression to match identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeysCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeysRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference to a Secret resource that contains a public key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeysSecret
{
    /// <summary>Name of the secret. The provided secret must contain a key named cosign.pub.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace name where the Secret exists.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Keys specifies one or more public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

    /// <summary>
    /// KMS provides the URI to the public key stored in a Key Management System. See:
    /// https://github.com/sigstore/cosign/blob/main/KMS.md
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }

    /// <summary>
    /// Keys is a set of X.509 public keys used to verify image signatures. The keys can be directly
    /// specified or can be a variable reference to a key specified in a ConfigMap (see
    /// https://kyverno.io/docs/writing-policies/variables/), or reference a standard Kubernetes Secret
    /// elsewhere in the cluster by specifying it in the format &quot;k8s://&lt;namespace&gt;/&lt;secret_name&gt; &quot;.
    /// The named Secret must specify a key `cosign.pub` containing the public key used for
    /// verification, (see https://github.com/sigstore/cosign/blob/main/KMS.md#kubernetes-secret).
    /// When multiple keys are specified each key is processed as a separate staticKey entry
    /// (.attestors[*].entries.keys) within the set of attestors and the count is applied across the keys.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public string? PublicKeys { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestorsEntries
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Attestor is a nested set of Attestor used to specify a more complex set of match authorities.</summary>
    [JsonPropertyName("attestor")]
    public JsonNode? Attestor { get; set; }

    /// <summary>Certificates specifies one or more certificates.</summary>
    [JsonPropertyName("certificates")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1PolicySpecRulesValidateManifestsAttestorsEntriesKeys? Keys { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for signatures and attestations that match this rule.
    /// If specified Repository will override other OCI image repository locations for this Attestor.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Specify signature algorithm for public keys. Supported values are sha224, sha256, sha384 and sha512.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsAttestors
{
    /// <summary>
    /// Count specifies the required number of entries that must match. If the count is null, all entries must match
    /// (a logical AND). If the count is 1, at least one entry must match (a logical OR). If the count contains a
    /// value N, then N must be less than or equal to the size of entries, and at least N entries must match.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Entries contains the available attestors. An attestor can be a static key,
    /// attributes for keyless verification, or a nested attestor declaration.
    /// </summary>
    [JsonPropertyName("entries")]
    public IList<V2beta1PolicySpecRulesValidateManifestsAttestorsEntries>? Entries { get; set; }
}

/// <summary>DryRun configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsDryRun
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsIgnoreFieldsObjects
{
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifestsIgnoreFields
{
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    [JsonPropertyName("objects")]
    public IList<V2beta1PolicySpecRulesValidateManifestsIgnoreFieldsObjects>? Objects { get; set; }
}

/// <summary>Manifest specifies conditions for manifest verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidateManifests
{
    /// <summary>AnnotationDomain is custom domain of annotation for message and signature. Default is &quot;cosign.sigstore.dev&quot;.</summary>
    [JsonPropertyName("annotationDomain")]
    public string? AnnotationDomain { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1PolicySpecRulesValidateManifestsAttestors>? Attestors { get; set; }

    /// <summary>DryRun configuration</summary>
    [JsonPropertyName("dryRun")]
    public V2beta1PolicySpecRulesValidateManifestsDryRun? DryRun { get; set; }

    /// <summary>Fields which will be ignored while comparing manifests.</summary>
    [JsonPropertyName("ignoreFields")]
    public IList<V2beta1PolicySpecRulesValidateManifestsIgnoreFields>? IgnoreFields { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for resource bundle reference.
    /// The repository can be overridden per Attestor or Attestation.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// ControlName specifies the name of the Pod Security Standard control.
/// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidatePodSecurityExcludeControlNameEnum>))]
public enum V2beta1PolicySpecRulesValidatePodSecurityExcludeControlNameEnum
{
    [EnumMember(Value = "HostProcess"), JsonStringEnumMemberName("HostProcess")]
    HostProcess,
    [EnumMember(Value = "Host Namespaces"), JsonStringEnumMemberName("Host Namespaces")]
    HostNamespaces,
    [EnumMember(Value = "Privileged Containers"), JsonStringEnumMemberName("Privileged Containers")]
    PrivilegedContainers,
    [EnumMember(Value = "Capabilities"), JsonStringEnumMemberName("Capabilities")]
    Capabilities,
    [EnumMember(Value = "HostPath Volumes"), JsonStringEnumMemberName("HostPath Volumes")]
    HostPathVolumes,
    [EnumMember(Value = "Host Ports"), JsonStringEnumMemberName("Host Ports")]
    HostPorts,
    [EnumMember(Value = "AppArmor"), JsonStringEnumMemberName("AppArmor")]
    AppArmor,
    [EnumMember(Value = "SELinux"), JsonStringEnumMemberName("SELinux")]
    SELinux,
    [EnumMember(Value = "/proc Mount Type"), JsonStringEnumMemberName("/proc Mount Type")]
    ProcMountType,
    [EnumMember(Value = "Seccomp"), JsonStringEnumMemberName("Seccomp")]
    Seccomp,
    [EnumMember(Value = "Sysctls"), JsonStringEnumMemberName("Sysctls")]
    Sysctls,
    [EnumMember(Value = "Volume Types"), JsonStringEnumMemberName("Volume Types")]
    VolumeTypes,
    [EnumMember(Value = "Privilege Escalation"), JsonStringEnumMemberName("Privilege Escalation")]
    PrivilegeEscalation,
    [EnumMember(Value = "Running as Non-root"), JsonStringEnumMemberName("Running as Non-root")]
    RunningAsNonRoot,
    [EnumMember(Value = "Running as Non-root user"), JsonStringEnumMemberName("Running as Non-root user")]
    RunningAsNonRootUser
}

/// <summary>PodSecurityStandard specifies the Pod Security Standard controls to be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidatePodSecurityExclude
{
    /// <summary>
    /// ControlName specifies the name of the Pod Security Standard control.
    /// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
    /// </summary>
    [JsonPropertyName("controlName")]
    public required V2beta1PolicySpecRulesValidatePodSecurityExcludeControlNameEnum ControlName { get; set; }

    /// <summary>
    /// Images selects matching containers and applies the container level PSS.
    /// Each image is the image name consisting of the registry address, repository, image, and tag.
    /// Empty list matches no containers, PSS checks are applied at the pod level only.
    /// Wildcards (&apos;*&apos; and &apos;?&apos;) are allowed. See: https://kubernetes.io/docs/concepts/containers/images.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// RestrictedField selects the field for the given Pod Security Standard control.
    /// When not set, all restricted fields for the control are selected.
    /// </summary>
    [JsonPropertyName("restrictedField")]
    public string? RestrictedField { get; set; }

    /// <summary>Values defines the allowed values that can be excluded.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Level defines the Pod Security Standard level to be applied to workloads.
/// Allowed values are privileged, baseline, and restricted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidatePodSecurityLevelEnum>))]
public enum V2beta1PolicySpecRulesValidatePodSecurityLevelEnum
{
    [EnumMember(Value = "privileged"), JsonStringEnumMemberName("privileged")]
    Privileged,
    [EnumMember(Value = "baseline"), JsonStringEnumMemberName("baseline")]
    Baseline,
    [EnumMember(Value = "restricted"), JsonStringEnumMemberName("restricted")]
    Restricted
}

/// <summary>
/// Version defines the Pod Security Standard versions that Kubernetes supports.
/// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesValidatePodSecurityVersionEnum>))]
public enum V2beta1PolicySpecRulesValidatePodSecurityVersionEnum
{
    [EnumMember(Value = "v1.19"), JsonStringEnumMemberName("v1.19")]
    V119,
    [EnumMember(Value = "v1.20"), JsonStringEnumMemberName("v1.20")]
    V120,
    [EnumMember(Value = "v1.21"), JsonStringEnumMemberName("v1.21")]
    V121,
    [EnumMember(Value = "v1.22"), JsonStringEnumMemberName("v1.22")]
    V122,
    [EnumMember(Value = "v1.23"), JsonStringEnumMemberName("v1.23")]
    V123,
    [EnumMember(Value = "v1.24"), JsonStringEnumMemberName("v1.24")]
    V124,
    [EnumMember(Value = "v1.25"), JsonStringEnumMemberName("v1.25")]
    V125,
    [EnumMember(Value = "v1.26"), JsonStringEnumMemberName("v1.26")]
    V126,
    [EnumMember(Value = "v1.27"), JsonStringEnumMemberName("v1.27")]
    V127,
    [EnumMember(Value = "v1.28"), JsonStringEnumMemberName("v1.28")]
    V128,
    [EnumMember(Value = "v1.29"), JsonStringEnumMemberName("v1.29")]
    V129,
    [EnumMember(Value = "v1.30"), JsonStringEnumMemberName("v1.30")]
    V130,
    [EnumMember(Value = "v1.31"), JsonStringEnumMemberName("v1.31")]
    V131,
    [EnumMember(Value = "v1.32"), JsonStringEnumMemberName("v1.32")]
    V132,
    [EnumMember(Value = "latest"), JsonStringEnumMemberName("latest")]
    Latest
}

/// <summary>
/// PodSecurity applies exemptions for Kubernetes Pod Security admission
/// by specifying exclusions for Pod Security Standards controls.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidatePodSecurity
{
    /// <summary>Exclude specifies the Pod Security Standard controls to be excluded.</summary>
    [JsonPropertyName("exclude")]
    public IList<V2beta1PolicySpecRulesValidatePodSecurityExclude>? Exclude { get; set; }

    /// <summary>
    /// Level defines the Pod Security Standard level to be applied to workloads.
    /// Allowed values are privileged, baseline, and restricted.
    /// </summary>
    [JsonPropertyName("level")]
    public V2beta1PolicySpecRulesValidatePodSecurityLevelEnum? Level { get; set; }

    /// <summary>
    /// Version defines the Pod Security Standard versions that Kubernetes supports.
    /// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
    /// </summary>
    [JsonPropertyName("version")]
    public V2beta1PolicySpecRulesValidatePodSecurityVersionEnum? Version { get; set; }
}

/// <summary>Validation is used to validate matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesValidate
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Assert defines a kyverno-json assertion tree.</summary>
    [JsonPropertyName("assert")]
    public JsonNode? Assert { get; set; }

    /// <summary>CEL allows validation checks using the Common Expression Language (https://kubernetes.io/docs/reference/using-api/cel/).</summary>
    [JsonPropertyName("cel")]
    public V2beta1PolicySpecRulesValidateCel? Cel { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1PolicySpecRulesValidateDeny? Deny { get; set; }

    /// <summary>
    /// FailureAction defines if a validation policy rule violation should block
    /// the admission review request (Enforce), or allow (Audit) the admission review request
    /// and report an error in a policy report. Optional.
    /// Allowed values are Audit or Enforce.
    /// </summary>
    [JsonPropertyName("failureAction")]
    public V2beta1PolicySpecRulesValidateFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// FailureActionOverrides is a Cluster Policy attribute that specifies FailureAction
    /// namespace-wise. It overrides FailureAction for the specified namespaces.
    /// </summary>
    [JsonPropertyName("failureActionOverrides")]
    public IList<V2beta1PolicySpecRulesValidateFailureActionOverrides>? FailureActionOverrides { get; set; }

    /// <summary>ForEach applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1PolicySpecRulesValidateForeach>? Foreach { get; set; }

    /// <summary>Manifest specifies conditions for manifest verification</summary>
    [JsonPropertyName("manifests")]
    public V2beta1PolicySpecRulesValidateManifests? Manifests { get; set; }

    /// <summary>Message specifies a custom message to be displayed on failure.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Pattern specifies an overlay-style pattern used to check resources.</summary>
    [JsonPropertyName("pattern")]
    public JsonNode? Pattern { get; set; }

    /// <summary>
    /// PodSecurity applies exemptions for Kubernetes Pod Security admission
    /// by specifying exclusions for Pod Security Standards controls.
    /// </summary>
    [JsonPropertyName("podSecurity")]
    public V2beta1PolicySpecRulesValidatePodSecurity? PodSecurity { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Certificates specifies one or more certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificates
{
    /// <summary>Cert is an optional PEM-encoded public certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>CertChain is an optional PEM encoded set of certificates used to verify.</summary>
    [JsonPropertyName("certChain")]
    public string? CertChain { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
/// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

    /// <summary>Issuer is the certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp is the regular expression to match certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor? Rekor { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>Subject is the verified identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp is the regular expression to match identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference to a Secret resource that contains a public key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret
{
    /// <summary>Name of the secret. The provided secret must contain a key named cosign.pub.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace name where the Secret exists.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Keys specifies one or more public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

    /// <summary>
    /// KMS provides the URI to the public key stored in a Key Management System. See:
    /// https://github.com/sigstore/cosign/blob/main/KMS.md
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }

    /// <summary>
    /// Keys is a set of X.509 public keys used to verify image signatures. The keys can be directly
    /// specified or can be a variable reference to a key specified in a ConfigMap (see
    /// https://kyverno.io/docs/writing-policies/variables/), or reference a standard Kubernetes Secret
    /// elsewhere in the cluster by specifying it in the format &quot;k8s://&lt;namespace&gt;/&lt;secret_name&gt; &quot;.
    /// The named Secret must specify a key `cosign.pub` containing the public key used for
    /// verification, (see https://github.com/sigstore/cosign/blob/main/KMS.md#kubernetes-secret).
    /// When multiple keys are specified each key is processed as a separate staticKey entry
    /// (.attestors[*].entries.keys) within the set of attestors and the count is applied across the keys.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public string? PublicKeys { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntries
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Attestor is a nested set of Attestor used to specify a more complex set of match authorities.</summary>
    [JsonPropertyName("attestor")]
    public JsonNode? Attestor { get; set; }

    /// <summary>Certificates specifies one or more certificates.</summary>
    [JsonPropertyName("certificates")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeys? Keys { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for signatures and attestations that match this rule.
    /// If specified Repository will override other OCI image repository locations for this Attestor.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Specify signature algorithm for public keys. Supported values are sha224, sha256, sha384 and sha512.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsAttestors
{
    /// <summary>
    /// Count specifies the required number of entries that must match. If the count is null, all entries must match
    /// (a logical AND). If the count is 1, at least one entry must match (a logical OR). If the count contains a
    /// value N, then N must be less than or equal to the size of entries, and at least N entries must match.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Entries contains the available attestors. An attestor can be a static key,
    /// attributes for keyless verification, or a nested attestor declaration.
    /// </summary>
    [JsonPropertyName("entries")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestationsAttestorsEntries>? Entries { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum>))]
public enum V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

/// <summary>Condition defines variable-based conditional criteria for rule execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAll
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum>))]
public enum V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

/// <summary>Condition defines variable-based conditional criteria for rule execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAny
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// AnyAllConditions consists of conditions wrapped denoting a logical criteria to be fulfilled.
/// AnyConditions get fulfilled when at least one of its sub-conditions passes.
/// AllConditions get fulfilled only when all of its sub-conditions pass.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestationsConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestationsConditionsAny>? Any { get; set; }
}

/// <summary>
/// Attestation are checks for signed in-toto Statements that are used to verify the image.
/// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
/// OCI registry and decodes them into a list of Statements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestations
{
    /// <summary>Attestors specify the required attestors (i.e. authorities).</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestationsAttestors>? Attestors { get; set; }

    /// <summary>
    /// Conditions are used to verify attributes within a Predicate. If no Conditions are specified
    /// the attestation check is satisfied as long there are predicates that match the predicate type.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestationsConditions>? Conditions { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Deprecated in favour of &apos;Type&apos;, to be removed soon</summary>
    [JsonPropertyName("predicateType")]
    public string? PredicateType { get; set; }

    /// <summary>Type defines the type of attestation contained within the Statement.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Certificates specifies one or more certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesCertificates
{
    /// <summary>Cert is an optional PEM-encoded public certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>CertChain is an optional PEM encoded set of certificates used to verify.</summary>
    [JsonPropertyName("certChain")]
    public string? CertChain { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
/// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

    /// <summary>Issuer is the certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp is the regular expression to match certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessRekor? Rekor { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>Subject is the verified identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp is the regular expression to match identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeysCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeysRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference to a Secret resource that contains a public key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeysSecret
{
    /// <summary>Name of the secret. The provided secret must contain a key named cosign.pub.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace name where the Secret exists.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Keys specifies one or more public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeysCtlog? Ctlog { get; set; }

    /// <summary>
    /// KMS provides the URI to the public key stored in a Key Management System. See:
    /// https://github.com/sigstore/cosign/blob/main/KMS.md
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }

    /// <summary>
    /// Keys is a set of X.509 public keys used to verify image signatures. The keys can be directly
    /// specified or can be a variable reference to a key specified in a ConfigMap (see
    /// https://kyverno.io/docs/writing-policies/variables/), or reference a standard Kubernetes Secret
    /// elsewhere in the cluster by specifying it in the format &quot;k8s://&lt;namespace&gt;/&lt;secret_name&gt; &quot;.
    /// The named Secret must specify a key `cosign.pub` containing the public key used for
    /// verification, (see https://github.com/sigstore/cosign/blob/main/KMS.md#kubernetes-secret).
    /// When multiple keys are specified each key is processed as a separate staticKey entry
    /// (.attestors[*].entries.keys) within the set of attestors and the count is applied across the keys.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public string? PublicKeys { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestorsEntries
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Attestor is a nested set of Attestor used to specify a more complex set of match authorities.</summary>
    [JsonPropertyName("attestor")]
    public JsonNode? Attestor { get; set; }

    /// <summary>Certificates specifies one or more certificates.</summary>
    [JsonPropertyName("certificates")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1PolicySpecRulesVerifyImagesAttestorsEntriesKeys? Keys { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for signatures and attestations that match this rule.
    /// If specified Repository will override other OCI image repository locations for this Attestor.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Specify signature algorithm for public keys. Supported values are sha224, sha256, sha384 and sha512.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesAttestors
{
    /// <summary>
    /// Count specifies the required number of entries that must match. If the count is null, all entries must match
    /// (a logical AND). If the count is 1, at least one entry must match (a logical OR). If the count contains a
    /// value N, then N must be less than or equal to the size of entries, and at least N entries must match.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Entries contains the available attestors. An attestor can be a static key,
    /// attributes for keyless verification, or a nested attestor declaration.
    /// </summary>
    [JsonPropertyName("entries")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestorsEntries>? Entries { get; set; }
}

/// <summary>Allowed values are Audit or Enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesVerifyImagesFailureActionEnum>))]
public enum V2beta1PolicySpecRulesVerifyImagesFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// Type specifies the method of signature validation. The allowed options
/// are Cosign and Notary. By default Cosign is used if a type is not specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecRulesVerifyImagesTypeEnum>))]
public enum V2beta1PolicySpecRulesVerifyImagesTypeEnum
{
    [EnumMember(Value = "Cosign"), JsonStringEnumMemberName("Cosign")]
    Cosign,
    [EnumMember(Value = "SigstoreBundle"), JsonStringEnumMemberName("SigstoreBundle")]
    SigstoreBundle,
    [EnumMember(Value = "Notary"), JsonStringEnumMemberName("Notary")]
    Notary
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesValidateDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement. A direct list
    /// of conditions (without `any` or `all` statements) is also supported for backwards compatibility
    /// but will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public JsonNode? Conditions { get; set; }
}

/// <summary>
/// Validation checks conditions across multiple image
/// verification attestations or context entries
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImagesValidate
{
    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1PolicySpecRulesVerifyImagesValidateDeny? Deny { get; set; }

    /// <summary>Message specifies a custom message to be displayed on failure.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// ImageVerification validates that images that match the specified pattern
/// are signed with the supplied public key. Once the image is verified it is
/// mutated to include the SHA digest retrieved during the registration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRulesVerifyImages
{
    /// <summary>
    /// Attestations are optional checks for signed in-toto Statements used to verify the image.
    /// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
    /// OCI registry and decodes them into a list of Statement declarations.
    /// </summary>
    [JsonPropertyName("attestations")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestations>? Attestations { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1PolicySpecRulesVerifyImagesAttestors>? Attestors { get; set; }

    /// <summary>Allowed values are Audit or Enforce.</summary>
    [JsonPropertyName("failureAction")]
    public V2beta1PolicySpecRulesVerifyImagesFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// ImageReferences is a list of matching image reference patterns. At least one pattern in the
    /// list must match the image for the rule to apply. Each image reference consists of a registry
    /// address (defaults to docker.io), repository, image, and tag (defaults to latest).
    /// Wildcards (&apos;*&apos; and &apos;?&apos;) are allowed. See: https://kubernetes.io/docs/concepts/containers/images.
    /// </summary>
    [JsonPropertyName("imageReferences")]
    public IList<string>? ImageReferences { get; set; }

    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicySpecRulesVerifyImagesImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// MutateDigest enables replacement of image tags with digests.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("mutateDigest")]
    public bool? MutateDigest { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for image signatures and attestations that match this rule.
    /// If specified Repository will override the default OCI image repository configured for the installation.
    /// The repository can also be overridden per Attestor or Attestation.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Required validates that images are verified i.e. have matched passed a signature or attestation check.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// SkipImageReferences is a list of matching image reference patterns that should be skipped.
    /// At least one pattern in the list must match the image for the rule to be skipped. Each image reference
    /// consists of a registry address (defaults to docker.io), repository, image, and tag (defaults to latest).
    /// Wildcards (&apos;*&apos; and &apos;?&apos;) are allowed. See: https://kubernetes.io/docs/concepts/containers/images.
    /// </summary>
    [JsonPropertyName("skipImageReferences")]
    public IList<string>? SkipImageReferences { get; set; }

    /// <summary>
    /// Type specifies the method of signature validation. The allowed options
    /// are Cosign and Notary. By default Cosign is used if a type is not specified.
    /// </summary>
    [JsonPropertyName("type")]
    public V2beta1PolicySpecRulesVerifyImagesTypeEnum? Type { get; set; }

    /// <summary>UseCache enables caching of image verify responses for this rule</summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Validation checks conditions across multiple image
    /// verification attestations or context entries
    /// </summary>
    [JsonPropertyName("validate")]
    public V2beta1PolicySpecRulesVerifyImagesValidate? Validate { get; set; }

    /// <summary>VerifyDigest validates that images have a digest.</summary>
    [JsonPropertyName("verifyDigest")]
    public bool? VerifyDigest { get; set; }
}

/// <summary>
/// Rule defines a validation, mutation, or generation control for matching resources.
/// Each rules contains a match declaration to select resources, and an optional exclude
/// declaration to specify which resources to exclude.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecRules
{
    /// <summary>
    /// CELPreconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of CEL conditions. It can only be used with the validate.cel subrule
    /// </summary>
    [JsonPropertyName("celPreconditions")]
    public IList<V2beta1PolicySpecRulesCelPreconditions>? CelPreconditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicySpecRulesContext>? Context { get; set; }

    /// <summary>
    /// ExcludeResources defines when this policy rule should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V2beta1PolicySpecRulesExclude? Exclude { get; set; }

    /// <summary>Generation is used to create new resources.</summary>
    [JsonPropertyName("generate")]
    public V2beta1PolicySpecRulesGenerate? Generate { get; set; }

    /// <summary>
    /// ImageExtractors defines a mapping from kinds to ImageExtractorConfigs.
    /// This config is only valid for verifyImages rules.
    /// </summary>
    [JsonPropertyName("imageExtractors")]
    public IDictionary<string, IList<V2beta1PolicySpecRulesImageExtractors>>? ImageExtractors { get; set; }

    /// <summary>
    /// MatchResources defines when this policy rule should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V2beta1PolicySpecRulesMatch Match { get; set; }

    /// <summary>Mutation is used to modify matching resources.</summary>
    [JsonPropertyName("mutate")]
    public V2beta1PolicySpecRulesMutate? Mutate { get; set; }

    /// <summary>Name is a label to identify the rule, It must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Preconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public V2beta1PolicySpecRulesPreconditions? Preconditions { get; set; }

    /// <summary>
    /// SkipBackgroundRequests bypasses admission requests that are sent by the background controller.
    /// The default value is set to &quot;true&quot;, it must be set to &quot;false&quot; to apply
    /// generate and mutateExisting rules to those requests.
    /// </summary>
    [JsonPropertyName("skipBackgroundRequests")]
    public bool? SkipBackgroundRequests { get; set; }

    /// <summary>Validation is used to validate matching resources.</summary>
    [JsonPropertyName("validate")]
    public V2beta1PolicySpecRulesValidate? Validate { get; set; }

    /// <summary>VerifyImages is used to verify image signatures and mutate them to add a digest</summary>
    [JsonPropertyName("verifyImages")]
    public IList<V2beta1PolicySpecRulesVerifyImages>? VerifyImages { get; set; }
}

/// <summary>Deprecated, use validationFailureAction under the validate rule instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecValidationFailureActionEnum>))]
public enum V2beta1PolicySpecValidationFailureActionEnum
{
    [EnumMember(Value = "audit"), JsonStringEnumMemberName("audit")]
    Audit,
    [EnumMember(Value = "enforce"), JsonStringEnumMemberName("enforce")]
    Enforce,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit1,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce1
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecValidationFailureActionOverridesActionEnum>))]
public enum V2beta1PolicySpecValidationFailureActionOverridesActionEnum
{
    [EnumMember(Value = "audit"), JsonStringEnumMemberName("audit")]
    Audit,
    [EnumMember(Value = "enforce"), JsonStringEnumMemberName("enforce")]
    Enforce,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit1,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce1
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecValidationFailureActionOverridesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label selector is a label query over a set of resources. The result of matchLabels and
/// matchExpressions are ANDed. An empty label selector matches all objects. A null
/// label selector matches no objects.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecValidationFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicySpecValidationFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecValidationFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V2beta1PolicySpecValidationFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicySpecValidationFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>
/// FailurePolicy defines how unexpected policy errors and webhook response timeout errors are handled.
/// Rules within the same policy share the same failure behavior.
/// This field should not be accessed directly, instead `GetFailurePolicy()` should be used.
/// Allowed values are Ignore or Fail. Defaults to Fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicySpecWebhookConfigurationFailurePolicyEnum>))]
public enum V2beta1PolicySpecWebhookConfigurationFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecWebhookConfigurationMatchConditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebhookConfiguration specifies the custom configuration for Kubernetes admission webhookconfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpecWebhookConfiguration
{
    /// <summary>
    /// FailurePolicy defines how unexpected policy errors and webhook response timeout errors are handled.
    /// Rules within the same policy share the same failure behavior.
    /// This field should not be accessed directly, instead `GetFailurePolicy()` should be used.
    /// Allowed values are Ignore or Fail. Defaults to Fail.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V2beta1PolicySpecWebhookConfigurationFailurePolicyEnum? FailurePolicy { get; set; }

    /// <summary>
    /// MatchCondition configures admission webhook matchConditions.
    /// Requires Kubernetes 1.27 or later.
    /// </summary>
    [JsonPropertyName("matchConditions")]
    public IList<V2beta1PolicySpecWebhookConfigurationMatchConditions>? MatchConditions { get; set; }

    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Spec defines policy behaviors and contains one or more rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicySpec
{
    /// <summary>
    /// Admission controls if rules are applied during admission.
    /// Optional. Default value is &quot;true&quot;.
    /// </summary>
    [JsonPropertyName("admission")]
    public bool? Admission { get; set; }

    /// <summary>
    /// ApplyRules controls how rules in a policy are applied. Rule are processed in
    /// the order of declaration. When set to `One` processing stops after a rule has
    /// been applied i.e. the rule matches and results in a pass, fail, or error. When
    /// set to `All` all rules in the policy are processed. The default is `All`.
    /// </summary>
    [JsonPropertyName("applyRules")]
    public V2beta1PolicySpecApplyRulesEnum? ApplyRules { get; set; }

    /// <summary>
    /// Background controls if rules are applied to existing resources during a background scan.
    /// Optional. Default value is &quot;true&quot;. The value must be set to &quot;false&quot; if the policy rule
    /// uses variables that are only available in the admission review request (e.g. user name).
    /// </summary>
    [JsonPropertyName("background")]
    public bool? Background { get; set; }

    /// <summary>
    /// EmitWarning enables API response warnings for mutate policy rules or validate policy rules with validationFailureAction set to Audit.
    /// Enabling this option will extend admission request processing times. The default value is &quot;false&quot;.
    /// </summary>
    [JsonPropertyName("emitWarning")]
    public bool? EmitWarning { get; set; }

    /// <summary>Deprecated, use failurePolicy under the webhookConfiguration instead.</summary>
    [JsonPropertyName("failurePolicy")]
    public V2beta1PolicySpecFailurePolicyEnum? FailurePolicy { get; set; }

    /// <summary>Deprecated, use generateExisting under the generate rule instead</summary>
    [JsonPropertyName("generateExisting")]
    public bool? GenerateExisting { get; set; }

    /// <summary>Deprecated, use generateExisting instead</summary>
    [JsonPropertyName("generateExistingOnPolicyUpdate")]
    public bool? GenerateExistingOnPolicyUpdate { get; set; }

    /// <summary>Deprecated, use mutateExistingOnPolicyUpdate under the mutate rule instead</summary>
    [JsonPropertyName("mutateExistingOnPolicyUpdate")]
    public bool? MutateExistingOnPolicyUpdate { get; set; }

    /// <summary>
    /// Rules is a list of Rule instances. A Policy contains multiple rules and
    /// each rule can validate, mutate, or generate resources.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V2beta1PolicySpecRules>? Rules { get; set; }

    /// <summary>Deprecated.</summary>
    [JsonPropertyName("schemaValidation")]
    public bool? SchemaValidation { get; set; }

    /// <summary>
    /// UseServerSideApply controls whether to use server-side apply for generate rules
    /// If is set to &quot;true&quot; create &amp; update for generate rules will use apply instead of create/update.
    /// Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("useServerSideApply")]
    public bool? UseServerSideApply { get; set; }

    /// <summary>Deprecated, use validationFailureAction under the validate rule instead.</summary>
    [JsonPropertyName("validationFailureAction")]
    public V2beta1PolicySpecValidationFailureActionEnum? ValidationFailureAction { get; set; }

    /// <summary>Deprecated, use validationFailureActionOverrides under the validate rule instead.</summary>
    [JsonPropertyName("validationFailureActionOverrides")]
    public IList<V2beta1PolicySpecValidationFailureActionOverrides>? ValidationFailureActionOverrides { get; set; }

    /// <summary>WebhookConfiguration specifies the custom configuration for Kubernetes admission webhookconfiguration.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V2beta1PolicySpecWebhookConfiguration? WebhookConfiguration { get; set; }

    /// <summary>Deprecated, use webhookTimeoutSeconds under webhookConfiguration instead.</summary>
    [JsonPropertyName("webhookTimeoutSeconds")]
    public int? WebhookTimeoutSeconds { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesCelPreconditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesContextApiCallMethodEnum>))]
public enum V2beta1PolicyStatusAutogenRulesContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicyStatusAutogenRulesContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicyStatusAutogenRulesContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicyStatusAutogenRulesContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicyStatusAutogenRulesContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicyStatusAutogenRulesContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicyStatusAutogenRulesContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicyStatusAutogenRulesContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicyStatusAutogenRulesContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicyStatusAutogenRulesContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum>))]
public enum V2beta1PolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAllResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAllResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAllSubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicyStatusAutogenRulesExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum>))]
public enum V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAnyResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAnySubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicyStatusAutogenRulesExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesExcludeResourcesOperationsEnum>))]
public enum V2beta1PolicyStatusAutogenRulesExcludeResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// ResourceDescription contains information about the resource being created or modified.
/// Requires at least one tag to be specified when under MatchResources.
/// Specifying ResourceDescription directly under match is being deprecated.
/// Please specify under &quot;any&quot; or &quot;all&quot; instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesExcludeResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExcludeSubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// ExcludeResources defines when this policy rule should not be applied. The exclude
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the name or role.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeAny>? Any { get; set; }

    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>
    /// ResourceDescription contains information about the resource being created or modified.
    /// Requires at least one tag to be specified when under MatchResources.
    /// Specifying ResourceDescription directly under match is being deprecated.
    /// Please specify under &quot;any&quot; or &quot;all&quot; instead.
    /// </summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicyStatusAutogenRulesExcludeResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicyStatusAutogenRulesExcludeSubjects>? Subjects { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateClone
{
    /// <summary>Name specifies name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateCloneListSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels`.
/// wildcard characters are not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateCloneList
{
    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels`.
    /// wildcard characters are not supported.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesGenerateCloneListSelector? Selector { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachClone
{
    /// <summary>Name specifies name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachCloneListSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels`.
/// wildcard characters are not supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateForeachCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachCloneList
{
    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>Namespace specifies source resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels`.
    /// wildcard characters are not supported.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachCloneListSelector? Selector { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum>))]
public enum V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachContextVariable? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerateForeach
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Clone specifies the source resource used to populate each generated resource.
    /// At most one of Data or Clone can be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("clone")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1PolicyStatusAutogenRulesGenerateForeachCloneList? CloneList { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateForeachContext>? Context { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// List specifies a JMESPath expression that results in one or more elements
    /// to which the validation logic is applied.
    /// </summary>
    [JsonPropertyName("list")]
    public string? List { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// AnyAllConditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Generation is used to create new resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesGenerate
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Clone specifies the source resource used to populate each generated resource.
    /// At most one of Data or Clone can be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("clone")]
    public V2beta1PolicyStatusAutogenRulesGenerateClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1PolicyStatusAutogenRulesGenerateCloneList? CloneList { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>ForEach applies generate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1PolicyStatusAutogenRulesGenerateForeach>? Foreach { get; set; }

    /// <summary>
    /// GenerateExisting controls whether to trigger the rule in existing resources
    /// If is set to &quot;true&quot; the rule will be triggered and applied to existing matched resources.
    /// </summary>
    [JsonPropertyName("generateExisting")]
    public bool? GenerateExisting { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// OrphanDownstreamOnPolicyDelete controls whether generated resources should be deleted when the rule that generated
    /// them is deleted with synchronization enabled. This option is only applicable to generate rules of the data type.
    /// See https://kyverno.io/docs/writing-policies/generate/#data-examples.
    /// Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("orphanDownstreamOnPolicyDelete")]
    public bool? OrphanDownstreamOnPolicyDelete { get; set; }

    /// <summary>
    /// Synchronize controls if generated resources should be kept in-sync with their source resource.
    /// If Synchronize is set to &quot;true&quot; changes to generated resources will be overwritten with resource
    /// data from Data or the resource specified in the Clone declaration.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("synchronize")]
    public bool? Synchronize { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesImageExtractors
{
    /// <summary>
    /// JMESPath is an optional JMESPath expression to apply to the image value.
    /// This is useful when the extracted image begins with a prefix like &apos;docker://&apos;.
    /// The &apos;trim_prefix&apos; function may be used to trim the prefix: trim_prefix(@, &apos;docker://&apos;).
    /// Note - Image digest mutation may not be used when applying a JMESPAth to an image.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Key is an optional name of the field within &apos;path&apos; that will be used to uniquely identify an image.
    /// Note - this field MUST be unique.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Name is the entry the image will be available under &apos;images.&lt;name&gt; &apos; in the context.
    /// If this field is not defined, image entries will appear under &apos;images.custom&apos;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path is the path to the object containing the image field in a custom resource.
    /// It should be slash-separated. Each slash-separated key must be a valid YAML key or a wildcard &apos;*&apos;.
    /// Wildcard keys are expanded in case of arrays or objects.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>
    /// Value is an optional name of the field within &apos;path&apos; that points to the image URI.
    /// This is useful when a custom &apos;key&apos; is also defined.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMatchAllResourcesOperationsEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMatchAllResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAllResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAllResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAllSubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicyStatusAutogenRulesMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAnyResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAnyResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAnySubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ResourceFilter allow users to &quot;AND&quot; or &quot;OR&quot; between resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicyStatusAutogenRulesMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchResourcesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector is a label selector for the resource namespace. Label keys and values
/// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
/// and `?` (matches one character).Wildcards allows writing label selectors like
/// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
/// does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>AdmissionOperation can have one of the values CREATE, UPDATE, CONNECT, DELETE, which are used to match a specific action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMatchResourcesOperationsEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMatchResourcesOperationsEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchResourcesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
/// characters `*` (matches zero or many characters) and `?` (matches one character).
/// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
/// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// ResourceDescription contains information about the resource being created or modified.
/// Requires at least one tag to be specified when under MatchResources.
/// Specifying ResourceDescription directly under match is being deprecated.
/// Please specify under &quot;any&quot; or &quot;all&quot; instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchResources
{
    /// <summary>
    /// Annotations is a  map of annotations (key-value pairs of type string). Annotation keys
    /// and values support the wildcard characters &quot;*&quot; (matches zero or many characters) and
    /// &quot;?&quot; (matches at least one character).
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Kinds is a list of resource kinds.</summary>
    [JsonPropertyName("kinds")]
    public IList<string>? Kinds { get; set; }

    /// <summary>
    /// Name is the name of the resource. The name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// NOTE: &quot;Name&quot; is being deprecated in favor of &quot;Names&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Names are the names of the resources. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// NamespaceSelector is a label selector for the resource namespace. Label keys and values
    /// in `matchLabels` support the wildcard characters `*` (matches zero or many characters)
    /// and `?` (matches one character).Wildcards allows writing label selectors like
    /// [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that using [&quot;*&quot; : &quot;*&quot;] matches any key and value but
    /// does not match an empty label set.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesMatchResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesMatchResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatchSubjects
{
    /// <summary>
    /// APIGroup holds the API group of the referenced subject.
    /// Defaults to &quot; &quot; for ServiceAccount subjects.
    /// Defaults to &quot;rbac.authorization.k8s.io&quot; for User and Group subjects.
    /// </summary>
    [JsonPropertyName("apiGroup")]
    public string? ApiGroup { get; set; }

    /// <summary>
    /// Kind of object being referenced. Values defined by this API group are &quot;User&quot;, &quot;Group&quot;, and &quot;ServiceAccount&quot;.
    /// If the Authorizer does not recognized the kind value, the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the object being referenced.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referenced object.  If the object kind is non-namespace, such as &quot;User&quot; or &quot;Group&quot;, and this value is not empty
    /// the Authorizer should report an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// MatchResources defines when this policy rule should be applied. The match
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the user name or role.
/// At least one kind is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchAny>? Any { get; set; }

    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>
    /// ResourceDescription contains information about the resource being created or modified.
    /// Requires at least one tag to be specified when under MatchResources.
    /// Specifying ResourceDescription directly under match is being deprecated.
    /// Please specify under &quot;any&quot; or &quot;all&quot; instead.
    /// </summary>
    [JsonPropertyName("resources")]
    public V2beta1PolicyStatusAutogenRulesMatchResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1PolicyStatusAutogenRulesMatchSubjects>? Subjects { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachContextVariable? Variable { get; set; }
}

/// <summary>
/// Order defines the iteration order on the list.
/// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMutateForeachOrderEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMutateForeachOrderEnum
{
    [EnumMember(Value = "Ascending"), JsonStringEnumMemberName("Ascending")]
    Ascending,
    [EnumMember(Value = "Descending"), JsonStringEnumMemberName("Descending")]
    Descending
}

/// <summary>ForEachMutation applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateForeach
{
    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateForeachContext>? Context { get; set; }

    /// <summary>Foreach declares a nested foreach iterator</summary>
    [JsonPropertyName("foreach")]
    public JsonNode? Foreach { get; set; }

    /// <summary>
    /// List specifies a JMESPath expression that results in one or more elements
    /// to which the validation logic is applied.
    /// </summary>
    [JsonPropertyName("list")]
    public string? List { get; set; }

    /// <summary>
    /// Order defines the iteration order on the list.
    /// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
    /// </summary>
    [JsonPropertyName("order")]
    public V2beta1PolicyStatusAutogenRulesMutateForeachOrderEnum? Order { get; set; }

    /// <summary>
    /// PatchStrategicMerge is a strategic merge patch used to modify resources.
    /// See https://kubernetes.io/docs/tasks/manage-kubernetes-objects/update-api-object-kubectl-patch/
    /// and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesstrategicmerge/.
    /// </summary>
    [JsonPropertyName("patchStrategicMerge")]
    public JsonNode? PatchStrategicMerge { get; set; }

    /// <summary>
    /// PatchesJSON6902 is a list of RFC 6902 JSON Patch declarations used to modify resources.
    /// See https://tools.ietf.org/html/rfc6902 and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesjson6902/.
    /// </summary>
    [JsonPropertyName("patchesJson6902")]
    public string? PatchesJson6902 { get; set; }

    /// <summary>
    /// AnyAllConditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Selector allows you to select target resources with their labels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargetsSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateTargetsSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>TargetResourceSpec defines targets for mutating existing resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutateTargets
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateTargetsContext>? Context { get; set; }

    /// <summary>Kind specifies resource kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name specifies the resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies resource namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Preconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements. A direct list
    /// of conditions (without `any` or `all` statements is supported for backwards compatibility but
    /// will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }

    /// <summary>Selector allows you to select target resources with their labels.</summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesMutateTargetsSelector? Selector { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Mutation is used to modify matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesMutate
{
    /// <summary>ForEach applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateForeach>? Foreach { get; set; }

    /// <summary>MutateExistingOnPolicyUpdate controls if the mutateExisting rule will be applied on policy events.</summary>
    [JsonPropertyName("mutateExistingOnPolicyUpdate")]
    public bool? MutateExistingOnPolicyUpdate { get; set; }

    /// <summary>
    /// PatchStrategicMerge is a strategic merge patch used to modify resources.
    /// See https://kubernetes.io/docs/tasks/manage-kubernetes-objects/update-api-object-kubectl-patch/
    /// and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesstrategicmerge/.
    /// </summary>
    [JsonPropertyName("patchStrategicMerge")]
    public JsonNode? PatchStrategicMerge { get; set; }

    /// <summary>
    /// PatchesJSON6902 is a list of RFC 6902 JSON Patch declarations used to modify resources.
    /// See https://tools.ietf.org/html/rfc6902 and https://kubectl.docs.kubernetes.io/references/kustomize/kustomization/patchesjson6902/.
    /// </summary>
    [JsonPropertyName("patchesJson6902")]
    public string? PatchesJson6902 { get; set; }

    /// <summary>Targets defines the target resources to be mutated.</summary>
    [JsonPropertyName("targets")]
    public IList<V2beta1PolicyStatusAutogenRulesMutateTargets>? Targets { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelAuditAnnotations
{
    /// <summary>
    /// key specifies the audit annotation key. The audit annotation keys of
    /// a ValidatingAdmissionPolicy must be unique. The key must be a qualified
    /// name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
    /// 
    /// The key is combined with the resource name of the
    /// ValidatingAdmissionPolicy to construct an audit annotation key:
    /// &quot;{ValidatingAdmissionPolicy name}/{key}&quot;.
    /// 
    /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy
    /// and the same audit annotation key, the annotation key will be identical.
    /// In this case, the first annotation written with the key will be included
    /// in the audit event and all subsequent annotations with the same key
    /// will be discarded.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// valueExpression represents the expression which is evaluated by CEL to
    /// produce an audit annotation value. The expression must evaluate to either
    /// a string or null value. If the expression evaluates to a string, the
    /// audit annotation is included with the string value. If the expression
    /// evaluates to null or empty string the audit annotation will be omitted.
    /// The valueExpression may be no longer than 5kb in length.
    /// If the result of the valueExpression is more than 10kb in length, it
    /// will be truncated to 10kb.
    /// 
    /// If multiple ValidatingAdmissionPolicyBinding resources match an
    /// API request, then the valueExpression will be evaluated for
    /// each binding. All unique values produced by the valueExpressions
    /// will be joined together in a comma-separated list.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; set; }
}

/// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelExpressions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL.
    /// ref: https://github.com/google/cel-spec
    /// CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
    /// 
    /// - &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// - &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// - &apos;request&apos; - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)).
    /// - &apos;params&apos; - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind.
    /// - &apos;namespaceObject&apos; - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources.
    /// - &apos;variables&apos; - Map of composited variables, from its name to its lazily evaluated value.
    ///   For example, a variable named &apos;foo&apos; can be accessed as &apos;variables.foo&apos;.
    /// - &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// - &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// 
    /// The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the
    /// object. No other metadata properties are accessible.
    /// 
    /// Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible.
    /// Accessible property names are escaped according to the following rules when accessed in the expression:
    /// - &apos;__&apos; escapes to &apos;__underscores__&apos;
    /// - &apos;.&apos; escapes to &apos;__dot__&apos;
    /// - &apos;-&apos; escapes to &apos;__dash__&apos;
    /// - &apos;/&apos; escapes to &apos;__slash__&apos;
    /// - Property names that exactly match a CEL RESERVED keyword escape to &apos;__{keyword}__&apos;. The keywords are:
    /// 	  &quot;true&quot;, &quot;false&quot;, &quot;null&quot;, &quot;in&quot;, &quot;as&quot;, &quot;break&quot;, &quot;const&quot;, &quot;continue&quot;, &quot;else&quot;, &quot;for&quot;, &quot;function&quot;, &quot;if&quot;,
    /// 	  &quot;import&quot;, &quot;let&quot;, &quot;loop&quot;, &quot;package&quot;, &quot;namespace&quot;, &quot;return&quot;.
    /// Examples:
    ///   - Expression accessing a property named &quot;namespace&quot;: {&quot;Expression&quot;: &quot;object.__namespace__ &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;x-prop&quot;: {&quot;Expression&quot;: &quot;object.x__dash__prop &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;redact__d&quot;: {&quot;Expression&quot;: &quot;object.redact__underscores__d &gt; 0&quot;}
    /// 
    /// Equality on arrays with list type of &apos;set&apos; or &apos;map&apos; ignores element order, i.e. [1, 2] == [2, 1].
    /// Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
    ///   - &apos;set&apos;: `X + Y` performs a union where the array positions of all elements in `X` are preserved and
    ///     non-intersecting elements in `Y` are appended, retaining their partial order.
    ///   - &apos;map&apos;: `X + Y` performs a merge where the array positions of all keys in `X` are preserved but the values
    ///     are overwritten by values in `Y` when the key sets of `X` and `Y` intersect. Elements in `Y` with
    ///     non-intersecting keys are appended, retaining their partial order.
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Message represents the message displayed when validation fails. The message is required if the Expression contains
    /// line breaks. The message must not contain line breaks.
    /// If unset, the message is &quot;failed rule: {Rule}&quot;.
    /// e.g. &quot;must be a URL with the host matching spec.host&quot;
    /// If the Expression contains line breaks. Message is required.
    /// The message must not contain line breaks.
    /// If unset, the message is &quot;failed Expression: {Expression}&quot;.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.
    /// Since messageExpression is used as a failure message, it must evaluate to a string.
    /// If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails.
    /// If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced
    /// as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string
    /// that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and
    /// the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged.
    /// messageExpression has access to all the same variables as the `expression` except for &apos;authorizer&apos; and &apos;authorizer.requestResource&apos;.
    /// Example:
    /// &quot;object.x must be less than max (&quot;+string(params.max)+&quot;)&quot;
    /// </summary>
    [JsonPropertyName("messageExpression")]
    public string? MessageExpression { get; set; }

    /// <summary>
    /// Reason represents a machine-readable description of why this validation failed.
    /// If this is the first validation in the list to fail, this reason, as well as the
    /// corresponding HTTP response code, are used in the
    /// HTTP response to the client.
    /// The currently supported reasons are: &quot;Unauthorized&quot;, &quot;Forbidden&quot;, &quot;Invalid&quot;, &quot;RequestEntityTooLarge&quot;.
    /// If not set, StatusReasonInvalid is used in the response to the client.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelParamKind
{
    /// <summary>
    /// APIVersion is the API group version the resources belong to.
    /// In format of &quot;group/version&quot;.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Kind is the API kind the resources belong to.
    /// Required.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelParamRefSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// selector can be used to match multiple param objects based on their labels.
/// Supply selector: {} to match all resources of the ParamKind.
/// 
/// If multiple params are found, they are all evaluated with the policy expressions
/// and the results are ANDed together.
/// 
/// One of `name` or `selector` must be set, but `name` and `selector` are
/// mutually exclusive properties. If one is set, the other must be unset.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelParamRefSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateCelParamRefSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>ParamRef references a parameter resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelParamRef
{
    /// <summary>
    /// name is the name of the resource being referenced.
    /// 
    /// One of `name` or `selector` must be set, but `name` and `selector` are
    /// mutually exclusive properties. If one is set, the other must be unset.
    /// 
    /// A single parameter used for all admission requests can be configured
    /// by setting the `name` field, leaving `selector` blank, and setting namespace
    /// if `paramKind` is namespace-scoped.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// namespace is the namespace of the referenced resource. Allows limiting
    /// the search for params to a specific namespace. Applies to both `name` and
    /// `selector` fields.
    /// 
    /// A per-namespace parameter may be used by specifying a namespace-scoped
    /// `paramKind` in the policy and leaving this field empty.
    /// 
    /// - If `paramKind` is cluster-scoped, this field MUST be unset. Setting this
    /// field results in a configuration error.
    /// 
    /// - If `paramKind` is namespace-scoped, the namespace of the object being
    /// evaluated for admission will be used when this field is left unset. Take
    /// care that if this is left empty the binding must not match any cluster-scoped
    /// resources, which will result in an error.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// `parameterNotFoundAction` controls the behavior of the binding when the resource
    /// exists, and name or selector is valid, but there are no parameters
    /// matched by the binding. If the value is set to `Allow`, then no
    /// matched parameters will be treated as successful validation by the binding.
    /// If set to `Deny`, then no matched parameters will be subject to the
    /// `failurePolicy` of the policy.
    /// 
    /// Allowed values are `Allow` or `Deny`
    /// 
    /// Required
    /// </summary>
    [JsonPropertyName("parameterNotFoundAction")]
    public string? ParameterNotFoundAction { get; set; }

    /// <summary>
    /// selector can be used to match multiple param objects based on their labels.
    /// Supply selector: {} to match all resources of the ParamKind.
    /// 
    /// If multiple params are found, they are all evaluated with the policy expressions
    /// and the results are ANDed together.
    /// 
    /// One of `name` or `selector` must be set, but `name` and `selector` are
    /// mutually exclusive properties. If one is set, the other must be unset.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1PolicyStatusAutogenRulesValidateCelParamRefSelector? Selector { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCelVariables
{
    /// <summary>
    /// Expression is the expression that will be evaluated as the value of the variable.
    /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is the name of the variable. The name must be a valid CEL identifier and unique among all variables.
    /// The variable can be accessed in other expressions through `variables`
    /// For example, if name is &quot;foo&quot;, the variable will be available as `variables.foo`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CEL allows validation checks using the Common Expression Language (https://kubernetes.io/docs/reference/using-api/cel/).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateCel
{
    /// <summary>AuditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateCelAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>Expressions is a list of CELExpression types.</summary>
    [JsonPropertyName("expressions")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateCelExpressions>? Expressions { get; set; }

    /// <summary>
    /// Generate specifies whether to generate a Kubernetes ValidatingAdmissionPolicy from the rule.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("generate")]
    public bool? Generate { get; set; }

    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    [JsonPropertyName("paramKind")]
    public V2beta1PolicyStatusAutogenRulesValidateCelParamKind? ParamKind { get; set; }

    /// <summary>ParamRef references a parameter resource.</summary>
    [JsonPropertyName("paramRef")]
    public V2beta1PolicyStatusAutogenRulesValidateCelParamRef? ParamRef { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateCelVariables>? Variables { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement. A direct list
    /// of conditions (without `any` or `all` statements) is also supported for backwards compatibility
    /// but will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public JsonNode? Conditions { get; set; }
}

/// <summary>
/// FailureAction defines if a validation policy rule violation should block
/// the admission review request (Enforce), or allow (Audit) the admission review request
/// and report an error in a policy report. Optional.
/// Allowed values are Audit or Enforce.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidateFailureActionEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidateFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum
{
    [EnumMember(Value = "audit"), JsonStringEnumMemberName("audit")]
    Audit,
    [EnumMember(Value = "enforce"), JsonStringEnumMemberName("enforce")]
    Enforce,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit1,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce1
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A label selector is a label query over a set of resources. The result of matchLabels and
/// matchExpressions are ANDed. An empty label selector matches all objects. A null
/// label selector matches no objects.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallData
{
    /// <summary>Key is a unique identifier for the data value</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the data value</summary>
    [JsonPropertyName("value")]
    public required JsonNode Value { get; set; }
}

/// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallServiceHeaders
{
    /// <summary>Key is the header key</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the header value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Service is an API call to a JSON web service.
/// This is used for non-Kubernetes API server calls.
/// It&apos;s mutually exclusive with the URLPath field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
/// The data returned is stored in the context with the name for the context entry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallData>? Data { get; set; }

    /// <summary>
    /// Default is an optional arbitrary JSON object that the context
    /// value is set to, if the apiCall returns error.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCallService? Service { get; set; }

    /// <summary>
    /// URLPath is the URL path to be used in the HTTP GET or POST request to the
    /// Kubernetes API server (e.g. &quot;/api/v1/namespaces&quot; or  &quot;/apis/apps/v1/deployments&quot;).
    /// The format required is the same format used by the `kubectl get --raw` command.
    /// See https://kyverno.io/docs/writing-policies/external-data-sources/#variables-from-kubernetes-api-server-calls
    /// for details.
    /// It&apos;s mutually exclusive with the Service field.
    /// </summary>
    [JsonPropertyName("urlPath")]
    public string? UrlPath { get; set; }
}

/// <summary>ConfigMap is the ConfigMap reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextConfigMap
{
    /// <summary>Name is the ConfigMap name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the ConfigMap namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextGlobalReference
{
    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the JSON response returned from the server. For example
    /// a JMESPath of &quot;items | length(@)&quot; applied to the API server response
    /// for the URLPath &quot;/apis/apps/v1/deployments&quot; will return the total count
    /// of deployments across all namespaces.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Name of the global context entry</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>
    /// JMESPath is an optional JSON Match Expression that can be used to
    /// transform the ImageData struct returned as a result of processing
    /// the image reference.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>
    /// Reference is image reference to a container image in the registry.
    /// Example: ghcr.io/kyverno/kyverno:latest
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }
}

/// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContextVariable
{
    /// <summary>
    /// Default is an optional arbitrary JSON object that the variable may take if the JMESPath
    /// expression evaluates to nil
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; set; }

    /// <summary>
    /// JMESPath is an optional JMESPath Expression that can be used to
    /// transform the variable.
    /// </summary>
    [JsonPropertyName("jmesPath")]
    public string? JmesPath { get; set; }

    /// <summary>Value is any arbitrary JSON object representable in YAML or JSON form.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// ContextEntry adds variables and data sources to a rule Context. Either a
/// ConfigMap reference or a APILookup must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachContextVariable? Variable { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeachDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement. A direct list
    /// of conditions (without `any` or `all` statements) is also supported for backwards compatibility
    /// but will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public JsonNode? Conditions { get; set; }
}

/// <summary>ForEachValidation applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateForeach
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateForeachContext>? Context { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1PolicyStatusAutogenRulesValidateForeachDeny? Deny { get; set; }

    /// <summary>
    /// ElementScope specifies whether to use the current list element as the scope for validation. Defaults to &quot;true&quot; if not specified.
    /// When set to &quot;false&quot;, &quot;request.object&quot; is used as the validation scope within the foreach
    /// block to allow referencing other elements in the subtree.
    /// </summary>
    [JsonPropertyName("elementScope")]
    public bool? ElementScope { get; set; }

    /// <summary>Foreach declares a nested foreach iterator</summary>
    [JsonPropertyName("foreach")]
    public JsonNode? Foreach { get; set; }

    /// <summary>
    /// List specifies a JMESPath expression that results in one or more elements
    /// to which the validation logic is applied.
    /// </summary>
    [JsonPropertyName("list")]
    public string? List { get; set; }

    /// <summary>Pattern specifies an overlay-style pattern used to check resources.</summary>
    [JsonPropertyName("pattern")]
    public JsonNode? Pattern { get; set; }

    /// <summary>
    /// AnyAllConditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Certificates specifies one or more certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificates
{
    /// <summary>Cert is an optional PEM-encoded public certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>CertChain is an optional PEM encoded set of certificates used to verify.</summary>
    [JsonPropertyName("certChain")]
    public string? CertChain { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
/// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

    /// <summary>Issuer is the certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp is the regular expression to match certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessRekor? Rekor { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>Subject is the verified identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp is the regular expression to match identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference to a Secret resource that contains a public key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysSecret
{
    /// <summary>Name of the secret. The provided secret must contain a key named cosign.pub.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace name where the Secret exists.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Keys specifies one or more public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

    /// <summary>
    /// KMS provides the URI to the public key stored in a Key Management System. See:
    /// https://github.com/sigstore/cosign/blob/main/KMS.md
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }

    /// <summary>
    /// Keys is a set of X.509 public keys used to verify image signatures. The keys can be directly
    /// specified or can be a variable reference to a key specified in a ConfigMap (see
    /// https://kyverno.io/docs/writing-policies/variables/), or reference a standard Kubernetes Secret
    /// elsewhere in the cluster by specifying it in the format &quot;k8s://&lt;namespace&gt;/&lt;secret_name&gt; &quot;.
    /// The named Secret must specify a key `cosign.pub` containing the public key used for
    /// verification, (see https://github.com/sigstore/cosign/blob/main/KMS.md#kubernetes-secret).
    /// When multiple keys are specified each key is processed as a separate staticKey entry
    /// (.attestors[*].entries.keys) within the set of attestors and the count is applied across the keys.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public string? PublicKeys { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntries
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Attestor is a nested set of Attestor used to specify a more complex set of match authorities.</summary>
    [JsonPropertyName("attestor")]
    public JsonNode? Attestor { get; set; }

    /// <summary>Certificates specifies one or more certificates.</summary>
    [JsonPropertyName("certificates")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeys? Keys { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for signatures and attestations that match this rule.
    /// If specified Repository will override other OCI image repository locations for this Attestor.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Specify signature algorithm for public keys. Supported values are sha224, sha256, sha384 and sha512.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsAttestors
{
    /// <summary>
    /// Count specifies the required number of entries that must match. If the count is null, all entries must match
    /// (a logical AND). If the count is 1, at least one entry must match (a logical OR). If the count contains a
    /// value N, then N must be less than or equal to the size of entries, and at least N entries must match.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Entries contains the available attestors. An attestor can be a static key,
    /// attributes for keyless verification, or a nested attestor declaration.
    /// </summary>
    [JsonPropertyName("entries")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateManifestsAttestorsEntries>? Entries { get; set; }
}

/// <summary>DryRun configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsDryRun
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsIgnoreFieldsObjects
{
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifestsIgnoreFields
{
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    [JsonPropertyName("objects")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateManifestsIgnoreFieldsObjects>? Objects { get; set; }
}

/// <summary>Manifest specifies conditions for manifest verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidateManifests
{
    /// <summary>AnnotationDomain is custom domain of annotation for message and signature. Default is &quot;cosign.sigstore.dev&quot;.</summary>
    [JsonPropertyName("annotationDomain")]
    public string? AnnotationDomain { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateManifestsAttestors>? Attestors { get; set; }

    /// <summary>DryRun configuration</summary>
    [JsonPropertyName("dryRun")]
    public V2beta1PolicyStatusAutogenRulesValidateManifestsDryRun? DryRun { get; set; }

    /// <summary>Fields which will be ignored while comparing manifests.</summary>
    [JsonPropertyName("ignoreFields")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateManifestsIgnoreFields>? IgnoreFields { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for resource bundle reference.
    /// The repository can be overridden per Attestor or Attestation.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// ControlName specifies the name of the Pod Security Standard control.
/// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum
{
    [EnumMember(Value = "HostProcess"), JsonStringEnumMemberName("HostProcess")]
    HostProcess,
    [EnumMember(Value = "Host Namespaces"), JsonStringEnumMemberName("Host Namespaces")]
    HostNamespaces,
    [EnumMember(Value = "Privileged Containers"), JsonStringEnumMemberName("Privileged Containers")]
    PrivilegedContainers,
    [EnumMember(Value = "Capabilities"), JsonStringEnumMemberName("Capabilities")]
    Capabilities,
    [EnumMember(Value = "HostPath Volumes"), JsonStringEnumMemberName("HostPath Volumes")]
    HostPathVolumes,
    [EnumMember(Value = "Host Ports"), JsonStringEnumMemberName("Host Ports")]
    HostPorts,
    [EnumMember(Value = "AppArmor"), JsonStringEnumMemberName("AppArmor")]
    AppArmor,
    [EnumMember(Value = "SELinux"), JsonStringEnumMemberName("SELinux")]
    SELinux,
    [EnumMember(Value = "/proc Mount Type"), JsonStringEnumMemberName("/proc Mount Type")]
    ProcMountType,
    [EnumMember(Value = "Seccomp"), JsonStringEnumMemberName("Seccomp")]
    Seccomp,
    [EnumMember(Value = "Sysctls"), JsonStringEnumMemberName("Sysctls")]
    Sysctls,
    [EnumMember(Value = "Volume Types"), JsonStringEnumMemberName("Volume Types")]
    VolumeTypes,
    [EnumMember(Value = "Privilege Escalation"), JsonStringEnumMemberName("Privilege Escalation")]
    PrivilegeEscalation,
    [EnumMember(Value = "Running as Non-root"), JsonStringEnumMemberName("Running as Non-root")]
    RunningAsNonRoot,
    [EnumMember(Value = "Running as Non-root user"), JsonStringEnumMemberName("Running as Non-root user")]
    RunningAsNonRootUser
}

/// <summary>PodSecurityStandard specifies the Pod Security Standard controls to be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidatePodSecurityExclude
{
    /// <summary>
    /// ControlName specifies the name of the Pod Security Standard control.
    /// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
    /// </summary>
    [JsonPropertyName("controlName")]
    public required V2beta1PolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum ControlName { get; set; }

    /// <summary>
    /// Images selects matching containers and applies the container level PSS.
    /// Each image is the image name consisting of the registry address, repository, image, and tag.
    /// Empty list matches no containers, PSS checks are applied at the pod level only.
    /// Wildcards (&apos;*&apos; and &apos;?&apos;) are allowed. See: https://kubernetes.io/docs/concepts/containers/images.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>
    /// RestrictedField selects the field for the given Pod Security Standard control.
    /// When not set, all restricted fields for the control are selected.
    /// </summary>
    [JsonPropertyName("restrictedField")]
    public string? RestrictedField { get; set; }

    /// <summary>Values defines the allowed values that can be excluded.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Level defines the Pod Security Standard level to be applied to workloads.
/// Allowed values are privileged, baseline, and restricted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidatePodSecurityLevelEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidatePodSecurityLevelEnum
{
    [EnumMember(Value = "privileged"), JsonStringEnumMemberName("privileged")]
    Privileged,
    [EnumMember(Value = "baseline"), JsonStringEnumMemberName("baseline")]
    Baseline,
    [EnumMember(Value = "restricted"), JsonStringEnumMemberName("restricted")]
    Restricted
}

/// <summary>
/// Version defines the Pod Security Standard versions that Kubernetes supports.
/// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesValidatePodSecurityVersionEnum>))]
public enum V2beta1PolicyStatusAutogenRulesValidatePodSecurityVersionEnum
{
    [EnumMember(Value = "v1.19"), JsonStringEnumMemberName("v1.19")]
    V119,
    [EnumMember(Value = "v1.20"), JsonStringEnumMemberName("v1.20")]
    V120,
    [EnumMember(Value = "v1.21"), JsonStringEnumMemberName("v1.21")]
    V121,
    [EnumMember(Value = "v1.22"), JsonStringEnumMemberName("v1.22")]
    V122,
    [EnumMember(Value = "v1.23"), JsonStringEnumMemberName("v1.23")]
    V123,
    [EnumMember(Value = "v1.24"), JsonStringEnumMemberName("v1.24")]
    V124,
    [EnumMember(Value = "v1.25"), JsonStringEnumMemberName("v1.25")]
    V125,
    [EnumMember(Value = "v1.26"), JsonStringEnumMemberName("v1.26")]
    V126,
    [EnumMember(Value = "v1.27"), JsonStringEnumMemberName("v1.27")]
    V127,
    [EnumMember(Value = "v1.28"), JsonStringEnumMemberName("v1.28")]
    V128,
    [EnumMember(Value = "v1.29"), JsonStringEnumMemberName("v1.29")]
    V129,
    [EnumMember(Value = "v1.30"), JsonStringEnumMemberName("v1.30")]
    V130,
    [EnumMember(Value = "v1.31"), JsonStringEnumMemberName("v1.31")]
    V131,
    [EnumMember(Value = "v1.32"), JsonStringEnumMemberName("v1.32")]
    V132,
    [EnumMember(Value = "latest"), JsonStringEnumMemberName("latest")]
    Latest
}

/// <summary>
/// PodSecurity applies exemptions for Kubernetes Pod Security admission
/// by specifying exclusions for Pod Security Standards controls.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidatePodSecurity
{
    /// <summary>Exclude specifies the Pod Security Standard controls to be excluded.</summary>
    [JsonPropertyName("exclude")]
    public IList<V2beta1PolicyStatusAutogenRulesValidatePodSecurityExclude>? Exclude { get; set; }

    /// <summary>
    /// Level defines the Pod Security Standard level to be applied to workloads.
    /// Allowed values are privileged, baseline, and restricted.
    /// </summary>
    [JsonPropertyName("level")]
    public V2beta1PolicyStatusAutogenRulesValidatePodSecurityLevelEnum? Level { get; set; }

    /// <summary>
    /// Version defines the Pod Security Standard versions that Kubernetes supports.
    /// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
    /// </summary>
    [JsonPropertyName("version")]
    public V2beta1PolicyStatusAutogenRulesValidatePodSecurityVersionEnum? Version { get; set; }
}

/// <summary>Validation is used to validate matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesValidate
{
    /// <summary>AllowExistingViolations allows prexisting violating resources to continue violating a policy.</summary>
    [JsonPropertyName("allowExistingViolations")]
    public bool? AllowExistingViolations { get; set; }

    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Assert defines a kyverno-json assertion tree.</summary>
    [JsonPropertyName("assert")]
    public JsonNode? Assert { get; set; }

    /// <summary>CEL allows validation checks using the Common Expression Language (https://kubernetes.io/docs/reference/using-api/cel/).</summary>
    [JsonPropertyName("cel")]
    public V2beta1PolicyStatusAutogenRulesValidateCel? Cel { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1PolicyStatusAutogenRulesValidateDeny? Deny { get; set; }

    /// <summary>
    /// FailureAction defines if a validation policy rule violation should block
    /// the admission review request (Enforce), or allow (Audit) the admission review request
    /// and report an error in a policy report. Optional.
    /// Allowed values are Audit or Enforce.
    /// </summary>
    [JsonPropertyName("failureAction")]
    public V2beta1PolicyStatusAutogenRulesValidateFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// FailureActionOverrides is a Cluster Policy attribute that specifies FailureAction
    /// namespace-wise. It overrides FailureAction for the specified namespaces.
    /// </summary>
    [JsonPropertyName("failureActionOverrides")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateFailureActionOverrides>? FailureActionOverrides { get; set; }

    /// <summary>ForEach applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1PolicyStatusAutogenRulesValidateForeach>? Foreach { get; set; }

    /// <summary>Manifest specifies conditions for manifest verification</summary>
    [JsonPropertyName("manifests")]
    public V2beta1PolicyStatusAutogenRulesValidateManifests? Manifests { get; set; }

    /// <summary>Message specifies a custom message to be displayed on failure.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Pattern specifies an overlay-style pattern used to check resources.</summary>
    [JsonPropertyName("pattern")]
    public JsonNode? Pattern { get; set; }

    /// <summary>
    /// PodSecurity applies exemptions for Kubernetes Pod Security admission
    /// by specifying exclusions for Pod Security Standards controls.
    /// </summary>
    [JsonPropertyName("podSecurity")]
    public V2beta1PolicyStatusAutogenRulesValidatePodSecurity? PodSecurity { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Certificates specifies one or more certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificates
{
    /// <summary>Cert is an optional PEM-encoded public certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>CertChain is an optional PEM encoded set of certificates used to verify.</summary>
    [JsonPropertyName("certChain")]
    public string? CertChain { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
/// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

    /// <summary>Issuer is the certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp is the regular expression to match certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor? Rekor { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>Subject is the verified identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp is the regular expression to match identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference to a Secret resource that contains a public key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret
{
    /// <summary>Name of the secret. The provided secret must contain a key named cosign.pub.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace name where the Secret exists.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Keys specifies one or more public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

    /// <summary>
    /// KMS provides the URI to the public key stored in a Key Management System. See:
    /// https://github.com/sigstore/cosign/blob/main/KMS.md
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }

    /// <summary>
    /// Keys is a set of X.509 public keys used to verify image signatures. The keys can be directly
    /// specified or can be a variable reference to a key specified in a ConfigMap (see
    /// https://kyverno.io/docs/writing-policies/variables/), or reference a standard Kubernetes Secret
    /// elsewhere in the cluster by specifying it in the format &quot;k8s://&lt;namespace&gt;/&lt;secret_name&gt; &quot;.
    /// The named Secret must specify a key `cosign.pub` containing the public key used for
    /// verification, (see https://github.com/sigstore/cosign/blob/main/KMS.md#kubernetes-secret).
    /// When multiple keys are specified each key is processed as a separate staticKey entry
    /// (.attestors[*].entries.keys) within the set of attestors and the count is applied across the keys.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public string? PublicKeys { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntries
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Attestor is a nested set of Attestor used to specify a more complex set of match authorities.</summary>
    [JsonPropertyName("attestor")]
    public JsonNode? Attestor { get; set; }

    /// <summary>Certificates specifies one or more certificates.</summary>
    [JsonPropertyName("certificates")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeys? Keys { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for signatures and attestations that match this rule.
    /// If specified Repository will override other OCI image repository locations for this Attestor.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Specify signature algorithm for public keys. Supported values are sha224, sha256, sha384 and sha512.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestors
{
    /// <summary>
    /// Count specifies the required number of entries that must match. If the count is null, all entries must match
    /// (a logical AND). If the count is 1, at least one entry must match (a logical OR). If the count contains a
    /// value N, then N must be less than or equal to the size of entries, and at least N entries must match.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Entries contains the available attestors. An attestor can be a static key,
    /// attributes for keyless verification, or a nested attestor declaration.
    /// </summary>
    [JsonPropertyName("entries")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntries>? Entries { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum>))]
public enum V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

/// <summary>Condition defines variable-based conditional criteria for rule execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAll
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum>))]
public enum V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "NotEquals"), JsonStringEnumMemberName("NotEquals")]
    NotEquals,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "AnyIn"), JsonStringEnumMemberName("AnyIn")]
    AnyIn,
    [EnumMember(Value = "AllIn"), JsonStringEnumMemberName("AllIn")]
    AllIn,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn,
    [EnumMember(Value = "AnyNotIn"), JsonStringEnumMemberName("AnyNotIn")]
    AnyNotIn,
    [EnumMember(Value = "AllNotIn"), JsonStringEnumMemberName("AllNotIn")]
    AllNotIn,
    [EnumMember(Value = "GreaterThanOrEquals"), JsonStringEnumMemberName("GreaterThanOrEquals")]
    GreaterThanOrEquals,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "LessThanOrEquals"), JsonStringEnumMemberName("LessThanOrEquals")]
    LessThanOrEquals,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "DurationGreaterThanOrEquals"), JsonStringEnumMemberName("DurationGreaterThanOrEquals")]
    DurationGreaterThanOrEquals,
    [EnumMember(Value = "DurationGreaterThan"), JsonStringEnumMemberName("DurationGreaterThan")]
    DurationGreaterThan,
    [EnumMember(Value = "DurationLessThanOrEquals"), JsonStringEnumMemberName("DurationLessThanOrEquals")]
    DurationLessThanOrEquals,
    [EnumMember(Value = "DurationLessThan"), JsonStringEnumMemberName("DurationLessThan")]
    DurationLessThan
}

/// <summary>Condition defines variable-based conditional criteria for rule execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAny
{
    /// <summary>Key is the context entry (using JMESPath) for conditional rule evaluation.</summary>
    [JsonPropertyName("key")]
    public JsonNode? Key { get; set; }

    /// <summary>Message is an optional display message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Operator is the conditional operation to perform. Valid operators are:
    /// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
    /// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
    /// DurationLessThanOrEquals, DurationLessThan
    /// </summary>
    [JsonPropertyName("operator")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>
/// AnyAllConditions consists of conditions wrapped denoting a logical criteria to be fulfilled.
/// AnyConditions get fulfilled when at least one of its sub-conditions passes.
/// AllConditions get fulfilled only when all of its sub-conditions pass.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAny>? Any { get; set; }
}

/// <summary>
/// Attestation are checks for signed in-toto Statements that are used to verify the image.
/// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
/// OCI registry and decodes them into a list of Statements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestations
{
    /// <summary>Attestors specify the required attestors (i.e. authorities).</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestors>? Attestors { get; set; }

    /// <summary>
    /// Conditions are used to verify attributes within a Predicate. If no Conditions are specified
    /// the attestation check is satisfied as long there are predicates that match the predicate type.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestationsConditions>? Conditions { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Deprecated in favour of &apos;Type&apos;, to be removed soon</summary>
    [JsonPropertyName("predicateType")]
    public string? PredicateType { get; set; }

    /// <summary>Type defines the type of attestation contained within the Statement.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Certificates specifies one or more certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificates
{
    /// <summary>Cert is an optional PEM-encoded public certificate.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>CertChain is an optional PEM encoded set of certificates used to verify.</summary>
    [JsonPropertyName("certChain")]
    public string? CertChain { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
/// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

    /// <summary>Issuer is the certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp is the regular expression to match certificate issuer used for keyless signing.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessRekor? Rekor { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>Subject is the verified identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp is the regular expression to match identity used for keyless signing, for example the email address.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysCtlog
{
    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("ignoreSCT")]
    public bool? IgnoreSCT { get; set; }

    /// <summary>PubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }
}

/// <summary>
/// Rekor provides configuration for the Rekor transparency log service. If an empty object
/// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysRekor
{
    /// <summary>IgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("ignoreTlog")]
    public bool? IgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("pubkey")]
    public string? Pubkey { get; set; }

    /// <summary>URL is the address of the transparency log. Defaults to the public Rekor log instance https://rekor.sigstore.dev.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Reference to a Secret resource that contains a public key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysSecret
{
    /// <summary>Name of the secret. The provided secret must contain a key named cosign.pub.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace name where the Secret exists.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Keys specifies one or more public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysCtlog? Ctlog { get; set; }

    /// <summary>
    /// KMS provides the URI to the public key stored in a Key Management System. See:
    /// https://github.com/sigstore/cosign/blob/main/KMS.md
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }

    /// <summary>
    /// Keys is a set of X.509 public keys used to verify image signatures. The keys can be directly
    /// specified or can be a variable reference to a key specified in a ConfigMap (see
    /// https://kyverno.io/docs/writing-policies/variables/), or reference a standard Kubernetes Secret
    /// elsewhere in the cluster by specifying it in the format &quot;k8s://&lt;namespace&gt;/&lt;secret_name&gt; &quot;.
    /// The named Secret must specify a key `cosign.pub` containing the public key used for
    /// verification, (see https://github.com/sigstore/cosign/blob/main/KMS.md#kubernetes-secret).
    /// When multiple keys are specified each key is processed as a separate staticKey entry
    /// (.attestors[*].entries.keys) within the set of attestors and the count is applied across the keys.
    /// </summary>
    [JsonPropertyName("publicKeys")]
    public string? PublicKeys { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntries
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Attestor is a nested set of Attestor used to specify a more complex set of match authorities.</summary>
    [JsonPropertyName("attestor")]
    public JsonNode? Attestor { get; set; }

    /// <summary>Certificates specifies one or more certificates.</summary>
    [JsonPropertyName("certificates")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeys? Keys { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for signatures and attestations that match this rule.
    /// If specified Repository will override other OCI image repository locations for this Attestor.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Specify signature algorithm for public keys. Supported values are sha224, sha256, sha384 and sha512.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesAttestors
{
    /// <summary>
    /// Count specifies the required number of entries that must match. If the count is null, all entries must match
    /// (a logical AND). If the count is 1, at least one entry must match (a logical OR). If the count contains a
    /// value N, then N must be less than or equal to the size of entries, and at least N entries must match.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Entries contains the available attestors. An attestor can be a static key,
    /// attributes for keyless verification, or a nested attestor declaration.
    /// </summary>
    [JsonPropertyName("entries")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestorsEntries>? Entries { get; set; }
}

/// <summary>Allowed values are Audit or Enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesVerifyImagesFailureActionEnum>))]
public enum V2beta1PolicyStatusAutogenRulesVerifyImagesFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets can be specified as a name (Kyverno namespace) or namespace/name.
    /// imagePullSecrets from the resource namespace are also used.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>
/// Type specifies the method of signature validation. The allowed options
/// are Cosign, Sigstore Bundle and Notary. By default Cosign is used if a type is not specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusAutogenRulesVerifyImagesTypeEnum>))]
public enum V2beta1PolicyStatusAutogenRulesVerifyImagesTypeEnum
{
    [EnumMember(Value = "Cosign"), JsonStringEnumMemberName("Cosign")]
    Cosign,
    [EnumMember(Value = "SigstoreBundle"), JsonStringEnumMemberName("SigstoreBundle")]
    SigstoreBundle,
    [EnumMember(Value = "Notary"), JsonStringEnumMemberName("Notary")]
    Notary
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesValidateDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement. A direct list
    /// of conditions (without `any` or `all` statements) is also supported for backwards compatibility
    /// but will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public JsonNode? Conditions { get; set; }
}

/// <summary>
/// Validation checks conditions across multiple image
/// verification attestations or context entries
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImagesValidate
{
    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesValidateDeny? Deny { get; set; }

    /// <summary>Message specifies a custom message to be displayed on failure.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// ImageVerification validates that images that match the specified pattern
/// are signed with the supplied public key. Once the image is verified it is
/// mutated to include the SHA digest retrieved during the registration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRulesVerifyImages
{
    /// <summary>Deprecated.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>Deprecated. Use annotations per Attestor instead.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Attestations are optional checks for signed in-toto Statements used to verify the image.
    /// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
    /// OCI registry and decodes them into a list of Statement declarations.
    /// </summary>
    [JsonPropertyName("attestations")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestations>? Attestations { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImagesAttestors>? Attestors { get; set; }

    /// <summary>
    /// CosignOCI11 enables the experimental OCI 1.1 behaviour in cosign image verification.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("cosignOCI11")]
    public bool? CosignOCI11 { get; set; }

    /// <summary>Allowed values are Audit or Enforce.</summary>
    [JsonPropertyName("failureAction")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesFailureActionEnum? FailureAction { get; set; }

    /// <summary>Deprecated. Use ImageReferences instead.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// ImageReferences is a list of matching image reference patterns. At least one pattern in the
    /// list must match the image for the rule to apply. Each image reference consists of a registry
    /// address (defaults to docker.io), repository, image, and tag (defaults to latest).
    /// Wildcards (&apos;*&apos; and &apos;?&apos;) are allowed. See: https://kubernetes.io/docs/concepts/containers/images.
    /// </summary>
    [JsonPropertyName("imageReferences")]
    public IList<string>? ImageReferences { get; set; }

    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry.</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentials? ImageRegistryCredentials { get; set; }

    /// <summary>Deprecated. Use KeylessAttestor instead.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Deprecated. Use StaticKeyAttestor instead.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// MutateDigest enables replacement of image tags with digests.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("mutateDigest")]
    public bool? MutateDigest { get; set; }

    /// <summary>
    /// Repository is an optional alternate OCI repository to use for image signatures and attestations that match this rule.
    /// If specified Repository will override the default OCI image repository configured for the installation.
    /// The repository can also be overridden per Attestor or Attestation.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Required validates that images are verified i.e. have matched passed a signature or attestation check.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Deprecated. Use KeylessAttestor instead.</summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }

    /// <summary>
    /// SkipImageReferences is a list of matching image reference patterns that should be skipped.
    /// At least one pattern in the list must match the image for the rule to be skipped. Each image reference
    /// consists of a registry address (defaults to docker.io), repository, image, and tag (defaults to latest).
    /// Wildcards (&apos;*&apos; and &apos;?&apos;) are allowed. See: https://kubernetes.io/docs/concepts/containers/images.
    /// </summary>
    [JsonPropertyName("skipImageReferences")]
    public IList<string>? SkipImageReferences { get; set; }

    /// <summary>Deprecated. Use KeylessAttestor instead.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// Type specifies the method of signature validation. The allowed options
    /// are Cosign, Sigstore Bundle and Notary. By default Cosign is used if a type is not specified.
    /// </summary>
    [JsonPropertyName("type")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesTypeEnum? Type { get; set; }

    /// <summary>UseCache enables caching of image verify responses for this rule.</summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Validation checks conditions across multiple image
    /// verification attestations or context entries
    /// </summary>
    [JsonPropertyName("validate")]
    public V2beta1PolicyStatusAutogenRulesVerifyImagesValidate? Validate { get; set; }

    /// <summary>VerifyDigest validates that images have a digest.</summary>
    [JsonPropertyName("verifyDigest")]
    public bool? VerifyDigest { get; set; }
}

/// <summary>
/// Rule defines a validation, mutation, or generation control for matching resources.
/// Each rules contains a match declaration to select resources, and an optional exclude
/// declaration to specify which resources to exclude.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogenRules
{
    /// <summary>
    /// CELPreconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of CEL conditions. It can only be used with the validate.cel subrule
    /// </summary>
    [JsonPropertyName("celPreconditions")]
    public IList<V2beta1PolicyStatusAutogenRulesCelPreconditions>? CelPreconditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1PolicyStatusAutogenRulesContext>? Context { get; set; }

    /// <summary>
    /// ExcludeResources defines when this policy rule should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V2beta1PolicyStatusAutogenRulesExclude? Exclude { get; set; }

    /// <summary>Generation is used to create new resources.</summary>
    [JsonPropertyName("generate")]
    public V2beta1PolicyStatusAutogenRulesGenerate? Generate { get; set; }

    /// <summary>
    /// ImageExtractors defines a mapping from kinds to ImageExtractorConfigs.
    /// This config is only valid for verifyImages rules.
    /// </summary>
    [JsonPropertyName("imageExtractors")]
    public IDictionary<string, IList<V2beta1PolicyStatusAutogenRulesImageExtractors>>? ImageExtractors { get; set; }

    /// <summary>
    /// MatchResources defines when this policy rule should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V2beta1PolicyStatusAutogenRulesMatch Match { get; set; }

    /// <summary>Mutation is used to modify matching resources.</summary>
    [JsonPropertyName("mutate")]
    public V2beta1PolicyStatusAutogenRulesMutate? Mutate { get; set; }

    /// <summary>Name is a label to identify the rule, It must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Preconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements. A direct list
    /// of conditions (without `any` or `all` statements is supported for backwards compatibility but
    /// will be deprecated in the next major release.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public JsonNode? Preconditions { get; set; }

    /// <summary>ReportProperties are the additional properties from the rule that will be added to the policy report result</summary>
    [JsonPropertyName("reportProperties")]
    public IDictionary<string, string>? ReportProperties { get; set; }

    /// <summary>
    /// SkipBackgroundRequests bypasses admission requests that are sent by the background controller.
    /// The default value is set to &quot;true&quot;, it must be set to &quot;false&quot; to apply
    /// generate and mutateExisting rules to those requests.
    /// </summary>
    [JsonPropertyName("skipBackgroundRequests")]
    public bool? SkipBackgroundRequests { get; set; }

    /// <summary>Validation is used to validate matching resources.</summary>
    [JsonPropertyName("validate")]
    public V2beta1PolicyStatusAutogenRulesValidate? Validate { get; set; }

    /// <summary>VerifyImages is used to verify image signatures and mutate them to add a digest</summary>
    [JsonPropertyName("verifyImages")]
    public IList<V2beta1PolicyStatusAutogenRulesVerifyImages>? VerifyImages { get; set; }
}

/// <summary>AutogenStatus contains autogen status information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusAutogen
{
    /// <summary>Rules is a list of Rule instances. It contains auto generated rules added for pod controllers</summary>
    [JsonPropertyName("rules")]
    public IList<V2beta1PolicyStatusAutogenRules>? Rules { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1PolicyStatusConditionsStatusEnum>))]
public enum V2beta1PolicyStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V2beta1PolicyStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// RuleCountStatus contains four variables which describes counts for
/// validate, generate, mutate and verify images rules
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusRulecount
{
    /// <summary>Count for generate rules in policy</summary>
    [JsonPropertyName("generate")]
    public required int Generate { get; set; }

    /// <summary>Count for mutate rules in policy</summary>
    [JsonPropertyName("mutate")]
    public required int Mutate { get; set; }

    /// <summary>Count for validate rules in policy</summary>
    [JsonPropertyName("validate")]
    public required int Validate { get; set; }

    /// <summary>Count for verify image rules in policy</summary>
    [JsonPropertyName("verifyimages")]
    public required int Verifyimages { get; set; }
}

/// <summary>ValidatingAdmissionPolicy contains status information</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatusValidatingadmissionpolicy
{
    /// <summary>Generated indicates whether a validating admission policy is generated from the policy or not</summary>
    [JsonPropertyName("generated")]
    public required bool Generated { get; set; }

    /// <summary>
    /// Message is a human readable message indicating details about the generation of validating admission policy
    /// It is an empty string when validating admission policy is successfully generated.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}

/// <summary>Status contains policy runtime data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1PolicyStatus
{
    /// <summary>AutogenStatus contains autogen status information.</summary>
    [JsonPropertyName("autogen")]
    public V2beta1PolicyStatusAutogen? Autogen { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V2beta1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Deprecated in favor of Conditions</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }

    /// <summary>
    /// RuleCountStatus contains four variables which describes counts for
    /// validate, generate, mutate and verify images rules
    /// </summary>
    [JsonPropertyName("rulecount")]
    public V2beta1PolicyStatusRulecount? Rulecount { get; set; }

    /// <summary>ValidatingAdmissionPolicy contains status information</summary>
    [JsonPropertyName("validatingadmissionpolicy")]
    public V2beta1PolicyStatusValidatingadmissionpolicy? Validatingadmissionpolicy { get; set; }
}

/// <summary>
/// Policy declares validation, mutation, and generation behaviors for matching resources.
/// See: https://kyverno.io/docs/writing-policies/ for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2beta1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V2beta1PolicySpec>, IStatus<V2beta1PolicyStatus?>
{
    public const string KubeApiVersion = "v2beta1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines policy behaviors and contains one or more rules.</summary>
    [JsonPropertyName("spec")]
    public required V2beta1PolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V2beta1PolicyStatus? Status { get; set; }
}