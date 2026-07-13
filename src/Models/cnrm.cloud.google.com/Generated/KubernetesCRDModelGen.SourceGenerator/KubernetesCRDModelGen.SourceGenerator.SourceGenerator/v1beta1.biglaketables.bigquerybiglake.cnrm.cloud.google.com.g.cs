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
/// <summary>BigLakeTable is the Schema for the BigLakeTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigLakeTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BigLakeTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigLakeTableList";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglaketables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerybiglake.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigLakeTableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BigLakeTable objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BigLakeTable> Items { get; set; }
}

/// <summary>Serializer and deserializer information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableSpecHiveOptionsStorageDescriptorSerdeInfo
{
    /// <summary>The fully qualified Java class name of the serialization library.</summary>
    [JsonPropertyName("serializationLib")]
    public string? SerializationLib { get; set; }
}

/// <summary>Stores physical storage information of the data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableSpecHiveOptionsStorageDescriptor
{
    /// <summary>The fully qualified Java class name of the input format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Cloud Storage folder URI where the table data is stored, starting with &quot;gs://&quot;.</summary>
    [JsonPropertyName("locationURI")]
    public string? LocationURI { get; set; }

    /// <summary>The fully qualified Java class name of the output format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Serializer and deserializer information.</summary>
    [JsonPropertyName("serdeInfo")]
    public V1beta1BigLakeTableSpecHiveOptionsStorageDescriptorSerdeInfo? SerdeInfo { get; set; }
}

/// <summary>Options of a Hive table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableSpecHiveOptions
{
    /// <summary>Stores user supplied Hive table parameters.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Stores physical storage information of the data.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1BigLakeTableSpecHiveOptionsStorageDescriptor? StorageDescriptor { get; set; }

    /// <summary>Hive table type. For example, MANAGED_TABLE, EXTERNAL_TABLE.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }
}

/// <summary>Required. The parent resource where this table will be created. Format: projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableSpecParentDatabaseRef
{
    /// <summary>A reference to an externally managed BigQueryBigLakeDatabase resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/catalogs/{{catalogID}}/databases/{{databaseID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigQueryBigLakeDatabase resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigQueryBigLakeDatabase resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BigLakeTableSpec defines the desired state of BigLakeTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableSpec
{
    /// <summary>Options of a Hive table.</summary>
    [JsonPropertyName("hiveOptions")]
    public V1beta1BigLakeTableSpecHiveOptions? HiveOptions { get; set; }

    /// <summary>Required. The parent resource where this table will be created. Format: projects/{project_id_or_number}/locations/{location_id}/catalogs/{catalog_id}/databases/{database_id}</summary>
    [JsonPropertyName("parentDatabaseRef")]
    public required V1beta1BigLakeTableSpecParentDatabaseRef ParentDatabaseRef { get; set; }

    /// <summary>The BigLake Table ID. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The table type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableStatusConditions
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
public partial class V1beta1BigLakeTableStatusObservedState
{
    /// <summary>Output only. The creation time of the table.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The deletion time of the table. Only set after the table is deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. The time when this table is considered expired. Only set after the table is deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The last modification time of the table.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BigLakeTableStatus defines the config connector machine state of BigLakeTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigLakeTableStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigLakeTableStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigLakeTable resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1BigLakeTableStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigLakeTable is the Schema for the BigLakeTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigLakeTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigLakeTableSpec>, IStatus<V1beta1BigLakeTableStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigLakeTable";
    public const string KubeGroup = "bigquerybiglake.cnrm.cloud.google.com";
    public const string KubePluralName = "biglaketables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerybiglake.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigLakeTable";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigLakeTableSpec defines the desired state of BigLakeTable</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BigLakeTableSpec Spec { get; set; }

    /// <summary>BigLakeTableStatus defines the config connector machine state of BigLakeTable</summary>
    [JsonPropertyName("status")]
    public V1beta1BigLakeTableStatus? Status { get; set; }
}