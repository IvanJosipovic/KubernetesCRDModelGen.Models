#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicenetworking.cnrm.cloud.google.com;
/// <summary>ServiceNetworkingPeeredDNSDomain is the Schema for the ServiceNetworkingPeeredDNSDomain API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServiceNetworkingPeeredDNSDomainList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServiceNetworkingPeeredDNSDomain>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServiceNetworkingPeeredDNSDomainList";
    public const string KubeGroup = "servicenetworking.cnrm.cloud.google.com";
    public const string KubePluralName = "servicenetworkingpeereddnsdomains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicenetworking.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceNetworkingPeeredDNSDomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ServiceNetworkingPeeredDNSDomain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ServiceNetworkingPeeredDNSDomain> Items { get; set; }
}

/// <summary>The network that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceNetworkingPeeredDNSDomainSpecNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ServiceNetworkingPeeredDNSDomainSpec defines the desired state of ServiceNetworkingPeeredDNSDomain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceNetworkingPeeredDNSDomainSpec
{
    /// <summary>The DNS domain name suffix e.g. `example.com.`. Cloud DNS requires that a DNS suffix ends with a trailing dot.</summary>
    [JsonPropertyName("dnsSuffix")]
    public string? DnsSuffix { get; set; }

    /// <summary>The network that this resource belongs to.</summary>
    [JsonPropertyName("networkRef")]
    public required V1alpha1ServiceNetworkingPeeredDNSDomainSpecNetworkRef NetworkRef { get; set; }

    /// <summary>The ServiceNetworkingPeeredDNSDomain name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceNetworkingPeeredDNSDomainStatusConditions
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
public partial class V1alpha1ServiceNetworkingPeeredDNSDomainStatusObservedState
{
}

/// <summary>ServiceNetworkingPeeredDNSDomainStatus defines the config connector machine state of ServiceNetworkingPeeredDNSDomain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServiceNetworkingPeeredDNSDomainStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServiceNetworkingPeeredDNSDomainStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ServiceNetworkingPeeredDNSDomain resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ServiceNetworkingPeeredDNSDomainStatusObservedState? ObservedState { get; set; }
}

/// <summary>ServiceNetworkingPeeredDNSDomain is the Schema for the ServiceNetworkingPeeredDNSDomain API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServiceNetworkingPeeredDNSDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServiceNetworkingPeeredDNSDomainSpec>, IStatus<V1alpha1ServiceNetworkingPeeredDNSDomainStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServiceNetworkingPeeredDNSDomain";
    public const string KubeGroup = "servicenetworking.cnrm.cloud.google.com";
    public const string KubePluralName = "servicenetworkingpeereddnsdomains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicenetworking.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceNetworkingPeeredDNSDomain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceNetworkingPeeredDNSDomainSpec defines the desired state of ServiceNetworkingPeeredDNSDomain</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ServiceNetworkingPeeredDNSDomainSpec Spec { get; set; }

    /// <summary>ServiceNetworkingPeeredDNSDomainStatus defines the config connector machine state of ServiceNetworkingPeeredDNSDomain</summary>
    [JsonPropertyName("status")]
    public V1alpha1ServiceNetworkingPeeredDNSDomainStatus? Status { get; set; }
}