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
public partial class V1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1Policy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Policy> Items { get; set; }
}

/// <summary>
/// ApplyRules controls how rules in a policy are applied. Rule are processed in
/// the order of declaration. When set to `One` processing stops after a rule has
/// been applied i.e. the rule matches and results in a pass, fail, or error. When
/// set to `All` all rules in the policy are processed. The default is `All`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecApplyRulesEnum>))]
public enum V1PolicySpecApplyRulesEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "One"), JsonStringEnumMemberName("One")]
    One
}

/// <summary>Deprecated, use failurePolicy under the webhookConfiguration instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecFailurePolicyEnum>))]
public enum V1PolicySpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesCelPreconditions
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
public partial class V1PolicySpecRulesContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesContextApiCallMethodEnum>))]
public enum V1PolicySpecRulesContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesContextApiCallServiceHeaders
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
public partial class V1PolicySpecRulesContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicySpecRulesContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicySpecRulesContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicySpecRulesContextApiCallData>? Data { get; set; }

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
    public V1PolicySpecRulesContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicySpecRulesContextApiCallService? Service { get; set; }

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
public partial class V1PolicySpecRulesContextConfigMap
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
public partial class V1PolicySpecRulesContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicySpecRulesContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicySpecRulesContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicySpecRulesContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicySpecRulesContextVariable
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
public partial class V1PolicySpecRulesContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicySpecRulesContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicySpecRulesContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicySpecRulesContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicySpecRulesContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicySpecRulesContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesExcludeAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesExcludeAllResourcesOperationsEnum>))]
public enum V1PolicySpecRulesExcludeAllResourcesOperationsEnum
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
public partial class V1PolicySpecRulesExcludeAllResourcesSelectorMatchExpressions
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
public partial class V1PolicySpecRulesExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesExcludeAllResources
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
    public V1PolicySpecRulesExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicySpecRulesExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicySpecRulesExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesExcludeAllSubjects
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
public partial class V1PolicySpecRulesExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicySpecRulesExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicySpecRulesExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesExcludeAnyResourcesOperationsEnum>))]
public enum V1PolicySpecRulesExcludeAnyResourcesOperationsEnum
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
public partial class V1PolicySpecRulesExcludeAnyResourcesSelectorMatchExpressions
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
public partial class V1PolicySpecRulesExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesExcludeAnyResources
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
    public V1PolicySpecRulesExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicySpecRulesExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicySpecRulesExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesExcludeAnySubjects
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
public partial class V1PolicySpecRulesExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicySpecRulesExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicySpecRulesExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesExcludeResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesExcludeResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesExcludeResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesExcludeResourcesOperationsEnum>))]
public enum V1PolicySpecRulesExcludeResourcesOperationsEnum
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
public partial class V1PolicySpecRulesExcludeResourcesSelectorMatchExpressions
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
public partial class V1PolicySpecRulesExcludeResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesExcludeResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesExcludeResources
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
    public V1PolicySpecRulesExcludeResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicySpecRulesExcludeResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicySpecRulesExcludeResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesExcludeSubjects
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
public partial class V1PolicySpecRulesExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V1PolicySpecRulesExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V1PolicySpecRulesExcludeAny>? Any { get; set; }

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
    public V1PolicySpecRulesExcludeResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicySpecRulesExcludeSubjects>? Subjects { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesGenerateClone
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
public partial class V1PolicySpecRulesGenerateCloneListSelectorMatchExpressions
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
public partial class V1PolicySpecRulesGenerateCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesGenerateCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesGenerateCloneList
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
    public V1PolicySpecRulesGenerateCloneListSelector? Selector { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesGenerateForeachClone
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
public partial class V1PolicySpecRulesGenerateForeachCloneListSelectorMatchExpressions
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
public partial class V1PolicySpecRulesGenerateForeachCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesGenerateForeachCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesGenerateForeachCloneList
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
    public V1PolicySpecRulesGenerateForeachCloneListSelector? Selector { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesGenerateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesGenerateForeachContextApiCallMethodEnum>))]
public enum V1PolicySpecRulesGenerateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesGenerateForeachContextApiCallServiceHeaders
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
public partial class V1PolicySpecRulesGenerateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicySpecRulesGenerateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicySpecRulesGenerateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicySpecRulesGenerateForeachContextApiCallData>? Data { get; set; }

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
    public V1PolicySpecRulesGenerateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicySpecRulesGenerateForeachContextApiCallService? Service { get; set; }

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
public partial class V1PolicySpecRulesGenerateForeachContextConfigMap
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
public partial class V1PolicySpecRulesGenerateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicySpecRulesGenerateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicySpecRulesGenerateForeachContextVariable
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
public partial class V1PolicySpecRulesGenerateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicySpecRulesGenerateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicySpecRulesGenerateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicySpecRulesGenerateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicySpecRulesGenerateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicySpecRulesGenerateForeachContextVariable? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesGenerateForeach
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
    public V1PolicySpecRulesGenerateForeachClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V1PolicySpecRulesGenerateForeachCloneList? CloneList { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicySpecRulesGenerateForeachContext>? Context { get; set; }

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
public partial class V1PolicySpecRulesGenerate
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
    public V1PolicySpecRulesGenerateClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V1PolicySpecRulesGenerateCloneList? CloneList { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>ForEach applies generate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V1PolicySpecRulesGenerateForeach>? Foreach { get; set; }

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
public partial class V1PolicySpecRulesImageExtractors
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
public partial class V1PolicySpecRulesMatchAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMatchAllResourcesOperationsEnum>))]
public enum V1PolicySpecRulesMatchAllResourcesOperationsEnum
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
public partial class V1PolicySpecRulesMatchAllResourcesSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesMatchAllResources
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
    public V1PolicySpecRulesMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicySpecRulesMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicySpecRulesMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMatchAllSubjects
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
public partial class V1PolicySpecRulesMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicySpecRulesMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicySpecRulesMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMatchAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMatchAnyResourcesOperationsEnum>))]
public enum V1PolicySpecRulesMatchAnyResourcesOperationsEnum
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
public partial class V1PolicySpecRulesMatchAnyResourcesSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesMatchAnyResources
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
    public V1PolicySpecRulesMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicySpecRulesMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicySpecRulesMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMatchAnySubjects
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
public partial class V1PolicySpecRulesMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicySpecRulesMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicySpecRulesMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMatchResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMatchResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMatchResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMatchResourcesOperationsEnum>))]
public enum V1PolicySpecRulesMatchResourcesOperationsEnum
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
public partial class V1PolicySpecRulesMatchResourcesSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMatchResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMatchResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesMatchResources
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
    public V1PolicySpecRulesMatchResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicySpecRulesMatchResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicySpecRulesMatchResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMatchSubjects
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
public partial class V1PolicySpecRulesMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V1PolicySpecRulesMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V1PolicySpecRulesMatchAny>? Any { get; set; }

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
    public V1PolicySpecRulesMatchResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicySpecRulesMatchSubjects>? Subjects { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMutateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMutateForeachContextApiCallMethodEnum>))]
public enum V1PolicySpecRulesMutateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMutateForeachContextApiCallServiceHeaders
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
public partial class V1PolicySpecRulesMutateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicySpecRulesMutateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicySpecRulesMutateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicySpecRulesMutateForeachContextApiCallData>? Data { get; set; }

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
    public V1PolicySpecRulesMutateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicySpecRulesMutateForeachContextApiCallService? Service { get; set; }

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
public partial class V1PolicySpecRulesMutateForeachContextConfigMap
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
public partial class V1PolicySpecRulesMutateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicySpecRulesMutateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicySpecRulesMutateForeachContextVariable
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
public partial class V1PolicySpecRulesMutateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicySpecRulesMutateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicySpecRulesMutateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicySpecRulesMutateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicySpecRulesMutateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicySpecRulesMutateForeachContextVariable? Variable { get; set; }
}

/// <summary>
/// Order defines the iteration order on the list.
/// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMutateForeachOrderEnum>))]
public enum V1PolicySpecRulesMutateForeachOrderEnum
{
    [EnumMember(Value = "Ascending"), JsonStringEnumMemberName("Ascending")]
    Ascending,
    [EnumMember(Value = "Descending"), JsonStringEnumMemberName("Descending")]
    Descending
}

/// <summary>ForEachMutation applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMutateForeach
{
    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicySpecRulesMutateForeachContext>? Context { get; set; }

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
    public V1PolicySpecRulesMutateForeachOrderEnum? Order { get; set; }

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
public partial class V1PolicySpecRulesMutateTargetsContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMutateTargetsContextApiCallMethodEnum>))]
public enum V1PolicySpecRulesMutateTargetsContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMutateTargetsContextApiCallServiceHeaders
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
public partial class V1PolicySpecRulesMutateTargetsContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicySpecRulesMutateTargetsContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicySpecRulesMutateTargetsContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicySpecRulesMutateTargetsContextApiCallData>? Data { get; set; }

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
    public V1PolicySpecRulesMutateTargetsContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicySpecRulesMutateTargetsContextApiCallService? Service { get; set; }

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
public partial class V1PolicySpecRulesMutateTargetsContextConfigMap
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
public partial class V1PolicySpecRulesMutateTargetsContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicySpecRulesMutateTargetsContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicySpecRulesMutateTargetsContextVariable
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
public partial class V1PolicySpecRulesMutateTargetsContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicySpecRulesMutateTargetsContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicySpecRulesMutateTargetsContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicySpecRulesMutateTargetsContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicySpecRulesMutateTargetsContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicySpecRulesMutateTargetsContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMutateTargetsSelectorMatchExpressions
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
public partial class V1PolicySpecRulesMutateTargetsSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesMutateTargetsSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesMutateTargets
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicySpecRulesMutateTargetsContext>? Context { get; set; }

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
    public V1PolicySpecRulesMutateTargetsSelector? Selector { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Mutation is used to modify matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesMutate
{
    /// <summary>ForEach applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V1PolicySpecRulesMutateForeach>? Foreach { get; set; }

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
    public IList<V1PolicySpecRulesMutateTargets>? Targets { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateCelAuditAnnotations
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
public partial class V1PolicySpecRulesValidateCelExpressions
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
public partial class V1PolicySpecRulesValidateCelParamKind
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
public partial class V1PolicySpecRulesValidateCelParamRefSelectorMatchExpressions
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
public partial class V1PolicySpecRulesValidateCelParamRefSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesValidateCelParamRefSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesValidateCelParamRef
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
    public V1PolicySpecRulesValidateCelParamRefSelector? Selector { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateCelVariables
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
public partial class V1PolicySpecRulesValidateCel
{
    /// <summary>AuditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V1PolicySpecRulesValidateCelAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>Expressions is a list of CELExpression types.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1PolicySpecRulesValidateCelExpressions>? Expressions { get; set; }

    /// <summary>
    /// Generate specifies whether to generate a Kubernetes ValidatingAdmissionPolicy from the rule.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("generate")]
    public bool? Generate { get; set; }

    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    [JsonPropertyName("paramKind")]
    public V1PolicySpecRulesValidateCelParamKind? ParamKind { get; set; }

    /// <summary>ParamRef references a parameter resource.</summary>
    [JsonPropertyName("paramRef")]
    public V1PolicySpecRulesValidateCelParamRef? ParamRef { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V1PolicySpecRulesValidateCelVariables>? Variables { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateDeny
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidateFailureActionEnum>))]
public enum V1PolicySpecRulesValidateFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidateFailureActionOverridesActionEnum>))]
public enum V1PolicySpecRulesValidateFailureActionOverridesActionEnum
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
public partial class V1PolicySpecRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecRulesValidateFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecRulesValidateFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V1PolicySpecRulesValidateFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PolicySpecRulesValidateFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidateForeachContextApiCallMethodEnum>))]
public enum V1PolicySpecRulesValidateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateForeachContextApiCallServiceHeaders
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
public partial class V1PolicySpecRulesValidateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicySpecRulesValidateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicySpecRulesValidateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicySpecRulesValidateForeachContextApiCallData>? Data { get; set; }

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
    public V1PolicySpecRulesValidateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicySpecRulesValidateForeachContextApiCallService? Service { get; set; }

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
public partial class V1PolicySpecRulesValidateForeachContextConfigMap
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
public partial class V1PolicySpecRulesValidateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicySpecRulesValidateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicySpecRulesValidateForeachContextVariable
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
public partial class V1PolicySpecRulesValidateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicySpecRulesValidateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicySpecRulesValidateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicySpecRulesValidateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicySpecRulesValidateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicySpecRulesValidateForeachContextVariable? Variable { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateForeachDeny
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
public partial class V1PolicySpecRulesValidateForeach
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicySpecRulesValidateForeachContext>? Context { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V1PolicySpecRulesValidateForeachDeny? Deny { get; set; }

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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesCtlog
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesRekor
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesCertificates
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
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessCtlog
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessRekor
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeysCtlog
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeysRekor
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeysSecret
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
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateManifestsAttestorsEntries
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
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V1PolicySpecRulesValidateManifestsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V1PolicySpecRulesValidateManifestsAttestors
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
    public IList<V1PolicySpecRulesValidateManifestsAttestorsEntries>? Entries { get; set; }
}

/// <summary>DryRun configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateManifestsDryRun
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateManifestsIgnoreFieldsObjects
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
public partial class V1PolicySpecRulesValidateManifestsIgnoreFields
{
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    [JsonPropertyName("objects")]
    public IList<V1PolicySpecRulesValidateManifestsIgnoreFieldsObjects>? Objects { get; set; }
}

/// <summary>Manifest specifies conditions for manifest verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidateManifests
{
    /// <summary>AnnotationDomain is custom domain of annotation for message and signature. Default is &quot;cosign.sigstore.dev&quot;.</summary>
    [JsonPropertyName("annotationDomain")]
    public string? AnnotationDomain { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V1PolicySpecRulesValidateManifestsAttestors>? Attestors { get; set; }

    /// <summary>DryRun configuration</summary>
    [JsonPropertyName("dryRun")]
    public V1PolicySpecRulesValidateManifestsDryRun? DryRun { get; set; }

    /// <summary>Fields which will be ignored while comparing manifests.</summary>
    [JsonPropertyName("ignoreFields")]
    public IList<V1PolicySpecRulesValidateManifestsIgnoreFields>? IgnoreFields { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidatePodSecurityExcludeControlNameEnum>))]
public enum V1PolicySpecRulesValidatePodSecurityExcludeControlNameEnum
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
public partial class V1PolicySpecRulesValidatePodSecurityExclude
{
    /// <summary>
    /// ControlName specifies the name of the Pod Security Standard control.
    /// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
    /// </summary>
    [JsonPropertyName("controlName")]
    public required V1PolicySpecRulesValidatePodSecurityExcludeControlNameEnum ControlName { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidatePodSecurityLevelEnum>))]
public enum V1PolicySpecRulesValidatePodSecurityLevelEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesValidatePodSecurityVersionEnum>))]
public enum V1PolicySpecRulesValidatePodSecurityVersionEnum
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
public partial class V1PolicySpecRulesValidatePodSecurity
{
    /// <summary>Exclude specifies the Pod Security Standard controls to be excluded.</summary>
    [JsonPropertyName("exclude")]
    public IList<V1PolicySpecRulesValidatePodSecurityExclude>? Exclude { get; set; }

    /// <summary>
    /// Level defines the Pod Security Standard level to be applied to workloads.
    /// Allowed values are privileged, baseline, and restricted.
    /// </summary>
    [JsonPropertyName("level")]
    public V1PolicySpecRulesValidatePodSecurityLevelEnum? Level { get; set; }

    /// <summary>
    /// Version defines the Pod Security Standard versions that Kubernetes supports.
    /// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
    /// </summary>
    [JsonPropertyName("version")]
    public V1PolicySpecRulesValidatePodSecurityVersionEnum? Version { get; set; }
}

/// <summary>Validation is used to validate matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesValidate
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
    public V1PolicySpecRulesValidateCel? Cel { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V1PolicySpecRulesValidateDeny? Deny { get; set; }

    /// <summary>
    /// FailureAction defines if a validation policy rule violation should block
    /// the admission review request (Enforce), or allow (Audit) the admission review request
    /// and report an error in a policy report. Optional.
    /// Allowed values are Audit or Enforce.
    /// </summary>
    [JsonPropertyName("failureAction")]
    public V1PolicySpecRulesValidateFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// FailureActionOverrides is a Cluster Policy attribute that specifies FailureAction
    /// namespace-wise. It overrides FailureAction for the specified namespaces.
    /// </summary>
    [JsonPropertyName("failureActionOverrides")]
    public IList<V1PolicySpecRulesValidateFailureActionOverrides>? FailureActionOverrides { get; set; }

    /// <summary>ForEach applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V1PolicySpecRulesValidateForeach>? Foreach { get; set; }

    /// <summary>Manifest specifies conditions for manifest verification</summary>
    [JsonPropertyName("manifests")]
    public V1PolicySpecRulesValidateManifests? Manifests { get; set; }

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
    public V1PolicySpecRulesValidatePodSecurity? PodSecurity { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificates
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
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntries
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
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V1PolicySpecRulesVerifyImagesAttestationsAttestors
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
    public IList<V1PolicySpecRulesVerifyImagesAttestationsAttestorsEntries>? Entries { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum>))]
public enum V1PolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsConditionsAll
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
    public V1PolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum>))]
public enum V1PolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum
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
public partial class V1PolicySpecRulesVerifyImagesAttestationsConditionsAny
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
    public V1PolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum? Operator { get; set; }

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
public partial class V1PolicySpecRulesVerifyImagesAttestationsConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V1PolicySpecRulesVerifyImagesAttestationsConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V1PolicySpecRulesVerifyImagesAttestationsConditionsAny>? Any { get; set; }
}

/// <summary>
/// Attestation are checks for signed in-toto Statements that are used to verify the image.
/// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
/// OCI registry and decodes them into a list of Statements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesVerifyImagesAttestations
{
    /// <summary>Attestors specify the required attestors (i.e. authorities).</summary>
    [JsonPropertyName("attestors")]
    public IList<V1PolicySpecRulesVerifyImagesAttestationsAttestors>? Attestors { get; set; }

    /// <summary>
    /// Conditions are used to verify attributes within a Predicate. If no Conditions are specified
    /// the attestation check is satisfied as long there are predicates that match the predicate type.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1PolicySpecRulesVerifyImagesAttestationsConditions>? Conditions { get; set; }

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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesCtlog
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesRekor
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesCertificates
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
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessCtlog
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessRekor
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeysCtlog
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeysRekor
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeysSecret
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
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecRulesVerifyImagesAttestorsEntries
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
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V1PolicySpecRulesVerifyImagesAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V1PolicySpecRulesVerifyImagesAttestors
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
    public IList<V1PolicySpecRulesVerifyImagesAttestorsEntries>? Entries { get; set; }
}

/// <summary>Allowed values are Audit or Enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesVerifyImagesFailureActionEnum>))]
public enum V1PolicySpecRulesVerifyImagesFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicySpecRulesVerifyImagesImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecRulesVerifyImagesTypeEnum>))]
public enum V1PolicySpecRulesVerifyImagesTypeEnum
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
public partial class V1PolicySpecRulesVerifyImagesValidateDeny
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
public partial class V1PolicySpecRulesVerifyImagesValidate
{
    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V1PolicySpecRulesVerifyImagesValidateDeny? Deny { get; set; }

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
public partial class V1PolicySpecRulesVerifyImages
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
    public IList<V1PolicySpecRulesVerifyImagesAttestations>? Attestations { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V1PolicySpecRulesVerifyImagesAttestors>? Attestors { get; set; }

    /// <summary>
    /// CosignOCI11 enables the experimental OCI 1.1 behaviour in cosign image verification.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("cosignOCI11")]
    public bool? CosignOCI11 { get; set; }

    /// <summary>Allowed values are Audit or Enforce.</summary>
    [JsonPropertyName("failureAction")]
    public V1PolicySpecRulesVerifyImagesFailureActionEnum? FailureAction { get; set; }

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
    public V1PolicySpecRulesVerifyImagesImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
    public V1PolicySpecRulesVerifyImagesTypeEnum? Type { get; set; }

    /// <summary>UseCache enables caching of image verify responses for this rule.</summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Validation checks conditions across multiple image
    /// verification attestations or context entries
    /// </summary>
    [JsonPropertyName("validate")]
    public V1PolicySpecRulesVerifyImagesValidate? Validate { get; set; }

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
public partial class V1PolicySpecRules
{
    /// <summary>
    /// CELPreconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of CEL conditions. It can only be used with the validate.cel subrule
    /// </summary>
    [JsonPropertyName("celPreconditions")]
    public IList<V1PolicySpecRulesCelPreconditions>? CelPreconditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicySpecRulesContext>? Context { get; set; }

    /// <summary>
    /// ExcludeResources defines when this policy rule should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V1PolicySpecRulesExclude? Exclude { get; set; }

    /// <summary>Generation is used to create new resources.</summary>
    [JsonPropertyName("generate")]
    public V1PolicySpecRulesGenerate? Generate { get; set; }

    /// <summary>
    /// ImageExtractors defines a mapping from kinds to ImageExtractorConfigs.
    /// This config is only valid for verifyImages rules.
    /// </summary>
    [JsonPropertyName("imageExtractors")]
    public IDictionary<string, IList<V1PolicySpecRulesImageExtractors>>? ImageExtractors { get; set; }

    /// <summary>
    /// MatchResources defines when this policy rule should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V1PolicySpecRulesMatch Match { get; set; }

    /// <summary>Mutation is used to modify matching resources.</summary>
    [JsonPropertyName("mutate")]
    public V1PolicySpecRulesMutate? Mutate { get; set; }

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
    public V1PolicySpecRulesValidate? Validate { get; set; }

    /// <summary>VerifyImages is used to verify image signatures and mutate them to add a digest</summary>
    [JsonPropertyName("verifyImages")]
    public IList<V1PolicySpecRulesVerifyImages>? VerifyImages { get; set; }
}

/// <summary>Deprecated, use validationFailureAction under the validate rule instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecValidationFailureActionEnum>))]
public enum V1PolicySpecValidationFailureActionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecValidationFailureActionOverridesActionEnum>))]
public enum V1PolicySpecValidationFailureActionOverridesActionEnum
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
public partial class V1PolicySpecValidationFailureActionOverridesNamespaceSelectorMatchExpressions
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
public partial class V1PolicySpecValidationFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicySpecValidationFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicySpecValidationFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V1PolicySpecValidationFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PolicySpecValidationFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicySpecWebhookConfigurationFailurePolicyEnum>))]
public enum V1PolicySpecWebhookConfigurationFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicySpecWebhookConfigurationMatchConditions
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
public partial class V1PolicySpecWebhookConfiguration
{
    /// <summary>
    /// FailurePolicy defines how unexpected policy errors and webhook response timeout errors are handled.
    /// Rules within the same policy share the same failure behavior.
    /// This field should not be accessed directly, instead `GetFailurePolicy()` should be used.
    /// Allowed values are Ignore or Fail. Defaults to Fail.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V1PolicySpecWebhookConfigurationFailurePolicyEnum? FailurePolicy { get; set; }

    /// <summary>
    /// MatchCondition configures admission webhook matchConditions.
    /// Requires Kubernetes 1.27 or later.
    /// </summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1PolicySpecWebhookConfigurationMatchConditions>? MatchConditions { get; set; }

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
public partial class V1PolicySpec
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
    public V1PolicySpecApplyRulesEnum? ApplyRules { get; set; }

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
    public V1PolicySpecFailurePolicyEnum? FailurePolicy { get; set; }

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
    public IList<V1PolicySpecRules>? Rules { get; set; }

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
    public V1PolicySpecValidationFailureActionEnum? ValidationFailureAction { get; set; }

    /// <summary>Deprecated, use validationFailureActionOverrides under the validate rule instead.</summary>
    [JsonPropertyName("validationFailureActionOverrides")]
    public IList<V1PolicySpecValidationFailureActionOverrides>? ValidationFailureActionOverrides { get; set; }

    /// <summary>WebhookConfiguration specifies the custom configuration for Kubernetes admission webhookconfiguration.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1PolicySpecWebhookConfiguration? WebhookConfiguration { get; set; }

    /// <summary>Deprecated, use webhookTimeoutSeconds under webhookConfiguration instead.</summary>
    [JsonPropertyName("webhookTimeoutSeconds")]
    public int? WebhookTimeoutSeconds { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesCelPreconditions
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
public partial class V1PolicyStatusAutogenRulesContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesContextApiCallMethodEnum>))]
public enum V1PolicyStatusAutogenRulesContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesContextApiCallServiceHeaders
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
public partial class V1PolicyStatusAutogenRulesContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicyStatusAutogenRulesContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicyStatusAutogenRulesContextApiCallData>? Data { get; set; }

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
    public V1PolicyStatusAutogenRulesContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicyStatusAutogenRulesContextApiCallService? Service { get; set; }

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
public partial class V1PolicyStatusAutogenRulesContextConfigMap
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
public partial class V1PolicyStatusAutogenRulesContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicyStatusAutogenRulesContextVariable
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
public partial class V1PolicyStatusAutogenRulesContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicyStatusAutogenRulesContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicyStatusAutogenRulesContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicyStatusAutogenRulesContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicyStatusAutogenRulesContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicyStatusAutogenRulesContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum>))]
public enum V1PolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum
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
public partial class V1PolicyStatusAutogenRulesExcludeAllResourcesSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesExcludeAllResources
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
    public V1PolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicyStatusAutogenRulesExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesExcludeAllSubjects
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
public partial class V1PolicyStatusAutogenRulesExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicyStatusAutogenRulesExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicyStatusAutogenRulesExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum>))]
public enum V1PolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum
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
public partial class V1PolicyStatusAutogenRulesExcludeAnyResourcesSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesExcludeAnyResources
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
    public V1PolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicyStatusAutogenRulesExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesExcludeAnySubjects
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
public partial class V1PolicyStatusAutogenRulesExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicyStatusAutogenRulesExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicyStatusAutogenRulesExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesExcludeResourcesOperationsEnum>))]
public enum V1PolicyStatusAutogenRulesExcludeResourcesOperationsEnum
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
public partial class V1PolicyStatusAutogenRulesExcludeResourcesSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesExcludeResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesExcludeResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesExcludeResources
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
    public V1PolicyStatusAutogenRulesExcludeResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicyStatusAutogenRulesExcludeResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicyStatusAutogenRulesExcludeResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesExcludeSubjects
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
public partial class V1PolicyStatusAutogenRulesExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V1PolicyStatusAutogenRulesExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V1PolicyStatusAutogenRulesExcludeAny>? Any { get; set; }

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
    public V1PolicyStatusAutogenRulesExcludeResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicyStatusAutogenRulesExcludeSubjects>? Subjects { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesGenerateClone
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
public partial class V1PolicyStatusAutogenRulesGenerateCloneListSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesGenerateCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesGenerateCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerateCloneList
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
    public V1PolicyStatusAutogenRulesGenerateCloneListSelector? Selector { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesGenerateForeachClone
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
public partial class V1PolicyStatusAutogenRulesGenerateForeachCloneListSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesGenerateForeachCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesGenerateForeachCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerateForeachCloneList
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
    public V1PolicyStatusAutogenRulesGenerateForeachCloneListSelector? Selector { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum>))]
public enum V1PolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextApiCallServiceHeaders
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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicyStatusAutogenRulesGenerateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicyStatusAutogenRulesGenerateForeachContextApiCallData>? Data { get; set; }

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
    public V1PolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextApiCallService? Service { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextConfigMap
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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContextVariable
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
public partial class V1PolicyStatusAutogenRulesGenerateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicyStatusAutogenRulesGenerateForeachContextVariable? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesGenerateForeach
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
    public V1PolicyStatusAutogenRulesGenerateForeachClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V1PolicyStatusAutogenRulesGenerateForeachCloneList? CloneList { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicyStatusAutogenRulesGenerateForeachContext>? Context { get; set; }

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
public partial class V1PolicyStatusAutogenRulesGenerate
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
    public V1PolicyStatusAutogenRulesGenerateClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V1PolicyStatusAutogenRulesGenerateCloneList? CloneList { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>ForEach applies generate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V1PolicyStatusAutogenRulesGenerateForeach>? Foreach { get; set; }

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
public partial class V1PolicyStatusAutogenRulesImageExtractors
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
public partial class V1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMatchAllResourcesOperationsEnum>))]
public enum V1PolicyStatusAutogenRulesMatchAllResourcesOperationsEnum
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
public partial class V1PolicyStatusAutogenRulesMatchAllResourcesSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMatchAllResources
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
    public V1PolicyStatusAutogenRulesMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicyStatusAutogenRulesMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicyStatusAutogenRulesMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMatchAllSubjects
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
public partial class V1PolicyStatusAutogenRulesMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicyStatusAutogenRulesMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicyStatusAutogenRulesMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum>))]
public enum V1PolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum
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
public partial class V1PolicyStatusAutogenRulesMatchAnyResourcesSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMatchAnyResources
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
    public V1PolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicyStatusAutogenRulesMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMatchAnySubjects
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
public partial class V1PolicyStatusAutogenRulesMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V1PolicyStatusAutogenRulesMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicyStatusAutogenRulesMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMatchResourcesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMatchResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMatchResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMatchResourcesOperationsEnum>))]
public enum V1PolicyStatusAutogenRulesMatchResourcesOperationsEnum
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
public partial class V1PolicyStatusAutogenRulesMatchResourcesSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMatchResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMatchResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMatchResources
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
    public V1PolicyStatusAutogenRulesMatchResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V1PolicyStatusAutogenRulesMatchResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1PolicyStatusAutogenRulesMatchResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMatchSubjects
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
public partial class V1PolicyStatusAutogenRulesMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V1PolicyStatusAutogenRulesMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V1PolicyStatusAutogenRulesMatchAny>? Any { get; set; }

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
    public V1PolicyStatusAutogenRulesMatchResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V1PolicyStatusAutogenRulesMatchSubjects>? Subjects { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMutateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum>))]
public enum V1PolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMutateForeachContextApiCallServiceHeaders
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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicyStatusAutogenRulesMutateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicyStatusAutogenRulesMutateForeachContextApiCallData>? Data { get; set; }

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
    public V1PolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicyStatusAutogenRulesMutateForeachContextApiCallService? Service { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextConfigMap
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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateForeachContextVariable
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
public partial class V1PolicyStatusAutogenRulesMutateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicyStatusAutogenRulesMutateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicyStatusAutogenRulesMutateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicyStatusAutogenRulesMutateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicyStatusAutogenRulesMutateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicyStatusAutogenRulesMutateForeachContextVariable? Variable { get; set; }
}

/// <summary>
/// Order defines the iteration order on the list.
/// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMutateForeachOrderEnum>))]
public enum V1PolicyStatusAutogenRulesMutateForeachOrderEnum
{
    [EnumMember(Value = "Ascending"), JsonStringEnumMemberName("Ascending")]
    Ascending,
    [EnumMember(Value = "Descending"), JsonStringEnumMemberName("Descending")]
    Descending
}

/// <summary>ForEachMutation applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMutateForeach
{
    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicyStatusAutogenRulesMutateForeachContext>? Context { get; set; }

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
    public V1PolicyStatusAutogenRulesMutateForeachOrderEnum? Order { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum>))]
public enum V1PolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextApiCallServiceHeaders
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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicyStatusAutogenRulesMutateTargetsContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicyStatusAutogenRulesMutateTargetsContextApiCallData>? Data { get; set; }

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
    public V1PolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextApiCallService? Service { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextConfigMap
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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContextVariable
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
public partial class V1PolicyStatusAutogenRulesMutateTargetsContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicyStatusAutogenRulesMutateTargetsContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMutateTargetsSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesMutateTargetsSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesMutateTargetsSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesMutateTargets
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicyStatusAutogenRulesMutateTargetsContext>? Context { get; set; }

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
    public V1PolicyStatusAutogenRulesMutateTargetsSelector? Selector { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Mutation is used to modify matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesMutate
{
    /// <summary>ForEach applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V1PolicyStatusAutogenRulesMutateForeach>? Foreach { get; set; }

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
    public IList<V1PolicyStatusAutogenRulesMutateTargets>? Targets { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateCelAuditAnnotations
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
public partial class V1PolicyStatusAutogenRulesValidateCelExpressions
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
public partial class V1PolicyStatusAutogenRulesValidateCelParamKind
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
public partial class V1PolicyStatusAutogenRulesValidateCelParamRefSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesValidateCelParamRefSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesValidateCelParamRefSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateCelParamRef
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
    public V1PolicyStatusAutogenRulesValidateCelParamRefSelector? Selector { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateCelVariables
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
public partial class V1PolicyStatusAutogenRulesValidateCel
{
    /// <summary>AuditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V1PolicyStatusAutogenRulesValidateCelAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>Expressions is a list of CELExpression types.</summary>
    [JsonPropertyName("expressions")]
    public IList<V1PolicyStatusAutogenRulesValidateCelExpressions>? Expressions { get; set; }

    /// <summary>
    /// Generate specifies whether to generate a Kubernetes ValidatingAdmissionPolicy from the rule.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("generate")]
    public bool? Generate { get; set; }

    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    [JsonPropertyName("paramKind")]
    public V1PolicyStatusAutogenRulesValidateCelParamKind? ParamKind { get; set; }

    /// <summary>ParamRef references a parameter resource.</summary>
    [JsonPropertyName("paramRef")]
    public V1PolicyStatusAutogenRulesValidateCelParamRef? ParamRef { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V1PolicyStatusAutogenRulesValidateCelVariables>? Variables { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateDeny
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidateFailureActionEnum>))]
public enum V1PolicyStatusAutogenRulesValidateFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum>))]
public enum V1PolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum
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
public partial class V1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions
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
public partial class V1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V1PolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1PolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum>))]
public enum V1PolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateForeachContextApiCallServiceHeaders
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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V1PolicyStatusAutogenRulesValidateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V1PolicyStatusAutogenRulesValidateForeachContextApiCallData>? Data { get; set; }

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
    public V1PolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V1PolicyStatusAutogenRulesValidateForeachContextApiCallService? Service { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextConfigMap
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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V1PolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateForeachContextVariable
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
public partial class V1PolicyStatusAutogenRulesValidateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V1PolicyStatusAutogenRulesValidateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V1PolicyStatusAutogenRulesValidateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V1PolicyStatusAutogenRulesValidateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V1PolicyStatusAutogenRulesValidateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V1PolicyStatusAutogenRulesValidateForeachContextVariable? Variable { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateForeachDeny
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
public partial class V1PolicyStatusAutogenRulesValidateForeach
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicyStatusAutogenRulesValidateForeachContext>? Context { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V1PolicyStatusAutogenRulesValidateForeachDeny? Deny { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesCtlog
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesRekor
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificates
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
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessCtlog
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessRekor
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysCtlog
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysRekor
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysSecret
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntries
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
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V1PolicyStatusAutogenRulesValidateManifestsAttestors
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
    public IList<V1PolicyStatusAutogenRulesValidateManifestsAttestorsEntries>? Entries { get; set; }
}

/// <summary>DryRun configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateManifestsDryRun
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateManifestsIgnoreFieldsObjects
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
public partial class V1PolicyStatusAutogenRulesValidateManifestsIgnoreFields
{
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    [JsonPropertyName("objects")]
    public IList<V1PolicyStatusAutogenRulesValidateManifestsIgnoreFieldsObjects>? Objects { get; set; }
}

/// <summary>Manifest specifies conditions for manifest verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidateManifests
{
    /// <summary>AnnotationDomain is custom domain of annotation for message and signature. Default is &quot;cosign.sigstore.dev&quot;.</summary>
    [JsonPropertyName("annotationDomain")]
    public string? AnnotationDomain { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V1PolicyStatusAutogenRulesValidateManifestsAttestors>? Attestors { get; set; }

    /// <summary>DryRun configuration</summary>
    [JsonPropertyName("dryRun")]
    public V1PolicyStatusAutogenRulesValidateManifestsDryRun? DryRun { get; set; }

    /// <summary>Fields which will be ignored while comparing manifests.</summary>
    [JsonPropertyName("ignoreFields")]
    public IList<V1PolicyStatusAutogenRulesValidateManifestsIgnoreFields>? IgnoreFields { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum>))]
public enum V1PolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum
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
public partial class V1PolicyStatusAutogenRulesValidatePodSecurityExclude
{
    /// <summary>
    /// ControlName specifies the name of the Pod Security Standard control.
    /// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
    /// </summary>
    [JsonPropertyName("controlName")]
    public required V1PolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum ControlName { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidatePodSecurityLevelEnum>))]
public enum V1PolicyStatusAutogenRulesValidatePodSecurityLevelEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesValidatePodSecurityVersionEnum>))]
public enum V1PolicyStatusAutogenRulesValidatePodSecurityVersionEnum
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
public partial class V1PolicyStatusAutogenRulesValidatePodSecurity
{
    /// <summary>Exclude specifies the Pod Security Standard controls to be excluded.</summary>
    [JsonPropertyName("exclude")]
    public IList<V1PolicyStatusAutogenRulesValidatePodSecurityExclude>? Exclude { get; set; }

    /// <summary>
    /// Level defines the Pod Security Standard level to be applied to workloads.
    /// Allowed values are privileged, baseline, and restricted.
    /// </summary>
    [JsonPropertyName("level")]
    public V1PolicyStatusAutogenRulesValidatePodSecurityLevelEnum? Level { get; set; }

    /// <summary>
    /// Version defines the Pod Security Standard versions that Kubernetes supports.
    /// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
    /// </summary>
    [JsonPropertyName("version")]
    public V1PolicyStatusAutogenRulesValidatePodSecurityVersionEnum? Version { get; set; }
}

/// <summary>Validation is used to validate matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesValidate
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
    public V1PolicyStatusAutogenRulesValidateCel? Cel { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V1PolicyStatusAutogenRulesValidateDeny? Deny { get; set; }

    /// <summary>
    /// FailureAction defines if a validation policy rule violation should block
    /// the admission review request (Enforce), or allow (Audit) the admission review request
    /// and report an error in a policy report. Optional.
    /// Allowed values are Audit or Enforce.
    /// </summary>
    [JsonPropertyName("failureAction")]
    public V1PolicyStatusAutogenRulesValidateFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// FailureActionOverrides is a Cluster Policy attribute that specifies FailureAction
    /// namespace-wise. It overrides FailureAction for the specified namespaces.
    /// </summary>
    [JsonPropertyName("failureActionOverrides")]
    public IList<V1PolicyStatusAutogenRulesValidateFailureActionOverrides>? FailureActionOverrides { get; set; }

    /// <summary>ForEach applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V1PolicyStatusAutogenRulesValidateForeach>? Foreach { get; set; }

    /// <summary>Manifest specifies conditions for manifest verification</summary>
    [JsonPropertyName("manifests")]
    public V1PolicyStatusAutogenRulesValidateManifests? Manifests { get; set; }

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
    public V1PolicyStatusAutogenRulesValidatePodSecurity? PodSecurity { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificates
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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntries
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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestors
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
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntries>? Entries { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum>))]
public enum V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAll
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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum>))]
public enum V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAny
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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum? Operator { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAny>? Any { get; set; }
}

/// <summary>
/// Attestation are checks for signed in-toto Statements that are used to verify the image.
/// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
/// OCI registry and decodes them into a list of Statements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestations
{
    /// <summary>Attestors specify the required attestors (i.e. authorities).</summary>
    [JsonPropertyName("attestors")]
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestationsAttestors>? Attestors { get; set; }

    /// <summary>
    /// Conditions are used to verify attributes within a Predicate. If no Conditions are specified
    /// the attestation check is satisfied as long there are predicates that match the predicate type.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestationsConditions>? Conditions { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesCtlog
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesRekor
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificates
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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessCtlog
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessRekor
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysCtlog
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysRekor
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysSecret
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntries
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
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImagesAttestors
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
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestorsEntries>? Entries { get; set; }
}

/// <summary>Allowed values are Audit or Enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesVerifyImagesFailureActionEnum>))]
public enum V1PolicyStatusAutogenRulesVerifyImagesFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum>))]
public enum V1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusAutogenRulesVerifyImagesTypeEnum>))]
public enum V1PolicyStatusAutogenRulesVerifyImagesTypeEnum
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesValidateDeny
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
public partial class V1PolicyStatusAutogenRulesVerifyImagesValidate
{
    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V1PolicyStatusAutogenRulesVerifyImagesValidateDeny? Deny { get; set; }

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
public partial class V1PolicyStatusAutogenRulesVerifyImages
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
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestations>? Attestations { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V1PolicyStatusAutogenRulesVerifyImagesAttestors>? Attestors { get; set; }

    /// <summary>
    /// CosignOCI11 enables the experimental OCI 1.1 behaviour in cosign image verification.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("cosignOCI11")]
    public bool? CosignOCI11 { get; set; }

    /// <summary>Allowed values are Audit or Enforce.</summary>
    [JsonPropertyName("failureAction")]
    public V1PolicyStatusAutogenRulesVerifyImagesFailureActionEnum? FailureAction { get; set; }

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
    public V1PolicyStatusAutogenRulesVerifyImagesImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
    public V1PolicyStatusAutogenRulesVerifyImagesTypeEnum? Type { get; set; }

    /// <summary>UseCache enables caching of image verify responses for this rule.</summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Validation checks conditions across multiple image
    /// verification attestations or context entries
    /// </summary>
    [JsonPropertyName("validate")]
    public V1PolicyStatusAutogenRulesVerifyImagesValidate? Validate { get; set; }

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
public partial class V1PolicyStatusAutogenRules
{
    /// <summary>
    /// CELPreconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of CEL conditions. It can only be used with the validate.cel subrule
    /// </summary>
    [JsonPropertyName("celPreconditions")]
    public IList<V1PolicyStatusAutogenRulesCelPreconditions>? CelPreconditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V1PolicyStatusAutogenRulesContext>? Context { get; set; }

    /// <summary>
    /// ExcludeResources defines when this policy rule should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V1PolicyStatusAutogenRulesExclude? Exclude { get; set; }

    /// <summary>Generation is used to create new resources.</summary>
    [JsonPropertyName("generate")]
    public V1PolicyStatusAutogenRulesGenerate? Generate { get; set; }

    /// <summary>
    /// ImageExtractors defines a mapping from kinds to ImageExtractorConfigs.
    /// This config is only valid for verifyImages rules.
    /// </summary>
    [JsonPropertyName("imageExtractors")]
    public IDictionary<string, IList<V1PolicyStatusAutogenRulesImageExtractors>>? ImageExtractors { get; set; }

    /// <summary>
    /// MatchResources defines when this policy rule should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V1PolicyStatusAutogenRulesMatch Match { get; set; }

    /// <summary>Mutation is used to modify matching resources.</summary>
    [JsonPropertyName("mutate")]
    public V1PolicyStatusAutogenRulesMutate? Mutate { get; set; }

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
    public V1PolicyStatusAutogenRulesValidate? Validate { get; set; }

    /// <summary>VerifyImages is used to verify image signatures and mutate them to add a digest</summary>
    [JsonPropertyName("verifyImages")]
    public IList<V1PolicyStatusAutogenRulesVerifyImages>? VerifyImages { get; set; }
}

/// <summary>AutogenStatus contains autogen status information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatusAutogen
{
    /// <summary>Rules is a list of Rule instances. It contains auto generated rules added for pod controllers</summary>
    [JsonPropertyName("rules")]
    public IList<V1PolicyStatusAutogenRules>? Rules { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1PolicyStatusConditionsStatusEnum>))]
public enum V1PolicyStatusConditionsStatusEnum
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
public partial class V1PolicyStatusConditions
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
    public required V1PolicyStatusConditionsStatusEnum Status { get; set; }

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
public partial class V1PolicyStatusRulecount
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
public partial class V1PolicyStatusValidatingadmissionpolicy
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

/// <summary>Deprecated. Policy metrics are available via the metrics endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1PolicyStatus
{
    /// <summary>AutogenStatus contains autogen status information.</summary>
    [JsonPropertyName("autogen")]
    public V1PolicyStatusAutogen? Autogen { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Deprecated in favor of Conditions</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }

    /// <summary>
    /// RuleCountStatus contains four variables which describes counts for
    /// validate, generate, mutate and verify images rules
    /// </summary>
    [JsonPropertyName("rulecount")]
    public V1PolicyStatusRulecount? Rulecount { get; set; }

    /// <summary>ValidatingAdmissionPolicy contains status information</summary>
    [JsonPropertyName("validatingadmissionpolicy")]
    public V1PolicyStatusValidatingadmissionpolicy? Validatingadmissionpolicy { get; set; }
}

/// <summary>
/// Policy declares validation, mutation, and generation behaviors for matching resources.
/// See: https://kyverno.io/docs/writing-policies/ for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1PolicySpec>, IStatus<V1PolicyStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines policy behaviors and contains one or more rules.</summary>
    [JsonPropertyName("spec")]
    public required V1PolicySpec Spec { get; set; }

    /// <summary>Deprecated. Policy metrics are available via the metrics endpoint</summary>
    [JsonPropertyName("status")]
    public V1PolicyStatus? Status { get; set; }
}