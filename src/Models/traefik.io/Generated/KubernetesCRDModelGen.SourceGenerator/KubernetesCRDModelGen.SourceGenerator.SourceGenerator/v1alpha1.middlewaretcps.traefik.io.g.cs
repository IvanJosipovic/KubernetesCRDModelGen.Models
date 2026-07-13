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
/// <summary>
/// MiddlewareTCP is the CRD implementation of a Traefik TCP middleware.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/tcp/middlewares/overview/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MiddlewareTCPList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MiddlewareTCP>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MiddlewareTCPList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "middlewaretcps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MiddlewareTCPList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MiddlewareTCP objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MiddlewareTCP> Items { get; set; }
}

/// <summary>InFlightConn defines the InFlightConn middleware configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpecInFlightConn
{
    /// <summary>
    /// Amount defines the maximum amount of allowed simultaneous connections.
    /// The middleware closes the connection if there are already amount connections opened.
    /// </summary>
    [JsonPropertyName("amount")]
    public long? Amount { get; set; }
}

/// <summary>
/// IPAllowList defines the IPAllowList middleware configuration.
/// This middleware accepts/refuses connections based on the client IP.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/tcp/middlewares/ipallowlist/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpecIpAllowList
{
    /// <summary>SourceRange defines the allowed IPs (or ranges of allowed IPs by using CIDR notation).</summary>
    [JsonPropertyName("sourceRange")]
    public IList<string>? SourceRange { get; set; }
}

/// <summary>
/// IPWhiteList defines the IPWhiteList middleware configuration.
/// This middleware accepts/refuses connections based on the client IP.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/tcp/middlewares/ipwhitelist/
/// 
/// Deprecated: please use IPAllowList instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpecIpWhiteList
{
    /// <summary>SourceRange defines the allowed IPs (or ranges of allowed IPs by using CIDR notation).</summary>
    [JsonPropertyName("sourceRange")]
    public IList<string>? SourceRange { get; set; }
}

/// <summary>MiddlewareTCPSpec defines the desired state of a MiddlewareTCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MiddlewareTCPSpec
{
    /// <summary>InFlightConn defines the InFlightConn middleware configuration.</summary>
    [JsonPropertyName("inFlightConn")]
    public V1alpha1MiddlewareTCPSpecInFlightConn? InFlightConn { get; set; }

    /// <summary>
    /// IPAllowList defines the IPAllowList middleware configuration.
    /// This middleware accepts/refuses connections based on the client IP.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/tcp/middlewares/ipallowlist/
    /// </summary>
    [JsonPropertyName("ipAllowList")]
    public V1alpha1MiddlewareTCPSpecIpAllowList? IpAllowList { get; set; }

    /// <summary>
    /// IPWhiteList defines the IPWhiteList middleware configuration.
    /// This middleware accepts/refuses connections based on the client IP.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/tcp/middlewares/ipwhitelist/
    /// 
    /// Deprecated: please use IPAllowList instead.
    /// </summary>
    [JsonPropertyName("ipWhiteList")]
    public V1alpha1MiddlewareTCPSpecIpWhiteList? IpWhiteList { get; set; }
}

/// <summary>
/// MiddlewareTCP is the CRD implementation of a Traefik TCP middleware.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/tcp/middlewares/overview/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MiddlewareTCP : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MiddlewareTCPSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MiddlewareTCP";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "middlewaretcps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MiddlewareTCP";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MiddlewareTCPSpec defines the desired state of a MiddlewareTCP.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MiddlewareTCPSpec Spec { get; set; }
}