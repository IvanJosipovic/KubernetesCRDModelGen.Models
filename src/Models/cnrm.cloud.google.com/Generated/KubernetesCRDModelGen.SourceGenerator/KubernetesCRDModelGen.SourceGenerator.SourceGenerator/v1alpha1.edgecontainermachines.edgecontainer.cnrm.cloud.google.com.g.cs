#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.edgecontainer.cnrm.cloud.google.com;
/// <summary>EdgeContainerMachine is the Schema for the EdgeContainerMachine API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EdgeContainerMachineList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1EdgeContainerMachine>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EdgeContainerMachineList";
    public const string KubeGroup = "edgecontainer.cnrm.cloud.google.com";
    public const string KubePluralName = "edgecontainermachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "edgecontainer.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EdgeContainerMachineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1EdgeContainerMachine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1EdgeContainerMachine> Items { get; set; }
}

/// <summary>Required. The host project of the machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EdgeContainerMachineSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>EdgeContainerMachineSpec defines the desired state of EdgeContainerMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EdgeContainerMachineSpec
{
    /// <summary>Labels associated with this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The location of the machine.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the machine.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1EdgeContainerMachineSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The EdgeContainerMachine name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The Google Distributed Cloud Edge zone of this machine.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EdgeContainerMachineStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EdgeContainerMachineStatusObservedState
{
    /// <summary>Output only. The time when the node pool was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Whether the machine is disabled. If disabled, the machine is unable to enter service.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Canonical resource name of the node that this machine is responsible for
    ///  hosting e.g.
    ///  projects/{project}/locations/{location}/clusters/{cluster_id}/nodePools/{pool_id}/{node},
    ///  Or empty if the machine is not assigned to assume the role of a node.
    /// 
    ///  For control plane nodes hosted on edge machines, this will return
    ///  the following format:
    ///    &quot;projects/{project}/locations/{location}/clusters/{cluster_id}/controlPlaneNodes/{node}&quot;.
    /// </summary>
    [JsonPropertyName("hostedNode")]
    public string? HostedNode { get; set; }

    /// <summary>Output only. The time when the node pool was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The software version of the machine.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EdgeContainerMachineStatus defines the config connector machine state of EdgeContainerMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1EdgeContainerMachineStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EdgeContainerMachineStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the EdgeContainerMachine resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1EdgeContainerMachineStatusObservedState? ObservedState { get; set; }
}

/// <summary>EdgeContainerMachine is the Schema for the EdgeContainerMachine API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EdgeContainerMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EdgeContainerMachineSpec>, IStatus<V1alpha1EdgeContainerMachineStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EdgeContainerMachine";
    public const string KubeGroup = "edgecontainer.cnrm.cloud.google.com";
    public const string KubePluralName = "edgecontainermachines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "edgecontainer.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EdgeContainerMachine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EdgeContainerMachineSpec defines the desired state of EdgeContainerMachine</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1EdgeContainerMachineSpec Spec { get; set; }

    /// <summary>EdgeContainerMachineStatus defines the config connector machine state of EdgeContainerMachine</summary>
    [JsonPropertyName("status")]
    public V1alpha1EdgeContainerMachineStatus? Status { get; set; }
}