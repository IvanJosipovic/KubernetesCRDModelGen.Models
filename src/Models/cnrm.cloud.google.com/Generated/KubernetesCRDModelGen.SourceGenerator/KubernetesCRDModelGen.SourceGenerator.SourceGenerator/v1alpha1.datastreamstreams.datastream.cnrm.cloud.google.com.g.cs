#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamStreamList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DatastreamStream>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamStreamList";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamstreams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datastream.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatastreamStreamList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DatastreamStream objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DatastreamStream> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The MySQL data type. Full data types list can be found here:
    /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables
{
    /// <summary>MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabases
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public required string Database { get; set; }

    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>MySQL data source objects to avoid backfilling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjects
{
    /// <summary>MySQL databases on the server.</summary>
    [JsonPropertyName("mysqlDatabases")]
    public required IList<V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjectsMysqlDatabases> MysqlDatabases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The Oracle data type. Full data types list can be found here:
    /// https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column encoding.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTables
{
    /// <summary>Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemas
{
    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>Schema name.</summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; set; }
}

/// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjects
{
    /// <summary>Oracle schemas/databases in the database server.</summary>
    [JsonPropertyName("oracleSchemas")]
    public required IList<V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjectsOracleSchemas> OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas
{
    /// <summary>Tables in the schema.</summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; set; }
}

/// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjects
{
    /// <summary>PostgreSQL schemas on the server.</summary>
    [JsonPropertyName("postgresqlSchemas")]
    public required IList<V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas> PostgresqlSchemas { get; set; }
}

/// <summary>Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecBackfillAll
{
    /// <summary>MySQL data source objects to avoid backfilling.</summary>
    [JsonPropertyName("mysqlExcludedObjects")]
    public V1alpha1DatastreamStreamSpecBackfillAllMysqlExcludedObjects? MysqlExcludedObjects { get; set; }

    /// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
    [JsonPropertyName("oracleExcludedObjects")]
    public V1alpha1DatastreamStreamSpecBackfillAllOracleExcludedObjects? OracleExcludedObjects { get; set; }

    /// <summary>PostgreSQL data source objects to avoid backfilling.</summary>
    [JsonPropertyName("postgresqlExcludedObjects")]
    public V1alpha1DatastreamStreamSpecBackfillAllPostgresqlExcludedObjects? PostgresqlExcludedObjects { get; set; }
}

/// <summary>A single target dataset to which all data will be streamed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSingleTargetDataset
{
    /// <summary>
    /// Dataset ID in the format projects/{project}/datasets/{dataset_id} or
    /// {project}:{dataset_id}.
    /// </summary>
    [JsonPropertyName("datasetId")]
    public required string DatasetId { get; set; }
}

/// <summary>Dataset template used for dynamic dataset creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate
{
    /// <summary>
    /// If supplied, every created dataset will have its name prefixed by the provided value.
    /// The prefix and name will be separated by an underscore. i.e. _.
    /// </summary>
    [JsonPropertyName("datasetIdPrefix")]
    public string? DatasetIdPrefix { get; set; }

    /// <summary>
    /// Immutable. Describes the Cloud KMS encryption key that will be used to protect destination BigQuery
    /// table. The BigQuery Service Account associated with your project requires access to this
    /// encryption key. i.e. projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{cryptoKey}.
    /// See https://cloud.google.com/bigquery/docs/customer-managed-encryption for more information.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See https://cloud.google.com/bigquery/docs/locations for supported locations.
    /// </summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }
}

/// <summary>Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets
{
    /// <summary>Dataset template used for dynamic dataset creation.</summary>
    [JsonPropertyName("datasetTemplate")]
    public required V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate DatasetTemplate { get; set; }
}

/// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfig
{
    /// <summary>
    /// The guaranteed data freshness (in seconds) when querying tables created by the stream.
    /// Editing this field will only affect new tables created in the future, but existing tables
    /// will not be impacted. Lower values mean that queries will return fresher data, but may result in higher cost.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;. Defaults to 900s.
    /// </summary>
    [JsonPropertyName("dataFreshness")]
    public string? DataFreshness { get; set; }

    /// <summary>A single target dataset to which all data will be streamed.</summary>
    [JsonPropertyName("singleTargetDataset")]
    public V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSingleTargetDataset? SingleTargetDataset { get; set; }

    /// <summary>Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.</summary>
    [JsonPropertyName("sourceHierarchyDatasets")]
    public V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets? SourceHierarchyDatasets { get; set; }
}

/// <summary>JSON file format configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfigGcsDestinationConfigJsonFileFormat
{
    /// <summary>Compression of the loaded JSON file. Possible values: [&quot;NO_COMPRESSION&quot;, &quot;GZIP&quot;].</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>The schema file format along JSON data files. Possible values: [&quot;NO_SCHEMA_FILE&quot;, &quot;AVRO_SCHEMA_FILE&quot;].</summary>
    [JsonPropertyName("schemaFileFormat")]
    public string? SchemaFileFormat { get; set; }
}

/// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfigGcsDestinationConfig
{
    /// <summary>AVRO file format configuration.</summary>
    [JsonPropertyName("avroFileFormat")]
    public JsonNode? AvroFileFormat { get; set; }

    /// <summary>
    /// The maximum duration for which new events are added before a file is closed and a new file is created.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;. Defaults to 900s.
    /// </summary>
    [JsonPropertyName("fileRotationInterval")]
    public string? FileRotationInterval { get; set; }

    /// <summary>The maximum file size to be saved in the bucket.</summary>
    [JsonPropertyName("fileRotationMb")]
    public int? FileRotationMb { get; set; }

    /// <summary>JSON file format configuration.</summary>
    [JsonPropertyName("jsonFileFormat")]
    public V1alpha1DatastreamStreamSpecDestinationConfigGcsDestinationConfigJsonFileFormat? JsonFileFormat { get; set; }

    /// <summary>Path inside the Cloud Storage bucket to write data to.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Destination connection profile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecDestinationConfig
{
    /// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
    [JsonPropertyName("bigqueryDestinationConfig")]
    public V1alpha1DatastreamStreamSpecDestinationConfigBigqueryDestinationConfig? BigqueryDestinationConfig { get; set; }

    /// <summary>Immutable. Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}.</summary>
    [JsonPropertyName("destinationConnectionProfile")]
    public required string DestinationConnectionProfile { get; set; }

    /// <summary>A configuration for how data should be loaded to Cloud Storage.</summary>
    [JsonPropertyName("gcsDestinationConfig")]
    public V1alpha1DatastreamStreamSpecDestinationConfigGcsDestinationConfig? GcsDestinationConfig { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecProjectRef
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
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The MySQL data type. Full data types list can be found here:
    /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public required string Database { get; set; }

    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>MySQL objects to exclude from the stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjects
{
    /// <summary>MySQL databases on the server.</summary>
    [JsonPropertyName("mysqlDatabases")]
    public required IList<V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases> MysqlDatabases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The MySQL data type. Full data types list can be found here:
    /// https://dev.mysql.com/doc/refman/8.0/en/data-types.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases
{
    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public required string Database { get; set; }

    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>MySQL objects to retrieve from the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjects
{
    /// <summary>MySQL databases on the server.</summary>
    [JsonPropertyName("mysqlDatabases")]
    public required IList<V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases> MysqlDatabases { get; set; }
}

/// <summary>MySQL data source configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfig
{
    /// <summary>MySQL objects to exclude from the stream.</summary>
    [JsonPropertyName("excludeObjects")]
    public V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>MySQL objects to retrieve from the source.</summary>
    [JsonPropertyName("includeObjects")]
    public V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>
    /// Maximum number of concurrent backfill tasks. The number should be non negative.
    /// If not set (or set to 0), the system&apos;s default value will be used.
    /// </summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public int? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>
    /// Maximum number of concurrent CDC tasks. The number should be non negative.
    /// If not set (or set to 0), the system&apos;s default value will be used.
    /// </summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public int? MaxConcurrentCdcTasks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The Oracle data type. Full data types list can be found here:
    /// https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column encoding.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables
{
    /// <summary>Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas
{
    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>Schema name.</summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; set; }
}

/// <summary>Oracle objects to exclude from the stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjects
{
    /// <summary>Oracle schemas/databases in the database server.</summary>
    [JsonPropertyName("oracleSchemas")]
    public required IList<V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas> OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The Oracle data type. Full data types list can be found here:
    /// https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf/Data-Types.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column encoding.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables
{
    /// <summary>Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas
{
    /// <summary>Tables in the database.</summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>Schema name.</summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; set; }
}

/// <summary>Oracle objects to retrieve from the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjects
{
    /// <summary>Oracle schemas/databases in the database server.</summary>
    [JsonPropertyName("oracleSchemas")]
    public required IList<V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas> OracleSchemas { get; set; }
}

/// <summary>MySQL data source configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfig
{
    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("dropLargeObjects")]
    public JsonNode? DropLargeObjects { get; set; }

    /// <summary>Oracle objects to exclude from the stream.</summary>
    [JsonPropertyName("excludeObjects")]
    public V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>Oracle objects to retrieve from the source.</summary>
    [JsonPropertyName("includeObjects")]
    public V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>
    /// Maximum number of concurrent backfill tasks. The number should be non negative.
    /// If not set (or set to 0), the system&apos;s default value will be used.
    /// </summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public int? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>
    /// Maximum number of concurrent CDC tasks. The number should be non negative.
    /// If not set (or set to 0), the system&apos;s default value will be used.
    /// </summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public int? MaxConcurrentCdcTasks { get; set; }

    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("streamLargeObjects")]
    public JsonNode? StreamLargeObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas
{
    /// <summary>Tables in the schema.</summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; set; }
}

/// <summary>PostgreSQL objects to exclude from the stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjects
{
    /// <summary>PostgreSQL schemas on the server.</summary>
    [JsonPropertyName("postgresqlSchemas")]
    public required IList<V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas> PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>Column name.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html.
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Column length.</summary>
    [JsonPropertyName("length")]
    public int? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public int? OrdinalPosition { get; set; }

    /// <summary>Column precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>Column scale.</summary>
    [JsonPropertyName("scale")]
    public int? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.</summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public required string Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas
{
    /// <summary>Tables in the schema.</summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; set; }
}

/// <summary>PostgreSQL objects to retrieve from the source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjects
{
    /// <summary>PostgreSQL schemas on the server.</summary>
    [JsonPropertyName("postgresqlSchemas")]
    public required IList<V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas> PostgresqlSchemas { get; set; }
}

/// <summary>PostgreSQL data source configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfig
{
    /// <summary>PostgreSQL objects to exclude from the stream.</summary>
    [JsonPropertyName("excludeObjects")]
    public V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>PostgreSQL objects to retrieve from the source.</summary>
    [JsonPropertyName("includeObjects")]
    public V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>
    /// Maximum number of concurrent backfill tasks. The number should be non
    /// negative. If not set (or set to 0), the system&apos;s default value will be used.
    /// </summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public int? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>
    /// The name of the publication that includes the set of all tables
    /// that are defined in the stream&apos;s include_objects.
    /// </summary>
    [JsonPropertyName("publication")]
    public required string Publication { get; set; }

    /// <summary>
    /// The name of the logical replication slot that&apos;s configured with
    /// the pgoutput plugin.
    /// </summary>
    [JsonPropertyName("replicationSlot")]
    public required string ReplicationSlot { get; set; }
}

/// <summary>Source connection profile configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpecSourceConfig
{
    /// <summary>MySQL data source configuration.</summary>
    [JsonPropertyName("mysqlSourceConfig")]
    public V1alpha1DatastreamStreamSpecSourceConfigMysqlSourceConfig? MysqlSourceConfig { get; set; }

    /// <summary>MySQL data source configuration.</summary>
    [JsonPropertyName("oracleSourceConfig")]
    public V1alpha1DatastreamStreamSpecSourceConfigOracleSourceConfig? OracleSourceConfig { get; set; }

    /// <summary>PostgreSQL data source configuration.</summary>
    [JsonPropertyName("postgresqlSourceConfig")]
    public V1alpha1DatastreamStreamSpecSourceConfigPostgresqlSourceConfig? PostgresqlSourceConfig { get; set; }

    /// <summary>Immutable. Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}.</summary>
    [JsonPropertyName("sourceConnectionProfile")]
    public required string SourceConnectionProfile { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamSpec
{
    /// <summary>Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.</summary>
    [JsonPropertyName("backfillAll")]
    public V1alpha1DatastreamStreamSpecBackfillAll? BackfillAll { get; set; }

    /// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
    [JsonPropertyName("backfillNone")]
    public JsonNode? BackfillNone { get; set; }

    /// <summary>
    /// Immutable. A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    [JsonPropertyName("customerManagedEncryptionKey")]
    public string? CustomerManagedEncryptionKey { get; set; }

    /// <summary>Desired state of the Stream. Set this field to &apos;RUNNING&apos; to start the stream, and &apos;PAUSED&apos; to pause the stream.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Destination connection profile configuration.</summary>
    [JsonPropertyName("destinationConfig")]
    public required V1alpha1DatastreamStreamSpecDestinationConfig DestinationConfig { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Immutable. The name of the location this stream is located in.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DatastreamStreamSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The streamId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Source connection profile configuration.</summary>
    [JsonPropertyName("sourceConfig")]
    public required V1alpha1DatastreamStreamSpecSourceConfig SourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamStreamStatusConditions
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
public partial class V1alpha1DatastreamStreamStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatastreamStreamStatusConditions>? Conditions { get; set; }

    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The state of the stream.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamStream : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DatastreamStreamSpec>, IStatus<V1alpha1DatastreamStreamStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamStream";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamstreams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datastream.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatastreamStream";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1DatastreamStreamSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1DatastreamStreamStatus? Status { get; set; }
}