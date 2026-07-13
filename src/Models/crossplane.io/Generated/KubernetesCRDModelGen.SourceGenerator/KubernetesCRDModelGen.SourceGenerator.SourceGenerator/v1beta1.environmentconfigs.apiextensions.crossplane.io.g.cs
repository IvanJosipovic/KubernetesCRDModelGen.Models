#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>
/// An EnvironmentConfig contains user-defined unstructured values for
/// use in a Composition.
/// 
/// Read the Crossplane documentation for
/// [more information about EnvironmentConfigs](https://docs.crossplane.io/latest/composition/environment-configs/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EnvironmentConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EnvironmentConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvironmentConfigList";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "environmentconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EnvironmentConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1EnvironmentConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1EnvironmentConfig> Items { get; set; }
}

/// <summary>
/// An EnvironmentConfig contains user-defined unstructured values for
/// use in a Composition.
/// 
/// Read the Crossplane documentation for
/// [more information about EnvironmentConfigs](https://docs.crossplane.io/latest/composition/environment-configs/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EnvironmentConfig : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EnvironmentConfig";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "environmentconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EnvironmentConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// The data of this EnvironmentConfig.
    /// This may contain any kind of structure that can be serialized into JSON.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, JsonNode>? Data { get; set; }
}