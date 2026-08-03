#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.gcp.m.upbound.io;
/// <summary>Stream is the Schema for the Streams API. A resource representing streaming data from a source to a destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StreamList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Stream>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StreamList";
    public const string KubeGroup = "datastream.gcp.m.upbound.io";
    public const string KubePluralName = "streams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datastream.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StreamList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Stream objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Stream> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// MongoDB data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjectsDatabases>? Databases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// MySQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// PostgreSQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjectsOracleSchemas>? OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// PostgreSQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSalesforceExcludedObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSalesforceExcludedObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSalesforceExcludedObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// Salesforce objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSalesforceExcludedObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSalesforceExcludedObjectsObjects>? Objects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// Spanner objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjectsSchemas>? Schemas { get; set; }
}

/// <summary>
/// Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillAll
{
    /// <summary>
    /// MongoDB data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllMongodbExcludedObjects? MongodbExcludedObjects { get; set; }

    /// <summary>
    /// MySQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllMysqlExcludedObjects? MysqlExcludedObjects { get; set; }

    /// <summary>
    /// PostgreSQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllOracleExcludedObjects? OracleExcludedObjects { get; set; }

    /// <summary>
    /// PostgreSQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllPostgresqlExcludedObjects? PostgresqlExcludedObjects { get; set; }

    /// <summary>
    /// Salesforce objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllSalesforceExcludedObjects? SalesforceExcludedObjects { get; set; }

    /// <summary>
    /// Spanner objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllSpannerExcludedObjects? SpannerExcludedObjects { get; set; }

    /// <summary>
    /// SQL Server data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerExcludedObjects")]
    public V1beta1StreamSpecForProviderBackfillAllSqlServerExcludedObjects? SqlServerExcludedObjects { get; set; }
}

/// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderBackfillNone
{
}

/// <summary>
/// AppendOnly mode defines that the stream of changes (INSERT, UPDATE-INSERT, UPDATE-DELETE and DELETE
/// events) to a source table will be written to the destination Google BigQuery table, retaining the
/// historical state of the data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigAppendOnly
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelector
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
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// BigLake Managed Tables configuration for BigQuery streams.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfig
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelector? BucketSelector { get; set; }

    /// <summary>The bigquery connection. Format: {project}.{location}.{name}</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The file format.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }

    /// <summary>The table format.</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>
/// Merge mode defines that all changes to a table will be merged at the destination Google BigQuery
/// table. This is the default write mode. When selected, BigQuery reflects the way the data is stored
/// in the source database. With Merge mode, no historical record of the change events is kept.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigMerge
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelector
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
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A single target dataset to which all data will be streamed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDataset
{
    /// <summary>
    /// Dataset ID in the format projects/{project}/datasets/{dataset_id} or
    /// {project}:{dataset_id}
    /// </summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelector? DatasetIdSelector { get; set; }
}

/// <summary>
/// Dataset template used for dynamic dataset creation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate
{
    /// <summary>
    /// If supplied, every created dataset will have its name prefixed by the provided value.
    /// The prefix and name will be separated by an underscore. i.e. _.
    /// </summary>
    [JsonPropertyName("datasetIdPrefix")]
    public string? DatasetIdPrefix { get; set; }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery
    /// table. The BigQuery Service Account associated with your project requires access to this
    /// encryption key. i.e. projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{cryptoKey}.
    /// See https://cloud.google.com/bigquery/docs/customer-managed-encryption for more information.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The name of the location this stream is located in.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelector
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
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets
{
    /// <summary>
    /// Dataset template used for dynamic dataset creation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("datasetTemplate")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate? DatasetTemplate { get; set; }

    /// <summary>Optional. The project id of the BigQuery dataset. If not specified, the project will be inferred from the stream resource.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelector? ProjectIdSelector { get; set; }
}

/// <summary>
/// A configuration for how data should be loaded to Google BigQuery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfig
{
    /// <summary>
    /// AppendOnly mode defines that the stream of changes (INSERT, UPDATE-INSERT, UPDATE-DELETE and DELETE
    /// events) to a source table will be written to the destination Google BigQuery table, retaining the
    /// historical state of the data.
    /// </summary>
    [JsonPropertyName("appendOnly")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigAppendOnly? AppendOnly { get; set; }

    /// <summary>
    /// BigLake Managed Tables configuration for BigQuery streams.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("blmtConfig")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigBlmtConfig? BlmtConfig { get; set; }

    /// <summary>
    /// The guaranteed data freshness (in seconds) when querying tables created by the stream.
    /// Editing this field will only affect new tables created in the future, but existing tables
    /// will not be impacted. Lower values mean that queries will return fresher data, but may result in higher cost.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;. Defaults to 900s.
    /// </summary>
    [JsonPropertyName("dataFreshness")]
    public string? DataFreshness { get; set; }

    /// <summary>
    /// Merge mode defines that all changes to a table will be merged at the destination Google BigQuery
    /// table. This is the default write mode. When selected, BigQuery reflects the way the data is stored
    /// in the source database. With Merge mode, no historical record of the change events is kept.
    /// </summary>
    [JsonPropertyName("merge")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigMerge? Merge { get; set; }

    /// <summary>
    /// A single target dataset to which all data will be streamed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("singleTargetDataset")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSingleTargetDataset? SingleTargetDataset { get; set; }

    /// <summary>
    /// Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceHierarchyDatasets")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets? SourceHierarchyDatasets { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelector
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
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelectorPolicy? Policy { get; set; }
}

/// <summary>AVRO file format configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigGcsDestinationConfigAvroFileFormat
{
}

/// <summary>
/// JSON file format configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigGcsDestinationConfigJsonFileFormat
{
    /// <summary>
    /// Compression of the loaded JSON file.
    /// Possible values are: NO_COMPRESSION, GZIP.
    /// </summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>
    /// The schema file format along JSON data files.
    /// Possible values are: NO_SCHEMA_FILE, AVRO_SCHEMA_FILE.
    /// </summary>
    [JsonPropertyName("schemaFileFormat")]
    public string? SchemaFileFormat { get; set; }
}

/// <summary>
/// A configuration for how data should be loaded to Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfigGcsDestinationConfig
{
    /// <summary>AVRO file format configuration.</summary>
    [JsonPropertyName("avroFileFormat")]
    public V1beta1StreamSpecForProviderDestinationConfigGcsDestinationConfigAvroFileFormat? AvroFileFormat { get; set; }

    /// <summary>
    /// The maximum duration for which new events are added before a file is closed and a new file is created.
    /// Values within the range of 15-60 seconds are allowed.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("fileRotationInterval")]
    public string? FileRotationInterval { get; set; }

    /// <summary>The maximum file size to be saved in the bucket.</summary>
    [JsonPropertyName("fileRotationMb")]
    public double? FileRotationMb { get; set; }

    /// <summary>
    /// JSON file format configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("jsonFileFormat")]
    public V1beta1StreamSpecForProviderDestinationConfigGcsDestinationConfigJsonFileFormat? JsonFileFormat { get; set; }

    /// <summary>Path inside the Cloud Storage bucket to write data to.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Destination connection profile configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderDestinationConfig
{
    /// <summary>
    /// A configuration for how data should be loaded to Google BigQuery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDestinationConfig")]
    public V1beta1StreamSpecForProviderDestinationConfigBigqueryDestinationConfig? BigqueryDestinationConfig { get; set; }

    /// <summary>Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}</summary>
    [JsonPropertyName("destinationConnectionProfile")]
    public string? DestinationConnectionProfile { get; set; }

    /// <summary>Reference to a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
    [JsonPropertyName("destinationConnectionProfileRef")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileRef? DestinationConnectionProfileRef { get; set; }

    /// <summary>Selector for a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
    [JsonPropertyName("destinationConnectionProfileSelector")]
    public V1beta1StreamSpecForProviderDestinationConfigDestinationConnectionProfileSelector? DestinationConnectionProfileSelector { get; set; }

    /// <summary>
    /// A configuration for how data should be loaded to Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsDestinationConfig")]
    public V1beta1StreamSpecForProviderDestinationConfigGcsDestinationConfig? GcsDestinationConfig { get; set; }
}

/// <summary>
/// BigQuery clustering rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryClustering
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioningIngestionTimePartition
{
    /// <summary>
    /// Partition granularity.
    /// Possible values are: PARTITIONING_TIME_GRANULARITY_UNSPECIFIED, PARTITIONING_TIME_GRANULARITY_HOUR, PARTITIONING_TIME_GRANULARITY_DAY, PARTITIONING_TIME_GRANULARITY_MONTH, PARTITIONING_TIME_GRANULARITY_YEAR.
    /// </summary>
    [JsonPropertyName("partitioningTimeGranularity")]
    public string? PartitioningTimeGranularity { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioningIntegerRangePartition
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The ending value for range partitioning (exclusive).</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>The interval of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The starting value for range partitioning (inclusive).</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioningTimeUnitPartition
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// Partition granularity.
    /// Possible values are: PARTITIONING_TIME_GRANULARITY_UNSPECIFIED, PARTITIONING_TIME_GRANULARITY_HOUR, PARTITIONING_TIME_GRANULARITY_DAY, PARTITIONING_TIME_GRANULARITY_MONTH, PARTITIONING_TIME_GRANULARITY_YEAR.
    /// </summary>
    [JsonPropertyName("partitioningTimeGranularity")]
    public string? PartitioningTimeGranularity { get; set; }
}

/// <summary>
/// BigQuery partitioning rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioning
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingestionTimePartition")]
    public V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioningIngestionTimePartition? IngestionTimePartition { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("integerRangePartition")]
    public V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioningIntegerRangePartition? IntegerRangePartition { get; set; }

    /// <summary>If true, queries over the table require a partition filter.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeUnitPartition")]
    public V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioningTimeUnitPartition? TimeUnitPartition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsCustomizationRules
{
    /// <summary>
    /// BigQuery clustering rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryClustering")]
    public V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryClustering? BigqueryClustering { get; set; }

    /// <summary>
    /// BigQuery partitioning rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryPartitioning")]
    public V1beta1StreamSpecForProviderRuleSetsCustomizationRulesBigqueryPartitioning? BigqueryPartitioning { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierMongodbIdentifier
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierMysqlIdentifier
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierOracleIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierPostgresqlIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierSalesforceIdentifier
{
    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierSpannerIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierSqlServerIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// Specific source object identifier.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifier
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierMongodbIdentifier? MongodbIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierMysqlIdentifier? MysqlIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierOracleIdentifier? OracleIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierPostgresqlIdentifier? PostgresqlIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierSalesforceIdentifier? SalesforceIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierSpannerIdentifier? SpannerIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifierSqlServerIdentifier? SqlServerIdentifier { get; set; }
}

/// <summary>
/// Object filter to apply the customization rules to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSetsObjectFilter
{
    /// <summary>
    /// Specific source object identifier.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceObjectIdentifier")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilterSourceObjectIdentifier? SourceObjectIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderRuleSets
{
    /// <summary>
    /// List of customization rules to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customizationRules")]
    public IList<V1beta1StreamSpecForProviderRuleSetsCustomizationRules>? CustomizationRules { get; set; }

    /// <summary>
    /// Object filter to apply the customization rules to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectFilter")]
    public V1beta1StreamSpecForProviderRuleSetsObjectFilter? ObjectFilter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabases>? Databases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabases>? Databases { get; set; }
}

/// <summary>
/// MongoDB source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }
}

/// <summary>CDC reader reads from binary logs replication cdc method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigBinaryLogPosition
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

/// <summary>CDC reader reads from gtid based replication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigGtid
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

/// <summary>
/// MySQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfig
{
    /// <summary>CDC reader reads from binary logs replication cdc method.</summary>
    [JsonPropertyName("binaryLogPosition")]
    public V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigBinaryLogPosition? BinaryLogPosition { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>CDC reader reads from gtid based replication.</summary>
    [JsonPropertyName("gtid")]
    public V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigGtid? Gtid { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }
}

/// <summary>Configuration to drop large object values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigDropLargeObjects
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas>? OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas>? OracleSchemas { get; set; }
}

/// <summary>Configuration to drop large object values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigStreamLargeObjects
{
}

/// <summary>
/// MySQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigOracleSourceConfig
{
    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("dropLargeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigDropLargeObjects? DropLargeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("streamLargeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigOracleSourceConfigStreamLargeObjects? StreamLargeObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

/// <summary>
/// PostgreSQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>
    /// The name of the publication that includes the set of all tables
    /// that are defined in the stream&apos;s include_objects.
    /// </summary>
    [JsonPropertyName("publication")]
    public string? Publication { get; set; }

    /// <summary>
    /// The name of the logical replication slot that&apos;s configured with
    /// the pgoutput plugin.
    /// </summary>
    [JsonPropertyName("replicationSlot")]
    public string? ReplicationSlot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigExcludeObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjects>? Objects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigIncludeObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjects>? Objects { get; set; }
}

/// <summary>
/// Salesforce data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Salesforce objects polling interval. The interval at which new changes will be polled for each object. The duration must be between 5 minutes and 24 hours.</summary>
    [JsonPropertyName("pollingInterval")]
    public string? PollingInterval { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelector
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
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemas>? Schemas { get; set; }
}

/// <summary>
/// Spanner data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfig
{
    /// <summary>Whether to use DataBoost for backfill queries.</summary>
    [JsonPropertyName("backfillDataBoostEnabled")]
    public bool? BackfillDataBoostEnabled { get; set; }

    /// <summary>The Spanner change stream name to use.</summary>
    [JsonPropertyName("changeStreamName")]
    public string? ChangeStreamName { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>The FGAC role to use for Spanner queries.</summary>
    [JsonPropertyName("fgacRole")]
    public string? FgacRole { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>
    /// The RPC priority to use for Spanner queries.
    /// Possible values are: LOW, MEDIUM, HIGH.
    /// </summary>
    [JsonPropertyName("spannerRpcPriority")]
    public string? SpannerRpcPriority { get; set; }
}

/// <summary>CDC reader reads from change tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigChangeTables
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemas>? Schemas { get; set; }
}

/// <summary>CDC reader reads from transaction logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigTransactionLogs
{
}

/// <summary>
/// SQL Server data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfig
{
    /// <summary>CDC reader reads from change tables.</summary>
    [JsonPropertyName("changeTables")]
    public V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigChangeTables? ChangeTables { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>CDC reader reads from transaction logs.</summary>
    [JsonPropertyName("transactionLogs")]
    public V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfigTransactionLogs? TransactionLogs { get; set; }
}

/// <summary>
/// Source connection profile configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProviderSourceConfig
{
    /// <summary>
    /// MongoDB source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigMongodbSourceConfig? MongodbSourceConfig { get; set; }

    /// <summary>
    /// MySQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigMysqlSourceConfig? MysqlSourceConfig { get; set; }

    /// <summary>
    /// MySQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigOracleSourceConfig? OracleSourceConfig { get; set; }

    /// <summary>
    /// PostgreSQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigPostgresqlSourceConfig? PostgresqlSourceConfig { get; set; }

    /// <summary>
    /// Salesforce data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigSalesforceSourceConfig? SalesforceSourceConfig { get; set; }

    /// <summary>Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}</summary>
    [JsonPropertyName("sourceConnectionProfile")]
    public string? SourceConnectionProfile { get; set; }

    /// <summary>Reference to a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
    [JsonPropertyName("sourceConnectionProfileRef")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileRef? SourceConnectionProfileRef { get; set; }

    /// <summary>Selector for a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
    [JsonPropertyName("sourceConnectionProfileSelector")]
    public V1beta1StreamSpecForProviderSourceConfigSourceConnectionProfileSelector? SourceConnectionProfileSelector { get; set; }

    /// <summary>
    /// Spanner data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigSpannerSourceConfig? SpannerSourceConfig { get; set; }

    /// <summary>
    /// SQL Server data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerSourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfigSqlServerSourceConfig? SqlServerSourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecForProvider
{
    /// <summary>
    /// Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backfillAll")]
    public V1beta1StreamSpecForProviderBackfillAll? BackfillAll { get; set; }

    /// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
    [JsonPropertyName("backfillNone")]
    public V1beta1StreamSpecForProviderBackfillNone? BackfillNone { get; set; }

    /// <summary>Create the stream without validating it.</summary>
    [JsonPropertyName("createWithoutValidation")]
    public bool? CreateWithoutValidation { get; set; }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    [JsonPropertyName("customerManagedEncryptionKey")]
    public string? CustomerManagedEncryptionKey { get; set; }

    /// <summary>
    /// Desired state of the Stream. Set this field to RUNNING to start the stream,
    /// NOT_STARTED to create the stream without starting and PAUSED to pause
    /// the stream from a RUNNING state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// Destination connection profile configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1StreamSpecForProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Labels.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location this stream is located in.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Rule sets to apply to the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1beta1StreamSpecForProviderRuleSets>? RuleSets { get; set; }

    /// <summary>
    /// Source connection profile configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceConfig")]
    public V1beta1StreamSpecForProviderSourceConfig? SourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// MongoDB data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjectsDatabases>? Databases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// MySQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// PostgreSQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjectsOracleSchemas>? OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// PostgreSQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSalesforceExcludedObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSalesforceExcludedObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSalesforceExcludedObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// Salesforce objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSalesforceExcludedObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSalesforceExcludedObjectsObjects>? Objects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// Spanner objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjectsSchemas>? Schemas { get; set; }
}

/// <summary>
/// Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillAll
{
    /// <summary>
    /// MongoDB data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllMongodbExcludedObjects? MongodbExcludedObjects { get; set; }

    /// <summary>
    /// MySQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllMysqlExcludedObjects? MysqlExcludedObjects { get; set; }

    /// <summary>
    /// PostgreSQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllOracleExcludedObjects? OracleExcludedObjects { get; set; }

    /// <summary>
    /// PostgreSQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllPostgresqlExcludedObjects? PostgresqlExcludedObjects { get; set; }

    /// <summary>
    /// Salesforce objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllSalesforceExcludedObjects? SalesforceExcludedObjects { get; set; }

    /// <summary>
    /// Spanner objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllSpannerExcludedObjects? SpannerExcludedObjects { get; set; }

    /// <summary>
    /// SQL Server data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerExcludedObjects")]
    public V1beta1StreamSpecInitProviderBackfillAllSqlServerExcludedObjects? SqlServerExcludedObjects { get; set; }
}

/// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderBackfillNone
{
}

/// <summary>
/// AppendOnly mode defines that the stream of changes (INSERT, UPDATE-INSERT, UPDATE-DELETE and DELETE
/// events) to a source table will be written to the destination Google BigQuery table, retaining the
/// historical state of the data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigAppendOnly
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelector
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
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// BigLake Managed Tables configuration for BigQuery streams.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfig
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfigBucketSelector? BucketSelector { get; set; }

    /// <summary>The bigquery connection. Format: {project}.{location}.{name}</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The file format.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }

    /// <summary>The table format.</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>
/// Merge mode defines that all changes to a table will be merged at the destination Google BigQuery
/// table. This is the default write mode. When selected, BigQuery reflects the way the data is stored
/// in the source database. With Merge mode, no historical record of the change events is kept.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigMerge
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelector
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
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A single target dataset to which all data will be streamed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDataset
{
    /// <summary>
    /// Dataset ID in the format projects/{project}/datasets/{dataset_id} or
    /// {project}:{dataset_id}
    /// </summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>Reference to a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdRef")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdRef? DatasetIdRef { get; set; }

    /// <summary>Selector for a Dataset in bigquery to populate datasetId.</summary>
    [JsonPropertyName("datasetIdSelector")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDatasetDatasetIdSelector? DatasetIdSelector { get; set; }
}

/// <summary>
/// Dataset template used for dynamic dataset creation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate
{
    /// <summary>
    /// If supplied, every created dataset will have its name prefixed by the provided value.
    /// The prefix and name will be separated by an underscore. i.e. _.
    /// </summary>
    [JsonPropertyName("datasetIdPrefix")]
    public string? DatasetIdPrefix { get; set; }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery
    /// table. The BigQuery Service Account associated with your project requires access to this
    /// encryption key. i.e. projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{cryptoKey}.
    /// See https://cloud.google.com/bigquery/docs/customer-managed-encryption for more information.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate projectId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelector
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
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets
{
    /// <summary>
    /// Dataset template used for dynamic dataset creation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("datasetTemplate")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate? DatasetTemplate { get; set; }

    /// <summary>Optional. The project id of the BigQuery dataset. If not specified, the project will be inferred from the stream resource.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate projectId.</summary>
    [JsonPropertyName("projectIdRef")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdRef? ProjectIdRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate projectId.</summary>
    [JsonPropertyName("projectIdSelector")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsProjectIdSelector? ProjectIdSelector { get; set; }
}

/// <summary>
/// A configuration for how data should be loaded to Google BigQuery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfig
{
    /// <summary>
    /// AppendOnly mode defines that the stream of changes (INSERT, UPDATE-INSERT, UPDATE-DELETE and DELETE
    /// events) to a source table will be written to the destination Google BigQuery table, retaining the
    /// historical state of the data.
    /// </summary>
    [JsonPropertyName("appendOnly")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigAppendOnly? AppendOnly { get; set; }

    /// <summary>
    /// BigLake Managed Tables configuration for BigQuery streams.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("blmtConfig")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigBlmtConfig? BlmtConfig { get; set; }

    /// <summary>
    /// The guaranteed data freshness (in seconds) when querying tables created by the stream.
    /// Editing this field will only affect new tables created in the future, but existing tables
    /// will not be impacted. Lower values mean that queries will return fresher data, but may result in higher cost.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;. Defaults to 900s.
    /// </summary>
    [JsonPropertyName("dataFreshness")]
    public string? DataFreshness { get; set; }

    /// <summary>
    /// Merge mode defines that all changes to a table will be merged at the destination Google BigQuery
    /// table. This is the default write mode. When selected, BigQuery reflects the way the data is stored
    /// in the source database. With Merge mode, no historical record of the change events is kept.
    /// </summary>
    [JsonPropertyName("merge")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigMerge? Merge { get; set; }

    /// <summary>
    /// A single target dataset to which all data will be streamed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("singleTargetDataset")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSingleTargetDataset? SingleTargetDataset { get; set; }

    /// <summary>
    /// Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceHierarchyDatasets")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets? SourceHierarchyDatasets { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelector
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
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelectorPolicy? Policy { get; set; }
}

/// <summary>AVRO file format configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigGcsDestinationConfigAvroFileFormat
{
}

/// <summary>
/// JSON file format configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigGcsDestinationConfigJsonFileFormat
{
    /// <summary>
    /// Compression of the loaded JSON file.
    /// Possible values are: NO_COMPRESSION, GZIP.
    /// </summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>
    /// The schema file format along JSON data files.
    /// Possible values are: NO_SCHEMA_FILE, AVRO_SCHEMA_FILE.
    /// </summary>
    [JsonPropertyName("schemaFileFormat")]
    public string? SchemaFileFormat { get; set; }
}

/// <summary>
/// A configuration for how data should be loaded to Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfigGcsDestinationConfig
{
    /// <summary>AVRO file format configuration.</summary>
    [JsonPropertyName("avroFileFormat")]
    public V1beta1StreamSpecInitProviderDestinationConfigGcsDestinationConfigAvroFileFormat? AvroFileFormat { get; set; }

    /// <summary>
    /// The maximum duration for which new events are added before a file is closed and a new file is created.
    /// Values within the range of 15-60 seconds are allowed.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("fileRotationInterval")]
    public string? FileRotationInterval { get; set; }

    /// <summary>The maximum file size to be saved in the bucket.</summary>
    [JsonPropertyName("fileRotationMb")]
    public double? FileRotationMb { get; set; }

    /// <summary>
    /// JSON file format configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("jsonFileFormat")]
    public V1beta1StreamSpecInitProviderDestinationConfigGcsDestinationConfigJsonFileFormat? JsonFileFormat { get; set; }

    /// <summary>Path inside the Cloud Storage bucket to write data to.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Destination connection profile configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderDestinationConfig
{
    /// <summary>
    /// A configuration for how data should be loaded to Google BigQuery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDestinationConfig")]
    public V1beta1StreamSpecInitProviderDestinationConfigBigqueryDestinationConfig? BigqueryDestinationConfig { get; set; }

    /// <summary>Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}</summary>
    [JsonPropertyName("destinationConnectionProfile")]
    public string? DestinationConnectionProfile { get; set; }

    /// <summary>Reference to a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
    [JsonPropertyName("destinationConnectionProfileRef")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileRef? DestinationConnectionProfileRef { get; set; }

    /// <summary>Selector for a ConnectionProfile in datastream to populate destinationConnectionProfile.</summary>
    [JsonPropertyName("destinationConnectionProfileSelector")]
    public V1beta1StreamSpecInitProviderDestinationConfigDestinationConnectionProfileSelector? DestinationConnectionProfileSelector { get; set; }

    /// <summary>
    /// A configuration for how data should be loaded to Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsDestinationConfig")]
    public V1beta1StreamSpecInitProviderDestinationConfigGcsDestinationConfig? GcsDestinationConfig { get; set; }
}

/// <summary>
/// BigQuery clustering rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryClustering
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioningIngestionTimePartition
{
    /// <summary>
    /// Partition granularity.
    /// Possible values are: PARTITIONING_TIME_GRANULARITY_UNSPECIFIED, PARTITIONING_TIME_GRANULARITY_HOUR, PARTITIONING_TIME_GRANULARITY_DAY, PARTITIONING_TIME_GRANULARITY_MONTH, PARTITIONING_TIME_GRANULARITY_YEAR.
    /// </summary>
    [JsonPropertyName("partitioningTimeGranularity")]
    public string? PartitioningTimeGranularity { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioningIntegerRangePartition
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The ending value for range partitioning (exclusive).</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>The interval of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The starting value for range partitioning (inclusive).</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioningTimeUnitPartition
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// Partition granularity.
    /// Possible values are: PARTITIONING_TIME_GRANULARITY_UNSPECIFIED, PARTITIONING_TIME_GRANULARITY_HOUR, PARTITIONING_TIME_GRANULARITY_DAY, PARTITIONING_TIME_GRANULARITY_MONTH, PARTITIONING_TIME_GRANULARITY_YEAR.
    /// </summary>
    [JsonPropertyName("partitioningTimeGranularity")]
    public string? PartitioningTimeGranularity { get; set; }
}

/// <summary>
/// BigQuery partitioning rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioning
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingestionTimePartition")]
    public V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioningIngestionTimePartition? IngestionTimePartition { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("integerRangePartition")]
    public V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioningIntegerRangePartition? IntegerRangePartition { get; set; }

    /// <summary>If true, queries over the table require a partition filter.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeUnitPartition")]
    public V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioningTimeUnitPartition? TimeUnitPartition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsCustomizationRules
{
    /// <summary>
    /// BigQuery clustering rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryClustering")]
    public V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryClustering? BigqueryClustering { get; set; }

    /// <summary>
    /// BigQuery partitioning rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryPartitioning")]
    public V1beta1StreamSpecInitProviderRuleSetsCustomizationRulesBigqueryPartitioning? BigqueryPartitioning { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierMongodbIdentifier
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierMysqlIdentifier
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierOracleIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierPostgresqlIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierSalesforceIdentifier
{
    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierSpannerIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierSqlServerIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// Specific source object identifier.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifier
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierMongodbIdentifier? MongodbIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierMysqlIdentifier? MysqlIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierOracleIdentifier? OracleIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierPostgresqlIdentifier? PostgresqlIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierSalesforceIdentifier? SalesforceIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierSpannerIdentifier? SpannerIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifierSqlServerIdentifier? SqlServerIdentifier { get; set; }
}

/// <summary>
/// Object filter to apply the customization rules to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSetsObjectFilter
{
    /// <summary>
    /// Specific source object identifier.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceObjectIdentifier")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilterSourceObjectIdentifier? SourceObjectIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderRuleSets
{
    /// <summary>
    /// List of customization rules to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customizationRules")]
    public IList<V1beta1StreamSpecInitProviderRuleSetsCustomizationRules>? CustomizationRules { get; set; }

    /// <summary>
    /// Object filter to apply the customization rules to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectFilter")]
    public V1beta1StreamSpecInitProviderRuleSetsObjectFilter? ObjectFilter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabases>? Databases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabases>? Databases { get; set; }
}

/// <summary>
/// MongoDB source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }
}

/// <summary>CDC reader reads from binary logs replication cdc method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigBinaryLogPosition
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

/// <summary>CDC reader reads from gtid based replication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigGtid
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

/// <summary>
/// MySQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfig
{
    /// <summary>CDC reader reads from binary logs replication cdc method.</summary>
    [JsonPropertyName("binaryLogPosition")]
    public V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigBinaryLogPosition? BinaryLogPosition { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>CDC reader reads from gtid based replication.</summary>
    [JsonPropertyName("gtid")]
    public V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigGtid? Gtid { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }
}

/// <summary>Configuration to drop large object values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigDropLargeObjects
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas>? OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas>? OracleSchemas { get; set; }
}

/// <summary>Configuration to drop large object values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigStreamLargeObjects
{
}

/// <summary>
/// MySQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfig
{
    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("dropLargeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigDropLargeObjects? DropLargeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("streamLargeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfigStreamLargeObjects? StreamLargeObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

/// <summary>
/// PostgreSQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>
    /// The name of the publication that includes the set of all tables
    /// that are defined in the stream&apos;s include_objects.
    /// </summary>
    [JsonPropertyName("publication")]
    public string? Publication { get; set; }

    /// <summary>
    /// The name of the logical replication slot that&apos;s configured with
    /// the pgoutput plugin.
    /// </summary>
    [JsonPropertyName("replicationSlot")]
    public string? ReplicationSlot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigExcludeObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjects>? Objects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigIncludeObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjects>? Objects { get; set; }
}

/// <summary>
/// Salesforce data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Salesforce objects polling interval. The interval at which new changes will be polled for each object. The duration must be between 5 minutes and 24 hours.</summary>
    [JsonPropertyName("pollingInterval")]
    public string? PollingInterval { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicyResolutionEnum>))]
public enum V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicyResolveEnum>))]
public enum V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelector
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
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemas>? Schemas { get; set; }
}

/// <summary>
/// Spanner data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfig
{
    /// <summary>Whether to use DataBoost for backfill queries.</summary>
    [JsonPropertyName("backfillDataBoostEnabled")]
    public bool? BackfillDataBoostEnabled { get; set; }

    /// <summary>The Spanner change stream name to use.</summary>
    [JsonPropertyName("changeStreamName")]
    public string? ChangeStreamName { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>The FGAC role to use for Spanner queries.</summary>
    [JsonPropertyName("fgacRole")]
    public string? FgacRole { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>
    /// The RPC priority to use for Spanner queries.
    /// Possible values are: LOW, MEDIUM, HIGH.
    /// </summary>
    [JsonPropertyName("spannerRpcPriority")]
    public string? SpannerRpcPriority { get; set; }
}

/// <summary>CDC reader reads from change tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigChangeTables
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemas>? Schemas { get; set; }
}

/// <summary>CDC reader reads from transaction logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigTransactionLogs
{
}

/// <summary>
/// SQL Server data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfig
{
    /// <summary>CDC reader reads from change tables.</summary>
    [JsonPropertyName("changeTables")]
    public V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigChangeTables? ChangeTables { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>CDC reader reads from transaction logs.</summary>
    [JsonPropertyName("transactionLogs")]
    public V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfigTransactionLogs? TransactionLogs { get; set; }
}

/// <summary>
/// Source connection profile configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpecInitProviderSourceConfig
{
    /// <summary>
    /// MongoDB source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigMongodbSourceConfig? MongodbSourceConfig { get; set; }

    /// <summary>
    /// MySQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigMysqlSourceConfig? MysqlSourceConfig { get; set; }

    /// <summary>
    /// MySQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigOracleSourceConfig? OracleSourceConfig { get; set; }

    /// <summary>
    /// PostgreSQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigPostgresqlSourceConfig? PostgresqlSourceConfig { get; set; }

    /// <summary>
    /// Salesforce data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigSalesforceSourceConfig? SalesforceSourceConfig { get; set; }

    /// <summary>Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}</summary>
    [JsonPropertyName("sourceConnectionProfile")]
    public string? SourceConnectionProfile { get; set; }

    /// <summary>Reference to a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
    [JsonPropertyName("sourceConnectionProfileRef")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileRef? SourceConnectionProfileRef { get; set; }

    /// <summary>Selector for a ConnectionProfile in datastream to populate sourceConnectionProfile.</summary>
    [JsonPropertyName("sourceConnectionProfileSelector")]
    public V1beta1StreamSpecInitProviderSourceConfigSourceConnectionProfileSelector? SourceConnectionProfileSelector { get; set; }

    /// <summary>
    /// Spanner data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigSpannerSourceConfig? SpannerSourceConfig { get; set; }

    /// <summary>
    /// SQL Server data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerSourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfigSqlServerSourceConfig? SqlServerSourceConfig { get; set; }
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
public partial class V1beta1StreamSpecInitProvider
{
    /// <summary>
    /// Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backfillAll")]
    public V1beta1StreamSpecInitProviderBackfillAll? BackfillAll { get; set; }

    /// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
    [JsonPropertyName("backfillNone")]
    public V1beta1StreamSpecInitProviderBackfillNone? BackfillNone { get; set; }

    /// <summary>Create the stream without validating it.</summary>
    [JsonPropertyName("createWithoutValidation")]
    public bool? CreateWithoutValidation { get; set; }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    [JsonPropertyName("customerManagedEncryptionKey")]
    public string? CustomerManagedEncryptionKey { get; set; }

    /// <summary>
    /// Desired state of the Stream. Set this field to RUNNING to start the stream,
    /// NOT_STARTED to create the stream without starting and PAUSED to pause
    /// the stream from a RUNNING state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// Destination connection profile configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1StreamSpecInitProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Labels.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Rule sets to apply to the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1beta1StreamSpecInitProviderRuleSets>? RuleSets { get; set; }

    /// <summary>
    /// Source connection profile configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceConfig")]
    public V1beta1StreamSpecInitProviderSourceConfig? SourceConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamSpecManagementPoliciesEnum>))]
public enum V1beta1StreamSpecManagementPoliciesEnum
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
public partial class V1beta1StreamSpecProviderConfigRef
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
public partial class V1beta1StreamSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>StreamSpec defines the desired state of Stream</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1StreamSpecForProvider ForProvider { get; set; }

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
    public V1beta1StreamSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1StreamSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StreamSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StreamSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// MongoDB data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjectsDatabases>? Databases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// MySQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column encoding.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// PostgreSQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjectsOracleSchemas>? OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// PostgreSQL data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSalesforceExcludedObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSalesforceExcludedObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSalesforceExcludedObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// Salesforce objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSalesforceExcludedObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSalesforceExcludedObjectsObjects>? Objects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Whether or not the column is a primary key.
    /// </summary>
    [JsonPropertyName("isPrimaryKey")]
    public bool? IsPrimaryKey { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// Spanner objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server data source objects to avoid backfilling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjectsSchemas>? Schemas { get; set; }
}

/// <summary>
/// Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillAll
{
    /// <summary>
    /// MongoDB data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllMongodbExcludedObjects? MongodbExcludedObjects { get; set; }

    /// <summary>
    /// MySQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllMysqlExcludedObjects? MysqlExcludedObjects { get; set; }

    /// <summary>
    /// PostgreSQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllOracleExcludedObjects? OracleExcludedObjects { get; set; }

    /// <summary>
    /// PostgreSQL data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllPostgresqlExcludedObjects? PostgresqlExcludedObjects { get; set; }

    /// <summary>
    /// Salesforce objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllSalesforceExcludedObjects? SalesforceExcludedObjects { get; set; }

    /// <summary>
    /// Spanner objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllSpannerExcludedObjects? SpannerExcludedObjects { get; set; }

    /// <summary>
    /// SQL Server data source objects to avoid backfilling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerExcludedObjects")]
    public V1beta1StreamStatusAtProviderBackfillAllSqlServerExcludedObjects? SqlServerExcludedObjects { get; set; }
}

/// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderBackfillNone
{
}

/// <summary>
/// AppendOnly mode defines that the stream of changes (INSERT, UPDATE-INSERT, UPDATE-DELETE and DELETE
/// events) to a source table will be written to the destination Google BigQuery table, retaining the
/// historical state of the data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigAppendOnly
{
}

/// <summary>
/// BigLake Managed Tables configuration for BigQuery streams.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigBlmtConfig
{
    /// <summary>The Cloud Storage bucket name.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The bigquery connection. Format: {project}.{location}.{name}</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The file format.</summary>
    [JsonPropertyName("fileFormat")]
    public string? FileFormat { get; set; }

    /// <summary>The root path inside the Cloud Storage bucket.</summary>
    [JsonPropertyName("rootPath")]
    public string? RootPath { get; set; }

    /// <summary>The table format.</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>
/// Merge mode defines that all changes to a table will be merged at the destination Google BigQuery
/// table. This is the default write mode. When selected, BigQuery reflects the way the data is stored
/// in the source database. With Merge mode, no historical record of the change events is kept.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigMerge
{
}

/// <summary>
/// A single target dataset to which all data will be streamed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigSingleTargetDataset
{
    /// <summary>
    /// Dataset ID in the format projects/{project}/datasets/{dataset_id} or
    /// {project}:{dataset_id}
    /// </summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }
}

/// <summary>
/// Dataset template used for dynamic dataset creation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate
{
    /// <summary>
    /// If supplied, every created dataset will have its name prefixed by the provided value.
    /// The prefix and name will be separated by an underscore. i.e. _.
    /// </summary>
    [JsonPropertyName("datasetIdPrefix")]
    public string? DatasetIdPrefix { get; set; }

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery
    /// table. The BigQuery Service Account associated with your project requires access to this
    /// encryption key. i.e. projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{cryptoKey}.
    /// See https://cloud.google.com/bigquery/docs/customer-managed-encryption for more information.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>The name of the location this stream is located in.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>
/// Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets
{
    /// <summary>
    /// Dataset template used for dynamic dataset creation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("datasetTemplate")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasetsDatasetTemplate? DatasetTemplate { get; set; }

    /// <summary>Optional. The project id of the BigQuery dataset. If not specified, the project will be inferred from the stream resource.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>
/// A configuration for how data should be loaded to Google BigQuery.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfig
{
    /// <summary>
    /// AppendOnly mode defines that the stream of changes (INSERT, UPDATE-INSERT, UPDATE-DELETE and DELETE
    /// events) to a source table will be written to the destination Google BigQuery table, retaining the
    /// historical state of the data.
    /// </summary>
    [JsonPropertyName("appendOnly")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigAppendOnly? AppendOnly { get; set; }

    /// <summary>
    /// BigLake Managed Tables configuration for BigQuery streams.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("blmtConfig")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigBlmtConfig? BlmtConfig { get; set; }

    /// <summary>
    /// The guaranteed data freshness (in seconds) when querying tables created by the stream.
    /// Editing this field will only affect new tables created in the future, but existing tables
    /// will not be impacted. Lower values mean that queries will return fresher data, but may result in higher cost.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;. Defaults to 900s.
    /// </summary>
    [JsonPropertyName("dataFreshness")]
    public string? DataFreshness { get; set; }

    /// <summary>
    /// Merge mode defines that all changes to a table will be merged at the destination Google BigQuery
    /// table. This is the default write mode. When selected, BigQuery reflects the way the data is stored
    /// in the source database. With Merge mode, no historical record of the change events is kept.
    /// </summary>
    [JsonPropertyName("merge")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigMerge? Merge { get; set; }

    /// <summary>
    /// A single target dataset to which all data will be streamed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("singleTargetDataset")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigSingleTargetDataset? SingleTargetDataset { get; set; }

    /// <summary>
    /// Destination datasets are created so that hierarchy of the destination data objects matches the source hierarchy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceHierarchyDatasets")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfigSourceHierarchyDatasets? SourceHierarchyDatasets { get; set; }
}

/// <summary>AVRO file format configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigGcsDestinationConfigAvroFileFormat
{
}

/// <summary>
/// JSON file format configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigGcsDestinationConfigJsonFileFormat
{
    /// <summary>
    /// Compression of the loaded JSON file.
    /// Possible values are: NO_COMPRESSION, GZIP.
    /// </summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>
    /// The schema file format along JSON data files.
    /// Possible values are: NO_SCHEMA_FILE, AVRO_SCHEMA_FILE.
    /// </summary>
    [JsonPropertyName("schemaFileFormat")]
    public string? SchemaFileFormat { get; set; }
}

/// <summary>
/// A configuration for how data should be loaded to Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfigGcsDestinationConfig
{
    /// <summary>AVRO file format configuration.</summary>
    [JsonPropertyName("avroFileFormat")]
    public V1beta1StreamStatusAtProviderDestinationConfigGcsDestinationConfigAvroFileFormat? AvroFileFormat { get; set; }

    /// <summary>
    /// The maximum duration for which new events are added before a file is closed and a new file is created.
    /// Values within the range of 15-60 seconds are allowed.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("fileRotationInterval")]
    public string? FileRotationInterval { get; set; }

    /// <summary>The maximum file size to be saved in the bucket.</summary>
    [JsonPropertyName("fileRotationMb")]
    public double? FileRotationMb { get; set; }

    /// <summary>
    /// JSON file format configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("jsonFileFormat")]
    public V1beta1StreamStatusAtProviderDestinationConfigGcsDestinationConfigJsonFileFormat? JsonFileFormat { get; set; }

    /// <summary>Path inside the Cloud Storage bucket to write data to.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Destination connection profile configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderDestinationConfig
{
    /// <summary>
    /// A configuration for how data should be loaded to Google BigQuery.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryDestinationConfig")]
    public V1beta1StreamStatusAtProviderDestinationConfigBigqueryDestinationConfig? BigqueryDestinationConfig { get; set; }

    /// <summary>Destination connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}</summary>
    [JsonPropertyName("destinationConnectionProfile")]
    public string? DestinationConnectionProfile { get; set; }

    /// <summary>
    /// A configuration for how data should be loaded to Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gcsDestinationConfig")]
    public V1beta1StreamStatusAtProviderDestinationConfigGcsDestinationConfig? GcsDestinationConfig { get; set; }
}

/// <summary>
/// BigQuery clustering rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryClustering
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<string>? Columns { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioningIngestionTimePartition
{
    /// <summary>
    /// Partition granularity.
    /// Possible values are: PARTITIONING_TIME_GRANULARITY_UNSPECIFIED, PARTITIONING_TIME_GRANULARITY_HOUR, PARTITIONING_TIME_GRANULARITY_DAY, PARTITIONING_TIME_GRANULARITY_MONTH, PARTITIONING_TIME_GRANULARITY_YEAR.
    /// </summary>
    [JsonPropertyName("partitioningTimeGranularity")]
    public string? PartitioningTimeGranularity { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioningIntegerRangePartition
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>The ending value for range partitioning (exclusive).</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>The interval of each range within the partition.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The starting value for range partitioning (inclusive).</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioningTimeUnitPartition
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// Partition granularity.
    /// Possible values are: PARTITIONING_TIME_GRANULARITY_UNSPECIFIED, PARTITIONING_TIME_GRANULARITY_HOUR, PARTITIONING_TIME_GRANULARITY_DAY, PARTITIONING_TIME_GRANULARITY_MONTH, PARTITIONING_TIME_GRANULARITY_YEAR.
    /// </summary>
    [JsonPropertyName("partitioningTimeGranularity")]
    public string? PartitioningTimeGranularity { get; set; }
}

/// <summary>
/// BigQuery partitioning rule.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioning
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ingestionTimePartition")]
    public V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioningIngestionTimePartition? IngestionTimePartition { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("integerRangePartition")]
    public V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioningIntegerRangePartition? IntegerRangePartition { get; set; }

    /// <summary>If true, queries over the table require a partition filter.</summary>
    [JsonPropertyName("requirePartitionFilter")]
    public bool? RequirePartitionFilter { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeUnitPartition")]
    public V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioningTimeUnitPartition? TimeUnitPartition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsCustomizationRules
{
    /// <summary>
    /// BigQuery clustering rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryClustering")]
    public V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryClustering? BigqueryClustering { get; set; }

    /// <summary>
    /// BigQuery partitioning rule.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bigqueryPartitioning")]
    public V1beta1StreamStatusAtProviderRuleSetsCustomizationRulesBigqueryPartitioning? BigqueryPartitioning { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierMongodbIdentifier
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierMysqlIdentifier
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierOracleIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierPostgresqlIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierSalesforceIdentifier
{
    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierSpannerIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierSqlServerIdentifier
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

/// <summary>
/// Specific source object identifier.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifier
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierMongodbIdentifier? MongodbIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierMysqlIdentifier? MysqlIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierOracleIdentifier? OracleIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierPostgresqlIdentifier? PostgresqlIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierSalesforceIdentifier? SalesforceIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierSpannerIdentifier? SpannerIdentifier { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifierSqlServerIdentifier? SqlServerIdentifier { get; set; }
}

/// <summary>
/// Object filter to apply the customization rules to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSetsObjectFilter
{
    /// <summary>
    /// Specific source object identifier.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceObjectIdentifier")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilterSourceObjectIdentifier? SourceObjectIdentifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderRuleSets
{
    /// <summary>
    /// List of customization rules to apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customizationRules")]
    public IList<V1beta1StreamStatusAtProviderRuleSetsCustomizationRules>? CustomizationRules { get; set; }

    /// <summary>
    /// Object filter to apply the customization rules to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectFilter")]
    public V1beta1StreamStatusAtProviderRuleSetsObjectFilter? ObjectFilter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjectsDatabases>? Databases { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollectionsFields
{
    /// <summary>Field name.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollections
{
    /// <summary>The MongoDB collection name.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollectionsFields>? Fields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabases
{
    /// <summary>
    /// Collections in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collections")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabasesCollections>? Collections { get; set; }

    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjects
{
    /// <summary>
    /// MongoDB databases in the cluster.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("databases")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjectsDatabases>? Databases { get; set; }
}

/// <summary>
/// MongoDB source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }
}

/// <summary>CDC reader reads from binary logs replication cdc method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigBinaryLogPosition
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

/// <summary>CDC reader reads from gtid based replication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigGtid
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns
{
    /// <summary>Column collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables
{
    /// <summary>
    /// MySQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlColumns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTablesMysqlColumns>? MysqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases
{
    /// <summary>The database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlTables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabasesMysqlTables>? MysqlTables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjects
{
    /// <summary>
    /// MySQL databases on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlDatabases")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjectsMysqlDatabases>? MysqlDatabases { get; set; }
}

/// <summary>
/// MySQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfig
{
    /// <summary>CDC reader reads from binary logs replication cdc method.</summary>
    [JsonPropertyName("binaryLogPosition")]
    public V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigBinaryLogPosition? BinaryLogPosition { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>CDC reader reads from gtid based replication.</summary>
    [JsonPropertyName("gtid")]
    public V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigGtid? Gtid { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }
}

/// <summary>Configuration to drop large object values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigDropLargeObjects
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column encoding.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjectsOracleSchemas>? OracleSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column encoding.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables
{
    /// <summary>
    /// Oracle columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleColumns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTablesOracleColumns>? OracleColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas
{
    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleTables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemasOracleTables>? OracleTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjects
{
    /// <summary>
    /// Oracle schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSchemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjectsOracleSchemas>? OracleSchemas { get; set; }
}

/// <summary>Configuration to drop large object values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigStreamLargeObjects
{
}

/// <summary>
/// MySQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfig
{
    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("dropLargeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigDropLargeObjects? DropLargeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>Configuration to drop large object values.</summary>
    [JsonPropertyName("streamLargeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfigStreamLargeObjects? StreamLargeObjects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables
{
    /// <summary>
    /// PostgreSQL columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlColumns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTablesPostgresqlColumns>? PostgresqlColumns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas
{
    /// <summary>
    /// Tables in the schema.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlTables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemasPostgresqlTables>? PostgresqlTables { get; set; }

    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjects
{
    /// <summary>
    /// PostgreSQL schemas on the server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSchemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjectsPostgresqlSchemas>? PostgresqlSchemas { get; set; }
}

/// <summary>
/// PostgreSQL data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>
    /// The name of the publication that includes the set of all tables
    /// that are defined in the stream&apos;s include_objects.
    /// </summary>
    [JsonPropertyName("publication")]
    public string? Publication { get; set; }

    /// <summary>
    /// The name of the logical replication slot that&apos;s configured with
    /// the pgoutput plugin.
    /// </summary>
    [JsonPropertyName("replicationSlot")]
    public string? ReplicationSlot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigExcludeObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigExcludeObjectsObjects>? Objects { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjectsFields
{
    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjects
{
    /// <summary>
    /// Fields in the Salesforce object. When unspecified as part of include/exclude objects, includes/excludes everything/nothing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjectsFields>? Fields { get; set; }

    /// <summary>The Salesforce object name.</summary>
    [JsonPropertyName("objectName")]
    public string? ObjectName { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigIncludeObjects
{
    /// <summary>
    /// Salesforce objects in Salesforce Org.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objects")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigIncludeObjectsObjects>? Objects { get; set; }
}

/// <summary>
/// Salesforce data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfig
{
    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Salesforce objects polling interval. The interval at which new changes will be polled for each object. The duration must be between 5 minutes and 24 hours.</summary>
    [JsonPropertyName("pollingInterval")]
    public string? PollingInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Whether or not the column is a primary key.
    /// </summary>
    [JsonPropertyName("isPrimaryKey")]
    public bool? IsPrimaryKey { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Whether or not the column is a primary key.
    /// </summary>
    [JsonPropertyName("isPrimaryKey")]
    public bool? IsPrimaryKey { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjectsSchemas>? Schemas { get; set; }
}

/// <summary>
/// Spanner data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfig
{
    /// <summary>Whether to use DataBoost for backfill queries.</summary>
    [JsonPropertyName("backfillDataBoostEnabled")]
    public bool? BackfillDataBoostEnabled { get; set; }

    /// <summary>The Spanner change stream name to use.</summary>
    [JsonPropertyName("changeStreamName")]
    public string? ChangeStreamName { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>The FGAC role to use for Spanner queries.</summary>
    [JsonPropertyName("fgacRole")]
    public string? FgacRole { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>
    /// The RPC priority to use for Spanner queries.
    /// Possible values are: LOW, MEDIUM, HIGH.
    /// </summary>
    [JsonPropertyName("spannerRpcPriority")]
    public string? SpannerRpcPriority { get; set; }
}

/// <summary>CDC reader reads from change tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigChangeTables
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to exclude from the stream.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjectsSchemas>? Schemas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTablesColumns
{
    /// <summary>The partitioning column.</summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }

    /// <summary>
    /// The PostgreSQL data type. Full data types list can be found here:
    /// https://www.postgresql.org/docs/current/datatype.html
    /// </summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>
    /// (Output)
    /// Column length.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>Whether or not the column can accept a null value.</summary>
    [JsonPropertyName("nullable")]
    public bool? Nullable { get; set; }

    /// <summary>The ordinal position of the column in the table.</summary>
    [JsonPropertyName("ordinalPosition")]
    public double? OrdinalPosition { get; set; }

    /// <summary>
    /// (Output)
    /// Column precision.
    /// </summary>
    [JsonPropertyName("precision")]
    public double? Precision { get; set; }

    /// <summary>Whether or not the column represents a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// (Output)
    /// Column scale.
    /// </summary>
    [JsonPropertyName("scale")]
    public double? Scale { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTables
{
    /// <summary>
    /// SQL Server columns in the schema. When unspecified as part of include/exclude objects, includes/excludes everything.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("columns")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTablesColumns>? Columns { get; set; }

    /// <summary>Table name.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemas
{
    /// <summary>The schema name.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// Tables in the database.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tables")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemasTables>? Tables { get; set; }
}

/// <summary>
/// SQL Server objects to retrieve from the source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjects
{
    /// <summary>
    /// SQL Server schemas/databases in the database server
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("schemas")]
    public IList<V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjectsSchemas>? Schemas { get; set; }
}

/// <summary>CDC reader reads from transaction logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigTransactionLogs
{
}

/// <summary>
/// SQL Server data source configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfig
{
    /// <summary>CDC reader reads from change tables.</summary>
    [JsonPropertyName("changeTables")]
    public V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigChangeTables? ChangeTables { get; set; }

    /// <summary>
    /// SQL Server objects to exclude from the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("excludeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigExcludeObjects? ExcludeObjects { get; set; }

    /// <summary>
    /// SQL Server objects to retrieve from the source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("includeObjects")]
    public V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigIncludeObjects? IncludeObjects { get; set; }

    /// <summary>Max concurrent backfill tasks.</summary>
    [JsonPropertyName("maxConcurrentBackfillTasks")]
    public double? MaxConcurrentBackfillTasks { get; set; }

    /// <summary>Max concurrent CDC tasks.</summary>
    [JsonPropertyName("maxConcurrentCdcTasks")]
    public double? MaxConcurrentCdcTasks { get; set; }

    /// <summary>CDC reader reads from transaction logs.</summary>
    [JsonPropertyName("transactionLogs")]
    public V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfigTransactionLogs? TransactionLogs { get; set; }
}

/// <summary>
/// Source connection profile configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProviderSourceConfig
{
    /// <summary>
    /// MongoDB source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mongodbSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigMongodbSourceConfig? MongodbSourceConfig { get; set; }

    /// <summary>
    /// MySQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mysqlSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigMysqlSourceConfig? MysqlSourceConfig { get; set; }

    /// <summary>
    /// MySQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oracleSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigOracleSourceConfig? OracleSourceConfig { get; set; }

    /// <summary>
    /// PostgreSQL data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("postgresqlSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigPostgresqlSourceConfig? PostgresqlSourceConfig { get; set; }

    /// <summary>
    /// Salesforce data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("salesforceSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigSalesforceSourceConfig? SalesforceSourceConfig { get; set; }

    /// <summary>Source connection profile resource. Format: projects/{project}/locations/{location}/connectionProfiles/{name}</summary>
    [JsonPropertyName("sourceConnectionProfile")]
    public string? SourceConnectionProfile { get; set; }

    /// <summary>
    /// Spanner data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spannerSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigSpannerSourceConfig? SpannerSourceConfig { get; set; }

    /// <summary>
    /// SQL Server data source configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sqlServerSourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfigSqlServerSourceConfig? SqlServerSourceConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusAtProvider
{
    /// <summary>
    /// Backfill strategy to automatically backfill the Stream&apos;s objects. Specific objects can be excluded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backfillAll")]
    public V1beta1StreamStatusAtProviderBackfillAll? BackfillAll { get; set; }

    /// <summary>Backfill strategy to disable automatic backfill for the Stream&apos;s objects.</summary>
    [JsonPropertyName("backfillNone")]
    public V1beta1StreamStatusAtProviderBackfillNone? BackfillNone { get; set; }

    /// <summary>Create the stream without validating it.</summary>
    [JsonPropertyName("createWithoutValidation")]
    public bool? CreateWithoutValidation { get; set; }

    /// <summary>
    /// A reference to a KMS encryption key. If provided, it will be used to encrypt the data. If left blank, data
    /// will be encrypted using an internal Stream-specific encryption key provisioned through KMS.
    /// </summary>
    [JsonPropertyName("customerManagedEncryptionKey")]
    public string? CustomerManagedEncryptionKey { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// Desired state of the Stream. Set this field to RUNNING to start the stream,
    /// NOT_STARTED to create the stream without starting and PAUSED to pause
    /// the stream from a RUNNING state.
    /// Possible values: NOT_STARTED, RUNNING, PAUSED. Default: NOT_STARTED
    /// </summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>
    /// Destination connection profile configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("destinationConfig")]
    public V1beta1StreamStatusAtProviderDestinationConfig? DestinationConfig { get; set; }

    /// <summary>Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/streams/{{stream_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Labels.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The name of the location this stream is located in.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The stream&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Rule sets to apply to the stream.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ruleSets")]
    public IList<V1beta1StreamStatusAtProviderRuleSets>? RuleSets { get; set; }

    /// <summary>
    /// Source connection profile configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceConfig")]
    public V1beta1StreamStatusAtProviderSourceConfig? SourceConfig { get; set; }

    /// <summary>The state of the stream.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatusConditions
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

/// <summary>StreamStatus defines the observed state of Stream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1StreamStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StreamStatusConditions>? Conditions { get; set; }

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

/// <summary>Stream is the Schema for the Streams API. A resource representing streaming data from a source to a destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Stream : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StreamSpec>, IStatus<V1beta1StreamStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Stream";
    public const string KubeGroup = "datastream.gcp.m.upbound.io";
    public const string KubePluralName = "streams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datastream.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Stream";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StreamSpec defines the desired state of Stream</summary>
    [JsonPropertyName("spec")]
    public required V1beta1StreamSpec Spec { get; set; }

    /// <summary>StreamStatus defines the observed state of Stream.</summary>
    [JsonPropertyName("status")]
    public V1beta1StreamStatus? Status { get; set; }
}