#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>APIVersion defines a version of an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIVersionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIVersion>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIVersionList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIVersionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIVersion objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIVersion> Items { get; set; }
}

/// <summary>Cors defines the Cross-Origin Resource Sharing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecCors
{
    /// <summary>AddVaryHeader defines whether the Vary header is automatically added/updated when the AllowOriginsList is set.</summary>
    [JsonPropertyName("addVaryHeader")]
    public bool? AddVaryHeader { get; set; }

    /// <summary>AllowCredentials defines whether the request can include user credentials.</summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>AllowHeadersList defines the Access-Control-Request-Headers values sent in preflight response.</summary>
    [JsonPropertyName("allowHeadersList")]
    public IList<string>? AllowHeadersList { get; set; }

    /// <summary>AllowMethodsList defines the Access-Control-Request-Method values sent in preflight response.</summary>
    [JsonPropertyName("allowMethodsList")]
    public IList<string>? AllowMethodsList { get; set; }

    /// <summary>AllowOriginListRegex is a list of allowable origins written following the Regular Expression syntax (https://golang.org/pkg/regexp/).</summary>
    [JsonPropertyName("allowOriginListRegex")]
    public IList<string>? AllowOriginListRegex { get; set; }

    /// <summary>AllowOriginsList is a list of allowable origins. Can also be a wildcard origin &quot;*&quot;.</summary>
    [JsonPropertyName("allowOriginsList")]
    public IList<string>? AllowOriginsList { get; set; }

    /// <summary>ExposeHeadersList defines the Access-Control-Expose-Headers values sent in preflight response.</summary>
    [JsonPropertyName("exposeHeadersList")]
    public IList<string>? ExposeHeadersList { get; set; }

    /// <summary>MaxAge defines the time that a preflight request may be cached.</summary>
    [JsonPropertyName("maxAge")]
    public long? MaxAge { get; set; }
}

/// <summary>OperationMatcher defines criteria for matching an OpenAPI operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOperationSetsMatchers
{
    /// <summary>Methods specifies the HTTP methods to be included for selection.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Path specifies the exact path of the operations to select.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>PathPrefix specifies the path prefix of the operations to select.</summary>
    [JsonPropertyName("pathPrefix")]
    public string? PathPrefix { get; set; }

    /// <summary>PathRegex specifies a regular expression pattern for matching operations based on their paths.</summary>
    [JsonPropertyName("pathRegex")]
    public string? PathRegex { get; set; }
}

/// <summary>
/// OperationSet gives a name to a set of matching OpenAPI operations.
/// This set of operations can then be referenced for granular filtering in APICatalogItems or ManagedSubscriptions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOperationSets
{
    /// <summary>Matchers defines a list of alternative rules for matching OpenAPI operations.</summary>
    [JsonPropertyName("matchers")]
    public required IList<V1alpha1APIVersionSpecOpenApiSpecOperationSetsMatchers> Matchers { get; set; }

    /// <summary>Name is the name of the OperationSet to reference in APICatalogItems or ManagedSubscriptions.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOverrideServers
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>Override holds data used to override OpenAPI specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpecOverride
{
    [JsonPropertyName("servers")]
    public required IList<V1alpha1APIVersionSpecOpenApiSpecOverrideServers> Servers { get; set; }
}

/// <summary>OpenAPISpec defines the API contract as an OpenAPI specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpecOpenApiSpec
{
    /// <summary>OperationSets defines the sets of operations to be referenced for granular filtering in APICatalogItems or ManagedSubscriptions.</summary>
    [JsonPropertyName("operationSets")]
    public IList<V1alpha1APIVersionSpecOpenApiSpecOperationSets>? OperationSets { get; set; }

    /// <summary>Override holds data used to override OpenAPI specification.</summary>
    [JsonPropertyName("override")]
    public V1alpha1APIVersionSpecOpenApiSpecOverride? Override { get; set; }

    /// <summary>
    /// Path specifies the endpoint path within the Kubernetes Service where the OpenAPI specification can be obtained.
    /// The Service queried is determined by the associated Ingress, IngressRoute, or HTTPRoute resource to which the API is attached.
    /// It&apos;s important to note that this option is incompatible if the Ingress or IngressRoute specifies multiple backend services.
    /// The Path must be accessible via a GET request method and should serve a YAML or JSON document containing the OpenAPI specification.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>RefreshInterval defines the rate at which the OpenAPI specification is refreshed.</summary>
    [JsonPropertyName("refreshInterval")]
    public string? RefreshInterval { get; set; }

    /// <summary>
    /// URL is a Traefik Hub agent accessible URL for obtaining the OpenAPI specification.
    /// The URL must be accessible via a GET request method and should serve a YAML or JSON document containing the OpenAPI specification.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// ValidateRequestBodySchema validates the request body against the OpenAPI specification.
    /// This option overrides the default behavior configured in the static configuration.
    /// </summary>
    [JsonPropertyName("validateRequestBodySchema")]
    public bool? ValidateRequestBodySchema { get; set; }

    /// <summary>
    /// ValidateRequestMethodAndPath validates that the path and method matches an operation defined in the OpenAPI specification.
    /// This option overrides the default behavior configured in the static configuration.
    /// </summary>
    [JsonPropertyName("validateRequestMethodAndPath")]
    public bool? ValidateRequestMethodAndPath { get; set; }
}

/// <summary>The desired behavior of this APIVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionSpec
{
    /// <summary>Cors defines the Cross-Origin Resource Sharing configuration.</summary>
    [JsonPropertyName("cors")]
    public V1alpha1APIVersionSpecCors? Cors { get; set; }

    /// <summary>Description explains what the APIVersion does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>OpenAPISpec defines the API contract as an OpenAPI specification.</summary>
    [JsonPropertyName("openApiSpec")]
    public V1alpha1APIVersionSpecOpenApiSpec? OpenApiSpec { get; set; }

    /// <summary>
    /// Release is the version number of the API.
    /// This value must follow the SemVer format: https://semver.org/
    /// </summary>
    [JsonPropertyName("release")]
    public required string Release { get; set; }

    /// <summary>Title is the public facing name of the APIVersion.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIVersionStatusConditionsStatusEnum>))]
public enum V1alpha1APIVersionStatusConditionsStatusEnum
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
public partial class V1alpha1APIVersionStatusConditions
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
    public required V1alpha1APIVersionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The current status of this APIVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIVersionStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIVersionStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the APIVersion.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIVersion defines a version of an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIVersionSpec?>, IStatus<V1alpha1APIVersionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIVersion";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIVersion";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIVersion.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIVersionSpec? Spec { get; set; }

    /// <summary>The current status of this APIVersion.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIVersionStatus? Status { get; set; }
}