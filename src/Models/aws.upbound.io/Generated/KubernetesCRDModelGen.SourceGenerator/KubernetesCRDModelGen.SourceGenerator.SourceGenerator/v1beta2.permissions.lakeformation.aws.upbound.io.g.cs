#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lakeformation.aws.upbound.io;
/// <summary>Permissions is the Schema for the Permissionss API. Grants permissions to the principal to access metadata in the Data Catalog and data organized in underlying data storage such as Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PermissionsList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Permissions>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PermissionsList";
    public const string KubeGroup = "lakeformation.aws.upbound.io";
    public const string KubePluralName = "permissions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lakeformation.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PermissionsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Permissions objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Permissions> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecDeletionPolicyEnum>))]
public enum V1beta2PermissionsSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDataCellsFilter
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of the data cells filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Data Catalog.</summary>
    [JsonPropertyName("tableCatalogId")]
    public string? TableCatalogId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDataLocationArnRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecForProviderDataLocationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDataLocationArnRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecForProviderDataLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDataLocationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecForProviderDataLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecForProviderDataLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDataLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecForProviderDataLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDataLocationArnSelector
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
    public V1beta2PermissionsSpecForProviderDataLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for a data location resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDataLocation
{
    /// <summary>Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2PermissionsSpecForProviderDataLocationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2PermissionsSpecForProviderDataLocationArnSelector? ArnSelector { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecForProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDatabaseNameSelector
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
    public V1beta2PermissionsSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for a database resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2PermissionsSpecForProviderDatabaseNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2PermissionsSpecForProviderDatabaseNameSelector? NameSelector { get; set; }
}

/// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The key-name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderLfTagPolicyExpression
{
    /// <summary>The key-name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource&apos;s tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta2PermissionsSpecForProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>Configuration block for a table resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderTableWithColumnsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderTableWithColumnsNameSelector
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
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2PermissionsSpecForProviderTableWithColumnsNameSelector? NameSelector { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecForProvider
{
    /// <summary>Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Whether the permissions are to be granted for the Data Catalog. Defaults to false.</summary>
    [JsonPropertyName("catalogResource")]
    public bool? CatalogResource { get; set; }

    /// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
    [JsonPropertyName("dataCellsFilter")]
    public V1beta2PermissionsSpecForProviderDataCellsFilter? DataCellsFilter { get; set; }

    /// <summary>Configuration block for a data location resource. Detailed below.</summary>
    [JsonPropertyName("dataLocation")]
    public V1beta2PermissionsSpecForProviderDataLocation? DataLocation { get; set; }

    /// <summary>Configuration block for a database resource. Detailed below.</summary>
    [JsonPropertyName("database")]
    public V1beta2PermissionsSpecForProviderDatabase? Database { get; set; }

    /// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
    [JsonPropertyName("lfTag")]
    public V1beta2PermissionsSpecForProviderLfTag? LfTag { get; set; }

    /// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
    [JsonPropertyName("lfTagPolicy")]
    public V1beta2PermissionsSpecForProviderLfTagPolicy? LfTagPolicy { get; set; }

    /// <summary>List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>Principal to be granted the permissions on the resource. Supported principals include IAM_ALLOWED_PRINCIPALS (see Default Behavior and  above), IAM roles, users, groups, Federated Users, SAML groups and users, QuickSight groups, OUs, and organizations as well as AWS account IDs for cross-account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public V1beta2PermissionsSpecForProviderTable? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public V1beta2PermissionsSpecForProviderTableWithColumns? TableWithColumns { get; set; }
}

/// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDataCellsFilter
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of the data cells filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Data Catalog.</summary>
    [JsonPropertyName("tableCatalogId")]
    public string? TableCatalogId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDataLocationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDataLocationArnSelector
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
    public V1beta2PermissionsSpecInitProviderDataLocationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for a data location resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDataLocation
{
    /// <summary>Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Resource in lakeformation to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2PermissionsSpecInitProviderDataLocationArnSelector? ArnSelector { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDatabaseNameSelector
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
    public V1beta2PermissionsSpecInitProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for a database resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2PermissionsSpecInitProviderDatabaseNameSelector? NameSelector { get; set; }
}

/// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The key-name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderLfTagPolicyExpression
{
    /// <summary>The key-name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource&apos;s tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta2PermissionsSpecInitProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>Configuration block for a table resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderTableWithColumnsNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogTable in glue to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelector
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
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecInitProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameRef? NameRef { get; set; }

    /// <summary>Selector for a CatalogTable in glue to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2PermissionsSpecInitProviderTableWithColumnsNameSelector? NameSelector { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
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
public partial class V1beta2PermissionsSpecInitProvider
{
    /// <summary>Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Whether the permissions are to be granted for the Data Catalog. Defaults to false.</summary>
    [JsonPropertyName("catalogResource")]
    public bool? CatalogResource { get; set; }

    /// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
    [JsonPropertyName("dataCellsFilter")]
    public V1beta2PermissionsSpecInitProviderDataCellsFilter? DataCellsFilter { get; set; }

    /// <summary>Configuration block for a data location resource. Detailed below.</summary>
    [JsonPropertyName("dataLocation")]
    public V1beta2PermissionsSpecInitProviderDataLocation? DataLocation { get; set; }

    /// <summary>Configuration block for a database resource. Detailed below.</summary>
    [JsonPropertyName("database")]
    public V1beta2PermissionsSpecInitProviderDatabase? Database { get; set; }

    /// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
    [JsonPropertyName("lfTag")]
    public V1beta2PermissionsSpecInitProviderLfTag? LfTag { get; set; }

    /// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
    [JsonPropertyName("lfTagPolicy")]
    public V1beta2PermissionsSpecInitProviderLfTagPolicy? LfTagPolicy { get; set; }

    /// <summary>List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>Principal to be granted the permissions on the resource. Supported principals include IAM_ALLOWED_PRINCIPALS (see Default Behavior and  above), IAM roles, users, groups, Federated Users, SAML groups and users, QuickSight groups, OUs, and organizations as well as AWS account IDs for cross-account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public V1beta2PermissionsSpecInitProviderTable? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public V1beta2PermissionsSpecInitProviderTableWithColumns? TableWithColumns { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecManagementPoliciesEnum>))]
public enum V1beta2PermissionsSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PermissionsSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PermissionsSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PermissionsSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PermissionsSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PermissionsSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PermissionsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PermissionsSpec defines the desired state of Permissions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsSpec
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
    public V1beta2PermissionsSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PermissionsSpecForProvider ForProvider { get; set; }

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
    public V1beta2PermissionsSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PermissionsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PermissionsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PermissionsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderDataCellsFilter
{
    /// <summary>The name of the database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The name of the data cells filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Data Catalog.</summary>
    [JsonPropertyName("tableCatalogId")]
    public string? TableCatalogId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Configuration block for a data location resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderDataLocation
{
    /// <summary>Amazon Resource Name (ARN) that uniquely identifies the data location resource.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Identifier for the Data Catalog where the location is registered with Lake Formation. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }
}

/// <summary>Configuration block for a database resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderDatabase
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderLfTag
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>The key-name for the tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values an attribute can take.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderLfTagPolicyExpression
{
    /// <summary>The key-name of an LF-Tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A list of possible values of an LF-Tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderLfTagPolicy
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>A list of tag conditions that apply to the resource&apos;s tag policy. Configuration block for tag conditions that apply to the policy. See expression below.</summary>
    [JsonPropertyName("expression")]
    public IList<V1beta2PermissionsStatusAtProviderLfTagPolicyExpression>? Expression { get; set; }

    /// <summary>The resource type for which the tag policy applies. Valid values are DATABASE and TABLE.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary>Configuration block for a table resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderTable
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Name of the database for the table. Unique to a Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Name of the table.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a wildcard representing every table under a database. Defaults to false.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

/// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProviderTableWithColumns
{
    /// <summary>Identifier for the Data Catalog. By default, it is the account ID of the caller.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Set of column names for the table.</summary>
    [JsonPropertyName("columnNames")]
    public IList<string>? ColumnNames { get; set; }

    /// <summary>Name of the database for the table with columns resource. Unique to the Data Catalog.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Set of column names for the table to exclude.</summary>
    [JsonPropertyName("excludedColumnNames")]
    public IList<string>? ExcludedColumnNames { get; set; }

    /// <summary>Name of the table resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to use a column wildcard.</summary>
    [JsonPropertyName("wildcard")]
    public bool? Wildcard { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusAtProvider
{
    /// <summary>Identifier for the Data Catalog. By default, the account ID. The Data Catalog is the persistent metadata store. It contains database definitions, table definitions, and other control information to manage your Lake Formation environment.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>Whether the permissions are to be granted for the Data Catalog. Defaults to false.</summary>
    [JsonPropertyName("catalogResource")]
    public bool? CatalogResource { get; set; }

    /// <summary>Configuration block for a data cells filter resource. Detailed below.</summary>
    [JsonPropertyName("dataCellsFilter")]
    public V1beta2PermissionsStatusAtProviderDataCellsFilter? DataCellsFilter { get; set; }

    /// <summary>Configuration block for a data location resource. Detailed below.</summary>
    [JsonPropertyName("dataLocation")]
    public V1beta2PermissionsStatusAtProviderDataLocation? DataLocation { get; set; }

    /// <summary>Configuration block for a database resource. Detailed below.</summary>
    [JsonPropertyName("database")]
    public V1beta2PermissionsStatusAtProviderDatabase? Database { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for an LF-tag resource. Detailed below.</summary>
    [JsonPropertyName("lfTag")]
    public V1beta2PermissionsStatusAtProviderLfTag? LfTag { get; set; }

    /// <summary>Configuration block for an LF-tag policy resource. Detailed below.</summary>
    [JsonPropertyName("lfTagPolicy")]
    public V1beta2PermissionsStatusAtProviderLfTagPolicy? LfTagPolicy { get; set; }

    /// <summary>List of permissions granted to the principal. Valid values may include ALL, ALTER, ASSOCIATE, CREATE_DATABASE, CREATE_TABLE, DATA_LOCATION_ACCESS, DELETE, DESCRIBE, DROP, INSERT, and SELECT. For details on each permission, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("permissions")]
    public IList<string>? Permissions { get; set; }

    /// <summary>Subset of permissions which the principal can pass.</summary>
    [JsonPropertyName("permissionsWithGrantOption")]
    public IList<string>? PermissionsWithGrantOption { get; set; }

    /// <summary>Principal to be granted the permissions on the resource. Supported principals include IAM_ALLOWED_PRINCIPALS (see Default Behavior and  above), IAM roles, users, groups, Federated Users, SAML groups and users, QuickSight groups, OUs, and organizations as well as AWS account IDs for cross-account permissions. For more information, see Lake Formation Permissions Reference.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for a table resource. Detailed below.</summary>
    [JsonPropertyName("table")]
    public V1beta2PermissionsStatusAtProviderTable? Table { get; set; }

    /// <summary>Configuration block for a table with columns resource. Detailed below.</summary>
    [JsonPropertyName("tableWithColumns")]
    public V1beta2PermissionsStatusAtProviderTableWithColumns? TableWithColumns { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatusConditions
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

/// <summary>PermissionsStatus defines the observed state of Permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PermissionsStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PermissionsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PermissionsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Permissions is the Schema for the Permissionss API. Grants permissions to the principal to access metadata in the Data Catalog and data organized in underlying data storage such as Amazon S3.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Permissions : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PermissionsSpec>, IStatus<V1beta2PermissionsStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Permissions";
    public const string KubeGroup = "lakeformation.aws.upbound.io";
    public const string KubePluralName = "permissions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "lakeformation.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Permissions";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PermissionsSpec defines the desired state of Permissions</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PermissionsSpec Spec { get; set; }

    /// <summary>PermissionsStatus defines the observed state of Permissions.</summary>
    [JsonPropertyName("status")]
    public V1beta2PermissionsStatus? Status { get; set; }
}