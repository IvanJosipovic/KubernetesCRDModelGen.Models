#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.temporal.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TemporalConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TemporalConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TemporalConnectionList";
    public const string KubeGroup = "temporal.io";
    public const string KubePluralName = "temporalconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "temporal.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TemporalConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TemporalConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TemporalConnection> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
public partial class V1alpha1TemporalConnectionSpecApiKeySecretRef
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
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
public partial class V1alpha1TemporalConnectionSpecMutualTLSSecretRef
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
public partial class V1alpha1TemporalConnectionSpec
{
    [JsonPropertyName("apiKeySecretRef")]
    public V1alpha1TemporalConnectionSpecApiKeySecretRef? ApiKeySecretRef { get; set; }

    [JsonPropertyName("hostPort")]
    public required string HostPort { get; set; }

    [JsonPropertyName("mutualTLSSecretRef")]
    public V1alpha1TemporalConnectionSpecMutualTLSSecretRef? MutualTLSSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TemporalConnectionStatusConditionsStatusEnum>))]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
public enum V1alpha1TemporalConnectionStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
public partial class V1alpha1TemporalConnectionStatusConditions
{
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    [JsonPropertyName("status")]
    public required V1alpha1TemporalConnectionStatusConditionsStatusEnum Status { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
public partial class V1alpha1TemporalConnectionStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TemporalConnectionStatusConditions>? Conditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("TemporalConnection is deprecated. Use Connection instead.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TemporalConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TemporalConnectionSpec?>, IStatus<V1alpha1TemporalConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TemporalConnection";
    public const string KubeGroup = "temporal.io";
    public const string KubePluralName = "temporalconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "temporal.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TemporalConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1TemporalConnectionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1TemporalConnectionStatus? Status { get; set; }
}