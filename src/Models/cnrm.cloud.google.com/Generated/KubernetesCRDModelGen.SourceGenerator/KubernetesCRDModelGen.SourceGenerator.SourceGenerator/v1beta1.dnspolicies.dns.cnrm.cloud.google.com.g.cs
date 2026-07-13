#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DNSPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DNSPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DNSPolicyList";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DNSPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DNSPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DNSPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSPolicySpecAlternativeNameServerConfigTargetNameServers
{
    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or &apos;default&apos; Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to &apos;private&apos;, Cloud DNS will always send queries through VPC for this target Possible values: [&quot;default&quot;, &quot;private&quot;].
    /// </summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address to forward to.</summary>
    [JsonPropertyName("ipv4Address")]
    public required string Ipv4Address { get; set; }
}

/// <summary>
/// Sets an alternative name server for the associated networks.
/// When specified, all DNS queries are forwarded to a name server that you choose.
/// Names such as .internal are not available when an alternative name server is specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSPolicySpecAlternativeNameServerConfig
{
    /// <summary>
    /// Sets an alternative name server for the associated networks. When specified,
    /// all DNS queries are forwarded to a name server that you choose. Names such as .internal
    /// are not available when an alternative name server is specified.
    /// </summary>
    [JsonPropertyName("targetNameServers")]
    public required IList<V1beta1DNSPolicySpecAlternativeNameServerConfigTargetNameServers> TargetNameServers { get; set; }
}

/// <summary>VPC network to bind to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSPolicySpecNetworksNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
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
public partial class V1beta1DNSPolicySpecNetworks
{
    /// <summary>VPC network to bind to.</summary>
    [JsonPropertyName("networkRef")]
    public required V1beta1DNSPolicySpecNetworksNetworkRef NetworkRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSPolicySpec
{
    /// <summary>
    /// Sets an alternative name server for the associated networks.
    /// When specified, all DNS queries are forwarded to a name server that you choose.
    /// Names such as .internal are not available when an alternative name server is specified.
    /// </summary>
    [JsonPropertyName("alternativeNameServerConfig")]
    public V1beta1DNSPolicySpecAlternativeNameServerConfig? AlternativeNameServerConfig { get; set; }

    /// <summary>A textual description field. Defaults to &apos;Managed by Config Connector&apos;.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Allows networks bound to this policy to receive DNS queries sent
    /// by VMs or applications over VPN connections. When enabled, a
    /// virtual IP address will be allocated from each of the sub-networks
    /// that are bound to this policy.
    /// </summary>
    [JsonPropertyName("enableInboundForwarding")]
    public bool? EnableInboundForwarding { get; set; }

    /// <summary>
    /// Controls whether logging is enabled for the networks bound to this policy.
    /// Defaults to no logging if not set.
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>List of network names specifying networks to which this policy is applied.</summary>
    [JsonPropertyName("networks")]
    public IList<V1beta1DNSPolicySpecNetworks>? Networks { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSPolicyStatusConditions
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
public partial class V1beta1DNSPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DNSPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DNSPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DNSPolicySpec?>, IStatus<V1beta1DNSPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DNSPolicy";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DNSPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1beta1DNSPolicySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1DNSPolicyStatus? Status { get; set; }
}