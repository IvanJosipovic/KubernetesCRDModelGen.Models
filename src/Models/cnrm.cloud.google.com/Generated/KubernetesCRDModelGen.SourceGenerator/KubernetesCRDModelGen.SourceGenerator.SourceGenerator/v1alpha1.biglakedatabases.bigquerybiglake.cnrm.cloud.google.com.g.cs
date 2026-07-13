#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerybiglake.cnrm.cloud.google.com;
/// <summary>BigLakeDatabase is the Schema for the BigLakeDatabase API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigLakeDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigLakeDatabase>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigLakeDatabaseList";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglakedatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerybiglake.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigLakeDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BigLakeDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BigLakeDatabase> Items { get; set; }
}

/// <summary>Options of a Hive database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseSpecHiveOptions
{
    /// <summary>Cloud Storage folder URI where the database data is stored, starting with &quot;gs://&quot;.</summary>
    [JsonPropertyName("locationURI")]
    public string? LocationURI { get; set; }

    /// <summary>Stores user supplied Hive database parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>Required. Defines the parent path of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseSpecParentCatalogRef
{
    /// <summary>A reference to an externally managed BigQueryBigLakeCatalog resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/catalogs/{{catalogID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigQueryBigLakeCatalog resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigQueryBigLakeCatalog resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BigLakeDatabaseSpec defines the desired state of BigLakeDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseSpec
{
    /// <summary>Options of a Hive database.</summary>
    [JsonPropertyName("hiveOptions")]
    public V1alpha1BigLakeDatabaseSpecHiveOptions? HiveOptions { get; set; }

    /// <summary>Required. Defines the parent path of the resource.</summary>
    [JsonPropertyName("parentCatalogRef")]
    public V1alpha1BigLakeDatabaseSpecParentCatalogRef? ParentCatalogRef { get; set; }

    /// <summary>The BigLakeDatabase name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The database type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseStatusConditions
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
public partial class V1alpha1BigLakeDatabaseStatusObservedState
{
    /// <summary>Output only. The creation time of the database.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The deletion time of the database. Only set after the database is deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. The time when this database is considered expired. Only set after the database is deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The last modification time of the database.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BigLakeDatabaseStatus defines the config connector machine state of BigLakeDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigLakeDatabaseStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigLakeDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigLakeDatabase resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigLakeDatabaseStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigLakeDatabase is the Schema for the BigLakeDatabase API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigLakeDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigLakeDatabaseSpec>, IStatus<V1alpha1BigLakeDatabaseStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigLakeDatabase";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglakedatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerybiglake.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigLakeDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigLakeDatabaseSpec defines the desired state of BigLakeDatabase</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BigLakeDatabaseSpec Spec { get; set; }

    /// <summary>BigLakeDatabaseStatus defines the config connector machine state of BigLakeDatabase</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigLakeDatabaseStatus? Status { get; set; }
}