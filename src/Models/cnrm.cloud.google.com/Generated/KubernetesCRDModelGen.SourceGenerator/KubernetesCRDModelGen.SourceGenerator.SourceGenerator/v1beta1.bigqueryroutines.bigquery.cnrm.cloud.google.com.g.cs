#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryRoutineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BigQueryRoutine>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryRoutineList";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryroutines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryRoutineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BigQueryRoutine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BigQueryRoutine> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryRoutineSpecArguments
{
    /// <summary>Defaults to FIXED_TYPE. Default value: &quot;FIXED_TYPE&quot; Possible values: [&quot;FIXED_TYPE&quot;, &quot;ANY_TYPE&quot;].</summary>
    [JsonPropertyName("argumentKind")]
    public string? ArgumentKind { get; set; }

    /// <summary>
    /// A JSON schema for the data type. Required unless argumentKind = ANY_TYPE.
    /// ~&gt;**NOTE**: Because this field expects a JSON string, any changes to the string
    /// will create a diff, even if the JSON itself hasn&apos;t changed. If the API returns
    /// a different value for the same schema, e.g. it switched the order of values
    /// or replaced STRUCT field type with RECORD field type, we currently cannot
    /// suppress the recurring diff this causes. As a workaround, we recommend using
    /// the schema as returned by the API.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Specifies whether the argument is input or output. Can be set for procedures only. Possible values: [&quot;IN&quot;, &quot;OUT&quot;, &quot;INOUT&quot;].</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The name of this argument. Can be absent for function return argument.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The ID of the dataset containing this routine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryRoutineSpecDatasetRef
{
    /// <summary>Allowed value: The `name` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryRoutineSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryRoutineSpec
{
    /// <summary>Input/output argument of a function or a stored procedure.</summary>
    [JsonPropertyName("arguments")]
    public IList<V1beta1BigQueryRoutineSpecArguments>? Arguments { get; set; }

    /// <summary>The ID of the dataset containing this routine.</summary>
    [JsonPropertyName("datasetRef")]
    public required V1beta1BigQueryRoutineSpecDatasetRef DatasetRef { get; set; }

    /// <summary>
    /// The body of the routine. For functions, this is the expression in the AS clause.
    /// If language=SQL, it is the substring inside (but excluding) the parentheses.
    /// </summary>
    [JsonPropertyName("definitionBody")]
    public required string DefinitionBody { get; set; }

    /// <summary>The description of the routine if defined.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The determinism level of the JavaScript UDF if defined. Possible values: [&quot;DETERMINISM_LEVEL_UNSPECIFIED&quot;, &quot;DETERMINISTIC&quot;, &quot;NOT_DETERMINISTIC&quot;].</summary>
    [JsonPropertyName("determinismLevel")]
    public string? DeterminismLevel { get; set; }

    /// <summary>
    /// Optional. If language = &quot;JAVASCRIPT&quot;, this field stores the path of the
    /// imported JAVASCRIPT libraries.
    /// </summary>
    [JsonPropertyName("importedLibraries")]
    public IList<string>? ImportedLibraries { get; set; }

    /// <summary>The language of the routine. Possible values: [&quot;SQL&quot;, &quot;JAVASCRIPT&quot;].</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1BigQueryRoutineSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The routineId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Optional. Can be set only if routineType = &quot;TABLE_VALUED_FUNCTION&quot;.
    /// 
    /// If absent, the return table type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the columns in the evaluated table result will
    /// be cast to match the column types specificed in return table type, at query time.
    /// </summary>
    [JsonPropertyName("returnTableType")]
    public string? ReturnTableType { get; set; }

    /// <summary>
    /// A JSON schema for the return type. Optional if language = &quot;SQL&quot;; required otherwise.
    /// If absent, the return type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the evaluated result will be cast to
    /// the specified returned type at query time. ~&gt;**NOTE**: Because this field expects a JSON
    /// string, any changes to the string will create a diff, even if the JSON itself hasn&apos;t
    /// changed. If the API returns a different value for the same schema, e.g. it switche
    /// d the order of values or replaced STRUCT field type with RECORD field type, we currently
    /// cannot suppress the recurring diff this causes. As a workaround, we recommend using
    /// the schema as returned by the API.
    /// </summary>
    [JsonPropertyName("returnType")]
    public string? ReturnType { get; set; }

    /// <summary>Immutable. The type of routine. Possible values: [&quot;SCALAR_FUNCTION&quot;, &quot;PROCEDURE&quot;, &quot;TABLE_VALUED_FUNCTION&quot;].</summary>
    [JsonPropertyName("routineType")]
    public string? RoutineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryRoutineStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BigQueryRoutineStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigQueryRoutineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The time when this routine was created, in milliseconds since the
    /// epoch.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public int? CreationTime { get; set; }

    /// <summary>
    /// The time when this routine was modified, in milliseconds since the
    /// epoch.
    /// </summary>
    [JsonPropertyName("lastModifiedTime")]
    public int? LastModifiedTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BigQueryRoutine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigQueryRoutineSpec>, IStatus<V1beta1BigQueryRoutineStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigQueryRoutine";
    public const string KubeGroup = "bigquery.cnrm.cloud.google.com";
    public const string KubePluralName = "bigqueryroutines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryRoutine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1BigQueryRoutineSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1BigQueryRoutineStatus? Status { get; set; }
}