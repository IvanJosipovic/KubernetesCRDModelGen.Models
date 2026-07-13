#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>
/// FailoverQuorum contains the information about the current failover
/// quorum status of a PG cluster. It is updated by the instance manager
/// of the primary node and reset to zero by the operator to trigger
/// an update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1FailoverQuorumList : IKubernetesObject<V1ListMeta>, IItems<V1FailoverQuorum>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "FailoverQuorumList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "failoverquorums";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FailoverQuorumList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1FailoverQuorum objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1FailoverQuorum> Items { get; set; }
}

/// <summary>Most recently observed status of the failover quorum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1FailoverQuorumStatus
{
    /// <summary>Contains the latest reported Method value.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Primary is the name of the primary instance that updated
    /// this object the latest time.
    /// </summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>
    /// StandbyNames is the list of potentially synchronous
    /// instance names.
    /// </summary>
    [JsonPropertyName("standbyNames")]
    public IList<string>? StandbyNames { get; set; }

    /// <summary>
    /// StandbyNumber is the number of synchronous standbys that transactions
    /// need to wait for replies from.
    /// </summary>
    [JsonPropertyName("standbyNumber")]
    public int? StandbyNumber { get; set; }
}

/// <summary>
/// FailoverQuorum contains the information about the current failover
/// quorum status of a PG cluster. It is updated by the instance manager
/// of the primary node and reset to zero by the operator to trigger
/// an update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1FailoverQuorum : IKubernetesObject<V1ObjectMeta>, IStatus<V1FailoverQuorumStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "FailoverQuorum";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "failoverquorums";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FailoverQuorum";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Most recently observed status of the failover quorum.</summary>
    [JsonPropertyName("status")]
    public V1FailoverQuorumStatus? Status { get; set; }
}