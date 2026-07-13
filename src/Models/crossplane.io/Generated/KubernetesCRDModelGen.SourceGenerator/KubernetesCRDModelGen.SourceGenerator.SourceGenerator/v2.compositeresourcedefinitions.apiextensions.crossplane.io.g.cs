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
/// <summary>
/// A CompositeResourceDefinition defines the schema for a new custom Kubernetes
/// API.
/// 
/// Read the Crossplane documentation for
/// [more information about CustomResourceDefinitions](https://docs.crossplane.io/latest/composition/composite-resource-definitions/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2CompositeResourceDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V2CompositeResourceDefinition>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "CompositeResourceDefinitionList";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "compositeresourcedefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CompositeResourceDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2CompositeResourceDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2CompositeResourceDefinition> Items { get; set; }
}

/// <summary>
/// ClaimNames specifies the names of an optional composite resource claim.
/// When claim names are specified Crossplane will create a namespaced
/// &apos;composite resource claim&apos; CRD that corresponds to the defined composite
/// resource. This composite resource claim acts as a namespaced proxy for
/// the composite resource; creating, updating, or deleting the claim will
/// create, update, or delete a corresponding composite resource. You may add
/// claim names to an existing CompositeResourceDefinition, but they cannot
/// be changed or removed once they have been set.
/// 
/// Deprecated: Claims aren&apos;t supported in apiextensions.crossplane.io/v2.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecClaimNames
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
/// service is a reference to the service for this webhook. Either
/// service or url must be specified.
/// 
/// If the webhook is running within the cluster, then you should use `service`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecConversionWebhookClientConfigService
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
public partial class V2CompositeResourceDefinitionSpecConversionWebhookClientConfig
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
    public V2CompositeResourceDefinitionSpecConversionWebhookClientConfigService? Service { get; set; }

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
public partial class V2CompositeResourceDefinitionSpecConversionWebhook
{
    /// <summary>clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.</summary>
    [JsonPropertyName("clientConfig")]
    public V2CompositeResourceDefinitionSpecConversionWebhookClientConfig? ClientConfig { get; set; }

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

/// <summary>Conversion defines all conversion settings for the defined Composite resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecConversion
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
    public V2CompositeResourceDefinitionSpecConversionWebhook? Webhook { get; set; }
}

/// <summary>
/// DefaultCompositeDeletePolicy is the policy used when deleting the Composite
/// that is associated with the Claim if no policy has been specified.
/// 
/// Deprecated: Claims aren&apos;t supported in apiextensions.crossplane.io/v2.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2CompositeResourceDefinitionSpecDefaultCompositeDeletePolicyEnum>))]
public enum V2CompositeResourceDefinitionSpecDefaultCompositeDeletePolicyEnum
{
    [EnumMember(Value = "Background"), JsonStringEnumMemberName("Background")]
    Background,
    [EnumMember(Value = "Foreground"), JsonStringEnumMemberName("Foreground")]
    Foreground
}

/// <summary>
/// DefaultCompositionRef refers to the Composition resource that will be used
/// in case no composition selector is given.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecDefaultCompositionRef
{
    /// <summary>Name of the Composition.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecDefaultCompositionRevisionSelectorMatchExpressions
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
/// DefaultCompositionRevisionSelector refers to the CompositionRevision that will be used
/// in case no compositionRevision selector is given.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecDefaultCompositionRevisionSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V2CompositeResourceDefinitionSpecDefaultCompositionRevisionSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// DefaultCompositionUpdatePolicy is the policy used when updating composites after a new
/// Composition Revision has been created if no policy has been specified on the composite.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2CompositeResourceDefinitionSpecDefaultCompositionUpdatePolicyEnum>))]
public enum V2CompositeResourceDefinitionSpecDefaultCompositionUpdatePolicyEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>
/// EnforcedCompositionRef refers to the Composition resource that will be used
/// by all composite instances whose schema is defined by this definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecEnforcedCompositionRef
{
    /// <summary>Name of the Composition.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Metadata specifies the desired metadata for the defined composite resource and claim CRD&apos;s.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecMetadata
{
    /// <summary>
    /// Annotations is an unstructured key value map stored with a resource that may be
    /// set by external tools to store and retrieve arbitrary metadata. They are not
    /// queryable and should be preserved when modifying objects.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels
    /// and services.
    /// These labels are added to the composite resource and claim CRD&apos;s in addition
    /// to any labels defined by `CompositionResourceDefinition` `metadata.labels`.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Names specifies the resource and kind names of the defined composite
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecNames
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
/// Scope of the defined composite resource. Namespaced composite resources
/// are scoped to a single namespace. Cluster scoped composite resource exist
/// outside the scope of any namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2CompositeResourceDefinitionSpecScopeEnum>))]
public enum V2CompositeResourceDefinitionSpecScopeEnum
{
    [EnumMember(Value = "Namespaced"), JsonStringEnumMemberName("Namespaced")]
    Namespaced,
    [EnumMember(Value = "Cluster"), JsonStringEnumMemberName("Cluster")]
    Cluster
}

/// <summary>CustomResourceColumnDefinition specifies a column for server side printing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecVersionsAdditionalPrinterColumns
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

/// <summary>
/// Schema describes the schema used for validation, pruning, and defaulting
/// of this version of the defined composite resource. Fields required by all
/// composite resources will be injected into this schema automatically, and
/// will override equivalently named fields in this schema. Omitting this
/// schema results in a schema that contains only the fields required by all
/// composite resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecVersionsSchema
{
    /// <summary>
    /// OpenAPIV3Schema is the OpenAPI v3 schema to use for validation and
    /// pruning.
    /// </summary>
    [JsonPropertyName("openAPIV3Schema")]
    public JsonNode? OpenAPIV3Schema { get; set; }
}

/// <summary>Scale indicates the CRD should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecVersionsSubresourcesScale
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
/// Subresources specifies what subresources this version of the defined Composite resource has.
/// The composition authors have responsibility to implement the logic fulfilling the subresources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecVersionsSubresources
{
    /// <summary>Scale indicates the CRD should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
    [JsonPropertyName("scale")]
    public V2CompositeResourceDefinitionSpecVersionsSubresourcesScale? Scale { get; set; }
}

/// <summary>CompositeResourceDefinitionVersion describes a version of an XR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpecVersions
{
    /// <summary>
    /// AdditionalPrinterColumns specifies additional columns returned in Table
    /// output. If no columns are specified, a single column displaying the age
    /// of the custom resource is used. See the following link for details:
    /// https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables
    /// </summary>
    [JsonPropertyName("additionalPrinterColumns")]
    public IList<V2CompositeResourceDefinitionSpecVersionsAdditionalPrinterColumns>? AdditionalPrinterColumns { get; set; }

    /// <summary>
    /// The deprecated field specifies that this version is deprecated and should
    /// not be used.
    /// </summary>
    [JsonPropertyName("deprecated")]
    public bool? Deprecated { get; set; }

    /// <summary>
    /// DeprecationWarning specifies the message that should be shown to the user
    /// when using this version.
    /// </summary>
    [JsonPropertyName("deprecationWarning")]
    public string? DeprecationWarning { get; set; }

    /// <summary>
    /// Name of this version, e.g. “v1”, “v2beta1”, etc. Composite resources are
    /// served under this version at `/apis/&lt;group&gt;/&lt;version&gt;/...` if `served` is
    /// true.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Referenceable specifies that this version may be referenced by a
    /// Composition in order to configure which resources an XR may be composed
    /// of. Exactly one version must be marked as referenceable; all Compositions
    /// must target only the referenceable version. The referenceable version
    /// must be served. It&apos;s mapped to the CRD&apos;s `spec.versions[*].storage` field.
    /// </summary>
    [JsonPropertyName("referenceable")]
    public required bool Referenceable { get; set; }

    /// <summary>
    /// Schema describes the schema used for validation, pruning, and defaulting
    /// of this version of the defined composite resource. Fields required by all
    /// composite resources will be injected into this schema automatically, and
    /// will override equivalently named fields in this schema. Omitting this
    /// schema results in a schema that contains only the fields required by all
    /// composite resources.
    /// </summary>
    [JsonPropertyName("schema")]
    public V2CompositeResourceDefinitionSpecVersionsSchema? Schema { get; set; }

    /// <summary>Served specifies that this version should be served via REST APIs.</summary>
    [JsonPropertyName("served")]
    public required bool Served { get; set; }

    /// <summary>
    /// Subresources specifies what subresources this version of the defined Composite resource has.
    /// The composition authors have responsibility to implement the logic fulfilling the subresources.
    /// </summary>
    [JsonPropertyName("subresources")]
    public V2CompositeResourceDefinitionSpecVersionsSubresources? Subresources { get; set; }
}

/// <summary>CompositeResourceDefinitionSpec specifies the desired state of the definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionSpec
{
    /// <summary>
    /// ClaimNames specifies the names of an optional composite resource claim.
    /// When claim names are specified Crossplane will create a namespaced
    /// &apos;composite resource claim&apos; CRD that corresponds to the defined composite
    /// resource. This composite resource claim acts as a namespaced proxy for
    /// the composite resource; creating, updating, or deleting the claim will
    /// create, update, or delete a corresponding composite resource. You may add
    /// claim names to an existing CompositeResourceDefinition, but they cannot
    /// be changed or removed once they have been set.
    /// 
    /// Deprecated: Claims aren&apos;t supported in apiextensions.crossplane.io/v2.
    /// </summary>
    [JsonPropertyName("claimNames")]
    public V2CompositeResourceDefinitionSpecClaimNames? ClaimNames { get; set; }

    /// <summary>
    /// ConnectionSecretKeys is the list of connection secret keys the
    /// defined XR can publish. If the list is empty, all keys will be
    /// published. If the list isn&apos;t empty, any connection secret keys that
    /// don&apos;t appear in the list will be filtered out. Only LegacyCluster XRs
    /// support connection secrets.
    /// 
    /// Deprecated: XR connection secrets aren&apos;t supported in
    /// apiextensions.crossplane.io/v2. Compose a secret instead.
    /// </summary>
    [JsonPropertyName("connectionSecretKeys")]
    public IList<string>? ConnectionSecretKeys { get; set; }

    /// <summary>Conversion defines all conversion settings for the defined Composite resource.</summary>
    [JsonPropertyName("conversion")]
    public V2CompositeResourceDefinitionSpecConversion? Conversion { get; set; }

    /// <summary>
    /// DefaultCompositeDeletePolicy is the policy used when deleting the Composite
    /// that is associated with the Claim if no policy has been specified.
    /// 
    /// Deprecated: Claims aren&apos;t supported in apiextensions.crossplane.io/v2.
    /// </summary>
    [JsonPropertyName("defaultCompositeDeletePolicy")]
    public V2CompositeResourceDefinitionSpecDefaultCompositeDeletePolicyEnum? DefaultCompositeDeletePolicy { get; set; }

    /// <summary>
    /// DefaultCompositionRef refers to the Composition resource that will be used
    /// in case no composition selector is given.
    /// </summary>
    [JsonPropertyName("defaultCompositionRef")]
    public V2CompositeResourceDefinitionSpecDefaultCompositionRef? DefaultCompositionRef { get; set; }

    /// <summary>
    /// DefaultCompositionRevisionSelector refers to the CompositionRevision that will be used
    /// in case no compositionRevision selector is given.
    /// </summary>
    [JsonPropertyName("defaultCompositionRevisionSelector")]
    public V2CompositeResourceDefinitionSpecDefaultCompositionRevisionSelector? DefaultCompositionRevisionSelector { get; set; }

    /// <summary>
    /// DefaultCompositionUpdatePolicy is the policy used when updating composites after a new
    /// Composition Revision has been created if no policy has been specified on the composite.
    /// </summary>
    [JsonPropertyName("defaultCompositionUpdatePolicy")]
    public V2CompositeResourceDefinitionSpecDefaultCompositionUpdatePolicyEnum? DefaultCompositionUpdatePolicy { get; set; }

    /// <summary>
    /// EnforcedCompositionRef refers to the Composition resource that will be used
    /// by all composite instances whose schema is defined by this definition.
    /// </summary>
    [JsonPropertyName("enforcedCompositionRef")]
    public V2CompositeResourceDefinitionSpecEnforcedCompositionRef? EnforcedCompositionRef { get; set; }

    /// <summary>
    /// Group specifies the API group of the defined composite resource.
    /// Composite resources are served under `/apis/&lt;group&gt;/...`. Must match the
    /// name of the XRD (in the form `&lt;names.plural&gt;.&lt;group&gt;`).
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Metadata specifies the desired metadata for the defined composite resource and claim CRD&apos;s.</summary>
    [JsonPropertyName("metadata")]
    public V2CompositeResourceDefinitionSpecMetadata? Metadata { get; set; }

    /// <summary>
    /// Names specifies the resource and kind names of the defined composite
    /// resource.
    /// </summary>
    [JsonPropertyName("names")]
    public required V2CompositeResourceDefinitionSpecNames Names { get; set; }

    /// <summary>
    /// Scope of the defined composite resource. Namespaced composite resources
    /// are scoped to a single namespace. Cluster scoped composite resource exist
    /// outside the scope of any namespace.
    /// </summary>
    [JsonPropertyName("scope")]
    public V2CompositeResourceDefinitionSpecScopeEnum? Scope { get; set; }

    /// <summary>
    /// Versions is the list of all API versions of the defined composite
    /// resource. Version names are used to compute the order in which served
    /// versions are listed in API discovery. If the version string is
    /// &quot;kube-like&quot;, it will sort above non &quot;kube-like&quot; version strings, which
    /// are ordered lexicographically. &quot;Kube-like&quot; versions start with a &quot;v&quot;,
    /// then are followed by a number (the major version), then optionally the
    /// string &quot;alpha&quot; or &quot;beta&quot; and another number (the minor version). These
    /// are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no
    /// suffix such as beta or alpha), and then by comparing major version, then
    /// minor version. An example sorted list of versions: v10, v2, v1, v11beta2,
    /// v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
    /// </summary>
    [JsonPropertyName("versions")]
    public required IList<V2CompositeResourceDefinitionSpecVersions> Versions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionStatusConditions
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

/// <summary>
/// The CompositeResourceClaimTypeRef is the type of composite resource claim
/// that Crossplane is currently reconciling for this definition. Its version
/// will eventually become consistent with the definition&apos;s referenceable
/// version. Note that clients may interact with any served type; this is
/// simply the type that Crossplane interacts with.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionStatusControllersCompositeResourceClaimType
{
    /// <summary>APIVersion of the type.</summary>
    [JsonPropertyName("apiVersion")]
    public required string ApiVersion { get; set; }

    /// <summary>Kind of the type.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }
}

/// <summary>
/// The CompositeResourceTypeRef is the type of composite resource that
/// Crossplane is currently reconciling for this definition. Its version will
/// eventually become consistent with the definition&apos;s referenceable version.
/// Note that clients may interact with any served type; this is simply the
/// type that Crossplane interacts with.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionStatusControllersCompositeResourceType
{
    /// <summary>APIVersion of the type.</summary>
    [JsonPropertyName("apiVersion")]
    public required string ApiVersion { get; set; }

    /// <summary>Kind of the type.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }
}

/// <summary>
/// Controllers represents the status of the controllers that power this
/// composite resource definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionStatusControllers
{
    /// <summary>
    /// The CompositeResourceClaimTypeRef is the type of composite resource claim
    /// that Crossplane is currently reconciling for this definition. Its version
    /// will eventually become consistent with the definition&apos;s referenceable
    /// version. Note that clients may interact with any served type; this is
    /// simply the type that Crossplane interacts with.
    /// </summary>
    [JsonPropertyName("compositeResourceClaimType")]
    public V2CompositeResourceDefinitionStatusControllersCompositeResourceClaimType? CompositeResourceClaimType { get; set; }

    /// <summary>
    /// The CompositeResourceTypeRef is the type of composite resource that
    /// Crossplane is currently reconciling for this definition. Its version will
    /// eventually become consistent with the definition&apos;s referenceable version.
    /// Note that clients may interact with any served type; this is simply the
    /// type that Crossplane interacts with.
    /// </summary>
    [JsonPropertyName("compositeResourceType")]
    public V2CompositeResourceDefinitionStatusControllersCompositeResourceType? CompositeResourceType { get; set; }
}

/// <summary>CompositeResourceDefinitionStatus shows the observed state of the definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2CompositeResourceDefinitionStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V2CompositeResourceDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Controllers represents the status of the controllers that power this
    /// composite resource definition.
    /// </summary>
    [JsonPropertyName("controllers")]
    public V2CompositeResourceDefinitionStatusControllers? Controllers { get; set; }
}

/// <summary>
/// A CompositeResourceDefinition defines the schema for a new custom Kubernetes
/// API.
/// 
/// Read the Crossplane documentation for
/// [more information about CustomResourceDefinitions](https://docs.crossplane.io/latest/composition/composite-resource-definitions/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2CompositeResourceDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V2CompositeResourceDefinitionSpec?>, IStatus<V2CompositeResourceDefinitionStatus?>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "CompositeResourceDefinition";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "compositeresourcedefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CompositeResourceDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CompositeResourceDefinitionSpec specifies the desired state of the definition.</summary>
    [JsonPropertyName("spec")]
    public V2CompositeResourceDefinitionSpec? Spec { get; set; }

    /// <summary>CompositeResourceDefinitionStatus shows the observed state of the definition.</summary>
    [JsonPropertyName("status")]
    public V2CompositeResourceDefinitionStatus? Status { get; set; }
}