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
/// <summary>CleanupPolicy defines a rule for resource cleanup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2CleanupPolicyList : IKubernetesObject<V1ListMeta>, IItems<V2CleanupPolicy>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "CleanupPolicyList";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "cleanuppolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CleanupPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2CleanupPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2CleanupPolicy> Items { get; set; }
}

/// <summary>
/// Operator is the conditional operation to perform. Valid operators are:
/// Equals, NotEquals, In, AnyIn, AllIn, NotIn, AnyNotIn, AllNotIn, GreaterThanOrEquals,
/// GreaterThan, LessThanOrEquals, LessThan, DurationGreaterThanOrEquals, DurationGreaterThan,
/// DurationLessThanOrEquals, DurationLessThan
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecConditionsAllOperatorEnum>))]
public enum V2CleanupPolicySpecConditionsAllOperatorEnum
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
public partial class V2CleanupPolicySpecConditionsAll
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
    public V2CleanupPolicySpecConditionsAllOperatorEnum? Operator { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecConditionsAnyOperatorEnum>))]
public enum V2CleanupPolicySpecConditionsAnyOperatorEnum
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
public partial class V2CleanupPolicySpecConditionsAny
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
    public V2CleanupPolicySpecConditionsAnyOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Value is the conditional value, or set of values. The values can be fixed set
    /// or can be variables declared using JMESPath.
    /// </summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary>Conditions defines the conditions used to select the resources which will be cleaned up.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecConditions
{
    /// <summary>
    /// AllConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, all of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("all")]
    public IList<V2CleanupPolicySpecConditionsAll>? All { get; set; }

    /// <summary>
    /// AnyConditions enable variable-based conditional rule execution. This is useful for
    /// finer control of when an rule is applied. A condition can reference object data
    /// using JMESPath notation.
    /// Here, at least one of the conditions need to pass.
    /// </summary>
    [JsonPropertyName("any")]
    public IList<V2CleanupPolicySpecConditionsAny>? Any { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecContextApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecContextApiCallMethodEnum>))]
public enum V2CleanupPolicySpecContextApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecContextApiCallServiceHeaders
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
public partial class V2CleanupPolicySpecContextApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2CleanupPolicySpecContextApiCallServiceHeaders>? Headers { get; set; }

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
public partial class V2CleanupPolicySpecContextApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2CleanupPolicySpecContextApiCallData>? Data { get; set; }

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
    public V2CleanupPolicySpecContextApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2CleanupPolicySpecContextApiCallService? Service { get; set; }

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
public partial class V2CleanupPolicySpecContextConfigMap
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
public partial class V2CleanupPolicySpecContextGlobalReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecContextImageRegistryImageRegistryCredentialsProvidersEnum>))]
public enum V2CleanupPolicySpecContextImageRegistryImageRegistryCredentialsProvidersEnum
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
public partial class V2CleanupPolicySpecContextImageRegistryImageRegistryCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V2CleanupPolicySpecContextImageRegistryImageRegistryCredentialsProvidersEnum>? Providers { get; set; }

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
public partial class V2CleanupPolicySpecContextImageRegistry
{
    /// <summary>ImageRegistryCredentials provides credentials that will be used for authentication with registry</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public V2CleanupPolicySpecContextImageRegistryImageRegistryCredentials? ImageRegistryCredentials { get; set; }

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
public partial class V2CleanupPolicySpecContextVariable
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
public partial class V2CleanupPolicySpecContext
{
    /// <summary>
    /// APICall is an HTTP request to the Kubernetes API server, or other JSON web service.
    /// The data returned is stored in the context with the name for the context entry.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2CleanupPolicySpecContextApiCall? ApiCall { get; set; }

    /// <summary>ConfigMap is the ConfigMap reference.</summary>
    [JsonPropertyName("configMap")]
    public V2CleanupPolicySpecContextConfigMap? ConfigMap { get; set; }

    /// <summary>GlobalContextEntryReference is a reference to a cached global context entry.</summary>
    [JsonPropertyName("globalReference")]
    public V2CleanupPolicySpecContextGlobalReference? GlobalReference { get; set; }

    /// <summary>
    /// ImageRegistry defines requests to an OCI/Docker V2 registry to fetch image
    /// details.
    /// </summary>
    [JsonPropertyName("imageRegistry")]
    public V2CleanupPolicySpecContextImageRegistry? ImageRegistry { get; set; }

    /// <summary>Name is the variable name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Variable defines an arbitrary JMESPath context variable that can be defined inline.</summary>
    [JsonPropertyName("variable")]
    public V2CleanupPolicySpecContextVariable? Variable { get; set; }
}

/// <summary>DeletionPropagationPolicy defines how resources will be deleted (Foreground, Background, Orphan).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecDeletionPropagationPolicyEnum>))]
public enum V2CleanupPolicySpecDeletionPropagationPolicyEnum
{
    [EnumMember(Value = "Foreground"), JsonStringEnumMemberName("Foreground")]
    Foreground,
    [EnumMember(Value = "Background"), JsonStringEnumMemberName("Background")]
    Background,
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecExcludeAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecExcludeAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecExcludeAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecExcludeAllResourcesOperationsEnum>))]
public enum V2CleanupPolicySpecExcludeAllResourcesOperationsEnum
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
public partial class V2CleanupPolicySpecExcludeAllResourcesSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecExcludeAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecExcludeAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2CleanupPolicySpecExcludeAllResources
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
    public V2CleanupPolicySpecExcludeAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2CleanupPolicySpecExcludeAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2CleanupPolicySpecExcludeAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecExcludeAllSubjects
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
public partial class V2CleanupPolicySpecExcludeAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2CleanupPolicySpecExcludeAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2CleanupPolicySpecExcludeAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecExcludeAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecExcludeAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecExcludeAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecExcludeAnyResourcesOperationsEnum>))]
public enum V2CleanupPolicySpecExcludeAnyResourcesOperationsEnum
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
public partial class V2CleanupPolicySpecExcludeAnyResourcesSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecExcludeAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecExcludeAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2CleanupPolicySpecExcludeAnyResources
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
    public V2CleanupPolicySpecExcludeAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2CleanupPolicySpecExcludeAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2CleanupPolicySpecExcludeAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecExcludeAnySubjects
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
public partial class V2CleanupPolicySpecExcludeAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2CleanupPolicySpecExcludeAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2CleanupPolicySpecExcludeAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// ExcludeResources defines when cleanuppolicy should not be applied. The exclude
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the name or role.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecExclude
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2CleanupPolicySpecExcludeAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2CleanupPolicySpecExcludeAny>? Any { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecMatchAllResourcesNamespaceSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecMatchAllResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecMatchAllResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecMatchAllResourcesOperationsEnum>))]
public enum V2CleanupPolicySpecMatchAllResourcesOperationsEnum
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
public partial class V2CleanupPolicySpecMatchAllResourcesSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecMatchAllResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecMatchAllResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2CleanupPolicySpecMatchAllResources
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
    public V2CleanupPolicySpecMatchAllResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2CleanupPolicySpecMatchAllResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2CleanupPolicySpecMatchAllResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecMatchAllSubjects
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
public partial class V2CleanupPolicySpecMatchAll
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2CleanupPolicySpecMatchAllResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2CleanupPolicySpecMatchAllSubjects>? Subjects { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecMatchAnyResourcesNamespaceSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecMatchAnyResourcesNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecMatchAnyResourcesNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicySpecMatchAnyResourcesOperationsEnum>))]
public enum V2CleanupPolicySpecMatchAnyResourcesOperationsEnum
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
public partial class V2CleanupPolicySpecMatchAnyResourcesSelectorMatchExpressions
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
public partial class V2CleanupPolicySpecMatchAnyResourcesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CleanupPolicySpecMatchAnyResourcesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V2CleanupPolicySpecMatchAnyResources
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
    public V2CleanupPolicySpecMatchAnyResourcesNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// Namespaces is a list of namespaces names. Each name supports wildcard characters
    /// &quot;*&quot; (matches zero or many characters) and &quot;?&quot; (at least one character).
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>Operations can contain values [&quot;CREATE, &quot;UPDATE&quot;, &quot;CONNECT&quot;, &quot;DELETE&quot;], which are used to match a specific action.</summary>
    [JsonPropertyName("operations")]
    public IList<V2CleanupPolicySpecMatchAnyResourcesOperationsEnum>? Operations { get; set; }

    /// <summary>
    /// Selector is a label selector. Label keys and values in `matchLabels` support the wildcard
    /// characters `*` (matches zero or many characters) and `?` (matches one character).
    /// Wildcards allows writing label selectors like [&quot;storage.k8s.io/*&quot;: &quot;*&quot;]. Note that
    /// using [&quot;*&quot; : &quot;*&quot;] matches any key and value but does not match an empty label set.
    /// </summary>
    [JsonPropertyName("selector")]
    public V2CleanupPolicySpecMatchAnyResourcesSelector? Selector { get; set; }
}

/// <summary>
/// Subject contains a reference to the object or user identities a role binding applies to.  This can either hold a direct API object reference,
/// or a value for non-objects such as user and group names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecMatchAnySubjects
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
public partial class V2CleanupPolicySpecMatchAny
{
    /// <summary>ClusterRoles is the list of cluster-wide role names for the user.</summary>
    [JsonPropertyName("clusterRoles")]
    public IList<string>? ClusterRoles { get; set; }

    /// <summary>ResourceDescription contains information about the resource being created or modified.</summary>
    [JsonPropertyName("resources")]
    public V2CleanupPolicySpecMatchAnyResources? Resources { get; set; }

    /// <summary>Roles is the list of namespaced role names for the user.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }

    /// <summary>Subjects is the list of subject names like users, user groups, and service accounts.</summary>
    [JsonPropertyName("subjects")]
    public IList<V2CleanupPolicySpecMatchAnySubjects>? Subjects { get; set; }
}

/// <summary>
/// MatchResources defines when cleanuppolicy should be applied. The match
/// criteria can include resource information (e.g. kind, name, namespace, labels)
/// and admission review request information like the user name or role.
/// At least one kind is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpecMatch
{
    /// <summary>All allows specifying resources which will be ANDed</summary>
    [JsonPropertyName("all")]
    public IList<V2CleanupPolicySpecMatchAll>? All { get; set; }

    /// <summary>Any allows specifying resources which will be ORed</summary>
    [JsonPropertyName("any")]
    public IList<V2CleanupPolicySpecMatchAny>? Any { get; set; }
}

/// <summary>Spec declares policy behaviors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicySpec
{
    /// <summary>Conditions defines the conditions used to select the resources which will be cleaned up.</summary>
    [JsonPropertyName("conditions")]
    public V2CleanupPolicySpecConditions? Conditions { get; set; }

    /// <summary>Context defines variables and data sources that can be used during rule execution.</summary>
    [JsonPropertyName("context")]
    public IList<V2CleanupPolicySpecContext>? Context { get; set; }

    /// <summary>DeletionPropagationPolicy defines how resources will be deleted (Foreground, Background, Orphan).</summary>
    [JsonPropertyName("deletionPropagationPolicy")]
    public V2CleanupPolicySpecDeletionPropagationPolicyEnum? DeletionPropagationPolicy { get; set; }

    /// <summary>
    /// ExcludeResources defines when cleanuppolicy should not be applied. The exclude
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the name or role.
    /// </summary>
    [JsonPropertyName("exclude")]
    public V2CleanupPolicySpecExclude? Exclude { get; set; }

    /// <summary>
    /// MatchResources defines when cleanuppolicy should be applied. The match
    /// criteria can include resource information (e.g. kind, name, namespace, labels)
    /// and admission review request information like the user name or role.
    /// At least one kind is required.
    /// </summary>
    [JsonPropertyName("match")]
    public required V2CleanupPolicySpecMatch Match { get; set; }

    /// <summary>The schedule in Cron format</summary>
    [JsonPropertyName("schedule")]
    public required string Schedule { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2CleanupPolicyStatusConditionsStatusEnum>))]
public enum V2CleanupPolicyStatusConditionsStatusEnum
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
public partial class V2CleanupPolicyStatusConditions
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
    public required V2CleanupPolicyStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Status contains policy runtime data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CleanupPolicyStatus
{
    [JsonPropertyName("conditions")]
    public IList<V2CleanupPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("lastExecutionTime")]
    public DateTime? LastExecutionTime { get; set; }
}

/// <summary>CleanupPolicy defines a rule for resource cleanup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2CleanupPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V2CleanupPolicySpec>, IStatus<V2CleanupPolicyStatus?>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "CleanupPolicy";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "cleanuppolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CleanupPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec declares policy behaviors.</summary>
    [JsonPropertyName("spec")]
    public required V2CleanupPolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V2CleanupPolicyStatus? Status { get; set; }
}