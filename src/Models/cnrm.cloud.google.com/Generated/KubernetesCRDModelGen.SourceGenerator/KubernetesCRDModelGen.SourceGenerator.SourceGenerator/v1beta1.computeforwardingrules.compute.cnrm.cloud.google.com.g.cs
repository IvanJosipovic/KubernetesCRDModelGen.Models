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
/// <summary>ComputeForwardingRule is the Schema for the compute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeForwardingRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeForwardingRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeForwardingRuleList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeforwardingrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeForwardingRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeForwardingRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeForwardingRule> Items { get; set; }
}

/// <summary>A ComputeBackendService to receive the matched traffic. This is used only for internal load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecBackendServiceRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecIpAddressAddressRef
{
    /// <summary>The ComputeAddress selflink in the form &quot;projects/{{project}}/regions/{{region}}/addresses/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// The IP address that this forwarding rule is serving on behalf of.
/// 
/// Addresses are restricted based on the forwarding rule&apos;s load
/// balancing scheme (EXTERNAL or INTERNAL) and scope (global or
/// regional).
/// 
/// When the load balancing scheme is EXTERNAL, for global forwarding
/// rules, the address must be a global IP, and for regional forwarding
/// rules, the address must live in the same region as the forwarding
/// rule. If this field is empty, an ephemeral IPv4 address from the
/// same scope (global or regional) will be assigned. A regional
/// forwarding rule supports IPv4 only. A global forwarding rule
/// supports either IPv4 or IPv6.
/// 
/// When the load balancing scheme is INTERNAL, this can only be an RFC
/// 1918 IP address belonging to the network/subnet configured for the
/// forwarding rule. By default, if this field is empty, an ephemeral
/// internal IP address will be automatically allocated from the IP
/// range of the subnet or network configured for this forwarding rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecIpAddress
{
    [JsonPropertyName("addressRef")]
    public V1beta1ComputeForwardingRuleSpecIpAddressAddressRef? AddressRef { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecMetadataFiltersFilterLabels
{
    /// <summary>Immutable. Name of the metadata label. The length must be between 1 and 1024 characters, inclusive.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Immutable. The value that the label must match. The value has a maximum length of 1024 characters.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecMetadataFilters
{
    /// <summary>
    /// Immutable. The list of label value pairs that must match labels in the
    /// provided metadata based on filterMatchCriteria
    /// 
    /// This list must not be empty and can have at the most 64 entries.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public required IList<V1beta1ComputeForwardingRuleSpecMetadataFiltersFilterLabels> FilterLabels { get; set; }

    /// <summary>
    /// Immutable. Specifies how individual filterLabel matches within the list of
    /// filterLabels contribute towards the overall metadataFilter match.
    /// 
    /// MATCH_ANY - At least one of the filterLabels must have a matching
    /// label in the provided metadata.
    /// MATCH_ALL - All filterLabels must have matching labels in the
    /// provided metadata. Possible values: [&quot;MATCH_ANY&quot;, &quot;MATCH_ALL&quot;].
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public required string FilterMatchCriteria { get; set; }
}

/// <summary>This field is not used for external load balancing. For internal load balancing, this field identifies the network that the load balanced IP should belong to for this forwarding rule. If this field is not specified, the default network will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecServiceDirectoryRegistrations
{
    /// <summary>Immutable. Service Directory namespace to register the forwarding rule under.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Immutable. Service Directory service to register the forwarding rule under.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Immutable. The subnetwork that the load balanced IP should belong to for this
/// forwarding rule. This field is only used for internal load
/// balancing.
/// 
/// If the network specified is in auto subnet mode, this field is
/// optional. However, if the network is in custom subnet mode, a
/// subnetwork must be specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form &quot;projects/{{project}}/regions/{{region}}/subnetworks/{{name}}&quot;, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A reference to a MemorystoreInstance resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetMemorystoreInstanceServiceAttachmentMemorystoreInstanceRef
{
    /// <summary>A reference to an externally managed MemorystoreInstance resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a MemorystoreInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a MemorystoreInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Target a serviceAttachment for a Memorystore for Valkey instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetMemorystoreInstanceServiceAttachment
{
    /// <summary>The connection type of the serviceAttachment. A memorystore instance has multiple serviceAttachments, each with a different connection type. Use connectionType to control which serviceAttachment to target. The empty value matches a serviceAttachment with an empty connectionType.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>A reference to a MemorystoreInstance resource.</summary>
    [JsonPropertyName("memorystoreInstanceRef")]
    public required V1beta1ComputeForwardingRuleSpecTargetMemorystoreInstanceServiceAttachmentMemorystoreInstanceRef MemorystoreInstanceRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetServiceAttachmentRef
{
    /// <summary>The ComputeServiceAttachment selflink in the form &quot;projects/{{project}}/regions/{{region}}/serviceAttachments/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetGRPCProxyRef
{
    /// <summary>The ComputeTargetGrpcProxy selflink in the form &quot;projects/{{project}}/global/targetGrpcProxies/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetGrpcProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetGrpcProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetHTTPProxyRef
{
    /// <summary>The ComputeTargetHTTPProxy selflink in the form &quot;projects/{{project}}/global/targetHttpProxies/{{name}}&quot; or &quot;projects/{{project}}/regions/{{region}}/targetHttpProxies/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetHTTPProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetHTTPProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetHTTPSProxyRef
{
    /// <summary>The ComputeTargetHTTPSProxy selflink in the form &quot;projects/{{project}}/global/targetHttpProxies/{{name}}&quot; or &quot;projects/{{project}}/regions/{{region}}/targetHttpProxies/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetHTTPSProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetHTTPSProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetSSLProxyRef
{
    /// <summary>The ComputeTargetSSLProxy selflink in the form &quot;projects/{{project}}/global/targetSslProxies/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetSSLProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetSSLProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetTCPProxyRef
{
    /// <summary>The ComputeTargetTCPProxy selflink in the form &quot;projects/{{project}}/global/targetTcpProxies/{{name}}&quot; or &quot;projects/{{project}}/regions/{{region}}/targetTcpProxies/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetTCPProxy` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetTCPProxy` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTargetTargetVPNGatewayRef
{
    /// <summary>The ComputeTargetVPNGateway selflink in the form &quot;projects/{{project}}/regions/{{region}}/targetVpnGateways/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeTargetVPNGateway` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeTargetVPNGateway` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The target resource to receive the matched traffic. The forwarded traffic must be of a type appropriate to the target object. For INTERNAL_SELF_MANAGED load balancing, only HTTP and HTTPS targets are valid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpecTarget
{
    [JsonPropertyName("googleAPIsBundle")]
    public string? GoogleAPIsBundle { get; set; }

    /// <summary>Target a serviceAttachment for a Memorystore for Valkey instance.</summary>
    [JsonPropertyName("memorystoreInstanceServiceAttachment")]
    public V1beta1ComputeForwardingRuleSpecTargetMemorystoreInstanceServiceAttachment? MemorystoreInstanceServiceAttachment { get; set; }

    [JsonPropertyName("serviceAttachmentRef")]
    public V1beta1ComputeForwardingRuleSpecTargetServiceAttachmentRef? ServiceAttachmentRef { get; set; }

    [JsonPropertyName("targetGRPCProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetGRPCProxyRef? TargetGRPCProxyRef { get; set; }

    [JsonPropertyName("targetHTTPProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetHTTPProxyRef? TargetHTTPProxyRef { get; set; }

    [JsonPropertyName("targetHTTPSProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetHTTPSProxyRef? TargetHTTPSProxyRef { get; set; }

    [JsonPropertyName("targetSSLProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetSSLProxyRef? TargetSSLProxyRef { get; set; }

    [JsonPropertyName("targetTCPProxyRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetTCPProxyRef? TargetTCPProxyRef { get; set; }

    [JsonPropertyName("targetVPNGatewayRef")]
    public V1beta1ComputeForwardingRuleSpecTargetTargetVPNGatewayRef? TargetVPNGatewayRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleSpec
{
    /// <summary>
    /// Immutable. This field can only be used:
    /// * If &apos;IPProtocol&apos; is one of TCP, UDP, or SCTP.
    /// * By internal TCP/UDP load balancers, backend service-based network load
    /// balancers, and internal and external protocol forwarding.
    /// 
    /// This option should be set to TRUE when the Forwarding Rule
    /// IPProtocol is set to L3_DEFAULT.
    /// 
    /// Set this field to true to allow packets addressed to any port or packets
    /// lacking destination port information (for example, UDP fragments after the
    /// first fragment) to be forwarded to the backends configured with this
    /// forwarding rule.
    /// 
    /// The &apos;ports&apos;, &apos;port_range&apos;, and
    /// &apos;allPorts&apos; fields are mutually exclusive.
    /// </summary>
    [JsonPropertyName("allPorts")]
    public bool? AllPorts { get; set; }

    /// <summary>
    /// This field is used along with the &apos;backend_service&apos; field for
    /// internal load balancing or with the &apos;target&apos; field for internal
    /// TargetInstance.
    /// 
    /// If the field is set to &apos;TRUE&apos;, clients can access ILB from all
    /// regions.
    /// 
    /// Otherwise only allows access from clients in the same region as the
    /// internal load balancer.
    /// </summary>
    [JsonPropertyName("allowGlobalAccess")]
    public bool? AllowGlobalAccess { get; set; }

    /// <summary>This is used in PSC consumer ForwardingRule to control whether the PSC endpoint can be accessed from another region.</summary>
    [JsonPropertyName("allowPscGlobalAccess")]
    public bool? AllowPscGlobalAccess { get; set; }

    /// <summary>A ComputeBackendService to receive the matched traffic. This is used only for internal load balancing.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta1ComputeForwardingRuleSpecBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The IP address that this forwarding rule is serving on behalf of.
    /// 
    /// Addresses are restricted based on the forwarding rule&apos;s load
    /// balancing scheme (EXTERNAL or INTERNAL) and scope (global or
    /// regional).
    /// 
    /// When the load balancing scheme is EXTERNAL, for global forwarding
    /// rules, the address must be a global IP, and for regional forwarding
    /// rules, the address must live in the same region as the forwarding
    /// rule. If this field is empty, an ephemeral IPv4 address from the
    /// same scope (global or regional) will be assigned. A regional
    /// forwarding rule supports IPv4 only. A global forwarding rule
    /// supports either IPv4 or IPv6.
    /// 
    /// When the load balancing scheme is INTERNAL, this can only be an RFC
    /// 1918 IP address belonging to the network/subnet configured for the
    /// forwarding rule. By default, if this field is empty, an ephemeral
    /// internal IP address will be automatically allocated from the IP
    /// range of the subnet or network configured for this forwarding rule.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public V1beta1ComputeForwardingRuleSpecIpAddress? IpAddress { get; set; }

    /// <summary>
    /// Immutable. The IP protocol to which this rule applies.
    /// 
    /// For protocol forwarding, valid
    /// options are &apos;TCP&apos;, &apos;UDP&apos;, &apos;ESP&apos;,
    /// &apos;AH&apos;, &apos;SCTP&apos;, &apos;ICMP&apos; and
    /// &apos;L3_DEFAULT&apos;.
    /// 
    /// The valid IP protocols are different for different load balancing products
    /// as described in [Load balancing
    /// features](https://cloud.google.com/load-balancing/docs/features#protocols_from_the_load_balancer_to_the_backends).
    /// 
    /// A Forwarding Rule with protocol L3_DEFAULT can attach with target instance or
    /// backend service with UNSPECIFIED protocol.
    /// A forwarding rule with &quot;L3_DEFAULT&quot; IPProtocal cannot be attached to a backend service with TCP or UDP. Possible values: [&quot;TCP&quot;, &quot;UDP&quot;, &quot;ESP&quot;, &quot;AH&quot;, &quot;SCTP&quot;, &quot;ICMP&quot;, &quot;L3_DEFAULT&quot;].
    /// </summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>
    /// Immutable. The IP address version that will be used by this forwarding rule.
    /// Valid options are IPV4 and IPV6.
    /// 
    /// If not set, the IPv4 address will be used by default. Possible values: [&quot;IPV4&quot;, &quot;IPV6&quot;].
    /// </summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>
    /// Immutable. Indicates whether or not this load balancer can be used as a collector for
    /// packet mirroring. To prevent mirroring loops, instances behind this
    /// load balancer will not have their traffic mirrored even if a
    /// &apos;PacketMirroring&apos; rule applies to them.
    /// 
    /// This can only be set to true for load balancers that have their
    /// &apos;loadBalancingScheme&apos; set to &apos;INTERNAL&apos;.
    /// </summary>
    [JsonPropertyName("isMirroringCollector")]
    public bool? IsMirroringCollector { get; set; }

    /// <summary>
    /// Immutable. Specifies the forwarding rule type.
    /// 
    /// Must set to empty for private service connect forwarding rule. For more information about forwarding rules, refer to
    /// [Forwarding rule concepts](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts). Default value: &quot;EXTERNAL&quot; Possible values: [&quot;EXTERNAL&quot;, &quot;EXTERNAL_MANAGED&quot;, &quot;INTERNAL&quot;, &quot;INTERNAL_MANAGED&quot;, &quot; &quot;].
    /// </summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>Location represents the geographical location of the ComputeForwardingRule. Specify a region name or &quot;global&quot; for global resources. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// Immutable. Opaque filter criteria used by Loadbalancer to restrict routing
    /// configuration to a limited set xDS compliant clients. In their xDS
    /// requests to Loadbalancer, xDS clients present node metadata. If a
    /// match takes place, the relevant routing configuration is made available
    /// to those proxies.
    /// 
    /// For each metadataFilter in this list, if its filterMatchCriteria is set
    /// to MATCH_ANY, at least one of the filterLabels must match the
    /// corresponding label provided in the metadata. If its filterMatchCriteria
    /// is set to MATCH_ALL, then all of its filterLabels must match with
    /// corresponding labels in the provided metadata.
    /// 
    /// metadataFilters specified here can be overridden by those specified in
    /// the UrlMap that this ForwardingRule references.
    /// 
    /// metadataFilters only applies to Loadbalancers that have their
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta1ComputeForwardingRuleSpecMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>This field is not used for external load balancing. For internal load balancing, this field identifies the network that the load balanced IP should belong to for this forwarding rule. If this field is not specified, the default network will be used.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeForwardingRuleSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>
    /// Immutable. This signifies the networking tier used for configuring
    /// this load balancer and can only take the following values:
    /// &apos;PREMIUM&apos;, &apos;STANDARD&apos;.
    /// 
    /// For regional ForwardingRule, the valid values are &apos;PREMIUM&apos; and
    /// &apos;STANDARD&apos;. For GlobalForwardingRule, the valid value is
    /// &apos;PREMIUM&apos;.
    /// 
    /// If this field is not specified, it is assumed to be &apos;PREMIUM&apos;.
    /// If &apos;IPAddress&apos; is specified, this value must be equal to the
    /// networkTier of the Address. Possible values: [&quot;PREMIUM&quot;, &quot;STANDARD&quot;].
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>Immutable. This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.</summary>
    [JsonPropertyName("noAutomateDnsZone")]
    public bool? NoAutomateDnsZone { get; set; }

    /// <summary>
    /// Immutable. This field can only be used:
    /// 
    /// * If &apos;IPProtocol&apos; is one of TCP, UDP, or SCTP.
    /// * By backend service-based network load balancers, target pool-based
    /// network load balancers, internal proxy load balancers, external proxy load
    /// balancers, Traffic Director, external protocol forwarding, and Classic VPN.
    /// Some products have restrictions on what ports can be used. See
    /// [port specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#port_specifications)
    /// for details.
    /// 
    /// Only packets addressed to ports in the specified range will be forwarded to
    /// the backends configured with this forwarding rule.
    /// 
    /// The &apos;ports&apos; and &apos;port_range&apos; fields are mutually exclusive.
    /// 
    /// For external forwarding rules, two or more forwarding rules cannot use the
    /// same &apos;[IPAddress, IPProtocol]&apos; pair, and cannot have
    /// overlapping &apos;portRange&apos;s.
    /// 
    /// For internal forwarding rules within the same VPC network, two or more
    /// forwarding rules cannot use the same &apos;[IPAddress, IPProtocol]&apos;
    /// pair, and cannot have overlapping &apos;portRange&apos;s.
    /// </summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }

    /// <summary>
    /// Immutable. This field can only be used:
    /// 
    /// * If &apos;IPProtocol&apos; is one of TCP, UDP, or SCTP.
    /// * By internal TCP/UDP load balancers, backend service-based network load
    /// balancers, internal protocol forwarding and when protocol is not L3_DEFAULT.
    /// 
    /// You can specify a list of up to five ports by number, separated by commas.
    /// The ports can be contiguous or discontiguous. Only packets addressed to
    /// these ports will be forwarded to the backends configured with this
    /// forwarding rule.
    /// 
    /// For external forwarding rules, two or more forwarding rules cannot use the
    /// same &apos;[IPAddress, IPProtocol]&apos; pair, and cannot share any values
    /// defined in &apos;ports&apos;.
    /// 
    /// For internal forwarding rules within the same VPC network, two or more
    /// forwarding rules cannot use the same &apos;[IPAddress, IPProtocol]&apos;
    /// pair, and cannot share any values defined in &apos;ports&apos;.
    /// 
    /// The &apos;ports&apos; and &apos;port_range&apos; fields are mutually exclusive.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Immutable. Service Directory resources to register this forwarding rule with.
    /// 
    /// Currently, only supports a single Service Directory resource.
    /// </summary>
    [JsonPropertyName("serviceDirectoryRegistrations")]
    public IList<V1beta1ComputeForwardingRuleSpecServiceDirectoryRegistrations>? ServiceDirectoryRegistrations { get; set; }

    /// <summary>
    /// Immutable. An optional prefix to the service name for this Forwarding Rule.
    /// If specified, will be the first label of the fully qualified service
    /// name.
    /// 
    /// The label must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the label must be 1-63 characters long and match the
    /// regular expression &apos;[a-z]([-a-z0-9]*[a-z0-9])?&apos; which means the first
    /// character must be a lowercase letter, and all following characters
    /// must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// 
    /// This field is only used for INTERNAL load balancing.
    /// </summary>
    [JsonPropertyName("serviceLabel")]
    public string? ServiceLabel { get; set; }

    /// <summary>Immutable. If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).</summary>
    [JsonPropertyName("sourceIpRanges")]
    public IList<string>? SourceIpRanges { get; set; }

    /// <summary>
    /// Immutable. The subnetwork that the load balanced IP should belong to for this
    /// forwarding rule. This field is only used for internal load
    /// balancing.
    /// 
    /// If the network specified is in auto subnet mode, this field is
    /// optional. However, if the network is in custom subnet mode, a
    /// subnetwork must be specified.
    /// </summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeForwardingRuleSpecSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>The target resource to receive the matched traffic. The forwarded traffic must be of a type appropriate to the target object. For INTERNAL_SELF_MANAGED load balancing, only HTTP and HTTPS targets are valid.</summary>
    [JsonPropertyName("target")]
    public V1beta1ComputeForwardingRuleSpecTarget? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeForwardingRuleStatusConditions
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
public partial class V1beta1ComputeForwardingRuleStatus
{
    /// <summary>[Output Only] The URL for the corresponding base Forwarding Rule. By base Forwarding Rule, we mean the Forwarding Rule that has the same IP address, protocol, and port settings with the current Forwarding Rule, but without sourceIPRanges specified. Always empty if the current Forwarding Rule does not have sourceIPRanges specified.</summary>
    [JsonPropertyName("baseForwardingRule")]
    public string? BaseForwardingRule { get; set; }

    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeForwardingRuleStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A unique Config Connector specifier for the resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>The PSC connection id of the PSC Forwarding Rule.</summary>
    [JsonPropertyName("pscConnectionId")]
    public string? PscConnectionId { get; set; }

    /// <summary>The PSC connection status of the PSC Forwarding Rule. Possible values: &apos;STATUS_UNSPECIFIED&apos;, &apos;PENDING&apos;, &apos;ACCEPTED&apos;, &apos;REJECTED&apos;, &apos;CLOSED&apos;.</summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }

    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The internal fully qualified service name for this Forwarding Rule. This field is only used for INTERNAL load balancing.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The target resource to receive the matched traffic.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>ComputeForwardingRule is the Schema for the compute API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeForwardingRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeForwardingRuleSpec?>, IStatus<V1beta1ComputeForwardingRuleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeForwardingRule";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeforwardingrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeForwardingRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1beta1ComputeForwardingRuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1ComputeForwardingRuleStatus? Status { get; set; }
}