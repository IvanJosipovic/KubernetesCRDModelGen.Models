#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>Database is the Schema for the databases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1DatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1Database>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "DatabaseList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "databases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Database objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Database> Items { get; set; }
}

/// <summary>The name of the PostgreSQL cluster hosting the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecCluster
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The policy for end-of-life maintenance of this database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecDatabaseReclaimPolicyEnum>))]
public enum V1DatabaseSpecDatabaseReclaimPolicyEnum
{
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    [EnumMember(Value = "retain"), JsonStringEnumMemberName("retain")]
    Retain
}

/// <summary>Ensure the PostgreSQL database is `present` or `absent` - defaults to &quot;present&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecEnsureEnum>))]
public enum V1DatabaseSpecEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>
/// Specifies whether an object (e.g schema) should be present or absent
/// in the database. If set to `present`, the object will be created if
/// it does not exist. If set to `absent`, the extension/schema will be
/// removed if it exists.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecExtensionsEnsureEnum>))]
public enum V1DatabaseSpecExtensionsEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>ExtensionSpec configures an extension in a database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecExtensions
{
    /// <summary>
    /// Specifies whether an object (e.g schema) should be present or absent
    /// in the database. If set to `present`, the object will be created if
    /// it does not exist. If set to `absent`, the extension/schema will be
    /// removed if it exists.
    /// </summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecExtensionsEnsureEnum? Ensure { get; set; }

    /// <summary>Name of the object (extension, schema, FDW, server)</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The name of the schema in which to install the extension&apos;s objects,
    /// in case the extension allows its contents to be relocated. If not
    /// specified (default), and the extension&apos;s control file does not
    /// specify a schema either, the current default object creation schema
    /// is used.
    /// </summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>
    /// The version of the extension to install. If empty, the operator will
    /// install the default version (whatever is specified in the
    /// extension&apos;s control file)
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Specifies whether an object (e.g schema) should be present or absent
/// in the database. If set to `present`, the object will be created if
/// it does not exist. If set to `absent`, the extension/schema will be
/// removed if it exists.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecFdwsEnsureEnum>))]
public enum V1DatabaseSpecFdwsEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>
/// Specifies whether an option should be present or absent in
/// the database. If set to `present`, the option will be
/// created if it does not exist. If set to `absent`, the
/// option will be removed if it exists.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecFdwsOptionsEnsureEnum>))]
public enum V1DatabaseSpecFdwsOptionsEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>OptionSpec holds the name, value and the ensure field for an option</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecFdwsOptions
{
    /// <summary>
    /// Specifies whether an option should be present or absent in
    /// the database. If set to `present`, the option will be
    /// created if it does not exist. If set to `absent`, the
    /// option will be removed if it exists.
    /// </summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecFdwsOptionsEnsureEnum? Ensure { get; set; }

    /// <summary>Name of the option</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value of the option</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>The type of usage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecFdwsUsageTypeEnum>))]
public enum V1DatabaseSpecFdwsUsageTypeEnum
{
    [EnumMember(Value = "grant"), JsonStringEnumMemberName("grant")]
    Grant,
    [EnumMember(Value = "revoke"), JsonStringEnumMemberName("revoke")]
    Revoke
}

/// <summary>UsageSpec configures a usage for a foreign data wrapper</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecFdwsUsage
{
    /// <summary>Name of the usage</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The type of usage</summary>
    [JsonPropertyName("type")]
    public V1DatabaseSpecFdwsUsageTypeEnum? Type { get; set; }
}

/// <summary>FDWSpec configures an Foreign Data Wrapper in a database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecFdws
{
    /// <summary>
    /// Specifies whether an object (e.g schema) should be present or absent
    /// in the database. If set to `present`, the object will be created if
    /// it does not exist. If set to `absent`, the extension/schema will be
    /// removed if it exists.
    /// </summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecFdwsEnsureEnum? Ensure { get; set; }

    /// <summary>
    /// Name of the handler function (e.g., &quot;postgres_fdw_handler&quot;).
    /// This will be empty if no handler is specified. In that case,
    /// the default handler is registered when the FDW extension is created.
    /// </summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary>Name of the object (extension, schema, FDW, server)</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Options specifies the configuration options for the FDW.</summary>
    [JsonPropertyName("options")]
    public IList<V1DatabaseSpecFdwsOptions>? Options { get; set; }

    /// <summary>
    /// Owner specifies the database role that will own the Foreign Data Wrapper.
    /// The role must have superuser privileges in the target database.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>List of roles for which `USAGE` privileges on the FDW are granted or revoked.</summary>
    [JsonPropertyName("usage")]
    public IList<V1DatabaseSpecFdwsUsage>? Usage { get; set; }

    /// <summary>
    /// Name of the validator function (e.g., &quot;postgres_fdw_validator&quot;).
    /// This will be empty if no validator is specified. In that case,
    /// the default validator is registered when the FDW extension is created.
    /// </summary>
    [JsonPropertyName("validator")]
    public string? Validator { get; set; }
}

/// <summary>
/// Specifies whether an object (e.g schema) should be present or absent
/// in the database. If set to `present`, the object will be created if
/// it does not exist. If set to `absent`, the extension/schema will be
/// removed if it exists.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecSchemasEnsureEnum>))]
public enum V1DatabaseSpecSchemasEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>SchemaSpec configures a schema in a database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecSchemas
{
    /// <summary>
    /// Specifies whether an object (e.g schema) should be present or absent
    /// in the database. If set to `present`, the object will be created if
    /// it does not exist. If set to `absent`, the extension/schema will be
    /// removed if it exists.
    /// </summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecSchemasEnsureEnum? Ensure { get; set; }

    /// <summary>Name of the object (extension, schema, FDW, server)</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The role name of the user who owns the schema inside PostgreSQL.
    /// It maps to the `AUTHORIZATION` parameter of `CREATE SCHEMA` and the
    /// `OWNER TO` command of `ALTER SCHEMA`.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}

/// <summary>
/// Specifies whether an object (e.g schema) should be present or absent
/// in the database. If set to `present`, the object will be created if
/// it does not exist. If set to `absent`, the extension/schema will be
/// removed if it exists.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecServersEnsureEnum>))]
public enum V1DatabaseSpecServersEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>
/// Specifies whether an option should be present or absent in
/// the database. If set to `present`, the option will be
/// created if it does not exist. If set to `absent`, the
/// option will be removed if it exists.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecServersOptionsEnsureEnum>))]
public enum V1DatabaseSpecServersOptionsEnsureEnum
{
    [EnumMember(Value = "present"), JsonStringEnumMemberName("present")]
    Present,
    [EnumMember(Value = "absent"), JsonStringEnumMemberName("absent")]
    Absent
}

/// <summary>OptionSpec holds the name, value and the ensure field for an option</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecServersOptions
{
    /// <summary>
    /// Specifies whether an option should be present or absent in
    /// the database. If set to `present`, the option will be
    /// created if it does not exist. If set to `absent`, the
    /// option will be removed if it exists.
    /// </summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecServersOptionsEnsureEnum? Ensure { get; set; }

    /// <summary>Name of the option</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value of the option</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>The type of usage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1DatabaseSpecServersUsageTypeEnum>))]
public enum V1DatabaseSpecServersUsageTypeEnum
{
    [EnumMember(Value = "grant"), JsonStringEnumMemberName("grant")]
    Grant,
    [EnumMember(Value = "revoke"), JsonStringEnumMemberName("revoke")]
    Revoke
}

/// <summary>UsageSpec configures a usage for a foreign data wrapper</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecServersUsage
{
    /// <summary>Name of the usage</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The type of usage</summary>
    [JsonPropertyName("type")]
    public V1DatabaseSpecServersUsageTypeEnum? Type { get; set; }
}

/// <summary>ServerSpec configures a server of a foreign data wrapper</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpecServers
{
    /// <summary>
    /// Specifies whether an object (e.g schema) should be present or absent
    /// in the database. If set to `present`, the object will be created if
    /// it does not exist. If set to `absent`, the extension/schema will be
    /// removed if it exists.
    /// </summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecServersEnsureEnum? Ensure { get; set; }

    /// <summary>The name of the Foreign Data Wrapper (FDW)</summary>
    [JsonPropertyName("fdw")]
    public required string Fdw { get; set; }

    /// <summary>Name of the object (extension, schema, FDW, server)</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Options specifies the configuration options for the server
    /// (key is the option name, value is the option value).
    /// </summary>
    [JsonPropertyName("options")]
    public IList<V1DatabaseSpecServersOptions>? Options { get; set; }

    /// <summary>List of roles for which `USAGE` privileges on the server are granted or revoked.</summary>
    [JsonPropertyName("usage")]
    public IList<V1DatabaseSpecServersUsage>? Usage { get; set; }
}

/// <summary>
/// Specification of the desired Database.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseSpec
{
    /// <summary>
    /// Maps to the `ALLOW_CONNECTIONS` parameter of `CREATE DATABASE` and
    /// `ALTER DATABASE`. If false then no one can connect to this database.
    /// </summary>
    [JsonPropertyName("allowConnections")]
    public bool? AllowConnections { get; set; }

    /// <summary>
    /// Maps to the `BUILTIN_LOCALE` parameter of `CREATE DATABASE`. This
    /// setting cannot be changed. Specifies the locale name when the
    /// builtin provider is used. This option requires `localeProvider` to
    /// be set to `builtin`. Available from PostgreSQL 17.
    /// </summary>
    [JsonPropertyName("builtinLocale")]
    public string? BuiltinLocale { get; set; }

    /// <summary>The name of the PostgreSQL cluster hosting the database.</summary>
    [JsonPropertyName("cluster")]
    public required V1DatabaseSpecCluster Cluster { get; set; }

    /// <summary>
    /// Maps to the `COLLATION_VERSION` parameter of `CREATE DATABASE`. This
    /// setting cannot be changed.
    /// </summary>
    [JsonPropertyName("collationVersion")]
    public string? CollationVersion { get; set; }

    /// <summary>
    /// Maps to the `CONNECTION LIMIT` clause of `CREATE DATABASE` and
    /// `ALTER DATABASE`. How many concurrent connections can be made to
    /// this database. -1 (the default) means no limit.
    /// </summary>
    [JsonPropertyName("connectionLimit")]
    public int? ConnectionLimit { get; set; }

    /// <summary>The policy for end-of-life maintenance of this database.</summary>
    [JsonPropertyName("databaseReclaimPolicy")]
    public V1DatabaseSpecDatabaseReclaimPolicyEnum? DatabaseReclaimPolicy { get; set; }

    /// <summary>
    /// Maps to the `ENCODING` parameter of `CREATE DATABASE`. This setting
    /// cannot be changed. Character set encoding to use in the database.
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>Ensure the PostgreSQL database is `present` or `absent` - defaults to &quot;present&quot;.</summary>
    [JsonPropertyName("ensure")]
    public V1DatabaseSpecEnsureEnum? Ensure { get; set; }

    /// <summary>The list of extensions to be managed in the database</summary>
    [JsonPropertyName("extensions")]
    public IList<V1DatabaseSpecExtensions>? Extensions { get; set; }

    /// <summary>The list of foreign data wrappers to be managed in the database</summary>
    [JsonPropertyName("fdws")]
    public IList<V1DatabaseSpecFdws>? Fdws { get; set; }

    /// <summary>
    /// Maps to the `ICU_LOCALE` parameter of `CREATE DATABASE`. This
    /// setting cannot be changed. Specifies the ICU locale when the ICU
    /// provider is used. This option requires `localeProvider` to be set to
    /// `icu`. Available from PostgreSQL 15.
    /// </summary>
    [JsonPropertyName("icuLocale")]
    public string? IcuLocale { get; set; }

    /// <summary>
    /// Maps to the `ICU_RULES` parameter of `CREATE DATABASE`. This setting
    /// cannot be changed. Specifies additional collation rules to customize
    /// the behavior of the default collation. This option requires
    /// `localeProvider` to be set to `icu`. Available from PostgreSQL 16.
    /// </summary>
    [JsonPropertyName("icuRules")]
    public string? IcuRules { get; set; }

    /// <summary>
    /// Maps to the `IS_TEMPLATE` parameter of `CREATE DATABASE` and `ALTER
    /// DATABASE`. If true, this database is considered a template and can
    /// be cloned by any user with `CREATEDB` privileges.
    /// </summary>
    [JsonPropertyName("isTemplate")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Maps to the `LOCALE` parameter of `CREATE DATABASE`. This setting
    /// cannot be changed. Sets the default collation order and character
    /// classification in the new database.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// Maps to the `LC_CTYPE` parameter of `CREATE DATABASE`. This setting
    /// cannot be changed.
    /// </summary>
    [JsonPropertyName("localeCType")]
    public string? LocaleCType { get; set; }

    /// <summary>
    /// Maps to the `LC_COLLATE` parameter of `CREATE DATABASE`. This
    /// setting cannot be changed.
    /// </summary>
    [JsonPropertyName("localeCollate")]
    public string? LocaleCollate { get; set; }

    /// <summary>
    /// Maps to the `LOCALE_PROVIDER` parameter of `CREATE DATABASE`. This
    /// setting cannot be changed. This option sets the locale provider for
    /// databases created in the new cluster. Available from PostgreSQL 16.
    /// </summary>
    [JsonPropertyName("localeProvider")]
    public string? LocaleProvider { get; set; }

    /// <summary>The name of the database to create inside PostgreSQL. This setting cannot be changed.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Maps to the `OWNER` parameter of `CREATE DATABASE`.
    /// Maps to the `OWNER TO` command of `ALTER DATABASE`.
    /// The role name of the user who owns the database inside PostgreSQL.
    /// </summary>
    [JsonPropertyName("owner")]
    public required string Owner { get; set; }

    /// <summary>The list of schemas to be managed in the database</summary>
    [JsonPropertyName("schemas")]
    public IList<V1DatabaseSpecSchemas>? Schemas { get; set; }

    /// <summary>The list of foreign servers to be managed in the database</summary>
    [JsonPropertyName("servers")]
    public IList<V1DatabaseSpecServers>? Servers { get; set; }

    /// <summary>
    /// Maps to the `TABLESPACE` parameter of `CREATE DATABASE`.
    /// Maps to the `SET TABLESPACE` command of `ALTER DATABASE`.
    /// The name of the tablespace (in PostgreSQL) that will be associated
    /// with the new database. This tablespace will be the default
    /// tablespace used for objects created in this database.
    /// </summary>
    [JsonPropertyName("tablespace")]
    public string? Tablespace { get; set; }

    /// <summary>
    /// Maps to the `TEMPLATE` parameter of `CREATE DATABASE`. This setting
    /// cannot be changed. The name of the template from which to create
    /// this database.
    /// </summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }
}

/// <summary>DatabaseObjectStatus is the status of the managed database objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseStatusExtensions
{
    /// <summary>
    /// True of the object has been installed successfully in
    /// the database
    /// </summary>
    [JsonPropertyName("applied")]
    public required bool Applied { get; set; }

    /// <summary>Message is the object reconciliation message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The name of the object</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DatabaseObjectStatus is the status of the managed database objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseStatusFdws
{
    /// <summary>
    /// True of the object has been installed successfully in
    /// the database
    /// </summary>
    [JsonPropertyName("applied")]
    public required bool Applied { get; set; }

    /// <summary>Message is the object reconciliation message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The name of the object</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DatabaseObjectStatus is the status of the managed database objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseStatusSchemas
{
    /// <summary>
    /// True of the object has been installed successfully in
    /// the database
    /// </summary>
    [JsonPropertyName("applied")]
    public required bool Applied { get; set; }

    /// <summary>Message is the object reconciliation message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The name of the object</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DatabaseObjectStatus is the status of the managed database objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseStatusServers
{
    /// <summary>
    /// True of the object has been installed successfully in
    /// the database
    /// </summary>
    [JsonPropertyName("applied")]
    public required bool Applied { get; set; }

    /// <summary>Message is the object reconciliation message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The name of the object</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Most recently observed status of the Database. This data may not be up to
/// date. Populated by the system. Read-only.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1DatabaseStatus
{
    /// <summary>Applied is true if the database was reconciled correctly</summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }

    /// <summary>Extensions is the status of the managed extensions</summary>
    [JsonPropertyName("extensions")]
    public IList<V1DatabaseStatusExtensions>? Extensions { get; set; }

    /// <summary>FDWs is the status of the managed FDWs</summary>
    [JsonPropertyName("fdws")]
    public IList<V1DatabaseStatusFdws>? Fdws { get; set; }

    /// <summary>Message is the reconciliation output message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// A sequence number representing the latest
    /// desired state that was synchronized
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Schemas is the status of the managed schemas</summary>
    [JsonPropertyName("schemas")]
    public IList<V1DatabaseStatusSchemas>? Schemas { get; set; }

    /// <summary>Servers is the status of the managed servers</summary>
    [JsonPropertyName("servers")]
    public IList<V1DatabaseStatusServers>? Servers { get; set; }
}

/// <summary>Database is the Schema for the databases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Database : IKubernetesObject<V1ObjectMeta>, ISpec<V1DatabaseSpec>, IStatus<V1DatabaseStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Database";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "databases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgresql.cnpg.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Database";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired Database.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1DatabaseSpec Spec { get; set; }

    /// <summary>
    /// Most recently observed status of the Database. This data may not be up to
    /// date. Populated by the system. Read-only.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("status")]
    public V1DatabaseStatus? Status { get; set; }
}