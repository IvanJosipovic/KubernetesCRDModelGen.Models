#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.m.upbound.io;
/// <summary>CatalogTable is the Schema for the CatalogTables API. Provides a Glue Catalog Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogTableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CatalogTable>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogTableList";
    public const string KubeGroup = "glue.aws.m.upbound.io";
    public const string KubePluralName = "catalogtables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CatalogTableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CatalogTable objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CatalogTable> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderDatabaseNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields
{
    /// <summary>Unique identifier assigned to this partition field within the Iceberg table&apos;s partition specification.</summary>
    [JsonPropertyName("fieldId")]
    public double? FieldId { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Identifier of the source field from the table schema that this partition field is based on.</summary>
    [JsonPropertyName("sourceId")]
    public double? SourceId { get; set; }

    /// <summary>Transformation function applied to the source field to create the partition. Common values: identity, bucket, truncate, year, month, day, hour.</summary>
    [JsonPropertyName("transform")]
    public string? Transform { get; set; }
}

/// <summary>Partitioning specification that defines how the Iceberg table data will be organized and partitioned for optimal query performance. See partition_spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields>? Fields { get; set; }

    /// <summary>Unique identifier for this partition specification within the Iceberg table&apos;s metadata history.</summary>
    [JsonPropertyName("specId")]
    public double? SpecId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSchemaFields
{
    /// <summary>Documentation or description text that provides additional context about the purpose and usage of this field. Length between 0 and 255 characters.</summary>
    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    /// <summary>Unique identifier assigned to this field within the Iceberg table schema, used for schema evolution and field tracking.</summary>
    [JsonPropertyName("id")]
    public double? Id { get; set; }

    /// <summary>Default value as JSON used to populate the field&apos;s value for all records that were written before the field was added to the schema.</summary>
    [JsonPropertyName("initialDefault")]
    public string? InitialDefault { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether this field is required (non-nullable) or optional (nullable) in the table schema.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Default value as JSON used to populate the field&apos;s value for any records written after the field was added to the schema, if the writer does not supply the field&apos;s value.</summary>
    [JsonPropertyName("writeDefault")]
    public string? WriteDefault { get; set; }
}

/// <summary>Schema definition that specifies the structure, field types, and metadata for the Iceberg table. See schema below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSchema
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSchemaFields>? Fields { get; set; }

    /// <summary>List of field identifiers that uniquely identify records in the table, used for row-level operations and deduplication.</summary>
    [JsonPropertyName("identifierFieldIds")]
    public IList<double>? IdentifierFieldIds { get; set; }

    /// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
    [JsonPropertyName("schemaId")]
    public double? SchemaId { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields
{
    /// <summary>Sort direction for this field. Valid values: asc, desc.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Ordering behavior for null values in this field. Valid values: nulls-first, nulls-last.</summary>
    [JsonPropertyName("nullOrder")]
    public string? NullOrder { get; set; }

    /// <summary>Identifier of the source field from the table schema that this partition field is based on.</summary>
    [JsonPropertyName("sourceId")]
    public double? SourceId { get; set; }

    /// <summary>Transformation function applied to the source field to create the partition. Common values: identity, bucket, truncate, year, month, day, hour.</summary>
    [JsonPropertyName("transform")]
    public string? Transform { get; set; }
}

/// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrder
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields>? Fields { get; set; }

    /// <summary>Unique identifier for this sort order specification within the Iceberg table&apos;s metadata.</summary>
    [JsonPropertyName("orderId")]
    public double? OrderId { get; set; }
}

/// <summary>Configuration parameters, including table properties and metadata specifications. See iceberg_table_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInput
{
    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Partitioning specification that defines how the Iceberg table data will be organized and partitioned for optimal query performance. See partition_spec below.</summary>
    [JsonPropertyName("partitionSpec")]
    public V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec? PartitionSpec { get; set; }

    /// <summary>Key-value pairs of additional table properties and configuration settings for the Iceberg table.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Schema definition that specifies the structure, field types, and metadata for the Iceberg table. See schema below.</summary>
    [JsonPropertyName("schema")]
    public V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSchema? Schema { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrder? SortOrder { get; set; }
}

/// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInput
{
    /// <summary>Configuration parameters, including table properties and metadata specifications. See iceberg_table_input below.</summary>
    [JsonPropertyName("icebergTableInput")]
    public V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInputIcebergTableInput? IcebergTableInput { get; set; }

    /// <summary>Required metadata operation. Can only be set to CREATE.</summary>
    [JsonPropertyName("metadataOperation")]
    public string? MetadataOperation { get; set; }

    /// <summary>Table version for the Iceberg table. Defaults to 2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderOpenTableFormatInput
{
    /// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
    [JsonPropertyName("icebergInput")]
    public V1beta1CatalogTableSpecForProviderOpenTableFormatInputIcebergInput? IcebergInput { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderPartitionIndex
{
    /// <summary>Name of the partition index.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>Keys for the partition index.</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderPartitionKeys
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Partition Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Datatype of data in the Partition Key.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorColumns
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReferenceSchemaId
{
    /// <summary>Name of the schema registry that contains the schema. Must be provided when schema_name is specified and conflicts with schema_arn.</summary>
    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    /// <summary>ARN of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaArn")]
    public string? SchemaArn { get; set; }

    /// <summary>Name of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }
}

/// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReference
{
    /// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
    [JsonPropertyName("schemaId")]
    public V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReferenceSchemaId? SchemaId { get; set; }

    /// <summary>Unique ID assigned to a version of the schema. Either this or the schema_id has to be provided.</summary>
    [JsonPropertyName("schemaVersionId")]
    public string? SchemaVersionId { get; set; }

    /// <summary>Version number of the schema.</summary>
    [JsonPropertyName("schemaVersionNumber")]
    public double? SchemaVersionNumber { get; set; }
}

/// <summary>Configuration block for serialization and deserialization (&quot;SerDe&quot;) information. See ser_de_info below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSerDeInfo
{
    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Usually the class that implements the SerDe. An example is org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSkewedInfo
{
    /// <summary>List of names of columns that contain skewed values.</summary>
    [JsonPropertyName("skewedColumnNames")]
    public IList<string>? SkewedColumnNames { get; set; }

    /// <summary>List of values that appear so frequently as to be considered skewed.</summary>
    [JsonPropertyName("skewedColumnValueLocationMaps")]
    public IDictionary<string, string>? SkewedColumnValueLocationMaps { get; set; }

    /// <summary>Map of skewed values to the columns that contain them.</summary>
    [JsonPropertyName("skewedColumnValues")]
    public IList<string>? SkewedColumnValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptorSortColumns
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public double? SortOrder { get; set; }
}

/// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderStorageDescriptor
{
    /// <summary>List of locations that point to the path where a Delta table is located.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<string>? AdditionalLocations { get; set; }

    /// <summary>List of reducer grouping columns, clustering columns, and bucketing columns in the table.</summary>
    [JsonPropertyName("bucketColumns")]
    public IList<string>? BucketColumns { get; set; }

    /// <summary>Configuration block for columns in the table. See columns below.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorColumns>? Columns { get; set; }

    /// <summary>Whether the data in the table is compressed.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; set; }

    /// <summary>Input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Must be specified if the table contains any dimension columns.</summary>
    [JsonPropertyName("numberOfBuckets")]
    public double? NumberOfBuckets { get; set; }

    /// <summary>Output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
    [JsonPropertyName("schemaReference")]
    public V1beta1CatalogTableSpecForProviderStorageDescriptorSchemaReference? SchemaReference { get; set; }

    /// <summary>Configuration block for serialization and deserialization (&quot;SerDe&quot;) information. See ser_de_info below.</summary>
    [JsonPropertyName("serDeInfo")]
    public V1beta1CatalogTableSpecForProviderStorageDescriptorSerDeInfo? SerDeInfo { get; set; }

    /// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
    [JsonPropertyName("skewedInfo")]
    public V1beta1CatalogTableSpecForProviderStorageDescriptorSkewedInfo? SkewedInfo { get; set; }

    /// <summary>Configuration block for the sort order of each bucket in the table. See sort_columns below.</summary>
    [JsonPropertyName("sortColumns")]
    public IList<V1beta1CatalogTableSpecForProviderStorageDescriptorSortColumns>? SortColumns { get; set; }

    /// <summary>Whether the table data is stored in subdirectories.</summary>
    [JsonPropertyName("storedAsSubDirectories")]
    public bool? StoredAsSubDirectories { get; set; }
}

/// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderTargetTable
{
    /// <summary>ID of the Data Catalog in which the table resides.</summary>
    [JsonPropertyName("catalogId")]
    public required string CatalogId { get; set; }

    /// <summary>Name of the catalog database that contains the target table.</summary>
    [JsonPropertyName("databaseName")]
    public required string DatabaseName { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region of the target table.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolutionEnum>))]
public enum V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolveEnum>))]
public enum V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate validationConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolutionEnum>))]
public enum V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolveEnum>))]
public enum V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate validationConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderViewDefinitionRepresentations
{
    /// <summary>Parameter that specifies the engine type of a specific representation. Valid values are REDSHIFT, ATHENA, and SPARK.</summary>
    [JsonPropertyName("dialect")]
    public string? Dialect { get; set; }

    /// <summary>Parameter that specifies the version of the engine of a specific representation.</summary>
    [JsonPropertyName("dialectVersion")]
    public string? DialectVersion { get; set; }

    /// <summary>Name of the connection to be used to validate the specific representation of the view.</summary>
    [JsonPropertyName("validationConnection")]
    public string? ValidationConnection { get; set; }

    /// <summary>Reference to a Connection in glue to populate validationConnection.</summary>
    [JsonPropertyName("validationConnectionRef")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionRef? ValidationConnectionRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate validationConnection.</summary>
    [JsonPropertyName("validationConnectionSelector")]
    public V1beta1CatalogTableSpecForProviderViewDefinitionRepresentationsValidationConnectionSelector? ValidationConnectionSelector { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>Structure that contains all the information that defines the view, including the dialect or dialects for the view, and the query. See view_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProviderViewDefinition
{
    /// <summary>Definer of a view in SQL.</summary>
    [JsonPropertyName("definer")]
    public string? Definer { get; set; }

    /// <summary>You can set this flag as true to instruct the engine not to push user-provided operations into the logical plan of the view during query planning. However, setting this flag does not guarantee that the engine will comply. Refer to the engine&apos;s documentation to understand the guarantees provided, if any.</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>Type of the materialized view&apos;s last refresh. Valid values: Full, Incremental.</summary>
    [JsonPropertyName("lastRefreshType")]
    public string? LastRefreshType { get; set; }

    /// <summary>Auto refresh interval in seconds for the materialized view.</summary>
    [JsonPropertyName("refreshSeconds")]
    public double? RefreshSeconds { get; set; }

    /// <summary>List of structures that contains the dialect of the view, and the query that defines the view. See representations below.</summary>
    [JsonPropertyName("representations")]
    public IList<V1beta1CatalogTableSpecForProviderViewDefinitionRepresentations>? Representations { get; set; }

    /// <summary>List of the Apache Iceberg table versions referenced by the materialized view.</summary>
    [JsonPropertyName("subObjectVersionIds")]
    public IList<double>? SubObjectVersionIds { get; set; }

    /// <summary>List of base table ARNs that make up the view.</summary>
    [JsonPropertyName("subObjects")]
    public IList<string>? SubObjects { get; set; }

    /// <summary>ID value that identifies this view&apos;s version. For materialized views, the version ID is the Apache Iceberg table&apos;s snapshot ID.</summary>
    [JsonPropertyName("viewVersionId")]
    public double? ViewVersionId { get; set; }

    /// <summary>Version ID of the Apache Iceberg table.</summary>
    [JsonPropertyName("viewVersionToken")]
    public string? ViewVersionToken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecForProvider
{
    /// <summary>ID of the Glue Catalog and database to create the table in. If omitted, this defaults to the AWS Account ID plus the database name.</summary>
    [JsonPropertyName("catalogId")]
    public required string CatalogId { get; set; }

    /// <summary>Name of the metadata database where the table metadata resides. For Hive compatibility, this must be all lowercase.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1CatalogTableSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>Description of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
    [JsonPropertyName("openTableFormatInput")]
    public V1beta1CatalogTableSpecForProviderOpenTableFormatInput? OpenTableFormatInput { get; set; }

    /// <summary>Owner of the table.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Properties associated with this table, as a map of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration block for a maximum of 3 partition indexes. See partition_index below.</summary>
    [JsonPropertyName("partitionIndex")]
    public IList<V1beta1CatalogTableSpecForProviderPartitionIndex>? PartitionIndex { get; set; }

    /// <summary>Configuration block of columns by which the table is partitioned. Only primitive types are supported as partition keys. See partition_keys below.</summary>
    [JsonPropertyName("partitionKeys")]
    public IList<V1beta1CatalogTableSpecForProviderPartitionKeys>? PartitionKeys { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Retention time for this table.</summary>
    [JsonPropertyName("retention")]
    public double? Retention { get; set; }

    /// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1CatalogTableSpecForProviderStorageDescriptor? StorageDescriptor { get; set; }

    /// <summary>Type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.). While optional, some Athena DDL queries such as ALTER TABLE and SHOW CREATE TABLE will fail if this argument is empty.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
    [JsonPropertyName("targetTable")]
    public V1beta1CatalogTableSpecForProviderTargetTable? TargetTable { get; set; }

    /// <summary>Structure that contains all the information that defines the view, including the dialect or dialects for the view, and the query. See view_definition below.</summary>
    [JsonPropertyName("viewDefinition")]
    public V1beta1CatalogTableSpecForProviderViewDefinition? ViewDefinition { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields
{
    /// <summary>Unique identifier assigned to this partition field within the Iceberg table&apos;s partition specification.</summary>
    [JsonPropertyName("fieldId")]
    public double? FieldId { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Identifier of the source field from the table schema that this partition field is based on.</summary>
    [JsonPropertyName("sourceId")]
    public double? SourceId { get; set; }

    /// <summary>Transformation function applied to the source field to create the partition. Common values: identity, bucket, truncate, year, month, day, hour.</summary>
    [JsonPropertyName("transform")]
    public string? Transform { get; set; }
}

/// <summary>Partitioning specification that defines how the Iceberg table data will be organized and partitioned for optimal query performance. See partition_spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields>? Fields { get; set; }

    /// <summary>Unique identifier for this partition specification within the Iceberg table&apos;s metadata history.</summary>
    [JsonPropertyName("specId")]
    public double? SpecId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSchemaFields
{
    /// <summary>Documentation or description text that provides additional context about the purpose and usage of this field. Length between 0 and 255 characters.</summary>
    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    /// <summary>Unique identifier assigned to this field within the Iceberg table schema, used for schema evolution and field tracking.</summary>
    [JsonPropertyName("id")]
    public double? Id { get; set; }

    /// <summary>Default value as JSON used to populate the field&apos;s value for all records that were written before the field was added to the schema.</summary>
    [JsonPropertyName("initialDefault")]
    public string? InitialDefault { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether this field is required (non-nullable) or optional (nullable) in the table schema.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Default value as JSON used to populate the field&apos;s value for any records written after the field was added to the schema, if the writer does not supply the field&apos;s value.</summary>
    [JsonPropertyName("writeDefault")]
    public string? WriteDefault { get; set; }
}

/// <summary>Schema definition that specifies the structure, field types, and metadata for the Iceberg table. See schema below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSchema
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSchemaFields>? Fields { get; set; }

    /// <summary>List of field identifiers that uniquely identify records in the table, used for row-level operations and deduplication.</summary>
    [JsonPropertyName("identifierFieldIds")]
    public IList<double>? IdentifierFieldIds { get; set; }

    /// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
    [JsonPropertyName("schemaId")]
    public double? SchemaId { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields
{
    /// <summary>Sort direction for this field. Valid values: asc, desc.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Ordering behavior for null values in this field. Valid values: nulls-first, nulls-last.</summary>
    [JsonPropertyName("nullOrder")]
    public string? NullOrder { get; set; }

    /// <summary>Identifier of the source field from the table schema that this partition field is based on.</summary>
    [JsonPropertyName("sourceId")]
    public double? SourceId { get; set; }

    /// <summary>Transformation function applied to the source field to create the partition. Common values: identity, bucket, truncate, year, month, day, hour.</summary>
    [JsonPropertyName("transform")]
    public string? Transform { get; set; }
}

/// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrder
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields>? Fields { get; set; }

    /// <summary>Unique identifier for this sort order specification within the Iceberg table&apos;s metadata.</summary>
    [JsonPropertyName("orderId")]
    public double? OrderId { get; set; }
}

/// <summary>Configuration parameters, including table properties and metadata specifications. See iceberg_table_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInput
{
    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Partitioning specification that defines how the Iceberg table data will be organized and partitioned for optimal query performance. See partition_spec below.</summary>
    [JsonPropertyName("partitionSpec")]
    public V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec? PartitionSpec { get; set; }

    /// <summary>Key-value pairs of additional table properties and configuration settings for the Iceberg table.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Schema definition that specifies the structure, field types, and metadata for the Iceberg table. See schema below.</summary>
    [JsonPropertyName("schema")]
    public V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSchema? Schema { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrder? SortOrder { get; set; }
}

/// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInput
{
    /// <summary>Configuration parameters, including table properties and metadata specifications. See iceberg_table_input below.</summary>
    [JsonPropertyName("icebergTableInput")]
    public V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInputIcebergTableInput? IcebergTableInput { get; set; }

    /// <summary>Required metadata operation. Can only be set to CREATE.</summary>
    [JsonPropertyName("metadataOperation")]
    public string? MetadataOperation { get; set; }

    /// <summary>Table version for the Iceberg table. Defaults to 2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderOpenTableFormatInput
{
    /// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
    [JsonPropertyName("icebergInput")]
    public V1beta1CatalogTableSpecInitProviderOpenTableFormatInputIcebergInput? IcebergInput { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderPartitionIndex
{
    /// <summary>Name of the partition index.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>Keys for the partition index.</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderPartitionKeys
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Partition Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Datatype of data in the Partition Key.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorColumns
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReferenceSchemaId
{
    /// <summary>Name of the schema registry that contains the schema. Must be provided when schema_name is specified and conflicts with schema_arn.</summary>
    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    /// <summary>ARN of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaArn")]
    public string? SchemaArn { get; set; }

    /// <summary>Name of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }
}

/// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReference
{
    /// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
    [JsonPropertyName("schemaId")]
    public V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReferenceSchemaId? SchemaId { get; set; }

    /// <summary>Unique ID assigned to a version of the schema. Either this or the schema_id has to be provided.</summary>
    [JsonPropertyName("schemaVersionId")]
    public string? SchemaVersionId { get; set; }

    /// <summary>Version number of the schema.</summary>
    [JsonPropertyName("schemaVersionNumber")]
    public double? SchemaVersionNumber { get; set; }
}

/// <summary>Configuration block for serialization and deserialization (&quot;SerDe&quot;) information. See ser_de_info below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSerDeInfo
{
    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Usually the class that implements the SerDe. An example is org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSkewedInfo
{
    /// <summary>List of names of columns that contain skewed values.</summary>
    [JsonPropertyName("skewedColumnNames")]
    public IList<string>? SkewedColumnNames { get; set; }

    /// <summary>List of values that appear so frequently as to be considered skewed.</summary>
    [JsonPropertyName("skewedColumnValueLocationMaps")]
    public IDictionary<string, string>? SkewedColumnValueLocationMaps { get; set; }

    /// <summary>Map of skewed values to the columns that contain them.</summary>
    [JsonPropertyName("skewedColumnValues")]
    public IList<string>? SkewedColumnValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptorSortColumns
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public double? SortOrder { get; set; }
}

/// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderStorageDescriptor
{
    /// <summary>List of locations that point to the path where a Delta table is located.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<string>? AdditionalLocations { get; set; }

    /// <summary>List of reducer grouping columns, clustering columns, and bucketing columns in the table.</summary>
    [JsonPropertyName("bucketColumns")]
    public IList<string>? BucketColumns { get; set; }

    /// <summary>Configuration block for columns in the table. See columns below.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorColumns>? Columns { get; set; }

    /// <summary>Whether the data in the table is compressed.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; set; }

    /// <summary>Input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Must be specified if the table contains any dimension columns.</summary>
    [JsonPropertyName("numberOfBuckets")]
    public double? NumberOfBuckets { get; set; }

    /// <summary>Output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
    [JsonPropertyName("schemaReference")]
    public V1beta1CatalogTableSpecInitProviderStorageDescriptorSchemaReference? SchemaReference { get; set; }

    /// <summary>Configuration block for serialization and deserialization (&quot;SerDe&quot;) information. See ser_de_info below.</summary>
    [JsonPropertyName("serDeInfo")]
    public V1beta1CatalogTableSpecInitProviderStorageDescriptorSerDeInfo? SerDeInfo { get; set; }

    /// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
    [JsonPropertyName("skewedInfo")]
    public V1beta1CatalogTableSpecInitProviderStorageDescriptorSkewedInfo? SkewedInfo { get; set; }

    /// <summary>Configuration block for the sort order of each bucket in the table. See sort_columns below.</summary>
    [JsonPropertyName("sortColumns")]
    public IList<V1beta1CatalogTableSpecInitProviderStorageDescriptorSortColumns>? SortColumns { get; set; }

    /// <summary>Whether the table data is stored in subdirectories.</summary>
    [JsonPropertyName("storedAsSubDirectories")]
    public bool? StoredAsSubDirectories { get; set; }
}

/// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderTargetTable
{
    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolutionEnum>))]
public enum V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolveEnum>))]
public enum V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate validationConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolutionEnum>))]
public enum V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolveEnum>))]
public enum V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate validationConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentations
{
    /// <summary>Parameter that specifies the engine type of a specific representation. Valid values are REDSHIFT, ATHENA, and SPARK.</summary>
    [JsonPropertyName("dialect")]
    public string? Dialect { get; set; }

    /// <summary>Parameter that specifies the version of the engine of a specific representation.</summary>
    [JsonPropertyName("dialectVersion")]
    public string? DialectVersion { get; set; }

    /// <summary>Name of the connection to be used to validate the specific representation of the view.</summary>
    [JsonPropertyName("validationConnection")]
    public string? ValidationConnection { get; set; }

    /// <summary>Reference to a Connection in glue to populate validationConnection.</summary>
    [JsonPropertyName("validationConnectionRef")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionRef? ValidationConnectionRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate validationConnection.</summary>
    [JsonPropertyName("validationConnectionSelector")]
    public V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentationsValidationConnectionSelector? ValidationConnectionSelector { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>Structure that contains all the information that defines the view, including the dialect or dialects for the view, and the query. See view_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProviderViewDefinition
{
    /// <summary>Definer of a view in SQL.</summary>
    [JsonPropertyName("definer")]
    public string? Definer { get; set; }

    /// <summary>You can set this flag as true to instruct the engine not to push user-provided operations into the logical plan of the view during query planning. However, setting this flag does not guarantee that the engine will comply. Refer to the engine&apos;s documentation to understand the guarantees provided, if any.</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>Type of the materialized view&apos;s last refresh. Valid values: Full, Incremental.</summary>
    [JsonPropertyName("lastRefreshType")]
    public string? LastRefreshType { get; set; }

    /// <summary>Auto refresh interval in seconds for the materialized view.</summary>
    [JsonPropertyName("refreshSeconds")]
    public double? RefreshSeconds { get; set; }

    /// <summary>List of structures that contains the dialect of the view, and the query that defines the view. See representations below.</summary>
    [JsonPropertyName("representations")]
    public IList<V1beta1CatalogTableSpecInitProviderViewDefinitionRepresentations>? Representations { get; set; }

    /// <summary>List of the Apache Iceberg table versions referenced by the materialized view.</summary>
    [JsonPropertyName("subObjectVersionIds")]
    public IList<double>? SubObjectVersionIds { get; set; }

    /// <summary>List of base table ARNs that make up the view.</summary>
    [JsonPropertyName("subObjects")]
    public IList<string>? SubObjects { get; set; }

    /// <summary>ID value that identifies this view&apos;s version. For materialized views, the version ID is the Apache Iceberg table&apos;s snapshot ID.</summary>
    [JsonPropertyName("viewVersionId")]
    public double? ViewVersionId { get; set; }

    /// <summary>Version ID of the Apache Iceberg table.</summary>
    [JsonPropertyName("viewVersionToken")]
    public string? ViewVersionToken { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecInitProvider
{
    /// <summary>Description of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
    [JsonPropertyName("openTableFormatInput")]
    public V1beta1CatalogTableSpecInitProviderOpenTableFormatInput? OpenTableFormatInput { get; set; }

    /// <summary>Owner of the table.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Properties associated with this table, as a map of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration block for a maximum of 3 partition indexes. See partition_index below.</summary>
    [JsonPropertyName("partitionIndex")]
    public IList<V1beta1CatalogTableSpecInitProviderPartitionIndex>? PartitionIndex { get; set; }

    /// <summary>Configuration block of columns by which the table is partitioned. Only primitive types are supported as partition keys. See partition_keys below.</summary>
    [JsonPropertyName("partitionKeys")]
    public IList<V1beta1CatalogTableSpecInitProviderPartitionKeys>? PartitionKeys { get; set; }

    /// <summary>Retention time for this table.</summary>
    [JsonPropertyName("retention")]
    public double? Retention { get; set; }

    /// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1CatalogTableSpecInitProviderStorageDescriptor? StorageDescriptor { get; set; }

    /// <summary>Type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.). While optional, some Athena DDL queries such as ALTER TABLE and SHOW CREATE TABLE will fail if this argument is empty.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
    [JsonPropertyName("targetTable")]
    public V1beta1CatalogTableSpecInitProviderTargetTable? TargetTable { get; set; }

    /// <summary>Structure that contains all the information that defines the view, including the dialect or dialects for the view, and the query. See view_definition below.</summary>
    [JsonPropertyName("viewDefinition")]
    public V1beta1CatalogTableSpecInitProviderViewDefinition? ViewDefinition { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CatalogTableSpecManagementPoliciesEnum>))]
public enum V1beta1CatalogTableSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CatalogTableSpec defines the desired state of CatalogTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1CatalogTableSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CatalogTableSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CatalogTableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CatalogTableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CatalogTableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields
{
    /// <summary>Unique identifier assigned to this partition field within the Iceberg table&apos;s partition specification.</summary>
    [JsonPropertyName("fieldId")]
    public double? FieldId { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Identifier of the source field from the table schema that this partition field is based on.</summary>
    [JsonPropertyName("sourceId")]
    public double? SourceId { get; set; }

    /// <summary>Transformation function applied to the source field to create the partition. Common values: identity, bucket, truncate, year, month, day, hour.</summary>
    [JsonPropertyName("transform")]
    public string? Transform { get; set; }
}

/// <summary>Partitioning specification that defines how the Iceberg table data will be organized and partitioned for optimal query performance. See partition_spec below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields>? Fields { get; set; }

    /// <summary>Unique identifier for this partition specification within the Iceberg table&apos;s metadata history.</summary>
    [JsonPropertyName("specId")]
    public double? SpecId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSchemaFields
{
    /// <summary>Documentation or description text that provides additional context about the purpose and usage of this field. Length between 0 and 255 characters.</summary>
    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    /// <summary>Unique identifier assigned to this field within the Iceberg table schema, used for schema evolution and field tracking.</summary>
    [JsonPropertyName("id")]
    public double? Id { get; set; }

    /// <summary>Default value as JSON used to populate the field&apos;s value for all records that were written before the field was added to the schema.</summary>
    [JsonPropertyName("initialDefault")]
    public string? InitialDefault { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether this field is required (non-nullable) or optional (nullable) in the table schema.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Default value as JSON used to populate the field&apos;s value for any records written after the field was added to the schema, if the writer does not supply the field&apos;s value.</summary>
    [JsonPropertyName("writeDefault")]
    public string? WriteDefault { get; set; }
}

/// <summary>Schema definition that specifies the structure, field types, and metadata for the Iceberg table. See schema below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSchema
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSchemaFields>? Fields { get; set; }

    /// <summary>List of field identifiers that uniquely identify records in the table, used for row-level operations and deduplication.</summary>
    [JsonPropertyName("identifierFieldIds")]
    public IList<double>? IdentifierFieldIds { get; set; }

    /// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
    [JsonPropertyName("schemaId")]
    public double? SchemaId { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields
{
    /// <summary>Sort direction for this field. Valid values: asc, desc.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Ordering behavior for null values in this field. Valid values: nulls-first, nulls-last.</summary>
    [JsonPropertyName("nullOrder")]
    public string? NullOrder { get; set; }

    /// <summary>Identifier of the source field from the table schema that this partition field is based on.</summary>
    [JsonPropertyName("sourceId")]
    public double? SourceId { get; set; }

    /// <summary>Transformation function applied to the source field to create the partition. Common values: identity, bucket, truncate, year, month, day, hour.</summary>
    [JsonPropertyName("transform")]
    public string? Transform { get; set; }
}

/// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrder
{
    /// <summary>List of partition fields that define how the table data should be partitioned. See partition_spec.fields below.</summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrderFields>? Fields { get; set; }

    /// <summary>Unique identifier for this sort order specification within the Iceberg table&apos;s metadata.</summary>
    [JsonPropertyName("orderId")]
    public double? OrderId { get; set; }
}

/// <summary>Configuration parameters, including table properties and metadata specifications. See iceberg_table_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInput
{
    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Partitioning specification that defines how the Iceberg table data will be organized and partitioned for optimal query performance. See partition_spec below.</summary>
    [JsonPropertyName("partitionSpec")]
    public V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpec? PartitionSpec { get; set; }

    /// <summary>Key-value pairs of additional table properties and configuration settings for the Iceberg table.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Schema definition that specifies the structure, field types, and metadata for the Iceberg table. See schema below.</summary>
    [JsonPropertyName("schema")]
    public V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSchema? Schema { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInputSortOrder? SortOrder { get; set; }
}

/// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInput
{
    /// <summary>Configuration parameters, including table properties and metadata specifications. See iceberg_table_input below.</summary>
    [JsonPropertyName("icebergTableInput")]
    public V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInputIcebergTableInput? IcebergTableInput { get; set; }

    /// <summary>Required metadata operation. Can only be set to CREATE.</summary>
    [JsonPropertyName("metadataOperation")]
    public string? MetadataOperation { get; set; }

    /// <summary>Table version for the Iceberg table. Defaults to 2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderOpenTableFormatInput
{
    /// <summary>Configuration block for iceberg table config. See iceberg_input below.</summary>
    [JsonPropertyName("icebergInput")]
    public V1beta1CatalogTableStatusAtProviderOpenTableFormatInputIcebergInput? IcebergInput { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderPartitionIndex
{
    /// <summary>Name of the partition index.</summary>
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>Status of the partition index.</summary>
    [JsonPropertyName("indexStatus")]
    public string? IndexStatus { get; set; }

    /// <summary>Keys for the partition index.</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderPartitionKeys
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the Partition Key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Map of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Datatype of data in the Partition Key.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorColumns
{
    /// <summary>Free-form text comment.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Root type of the schema structure. Valid value: struct.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReferenceSchemaId
{
    /// <summary>Name of the schema registry that contains the schema. Must be provided when schema_name is specified and conflicts with schema_arn.</summary>
    [JsonPropertyName("registryName")]
    public string? RegistryName { get; set; }

    /// <summary>ARN of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaArn")]
    public string? SchemaArn { get; set; }

    /// <summary>Name of the schema. One of schema_arn or schema_name has to be provided.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }
}

/// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReference
{
    /// <summary>Unique identifier for this schema version within the Iceberg table&apos;s schema evolution history.</summary>
    [JsonPropertyName("schemaId")]
    public V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReferenceSchemaId? SchemaId { get; set; }

    /// <summary>Unique ID assigned to a version of the schema. Either this or the schema_id has to be provided.</summary>
    [JsonPropertyName("schemaVersionId")]
    public string? SchemaVersionId { get; set; }

    /// <summary>Version number of the schema.</summary>
    [JsonPropertyName("schemaVersionNumber")]
    public double? SchemaVersionNumber { get; set; }
}

/// <summary>Configuration block for serialization and deserialization (&quot;SerDe&quot;) information. See ser_de_info below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSerDeInfo
{
    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Usually the class that implements the SerDe. An example is org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.</summary>
    [JsonPropertyName("serializationLibrary")]
    public string? SerializationLibrary { get; set; }
}

/// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSkewedInfo
{
    /// <summary>List of names of columns that contain skewed values.</summary>
    [JsonPropertyName("skewedColumnNames")]
    public IList<string>? SkewedColumnNames { get; set; }

    /// <summary>List of values that appear so frequently as to be considered skewed.</summary>
    [JsonPropertyName("skewedColumnValueLocationMaps")]
    public IDictionary<string, string>? SkewedColumnValueLocationMaps { get; set; }

    /// <summary>Map of skewed values to the columns that contain them.</summary>
    [JsonPropertyName("skewedColumnValues")]
    public IList<string>? SkewedColumnValues { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptorSortColumns
{
    /// <summary>Name of the column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>Whether the column is sorted in ascending (1) or descending order (0).</summary>
    [JsonPropertyName("sortOrder")]
    public double? SortOrder { get; set; }
}

/// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderStorageDescriptor
{
    /// <summary>List of locations that point to the path where a Delta table is located.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<string>? AdditionalLocations { get; set; }

    /// <summary>List of reducer grouping columns, clustering columns, and bucketing columns in the table.</summary>
    [JsonPropertyName("bucketColumns")]
    public IList<string>? BucketColumns { get; set; }

    /// <summary>Configuration block for columns in the table. See columns below.</summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorColumns>? Columns { get; set; }

    /// <summary>Whether the data in the table is compressed.</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; set; }

    /// <summary>Input format: SequenceFileInputFormat (binary), or TextInputFormat, or a custom format.</summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>Physical location of the table. By default this takes the form of the warehouse location, followed by the database location in the warehouse, followed by the table name.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Must be specified if the table contains any dimension columns.</summary>
    [JsonPropertyName("numberOfBuckets")]
    public double? NumberOfBuckets { get; set; }

    /// <summary>Output format: SequenceFileOutputFormat (binary), or IgnoreKeyTextOutputFormat, or a custom format.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>User-supplied properties in key-value form.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Object that references a schema stored in the AWS Glue Schema Registry. When creating a table, you can pass an empty list of columns for the schema, and instead use a schema reference. See Schema Reference below.</summary>
    [JsonPropertyName("schemaReference")]
    public V1beta1CatalogTableStatusAtProviderStorageDescriptorSchemaReference? SchemaReference { get; set; }

    /// <summary>Configuration block for serialization and deserialization (&quot;SerDe&quot;) information. See ser_de_info below.</summary>
    [JsonPropertyName("serDeInfo")]
    public V1beta1CatalogTableStatusAtProviderStorageDescriptorSerDeInfo? SerDeInfo { get; set; }

    /// <summary>Configuration block with information about values that appear very frequently in a column (skewed values). See skewed_info below.</summary>
    [JsonPropertyName("skewedInfo")]
    public V1beta1CatalogTableStatusAtProviderStorageDescriptorSkewedInfo? SkewedInfo { get; set; }

    /// <summary>Configuration block for the sort order of each bucket in the table. See sort_columns below.</summary>
    [JsonPropertyName("sortColumns")]
    public IList<V1beta1CatalogTableStatusAtProviderStorageDescriptorSortColumns>? SortColumns { get; set; }

    /// <summary>Whether the table data is stored in subdirectories.</summary>
    [JsonPropertyName("storedAsSubDirectories")]
    public bool? StoredAsSubDirectories { get; set; }
}

/// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderTargetTable
{
    /// <summary>ID of the Data Catalog in which the table resides.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the catalog database that contains the target table.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the target table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region of the target table.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderViewDefinitionRepresentations
{
    /// <summary>Parameter that specifies the engine type of a specific representation. Valid values are REDSHIFT, ATHENA, and SPARK.</summary>
    [JsonPropertyName("dialect")]
    public string? Dialect { get; set; }

    /// <summary>Parameter that specifies the version of the engine of a specific representation.</summary>
    [JsonPropertyName("dialectVersion")]
    public string? DialectVersion { get; set; }

    /// <summary>Name of the connection to be used to validate the specific representation of the view.</summary>
    [JsonPropertyName("validationConnection")]
    public string? ValidationConnection { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>Structure that contains all the information that defines the view, including the dialect or dialects for the view, and the query. See view_definition below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProviderViewDefinition
{
    /// <summary>Definer of a view in SQL.</summary>
    [JsonPropertyName("definer")]
    public string? Definer { get; set; }

    /// <summary>You can set this flag as true to instruct the engine not to push user-provided operations into the logical plan of the view during query planning. However, setting this flag does not guarantee that the engine will comply. Refer to the engine&apos;s documentation to understand the guarantees provided, if any.</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>Type of the materialized view&apos;s last refresh. Valid values: Full, Incremental.</summary>
    [JsonPropertyName("lastRefreshType")]
    public string? LastRefreshType { get; set; }

    /// <summary>Auto refresh interval in seconds for the materialized view.</summary>
    [JsonPropertyName("refreshSeconds")]
    public double? RefreshSeconds { get; set; }

    /// <summary>List of structures that contains the dialect of the view, and the query that defines the view. See representations below.</summary>
    [JsonPropertyName("representations")]
    public IList<V1beta1CatalogTableStatusAtProviderViewDefinitionRepresentations>? Representations { get; set; }

    /// <summary>List of the Apache Iceberg table versions referenced by the materialized view.</summary>
    [JsonPropertyName("subObjectVersionIds")]
    public IList<double>? SubObjectVersionIds { get; set; }

    /// <summary>List of base table ARNs that make up the view.</summary>
    [JsonPropertyName("subObjects")]
    public IList<string>? SubObjects { get; set; }

    /// <summary>ID value that identifies this view&apos;s version. For materialized views, the version ID is the Apache Iceberg table&apos;s snapshot ID.</summary>
    [JsonPropertyName("viewVersionId")]
    public double? ViewVersionId { get; set; }

    /// <summary>Version ID of the Apache Iceberg table.</summary>
    [JsonPropertyName("viewVersionToken")]
    public string? ViewVersionToken { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusAtProvider
{
    /// <summary>ARN of the Glue Table.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID of the Glue Catalog and database to create the table in. If omitted, this defaults to the AWS Account ID plus the database name.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the metadata database where the table metadata resides. For Hive compatibility, this must be all lowercase.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Description of the table.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Unique identifier assigned to this field within the Iceberg table schema, used for schema evolution and field tracking.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for open table formats. See open_table_format_input below.</summary>
    [JsonPropertyName("openTableFormatInput")]
    public V1beta1CatalogTableStatusAtProviderOpenTableFormatInput? OpenTableFormatInput { get; set; }

    /// <summary>Owner of the table.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Properties associated with this table, as a map of key-value pairs.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Configuration block for a maximum of 3 partition indexes. See partition_index below.</summary>
    [JsonPropertyName("partitionIndex")]
    public IList<V1beta1CatalogTableStatusAtProviderPartitionIndex>? PartitionIndex { get; set; }

    /// <summary>Configuration block of columns by which the table is partitioned. Only primitive types are supported as partition keys. See partition_keys below.</summary>
    [JsonPropertyName("partitionKeys")]
    public IList<V1beta1CatalogTableStatusAtProviderPartitionKeys>? PartitionKeys { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Retention time for this table.</summary>
    [JsonPropertyName("retention")]
    public double? Retention { get; set; }

    /// <summary>Configuration block for information about the physical storage of this table. For more information, refer to the Glue Developer Guide. See storage_descriptor below.</summary>
    [JsonPropertyName("storageDescriptor")]
    public V1beta1CatalogTableStatusAtProviderStorageDescriptor? StorageDescriptor { get; set; }

    /// <summary>Type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.). While optional, some Athena DDL queries such as ALTER TABLE and SHOW CREATE TABLE will fail if this argument is empty.</summary>
    [JsonPropertyName("tableType")]
    public string? TableType { get; set; }

    /// <summary>Configuration block of a target table for resource linking. See target_table below.</summary>
    [JsonPropertyName("targetTable")]
    public V1beta1CatalogTableStatusAtProviderTargetTable? TargetTable { get; set; }

    /// <summary>Structure that contains all the information that defines the view, including the dialect or dialects for the view, and the query. See view_definition below.</summary>
    [JsonPropertyName("viewDefinition")]
    public V1beta1CatalogTableStatusAtProviderViewDefinition? ViewDefinition { get; set; }

    /// <summary>If the table is a view, the expanded text of the view; otherwise null.</summary>
    [JsonPropertyName("viewExpandedText")]
    public string? ViewExpandedText { get; set; }

    /// <summary>If the table is a view, the original text of the view; otherwise null.</summary>
    [JsonPropertyName("viewOriginalText")]
    public string? ViewOriginalText { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>CatalogTableStatus defines the observed state of CatalogTable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CatalogTableStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CatalogTableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CatalogTableStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CatalogTable is the Schema for the CatalogTables API. Provides a Glue Catalog Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CatalogTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CatalogTableSpec>, IStatus<V1beta1CatalogTableStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CatalogTable";
    public const string KubeGroup = "glue.aws.m.upbound.io";
    public const string KubePluralName = "catalogtables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CatalogTable";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CatalogTableSpec defines the desired state of CatalogTable</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CatalogTableSpec Spec { get; set; }

    /// <summary>CatalogTableStatus defines the observed state of CatalogTable.</summary>
    [JsonPropertyName("status")]
    public V1beta1CatalogTableStatus? Status { get; set; }
}