#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
/// <summary>BigtableTable is the Schema for the BigtableTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigtableTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BigtableTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigtableTableList";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtabletables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigtable.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigtableTableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BigtableTable objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BigtableTable> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableTableSpecColumnFamily
{
    /// <summary>The name of the column family.</summary>
    [JsonPropertyName("family")]
    public required string Family { get; set; }
}

/// <summary>Immutable. The instance to create the table in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableTableSpecInstanceRef
{
    /// <summary>A reference to an externally managed BigtableInstance resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BigtableInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BigtableInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BigtableTableSpec defines the desired state of BigtableTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableTableSpec
{
    /// <summary>Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days..</summary>
    [JsonPropertyName("changeStreamRetention")]
    public string? ChangeStreamRetention { get; set; }

    /// <summary>The names of the column families that should be created immediately upon table creation, specified by name. The values that may be set are specified here. At least one column family must be specified.</summary>
    [JsonPropertyName("columnFamily")]
    public IList<V1beta1BigtableTableSpecColumnFamily>? ColumnFamily { get; set; }

    /// <summary>
    /// NOTE: DeletionProtection proto field is changed from string (1.38) to bool (1.40) in cloud.google.com/go/bigtable/admin/apiv2/adminpb
    /// Set to true to make the table protected against data loss. i.e. deleting
    /// the following resources through Admin APIs are prohibited:
    /// 
    /// * The table.
    /// * The column families in the table.
    /// * The instance containing the table.
    /// 
    /// Note one can still delete the data stored in the table through Data APIs.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Immutable. The instance to create the table in.</summary>
    [JsonPropertyName("instanceRef")]
    public required V1beta1BigtableTableSpecInstanceRef InstanceRef { get; set; }

    /// <summary>The BigtableTable name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A list of predefined keys to split the table on.</summary>
    [JsonPropertyName("splitKeys")]
    public IList<string>? SplitKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableTableStatusConditions
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

/// <summary>BigtableTableStatus defines the config connector machine state of BigtableTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigtableTableStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigtableTableStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigtableTable resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BigtableTable is the Schema for the BigtableTable API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigtableTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigtableTableSpec>, IStatus<V1beta1BigtableTableStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigtableTable";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtabletables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigtable.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigtableTable";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigtableTableSpec defines the desired state of BigtableTable</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BigtableTableSpec Spec { get; set; }

    /// <summary>BigtableTableStatus defines the config connector machine state of BigtableTable</summary>
    [JsonPropertyName("status")]
    public V1beta1BigtableTableStatus? Status { get; set; }
}