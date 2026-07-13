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
public partial class V1BGPConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1BGPConfiguration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfigurationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1BGPConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1BGPConfiguration> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPConfigurationSpecBindModeEnum>))]
public enum V1BGPConfigurationSpecBindModeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "NodeIP"), JsonStringEnumMemberName("NodeIP")]
    NodeIP
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecCommunities
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPassword
{
    [JsonPropertyName("secretKeyRef")]
    public V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecPrefixAdvertisements
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("communities")]
    public IList<string>? Communities { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPConfigurationSpecProgramClusterRoutesEnum>))]
public enum V1BGPConfigurationSpecProgramClusterRoutesEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceClusterIPs
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceExternalIPs
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPConfigurationSpecServiceLoadBalancerAggregationEnum>))]
public enum V1BGPConfigurationSpecServiceLoadBalancerAggregationEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceLoadBalancerIPs
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpec
{
    [JsonPropertyName("asNumber")]
    public int? AsNumber { get; set; }

    [JsonPropertyName("bindMode")]
    public V1BGPConfigurationSpecBindModeEnum? BindMode { get; set; }

    [JsonPropertyName("communities")]
    public IList<V1BGPConfigurationSpecCommunities>? Communities { get; set; }

    [JsonPropertyName("ignoredInterfaces")]
    public IList<string>? IgnoredInterfaces { get; set; }

    [JsonPropertyName("ipv4NormalRoutePriority")]
    public int? Ipv4NormalRoutePriority { get; set; }

    [JsonPropertyName("ipv6NormalRoutePriority")]
    public int? Ipv6NormalRoutePriority { get; set; }

    [JsonPropertyName("listenPort")]
    public int? ListenPort { get; set; }

    [JsonPropertyName("localWorkloadPeeringIPV4")]
    public string? LocalWorkloadPeeringIPV4 { get; set; }

    [JsonPropertyName("localWorkloadPeeringIPV6")]
    public string? LocalWorkloadPeeringIPV6 { get; set; }

    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    [JsonPropertyName("nodeMeshMaxRestartTime")]
    public string? NodeMeshMaxRestartTime { get; set; }

    [JsonPropertyName("nodeMeshPassword")]
    public V1BGPConfigurationSpecNodeMeshPassword? NodeMeshPassword { get; set; }

    [JsonPropertyName("nodeToNodeMeshEnabled")]
    public bool? NodeToNodeMeshEnabled { get; set; }

    [JsonPropertyName("prefixAdvertisements")]
    public IList<V1BGPConfigurationSpecPrefixAdvertisements>? PrefixAdvertisements { get; set; }

    [JsonPropertyName("programClusterRoutes")]
    public V1BGPConfigurationSpecProgramClusterRoutesEnum? ProgramClusterRoutes { get; set; }

    [JsonPropertyName("serviceClusterIPs")]
    public IList<V1BGPConfigurationSpecServiceClusterIPs>? ServiceClusterIPs { get; set; }

    [JsonPropertyName("serviceExternalIPs")]
    public IList<V1BGPConfigurationSpecServiceExternalIPs>? ServiceExternalIPs { get; set; }

    [JsonPropertyName("serviceLoadBalancerAggregation")]
    public V1BGPConfigurationSpecServiceLoadBalancerAggregationEnum? ServiceLoadBalancerAggregation { get; set; }

    [JsonPropertyName("serviceLoadBalancerIPs")]
    public IList<V1BGPConfigurationSpecServiceLoadBalancerIPs>? ServiceLoadBalancerIPs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPConfigurationSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1BGPConfigurationSpec? Spec { get; set; }
}