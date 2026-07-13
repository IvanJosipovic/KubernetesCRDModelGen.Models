#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.metastore.cnrm.cloud.google.com;
/// <summary>MetastoreBackup is the Schema for the MetastoreBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetastoreBackupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MetastoreBackup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetastoreBackupList";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastorebackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "metastore.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreBackupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MetastoreBackup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MetastoreBackup> Items { get; set; }
}

/// <summary>The MetastoreService that the backup belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreBackupSpecServiceRef
{
    /// <summary>A reference to an externally managed MetastoreService resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/services/{{serviceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a MetastoreService resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a MetastoreService resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>MetastoreBackupSpec defines the desired state of MetastoreBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreBackupSpec
{
    /// <summary>The description of the backup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The MetastoreBackup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The MetastoreService that the backup belongs to.</summary>
    [JsonPropertyName("serviceRef")]
    public required V1beta1MetastoreBackupSpecServiceRef ServiceRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreBackupStatusConditions
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
public partial class V1beta1MetastoreBackupStatusObservedState
{
    /// <summary>Output only. The time when the backup was started.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time when the backup finished creating.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. Services that are restoring from the backup.</summary>
    [JsonPropertyName("restoringServices")]
    public IList<string>? RestoringServices { get; set; }

    /// <summary>Output only. The revision of the service at the time of backup.</summary>
    [JsonPropertyName("serviceRevision")]
    public JsonNode? ServiceRevision { get; set; }

    /// <summary>Output only. The current state of the backup.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>MetastoreBackupStatus defines the config connector machine state of MetastoreBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreBackupStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MetastoreBackupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the MetastoreBackup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1MetastoreBackupStatusObservedState? ObservedState { get; set; }
}

/// <summary>MetastoreBackup is the Schema for the MetastoreBackup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetastoreBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MetastoreBackupSpec>, IStatus<V1beta1MetastoreBackupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetastoreBackup";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastorebackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "metastore.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreBackup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreBackupSpec defines the desired state of MetastoreBackup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MetastoreBackupSpec Spec { get; set; }

    /// <summary>MetastoreBackupStatus defines the config connector machine state of MetastoreBackup</summary>
    [JsonPropertyName("status")]
    public V1beta1MetastoreBackupStatus? Status { get; set; }
}