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
/// <summary>ComputeTargetTCPProxy is the Schema for the ComputeTargetTCPProxy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetTCPProxyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeTargetTCPProxy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetTCPProxyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargettcpproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeTargetTCPProxyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeTargetTCPProxy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeTargetTCPProxy> Items { get; set; }
}

/// <summary>A reference to the ComputeBackendService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetTCPProxySpecBackendServiceRef
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

/// <summary>ComputeTargetTCPProxySpec defines the desired state of ComputeTargetTCPProxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetTCPProxySpec
{
    /// <summary>A reference to the ComputeBackendService resource.</summary>
    [JsonPropertyName("backendServiceRef")]
    public required V1beta1ComputeTargetTCPProxySpecBackendServiceRef BackendServiceRef { get; set; }

    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The geographical location of the ComputeTargetTCPProxy. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Immutable. This field only applies when the forwarding rule that references this target proxy has a loadBalancingScheme set to INTERNAL_SELF_MANAGED.</summary>
    [JsonPropertyName("proxyBind")]
    public bool? ProxyBind { get; set; }

    /// <summary>Specifies the type of proxy header to append before sending data to the backend. Default value: &quot;NONE&quot; Possible values: [&quot;NONE&quot;, &quot;PROXY_V1&quot;].</summary>
    [JsonPropertyName("proxyHeader")]
    public string? ProxyHeader { get; set; }

    /// <summary>The ComputeTargetTCPProxy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetTCPProxyStatusConditions
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

/// <summary>ComputeTargetTCPProxyStatus defines the config connector machine state of ComputeTargetTCPProxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeTargetTCPProxyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeTargetTCPProxyStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A unique specifier for the ComputeTargetTCPProxy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("proxyId")]
    public long? ProxyId { get; set; }

    /// <summary>The SelfLink for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeTargetTCPProxy is the Schema for the ComputeTargetTCPProxy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeTargetTCPProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeTargetTCPProxySpec>, IStatus<V1beta1ComputeTargetTCPProxyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeTargetTCPProxy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computetargettcpproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeTargetTCPProxy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeTargetTCPProxySpec defines the desired state of ComputeTargetTCPProxy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeTargetTCPProxySpec Spec { get; set; }

    /// <summary>ComputeTargetTCPProxyStatus defines the config connector machine state of ComputeTargetTCPProxy</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeTargetTCPProxyStatus? Status { get; set; }
}