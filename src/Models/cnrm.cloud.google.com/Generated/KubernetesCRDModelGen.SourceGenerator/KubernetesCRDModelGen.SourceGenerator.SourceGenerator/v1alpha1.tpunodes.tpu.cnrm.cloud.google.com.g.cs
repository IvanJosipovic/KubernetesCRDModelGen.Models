#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.tpu.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TPUNodeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TPUNode>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TPUNodeList";
    public const string KubeGroup = "tpu.cnrm.cloud.google.com";
    public const string KubePluralName = "tpunodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "tpu.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TPUNodeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TPUNode objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TPUNode> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUNodeSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Sets the scheduling options for this TPU instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUNodeSpecSchedulingConfig
{
    /// <summary>Immutable. Defines whether the TPU instance is preemptible.</summary>
    [JsonPropertyName("preemptible")]
    public required bool Preemptible { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUNodeSpec
{
    /// <summary>Immutable. The type of hardware accelerators associated with this node.</summary>
    [JsonPropertyName("acceleratorType")]
    public required string AcceleratorType { get; set; }

    /// <summary>
    /// Immutable. The CIDR block that the TPU node will use when selecting an IP
    /// address. This CIDR block must be a /29 block; the Compute Engine
    /// networks API forbids a smaller block, and using a larger block would
    /// be wasteful (a node can only consume one IP address).
    /// 
    /// Errors will occur if the CIDR block has already been used for a
    /// currently existing TPU node, the CIDR block conflicts with any
    /// subnetworks in the user&apos;s provided network, or the provided network
    /// is peered with another network that is using that CIDR block.
    /// </summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Immutable. The user-supplied description of the TPU. Maximum of 512 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Immutable. The name of a network to peer the TPU node to. It must be a
    /// preexisting Compute Engine network inside of the project on which
    /// this API has been activated. If none is provided, &quot;default&quot; will be
    /// used.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1TPUNodeSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Sets the scheduling options for this TPU instance.</summary>
    [JsonPropertyName("schedulingConfig")]
    public V1alpha1TPUNodeSpecSchedulingConfig? SchedulingConfig { get; set; }

    /// <summary>The version of Tensorflow running in the Node.</summary>
    [JsonPropertyName("tensorflowVersion")]
    public required string TensorflowVersion { get; set; }

    /// <summary>
    /// Immutable. Whether the VPC peering for the node is set up through Service Networking API.
    /// The VPC Peering should be set up before provisioning the node. If this field is set,
    /// cidr_block field should not be specified. If the network that you want to peer the
    /// TPU Node to is a Shared VPC network, the node must be created with this this field enabled.
    /// </summary>
    [JsonPropertyName("useServiceNetworking")]
    public bool? UseServiceNetworking { get; set; }

    /// <summary>Immutable. The GCP location for the TPU. If it is not provided, the provider zone is used.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUNodeStatusConditions
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
public partial class V1alpha1TPUNodeStatusNetworkEndpoints
{
    /// <summary>The IP address of this network endpoint.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The port of this network endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TPUNodeStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TPUNodeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The network endpoints where TPU workers can be accessed and sent work.
    /// It is recommended that Tensorflow clients of the node first reach out
    /// to the first (index 0) entry.
    /// </summary>
    [JsonPropertyName("networkEndpoints")]
    public IList<V1alpha1TPUNodeStatusNetworkEndpoints>? NetworkEndpoints { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>
    /// The service account used to run the tensor flow services within the
    /// node. To share resources, including Google Cloud Storage data, with
    /// the Tensorflow job running in the Node, this account must have
    /// permissions to that data.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TPUNode : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TPUNodeSpec>, IStatus<V1alpha1TPUNodeStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TPUNode";
    public const string KubeGroup = "tpu.cnrm.cloud.google.com";
    public const string KubePluralName = "tpunodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "tpu.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TPUNode";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1TPUNodeSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1TPUNodeStatus? Status { get; set; }
}