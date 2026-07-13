#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.cnrm.cloud.google.com;
/// <summary>ApigeeInstanceAttachment is the Schema for the ApigeeInstanceAttachment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeInstanceAttachmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ApigeeInstanceAttachment>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeInstanceAttachmentList";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeinstanceattachments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigee.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApigeeInstanceAttachmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ApigeeInstanceAttachment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ApigeeInstanceAttachment> Items { get; set; }
}

/// <summary>ID of the attached environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceAttachmentSpecEnvironmentRef
{
    /// <summary>A reference to an externally managed ApigeeEnvironment resource. Should be in the format &quot;organizations/{{organizationID}}/environments/{{environmentID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ApigeeEnvironment resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ApigeeEnvironment resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to parent Apigee Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceAttachmentSpecInstanceRef
{
    /// <summary>A reference to an externally managed ApigeeInstance resource. Should be in the format &quot;organizations/{{organizationID}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ApigeeInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ApigeeInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ApigeeInstanceAttachmentSpec defines the desired state of ApigeeInstanceAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceAttachmentSpec
{
    /// <summary>ID of the attached environment.</summary>
    [JsonPropertyName("environmentRef")]
    public required V1beta1ApigeeInstanceAttachmentSpecEnvironmentRef EnvironmentRef { get; set; }

    /// <summary>Reference to parent Apigee Instance.</summary>
    [JsonPropertyName("instanceRef")]
    public required V1beta1ApigeeInstanceAttachmentSpecInstanceRef InstanceRef { get; set; }

    /// <summary>The ApigeeInstanceAttachment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceAttachmentStatusConditions
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
public partial class V1beta1ApigeeInstanceAttachmentStatusObservedState
{
    /// <summary>Output only. Time the attachment was created in milliseconds since epoch.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
}

/// <summary>ApigeeInstanceAttachmentStatus defines the config connector machine state of ApigeeInstanceAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApigeeInstanceAttachmentStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApigeeInstanceAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ApigeeInstanceAttachment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ApigeeInstanceAttachmentStatusObservedState? ObservedState { get; set; }
}

/// <summary>ApigeeInstanceAttachment is the Schema for the ApigeeInstanceAttachment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApigeeInstanceAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApigeeInstanceAttachmentSpec>, IStatus<V1beta1ApigeeInstanceAttachmentStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApigeeInstanceAttachment";
    public const string KubeGroup = "apigee.cnrm.cloud.google.com";
    public const string KubePluralName = "apigeeinstanceattachments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigee.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApigeeInstanceAttachment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApigeeInstanceAttachmentSpec defines the desired state of ApigeeInstanceAttachment</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ApigeeInstanceAttachmentSpec Spec { get; set; }

    /// <summary>ApigeeInstanceAttachmentStatus defines the config connector machine state of ApigeeInstanceAttachment</summary>
    [JsonPropertyName("status")]
    public V1beta1ApigeeInstanceAttachmentStatus? Status { get; set; }
}