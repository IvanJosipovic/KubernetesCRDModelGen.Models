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
public partial class V1IPAMConfigList : IKubernetesObject<V1ListMeta>, IItems<V1IPAMConfig>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMConfigList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPAMConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1IPAMConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1IPAMConfig> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPAMConfigSpecKubeVirtVMAddressPersistenceEnum>))]
public enum V1IPAMConfigSpecKubeVirtVMAddressPersistenceEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPAMConfigSpec
{
    [JsonPropertyName("autoAllocateBlocks")]
    public required bool AutoAllocateBlocks { get; set; }

    [JsonPropertyName("kubeVirtVMAddressPersistence")]
    public V1IPAMConfigSpecKubeVirtVMAddressPersistenceEnum? KubeVirtVMAddressPersistence { get; set; }

    [JsonPropertyName("maxBlocksPerHost")]
    public int? MaxBlocksPerHost { get; set; }

    [JsonPropertyName("strictAffinity")]
    public required bool StrictAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPAMConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPAMConfigSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMConfig";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPAMConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1IPAMConfigSpec? Spec { get; set; }
}