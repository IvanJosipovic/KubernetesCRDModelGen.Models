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
public partial class V1beta1DNSManagedZoneList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DNSManagedZone>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DNSManagedZoneList";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnsmanagedzones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DNSManagedZoneList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DNSManagedZone objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DNSManagedZone> Items { get; set; }
}

/// <summary>Cloud logging configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public required bool EnableLogging { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecDnssecConfigDefaultKeySpecs
{
    /// <summary>String mnemonic specifying the DNSSEC algorithm of this key Possible values: [&quot;ecdsap256sha256&quot;, &quot;ecdsap384sha384&quot;, &quot;rsasha1&quot;, &quot;rsasha256&quot;, &quot;rsasha512&quot;].</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits.</summary>
    [JsonPropertyName("keyLength")]
    public int? KeyLength { get; set; }

    /// <summary>
    /// Specifies whether this is a key signing key (KSK) or a zone
    /// signing key (ZSK). Key signing keys have the Secure Entry
    /// Point flag set and, when active, will only be used to sign
    /// resource record sets of type DNSKEY. Zone signing keys do
    /// not have the Secure Entry Point flag set and will be used
    /// to sign all other types of resource record sets. Possible values: [&quot;keySigning&quot;, &quot;zoneSigning&quot;].
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>DNSSEC configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecDnssecConfig
{
    /// <summary>
    /// Specifies parameters that will be used for generating initial DnsKeys
    /// for this ManagedZone. If you provide a spec for keySigning or zoneSigning,
    /// you must also provide one for the other.
    /// default_key_specs can only be updated when the state is &apos;off&apos;.
    /// </summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta1DNSManagedZoneSpecDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is &apos;off&apos;. Possible values: [&quot;nsec&quot;, &quot;nsec3&quot;].
    /// </summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>Specifies whether DNSSEC is enabled, and what mode it is in Possible values: [&quot;off&quot;, &quot;on&quot;, &quot;transfer&quot;].</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecForwardingConfigTargetNameServers
{
    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or &apos;default&apos; Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to &apos;private&apos;, Cloud DNS will always send queries through VPC for this target Possible values: [&quot;default&quot;, &quot;private&quot;].
    /// </summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public required string Ipv4Address { get; set; }
}

/// <summary>
/// The presence for this field indicates that outbound forwarding is enabled
/// for this zone. The value of this field contains the set of destinations
/// to forward to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecForwardingConfig
{
    /// <summary>
    /// List of target name servers to forward to. Cloud DNS will
    /// select the best available name server if more than
    /// one target is given.
    /// </summary>
    [JsonPropertyName("targetNameServers")]
    public required IList<V1beta1DNSManagedZoneSpecForwardingConfigTargetNameServers> TargetNameServers { get; set; }
}

/// <summary>VPC network to forward queries to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPeeringConfigTargetNetworkNetworkRef
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

/// <summary>The network with which to peer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPeeringConfigTargetNetwork
{
    /// <summary>VPC network to forward queries to.</summary>
    [JsonPropertyName("networkRef")]
    public required V1beta1DNSManagedZoneSpecPeeringConfigTargetNetworkNetworkRef NetworkRef { get; set; }
}

/// <summary>
/// The presence of this field indicates that DNS Peering is enabled for this
/// zone. The value of this field contains the network to peer with.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPeeringConfig
{
    /// <summary>The network with which to peer.</summary>
    [JsonPropertyName("targetNetwork")]
    public required V1beta1DNSManagedZoneSpecPeeringConfigTargetNetwork TargetNetwork { get; set; }
}

/// <summary>
/// The resource name of the cluster to bind this ManagedZone to.
/// This should be specified in the format like
/// &apos;projects/*/locations/*/clusters/*&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClustersGkeClusterNameRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ContainerCluster` resource.</summary>
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
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClusters
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// &apos;projects/*/locations/*/clusters/*&apos;.
    /// </summary>
    [JsonPropertyName("gkeClusterNameRef")]
    public required V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClustersGkeClusterNameRef GkeClusterNameRef { get; set; }
}

/// <summary>VPC network to bind to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworksNetworkRef
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
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworks
{
    /// <summary>VPC network to bind to.</summary>
    [JsonPropertyName("networkRef")]
    public required V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworksNetworkRef NetworkRef { get; set; }
}

/// <summary>
/// For privately visible zones, the set of Virtual Private Cloud
/// resources that the zone is visible from. At least one of &apos;gke_clusters&apos; or &apos;networks&apos; must be specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecPrivateVisibilityConfig
{
    /// <summary>The list of Google Kubernetes Engine clusters that can see this zone.</summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta1DNSManagedZoneSpecPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    [JsonPropertyName("networks")]
    public IList<V1beta1DNSManagedZoneSpecPrivateVisibilityConfigNetworks>? Networks { get; set; }
}

/// <summary>The namespace associated with the zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecServiceDirectoryConfigNamespace
{
    /// <summary>
    /// The fully qualified or partial URL of the service directory namespace that should be
    /// associated with the zone. This should be formatted like
    /// &apos;https://servicedirectory.googleapis.com/v1/projects/{project}/locations/{location}/namespaces/{namespace_id}&apos;
    /// or simply &apos;projects/{project}/locations/{location}/namespaces/{namespace_id}&apos;
    /// Ignored for &apos;public&apos; visibility zones.
    /// </summary>
    [JsonPropertyName("namespaceUrl")]
    public required string NamespaceUrl { get; set; }
}

/// <summary>Immutable. The presence of this field indicates that this zone is backed by Service Directory. The value of this field contains information related to the namespace associated with the zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpecServiceDirectoryConfig
{
    /// <summary>The namespace associated with the zone.</summary>
    [JsonPropertyName("namespace")]
    public required V1beta1DNSManagedZoneSpecServiceDirectoryConfigNamespace Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneSpec
{
    /// <summary>Cloud logging configuration.</summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public V1beta1DNSManagedZoneSpecCloudLoggingConfig? CloudLoggingConfig { get; set; }

    /// <summary>A textual description field. Defaults to &apos;Managed by Config Connector&apos;.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The DNS name of this managed zone, for instance &quot;example.com.&quot;.</summary>
    [JsonPropertyName("dnsName")]
    public required string DnsName { get; set; }

    /// <summary>DNSSEC configuration.</summary>
    [JsonPropertyName("dnssecConfig")]
    public V1beta1DNSManagedZoneSpecDnssecConfig? DnssecConfig { get; set; }

    /// <summary>
    /// The presence for this field indicates that outbound forwarding is enabled
    /// for this zone. The value of this field contains the set of destinations
    /// to forward to.
    /// </summary>
    [JsonPropertyName("forwardingConfig")]
    public V1beta1DNSManagedZoneSpecForwardingConfig? ForwardingConfig { get; set; }

    /// <summary>
    /// The presence of this field indicates that DNS Peering is enabled for this
    /// zone. The value of this field contains the network to peer with.
    /// </summary>
    [JsonPropertyName("peeringConfig")]
    public V1beta1DNSManagedZoneSpecPeeringConfig? PeeringConfig { get; set; }

    /// <summary>
    /// For privately visible zones, the set of Virtual Private Cloud
    /// resources that the zone is visible from. At least one of &apos;gke_clusters&apos; or &apos;networks&apos; must be specified.
    /// </summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public V1beta1DNSManagedZoneSpecPrivateVisibilityConfig? PrivateVisibilityConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Immutable. Specifies if this is a managed reverse lookup zone. If true, Cloud DNS will resolve reverse
    /// lookup queries using automatically configured records for VPC resources. This only applies
    /// to networks listed under &apos;private_visibility_config&apos;.
    /// </summary>
    [JsonPropertyName("reverseLookup")]
    public bool? ReverseLookup { get; set; }

    /// <summary>Immutable. The presence of this field indicates that this zone is backed by Service Directory. The value of this field contains information related to the namespace associated with the zone.</summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1DNSManagedZoneSpecServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Immutable. The zone&apos;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources. Default value: &quot;public&quot; Possible values: [&quot;private&quot;, &quot;public&quot;].
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DNSManagedZoneStatusConditions
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
public partial class V1beta1DNSManagedZoneStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DNSManagedZoneStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>Unique identifier for the resource; defined by the server.</summary>
    [JsonPropertyName("managedZoneId")]
    public int? ManagedZoneId { get; set; }

    /// <summary>
    /// Delegate your managed_zone to these virtual name servers;
    /// defined by the server.
    /// </summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DNSManagedZone : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DNSManagedZoneSpec>, IStatus<V1beta1DNSManagedZoneStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DNSManagedZone";
    public const string KubeGroup = "dns.cnrm.cloud.google.com";
    public const string KubePluralName = "dnsmanagedzones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DNSManagedZone";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1DNSManagedZoneSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1DNSManagedZoneStatus? Status { get; set; }
}