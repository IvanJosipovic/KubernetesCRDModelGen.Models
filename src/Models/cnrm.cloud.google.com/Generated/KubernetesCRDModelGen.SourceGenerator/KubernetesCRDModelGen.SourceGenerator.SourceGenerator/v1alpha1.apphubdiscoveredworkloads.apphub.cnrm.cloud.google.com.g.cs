#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apphub.cnrm.cloud.google.com;
/// <summary>AppHubDiscoveredWorkload is the Schema for the AppHubDiscoveredWorkload API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppHubDiscoveredWorkloadList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AppHubDiscoveredWorkload>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppHubDiscoveredWorkloadList";
    public const string KubeGroup = "apphub.cnrm.cloud.google.com";
    public const string KubePluralName = "apphubdiscoveredworkloads";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apphub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppHubDiscoveredWorkloadList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AppHubDiscoveredWorkload objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AppHubDiscoveredWorkload> Items { get; set; }
}

/// <summary>Required. The host project of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadSpecProjectRef
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

/// <summary>AppHubDiscoveredWorkloadSpec defines the desired state of AppHubDiscoveredWorkload</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadSpec
{
    /// <summary>Required. The location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the resource.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1AppHubDiscoveredWorkloadSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The AppHubDiscoveredWorkload name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadStatusConditions
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

/// <summary>Output only. Properties of an underlying compute resource represented by the Workload. These are immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadStatusObservedStateWorkloadProperties
{
    /// <summary>Output only. The service project identifier that the underlying cloud resource resides in. Empty for non-cloud resources.</summary>
    [JsonPropertyName("gcpProject")]
    public string? GcpProject { get; set; }

    /// <summary>Output only. The location that the underlying compute resource resides in (for example, us-west1).</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Output only. The location that the underlying compute resource resides in if it is zonal (for example, us-west1-a).</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Output only. Reference of an underlying compute resource represented by the Workload. These are immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadStatusObservedStateWorkloadReference
{
    /// <summary>Output only. The underlying compute resource uri.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadStatusObservedState
{
    /// <summary>Output only. Properties of an underlying compute resource represented by the Workload. These are immutable.</summary>
    [JsonPropertyName("workloadProperties")]
    public V1alpha1AppHubDiscoveredWorkloadStatusObservedStateWorkloadProperties? WorkloadProperties { get; set; }

    /// <summary>Output only. Reference of an underlying compute resource represented by the Workload. These are immutable.</summary>
    [JsonPropertyName("workloadReference")]
    public V1alpha1AppHubDiscoveredWorkloadStatusObservedStateWorkloadReference? WorkloadReference { get; set; }
}

/// <summary>AppHubDiscoveredWorkloadStatus defines the config connector machine state of AppHubDiscoveredWorkload</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppHubDiscoveredWorkloadStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppHubDiscoveredWorkloadStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the AppHubDiscoveredWorkload resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1AppHubDiscoveredWorkloadStatusObservedState? ObservedState { get; set; }
}

/// <summary>AppHubDiscoveredWorkload is the Schema for the AppHubDiscoveredWorkload API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppHubDiscoveredWorkload : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppHubDiscoveredWorkloadSpec>, IStatus<V1alpha1AppHubDiscoveredWorkloadStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppHubDiscoveredWorkload";
    public const string KubeGroup = "apphub.cnrm.cloud.google.com";
    public const string KubePluralName = "apphubdiscoveredworkloads";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apphub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppHubDiscoveredWorkload";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppHubDiscoveredWorkloadSpec defines the desired state of AppHubDiscoveredWorkload</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AppHubDiscoveredWorkloadSpec Spec { get; set; }

    /// <summary>AppHubDiscoveredWorkloadStatus defines the config connector machine state of AppHubDiscoveredWorkload</summary>
    [JsonPropertyName("status")]
    public V1alpha1AppHubDiscoveredWorkloadStatus? Status { get; set; }
}