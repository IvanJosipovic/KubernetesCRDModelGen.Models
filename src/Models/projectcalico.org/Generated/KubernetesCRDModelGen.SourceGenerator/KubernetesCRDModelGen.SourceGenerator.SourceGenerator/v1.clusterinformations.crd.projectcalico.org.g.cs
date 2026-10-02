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
/// <summary>ClusterInformation contains the cluster specific information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterInformationList : IKubernetesObject<V1ListMeta>, IItems<V1ClusterInformation>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterInformationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "clusterinformations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterInformationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ClusterInformation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ClusterInformation> Items { get; set; }
}

/// <summary>
/// ClusterInformationSpec contains the values of describing the cluster.
/// This resource is managed automatically by Calico components and should not be modified manually.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ClusterInformationSpec
{
    /// <summary>CalicoVersion is the version of Calico running on the cluster, set automatically by calico/node.</summary>
    [JsonPropertyName("calicoVersion")]
    public string? CalicoVersion { get; set; }

    /// <summary>ClusterGUID is the unique identifier for this cluster, generated automatically at install time.</summary>
    [JsonPropertyName("clusterGUID")]
    public string? ClusterGUID { get; set; }

    /// <summary>
    /// ClusterType describes the type of the cluster, e.g., &quot;k8s,bgp,kubeadm&quot;.
    /// Set automatically based on the detected environment.
    /// </summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>
    /// DatastoreReady is used during significant datastore migrations to signal to components
    /// such as Felix that it should wait before accessing the datastore.
    /// </summary>
    [JsonPropertyName("datastoreReady")]
    public bool? DatastoreReady { get; set; }

    /// <summary>Variant declares which variant of Calico is active.</summary>
    [JsonPropertyName("variant")]
    public string? Variant { get; set; }
}

/// <summary>ClusterInformation contains the cluster specific information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ClusterInformation : IKubernetesObject<V1ObjectMeta>, ISpec<V1ClusterInformationSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ClusterInformation";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "clusterinformations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterInformation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ClusterInformationSpec contains the values of describing the cluster.
    /// This resource is managed automatically by Calico components and should not be modified manually.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1ClusterInformationSpec? Spec { get; set; }
}