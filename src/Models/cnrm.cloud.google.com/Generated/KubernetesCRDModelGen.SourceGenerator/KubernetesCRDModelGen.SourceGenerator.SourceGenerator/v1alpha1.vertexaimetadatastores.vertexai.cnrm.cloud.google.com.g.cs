#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary>VertexAIMetadataStore is the Schema for the VertexAIMetadataStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIMetadataStoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIMetadataStore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIMetadataStoreList";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaimetadatastores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIMetadataStoreList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAIMetadataStore objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAIMetadataStore> Items { get; set; }
}

/// <summary>Optional. Dataplex integration settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreSpecDataplexConfig
{
    /// <summary>Optional. Whether or not Data Lineage synchronization is enabled for Vertex Pipelines.</summary>
    [JsonPropertyName("enabledPipelinesLineage")]
    public bool? EnabledPipelinesLineage { get; set; }
}

/// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreSpecEncryptionSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Customer-managed encryption key spec for a Metadata Store. If set, this Metadata Store and all sub-resources of this Metadata Store are secured using this key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public required V1alpha1VertexAIMetadataStoreSpecEncryptionSpecKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreSpecProjectRef
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

/// <summary>VertexAIMetadataStoreSpec defines the desired state of VertexAIMetadataStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreSpec
{
    /// <summary>Optional. Dataplex integration settings.</summary>
    [JsonPropertyName("dataplexConfig")]
    public V1alpha1VertexAIMetadataStoreSpecDataplexConfig? DataplexConfig { get; set; }

    /// <summary>Description of the MetadataStore.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Customer-managed encryption key spec for a Metadata Store. If set, this Metadata Store and all sub-resources of this Metadata Store are secured using this key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAIMetadataStoreSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1VertexAIMetadataStoreSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The region of the Metadata Store. eg us-central1.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The VertexAIMetadataStore name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreStatusConditions
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

/// <summary>Output only. State information of the MetadataStore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreStatusObservedStateState
{
    /// <summary>The disk utilization of the MetadataStore in bytes.</summary>
    [JsonPropertyName("diskUtilizationBytes")]
    public long? DiskUtilizationBytes { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreStatusObservedState
{
    /// <summary>Output only. Timestamp when this MetadataStore was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The resource name of the MetadataStore instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. State information of the MetadataStore.</summary>
    [JsonPropertyName("state")]
    public V1alpha1VertexAIMetadataStoreStatusObservedStateState? State { get; set; }

    /// <summary>Output only. Timestamp when this MetadataStore was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAIMetadataStoreStatus defines the config connector machine state of VertexAIMetadataStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIMetadataStoreStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIMetadataStoreStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIMetadataStore resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIMetadataStoreStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIMetadataStore is the Schema for the VertexAIMetadataStore API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIMetadataStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIMetadataStoreSpec>, IStatus<V1alpha1VertexAIMetadataStoreStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIMetadataStore";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaimetadatastores";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIMetadataStore";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIMetadataStoreSpec defines the desired state of VertexAIMetadataStore</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAIMetadataStoreSpec Spec { get; set; }

    /// <summary>VertexAIMetadataStoreStatus defines the config connector machine state of VertexAIMetadataStore</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIMetadataStoreStatus? Status { get; set; }
}