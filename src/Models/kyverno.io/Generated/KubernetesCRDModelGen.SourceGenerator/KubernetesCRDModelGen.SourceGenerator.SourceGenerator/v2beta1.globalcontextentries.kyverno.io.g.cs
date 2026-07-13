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
/// <summary>GlobalContextEntry declares resources to be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2beta1GlobalContextEntryList : IKubernetesObject<V1ListMeta>, IItems<V2beta1GlobalContextEntry>
{
    public const string KubeApiVersion = "v2beta1";
    public const string KubeKind = "GlobalContextEntryList";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "globalcontextentries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GlobalContextEntryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2beta1GlobalContextEntry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2beta1GlobalContextEntry> Items { get; set; }
}

/// <summary>RequestData contains the HTTP POST data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntrySpecApiCallData
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
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1GlobalContextEntrySpecApiCallMethodEnum>))]
public enum V2beta1GlobalContextEntrySpecApiCallMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntrySpecApiCallServiceHeaders
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
public partial class V2beta1GlobalContextEntrySpecApiCallService
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate
    /// the server certificate.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public string? CaBundle { get; set; }

    /// <summary>Headers is a list of optional HTTP headers to be included in the request.</summary>
    [JsonPropertyName("headers")]
    public IList<V2beta1GlobalContextEntrySpecApiCallServiceHeaders>? Headers { get; set; }

    /// <summary>
    /// URL is the JSON web service URL. A typical form is
    /// `https://{service}.{namespace}:{port}/{path}`.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// Stores results from an API call which will be cached.
/// Mutually exclusive with KubernetesResource.
/// This can be used to make calls to external (non-Kubernetes API server) services.
/// It can also be used to make calls to the Kubernetes API server in such cases:
/// 1. A POST is needed to create a resource.
/// 2. Finer-grained control is needed. Example: To restrict the number of resources cached.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntrySpecApiCall
{
    /// <summary>
    /// The data object specifies the POST data sent to the server.
    /// Only applicable when the method field is set to POST.
    /// </summary>
    [JsonPropertyName("data")]
    public IList<V2beta1GlobalContextEntrySpecApiCallData>? Data { get; set; }

    /// <summary>Method is the HTTP request type (GET or POST). Defaults to GET.</summary>
    [JsonPropertyName("method")]
    public V2beta1GlobalContextEntrySpecApiCallMethodEnum? Method { get; set; }

    /// <summary>
    /// RefreshInterval defines the interval in duration at which to poll the APICall.
    /// The duration is a sequence of decimal numbers, each with optional fraction and a unit suffix,
    /// such as &quot;300ms&quot;, &quot;1.5h&quot; or &quot;2h45m&quot;. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;.
    /// </summary>
    [JsonPropertyName("refreshInterval")]
    public string? RefreshInterval { get; set; }

    /// <summary>RetryLimit defines the number of times the APICall should be retried in case of failure.</summary>
    [JsonPropertyName("retryLimit")]
    public int? RetryLimit { get; set; }

    /// <summary>
    /// Service is an API call to a JSON web service.
    /// This is used for non-Kubernetes API server calls.
    /// It&apos;s mutually exclusive with the URLPath field.
    /// </summary>
    [JsonPropertyName("service")]
    public V2beta1GlobalContextEntrySpecApiCallService? Service { get; set; }

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

/// <summary>
/// Stores a list of Kubernetes resources which will be cached.
/// Mutually exclusive with APICall.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntrySpecKubernetesResource
{
    /// <summary>Group defines the group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Namespace defines the namespace of the resource. Leave empty for cluster scoped resources.
    /// If left empty for namespaced resources, all resources from all namespaces will be cached.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Resource defines the type of the resource.
    /// Requires the pluralized form of the resource kind in lowercase. (Ex., &quot;deployments&quot;)
    /// </summary>
    [JsonPropertyName("resource")]
    public required string Resource { get; set; }

    /// <summary>Version defines the version of the resource.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntrySpecProjections
{
    /// <summary>JMESPath is the JMESPath expression to extract the value from the cached resource.</summary>
    [JsonPropertyName("jmesPath")]
    public required string JmesPath { get; set; }

    /// <summary>Name is the name to use for the extracted value in the context.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Spec declares policy exception behaviors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntrySpec
{
    /// <summary>
    /// Stores results from an API call which will be cached.
    /// Mutually exclusive with KubernetesResource.
    /// This can be used to make calls to external (non-Kubernetes API server) services.
    /// It can also be used to make calls to the Kubernetes API server in such cases:
    /// 1. A POST is needed to create a resource.
    /// 2. Finer-grained control is needed. Example: To restrict the number of resources cached.
    /// </summary>
    [JsonPropertyName("apiCall")]
    public V2beta1GlobalContextEntrySpecApiCall? ApiCall { get; set; }

    /// <summary>
    /// Stores a list of Kubernetes resources which will be cached.
    /// Mutually exclusive with APICall.
    /// </summary>
    [JsonPropertyName("kubernetesResource")]
    public V2beta1GlobalContextEntrySpecKubernetesResource? KubernetesResource { get; set; }

    /// <summary>Projections defines the list of JMESPath expressions to extract values from the cached resource.</summary>
    [JsonPropertyName("projections")]
    public IList<V2beta1GlobalContextEntrySpecProjections>? Projections { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2beta1GlobalContextEntryStatusConditionsStatusEnum>))]
public enum V2beta1GlobalContextEntryStatusConditionsStatusEnum
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
public partial class V2beta1GlobalContextEntryStatusConditions
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
    public required V2beta1GlobalContextEntryStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Status contains globalcontextentry runtime data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2beta1GlobalContextEntryStatus
{
    [JsonPropertyName("conditions")]
    public IList<V2beta1GlobalContextEntryStatusConditions>? Conditions { get; set; }

    /// <summary>Indicates the time when the globalcontextentry was last refreshed successfully for the API Call</summary>
    [JsonPropertyName("lastRefreshTime")]
    public DateTime? LastRefreshTime { get; set; }

    /// <summary>Deprecated in favor of Conditions</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }
}

/// <summary>GlobalContextEntry declares resources to be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2beta1GlobalContextEntry : IKubernetesObject<V1ObjectMeta>, ISpec<V2beta1GlobalContextEntrySpec>, IStatus<V2beta1GlobalContextEntryStatus?>
{
    public const string KubeApiVersion = "v2beta1";
    public const string KubeKind = "GlobalContextEntry";
    public const string KubeGroup = "kyverno.io";
    public const string KubePluralName = "globalcontextentries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kyverno.io/v2beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GlobalContextEntry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec declares policy exception behaviors.</summary>
    [JsonPropertyName("spec")]
    public required V2beta1GlobalContextEntrySpec Spec { get; set; }

    /// <summary>Status contains globalcontextentry runtime data.</summary>
    [JsonPropertyName("status")]
    public V2beta1GlobalContextEntryStatus? Status { get; set; }
}