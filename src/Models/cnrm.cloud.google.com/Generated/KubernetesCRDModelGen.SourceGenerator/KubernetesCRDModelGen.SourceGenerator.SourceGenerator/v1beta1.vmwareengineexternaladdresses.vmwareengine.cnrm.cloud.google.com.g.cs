#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vmwareengine.cnrm.cloud.google.com;
/// <summary>VMwareEngineExternalAddress is the Schema for the VMwareEngineExternalAddress API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VMwareEngineExternalAddressList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VMwareEngineExternalAddress>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VMwareEngineExternalAddressList";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineexternaladdresses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vmwareengine.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VMwareEngineExternalAddressList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VMwareEngineExternalAddress objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VMwareEngineExternalAddress> Items { get; set; }
}

/// <summary>Required. The resource name of the private cloud to create a new external IP address in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VMwareEngineExternalAddressSpecPrivateCloudRef
{
    /// <summary>A reference to an externally managed VMwareEnginePrivateCloud resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/privateClouds/{{privatecloudID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEnginePrivateCloud resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEnginePrivateCloud resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>VMwareEngineExternalAddressSpec defines the desired state of VMwareEngineExternalAddress</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VMwareEngineExternalAddressSpec
{
    /// <summary>User-provided description for this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The internal IP address of a workload VM.</summary>
    [JsonPropertyName("internalIP")]
    public string? InternalIP { get; set; }

    /// <summary>Required. The resource name of the private cloud to create a new external IP address in.</summary>
    [JsonPropertyName("privateCloudRef")]
    public required V1beta1VMwareEngineExternalAddressSpecPrivateCloudRef PrivateCloudRef { get; set; }

    /// <summary>The VMwareEngineExternalAddress name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VMwareEngineExternalAddressStatusConditions
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
public partial class V1beta1VMwareEngineExternalAddressStatusObservedState
{
    /// <summary>Output only. Creation time of this resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The external IP address of a workload VM.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>Output only. The state of the resource.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-generated unique identifier for the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Last update time of this resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VMwareEngineExternalAddressStatus defines the config connector machine state of VMwareEngineExternalAddress</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VMwareEngineExternalAddressStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VMwareEngineExternalAddressStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VMwareEngineExternalAddress resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1VMwareEngineExternalAddressStatusObservedState? ObservedState { get; set; }
}

/// <summary>VMwareEngineExternalAddress is the Schema for the VMwareEngineExternalAddress API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VMwareEngineExternalAddress : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VMwareEngineExternalAddressSpec>, IStatus<V1beta1VMwareEngineExternalAddressStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VMwareEngineExternalAddress";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineexternaladdresses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vmwareengine.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VMwareEngineExternalAddress";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VMwareEngineExternalAddressSpec defines the desired state of VMwareEngineExternalAddress</summary>
    [JsonPropertyName("spec")]
    public required V1beta1VMwareEngineExternalAddressSpec Spec { get; set; }

    /// <summary>VMwareEngineExternalAddressStatus defines the config connector machine state of VMwareEngineExternalAddress</summary>
    [JsonPropertyName("status")]
    public V1beta1VMwareEngineExternalAddressStatus? Status { get; set; }
}