#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkservices.cnrm.cloud.google.com;
/// <summary>NetworkServicesLBRouteExtension is the Schema for the NetworkServicesLBRouteExtension API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkServicesLBRouteExtensionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkServicesLBRouteExtension>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkServicesLBRouteExtensionList";
    public const string KubeGroup = "networkservices.cnrm.cloud.google.com";
    public const string KubePluralName = "networkserviceslbrouteextensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkservices.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkServicesLBRouteExtensionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkServicesLBRouteExtension objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkServicesLBRouteExtension> Items { get; set; }
}

/// <summary>
/// Optional. The reference to the service that runs the extension.
/// 
/// To configure a callout extension, `service` must be a fully-qualified reference
/// to a [backend service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices)
/// in the format:
/// `https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService}`
/// or
/// `https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsExtensionsBackendServiceRef
{
    /// <summary>The value of an externally managed ComputeBackendService resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeBackendService resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeBackendService resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Optional. The reference to the WasmPlugin resource.
/// 
/// To configure a plugin extension, `service` must be a reference to a
/// [`WasmPlugin` resource](https://cloud.google.com/service-extensions/docs/reference/rest/v1beta1/projects.locations.wasmPlugins)
/// in the format:
/// `projects/{project}/locations/{location}/wasmPlugins/{plugin}`
/// or
/// `//networkservices.googleapis.com/projects/{project}/locations/{location}/wasmPlugins/{wasmPlugin}`.
/// 
/// Plugin extensions are currently supported for the `LBTrafficExtension`, the
/// `LBRouteExtension`, and the `LBEdgeExtension` resources.
/// 
/// Note: Only the `external` subfield is supported as the
/// `NetworkServicesWasmPlugin` resource is not yet supported in Config Connector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsExtensionsWasmPluginRef
{
    /// <summary>The name of the wasmplugin. Allowed value: The Google Cloud resource name of a `NetworkServicesWasmPlugin` resource (format: `projects/{{project}}/locations/{{location}}/wasmPlugins/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsExtensions
{
    /// <summary>
    /// Optional. The `:authority` header in the gRPC request sent from Envoy
    /// to the extension service.
    /// Required for Callout extensions.
    /// 
    /// This field is not supported for plugin extensions. Setting it results in
    /// a validation error.
    /// </summary>
    [JsonPropertyName("authority")]
    public string? Authority { get; set; }

    /// <summary>
    /// Optional. The reference to the service that runs the extension.
    /// 
    /// To configure a callout extension, `service` must be a fully-qualified reference
    /// to a [backend service](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices)
    /// in the format:
    /// `https://www.googleapis.com/compute/v1/projects/{project}/regions/{region}/backendServices/{backendService}`
    /// or
    /// `https://www.googleapis.com/compute/v1/projects/{project}/global/backendServices/{backendService}`.
    /// </summary>
    [JsonPropertyName("backendServiceRef")]
    public V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsExtensionsBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>
    /// Optional. Determines how the proxy behaves if the call to the extension
    /// fails or times out.
    /// 
    /// When set to `TRUE`, request or response processing continues without
    /// error. Any subsequent extensions in the extension chain are also
    /// executed. When set to `FALSE` or the default setting of `FALSE` is used,
    /// one of the following happens:
    /// 
    /// * If response headers have not been delivered to the downstream client,
    /// a generic 500 error is returned to the client. The error response can be
    /// tailored by configuring a custom error response in the load balancer.
    /// 
    /// * If response headers have been delivered, then the HTTP stream to the
    /// downstream client is reset.
    /// </summary>
    [JsonPropertyName("failOpen")]
    public bool? FailOpen { get; set; }

    /// <summary>Optional. List of the HTTP headers to forward to the extension (from the client or backend). If omitted, all headers are sent. Each element is a string indicating the header name.</summary>
    [JsonPropertyName("forwardHeaders")]
    public IList<string>? ForwardHeaders { get; set; }

    /// <summary>
    /// Optional. The metadata provided here is included as part of the
    /// `metadata_context` (of type `google.protobuf.Struct`) in the
    /// `ProcessingRequest` message sent to the extension server.
    /// 
    /// The metadata is available under the namespace
    /// `com.google.&lt;extension_type&gt;.&lt;resource_name&gt;.&lt;extension_chain_name&gt;.&lt;extension_name&gt;`.
    /// For example:
    /// `com.google.lb_traffic_extension.lbtrafficextension1.chain1.ext1`.
    /// 
    /// The following variables are supported in the metadata:
    /// 
    /// `{forwarding_rule_id}` - substituted with the forwarding rule&apos;s fully
    /// qualified resource name.
    /// 
    /// This field must not be set for plugin extensions. Setting it results in
    /// a validation error.
    /// 
    /// You can set metadata at either the resource level or the extension level.
    /// The extension level metadata is recommended because you can pass a
    /// different set of metadata through each extension to the backend.
    /// 
    /// This field is subject to following limitations:
    /// 
    /// * The total size of the metadata must be less than 1KiB.
    /// * The total number of keys in the metadata must be less than 16.
    /// * The length of each key must be less than 64 characters.
    /// * The length of each value must be less than 1024 characters.
    /// * All values must be strings.
    /// </summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>Required. The name for this extension. The name is logged as part of the HTTP request logs. The name must conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens, and can have a maximum length of 63 characters. Additionally, the first character must be a letter and the last a letter or a number.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Optional. A set of events during request or response processing for which
    /// this extension is called.
    /// 
    /// For the `LBTrafficExtension` resource, this field is required.
    /// 
    /// For the `LBRouteExtension` resource, this field is optional. If
    /// unspecified, `REQUEST_HEADERS` event is assumed as supported.
    /// 
    /// For the `LBEdgeExtension` resource, this field is required and must only
    /// contain `REQUEST_HEADERS` event.
    /// </summary>
    [JsonPropertyName("supportedEvents")]
    public IList<string>? SupportedEvents { get; set; }

    /// <summary>
    /// Optional. Specifies the timeout for each individual message on the
    /// stream. The timeout must be between `10`-`10000` milliseconds. Required
    /// for callout extensions.
    /// 
    /// This field is not supported for plugin extensions. Setting it results in
    /// a validation error.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>
    /// Optional. The reference to the WasmPlugin resource.
    /// 
    /// To configure a plugin extension, `service` must be a reference to a
    /// [`WasmPlugin` resource](https://cloud.google.com/service-extensions/docs/reference/rest/v1beta1/projects.locations.wasmPlugins)
    /// in the format:
    /// `projects/{project}/locations/{location}/wasmPlugins/{plugin}`
    /// or
    /// `//networkservices.googleapis.com/projects/{project}/locations/{location}/wasmPlugins/{wasmPlugin}`.
    /// 
    /// Plugin extensions are currently supported for the `LBTrafficExtension`, the
    /// `LBRouteExtension`, and the `LBEdgeExtension` resources.
    /// 
    /// Note: Only the `external` subfield is supported as the
    /// `NetworkServicesWasmPlugin` resource is not yet supported in Config Connector.
    /// </summary>
    [JsonPropertyName("wasmPluginRef")]
    public V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsExtensionsWasmPluginRef? WasmPluginRef { get; set; }
}

/// <summary>Required. Conditions under which this chain is invoked for a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsMatchCondition
{
    /// <summary>
    /// Required. A Common Expression Language (CEL) expression that is used to
    /// match requests for which the extension chain is executed.
    /// 
    /// For more information, see [CEL matcher language
    /// reference](https://cloud.google.com/service-extensions/docs/cel-matcher-language-reference).
    /// </summary>
    [JsonPropertyName("celExpression")]
    public required string CelExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChains
{
    /// <summary>Required. A set of extensions to execute for the matching request. At least one extension is required. Up to 3 extensions can be defined for each extension chain for `LBTrafficExtension` resource. `LBRouteExtension` and `LBEdgeExtension` chains are limited to 1 extension per extension chain.</summary>
    [JsonPropertyName("extensions")]
    public required IList<V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsExtensions> Extensions { get; set; }

    /// <summary>Required. Conditions under which this chain is invoked for a request.</summary>
    [JsonPropertyName("matchCondition")]
    public required V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChainsMatchCondition MatchCondition { get; set; }

    /// <summary>Required. The name for this extension chain. The name is logged as part of the HTTP request logs. The name must conform with RFC-1034, is restricted to lower-cased letters, numbers and hyphens, and can have a maximum length of 63 characters. Additionally, the first character must be a letter and the last a letter or a number.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ForwardingRuleRef defines the resource reference to ComputeForwardingRule, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecForwardingRuleRefs
{
    /// <summary>A reference to an externally managed ComputeForwardingRule resource. Should be in the format &quot;projects/{{projectID}}/global/forwardingRules/{{forwardingRuleID}}&quot; or &quot;projects/{{projectID}}/regions/{{region}}/forwardingRules/{{forwardingRuleID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeForwardingRule resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeForwardingRule resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>NetworkServicesLBRouteExtensionSpec defines the desired state of NetworkServicesLBRouteExtension</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionSpec
{
    /// <summary>Optional. A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. A set of ordered extension chains that contain the match conditions and extensions to execute. Match conditions for each extension chain are evaluated in sequence for a given request. The first extension chain that has a condition that matches the request is executed. Any subsequent extension chains do not execute. Limited to 5 extension chains per resource.</summary>
    [JsonPropertyName("extensionChains")]
    public required IList<V1alpha1NetworkServicesLBRouteExtensionSpecExtensionChains> ExtensionChains { get; set; }

    /// <summary>Required. A list of references to the forwarding rules to which this service extension is attached. At least one forwarding rule is required. Only one LBRouteExtension resource can be associated with a forwarding rule.</summary>
    [JsonPropertyName("forwardingRuleRefs")]
    public required IList<V1alpha1NetworkServicesLBRouteExtensionSpecForwardingRuleRefs> ForwardingRuleRefs { get; set; }

    /// <summary>Required. All backend services and forwarding rules referenced by this extension must share the same load balancing scheme. Supported values: INTERNAL_MANAGED, EXTERNAL_MANAGED.</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public required string LoadBalancingScheme { get; set; }

    /// <summary>The location that this resource belongs to.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. The metadata provided here is included as part of the metadata_context (of type google.protobuf.Struct) in the ProcessingRequest message sent to the extension server.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkServicesLBRouteExtensionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkServicesLBRouteExtension name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionStatusObservedState
{
    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkServicesLBRouteExtensionStatus defines the config connector machine state of NetworkServicesLBRouteExtension</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesLBRouteExtensionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkServicesLBRouteExtensionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkServicesLBRouteExtension resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkServicesLBRouteExtensionStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkServicesLBRouteExtension is the Schema for the NetworkServicesLBRouteExtension API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkServicesLBRouteExtension : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkServicesLBRouteExtensionSpec>, IStatus<V1alpha1NetworkServicesLBRouteExtensionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkServicesLBRouteExtension";
    public const string KubeGroup = "networkservices.cnrm.cloud.google.com";
    public const string KubePluralName = "networkserviceslbrouteextensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkservices.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkServicesLBRouteExtension";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkServicesLBRouteExtensionSpec defines the desired state of NetworkServicesLBRouteExtension</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkServicesLBRouteExtensionSpec Spec { get; set; }

    /// <summary>NetworkServicesLBRouteExtensionStatus defines the config connector machine state of NetworkServicesLBRouteExtension</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkServicesLBRouteExtensionStatus? Status { get; set; }
}