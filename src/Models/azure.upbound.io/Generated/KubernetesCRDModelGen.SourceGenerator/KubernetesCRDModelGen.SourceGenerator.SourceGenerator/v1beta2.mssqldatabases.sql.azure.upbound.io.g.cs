#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.upbound.io;
/// <summary>MSSQLDatabase is the Schema for the MSSQLDatabases API. Manages a MS SQL Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MSSQLDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MSSQLDatabase>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MSSQLDatabaseList";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqldatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MSSQLDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MSSQLDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MSSQLDatabase> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecDeletionPolicyEnum>))]
public enum V1beta2MSSQLDatabaseSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelector
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
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelector
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
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Database.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Database. Possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies the password of the SQL administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderImportAdministratorLoginPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Specifies the access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderImportStorageKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A import block as documented below. Mutually exclusive with create_mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderImport
{
    /// <summary>Specifies the name of the SQL administrator.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Specifies the password of the SQL administrator.</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public V1beta2MSSQLDatabaseSpecForProviderImportAdministratorLoginPasswordSecretRef? AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>Specifies the type of authentication used to access the server. Valid values are SQL or ADPassword.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The resource id for the storage account used to store BACPAC file. If set, private endpoint connection will be created for the storage account. Must match storage account used for storage_uri parameter.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the access key for the storage account.</summary>
    [JsonPropertyName("storageKeySecretRef")]
    public V1beta2MSSQLDatabaseSpecForProviderImportStorageKeySecretRef? StorageKeySecretRef { get; set; }

    /// <summary>Specifies the type of access key for the storage account. Valid values are StorageAccessKey or SharedAccessKey.</summary>
    [JsonPropertyName("storageKeyType")]
    public string? StorageKeyType { get; set; }

    /// <summary>Specifies the blob URI of the .bacpac file.</summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>A long_term_retention_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderLongTermRetentionPolicy
{
    /// <summary>Specifies if the backups are immutable. Defaults to false.</summary>
    [JsonPropertyName("immutableBackupsEnabled")]
    public bool? ImmutableBackupsEnabled { get; set; }

    /// <summary>The monthly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 120 months. e.g. P1Y, P1M, P4W or P30D. Defaults to PT0S.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>The week of year to take the yearly backup. Value has to be between 1 and 52.</summary>
    [JsonPropertyName("weekOfYear")]
    public double? WeekOfYear { get; set; }

    /// <summary>The weekly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 520 weeks. e.g. P1Y, P1M, P1W or P7D. Defaults to PT0S.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>The yearly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 10 years. e.g. P1Y, P12M, P52W or P365D. Defaults to PT0S.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLServer in sql to populate serverId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderServerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLServer in sql to populate serverId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderServerIdSelector
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
    public V1beta2MSSQLDatabaseSpecForProviderServerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A short_term_retention_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderShortTermRetentionPolicy
{
    /// <summary>The hours between each differential backup. This is only applicable to live databases but not dropped databases. Value has to be 12 or 24. Defaults to 12 hours.</summary>
    [JsonPropertyName("backupIntervalInHours")]
    public double? BackupIntervalInHours { get; set; }

    /// <summary>Point In Time Restore configuration. Value has to be between 1 and 35.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }
}

/// <summary>Specifies the identifier key of the Threat Detection audit storage account. Required if state is Enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Threat detection policy configuration. The threat_detection_policy block supports fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderThreatDetectionPolicy
{
    /// <summary>Specifies a list of alerts which should be disabled. Possible values include Access_Anomaly, Sql_Injection and Sql_Injection_Vulnerability.</summary>
    [JsonPropertyName("disabledAlerts")]
    public IList<string>? DisabledAlerts { get; set; }

    /// <summary>Should the account administrators be emailed when this alert is triggered? Possible values are Enabled or Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("emailAccountAdmins")]
    public string? EmailAccountAdmins { get; set; }

    /// <summary>A list of email addresses which alerts should be sent to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>The State of the Policy. Possible values are Enabled or Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Specifies the identifier key of the Threat Detection audit storage account. Required if state is Enabled.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta2MSSQLDatabaseSpecForProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>Specifies the blob storage endpoint (e.g. https://example.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. Required if state is Enabled.</summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelector
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
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecForProvider
{
    /// <summary>Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. This property is only settable for Serverless databases.</summary>
    [JsonPropertyName("autoPauseDelayInMinutes")]
    public double? AutoPauseDelayInMinutes { get; set; }

    /// <summary>Specifies the collation of the database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The create mode of the database. Possible values are Copy, Default, OnlineSecondary, PointInTimeRestore, Recovery, Restore, RestoreExternalBackup, RestoreExternalBackupSecondary, RestoreLongTermRetentionBackup and Secondary. Mutually exclusive with import. Changing this forces a new resource to be created. Defaults to Default.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>The ID of the source database from which to create the new database. This should only be used for databases with create_mode values that use another database as reference. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("creationSourceDatabaseId")]
    public string? CreationSourceDatabaseId { get; set; }

    /// <summary>Specifies the ID of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolId")]
    public string? ElasticPoolId { get; set; }

    /// <summary>Reference to a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
    [JsonPropertyName("elasticPoolIdRef")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdRef? ElasticPoolIdRef { get; set; }

    /// <summary>Selector for a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
    [JsonPropertyName("elasticPoolIdSelector")]
    public V1beta2MSSQLDatabaseSpecForProviderElasticPoolIdSelector? ElasticPoolIdSelector { get; set; }

    /// <summary>Specifies the type of enclave to be used by the elastic pool. When enclave_type is not specified (e.g., the default) enclaves are not enabled on the database. Once enabled (e.g., by specifying Default or VBS) removing the enclave_type field from the configuration file will force the creation of a new resource. Possible values are Default or VBS.</summary>
    [JsonPropertyName("enclaveType")]
    public string? EnclaveType { get; set; }

    /// <summary>A boolean that specifies if the Geo Backup Policy is enabled. Defaults to true.</summary>
    [JsonPropertyName("geoBackupEnabled")]
    public bool? GeoBackupEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2MSSQLDatabaseSpecForProviderIdentity? Identity { get; set; }

    /// <summary>A import block as documented below. Mutually exclusive with create_mode.</summary>
    [JsonPropertyName("import")]
    public V1beta2MSSQLDatabaseSpecForProviderImport? Import { get; set; }

    /// <summary>A boolean that specifies if this is a ledger database. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ledgerEnabled")]
    public bool? LedgerEnabled { get; set; }

    /// <summary>Specifies the license type applied to this database. Possible values are LicenseIncluded and BasePrice.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>A long_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("longTermRetentionPolicy")]
    public V1beta2MSSQLDatabaseSpecForProviderLongTermRetentionPolicy? LongTermRetentionPolicy { get; set; }

    /// <summary>The name of the Public Maintenance Configuration window to apply to the database. Valid values include SQL_Default, SQL_EastUS_DB_1, SQL_EastUS2_DB_1, SQL_SoutheastAsia_DB_1, SQL_AustraliaEast_DB_1, SQL_NorthEurope_DB_1, SQL_SouthCentralUS_DB_1, SQL_WestUS2_DB_1, SQL_UKSouth_DB_1, SQL_WestEurope_DB_1, SQL_EastUS_DB_2, SQL_EastUS2_DB_2, SQL_WestUS2_DB_2, SQL_SoutheastAsia_DB_2, SQL_AustraliaEast_DB_2, SQL_NorthEurope_DB_2, SQL_SouthCentralUS_DB_2, SQL_UKSouth_DB_2, SQL_WestEurope_DB_2, SQL_AustraliaSoutheast_DB_1, SQL_BrazilSouth_DB_1, SQL_CanadaCentral_DB_1, SQL_CanadaEast_DB_1, SQL_CentralUS_DB_1, SQL_EastAsia_DB_1, SQL_FranceCentral_DB_1, SQL_GermanyWestCentral_DB_1, SQL_CentralIndia_DB_1, SQL_SouthIndia_DB_1, SQL_JapanEast_DB_1, SQL_JapanWest_DB_1, SQL_NorthCentralUS_DB_1, SQL_UKWest_DB_1, SQL_WestUS_DB_1, SQL_AustraliaSoutheast_DB_2, SQL_BrazilSouth_DB_2, SQL_CanadaCentral_DB_2, SQL_CanadaEast_DB_2, SQL_CentralUS_DB_2, SQL_EastAsia_DB_2, SQL_FranceCentral_DB_2, SQL_GermanyWestCentral_DB_2, SQL_CentralIndia_DB_2, SQL_SouthIndia_DB_2, SQL_JapanEast_DB_2, SQL_JapanWest_DB_2, SQL_NorthCentralUS_DB_2, SQL_UKWest_DB_2, SQL_WestUS_DB_2, SQL_WestCentralUS_DB_1, SQL_FranceSouth_DB_1, SQL_WestCentralUS_DB_2, SQL_FranceSouth_DB_2, SQL_SwitzerlandNorth_DB_1, SQL_SwitzerlandNorth_DB_2, SQL_BrazilSoutheast_DB_1, SQL_UAENorth_DB_1, SQL_BrazilSoutheast_DB_2, SQL_UAENorth_DB_2, SQL_SouthAfricaNorth_DB_1, SQL_SouthAfricaNorth_DB_2, SQL_WestUS3_DB_1, SQL_WestUS3_DB_2, SQL_SwedenCentral_DB_1, SQL_SwedenCentral_DB_2. Defaults to SQL_Default.</summary>
    [JsonPropertyName("maintenanceConfigurationName")]
    public string? MaintenanceConfigurationName { get; set; }

    /// <summary>The max size of the database in gigabytes.</summary>
    [JsonPropertyName("maxSizeGb")]
    public double? MaxSizeGb { get; set; }

    /// <summary>Minimal capacity that database will always have allocated, if not paused. This property is only settable for Serverless databases.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases.</summary>
    [JsonPropertyName("readReplicaCount")]
    public double? ReadReplicaCount { get; set; }

    /// <summary>If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases.</summary>
    [JsonPropertyName("readScale")]
    public bool? ReadScale { get; set; }

    /// <summary>The ID of the database to be recovered. This property is only applicable when the create_mode is Recovery.</summary>
    [JsonPropertyName("recoverDatabaseId")]
    public string? RecoverDatabaseId { get; set; }

    /// <summary>The ID of the Recovery Services Recovery Point Id to be restored. This property is only applicable when the create_mode is Recovery.</summary>
    [JsonPropertyName("recoveryPointId")]
    public string? RecoveryPointId { get; set; }

    /// <summary>The ID of the database to be restored. This property is only applicable when the create_mode is Restore.</summary>
    [JsonPropertyName("restoreDroppedDatabaseId")]
    public string? RestoreDroppedDatabaseId { get; set; }

    /// <summary>The ID of the long term retention backup to be restored. This property is only applicable when the create_mode is RestoreLongTermRetentionBackup.</summary>
    [JsonPropertyName("restoreLongTermRetentionBackupId")]
    public string? RestoreLongTermRetentionBackupId { get; set; }

    /// <summary>Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. This property is only settable for create_mode= PointInTimeRestore databases.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Specifies the name of the sample schema to apply when creating this database. Possible value is AdventureWorksLT.</summary>
    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    /// <summary>How do you want your replica to be made? Valid values include Geo, Named and Standby. Defaults to Geo. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>The id of the MS SQL Server on which to create the database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serverId")]
    public string? ServerId { get; set; }

    /// <summary>Reference to a MSSQLServer in sql to populate serverId.</summary>
    [JsonPropertyName("serverIdRef")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdRef? ServerIdRef { get; set; }

    /// <summary>Selector for a MSSQLServer in sql to populate serverId.</summary>
    [JsonPropertyName("serverIdSelector")]
    public V1beta2MSSQLDatabaseSpecForProviderServerIdSelector? ServerIdSelector { get; set; }

    /// <summary>A short_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("shortTermRetentionPolicy")]
    public V1beta2MSSQLDatabaseSpecForProviderShortTermRetentionPolicy? ShortTermRetentionPolicy { get; set; }

    /// <summary>Specifies the name of the SKU used by the database. For example, GP_S_Gen5_2,HS_Gen4_1,BC_Gen5_2, ElasticPool, Basic,S0, P2 ,DW100c, DS100. Changing this from the HyperScale service tier to another service tier will create a new resource.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the storage account type used to store backups for this database. Possible values are Geo, GeoZone, Local and Zone. Defaults to Geo.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Threat detection policy configuration. The threat_detection_policy block supports fields documented below.</summary>
    [JsonPropertyName("threatDetectionPolicy")]
    public V1beta2MSSQLDatabaseSpecForProviderThreatDetectionPolicy? ThreatDetectionPolicy { get; set; }

    /// <summary>If set to true, Transparent Data Encryption will be enabled on the database. Defaults to true.</summary>
    [JsonPropertyName("transparentDataEncryptionEnabled")]
    public bool? TransparentDataEncryptionEnabled { get; set; }

    /// <summary>Boolean flag to specify whether TDE automatically rotates the encryption Key to latest version or not. Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyAutomaticRotationEnabled")]
    public bool? TransparentDataEncryptionKeyAutomaticRotationEnabled { get; set; }

    /// <summary>The fully versioned Key Vault Key URL (e.g. &apos;https://&lt;YourVaultName&gt;.vault.azure.net/keys/&lt;YourKeyName&gt;/&lt;YourKeyVersion&gt;) to be used as the Customer Managed Key(CMK/BYOK) for the Transparent Data Encryption(TDE) layer.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyId")]
    public string? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdRef")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRef? TransparentDataEncryptionKeyVaultKeyIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdSelector")]
    public V1beta2MSSQLDatabaseSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelector? TransparentDataEncryptionKeyVaultKeyIdSelector { get; set; }

    /// <summary>Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. This property is only settable for Premium and Business Critical databases.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelector
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
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelector
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
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Database.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Database. Possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Specifies the password of the SQL administrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderImportAdministratorLoginPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Specifies the access key for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderImportStorageKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A import block as documented below. Mutually exclusive with create_mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderImport
{
    /// <summary>Specifies the name of the SQL administrator.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Specifies the password of the SQL administrator.</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public required V1beta2MSSQLDatabaseSpecInitProviderImportAdministratorLoginPasswordSecretRef AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>Specifies the type of authentication used to access the server. Valid values are SQL or ADPassword.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The resource id for the storage account used to store BACPAC file. If set, private endpoint connection will be created for the storage account. Must match storage account used for storage_uri parameter.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the access key for the storage account.</summary>
    [JsonPropertyName("storageKeySecretRef")]
    public required V1beta2MSSQLDatabaseSpecInitProviderImportStorageKeySecretRef StorageKeySecretRef { get; set; }

    /// <summary>Specifies the type of access key for the storage account. Valid values are StorageAccessKey or SharedAccessKey.</summary>
    [JsonPropertyName("storageKeyType")]
    public string? StorageKeyType { get; set; }

    /// <summary>Specifies the blob URI of the .bacpac file.</summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>A long_term_retention_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderLongTermRetentionPolicy
{
    /// <summary>Specifies if the backups are immutable. Defaults to false.</summary>
    [JsonPropertyName("immutableBackupsEnabled")]
    public bool? ImmutableBackupsEnabled { get; set; }

    /// <summary>The monthly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 120 months. e.g. P1Y, P1M, P4W or P30D. Defaults to PT0S.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>The week of year to take the yearly backup. Value has to be between 1 and 52.</summary>
    [JsonPropertyName("weekOfYear")]
    public double? WeekOfYear { get; set; }

    /// <summary>The weekly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 520 weeks. e.g. P1Y, P1M, P1W or P7D. Defaults to PT0S.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>The yearly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 10 years. e.g. P1Y, P12M, P52W or P365D. Defaults to PT0S.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary>A short_term_retention_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderShortTermRetentionPolicy
{
    /// <summary>The hours between each differential backup. This is only applicable to live databases but not dropped databases. Value has to be 12 or 24. Defaults to 12 hours.</summary>
    [JsonPropertyName("backupIntervalInHours")]
    public double? BackupIntervalInHours { get; set; }

    /// <summary>Point In Time Restore configuration. Value has to be between 1 and 35.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }
}

/// <summary>Specifies the identifier key of the Threat Detection audit storage account. Required if state is Enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Threat detection policy configuration. The threat_detection_policy block supports fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderThreatDetectionPolicy
{
    /// <summary>Specifies a list of alerts which should be disabled. Possible values include Access_Anomaly, Sql_Injection and Sql_Injection_Vulnerability.</summary>
    [JsonPropertyName("disabledAlerts")]
    public IList<string>? DisabledAlerts { get; set; }

    /// <summary>Should the account administrators be emailed when this alert is triggered? Possible values are Enabled or Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("emailAccountAdmins")]
    public string? EmailAccountAdmins { get; set; }

    /// <summary>A list of email addresses which alerts should be sent to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>The State of the Policy. Possible values are Enabled or Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Specifies the identifier key of the Threat Detection audit storage account. Required if state is Enabled.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta2MSSQLDatabaseSpecInitProviderThreatDetectionPolicyStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>Specifies the blob storage endpoint (e.g. https://example.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. Required if state is Enabled.</summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelector
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
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2MSSQLDatabaseSpecInitProvider
{
    /// <summary>Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. This property is only settable for Serverless databases.</summary>
    [JsonPropertyName("autoPauseDelayInMinutes")]
    public double? AutoPauseDelayInMinutes { get; set; }

    /// <summary>Specifies the collation of the database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The create mode of the database. Possible values are Copy, Default, OnlineSecondary, PointInTimeRestore, Recovery, Restore, RestoreExternalBackup, RestoreExternalBackupSecondary, RestoreLongTermRetentionBackup and Secondary. Mutually exclusive with import. Changing this forces a new resource to be created. Defaults to Default.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>The ID of the source database from which to create the new database. This should only be used for databases with create_mode values that use another database as reference. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("creationSourceDatabaseId")]
    public string? CreationSourceDatabaseId { get; set; }

    /// <summary>Specifies the ID of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolId")]
    public string? ElasticPoolId { get; set; }

    /// <summary>Reference to a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
    [JsonPropertyName("elasticPoolIdRef")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdRef? ElasticPoolIdRef { get; set; }

    /// <summary>Selector for a MSSQLElasticPool in sql to populate elasticPoolId.</summary>
    [JsonPropertyName("elasticPoolIdSelector")]
    public V1beta2MSSQLDatabaseSpecInitProviderElasticPoolIdSelector? ElasticPoolIdSelector { get; set; }

    /// <summary>Specifies the type of enclave to be used by the elastic pool. When enclave_type is not specified (e.g., the default) enclaves are not enabled on the database. Once enabled (e.g., by specifying Default or VBS) removing the enclave_type field from the configuration file will force the creation of a new resource. Possible values are Default or VBS.</summary>
    [JsonPropertyName("enclaveType")]
    public string? EnclaveType { get; set; }

    /// <summary>A boolean that specifies if the Geo Backup Policy is enabled. Defaults to true.</summary>
    [JsonPropertyName("geoBackupEnabled")]
    public bool? GeoBackupEnabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2MSSQLDatabaseSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>A import block as documented below. Mutually exclusive with create_mode.</summary>
    [JsonPropertyName("import")]
    public V1beta2MSSQLDatabaseSpecInitProviderImport? Import { get; set; }

    /// <summary>A boolean that specifies if this is a ledger database. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ledgerEnabled")]
    public bool? LedgerEnabled { get; set; }

    /// <summary>Specifies the license type applied to this database. Possible values are LicenseIncluded and BasePrice.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>A long_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("longTermRetentionPolicy")]
    public V1beta2MSSQLDatabaseSpecInitProviderLongTermRetentionPolicy? LongTermRetentionPolicy { get; set; }

    /// <summary>The name of the Public Maintenance Configuration window to apply to the database. Valid values include SQL_Default, SQL_EastUS_DB_1, SQL_EastUS2_DB_1, SQL_SoutheastAsia_DB_1, SQL_AustraliaEast_DB_1, SQL_NorthEurope_DB_1, SQL_SouthCentralUS_DB_1, SQL_WestUS2_DB_1, SQL_UKSouth_DB_1, SQL_WestEurope_DB_1, SQL_EastUS_DB_2, SQL_EastUS2_DB_2, SQL_WestUS2_DB_2, SQL_SoutheastAsia_DB_2, SQL_AustraliaEast_DB_2, SQL_NorthEurope_DB_2, SQL_SouthCentralUS_DB_2, SQL_UKSouth_DB_2, SQL_WestEurope_DB_2, SQL_AustraliaSoutheast_DB_1, SQL_BrazilSouth_DB_1, SQL_CanadaCentral_DB_1, SQL_CanadaEast_DB_1, SQL_CentralUS_DB_1, SQL_EastAsia_DB_1, SQL_FranceCentral_DB_1, SQL_GermanyWestCentral_DB_1, SQL_CentralIndia_DB_1, SQL_SouthIndia_DB_1, SQL_JapanEast_DB_1, SQL_JapanWest_DB_1, SQL_NorthCentralUS_DB_1, SQL_UKWest_DB_1, SQL_WestUS_DB_1, SQL_AustraliaSoutheast_DB_2, SQL_BrazilSouth_DB_2, SQL_CanadaCentral_DB_2, SQL_CanadaEast_DB_2, SQL_CentralUS_DB_2, SQL_EastAsia_DB_2, SQL_FranceCentral_DB_2, SQL_GermanyWestCentral_DB_2, SQL_CentralIndia_DB_2, SQL_SouthIndia_DB_2, SQL_JapanEast_DB_2, SQL_JapanWest_DB_2, SQL_NorthCentralUS_DB_2, SQL_UKWest_DB_2, SQL_WestUS_DB_2, SQL_WestCentralUS_DB_1, SQL_FranceSouth_DB_1, SQL_WestCentralUS_DB_2, SQL_FranceSouth_DB_2, SQL_SwitzerlandNorth_DB_1, SQL_SwitzerlandNorth_DB_2, SQL_BrazilSoutheast_DB_1, SQL_UAENorth_DB_1, SQL_BrazilSoutheast_DB_2, SQL_UAENorth_DB_2, SQL_SouthAfricaNorth_DB_1, SQL_SouthAfricaNorth_DB_2, SQL_WestUS3_DB_1, SQL_WestUS3_DB_2, SQL_SwedenCentral_DB_1, SQL_SwedenCentral_DB_2. Defaults to SQL_Default.</summary>
    [JsonPropertyName("maintenanceConfigurationName")]
    public string? MaintenanceConfigurationName { get; set; }

    /// <summary>The max size of the database in gigabytes.</summary>
    [JsonPropertyName("maxSizeGb")]
    public double? MaxSizeGb { get; set; }

    /// <summary>Minimal capacity that database will always have allocated, if not paused. This property is only settable for Serverless databases.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases.</summary>
    [JsonPropertyName("readReplicaCount")]
    public double? ReadReplicaCount { get; set; }

    /// <summary>If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases.</summary>
    [JsonPropertyName("readScale")]
    public bool? ReadScale { get; set; }

    /// <summary>The ID of the database to be recovered. This property is only applicable when the create_mode is Recovery.</summary>
    [JsonPropertyName("recoverDatabaseId")]
    public string? RecoverDatabaseId { get; set; }

    /// <summary>The ID of the Recovery Services Recovery Point Id to be restored. This property is only applicable when the create_mode is Recovery.</summary>
    [JsonPropertyName("recoveryPointId")]
    public string? RecoveryPointId { get; set; }

    /// <summary>The ID of the database to be restored. This property is only applicable when the create_mode is Restore.</summary>
    [JsonPropertyName("restoreDroppedDatabaseId")]
    public string? RestoreDroppedDatabaseId { get; set; }

    /// <summary>The ID of the long term retention backup to be restored. This property is only applicable when the create_mode is RestoreLongTermRetentionBackup.</summary>
    [JsonPropertyName("restoreLongTermRetentionBackupId")]
    public string? RestoreLongTermRetentionBackupId { get; set; }

    /// <summary>Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. This property is only settable for create_mode= PointInTimeRestore databases.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Specifies the name of the sample schema to apply when creating this database. Possible value is AdventureWorksLT.</summary>
    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    /// <summary>How do you want your replica to be made? Valid values include Geo, Named and Standby. Defaults to Geo. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>A short_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("shortTermRetentionPolicy")]
    public V1beta2MSSQLDatabaseSpecInitProviderShortTermRetentionPolicy? ShortTermRetentionPolicy { get; set; }

    /// <summary>Specifies the name of the SKU used by the database. For example, GP_S_Gen5_2,HS_Gen4_1,BC_Gen5_2, ElasticPool, Basic,S0, P2 ,DW100c, DS100. Changing this from the HyperScale service tier to another service tier will create a new resource.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the storage account type used to store backups for this database. Possible values are Geo, GeoZone, Local and Zone. Defaults to Geo.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Threat detection policy configuration. The threat_detection_policy block supports fields documented below.</summary>
    [JsonPropertyName("threatDetectionPolicy")]
    public V1beta2MSSQLDatabaseSpecInitProviderThreatDetectionPolicy? ThreatDetectionPolicy { get; set; }

    /// <summary>If set to true, Transparent Data Encryption will be enabled on the database. Defaults to true.</summary>
    [JsonPropertyName("transparentDataEncryptionEnabled")]
    public bool? TransparentDataEncryptionEnabled { get; set; }

    /// <summary>Boolean flag to specify whether TDE automatically rotates the encryption Key to latest version or not. Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyAutomaticRotationEnabled")]
    public bool? TransparentDataEncryptionKeyAutomaticRotationEnabled { get; set; }

    /// <summary>The fully versioned Key Vault Key URL (e.g. &apos;https://&lt;YourVaultName&gt;.vault.azure.net/keys/&lt;YourKeyName&gt;/&lt;YourKeyVersion&gt;) to be used as the Customer Managed Key(CMK/BYOK) for the Transparent Data Encryption(TDE) layer.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyId")]
    public string? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdRef")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRef? TransparentDataEncryptionKeyVaultKeyIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdSelector")]
    public V1beta2MSSQLDatabaseSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelector? TransparentDataEncryptionKeyVaultKeyIdSelector { get; set; }

    /// <summary>Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. This property is only settable for Premium and Business Critical databases.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecManagementPoliciesEnum>))]
public enum V1beta2MSSQLDatabaseSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MSSQLDatabaseSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MSSQLDatabaseSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MSSQLDatabaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MSSQLDatabaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MSSQLDatabaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MSSQLDatabaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MSSQLDatabaseSpec defines the desired state of MSSQLDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseSpec
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
    public V1beta2MSSQLDatabaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MSSQLDatabaseSpecForProvider ForProvider { get; set; }

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
    public V1beta2MSSQLDatabaseSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2MSSQLDatabaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MSSQLDatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MSSQLDatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Database.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Database. Possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A import block as documented below. Mutually exclusive with create_mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusAtProviderImport
{
    /// <summary>Specifies the name of the SQL administrator.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>Specifies the type of authentication used to access the server. Valid values are SQL or ADPassword.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The resource id for the storage account used to store BACPAC file. If set, private endpoint connection will be created for the storage account. Must match storage account used for storage_uri parameter.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Specifies the type of access key for the storage account. Valid values are StorageAccessKey or SharedAccessKey.</summary>
    [JsonPropertyName("storageKeyType")]
    public string? StorageKeyType { get; set; }

    /// <summary>Specifies the blob URI of the .bacpac file.</summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>A long_term_retention_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusAtProviderLongTermRetentionPolicy
{
    /// <summary>Specifies if the backups are immutable. Defaults to false.</summary>
    [JsonPropertyName("immutableBackupsEnabled")]
    public bool? ImmutableBackupsEnabled { get; set; }

    /// <summary>The monthly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 120 months. e.g. P1Y, P1M, P4W or P30D. Defaults to PT0S.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>The week of year to take the yearly backup. Value has to be between 1 and 52.</summary>
    [JsonPropertyName("weekOfYear")]
    public double? WeekOfYear { get; set; }

    /// <summary>The weekly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 520 weeks. e.g. P1Y, P1M, P1W or P7D. Defaults to PT0S.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>The yearly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 10 years. e.g. P1Y, P12M, P52W or P365D. Defaults to PT0S.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary>A short_term_retention_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusAtProviderShortTermRetentionPolicy
{
    /// <summary>The hours between each differential backup. This is only applicable to live databases but not dropped databases. Value has to be 12 or 24. Defaults to 12 hours.</summary>
    [JsonPropertyName("backupIntervalInHours")]
    public double? BackupIntervalInHours { get; set; }

    /// <summary>Point In Time Restore configuration. Value has to be between 1 and 35.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }
}

/// <summary>Threat detection policy configuration. The threat_detection_policy block supports fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusAtProviderThreatDetectionPolicy
{
    /// <summary>Specifies a list of alerts which should be disabled. Possible values include Access_Anomaly, Sql_Injection and Sql_Injection_Vulnerability.</summary>
    [JsonPropertyName("disabledAlerts")]
    public IList<string>? DisabledAlerts { get; set; }

    /// <summary>Should the account administrators be emailed when this alert is triggered? Possible values are Enabled or Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("emailAccountAdmins")]
    public string? EmailAccountAdmins { get; set; }

    /// <summary>A list of email addresses which alerts should be sent to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Specifies the number of days to keep in the Threat Detection audit logs.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>The State of the Policy. Possible values are Enabled or Disabled. Defaults to Disabled.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Specifies the blob storage endpoint (e.g. https://example.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. Required if state is Enabled.</summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusAtProvider
{
    /// <summary>Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. This property is only settable for Serverless databases.</summary>
    [JsonPropertyName("autoPauseDelayInMinutes")]
    public double? AutoPauseDelayInMinutes { get; set; }

    /// <summary>Specifies the collation of the database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>The create mode of the database. Possible values are Copy, Default, OnlineSecondary, PointInTimeRestore, Recovery, Restore, RestoreExternalBackup, RestoreExternalBackupSecondary, RestoreLongTermRetentionBackup and Secondary. Mutually exclusive with import. Changing this forces a new resource to be created. Defaults to Default.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>The ID of the source database from which to create the new database. This should only be used for databases with create_mode values that use another database as reference. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("creationSourceDatabaseId")]
    public string? CreationSourceDatabaseId { get; set; }

    /// <summary>Specifies the ID of the elastic pool containing this database.</summary>
    [JsonPropertyName("elasticPoolId")]
    public string? ElasticPoolId { get; set; }

    /// <summary>Specifies the type of enclave to be used by the elastic pool. When enclave_type is not specified (e.g., the default) enclaves are not enabled on the database. Once enabled (e.g., by specifying Default or VBS) removing the enclave_type field from the configuration file will force the creation of a new resource. Possible values are Default or VBS.</summary>
    [JsonPropertyName("enclaveType")]
    public string? EnclaveType { get; set; }

    /// <summary>A boolean that specifies if the Geo Backup Policy is enabled. Defaults to true.</summary>
    [JsonPropertyName("geoBackupEnabled")]
    public bool? GeoBackupEnabled { get; set; }

    /// <summary>The ID of the MS SQL Database.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2MSSQLDatabaseStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>A import block as documented below. Mutually exclusive with create_mode.</summary>
    [JsonPropertyName("import")]
    public V1beta2MSSQLDatabaseStatusAtProviderImport? Import { get; set; }

    /// <summary>A boolean that specifies if this is a ledger database. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ledgerEnabled")]
    public bool? LedgerEnabled { get; set; }

    /// <summary>Specifies the license type applied to this database. Possible values are LicenseIncluded and BasePrice.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>A long_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("longTermRetentionPolicy")]
    public V1beta2MSSQLDatabaseStatusAtProviderLongTermRetentionPolicy? LongTermRetentionPolicy { get; set; }

    /// <summary>The name of the Public Maintenance Configuration window to apply to the database. Valid values include SQL_Default, SQL_EastUS_DB_1, SQL_EastUS2_DB_1, SQL_SoutheastAsia_DB_1, SQL_AustraliaEast_DB_1, SQL_NorthEurope_DB_1, SQL_SouthCentralUS_DB_1, SQL_WestUS2_DB_1, SQL_UKSouth_DB_1, SQL_WestEurope_DB_1, SQL_EastUS_DB_2, SQL_EastUS2_DB_2, SQL_WestUS2_DB_2, SQL_SoutheastAsia_DB_2, SQL_AustraliaEast_DB_2, SQL_NorthEurope_DB_2, SQL_SouthCentralUS_DB_2, SQL_UKSouth_DB_2, SQL_WestEurope_DB_2, SQL_AustraliaSoutheast_DB_1, SQL_BrazilSouth_DB_1, SQL_CanadaCentral_DB_1, SQL_CanadaEast_DB_1, SQL_CentralUS_DB_1, SQL_EastAsia_DB_1, SQL_FranceCentral_DB_1, SQL_GermanyWestCentral_DB_1, SQL_CentralIndia_DB_1, SQL_SouthIndia_DB_1, SQL_JapanEast_DB_1, SQL_JapanWest_DB_1, SQL_NorthCentralUS_DB_1, SQL_UKWest_DB_1, SQL_WestUS_DB_1, SQL_AustraliaSoutheast_DB_2, SQL_BrazilSouth_DB_2, SQL_CanadaCentral_DB_2, SQL_CanadaEast_DB_2, SQL_CentralUS_DB_2, SQL_EastAsia_DB_2, SQL_FranceCentral_DB_2, SQL_GermanyWestCentral_DB_2, SQL_CentralIndia_DB_2, SQL_SouthIndia_DB_2, SQL_JapanEast_DB_2, SQL_JapanWest_DB_2, SQL_NorthCentralUS_DB_2, SQL_UKWest_DB_2, SQL_WestUS_DB_2, SQL_WestCentralUS_DB_1, SQL_FranceSouth_DB_1, SQL_WestCentralUS_DB_2, SQL_FranceSouth_DB_2, SQL_SwitzerlandNorth_DB_1, SQL_SwitzerlandNorth_DB_2, SQL_BrazilSoutheast_DB_1, SQL_UAENorth_DB_1, SQL_BrazilSoutheast_DB_2, SQL_UAENorth_DB_2, SQL_SouthAfricaNorth_DB_1, SQL_SouthAfricaNorth_DB_2, SQL_WestUS3_DB_1, SQL_WestUS3_DB_2, SQL_SwedenCentral_DB_1, SQL_SwedenCentral_DB_2. Defaults to SQL_Default.</summary>
    [JsonPropertyName("maintenanceConfigurationName")]
    public string? MaintenanceConfigurationName { get; set; }

    /// <summary>The max size of the database in gigabytes.</summary>
    [JsonPropertyName("maxSizeGb")]
    public double? MaxSizeGb { get; set; }

    /// <summary>Minimal capacity that database will always have allocated, if not paused. This property is only settable for Serverless databases.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases.</summary>
    [JsonPropertyName("readReplicaCount")]
    public double? ReadReplicaCount { get; set; }

    /// <summary>If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases.</summary>
    [JsonPropertyName("readScale")]
    public bool? ReadScale { get; set; }

    /// <summary>The ID of the database to be recovered. This property is only applicable when the create_mode is Recovery.</summary>
    [JsonPropertyName("recoverDatabaseId")]
    public string? RecoverDatabaseId { get; set; }

    /// <summary>The ID of the Recovery Services Recovery Point Id to be restored. This property is only applicable when the create_mode is Recovery.</summary>
    [JsonPropertyName("recoveryPointId")]
    public string? RecoveryPointId { get; set; }

    /// <summary>The ID of the database to be restored. This property is only applicable when the create_mode is Restore.</summary>
    [JsonPropertyName("restoreDroppedDatabaseId")]
    public string? RestoreDroppedDatabaseId { get; set; }

    /// <summary>The ID of the long term retention backup to be restored. This property is only applicable when the create_mode is RestoreLongTermRetentionBackup.</summary>
    [JsonPropertyName("restoreLongTermRetentionBackupId")]
    public string? RestoreLongTermRetentionBackupId { get; set; }

    /// <summary>Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. This property is only settable for create_mode= PointInTimeRestore databases.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>Specifies the name of the sample schema to apply when creating this database. Possible value is AdventureWorksLT.</summary>
    [JsonPropertyName("sampleName")]
    public string? SampleName { get; set; }

    /// <summary>How do you want your replica to be made? Valid values include Geo, Named and Standby. Defaults to Geo. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }

    /// <summary>The id of the MS SQL Server on which to create the database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serverId")]
    public string? ServerId { get; set; }

    /// <summary>A short_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("shortTermRetentionPolicy")]
    public V1beta2MSSQLDatabaseStatusAtProviderShortTermRetentionPolicy? ShortTermRetentionPolicy { get; set; }

    /// <summary>Specifies the name of the SKU used by the database. For example, GP_S_Gen5_2,HS_Gen4_1,BC_Gen5_2, ElasticPool, Basic,S0, P2 ,DW100c, DS100. Changing this from the HyperScale service tier to another service tier will create a new resource.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the storage account type used to store backups for this database. Possible values are Geo, GeoZone, Local and Zone. Defaults to Geo.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Threat detection policy configuration. The threat_detection_policy block supports fields documented below.</summary>
    [JsonPropertyName("threatDetectionPolicy")]
    public V1beta2MSSQLDatabaseStatusAtProviderThreatDetectionPolicy? ThreatDetectionPolicy { get; set; }

    /// <summary>If set to true, Transparent Data Encryption will be enabled on the database. Defaults to true.</summary>
    [JsonPropertyName("transparentDataEncryptionEnabled")]
    public bool? TransparentDataEncryptionEnabled { get; set; }

    /// <summary>Boolean flag to specify whether TDE automatically rotates the encryption Key to latest version or not. Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyAutomaticRotationEnabled")]
    public bool? TransparentDataEncryptionKeyAutomaticRotationEnabled { get; set; }

    /// <summary>The fully versioned Key Vault Key URL (e.g. &apos;https://&lt;YourVaultName&gt;.vault.azure.net/keys/&lt;YourKeyName&gt;/&lt;YourKeyVersion&gt;) to be used as the Customer Managed Key(CMK/BYOK) for the Transparent Data Encryption(TDE) layer.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyId")]
    public string? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. This property is only settable for Premium and Business Critical databases.</summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatusConditions
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

/// <summary>MSSQLDatabaseStatus defines the observed state of MSSQLDatabase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MSSQLDatabaseStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MSSQLDatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MSSQLDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MSSQLDatabase is the Schema for the MSSQLDatabases API. Manages a MS SQL Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MSSQLDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MSSQLDatabaseSpec>, IStatus<V1beta2MSSQLDatabaseStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MSSQLDatabase";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqldatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MSSQLDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLDatabaseSpec defines the desired state of MSSQLDatabase</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MSSQLDatabaseSpec Spec { get; set; }

    /// <summary>MSSQLDatabaseStatus defines the observed state of MSSQLDatabase.</summary>
    [JsonPropertyName("status")]
    public V1beta2MSSQLDatabaseStatus? Status { get; set; }
}