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
public partial class V1IPPoolList : IKubernetesObject<V1ListMeta>, IItems<V1IPPool>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPoolList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1IPPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1IPPool> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecAllowedUsesEnum>))]
public enum V1IPPoolSpecAllowedUsesEnum
{
    [EnumMember(Value = "Workload"), JsonStringEnumMemberName("Workload")]
    Workload,
    [EnumMember(Value = "Tunnel"), JsonStringEnumMemberName("Tunnel")]
    Tunnel,
    [EnumMember(Value = "LoadBalancer"), JsonStringEnumMemberName("LoadBalancer")]
    LoadBalancer
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecAssignmentModeEnum>))]
public enum V1IPPoolSpecAssignmentModeEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecIpipModeEnum>))]
public enum V1IPPoolSpecIpipModeEnum
{
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "CrossSubnet"), JsonStringEnumMemberName("CrossSubnet")]
    CrossSubnet
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecVxlanModeEnum>))]
public enum V1IPPoolSpecVxlanModeEnum
{
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "CrossSubnet"), JsonStringEnumMemberName("CrossSubnet")]
    CrossSubnet
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPPoolSpec
{
    [JsonPropertyName("allowedUses")]
    public IList<V1IPPoolSpecAllowedUsesEnum>? AllowedUses { get; set; }

    [JsonPropertyName("assignmentMode")]
    public V1IPPoolSpecAssignmentModeEnum? AssignmentMode { get; set; }

    [JsonPropertyName("blockSize")]
    public int? BlockSize { get; set; }

    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    [JsonPropertyName("disableBGPExport")]
    public bool? DisableBGPExport { get; set; }

    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    [JsonPropertyName("ipipMode")]
    public V1IPPoolSpecIpipModeEnum? IpipMode { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("natOutgoing")]
    public bool? NatOutgoing { get; set; }

    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    [JsonPropertyName("vxlanMode")]
    public V1IPPoolSpecVxlanModeEnum? VxlanMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPPoolSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPool";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1IPPoolSpec? Spec { get; set; }
}