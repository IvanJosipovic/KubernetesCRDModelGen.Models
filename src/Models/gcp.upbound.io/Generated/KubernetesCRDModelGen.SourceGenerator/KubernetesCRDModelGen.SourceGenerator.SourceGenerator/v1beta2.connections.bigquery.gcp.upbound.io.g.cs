#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquery.gcp.upbound.io;
/// <summary>Connection is the Schema for the Connections API. A connection allows BigQuery connections to external data sources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Connection>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConnectionList";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Connection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Connection> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecDeletionPolicyEnum>))]
public enum V1beta2ConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Authentication using Google owned service account to assume into customer&apos;s AWS IAM Role.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }
}

/// <summary>
/// Connection properties specific to Amazon Web Services.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAws
{
    /// <summary>
    /// Authentication using Google owned service account to assume into customer&apos;s AWS IAM Role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("accessRole")]
    public V1beta2ConnectionSpecForProviderAwsAccessRole? AccessRole { get; set; }
}

/// <summary>
/// Container for connection properties specific to Azure.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderAzure
{
    /// <summary>The id of customer&apos;s directory that host the data.</summary>
    [JsonPropertyName("customerTenantId")]
    public string? CustomerTenantId { get; set; }

    /// <summary>The Azure Application (client) ID where the federated credentials will be hosted.</summary>
    [JsonPropertyName("federatedApplicationClientId")]
    public string? FederatedApplicationClientId { get; set; }
}

/// <summary>
/// Container for connection properties for delegation of access to GCP resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudResource
{
}

/// <summary>
/// Connection properties specific to Cloud Spanner
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSpanner
{
    /// <summary>Cloud Spanner database in the form `project/instance/database&apos;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as SELECT and INSERT. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. useParallelism and useDataBoost must be set when setting max parallelism.</summary>
    [JsonPropertyName("maxParallelism")]
    public double? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute resources. use_parallelism must be set when using data boost.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner.</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. useParallelism must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary>
/// Password for database.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlCredentialPasswordSecretRef
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelector
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
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Cloud SQL properties.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlCredential
{
    /// <summary>
    /// Password for database.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Username for database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredentialUsernameSelector? UsernameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelector
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
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelector
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
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Connection properties specific to the Cloud SQL.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderCloudSql
{
    /// <summary>
    /// Cloud SQL properties.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("credential")]
    public V1beta2ConnectionSpecForProviderCloudSqlCredential? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta2ConnectionSpecForProviderCloudSqlDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Cloud SQL instance ID in the form project:location:instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta2ConnectionSpecForProviderCloudSqlInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>
    /// Type of the Cloud SQL database.
    /// Possible values are: DATABASE_TYPE_UNSPECIFIED, POSTGRES, MYSQL.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Dataproc Metastore Service configuration for the connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSparkMetastoreServiceConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelector
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
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Spark History Server configuration for the connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterSelector")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfigDataprocClusterSelector? DataprocClusterSelector { get; set; }
}

/// <summary>
/// Container for connection properties to execute stored procedures for Apache Spark. resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProviderSpark
{
    /// <summary>
    /// Dataproc Metastore Service configuration for the connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metastoreServiceConfig")]
    public V1beta2ConnectionSpecForProviderSparkMetastoreServiceConfig? MetastoreServiceConfig { get; set; }

    /// <summary>
    /// Spark History Server configuration for the connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta2ConnectionSpecForProviderSparkSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecForProvider
{
    /// <summary>
    /// Connection properties specific to Amazon Web Services.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aws")]
    public V1beta2ConnectionSpecForProviderAws? Aws { get; set; }

    /// <summary>
    /// Container for connection properties specific to Azure.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("azure")]
    public V1beta2ConnectionSpecForProviderAzure? Azure { get; set; }

    /// <summary>
    /// Container for connection properties for delegation of access to GCP resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudResource")]
    public V1beta2ConnectionSpecForProviderCloudResource? CloudResource { get; set; }

    /// <summary>
    /// Connection properties specific to Cloud Spanner
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudSpanner")]
    public V1beta2ConnectionSpecForProviderCloudSpanner? CloudSpanner { get; set; }

    /// <summary>
    /// Connection properties specific to the Cloud SQL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudSql")]
    public V1beta2ConnectionSpecForProviderCloudSql? CloudSql { get; set; }

    /// <summary>Optional connection id that should be assigned to the created connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A descriptive description for the connection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A descriptive name for the connection</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>
    /// Optional. The Cloud KMS key that is used for encryption.
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Container for connection properties to execute stored procedures for Apache Spark. resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spark")]
    public V1beta2ConnectionSpecForProviderSpark? Spark { get; set; }
}

/// <summary>
/// Authentication using Google owned service account to assume into customer&apos;s AWS IAM Role.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }
}

/// <summary>
/// Connection properties specific to Amazon Web Services.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAws
{
    /// <summary>
    /// Authentication using Google owned service account to assume into customer&apos;s AWS IAM Role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("accessRole")]
    public V1beta2ConnectionSpecInitProviderAwsAccessRole? AccessRole { get; set; }
}

/// <summary>
/// Container for connection properties specific to Azure.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderAzure
{
    /// <summary>The id of customer&apos;s directory that host the data.</summary>
    [JsonPropertyName("customerTenantId")]
    public string? CustomerTenantId { get; set; }

    /// <summary>The Azure Application (client) ID where the federated credentials will be hosted.</summary>
    [JsonPropertyName("federatedApplicationClientId")]
    public string? FederatedApplicationClientId { get; set; }
}

/// <summary>
/// Container for connection properties for delegation of access to GCP resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudResource
{
}

/// <summary>
/// Connection properties specific to Cloud Spanner
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSpanner
{
    /// <summary>Cloud Spanner database in the form `project/instance/database&apos;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as SELECT and INSERT. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. useParallelism and useDataBoost must be set when setting max parallelism.</summary>
    [JsonPropertyName("maxParallelism")]
    public double? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute resources. use_parallelism must be set when using data boost.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner.</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. useParallelism must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary>
/// Password for database.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlCredentialPasswordSecretRef
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a User in sql to populate username.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelector
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
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Cloud SQL properties.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlCredential
{
    /// <summary>
    /// Password for database.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta2ConnectionSpecInitProviderCloudSqlCredentialPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>Username for database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Reference to a User in sql to populate username.</summary>
    [JsonPropertyName("usernameRef")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameRef? UsernameRef { get; set; }

    /// <summary>Selector for a User in sql to populate username.</summary>
    [JsonPropertyName("usernameSelector")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredentialUsernameSelector? UsernameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in sql to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelector
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
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelector
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
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Connection properties specific to the Cloud SQL.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderCloudSql
{
    /// <summary>
    /// Cloud SQL properties.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("credential")]
    public V1beta2ConnectionSpecInitProviderCloudSqlCredential? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in sql to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta2ConnectionSpecInitProviderCloudSqlDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>Cloud SQL instance ID in the form project:location:instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a DatabaseInstance in sql to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta2ConnectionSpecInitProviderCloudSqlInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>
    /// Type of the Cloud SQL database.
    /// Possible values are: DATABASE_TYPE_UNSPECIFIED, POSTGRES, MYSQL.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Dataproc Metastore Service configuration for the connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSparkMetastoreServiceConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelector
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
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Spark History Server configuration for the connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterRef")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterRef? DataprocClusterRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate dataprocCluster.</summary>
    [JsonPropertyName("dataprocClusterSelector")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfigDataprocClusterSelector? DataprocClusterSelector { get; set; }
}

/// <summary>
/// Container for connection properties to execute stored procedures for Apache Spark. resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecInitProviderSpark
{
    /// <summary>
    /// Dataproc Metastore Service configuration for the connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metastoreServiceConfig")]
    public V1beta2ConnectionSpecInitProviderSparkMetastoreServiceConfig? MetastoreServiceConfig { get; set; }

    /// <summary>
    /// Spark History Server configuration for the connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta2ConnectionSpecInitProviderSparkSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
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
public partial class V1beta2ConnectionSpecInitProvider
{
    /// <summary>
    /// Connection properties specific to Amazon Web Services.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aws")]
    public V1beta2ConnectionSpecInitProviderAws? Aws { get; set; }

    /// <summary>
    /// Container for connection properties specific to Azure.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("azure")]
    public V1beta2ConnectionSpecInitProviderAzure? Azure { get; set; }

    /// <summary>
    /// Container for connection properties for delegation of access to GCP resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudResource")]
    public V1beta2ConnectionSpecInitProviderCloudResource? CloudResource { get; set; }

    /// <summary>
    /// Connection properties specific to Cloud Spanner
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudSpanner")]
    public V1beta2ConnectionSpecInitProviderCloudSpanner? CloudSpanner { get; set; }

    /// <summary>
    /// Connection properties specific to the Cloud SQL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudSql")]
    public V1beta2ConnectionSpecInitProviderCloudSql? CloudSql { get; set; }

    /// <summary>Optional connection id that should be assigned to the created connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A descriptive description for the connection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A descriptive name for the connection</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>
    /// Optional. The Cloud KMS key that is used for encryption.
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Container for connection properties to execute stored procedures for Apache Spark. resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spark")]
    public V1beta2ConnectionSpecInitProviderSpark? Spark { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecManagementPoliciesEnum>))]
public enum V1beta2ConnectionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ConnectionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConnectionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ConnectionSpec defines the desired state of Connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionSpec
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
    public V1beta2ConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ConnectionSpecForProvider ForProvider { get; set; }

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
    public V1beta2ConnectionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Authentication using Google owned service account to assume into customer&apos;s AWS IAM Role.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAwsAccessRole
{
    /// <summary>The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }

    /// <summary>
    /// (Output)
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&apos;s AWS IAM Role.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }
}

/// <summary>
/// Connection properties specific to Amazon Web Services.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAws
{
    /// <summary>
    /// Authentication using Google owned service account to assume into customer&apos;s AWS IAM Role.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("accessRole")]
    public V1beta2ConnectionStatusAtProviderAwsAccessRole? AccessRole { get; set; }
}

/// <summary>
/// Container for connection properties specific to Azure.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderAzure
{
    /// <summary>
    /// (Output)
    /// The name of the Azure Active Directory Application.
    /// </summary>
    [JsonPropertyName("application")]
    public string? Application { get; set; }

    /// <summary>
    /// (Output)
    /// The client id of the Azure Active Directory Application.
    /// </summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The id of customer&apos;s directory that host the data.</summary>
    [JsonPropertyName("customerTenantId")]
    public string? CustomerTenantId { get; set; }

    /// <summary>The Azure Application (client) ID where the federated credentials will be hosted.</summary>
    [JsonPropertyName("federatedApplicationClientId")]
    public string? FederatedApplicationClientId { get; set; }

    /// <summary>
    /// (Output)
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&apos;s Azure Active Directory Application.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// (Output)
    /// The object id of the Azure Active Directory Application.
    /// </summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// (Output)
    /// The URL user will be redirected to after granting consent during connection setup.
    /// </summary>
    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }
}

/// <summary>
/// Container for connection properties for delegation of access to GCP resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderCloudResource
{
    /// <summary>
    /// (Output)
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    [JsonPropertyName("serviceAccountId")]
    public string? ServiceAccountId { get; set; }
}

/// <summary>
/// Connection properties specific to Cloud Spanner
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderCloudSpanner
{
    /// <summary>Cloud Spanner database in the form `project/instance/database&apos;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as SELECT and INSERT. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.</summary>
    [JsonPropertyName("databaseRole")]
    public string? DatabaseRole { get; set; }

    /// <summary>Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. useParallelism and useDataBoost must be set when setting max parallelism.</summary>
    [JsonPropertyName("maxParallelism")]
    public double? MaxParallelism { get; set; }

    /// <summary>If set, the request will be executed via Spanner independent compute resources. use_parallelism must be set when using data boost.</summary>
    [JsonPropertyName("useDataBoost")]
    public bool? UseDataBoost { get; set; }

    /// <summary>If parallelism should be used when reading from Cloud Spanner.</summary>
    [JsonPropertyName("useParallelism")]
    public bool? UseParallelism { get; set; }

    /// <summary>If the serverless analytics service should be used to read data from Cloud Spanner. useParallelism must be set when using serverless analytics.</summary>
    [JsonPropertyName("useServerlessAnalytics")]
    public bool? UseServerlessAnalytics { get; set; }
}

/// <summary>
/// Cloud SQL properties.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderCloudSqlCredential
{
    /// <summary>Username for database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Connection properties specific to the Cloud SQL.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderCloudSql
{
    /// <summary>
    /// Cloud SQL properties.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("credential")]
    public V1beta2ConnectionStatusAtProviderCloudSqlCredential? Credential { get; set; }

    /// <summary>Database name.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Cloud SQL instance ID in the form project:location:instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>
    /// (Output)
    /// When the connection is used in the context of an operation in BigQuery, this service account will serve as the identity being used for connecting to the CloudSQL instance specified in this connection.
    /// </summary>
    [JsonPropertyName("serviceAccountId")]
    public string? ServiceAccountId { get; set; }

    /// <summary>
    /// Type of the Cloud SQL database.
    /// Possible values are: DATABASE_TYPE_UNSPECIFIED, POSTGRES, MYSQL.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Dataproc Metastore Service configuration for the connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderSparkMetastoreServiceConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].</summary>
    [JsonPropertyName("metastoreService")]
    public string? MetastoreService { get; set; }
}

/// <summary>
/// Spark History Server configuration for the connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderSparkSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}

/// <summary>
/// Container for connection properties to execute stored procedures for Apache Spark. resources.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProviderSpark
{
    /// <summary>
    /// Dataproc Metastore Service configuration for the connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metastoreServiceConfig")]
    public V1beta2ConnectionStatusAtProviderSparkMetastoreServiceConfig? MetastoreServiceConfig { get; set; }

    /// <summary>
    /// (Output)
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    [JsonPropertyName("serviceAccountId")]
    public string? ServiceAccountId { get; set; }

    /// <summary>
    /// Spark History Server configuration for the connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta2ConnectionStatusAtProviderSparkSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusAtProvider
{
    /// <summary>
    /// Connection properties specific to Amazon Web Services.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aws")]
    public V1beta2ConnectionStatusAtProviderAws? Aws { get; set; }

    /// <summary>
    /// Container for connection properties specific to Azure.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("azure")]
    public V1beta2ConnectionStatusAtProviderAzure? Azure { get; set; }

    /// <summary>
    /// Container for connection properties for delegation of access to GCP resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudResource")]
    public V1beta2ConnectionStatusAtProviderCloudResource? CloudResource { get; set; }

    /// <summary>
    /// Connection properties specific to Cloud Spanner
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudSpanner")]
    public V1beta2ConnectionStatusAtProviderCloudSpanner? CloudSpanner { get; set; }

    /// <summary>
    /// Connection properties specific to the Cloud SQL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudSql")]
    public V1beta2ConnectionStatusAtProviderCloudSql? CloudSql { get; set; }

    /// <summary>Optional connection id that should be assigned to the created connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>A descriptive description for the connection</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A descriptive name for the connection</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>True if the connection has credential assigned.</summary>
    [JsonPropertyName("hasCredential")]
    public bool? HasCredential { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/connections/{{connection_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Optional. The Cloud KMS key that is used for encryption.
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The resource name of the connection in the form of:
    /// &quot;projects/{project_id}/locations/{location_id}/connections/{connectionId}&quot;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Container for connection properties to execute stored procedures for Apache Spark. resources.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spark")]
    public V1beta2ConnectionStatusAtProviderSpark? Spark { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatusConditions
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

/// <summary>ConnectionStatus defines the observed state of Connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConnectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Connection is the Schema for the Connections API. A connection allows BigQuery connections to external data sources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Connection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ConnectionSpec>, IStatus<V1beta2ConnectionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Connection";
    public const string KubeGroup = "bigquery.gcp.upbound.io";
    public const string KubePluralName = "connections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquery.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Connection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionSpec defines the desired state of Connection</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ConnectionSpec Spec { get; set; }

    /// <summary>ConnectionStatus defines the observed state of Connection.</summary>
    [JsonPropertyName("status")]
    public V1beta2ConnectionStatus? Status { get; set; }
}