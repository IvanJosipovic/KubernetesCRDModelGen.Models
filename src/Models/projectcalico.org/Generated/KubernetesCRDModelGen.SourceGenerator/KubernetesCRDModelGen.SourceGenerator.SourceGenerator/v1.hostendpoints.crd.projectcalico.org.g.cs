#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1HostEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1HostEndpoint>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "HostEndpointList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "hostendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HostEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1HostEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1HostEndpoint> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HostEndpointSpecPorts
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("port")]
    public required int Port { get; set; }

    [JsonPropertyName("protocol")]
    public required IntOrString Protocol { get; set; }
}

/// <summary>HostEndpointSpec contains the specification for a HostEndpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HostEndpointSpec
{
    /// <summary>
    /// The expected IP addresses (IPv4 and IPv6) of the endpoint.
    /// If &quot;InterfaceName&quot; is not present, Calico will look for an interface matching any
    /// of the IPs in the list and apply policy to that.
    /// Note:
    /// 	When using the selector match criteria in an ingress or egress security Policy
    /// 	or Profile, Calico converts the selector into a set of IP addresses. For host
    /// 	endpoints, the ExpectedIPs field is used for that purpose. (If only the interface
    /// 	name is specified, Calico does not learn the IPs of the interface for use in match
    /// 	criteria.)
    /// </summary>
    [JsonPropertyName("expectedIPs")]
    public IList<string>? ExpectedIPs { get; set; }

    /// <summary>
    /// Either &quot;*&quot;, or the name of a specific Linux interface to apply policy to; or empty.  &quot;*&quot;
    /// indicates that this HostEndpoint governs all traffic to, from or through the default
    /// network namespace of the host named by the &quot;Node&quot; field; entering and leaving that
    /// namespace via any interface, including those from/to non-host-networked local workloads.
    /// 
    /// If InterfaceName is not &quot;*&quot;, this HostEndpoint only governs traffic that enters or leaves
    /// the host through the specific interface named by InterfaceName, or - when InterfaceName
    /// is empty - through the specific interface that has one of the IPs in ExpectedIPs.
    /// Therefore, when InterfaceName is empty, at least one expected IP must be specified.  Only
    /// external interfaces (such as &quot;eth0&quot;) are supported here; it isn&apos;t possible for a
    /// HostEndpoint to protect traffic through a specific local workload interface.
    /// 
    /// Note: Only some kinds of policy are implemented for &quot;*&quot; HostEndpoints; initially just
    /// pre-DNAT policy.  Please check Calico documentation for the latest position.
    /// </summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>The node name identifying the Calico node instance.</summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary>Ports contains the endpoint&apos;s named ports, which may be referenced in security policy rules.</summary>
    [JsonPropertyName("ports")]
    public IList<V1HostEndpointSpecPorts>? Ports { get; set; }

    /// <summary>
    /// A list of identifiers of security Profile objects that apply to this endpoint. Each
    /// profile is applied in the order that they appear in this list.  Profile rules are applied
    /// after the selector-based security policy.
    /// </summary>
    [JsonPropertyName("profiles")]
    public IList<string>? Profiles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1HostEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1HostEndpointSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "HostEndpoint";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "hostendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HostEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HostEndpointSpec contains the specification for a HostEndpoint resource.</summary>
    [JsonPropertyName("spec")]
    public V1HostEndpointSpec? Spec { get; set; }
}