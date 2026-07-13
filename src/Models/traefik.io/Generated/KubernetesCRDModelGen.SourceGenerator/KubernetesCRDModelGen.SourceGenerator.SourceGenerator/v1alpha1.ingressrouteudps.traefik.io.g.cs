#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>IngressRouteUDP is a CRD implementation of a Traefik UDP Router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IngressRouteUDPList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IngressRouteUDP>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IngressRouteUDPList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "ingressrouteudps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IngressRouteUDPList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1IngressRouteUDP objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1IngressRouteUDP> Items { get; set; }
}

/// <summary>ServiceUDP defines an upstream UDP service to proxy traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteUDPSpecRoutesServices
{
    /// <summary>Name defines the name of the referenced Kubernetes Service.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public required IntOrString Port { get; set; }

    /// <summary>Weight defines the weight used when balancing requests between multiple Kubernetes Service.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>RouteUDP holds the UDP route configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteUDPSpecRoutes
{
    /// <summary>Services defines the list of UDP services.</summary>
    [JsonPropertyName("services")]
    public IList<V1alpha1IngressRouteUDPSpecRoutesServices>? Services { get; set; }
}

/// <summary>IngressRouteUDPSpec defines the desired state of a IngressRouteUDP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IngressRouteUDPSpec
{
    /// <summary>
    /// EntryPoints defines the list of entry point names to bind to.
    /// Entry points have to be configured in the static configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/install-configuration/entrypoints/
    /// Default: all.
    /// </summary>
    [JsonPropertyName("entryPoints")]
    public IList<string>? EntryPoints { get; set; }

    /// <summary>IngressClassName defines the name of the IngressClass cluster resource.</summary>
    [JsonPropertyName("ingressClassName")]
    public string? IngressClassName { get; set; }

    /// <summary>Routes defines the list of routes.</summary>
    [JsonPropertyName("routes")]
    public required IList<V1alpha1IngressRouteUDPSpecRoutes> Routes { get; set; }
}

/// <summary>IngressRouteUDP is a CRD implementation of a Traefik UDP Router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IngressRouteUDP : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IngressRouteUDPSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IngressRouteUDP";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "ingressrouteudps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IngressRouteUDP";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IngressRouteUDPSpec defines the desired state of a IngressRouteUDP.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1IngressRouteUDPSpec Spec { get; set; }
}