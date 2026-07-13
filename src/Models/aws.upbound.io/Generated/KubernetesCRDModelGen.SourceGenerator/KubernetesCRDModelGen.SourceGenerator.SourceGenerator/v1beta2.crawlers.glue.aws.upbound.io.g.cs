#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>Crawler is the Schema for the Crawlers API. Manages a Glue Crawler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CrawlerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Crawler>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CrawlerList";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "crawlers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CrawlerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Crawler objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Crawler> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecDeletionPolicyEnum>))]
public enum V1beta2CrawlerSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelector
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
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetTablesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTargetTablesSelector
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
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderCatalogTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta2CrawlerSpecForProviderCatalogTargetDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of catalog tables to be synchronized.</summary>
    [JsonPropertyName("tables")]
    public IList<string>? Tables { get; set; }

    /// <summary>References to CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesRefs")]
    public IList<V1beta2CrawlerSpecForProviderCatalogTargetTablesRefs>? TablesRefs { get; set; }

    /// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesSelector")]
    public V1beta2CrawlerSpecForProviderCatalogTargetTablesSelector? TablesSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderDatabaseNameSelector
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
    public V1beta2CrawlerSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderDeltaTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specifies whether the crawler will create native tables, to allow integration with query engines that support querying of the Delta transaction log directly.</summary>
    [JsonPropertyName("createNativeDeltaTable")]
    public bool? CreateNativeDeltaTable { get; set; }

    /// <summary>A list of the Amazon S3 paths to the Delta tables.</summary>
    [JsonPropertyName("deltaTables")]
    public IList<string>? DeltaTables { get; set; }

    /// <summary>Specifies whether to write the manifest files to the Delta table path.</summary>
    [JsonPropertyName("writeManifest")]
    public bool? WriteManifest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderDynamodbTarget
{
    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }

    /// <summary>The percentage of the configured read capacity units to use by the AWS Glue crawler. The valid values are null or a value between 0.1 to 1.5.</summary>
    [JsonPropertyName("scanRate")]
    public double? ScanRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderHudiTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderIcebergTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelector
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
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderJdbcTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta2CrawlerSpecForProviderJdbcTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>Specify a value of RAWTYPES or COMMENTS to enable additional metadata intable responses. RAWTYPES provides the native-level datatype. COMMENTS provides comments associated with a column or table in the database.</summary>
    [JsonPropertyName("enableAdditionalMetadata")]
    public IList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderLakeFormationConfiguration
{
    /// <summary>Required for cross account crawls. For same account crawls as the target data, this can omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether to use Lake Formation credentials for the crawler instead of the IAM role credentials.</summary>
    [JsonPropertyName("useLakeFormationCredentials")]
    public bool? UseLakeFormationCredentials { get; set; }
}

/// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderLineageConfiguration
{
    /// <summary>Specifies whether data lineage is enabled for the crawler. Valid values are: ENABLE and DISABLE. Default value is DISABLE.</summary>
    [JsonPropertyName("crawlerLineageSettings")]
    public string? CrawlerLineageSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelector
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
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderMongodbTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta2CrawlerSpecForProviderMongodbTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }
}

/// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderRecrawlPolicy
{
    /// <summary>Specifies whether to crawl the entire dataset again, crawl only folders that were added since the last crawler run, or crawl what S3 notifies the crawler of via SQS. Valid Values are: CRAWL_EVENT_MODE, CRAWL_EVERYTHING and CRAWL_NEW_FOLDERS_ONLY. Default value is CRAWL_EVERYTHING.</summary>
    [JsonPropertyName("recrawlBehavior")]
    public string? RecrawlBehavior { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderRoleRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderRoleRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecForProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecForProviderRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecForProviderRoleSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecForProviderRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecForProviderRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecForProviderRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderRoleSelector
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
    public V1beta2CrawlerSpecForProviderRoleSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderS3Target
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Sets the number of files in each leaf folder to be crawled when crawling sample files in a dataset. If not set, all the files are crawled. A valid value is an integer between 1 and 249.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }
}

/// <summary>Policy for the crawler&apos;s update and deletion behavior. See Schema Change Policy below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProviderSchemaChangePolicy
{
    /// <summary>The deletion behavior when the crawler finds a deleted object. Valid values: LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE. Defaults to DEPRECATE_IN_DATABASE.</summary>
    [JsonPropertyName("deleteBehavior")]
    public string? DeleteBehavior { get; set; }

    /// <summary>The update behavior when the crawler finds a changed schema. Valid values: LOG or UPDATE_IN_DATABASE. Defaults to UPDATE_IN_DATABASE.</summary>
    [JsonPropertyName("updateBehavior")]
    public string? UpdateBehavior { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecForProvider
{
    /// <summary>List of nested AWS Glue Data Catalog target arguments. See Catalog Target below.</summary>
    [JsonPropertyName("catalogTarget")]
    public IList<V1beta2CrawlerSpecForProviderCatalogTarget>? CatalogTarget { get; set; }

    /// <summary>List of custom classifiers. By default, all AWS classifiers are included in a crawl, but these custom classifiers always override the default classifiers for a given classification.</summary>
    [JsonPropertyName("classifiers")]
    public IList<string>? Classifiers { get; set; }

    /// <summary>JSON string of configuration information. For more details see Setting Crawler Configuration Options.</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta2CrawlerSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta2CrawlerSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>List of nested Delta Lake target arguments. See Delta Target below.</summary>
    [JsonPropertyName("deltaTarget")]
    public IList<V1beta2CrawlerSpecForProviderDeltaTarget>? DeltaTarget { get; set; }

    /// <summary>Description of the crawler.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of nested DynamoDB target arguments. See Dynamodb Target below.</summary>
    [JsonPropertyName("dynamodbTarget")]
    public IList<V1beta2CrawlerSpecForProviderDynamodbTarget>? DynamodbTarget { get; set; }

    /// <summary>List of nested Hudi target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("hudiTarget")]
    public IList<V1beta2CrawlerSpecForProviderHudiTarget>? HudiTarget { get; set; }

    /// <summary>List of nested Iceberg target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("icebergTarget")]
    public IList<V1beta2CrawlerSpecForProviderIcebergTarget>? IcebergTarget { get; set; }

    /// <summary>List of nested JDBC target arguments. See JDBC Target below.</summary>
    [JsonPropertyName("jdbcTarget")]
    public IList<V1beta2CrawlerSpecForProviderJdbcTarget>? JdbcTarget { get; set; }

    /// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
    [JsonPropertyName("lakeFormationConfiguration")]
    public V1beta2CrawlerSpecForProviderLakeFormationConfiguration? LakeFormationConfiguration { get; set; }

    /// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
    [JsonPropertyName("lineageConfiguration")]
    public V1beta2CrawlerSpecForProviderLineageConfiguration? LineageConfiguration { get; set; }

    /// <summary>List of nested MongoDB target arguments. See MongoDB Target below.</summary>
    [JsonPropertyName("mongodbTarget")]
    public IList<V1beta2CrawlerSpecForProviderMongodbTarget>? MongodbTarget { get; set; }

    /// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
    [JsonPropertyName("recrawlPolicy")]
    public V1beta2CrawlerSpecForProviderRecrawlPolicy? RecrawlPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The IAM role friendly name (including path without leading slash), or ARN of an IAM role, used by the crawler to access other resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta2CrawlerSpecForProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta2CrawlerSpecForProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of nested Amazon S3 target arguments. See S3 Target below.</summary>
    [JsonPropertyName("s3Target")]
    public IList<V1beta2CrawlerSpecForProviderS3Target>? S3Target { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers. For example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Policy for the crawler&apos;s update and deletion behavior. See Schema Change Policy below.</summary>
    [JsonPropertyName("schemaChangePolicy")]
    public V1beta2CrawlerSpecForProviderSchemaChangePolicy? SchemaChangePolicy { get; set; }

    /// <summary>The name of Security Configuration to be used by the crawler</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The table prefix used for catalog tables that are created.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelector
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
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelector
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
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderCatalogTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of catalog tables to be synchronized.</summary>
    [JsonPropertyName("tables")]
    public IList<string>? Tables { get; set; }

    /// <summary>References to CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesRefs")]
    public IList<V1beta2CrawlerSpecInitProviderCatalogTargetTablesRefs>? TablesRefs { get; set; }

    /// <summary>Selector for a list of CatalogTable in glue to populate tables.</summary>
    [JsonPropertyName("tablesSelector")]
    public V1beta2CrawlerSpecInitProviderCatalogTargetTablesSelector? TablesSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderDatabaseNameSelector
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
    public V1beta2CrawlerSpecInitProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderDeltaTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specifies whether the crawler will create native tables, to allow integration with query engines that support querying of the Delta transaction log directly.</summary>
    [JsonPropertyName("createNativeDeltaTable")]
    public bool? CreateNativeDeltaTable { get; set; }

    /// <summary>A list of the Amazon S3 paths to the Delta tables.</summary>
    [JsonPropertyName("deltaTables")]
    public IList<string>? DeltaTables { get; set; }

    /// <summary>Specifies whether to write the manifest files to the Delta table path.</summary>
    [JsonPropertyName("writeManifest")]
    public bool? WriteManifest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderDynamodbTarget
{
    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }

    /// <summary>The percentage of the configured read capacity units to use by the AWS Glue crawler. The valid values are null or a value between 0.1 to 1.5.</summary>
    [JsonPropertyName("scanRate")]
    public double? ScanRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderHudiTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderIcebergTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelector
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
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderJdbcTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta2CrawlerSpecInitProviderJdbcTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>Specify a value of RAWTYPES or COMMENTS to enable additional metadata intable responses. RAWTYPES provides the native-level datatype. COMMENTS provides comments associated with a column or table in the database.</summary>
    [JsonPropertyName("enableAdditionalMetadata")]
    public IList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderLakeFormationConfiguration
{
    /// <summary>Required for cross account crawls. For same account crawls as the target data, this can omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether to use Lake Formation credentials for the crawler instead of the IAM role credentials.</summary>
    [JsonPropertyName("useLakeFormationCredentials")]
    public bool? UseLakeFormationCredentials { get; set; }
}

/// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderLineageConfiguration
{
    /// <summary>Specifies whether data lineage is enabled for the crawler. Valid values are: ENABLE and DISABLE. Default value is DISABLE.</summary>
    [JsonPropertyName("crawlerLineageSettings")]
    public string? CrawlerLineageSettings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Connection in glue to populate connectionName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelector
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
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderMongodbTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Reference to a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameRef")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameRef? ConnectionNameRef { get; set; }

    /// <summary>Selector for a Connection in glue to populate connectionName.</summary>
    [JsonPropertyName("connectionNameSelector")]
    public V1beta2CrawlerSpecInitProviderMongodbTargetConnectionNameSelector? ConnectionNameSelector { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }
}

/// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderRecrawlPolicy
{
    /// <summary>Specifies whether to crawl the entire dataset again, crawl only folders that were added since the last crawler run, or crawl what S3 notifies the crawler of via SQS. Valid Values are: CRAWL_EVENT_MODE, CRAWL_EVERYTHING and CRAWL_NEW_FOLDERS_ONLY. Default value is CRAWL_EVERYTHING.</summary>
    [JsonPropertyName("recrawlBehavior")]
    public string? RecrawlBehavior { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderRoleRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderRoleRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecInitProviderRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecInitProviderRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecInitProviderRoleSelectorPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecInitProviderRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecInitProviderRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecInitProviderRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderRoleSelector
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
    public V1beta2CrawlerSpecInitProviderRoleSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderS3Target
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Sets the number of files in each leaf folder to be crawled when crawling sample files in a dataset. If not set, all the files are crawled. A valid value is an integer between 1 and 249.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }
}

/// <summary>Policy for the crawler&apos;s update and deletion behavior. See Schema Change Policy below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecInitProviderSchemaChangePolicy
{
    /// <summary>The deletion behavior when the crawler finds a deleted object. Valid values: LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE. Defaults to DEPRECATE_IN_DATABASE.</summary>
    [JsonPropertyName("deleteBehavior")]
    public string? DeleteBehavior { get; set; }

    /// <summary>The update behavior when the crawler finds a changed schema. Valid values: LOG or UPDATE_IN_DATABASE. Defaults to UPDATE_IN_DATABASE.</summary>
    [JsonPropertyName("updateBehavior")]
    public string? UpdateBehavior { get; set; }
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
public partial class V1beta2CrawlerSpecInitProvider
{
    /// <summary>List of nested AWS Glue Data Catalog target arguments. See Catalog Target below.</summary>
    [JsonPropertyName("catalogTarget")]
    public IList<V1beta2CrawlerSpecInitProviderCatalogTarget>? CatalogTarget { get; set; }

    /// <summary>List of custom classifiers. By default, all AWS classifiers are included in a crawl, but these custom classifiers always override the default classifiers for a given classification.</summary>
    [JsonPropertyName("classifiers")]
    public IList<string>? Classifiers { get; set; }

    /// <summary>JSON string of configuration information. For more details see Setting Crawler Configuration Options.</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a CatalogDatabase in glue to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta2CrawlerSpecInitProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>List of nested Delta Lake target arguments. See Delta Target below.</summary>
    [JsonPropertyName("deltaTarget")]
    public IList<V1beta2CrawlerSpecInitProviderDeltaTarget>? DeltaTarget { get; set; }

    /// <summary>Description of the crawler.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of nested DynamoDB target arguments. See Dynamodb Target below.</summary>
    [JsonPropertyName("dynamodbTarget")]
    public IList<V1beta2CrawlerSpecInitProviderDynamodbTarget>? DynamodbTarget { get; set; }

    /// <summary>List of nested Hudi target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("hudiTarget")]
    public IList<V1beta2CrawlerSpecInitProviderHudiTarget>? HudiTarget { get; set; }

    /// <summary>List of nested Iceberg target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("icebergTarget")]
    public IList<V1beta2CrawlerSpecInitProviderIcebergTarget>? IcebergTarget { get; set; }

    /// <summary>List of nested JDBC target arguments. See JDBC Target below.</summary>
    [JsonPropertyName("jdbcTarget")]
    public IList<V1beta2CrawlerSpecInitProviderJdbcTarget>? JdbcTarget { get; set; }

    /// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
    [JsonPropertyName("lakeFormationConfiguration")]
    public V1beta2CrawlerSpecInitProviderLakeFormationConfiguration? LakeFormationConfiguration { get; set; }

    /// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
    [JsonPropertyName("lineageConfiguration")]
    public V1beta2CrawlerSpecInitProviderLineageConfiguration? LineageConfiguration { get; set; }

    /// <summary>List of nested MongoDB target arguments. See MongoDB Target below.</summary>
    [JsonPropertyName("mongodbTarget")]
    public IList<V1beta2CrawlerSpecInitProviderMongodbTarget>? MongodbTarget { get; set; }

    /// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
    [JsonPropertyName("recrawlPolicy")]
    public V1beta2CrawlerSpecInitProviderRecrawlPolicy? RecrawlPolicy { get; set; }

    /// <summary>The IAM role friendly name (including path without leading slash), or ARN of an IAM role, used by the crawler to access other resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference to a Role in iam to populate role.</summary>
    [JsonPropertyName("roleRef")]
    public V1beta2CrawlerSpecInitProviderRoleRef? RoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate role.</summary>
    [JsonPropertyName("roleSelector")]
    public V1beta2CrawlerSpecInitProviderRoleSelector? RoleSelector { get; set; }

    /// <summary>List of nested Amazon S3 target arguments. See S3 Target below.</summary>
    [JsonPropertyName("s3Target")]
    public IList<V1beta2CrawlerSpecInitProviderS3Target>? S3Target { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers. For example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Policy for the crawler&apos;s update and deletion behavior. See Schema Change Policy below.</summary>
    [JsonPropertyName("schemaChangePolicy")]
    public V1beta2CrawlerSpecInitProviderSchemaChangePolicy? SchemaChangePolicy { get; set; }

    /// <summary>The name of Security Configuration to be used by the crawler</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The table prefix used for catalog tables that are created.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecManagementPoliciesEnum>))]
public enum V1beta2CrawlerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CrawlerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CrawlerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CrawlerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CrawlerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CrawlerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CrawlerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CrawlerSpec defines the desired state of Crawler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerSpec
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
    public V1beta2CrawlerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CrawlerSpecForProvider ForProvider { get; set; }

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
    public V1beta2CrawlerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CrawlerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CrawlerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CrawlerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderCatalogTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of catalog tables to be synchronized.</summary>
    [JsonPropertyName("tables")]
    public IList<string>? Tables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderDeltaTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specifies whether the crawler will create native tables, to allow integration with query engines that support querying of the Delta transaction log directly.</summary>
    [JsonPropertyName("createNativeDeltaTable")]
    public bool? CreateNativeDeltaTable { get; set; }

    /// <summary>A list of the Amazon S3 paths to the Delta tables.</summary>
    [JsonPropertyName("deltaTables")]
    public IList<string>? DeltaTables { get; set; }

    /// <summary>Specifies whether to write the manifest files to the Delta table path.</summary>
    [JsonPropertyName("writeManifest")]
    public bool? WriteManifest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderDynamodbTarget
{
    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }

    /// <summary>The percentage of the configured read capacity units to use by the AWS Glue crawler. The valid values are null or a value between 0.1 to 1.5.</summary>
    [JsonPropertyName("scanRate")]
    public double? ScanRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderHudiTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderIcebergTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The maximum depth of Amazon S3 paths that the crawler can traverse to discover the Hudi metadata folder in your Amazon S3 path. Used to limit the crawler run time. Valid values are between 1 and 20.</summary>
    [JsonPropertyName("maximumTraversalDepth")]
    public double? MaximumTraversalDepth { get; set; }

    /// <summary>One or more Amazon S3 paths that contains Hudi metadata folders as s3://bucket/prefix.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderJdbcTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>Specify a value of RAWTYPES or COMMENTS to enable additional metadata intable responses. RAWTYPES provides the native-level datatype. COMMENTS provides comments associated with a column or table in the database.</summary>
    [JsonPropertyName("enableAdditionalMetadata")]
    public IList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderLakeFormationConfiguration
{
    /// <summary>Required for cross account crawls. For same account crawls as the target data, this can omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Specifies whether to use Lake Formation credentials for the crawler instead of the IAM role credentials.</summary>
    [JsonPropertyName("useLakeFormationCredentials")]
    public bool? UseLakeFormationCredentials { get; set; }
}

/// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderLineageConfiguration
{
    /// <summary>Specifies whether data lineage is enabled for the crawler. Valid values are: ENABLE and DISABLE. Default value is DISABLE.</summary>
    [JsonPropertyName("crawlerLineageSettings")]
    public string? CrawlerLineageSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderMongodbTarget
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Indicates whether to scan all the records, or to sample rows from the table. Scanning all the records can take a long time when the table is not a high throughput table.  defaults to true.</summary>
    [JsonPropertyName("scanAll")]
    public bool? ScanAll { get; set; }
}

/// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderRecrawlPolicy
{
    /// <summary>Specifies whether to crawl the entire dataset again, crawl only folders that were added since the last crawler run, or crawl what S3 notifies the crawler of via SQS. Valid Values are: CRAWL_EVENT_MODE, CRAWL_EVERYTHING and CRAWL_NEW_FOLDERS_ONLY. Default value is CRAWL_EVERYTHING.</summary>
    [JsonPropertyName("recrawlBehavior")]
    public string? RecrawlBehavior { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderS3Target
{
    /// <summary>The name of the connection to use to connect to the JDBC target.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The ARN of the dead-letter SQS queue.</summary>
    [JsonPropertyName("dlqEventQueueArn")]
    public string? DlqEventQueueArn { get; set; }

    /// <summary>The ARN of the SQS queue to receive S3 notifications from.</summary>
    [JsonPropertyName("eventQueueArn")]
    public string? EventQueueArn { get; set; }

    /// <summary>A list of glob patterns used to exclude from the crawl.</summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary>The name of the DynamoDB table to crawl.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Sets the number of files in each leaf folder to be crawled when crawling sample files in a dataset. If not set, all the files are crawled. A valid value is an integer between 1 and 249.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }
}

/// <summary>Policy for the crawler&apos;s update and deletion behavior. See Schema Change Policy below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProviderSchemaChangePolicy
{
    /// <summary>The deletion behavior when the crawler finds a deleted object. Valid values: LOG, DELETE_FROM_DATABASE, or DEPRECATE_IN_DATABASE. Defaults to DEPRECATE_IN_DATABASE.</summary>
    [JsonPropertyName("deleteBehavior")]
    public string? DeleteBehavior { get; set; }

    /// <summary>The update behavior when the crawler finds a changed schema. Valid values: LOG or UPDATE_IN_DATABASE. Defaults to UPDATE_IN_DATABASE.</summary>
    [JsonPropertyName("updateBehavior")]
    public string? UpdateBehavior { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusAtProvider
{
    /// <summary>The ARN of the crawler</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>List of nested AWS Glue Data Catalog target arguments. See Catalog Target below.</summary>
    [JsonPropertyName("catalogTarget")]
    public IList<V1beta2CrawlerStatusAtProviderCatalogTarget>? CatalogTarget { get; set; }

    /// <summary>List of custom classifiers. By default, all AWS classifiers are included in a crawl, but these custom classifiers always override the default classifiers for a given classification.</summary>
    [JsonPropertyName("classifiers")]
    public IList<string>? Classifiers { get; set; }

    /// <summary>JSON string of configuration information. For more details see Setting Crawler Configuration Options.</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>Glue database where results are written.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>List of nested Delta Lake target arguments. See Delta Target below.</summary>
    [JsonPropertyName("deltaTarget")]
    public IList<V1beta2CrawlerStatusAtProviderDeltaTarget>? DeltaTarget { get; set; }

    /// <summary>Description of the crawler.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>List of nested DynamoDB target arguments. See Dynamodb Target below.</summary>
    [JsonPropertyName("dynamodbTarget")]
    public IList<V1beta2CrawlerStatusAtProviderDynamodbTarget>? DynamodbTarget { get; set; }

    /// <summary>List of nested Hudi target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("hudiTarget")]
    public IList<V1beta2CrawlerStatusAtProviderHudiTarget>? HudiTarget { get; set; }

    /// <summary>List of nested Iceberg target arguments. See Iceberg Target below.</summary>
    [JsonPropertyName("icebergTarget")]
    public IList<V1beta2CrawlerStatusAtProviderIcebergTarget>? IcebergTarget { get; set; }

    /// <summary>Crawler name</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of nested JDBC target arguments. See JDBC Target below.</summary>
    [JsonPropertyName("jdbcTarget")]
    public IList<V1beta2CrawlerStatusAtProviderJdbcTarget>? JdbcTarget { get; set; }

    /// <summary>Specifies Lake Formation configuration settings for the crawler. See Lake Formation Configuration below.</summary>
    [JsonPropertyName("lakeFormationConfiguration")]
    public V1beta2CrawlerStatusAtProviderLakeFormationConfiguration? LakeFormationConfiguration { get; set; }

    /// <summary>Specifies data lineage configuration settings for the crawler. See Lineage Configuration below.</summary>
    [JsonPropertyName("lineageConfiguration")]
    public V1beta2CrawlerStatusAtProviderLineageConfiguration? LineageConfiguration { get; set; }

    /// <summary>List of nested MongoDB target arguments. See MongoDB Target below.</summary>
    [JsonPropertyName("mongodbTarget")]
    public IList<V1beta2CrawlerStatusAtProviderMongodbTarget>? MongodbTarget { get; set; }

    /// <summary>A policy that specifies whether to crawl the entire dataset again, or to crawl only folders that were added since the last crawler run.. See Recrawl Policy below.</summary>
    [JsonPropertyName("recrawlPolicy")]
    public V1beta2CrawlerStatusAtProviderRecrawlPolicy? RecrawlPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The IAM role friendly name (including path without leading slash), or ARN of an IAM role, used by the crawler to access other resources.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>List of nested Amazon S3 target arguments. See S3 Target below.</summary>
    [JsonPropertyName("s3Target")]
    public IList<V1beta2CrawlerStatusAtProviderS3Target>? S3Target { get; set; }

    /// <summary>Based Schedules for Jobs and Crawlers. For example, to run something every day at 12:15 UTC, you would specify: cron(15 12 * * ? *).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Policy for the crawler&apos;s update and deletion behavior. See Schema Change Policy below.</summary>
    [JsonPropertyName("schemaChangePolicy")]
    public V1beta2CrawlerStatusAtProviderSchemaChangePolicy? SchemaChangePolicy { get; set; }

    /// <summary>The name of Security Configuration to be used by the crawler</summary>
    [JsonPropertyName("securityConfiguration")]
    public string? SecurityConfiguration { get; set; }

    /// <summary>The table prefix used for catalog tables that are created.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatusConditions
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

/// <summary>CrawlerStatus defines the observed state of Crawler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CrawlerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CrawlerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CrawlerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Crawler is the Schema for the Crawlers API. Manages a Glue Crawler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Crawler : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CrawlerSpec>, IStatus<V1beta2CrawlerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Crawler";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "crawlers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "glue.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Crawler";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CrawlerSpec defines the desired state of Crawler</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CrawlerSpec Spec { get; set; }

    /// <summary>CrawlerStatus defines the observed state of Crawler.</summary>
    [JsonPropertyName("status")]
    public V1beta2CrawlerStatus? Status { get; set; }
}