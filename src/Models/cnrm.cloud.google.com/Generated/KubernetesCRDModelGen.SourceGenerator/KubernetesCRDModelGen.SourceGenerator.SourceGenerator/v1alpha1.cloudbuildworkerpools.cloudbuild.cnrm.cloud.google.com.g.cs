#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.cnrm.cloud.google.com;
/// <summary>CloudBuildWorkerPool is the Schema for the CloudBuild WorkerPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudBuildWorkerPoolList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudBuildWorkerPool>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudBuildWorkerPoolList";
    public const string KubeGroup = "cloudbuild.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbuildworkerpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudBuildWorkerPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudBuildWorkerPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudBuildWorkerPool> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfigPeeredNetworkRef
{
    /// <summary>A reference to an externally-managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfig
{
    [JsonPropertyName("egressOption")]
    public string? EgressOption { get; set; }

    [JsonPropertyName("peeredNetworkIPRange")]
    public string? PeeredNetworkIPRange { get; set; }

    [JsonPropertyName("peeredNetworkRef")]
    public required V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfigPeeredNetworkRef PeeredNetworkRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigWorkerConfig
{
    [JsonPropertyName("diskSizeGb")]
    public long? DiskSizeGb { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1Config
{
    [JsonPropertyName("networkConfig")]
    public V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigNetworkConfig? NetworkConfig { get; set; }

    [JsonPropertyName("workerConfig")]
    public required V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1ConfigWorkerConfig WorkerConfig { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolSpecProjectRef
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

/// <summary>CloudBuildWorkerPoolSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolSpec
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("location")]
    public required string Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privatePoolV1Config")]
    public required V1alpha1CloudBuildWorkerPoolSpecPrivatePoolV1Config PrivatePoolV1Config { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudBuildWorkerPoolSpecProjectRef ProjectRef { get; set; }

    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolStatusObservedStateNetworkConfig
{
    [JsonPropertyName("egressOption")]
    public string? EgressOption { get; set; }

    [JsonPropertyName("peeredNetwork")]
    public string? PeeredNetwork { get; set; }

    [JsonPropertyName("peeredNetworkIPRange")]
    public string? PeeredNetworkIPRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolStatusObservedStateWorkerConfig
{
    [JsonPropertyName("diskSizeGb")]
    public long? DiskSizeGb { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolStatusObservedState
{
    /// <summary>The creation timestamp of the workerpool.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    [JsonPropertyName("networkConfig")]
    public V1alpha1CloudBuildWorkerPoolStatusObservedStateNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The last update timestamp of the workerpool.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }

    [JsonPropertyName("workerConfig")]
    public V1alpha1CloudBuildWorkerPoolStatusObservedStateWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>CloudBuildWorkerPoolStatus defines the observed state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudBuildWorkerPoolStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudBuildWorkerPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudBuildWorkerPoolStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudBuildWorkerPool is the Schema for the CloudBuild WorkerPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudBuildWorkerPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudBuildWorkerPoolSpec?>, IStatus<V1alpha1CloudBuildWorkerPoolStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudBuildWorkerPool";
    public const string KubeGroup = "cloudbuild.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudbuildworkerpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudBuildWorkerPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudBuildWorkerPoolSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudBuildWorkerPoolSpec? Spec { get; set; }

    /// <summary>CloudBuildWorkerPoolStatus defines the observed state of Instance</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudBuildWorkerPoolStatus? Status { get; set; }
}