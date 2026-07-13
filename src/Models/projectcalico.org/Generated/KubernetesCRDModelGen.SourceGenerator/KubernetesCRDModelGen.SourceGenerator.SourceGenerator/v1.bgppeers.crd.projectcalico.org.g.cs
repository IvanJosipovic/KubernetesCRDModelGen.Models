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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPPeerList : IKubernetesObject<V1ListMeta>, IItems<V1BGPPeer>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPPeerList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgppeers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPPeerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1BGPPeer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1BGPPeer> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPPeerSpecNextHopModeEnum>))]
public enum V1BGPPeerSpecNextHopModeEnum
{
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto,
    [EnumMember(Value = "Self"), JsonStringEnumMemberName("Self")]
    Self,
    [EnumMember(Value = "Keep"), JsonStringEnumMemberName("Keep")]
    Keep
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPPeerSpecPasswordSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPPeerSpecPassword
{
    [JsonPropertyName("secretKeyRef")]
    public V1BGPPeerSpecPasswordSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPPeerSpecSourceAddressEnum>))]
public enum V1BGPPeerSpecSourceAddressEnum
{
    [EnumMember(Value = "UseNodeIP"), JsonStringEnumMemberName("UseNodeIP")]
    UseNodeIP,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPPeerSpec
{
    [JsonPropertyName("asNumber")]
    public int? AsNumber { get; set; }

    [JsonPropertyName("filters")]
    public IList<string>? Filters { get; set; }

    [JsonPropertyName("keepOriginalNextHop")]
    public bool? KeepOriginalNextHop { get; set; }

    [JsonPropertyName("keepaliveTime")]
    public string? KeepaliveTime { get; set; }

    [JsonPropertyName("localASNumber")]
    public int? LocalASNumber { get; set; }

    [JsonPropertyName("localWorkloadSelector")]
    public string? LocalWorkloadSelector { get; set; }

    [JsonPropertyName("maxRestartTime")]
    public string? MaxRestartTime { get; set; }

    [JsonPropertyName("nextHopMode")]
    public V1BGPPeerSpecNextHopModeEnum? NextHopMode { get; set; }

    [JsonPropertyName("node")]
    public string? Node { get; set; }

    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    [JsonPropertyName("numAllowedLocalASNumbers")]
    public int? NumAllowedLocalASNumbers { get; set; }

    [JsonPropertyName("password")]
    public V1BGPPeerSpecPassword? Password { get; set; }

    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    [JsonPropertyName("peerSelector")]
    public string? PeerSelector { get; set; }

    [JsonPropertyName("reachableBy")]
    public string? ReachableBy { get; set; }

    [JsonPropertyName("reversePeering")]
    public string? ReversePeering { get; set; }

    [JsonPropertyName("sourceAddress")]
    public V1BGPPeerSpecSourceAddressEnum? SourceAddress { get; set; }

    [JsonPropertyName("ttlSecurity")]
    public int? TtlSecurity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPPeer : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPPeerSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPPeer";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgppeers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPPeer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1BGPPeerSpec? Spec { get; set; }
}