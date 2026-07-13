#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetHTTPProxyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeTargetHTTPProxy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetHTTPProxyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargethttpproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeTargetHTTPProxyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeTargetHTTPProxy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeTargetHTTPProxy> Items { get; set; }
}

/// <summary>
/// A reference to the ComputeURLMap resource that defines the mapping
/// from URL to the BackendService.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPProxySpecUrlMapRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeURLMap` resource.</summary>
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
public partial class V1beta1ComputeTargetHTTPProxySpec
{
    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Immutable. Specifies how long to keep a connection open, after completing a response,
    /// while there is no matching traffic (in seconds). If an HTTP keepalive is
    /// not specified, a default value (610 seconds) will be used. For Global
    /// external HTTP(S) load balancer, the minimum allowed value is 5 seconds and
    /// the maximum allowed value is 1200 seconds. For Global external HTTP(S)
    /// load balancer (classic), this option is not available publicly.
    /// </summary>
    [JsonPropertyName("httpKeepAliveTimeoutSec")]
    public int? HttpKeepAliveTimeoutSec { get; set; }

    /// <summary>Location represents the geographical location of the ComputeTargetHTTPProxy. Specify a region name or &quot;global&quot; for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// Immutable. This field only applies when the forwarding rule that references
    /// this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    [JsonPropertyName("proxyBind")]
    public bool? ProxyBind { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// A reference to the ComputeURLMap resource that defines the mapping
    /// from URL to the BackendService.
    /// </summary>
    [JsonPropertyName("urlMapRef")]
    public required V1beta1ComputeTargetHTTPProxySpecUrlMapRef UrlMapRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPProxyStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetHTTPProxyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeTargetHTTPProxyStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("proxyId")]
    public int? ProxyId { get; set; }

    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetHTTPProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeTargetHTTPProxySpec>, IStatus<V1beta1ComputeTargetHTTPProxyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetHTTPProxy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargethttpproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeTargetHTTPProxy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1ComputeTargetHTTPProxySpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1ComputeTargetHTTPProxyStatus? Status { get; set; }
}