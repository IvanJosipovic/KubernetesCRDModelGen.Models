#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.gcp.upbound.io;
/// <summary>Database is the Schema for the Databases API. A Cloud Spanner Database which is hosted on a Spanner instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Database>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DatabaseList";
    public const string KubeGroup = "spanner.gcp.upbound.io";
    public const string KubePluralName = "databases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Database objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Database> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecDeletionPolicyEnum>))]
public enum V1beta2DatabaseSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Encryption configuration for the database
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecForProviderEncryptionConfig
{
    /// <summary>
    /// Fully qualified name of the KMS key to use to encrypt this database. This key must exist
    /// in the same location as the Spanner Database.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    [JsonPropertyName("kmsKeyNames")]
    public IList<string>? KmsKeyNames { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecForProviderInstanceRefPolicyResolutionEnum>))]
public enum V1beta2DatabaseSpecForProviderInstanceRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecForProviderInstanceRefPolicyResolveEnum>))]
public enum V1beta2DatabaseSpecForProviderInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecForProviderInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatabaseSpecForProviderInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatabaseSpecForProviderInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in spanner to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecForProviderInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatabaseSpecForProviderInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecForProviderInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta2DatabaseSpecForProviderInstanceSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecForProviderInstanceSelectorPolicyResolveEnum>))]
public enum V1beta2DatabaseSpecForProviderInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecForProviderInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatabaseSpecForProviderInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatabaseSpecForProviderInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in spanner to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecForProviderInstanceSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatabaseSpecForProviderInstanceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecForProvider
{
    /// <summary>
    /// The dialect of the Cloud Spanner Database.
    /// If it is not provided, &quot;GOOGLE_STANDARD_SQL&quot; will be used.
    /// Possible values are: GOOGLE_STANDARD_SQL, POSTGRESQL.
    /// </summary>
    [JsonPropertyName("databaseDialect")]
    public string? DatabaseDialect { get; set; }

    /// <summary>
    /// An optional list of DDL statements to run inside the database. Statements can create
    /// tables, indexes, etc.
    /// During creation these statements execute atomically with the creation of the database
    /// and if there is an error in any statement, the database is not created. Limited updates to this field are supported, and
    /// newly appended DDL statements can be executed in an update. However, modifications
    /// to prior statements will create a plan that marks the resource for recreation.
    /// </summary>
    [JsonPropertyName("ddl")]
    public IList<string>? Ddl { get; set; }

    /// <summary>
    /// The default time zone for the database. The default time zone must be a valid name
    /// from the tz database. Default value is &quot;America/Los_angeles&quot;.
    /// </summary>
    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; set; }

    /// <summary>
    /// Defaults to true.
    /// When the field is set to false, deleting the database is allowed.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>
    /// Whether drop protection is enabled for this database. Defaults to false.
    /// whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces.
    /// (2) Setting &quot;enableDropProtection&quot; to true also prevents the deletion of the parent instance containing the database.
    /// &quot;deletion_protection&quot; attribute does not provide protection against the deletion of the parent instance.
    /// </summary>
    [JsonPropertyName("enableDropProtection")]
    public bool? EnableDropProtection { get; set; }

    /// <summary>
    /// Encryption configuration for the database
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2DatabaseSpecForProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The instance to create the database on.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in spanner to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta2DatabaseSpecForProviderInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in spanner to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta2DatabaseSpecForProviderInstanceSelector? InstanceSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The retention period for the database. The retention period must be between 1 hour
    /// and 7 days, and can be specified in days, hours, minutes, or seconds. For example,
    /// the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h.
    /// If this property is used, you must avoid adding new DDL statements to ddl that
    /// update the database&apos;s version_retention_period.
    /// </summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>
/// Encryption configuration for the database
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecInitProviderEncryptionConfig
{
    /// <summary>
    /// Fully qualified name of the KMS key to use to encrypt this database. This key must exist
    /// in the same location as the Spanner Database.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    [JsonPropertyName("kmsKeyNames")]
    public IList<string>? KmsKeyNames { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecInitProvider
{
    /// <summary>
    /// The dialect of the Cloud Spanner Database.
    /// If it is not provided, &quot;GOOGLE_STANDARD_SQL&quot; will be used.
    /// Possible values are: GOOGLE_STANDARD_SQL, POSTGRESQL.
    /// </summary>
    [JsonPropertyName("databaseDialect")]
    public string? DatabaseDialect { get; set; }

    /// <summary>
    /// An optional list of DDL statements to run inside the database. Statements can create
    /// tables, indexes, etc.
    /// During creation these statements execute atomically with the creation of the database
    /// and if there is an error in any statement, the database is not created. Limited updates to this field are supported, and
    /// newly appended DDL statements can be executed in an update. However, modifications
    /// to prior statements will create a plan that marks the resource for recreation.
    /// </summary>
    [JsonPropertyName("ddl")]
    public IList<string>? Ddl { get; set; }

    /// <summary>
    /// The default time zone for the database. The default time zone must be a valid name
    /// from the tz database. Default value is &quot;America/Los_angeles&quot;.
    /// </summary>
    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; set; }

    /// <summary>
    /// Defaults to true.
    /// When the field is set to false, deleting the database is allowed.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>
    /// Whether drop protection is enabled for this database. Defaults to false.
    /// whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces.
    /// (2) Setting &quot;enableDropProtection&quot; to true also prevents the deletion of the parent instance containing the database.
    /// &quot;deletion_protection&quot; attribute does not provide protection against the deletion of the parent instance.
    /// </summary>
    [JsonPropertyName("enableDropProtection")]
    public bool? EnableDropProtection { get; set; }

    /// <summary>
    /// Encryption configuration for the database
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2DatabaseSpecInitProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The retention period for the database. The retention period must be between 1 hour
    /// and 7 days, and can be specified in days, hours, minutes, or seconds. For example,
    /// the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h.
    /// If this property is used, you must avoid adding new DDL statements to ddl that
    /// update the database&apos;s version_retention_period.
    /// </summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecManagementPoliciesEnum>))]
public enum V1beta2DatabaseSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DatabaseSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DatabaseSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DatabaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DatabaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DatabaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DatabaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DatabaseSpec defines the desired state of Database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2DatabaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DatabaseSpecForProvider ForProvider { get; set; }

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
    public V1beta2DatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2DatabaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Encryption configuration for the database
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseStatusAtProviderEncryptionConfig
{
    /// <summary>
    /// Fully qualified name of the KMS key to use to encrypt this database. This key must exist
    /// in the same location as the Spanner Database.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Fully qualified name of the KMS keys to use to encrypt this database. The keys must exist
    /// in the same locations as the Spanner Database.
    /// </summary>
    [JsonPropertyName("kmsKeyNames")]
    public IList<string>? KmsKeyNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseStatusAtProvider
{
    /// <summary>
    /// The dialect of the Cloud Spanner Database.
    /// If it is not provided, &quot;GOOGLE_STANDARD_SQL&quot; will be used.
    /// Possible values are: GOOGLE_STANDARD_SQL, POSTGRESQL.
    /// </summary>
    [JsonPropertyName("databaseDialect")]
    public string? DatabaseDialect { get; set; }

    /// <summary>
    /// An optional list of DDL statements to run inside the database. Statements can create
    /// tables, indexes, etc.
    /// During creation these statements execute atomically with the creation of the database
    /// and if there is an error in any statement, the database is not created. Limited updates to this field are supported, and
    /// newly appended DDL statements can be executed in an update. However, modifications
    /// to prior statements will create a plan that marks the resource for recreation.
    /// </summary>
    [JsonPropertyName("ddl")]
    public IList<string>? Ddl { get; set; }

    /// <summary>
    /// The default time zone for the database. The default time zone must be a valid name
    /// from the tz database. Default value is &quot;America/Los_angeles&quot;.
    /// </summary>
    [JsonPropertyName("defaultTimeZone")]
    public string? DefaultTimeZone { get; set; }

    /// <summary>
    /// Defaults to true.
    /// When the field is set to false, deleting the database is allowed.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>
    /// Whether drop protection is enabled for this database. Defaults to false.
    /// whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces.
    /// (2) Setting &quot;enableDropProtection&quot; to true also prevents the deletion of the parent instance containing the database.
    /// &quot;deletion_protection&quot; attribute does not provide protection against the deletion of the parent instance.
    /// </summary>
    [JsonPropertyName("enableDropProtection")]
    public bool? EnableDropProtection { get; set; }

    /// <summary>
    /// Encryption configuration for the database
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2DatabaseStatusAtProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>an identifier for the resource with format {{instance}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The instance to create the database on.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>An explanation of the status of the database.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The retention period for the database. The retention period must be between 1 hour
    /// and 7 days, and can be specified in days, hours, minutes, or seconds. For example,
    /// the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h.
    /// If this property is used, you must avoid adding new DDL statements to ddl that
    /// update the database&apos;s version_retention_period.
    /// </summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseStatusConditions
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

/// <summary>DatabaseStatus defines the observed state of Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DatabaseStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Database is the Schema for the Databases API. A Cloud Spanner Database which is hosted on a Spanner instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Database : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DatabaseSpec>, IStatus<V1beta2DatabaseStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Database";
    public const string KubeGroup = "spanner.gcp.upbound.io";
    public const string KubePluralName = "databases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Database";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatabaseSpec defines the desired state of Database</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DatabaseSpec Spec { get; set; }

    /// <summary>DatabaseStatus defines the observed state of Database.</summary>
    [JsonPropertyName("status")]
    public V1beta2DatabaseStatus? Status { get; set; }
}