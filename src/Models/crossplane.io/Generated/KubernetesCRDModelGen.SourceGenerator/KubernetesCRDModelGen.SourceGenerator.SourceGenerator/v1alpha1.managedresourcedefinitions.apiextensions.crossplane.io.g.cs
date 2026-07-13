#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>A ManagedResourceDefinition defines the schema for a new custom Kubernetes API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedResourceDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedResourceDefinition>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedResourceDefinitionList";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "managedresourcedefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedResourceDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ManagedResourceDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ManagedResourceDefinition> Items { get; set; }
}

/// <summary>ConnectionDetail holds keys and descriptions of connection secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecConnectionDetails
{
    /// <summary>Description of how the key is used.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>Name of the key.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// service is a reference to the service for this webhook. Either
/// service or url must be specified.
/// 
/// If the webhook is running within the cluster, then you should use `service`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecConversionWebhookClientConfigService
{
    /// <summary>
    /// name is the name of the service.
    /// Required
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// namespace is the namespace of the service.
    /// Required
    /// </summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>path is an optional URL path at which the webhook will be contacted.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// port is an optional service port at which the webhook will be contacted.
    /// `port` should be a valid port number (1-65535, inclusive).
    /// Defaults to 443 for backward compatibility.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecConversionWebhookClientConfig
{
    /// <summary>
    /// caBundle is a PEM encoded CA bundle which will be used to validate the webhook&apos;s server certificate.
    /// If unspecified, system trust roots on the apiserver are used.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public byte[]? CaBundle { get; set; }

    /// <summary>
    /// service is a reference to the service for this webhook. Either
    /// service or url must be specified.
    /// 
    /// If the webhook is running within the cluster, then you should use `service`.
    /// </summary>
    [JsonPropertyName("service")]
    public V1alpha1ManagedResourceDefinitionSpecConversionWebhookClientConfigService? Service { get; set; }

    /// <summary>
    /// url gives the location of the webhook, in standard URL form
    /// (`scheme://host:port/path`). Exactly one of `url` or `service`
    /// must be specified.
    /// 
    /// The `host` should not refer to a service running in the cluster; use
    /// the `service` field instead. The host might be resolved via external
    /// DNS in some apiservers (e.g., `kube-apiserver` cannot resolve
    /// in-cluster DNS as that would be a layering violation). `host` may
    /// also be an IP address.
    /// 
    /// Please note that using `localhost` or `127.0.0.1` as a `host` is
    /// risky unless you take great care to run this webhook on all hosts
    /// which run an apiserver which might need to make calls to this
    /// webhook. Such installs are likely to be non-portable, i.e., not easy
    /// to turn up in a new cluster.
    /// 
    /// The scheme must be &quot;https&quot;; the URL must begin with &quot;https://&quot;.
    /// 
    /// A path is optional, and if present may be any string permissible in
    /// a URL. You may use the path to pass an arbitrary string to the
    /// webhook, for example, a cluster identifier.
    /// 
    /// Attempting to use a user or basic auth e.g. &quot;user:password@&quot; is not
    /// allowed. Fragments (&quot;#...&quot;) and query parameters (&quot;?...&quot;) are not
    /// allowed, either.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>webhook describes how to call the conversion webhook. Required when `strategy` is set to `&quot;Webhook&quot;`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecConversionWebhook
{
    /// <summary>clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.</summary>
    [JsonPropertyName("clientConfig")]
    public V1alpha1ManagedResourceDefinitionSpecConversionWebhookClientConfig? ClientConfig { get; set; }

    /// <summary>
    /// conversionReviewVersions is an ordered list of preferred `ConversionReview`
    /// versions the Webhook expects. The API server will use the first version in
    /// the list which it supports. If none of the versions specified in this list
    /// are supported by API server, conversion will fail for the custom resource.
    /// If a persisted Webhook configuration specifies allowed versions and does not
    /// include any versions known to the API Server, calls to the webhook will fail.
    /// </summary>
    [JsonPropertyName("conversionReviewVersions")]
    public required IList<string> ConversionReviewVersions { get; set; }
}

/// <summary>Conversion defines conversion settings for the CRD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecConversion
{
    /// <summary>
    /// strategy specifies how custom resources are converted between versions. Allowed values are:
    /// - `&quot;None&quot;`: The converter only change the apiVersion and would not touch any other field in the custom resource.
    /// - `&quot;Webhook&quot;`: API Server will call to an external webhook to do the conversion. Additional information
    ///   is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhook to be set.
    /// </summary>
    [JsonPropertyName("strategy")]
    public required string Strategy { get; set; }

    /// <summary>webhook describes how to call the conversion webhook. Required when `strategy` is set to `&quot;Webhook&quot;`.</summary>
    [JsonPropertyName("webhook")]
    public V1alpha1ManagedResourceDefinitionSpecConversionWebhook? Webhook { get; set; }
}

/// <summary>Names specify the resource and kind names for the custom resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecNames
{
    /// <summary>
    /// categories is a list of grouped resources this custom resource belongs to (e.g. &apos;all&apos;).
    /// This is published in API discovery documents, and used by clients to support invocations like
    /// `kubectl get all`.
    /// </summary>
    [JsonPropertyName("categories")]
    public IList<string>? Categories { get; set; }

    /// <summary>
    /// kind is the serialized kind of the resource. It is normally CamelCase and singular.
    /// Custom resource instances will use this value as the `kind` attribute in API calls.
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>listKind is the serialized kind of the list for this resource. Defaults to &quot;`kind`List&quot;.</summary>
    [JsonPropertyName("listKind")]
    public string? ListKind { get; set; }

    /// <summary>
    /// plural is the plural name of the resource to serve.
    /// The custom resources are served under `/apis/&lt;group&gt;/&lt;version&gt;/.../&lt;plural&gt;`.
    /// Must match the name of the CustomResourceDefinition (in the form `&lt;names.plural&gt;.&lt;group&gt;`).
    /// Must be all lowercase.
    /// </summary>
    [JsonPropertyName("plural")]
    public required string Plural { get; set; }

    /// <summary>
    /// shortNames are short names for the resource, exposed in API discovery documents,
    /// and used by clients to support invocations like `kubectl get &lt;shortname&gt;`.
    /// It must be all lowercase.
    /// </summary>
    [JsonPropertyName("shortNames")]
    public IList<string>? ShortNames { get; set; }

    /// <summary>singular is the singular name of the resource. It must be all lowercase. Defaults to lowercased `kind`.</summary>
    [JsonPropertyName("singular")]
    public string? Singular { get; set; }
}

/// <summary>
/// Scope indicates whether the defined custom resource is cluster- or namespace-scoped.
/// Allowed values are `Cluster` and `Namespaced`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ManagedResourceDefinitionSpecScopeEnum>))]
public enum V1alpha1ManagedResourceDefinitionSpecScopeEnum
{
    [EnumMember(Value = "Namespaced"), JsonStringEnumMemberName("Namespaced")]
    Namespaced,
    [EnumMember(Value = "Cluster"), JsonStringEnumMemberName("Cluster")]
    Cluster
}

/// <summary>State toggles whether the underlying CRD is created or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ManagedResourceDefinitionSpecStateEnum>))]
public enum V1alpha1ManagedResourceDefinitionSpecStateEnum
{
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive
}

/// <summary>CustomResourceColumnDefinition specifies a column for server side printing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersionsAdditionalPrinterColumns
{
    /// <summary>description is a human readable description of this column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// format is an optional OpenAPI type definition for this column. The &apos;name&apos; format is applied
    /// to the primary identifier column to assist in clients identifying column is the resource name.
    /// See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// jsonPath is a simple JSON path (i.e. with array notation) which is evaluated against
    /// each custom resource to produce the value for this column.
    /// </summary>
    [JsonPropertyName("jsonPath")]
    public required string JsonPath { get; set; }

    /// <summary>name is a human readable name for the column.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// priority is an integer defining the relative importance of this column compared to others. Lower
    /// numbers are considered higher priority. Columns that may be omitted in limited space scenarios
    /// should be given a priority greater than 0.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// type is an OpenAPI type definition for this column.
    /// See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Schema describes the schema used for validation, pruning, and defaulting of this version of the custom resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersionsSchema
{
    /// <summary>
    /// OpenAPIV3Schema is the OpenAPI v3 schema to use for validation and
    /// pruning.
    /// </summary>
    [JsonPropertyName("openAPIV3Schema")]
    public JsonNode? OpenAPIV3Schema { get; set; }
}

/// <summary>SelectableField specifies the JSON path of a field that may be used with field selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersionsSelectableFields
{
    /// <summary>
    /// jsonPath is a simple JSON path which is evaluated against each custom resource to produce a
    /// field selector value.
    /// Only JSON paths without the array notation are allowed.
    /// Must point to a field of type string, boolean or integer. Types with enum values
    /// and strings with formats are allowed.
    /// If jsonPath refers to absent field in a resource, the jsonPath evaluates to an empty string.
    /// Must not point to metdata fields.
    /// Required.
    /// </summary>
    [JsonPropertyName("jsonPath")]
    public required string JsonPath { get; set; }
}

/// <summary>scale indicates the custom resource should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersionsSubresourcesScale
{
    /// <summary>
    /// labelSelectorPath defines the JSON path inside of a custom resource that corresponds to Scale `status.selector`.
    /// Only JSON paths without the array notation are allowed.
    /// Must be a JSON Path under `.status` or `.spec`.
    /// Must be set to work with HorizontalPodAutoscaler.
    /// The field pointed by this JSON path must be a string field (not a complex selector struct)
    /// which contains a serialized label selector in string form.
    /// More info: https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions#scale-subresource
    /// If there is no value under the given path in the custom resource, the `status.selector` value in the `/scale`
    /// subresource will default to the empty string.
    /// </summary>
    [JsonPropertyName("labelSelectorPath")]
    public string? LabelSelectorPath { get; set; }

    /// <summary>
    /// specReplicasPath defines the JSON path inside of a custom resource that corresponds to Scale `spec.replicas`.
    /// Only JSON paths without the array notation are allowed.
    /// Must be a JSON Path under `.spec`.
    /// If there is no value under the given path in the custom resource, the `/scale` subresource will return an error on GET.
    /// </summary>
    [JsonPropertyName("specReplicasPath")]
    public required string SpecReplicasPath { get; set; }

    /// <summary>
    /// statusReplicasPath defines the JSON path inside of a custom resource that corresponds to Scale `status.replicas`.
    /// Only JSON paths without the array notation are allowed.
    /// Must be a JSON Path under `.status`.
    /// If there is no value under the given path in the custom resource, the `status.replicas` value in the `/scale` subresource
    /// will default to 0.
    /// </summary>
    [JsonPropertyName("statusReplicasPath")]
    public required string StatusReplicasPath { get; set; }
}

/// <summary>
/// status indicates the custom resource should serve a `/status` subresource.
/// When enabled:
/// 1. requests to the custom resource primary endpoint ignore changes to the `status` stanza of the object.
/// 2. requests to the custom resource `/status` subresource ignore changes to anything other than the `status` stanza of the object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersionsSubresourcesStatus
{
}

/// <summary>Subresources specify what subresources this version of the defined custom resource have.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersionsSubresources
{
    /// <summary>scale indicates the custom resource should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
    [JsonPropertyName("scale")]
    public V1alpha1ManagedResourceDefinitionSpecVersionsSubresourcesScale? Scale { get; set; }

    /// <summary>
    /// status indicates the custom resource should serve a `/status` subresource.
    /// When enabled:
    /// 1. requests to the custom resource primary endpoint ignore changes to the `status` stanza of the object.
    /// 2. requests to the custom resource `/status` subresource ignore changes to anything other than the `status` stanza of the object.
    /// </summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedResourceDefinitionSpecVersionsSubresourcesStatus? Status { get; set; }
}

/// <summary>CustomResourceDefinitionVersion describes a version for CRD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpecVersions
{
    /// <summary>
    /// AdditionalPrinterColumns specifies additional columns returned in Table output.
    /// See https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables for details.
    /// If no columns are specified, a single column displaying the age of the custom resource is used.
    /// </summary>
    [JsonPropertyName("additionalPrinterColumns")]
    public IList<V1alpha1ManagedResourceDefinitionSpecVersionsAdditionalPrinterColumns>? AdditionalPrinterColumns { get; set; }

    /// <summary>
    /// Deprecated indicates this version of the custom resource API is deprecated.
    /// When set to true, API requests to this version receive a warning header in the server response.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("deprecated")]
    public bool? Deprecated { get; set; }

    /// <summary>
    /// DeprecationWarning overrides the default warning returned to API clients.
    /// May only be set when `deprecated` is true.
    /// The default warning indicates this version is deprecated and recommends use
    /// of the newest served version of equal or greater stability, if one exists.
    /// </summary>
    [JsonPropertyName("deprecationWarning")]
    public string? DeprecationWarning { get; set; }

    /// <summary>
    /// Name is the version name, e.g. “v1”, “v2beta1”, etc.
    /// The custom resources are served under this version at `/apis/&lt;group&gt;/&lt;version&gt;/...` if `served` is true.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Schema describes the schema used for validation, pruning, and defaulting of this version of the custom resource.</summary>
    [JsonPropertyName("schema")]
    public V1alpha1ManagedResourceDefinitionSpecVersionsSchema? Schema { get; set; }

    /// <summary>
    /// SelectableFields specifies paths to fields that may be used as field selectors.
    /// A maximum of 8 selectable fields are allowed.
    /// See https://kubernetes.io/docs/concepts/overview/working-with-objects/field-selectors
    /// </summary>
    [JsonPropertyName("selectableFields")]
    public IList<V1alpha1ManagedResourceDefinitionSpecVersionsSelectableFields>? SelectableFields { get; set; }

    /// <summary>Served is a flag enabling/disabling this version from being served via REST APIs</summary>
    [JsonPropertyName("served")]
    public required bool Served { get; set; }

    /// <summary>
    /// Storage indicates this version should be used when persisting custom resources to storage.
    /// There must be exactly one version with storage=true.
    /// </summary>
    [JsonPropertyName("storage")]
    public required bool Storage { get; set; }

    /// <summary>Subresources specify what subresources this version of the defined custom resource have.</summary>
    [JsonPropertyName("subresources")]
    public V1alpha1ManagedResourceDefinitionSpecVersionsSubresources? Subresources { get; set; }
}

/// <summary>ManagedResourceDefinitionSpec specifies the desired state of the resource definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionSpec
{
    /// <summary>ConnectionDetails is an array of connection detail keys and descriptions.</summary>
    [JsonPropertyName("connectionDetails")]
    public IList<V1alpha1ManagedResourceDefinitionSpecConnectionDetails>? ConnectionDetails { get; set; }

    /// <summary>Conversion defines conversion settings for the CRD.</summary>
    [JsonPropertyName("conversion")]
    public V1alpha1ManagedResourceDefinitionSpecConversion? Conversion { get; set; }

    /// <summary>
    /// Group is the API group of the defined custom resource.
    /// The custom resources are served under `/apis/&lt;group&gt;/...`.
    /// Must match the name of the CustomResourceDefinition (in the form `&lt;names.plural&gt;.&lt;group&gt;`).
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Names specify the resource and kind names for the custom resource.</summary>
    [JsonPropertyName("names")]
    public required V1alpha1ManagedResourceDefinitionSpecNames Names { get; set; }

    /// <summary>
    /// PreserveUnknownFields indicates that object fields which are not specified
    /// in the OpenAPI schema should be preserved when persisting to storage.
    /// apiVersion, kind, metadata and known fields inside metadata are always preserved.
    /// This field is deprecated in favor of setting `x-preserve-unknown-fields` to true in `spec.versions[*].schema.openAPIV3Schema`.
    /// See https://kubernetes.io/docs/tasks/extend-kubernetes/custom-resources/custom-resource-definitions/#field-pruning for details.
    /// </summary>
    [JsonPropertyName("preserveUnknownFields")]
    public bool? PreserveUnknownFields { get; set; }

    /// <summary>
    /// Scope indicates whether the defined custom resource is cluster- or namespace-scoped.
    /// Allowed values are `Cluster` and `Namespaced`.
    /// </summary>
    [JsonPropertyName("scope")]
    public V1alpha1ManagedResourceDefinitionSpecScopeEnum? Scope { get; set; }

    /// <summary>State toggles whether the underlying CRD is created or not.</summary>
    [JsonPropertyName("state")]
    public V1alpha1ManagedResourceDefinitionSpecStateEnum? State { get; set; }

    /// <summary>
    /// Versions is the list of all API versions of the defined custom resource.
    /// Version names are used to compute the order in which served versions are listed in API discovery.
    /// If the version string is &quot;kube-like&quot;, it will sort above non &quot;kube-like&quot; version strings, which are ordered
    /// lexicographically. &quot;Kube-like&quot; versions start with a &quot;v&quot;, then are followed by a number (the major version),
    /// then optionally the string &quot;alpha&quot; or &quot;beta&quot; and another number (the minor version). These are sorted first
    /// by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing
    /// major version, then minor version. An example sorted list of versions:
    /// v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
    /// </summary>
    [JsonPropertyName("versions")]
    public required IList<V1alpha1ManagedResourceDefinitionSpecVersions> Versions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ManagedResourceDefinitionStatus shows the observed state of the resource definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedResourceDefinitionStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ManagedResourceDefinitionStatusConditions>? Conditions { get; set; }
}

/// <summary>A ManagedResourceDefinition defines the schema for a new custom Kubernetes API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedResourceDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedResourceDefinitionSpec?>, IStatus<V1alpha1ManagedResourceDefinitionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedResourceDefinition";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "managedresourcedefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedResourceDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedResourceDefinitionSpec specifies the desired state of the resource definition.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ManagedResourceDefinitionSpec? Spec { get; set; }

    /// <summary>ManagedResourceDefinitionStatus shows the observed state of the resource definition.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedResourceDefinitionStatus? Status { get; set; }
}