#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeNodeTemplate is the Schema for the ComputeNodeTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNodeTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeNodeTemplate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNodeTemplateList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenodetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeNodeTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeNodeTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeNodeTemplate> Items { get; set; }
}

/// <summary>Immutable. Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeTemplateSpecNodeTypeFlexibility
{
    /// <summary>Immutable. Number of virtual CPUs to use.</summary>
    [JsonPropertyName("cpus")]
    public string? Cpus { get; set; }

    /// <summary>Use local SSD.</summary>
    [JsonPropertyName("localSsd")]
    public string? LocalSsd { get; set; }

    /// <summary>Immutable. Physical memory available to the node, defined in MB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Immutable. The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeTemplateSpecServerBinding
{
    /// <summary>
    /// Immutable. Type of server binding policy. If &apos;RESTART_NODE_ON_ANY_SERVER&apos;,
    /// nodes using this template will restart on any physical server
    /// following a maintenance event.
    /// 
    /// If &apos;RESTART_NODE_ON_MINIMAL_SERVER&apos;, nodes using this template
    /// will restart on the same physical server following a maintenance
    /// event, instead of being live migrated to or restarted on a new
    /// physical server. This option may be useful if you are using
    /// software licenses tied to the underlying server characteristics
    /// such as physical sockets or cores, to avoid the need for
    /// additional licenses when maintenance occurs. However, VMs on such
    /// nodes will experience outages while maintenance is applied. Possible values: [&quot;RESTART_NODE_ON_ANY_SERVER&quot;, &quot;RESTART_NODE_ON_MINIMAL_SERVERS&quot;].
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ComputeNodeTemplateSpec defines the desired state of ComputeNodeTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeTemplateSpec
{
    /// <summary>Immutable. CPU overcommit. Default value: &quot;NONE&quot; Possible values: [&quot;ENABLED&quot;, &quot;NONE&quot;].</summary>
    [JsonPropertyName("cpuOvercommitType")]
    public string? CpuOvercommitType { get; set; }

    /// <summary>Immutable. An optional textual description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Node type to use for nodes group that are created from this template. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Immutable. Flexible properties for the desired node type. Node groups that use this node template will create nodes of a type that matches these properties. Only one of nodeTypeFlexibility and nodeType can be specified.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public V1beta1ComputeNodeTemplateSpecNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

    /// <summary>Immutable. Region where nodes using the node template will be created.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The server binding policy for nodes using this template. Determines where the nodes should restart following a maintenance event.</summary>
    [JsonPropertyName("serverBinding")]
    public V1beta1ComputeNodeTemplateSpecServerBinding? ServerBinding { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeTemplateStatusConditions
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

/// <summary>ComputeNodeTemplateStatus defines the config connector machine state of ComputeNodeTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNodeTemplateStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeNodeTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A unique specifier for the ComputeNodeTemplate resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeNodeTemplate is the Schema for the ComputeNodeTemplate API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNodeTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeNodeTemplateSpec>, IStatus<V1beta1ComputeNodeTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNodeTemplate";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenodetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeNodeTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeNodeTemplateSpec defines the desired state of ComputeNodeTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeNodeTemplateSpec Spec { get; set; }

    /// <summary>ComputeNodeTemplateStatus defines the config connector machine state of ComputeNodeTemplate</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeNodeTemplateStatus? Status { get; set; }
}