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
/// <summary>ClusterPolicy declares validation, mutation, and generation behaviors for matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2beta1ClusterPolicyList : IKubernetesObject<V1ListMeta>, IItems<V2beta1ClusterPolicy>
{
    public const string KubeApiVersion = "v2beta1";
    public const string KubeKind = "ClusterPolicyList";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "clusterpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2beta1ClusterPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2beta1ClusterPolicy> Items { get; set; }
}

/// <summary>
/// ApplyRules controls how rules in a policy are applied. Rule are processed in
/// the order of declaration. When set to `One` processing stops after a rule has
/// been applied i.e. the rule matches and results in a pass, fail, or error. When
/// set to `All` all rules in the policy are processed. The default is `All`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecApplyRulesEnum>))]
public enum V2beta1ClusterPolicySpecApplyRulesEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "One"), JsonStringEnumMemberName("One")]
    One
}

/// <summary>Deprecated, use failurePolicy under the webhookConfiguration instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecFailurePolicyEnum>))]
public enum V2beta1ClusterPolicySpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesCelPreconditions
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
public partial class V2beta1ClusterPolicySpecRulesContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicySpecRulesContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicySpecRulesContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicySpecRulesContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicySpecRulesContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicySpecRulesContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicySpecRulesContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesContextConfigMap
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
public partial class V2beta1ClusterPolicySpecRulesContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicySpecRulesContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicySpecRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicySpecRulesContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesContextVariable
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
public partial class V2beta1ClusterPolicySpecRulesContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicySpecRulesContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicySpecRulesContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicySpecRulesContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicySpecRulesContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicySpecRulesContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesExcludeAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesExcludeAllResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicySpecRulesExcludeAllResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAllResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesExcludeAllResources
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
    public V2beta1ClusterPolicySpecRulesExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicySpecRulesExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesExcludeAllSubjects
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicySpecRulesExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesExcludeAnyResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicySpecRulesExcludeAnyResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAnyResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesExcludeAnyResources
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
    public V2beta1ClusterPolicySpecRulesExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicySpecRulesExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesExcludeAnySubjects
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
public partial class V2beta1ClusterPolicySpecRulesExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicySpecRulesExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// ExcludeResources defines when this policy rule should not be applied. The exclude
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the name or role.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicySpecRulesExcludeAny>? Any { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesGenerateClone
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
public partial class V2beta1ClusterPolicySpecRulesGenerateCloneListSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesGenerateCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerateCloneList
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
    public V2beta1ClusterPolicySpecRulesGenerateCloneListSelector? Selector { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachClone
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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachCloneListSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateForeachCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachCloneList
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
    public V2beta1ClusterPolicySpecRulesGenerateForeachCloneListSelector? Selector { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextConfigMap
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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContextVariable
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
public partial class V2beta1ClusterPolicySpecRulesGenerateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachContextVariable? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesGenerateForeach
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
    public V2beta1ClusterPolicySpecRulesGenerateForeachClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1ClusterPolicySpecRulesGenerateForeachCloneList? CloneList { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateForeachContext>? Context { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesGenerate
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
    public V2beta1ClusterPolicySpecRulesGenerateClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1ClusterPolicySpecRulesGenerateCloneList? CloneList { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>ForEach applies generate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1ClusterPolicySpecRulesGenerateForeach>? Foreach { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesImageExtractors
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
public partial class V2beta1ClusterPolicySpecRulesMatchAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMatchAllResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicySpecRulesMatchAllResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicySpecRulesMatchAllResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMatchAllResources
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
    public V2beta1ClusterPolicySpecRulesMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicySpecRulesMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMatchAllSubjects
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
public partial class V2beta1ClusterPolicySpecRulesMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicySpecRulesMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMatchAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMatchAnyResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicySpecRulesMatchAnyResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicySpecRulesMatchAnyResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMatchAnyResources
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
    public V2beta1ClusterPolicySpecRulesMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicySpecRulesMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMatchAnySubjects
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
public partial class V2beta1ClusterPolicySpecRulesMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicySpecRulesMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// MatchResources defines when this policy rule should be applied. The match
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the user name or role.
/// At least one kind is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicySpecRulesMatchAny>? Any { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextConfigMap
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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContextVariable
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
public partial class V2beta1ClusterPolicySpecRulesMutateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicySpecRulesMutateForeachContextVariable? Variable { get; set; }
}

/// <summary>
/// Order defines the iteration order on the list.
/// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMutateForeachOrderEnum>))]
public enum V2beta1ClusterPolicySpecRulesMutateForeachOrderEnum
{
    [EnumMember(Value = "Ascending"), JsonStringEnumMemberName("Ascending")]
    Ascending,
    [EnumMember(Value = "Descending"), JsonStringEnumMemberName("Descending")]
    Descending
}

/// <summary>ForEachMutation applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMutateForeach
{
    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicySpecRulesMutateForeachContext>? Context { get; set; }

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
    public V2beta1ClusterPolicySpecRulesMutateForeachOrderEnum? Order { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextConfigMap
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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContextVariable
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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicySpecRulesMutateTargetsContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesMutateTargetsSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesMutateTargetsSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesMutateTargets
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicySpecRulesMutateTargetsContext>? Context { get; set; }

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
    public V2beta1ClusterPolicySpecRulesMutateTargetsSelector? Selector { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Mutation is used to modify matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesMutate
{
    /// <summary>ForEach applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1ClusterPolicySpecRulesMutateForeach>? Foreach { get; set; }

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
    public IList<V2beta1ClusterPolicySpecRulesMutateTargets>? Targets { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesPreconditionsAllOperatorEnum>))]
public enum V2beta1ClusterPolicySpecRulesPreconditionsAllOperatorEnum
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
public partial class V2beta1ClusterPolicySpecRulesPreconditionsAll
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
    public V2beta1ClusterPolicySpecRulesPreconditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesPreconditionsAnyOperatorEnum>))]
public enum V2beta1ClusterPolicySpecRulesPreconditionsAnyOperatorEnum
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
public partial class V2beta1ClusterPolicySpecRulesPreconditionsAny
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
    public V2beta1ClusterPolicySpecRulesPreconditionsAnyOperatorEnum? Operator { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesPreconditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicySpecRulesPreconditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicySpecRulesPreconditionsAny>? Any { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateCelAuditAnnotations
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
public partial class V2beta1ClusterPolicySpecRulesValidateCelExpressions
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
public partial class V2beta1ClusterPolicySpecRulesValidateCelParamKind
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
public partial class V2beta1ClusterPolicySpecRulesValidateCelParamRefSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesValidateCelParamRefSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesValidateCelParamRefSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateCelParamRef
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
    public V2beta1ClusterPolicySpecRulesValidateCelParamRefSelector? Selector { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateCelVariables
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
public partial class V2beta1ClusterPolicySpecRulesValidateCel
{
    /// <summary>AuditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V2beta1ClusterPolicySpecRulesValidateCelAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>Expressions is a list of CELExpression types.</summary>
    [JsonPropertyName("expressions")]
    public IList<V2beta1ClusterPolicySpecRulesValidateCelExpressions>? Expressions { get; set; }

    /// <summary>
    /// Generate specifies whether to generate a Kubernetes ValidatingAdmissionPolicy from the rule.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("generate")]
    public bool? Generate { get; set; }

    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    [JsonPropertyName("paramKind")]
    public V2beta1ClusterPolicySpecRulesValidateCelParamKind? ParamKind { get; set; }

    /// <summary>ParamRef references a parameter resource.</summary>
    [JsonPropertyName("paramRef")]
    public V2beta1ClusterPolicySpecRulesValidateCelParamRef? ParamRef { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V2beta1ClusterPolicySpecRulesValidateCelVariables>? Variables { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidateDenyConditionsAllOperatorEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidateDenyConditionsAllOperatorEnum
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
public partial class V2beta1ClusterPolicySpecRulesValidateDenyConditionsAll
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
    public V2beta1ClusterPolicySpecRulesValidateDenyConditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidateDenyConditionsAnyOperatorEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidateDenyConditionsAnyOperatorEnum
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
public partial class V2beta1ClusterPolicySpecRulesValidateDenyConditionsAny
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
    public V2beta1ClusterPolicySpecRulesValidateDenyConditionsAnyOperatorEnum? Operator { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateDenyConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicySpecRulesValidateDenyConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicySpecRulesValidateDenyConditionsAny>? Any { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateDeny
{
    /// <summary>
    /// Multiple conditions can be declared under an `any` or `all` statement.
    /// See: https://kyverno.io/docs/writing-policies/validate/#deny-rules
    /// </summary>
    [JsonPropertyName("conditions")]
    public V2beta1ClusterPolicySpecRulesValidateDenyConditions? Conditions { get; set; }
}

/// <summary>
/// FailureAction defines if a validation policy rule violation should block
/// the admission review request (Enforce), or allow (Audit) the admission review request
/// and report an error in a policy report. Optional.
/// Allowed values are Audit or Enforce.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidateFailureActionEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidateFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesActionEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesActionEnum
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
public partial class V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1ClusterPolicySpecRulesValidateFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextConfigMap
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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContextVariable
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
public partial class V2beta1ClusterPolicySpecRulesValidateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicySpecRulesValidateForeachContextVariable? Variable { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateForeachDeny
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
public partial class V2beta1ClusterPolicySpecRulesValidateForeach
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicySpecRulesValidateForeachContext>? Context { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1ClusterPolicySpecRulesValidateForeachDeny? Deny { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesCertificatesCtlog
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesCertificatesRekor
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesCertificates
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
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeylessCtlog
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeylessRekor
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeysCtlog
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeysRekor
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeysSecret
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntries
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
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsAttestors
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
    public IList<V2beta1ClusterPolicySpecRulesValidateManifestsAttestorsEntries>? Entries { get; set; }
}

/// <summary>DryRun configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsDryRun
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsIgnoreFieldsObjects
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
public partial class V2beta1ClusterPolicySpecRulesValidateManifestsIgnoreFields
{
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    [JsonPropertyName("objects")]
    public IList<V2beta1ClusterPolicySpecRulesValidateManifestsIgnoreFieldsObjects>? Objects { get; set; }
}

/// <summary>Manifest specifies conditions for manifest verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidateManifests
{
    /// <summary>AnnotationDomain is custom domain of annotation for message and signature. Default is &quot;cosign.sigstore.dev&quot;.</summary>
    [JsonPropertyName("annotationDomain")]
    public string? AnnotationDomain { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1ClusterPolicySpecRulesValidateManifestsAttestors>? Attestors { get; set; }

    /// <summary>DryRun configuration</summary>
    [JsonPropertyName("dryRun")]
    public V2beta1ClusterPolicySpecRulesValidateManifestsDryRun? DryRun { get; set; }

    /// <summary>Fields which will be ignored while comparing manifests.</summary>
    [JsonPropertyName("ignoreFields")]
    public IList<V2beta1ClusterPolicySpecRulesValidateManifestsIgnoreFields>? IgnoreFields { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidatePodSecurityExcludeControlNameEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidatePodSecurityExcludeControlNameEnum
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
public partial class V2beta1ClusterPolicySpecRulesValidatePodSecurityExclude
{
    /// <summary>
    /// ControlName specifies the name of the Pod Security Standard control.
    /// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
    /// </summary>
    [JsonPropertyName("controlName")]
    public required V2beta1ClusterPolicySpecRulesValidatePodSecurityExcludeControlNameEnum ControlName { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidatePodSecurityLevelEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidatePodSecurityLevelEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesValidatePodSecurityVersionEnum>))]
public enum V2beta1ClusterPolicySpecRulesValidatePodSecurityVersionEnum
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
public partial class V2beta1ClusterPolicySpecRulesValidatePodSecurity
{
    /// <summary>Exclude specifies the Pod Security Standard controls to be excluded.</summary>
    [JsonPropertyName("exclude")]
    public IList<V2beta1ClusterPolicySpecRulesValidatePodSecurityExclude>? Exclude { get; set; }

    /// <summary>
    /// Level defines the Pod Security Standard level to be applied to workloads.
    /// Allowed values are privileged, baseline, and restricted.
    /// </summary>
    [JsonPropertyName("level")]
    public V2beta1ClusterPolicySpecRulesValidatePodSecurityLevelEnum? Level { get; set; }

    /// <summary>
    /// Version defines the Pod Security Standard versions that Kubernetes supports.
    /// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
    /// </summary>
    [JsonPropertyName("version")]
    public V2beta1ClusterPolicySpecRulesValidatePodSecurityVersionEnum? Version { get; set; }
}

/// <summary>Validation is used to validate matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesValidate
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
    public V2beta1ClusterPolicySpecRulesValidateCel? Cel { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1ClusterPolicySpecRulesValidateDeny? Deny { get; set; }

    /// <summary>
    /// FailureAction defines if a validation policy rule violation should block
    /// the admission review request (Enforce), or allow (Audit) the admission review request
    /// and report an error in a policy report. Optional.
    /// Allowed values are Audit or Enforce.
    /// </summary>
    [JsonPropertyName("failureAction")]
    public V2beta1ClusterPolicySpecRulesValidateFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// FailureActionOverrides is a Cluster Policy attribute that specifies FailureAction
    /// namespace-wise. It overrides FailureAction for the specified namespaces.
    /// </summary>
    [JsonPropertyName("failureActionOverrides")]
    public IList<V2beta1ClusterPolicySpecRulesValidateFailureActionOverrides>? FailureActionOverrides { get; set; }

    /// <summary>ForEach applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1ClusterPolicySpecRulesValidateForeach>? Foreach { get; set; }

    /// <summary>Manifest specifies conditions for manifest verification</summary>
    [JsonPropertyName("manifests")]
    public V2beta1ClusterPolicySpecRulesValidateManifests? Manifests { get; set; }

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
    public V2beta1ClusterPolicySpecRulesValidatePodSecurity? PodSecurity { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificates
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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntries
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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestors
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
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestorsEntries>? Entries { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum>))]
public enum V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAll
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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum>))]
public enum V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAny
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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAnyOperatorEnum? Operator { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditionsAny>? Any { get; set; }
}

/// <summary>
/// Attestation are checks for signed in-toto Statements that are used to verify the image.
/// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
/// OCI registry and decodes them into a list of Statements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestations
{
    /// <summary>Attestors specify the required attestors (i.e. authorities).</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsAttestors>? Attestors { get; set; }

    /// <summary>
    /// Conditions are used to verify attributes within a Predicate. If no Conditions are specified
    /// the attestation check is satisfied as long there are predicates that match the predicate type.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestationsConditions>? Conditions { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesCertificatesCtlog
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesCertificatesRekor
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesCertificates
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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeylessCtlog
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeylessRekor
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeysCtlog
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeysRekor
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeysSecret
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntries
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
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesAttestors
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
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestorsEntries>? Entries { get; set; }
}

/// <summary>Allowed values are Audit or Enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesVerifyImagesFailureActionEnum>))]
public enum V2beta1ClusterPolicySpecRulesVerifyImagesFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecRulesVerifyImagesTypeEnum>))]
public enum V2beta1ClusterPolicySpecRulesVerifyImagesTypeEnum
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesValidateDeny
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
public partial class V2beta1ClusterPolicySpecRulesVerifyImagesValidate
{
    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesValidateDeny? Deny { get; set; }

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
public partial class V2beta1ClusterPolicySpecRulesVerifyImages
{
    /// <summary>
    /// Attestations are optional checks for signed in-toto Statements used to verify the image.
    /// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
    /// OCI registry and decodes them into a list of Statement declarations.
    /// </summary>
    [JsonPropertyName("attestations")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestations>? Attestations { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImagesAttestors>? Attestors { get; set; }

    /// <summary>Allowed values are Audit or Enforce.</summary>
    [JsonPropertyName("failureAction")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesFailureActionEnum? FailureAction { get; set; }

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
    public V2beta1ClusterPolicySpecRulesVerifyImagesImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
    public V2beta1ClusterPolicySpecRulesVerifyImagesTypeEnum? Type { get; set; }

    /// <summary>UseCache enables caching of image verify responses for this rule</summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Validation checks conditions across multiple image
    /// verification attestations or context entries
    /// </summary>
    [JsonPropertyName("validate")]
    public V2beta1ClusterPolicySpecRulesVerifyImagesValidate? Validate { get; set; }

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
public partial class V2beta1ClusterPolicySpecRules
{
    /// <summary>
    /// CELPreconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of CEL conditions. It can only be used with the validate.cel subrule
    /// </summary>
    [JsonPropertyName("celPreconditions")]
    public IList<V2beta1ClusterPolicySpecRulesCelPreconditions>? CelPreconditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicySpecRulesContext>? Context { get; set; }

    /// <summary>
    /// ExcludeResources defines when this policy rule should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V2beta1ClusterPolicySpecRulesExclude? Exclude { get; set; }

    /// <summary>Generation is used to create new resources.</summary>
    [JsonPropertyName("generate")]
    public V2beta1ClusterPolicySpecRulesGenerate? Generate { get; set; }

    /// <summary>
    /// ImageExtractors defines a mapping from kinds to ImageExtractorConfigs.
    /// This config is only valid for verifyImages rules.
    /// </summary>
    [JsonPropertyName("imageExtractors")]
    public IDictionary<string, IList<V2beta1ClusterPolicySpecRulesImageExtractors>>? ImageExtractors { get; set; }

    /// <summary>
    /// MatchResources defines when this policy rule should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V2beta1ClusterPolicySpecRulesMatch Match { get; set; }

    /// <summary>Mutation is used to modify matching resources.</summary>
    [JsonPropertyName("mutate")]
    public V2beta1ClusterPolicySpecRulesMutate? Mutate { get; set; }

    /// <summary>Name is a label to identify the rule, It must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Preconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of conditions. The declaration can contain nested `any` or `all` statements.
    /// See: https://kyverno.io/docs/writing-policies/preconditions/
    /// </summary>
    [JsonPropertyName("preconditions")]
    public V2beta1ClusterPolicySpecRulesPreconditions? Preconditions { get; set; }

    /// <summary>
    /// SkipBackgroundRequests bypasses admission requests that are sent by the background controller.
    /// The default value is set to &quot;true&quot;, it must be set to &quot;false&quot; to apply
    /// generate and mutateExisting rules to those requests.
    /// </summary>
    [JsonPropertyName("skipBackgroundRequests")]
    public bool? SkipBackgroundRequests { get; set; }

    /// <summary>Validation is used to validate matching resources.</summary>
    [JsonPropertyName("validate")]
    public V2beta1ClusterPolicySpecRulesValidate? Validate { get; set; }

    /// <summary>VerifyImages is used to verify image signatures and mutate them to add a digest</summary>
    [JsonPropertyName("verifyImages")]
    public IList<V2beta1ClusterPolicySpecRulesVerifyImages>? VerifyImages { get; set; }
}

/// <summary>Deprecated, use validationFailureAction under the validate rule instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecValidationFailureActionEnum>))]
public enum V2beta1ClusterPolicySpecValidationFailureActionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecValidationFailureActionOverridesActionEnum>))]
public enum V2beta1ClusterPolicySpecValidationFailureActionOverridesActionEnum
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
public partial class V2beta1ClusterPolicySpecValidationFailureActionOverridesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicySpecValidationFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicySpecValidationFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicySpecValidationFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V2beta1ClusterPolicySpecValidationFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1ClusterPolicySpecValidationFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicySpecWebhookConfigurationFailurePolicyEnum>))]
public enum V2beta1ClusterPolicySpecWebhookConfigurationFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpecWebhookConfigurationMatchConditions
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
public partial class V2beta1ClusterPolicySpecWebhookConfiguration
{
    /// <summary>
    /// FailurePolicy defines how unexpected policy errors and webhook response timeout errors are handled.
    /// Rules within the same policy share the same failure behavior.
    /// This field should not be accessed directly, instead `GetFailurePolicy()` should be used.
    /// Allowed values are Ignore or Fail. Defaults to Fail.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V2beta1ClusterPolicySpecWebhookConfigurationFailurePolicyEnum? FailurePolicy { get; set; }

    /// <summary>
    /// MatchCondition configures admission webhook matchConditions.
    /// Requires Kubernetes 1.27 or later.
    /// </summary>
    [JsonPropertyName("matchConditions")]
    public IList<V2beta1ClusterPolicySpecWebhookConfigurationMatchConditions>? MatchConditions { get; set; }

    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Spec declares policy behaviors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicySpec
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
    public V2beta1ClusterPolicySpecApplyRulesEnum? ApplyRules { get; set; }

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
    public V2beta1ClusterPolicySpecFailurePolicyEnum? FailurePolicy { get; set; }

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
    public IList<V2beta1ClusterPolicySpecRules>? Rules { get; set; }

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
    public V2beta1ClusterPolicySpecValidationFailureActionEnum? ValidationFailureAction { get; set; }

    /// <summary>Deprecated, use validationFailureActionOverrides under the validate rule instead.</summary>
    [JsonPropertyName("validationFailureActionOverrides")]
    public IList<V2beta1ClusterPolicySpecValidationFailureActionOverrides>? ValidationFailureActionOverrides { get; set; }

    /// <summary>WebhookConfiguration specifies the custom configuration for Kubernetes admission webhookconfiguration.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V2beta1ClusterPolicySpecWebhookConfiguration? WebhookConfiguration { get; set; }

    /// <summary>Deprecated, use webhookTimeoutSeconds under webhookConfiguration instead.</summary>
    [JsonPropertyName("webhookTimeoutSeconds")]
    public int? WebhookTimeoutSeconds { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesCelPreconditions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextConfigMap
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContextVariable
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicyStatusAutogenRulesContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResources
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
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAllSubjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResources
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
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAnySubjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeResources
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
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesExcludeSubjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeAny>? Any { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesExcludeResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesExcludeSubjects>? Subjects { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateClone
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateCloneListSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateCloneList
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
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateCloneListSelector? Selector { get; set; }
}

/// <summary>
/// Clone specifies the source resource used to populate each generated resource.
/// At most one of Data or Clone can be specified. If neither are provided, the generated
/// resource will be created with default data only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachClone
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachCloneListSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachCloneListSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachCloneListSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachCloneList
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
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachCloneListSelector? Selector { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextConfigMap
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextVariable
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContextVariable? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerateForeach
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
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachCloneList? CloneList { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeachContext>? Context { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesGenerate
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
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateClone? Clone { get; set; }

    /// <summary>CloneList specifies the list of source resource used to populate each generated resource.</summary>
    [JsonPropertyName("cloneList")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerateCloneList? CloneList { get; set; }

    /// <summary>
    /// Data provides the resource declaration used to populate each generated resource.
    /// At most one of Data or Clone must be specified. If neither are provided, the generated
    /// resource will be created with default data only.
    /// </summary>
    [JsonPropertyName("data")]
    public JsonNode? Data { get; set; }

    /// <summary>ForEach applies generate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesGenerateForeach>? Foreach { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesImageExtractors
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAllResources
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
    public V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicyStatusAutogenRulesMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAllSubjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicyStatusAutogenRulesMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResources
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
    public V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAnySubjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2beta1ClusterPolicyStatusAutogenRulesMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesOperationsEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesOperationsEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchResources
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
    public V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2beta1ClusterPolicyStatusAutogenRulesMatchResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatchSubjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchAny>? Any { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesMatchResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMatchSubjects>? Subjects { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextConfigMap
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextVariable
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContextVariable? Variable { get; set; }
}

/// <summary>
/// Order defines the iteration order on the list.
/// Can be Ascending to iterate from first to last element or Descending to iterate in from last to first element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachOrderEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMutateForeachOrderEnum
{
    [EnumMember(Value = "Ascending"), JsonStringEnumMemberName("Ascending")]
    Ascending,
    [EnumMember(Value = "Descending"), JsonStringEnumMemberName("Descending")]
    Descending
}

/// <summary>ForEachMutation applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateForeach
{
    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateForeachContext>? Context { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesMutateForeachOrderEnum? Order { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextConfigMap
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextVariable
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContextVariable? Variable { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutateTargets
{
    /// <summary>APIVersion specifies resource apiVersion.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsContext>? Context { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesMutateTargetsSelector? Selector { get; set; }

    /// <summary>UID specifies the resource uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Mutation is used to modify matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesMutate
{
    /// <summary>ForEach applies mutation rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateForeach>? Foreach { get; set; }

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
    public IList<V2beta1ClusterPolicyStatusAutogenRulesMutateTargets>? Targets { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelAuditAnnotations
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamKind
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamRefSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamRefSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamRefSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamRef
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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamRefSelector? Selector { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCelVariables
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateCel
{
    /// <summary>AuditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateCelAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>Expressions is a list of CELExpression types.</summary>
    [JsonPropertyName("expressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateCelExpressions>? Expressions { get; set; }

    /// <summary>
    /// Generate specifies whether to generate a Kubernetes ValidatingAdmissionPolicy from the rule.
    /// Optional. Defaults to &quot;false&quot; if not specified.
    /// </summary>
    [JsonPropertyName("generate")]
    public bool? Generate { get; set; }

    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    [JsonPropertyName("paramKind")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamKind? ParamKind { get; set; }

    /// <summary>ParamRef references a parameter resource.</summary>
    [JsonPropertyName("paramRef")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateCelParamRef? ParamRef { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// The variables defined here will be available under `variables` in other expressions of the policy.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateCelVariables>? Variables { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateDeny
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ValidationFailureAction defines the policy validation failure action</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverrides
{
    /// <summary>ValidationFailureAction defines the policy validation failure action</summary>
    [JsonPropertyName("action")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesActionEnum? Action { get; set; }

    /// <summary>
    /// A label selector is a label query over a set of resources. The result of matchLabels and
    /// matchExpressions are ANDed. An empty label selector matches all objects. A null
    /// label selector matches no objects.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverridesNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallServiceHeaders
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallData>? Data { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCallService? Service { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextConfigMap
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextVariable
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContextVariable? Variable { get; set; }
}

/// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeachDeny
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateForeach
{
    /// <summary>
    /// AnyPattern specifies list of validation patterns. At least one of the patterns
    /// must be satisfied for the validation rule to succeed.
    /// </summary>
    [JsonPropertyName("anyPattern")]
    public JsonNode? AnyPattern { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateForeachContext>? Context { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateForeachDeny? Deny { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificates
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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysSecret
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntries
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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestors
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
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestorsEntries>? Entries { get; set; }
}

/// <summary>DryRun configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsDryRun
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsIgnoreFieldsObjects
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsIgnoreFields
{
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    [JsonPropertyName("objects")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsIgnoreFieldsObjects>? Objects { get; set; }
}

/// <summary>Manifest specifies conditions for manifest verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidateManifests
{
    /// <summary>AnnotationDomain is custom domain of annotation for message and signature. Default is &quot;cosign.sigstore.dev&quot;.</summary>
    [JsonPropertyName("annotationDomain")]
    public string? AnnotationDomain { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsAttestors>? Attestors { get; set; }

    /// <summary>DryRun configuration</summary>
    [JsonPropertyName("dryRun")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsDryRun? DryRun { get; set; }

    /// <summary>Fields which will be ignored while comparing manifests.</summary>
    [JsonPropertyName("ignoreFields")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateManifestsIgnoreFields>? IgnoreFields { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityExclude
{
    /// <summary>
    /// ControlName specifies the name of the Pod Security Standard control.
    /// See: https://kubernetes.io/docs/concepts/security/pod-security-standards/
    /// </summary>
    [JsonPropertyName("controlName")]
    public required V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityExcludeControlNameEnum ControlName { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityLevelEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityLevelEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityVersionEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityVersionEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurity
{
    /// <summary>Exclude specifies the Pod Security Standard controls to be excluded.</summary>
    [JsonPropertyName("exclude")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityExclude>? Exclude { get; set; }

    /// <summary>
    /// Level defines the Pod Security Standard level to be applied to workloads.
    /// Allowed values are privileged, baseline, and restricted.
    /// </summary>
    [JsonPropertyName("level")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityLevelEnum? Level { get; set; }

    /// <summary>
    /// Version defines the Pod Security Standard versions that Kubernetes supports.
    /// Allowed values are v1.19, v1.20, v1.21, v1.22, v1.23, v1.24, v1.25, v1.26, v1.27, v1.28, v1.29, v1.30, v1.31, v1.32, latest. Defaults to latest.
    /// </summary>
    [JsonPropertyName("version")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurityVersionEnum? Version { get; set; }
}

/// <summary>Validation is used to validate matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesValidate
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
    public V2beta1ClusterPolicyStatusAutogenRulesValidateCel? Cel { get; set; }

    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateDeny? Deny { get; set; }

    /// <summary>
    /// FailureAction defines if a validation policy rule violation should block
    /// the admission review request (Enforce), or allow (Audit) the admission review request
    /// and report an error in a policy report. Optional.
    /// Allowed values are Audit or Enforce.
    /// </summary>
    [JsonPropertyName("failureAction")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionEnum? FailureAction { get; set; }

    /// <summary>
    /// FailureActionOverrides is a Cluster Policy attribute that specifies FailureAction
    /// namespace-wise. It overrides FailureAction for the specified namespaces.
    /// </summary>
    [JsonPropertyName("failureActionOverrides")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateFailureActionOverrides>? FailureActionOverrides { get; set; }

    /// <summary>ForEach applies validate rules to a list of sub-elements by creating a context for each entry in the list and looping over it to apply the specified logic.</summary>
    [JsonPropertyName("foreach")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesValidateForeach>? Foreach { get; set; }

    /// <summary>Manifest specifies conditions for manifest verification</summary>
    [JsonPropertyName("manifests")]
    public V2beta1ClusterPolicyStatusAutogenRulesValidateManifests? Manifests { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesValidatePodSecurity? PodSecurity { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificates
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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntries
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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestors
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
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestorsEntries>? Entries { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAll
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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAny
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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAnyOperatorEnum? Operator { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditionsAny>? Any { get; set; }
}

/// <summary>
/// Attestation are checks for signed in-toto Statements that are used to verify the image.
/// See https://github.com/in-toto/attestation. Kyverno fetches signed attestations from the
/// OCI registry and decodes them into a list of Statements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestations
{
    /// <summary>Attestors specify the required attestors (i.e. authorities).</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsAttestors>? Attestors { get; set; }

    /// <summary>
    /// Conditions are used to verify attributes within a Predicate. If no Conditions are specified
    /// the attestation check is satisfied as long there are predicates that match the predicate type.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestationsConditions>? Conditions { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificates
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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesCtlog? Ctlog { get; set; }

    /// <summary>
    /// Rekor provides configuration for the Rekor transparency log service. If an empty object
    /// is provided the public instance of Rekor (https://rekor.sigstore.dev) is used.
    /// </summary>
    [JsonPropertyName("rekor")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificatesRekor? Rekor { get; set; }
}

/// <summary>
/// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
/// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeyless
{
    /// <summary>AdditionalExtensions are certificate-extensions used for keyless signing.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IDictionary<string, string>? AdditionalExtensions { get; set; }

    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeylessRekor? Rekor { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysCtlog
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysRekor
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysSecret
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeys
{
    /// <summary>
    /// CTLog (certificate timestamp log) provides a configuration for validation of Signed Certificate
    /// Timestamps (SCTs). If the value is unset, the default behavior by Cosign is used.
    /// </summary>
    [JsonPropertyName("ctlog")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysCtlog? Ctlog { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysRekor? Rekor { get; set; }

    /// <summary>Reference to a Secret resource that contains a public key</summary>
    [JsonPropertyName("secret")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeysSecret? Secret { get; set; }

    /// <summary>Deprecated. Use attestor.signatureAlgorithm instead.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntries
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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesCertificates? Certificates { get; set; }

    /// <summary>
    /// Keyless is a set of attribute used to verify a Sigstore keyless attestor.
    /// See https://github.com/sigstore/cosign/blob/main/KEYLESS.md.
    /// </summary>
    [JsonPropertyName("keyless")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeyless? Keyless { get; set; }

    /// <summary>Keys specifies one or more public keys.</summary>
    [JsonPropertyName("keys")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntriesKeys? Keys { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestors
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
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestorsEntries>? Entries { get; set; }
}

/// <summary>Allowed values are Audit or Enforce.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesFailureActionEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesFailureActionEnum
{
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Enforce"), JsonStringEnumMemberName("Enforce")]
    Enforce
}

/// <summary>ImageRegistryCredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesTypeEnum>))]
public enum V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesTypeEnum
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesValidateDeny
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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesValidate
{
    /// <summary>Deny defines conditions used to pass or fail a validation rule.</summary>
    [JsonPropertyName("deny")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesValidateDeny? Deny { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRulesVerifyImages
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
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestations>? Attestations { get; set; }

    /// <summary>Attestors specified the required attestors (i.e. authorities)</summary>
    [JsonPropertyName("attestors")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesAttestors>? Attestors { get; set; }

    /// <summary>
    /// CosignOCI11 enables the experimental OCI 1.1 behaviour in cosign image verification.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("cosignOCI11")]
    public bool? CosignOCI11 { get; set; }

    /// <summary>Allowed values are Audit or Enforce.</summary>
    [JsonPropertyName("failureAction")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesFailureActionEnum? FailureAction { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesTypeEnum? Type { get; set; }

    /// <summary>UseCache enables caching of image verify responses for this rule.</summary>
    [JsonPropertyName("useCache")]
    public bool? UseCache { get; set; }

    /// <summary>
    /// Validation checks conditions across multiple image
    /// verification attestations or context entries
    /// </summary>
    [JsonPropertyName("validate")]
    public V2beta1ClusterPolicyStatusAutogenRulesVerifyImagesValidate? Validate { get; set; }

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
public partial class V2beta1ClusterPolicyStatusAutogenRules
{
    /// <summary>
    /// CELPreconditions are used to determine if a policy rule should be applied by evaluating a
    /// set of CEL conditions. It can only be used with the validate.cel subrule
    /// </summary>
    [JsonPropertyName("celPreconditions")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesCelPreconditions>? CelPreconditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesContext>? Context { get; set; }

    /// <summary>
    /// ExcludeResources defines when this policy rule should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V2beta1ClusterPolicyStatusAutogenRulesExclude? Exclude { get; set; }

    /// <summary>Generation is used to create new resources.</summary>
    [JsonPropertyName("generate")]
    public V2beta1ClusterPolicyStatusAutogenRulesGenerate? Generate { get; set; }

    /// <summary>
    /// ImageExtractors defines a mapping from kinds to ImageExtractorConfigs.
    /// This config is only valid for verifyImages rules.
    /// </summary>
    [JsonPropertyName("imageExtractors")]
    public IDictionary<string, IList<V2beta1ClusterPolicyStatusAutogenRulesImageExtractors>>? ImageExtractors { get; set; }

    /// <summary>
    /// MatchResources defines when this policy rule should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V2beta1ClusterPolicyStatusAutogenRulesMatch Match { get; set; }

    /// <summary>Mutation is used to modify matching resources.</summary>
    [JsonPropertyName("mutate")]
    public V2beta1ClusterPolicyStatusAutogenRulesMutate? Mutate { get; set; }

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
    public V2beta1ClusterPolicyStatusAutogenRulesValidate? Validate { get; set; }

    /// <summary>VerifyImages is used to verify image signatures and mutate them to add a digest</summary>
    [JsonPropertyName("verifyImages")]
    public IList<V2beta1ClusterPolicyStatusAutogenRulesVerifyImages>? VerifyImages { get; set; }
}

/// <summary>AutogenStatus contains autogen status information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1ClusterPolicyStatusAutogen
{
    /// <summary>Rules is a list of Rule instances. It contains auto generated rules added for pod controllers</summary>
    [JsonPropertyName("rules")]
    public IList<V2beta1ClusterPolicyStatusAutogenRules>? Rules { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1ClusterPolicyStatusConditionsStatusEnum>))]
public enum V2beta1ClusterPolicyStatusConditionsStatusEnum
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
public partial class V2beta1ClusterPolicyStatusConditions
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
    public required V2beta1ClusterPolicyStatusConditionsStatusEnum Status { get; set; }

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
public partial class V2beta1ClusterPolicyStatusRulecount
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
public partial class V2beta1ClusterPolicyStatusValidatingadmissionpolicy
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
public partial class V2beta1ClusterPolicyStatus
{
    /// <summary>AutogenStatus contains autogen status information.</summary>
    [JsonPropertyName("autogen")]
    public V2beta1ClusterPolicyStatusAutogen? Autogen { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V2beta1ClusterPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Deprecated in favor of Conditions</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }

    /// <summary>
    /// RuleCountStatus contains four variables which describes counts for
    /// validate, generate, mutate and verify images rules
    /// </summary>
    [JsonPropertyName("rulecount")]
    public V2beta1ClusterPolicyStatusRulecount? Rulecount { get; set; }

    /// <summary>ValidatingAdmissionPolicy contains status information</summary>
    [JsonPropertyName("validatingadmissionpolicy")]
    public V2beta1ClusterPolicyStatusValidatingadmissionpolicy? Validatingadmissionpolicy { get; set; }
}

/// <summary>ClusterPolicy declares validation, mutation, and generation behaviors for matching resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2beta1ClusterPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V2beta1ClusterPolicySpec>, IStatus<V2beta1ClusterPolicyStatus?>
{
    public const string KubeApiVersion = "v2beta1";
    public const string KubeKind = "ClusterPolicy";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "clusterpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec declares policy behaviors.</summary>
    [JsonPropertyName("spec")]
    public required V2beta1ClusterPolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V2beta1ClusterPolicyStatus? Status { get; set; }
}