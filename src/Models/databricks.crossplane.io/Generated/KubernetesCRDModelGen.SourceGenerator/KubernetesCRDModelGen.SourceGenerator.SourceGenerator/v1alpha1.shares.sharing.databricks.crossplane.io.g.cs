#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sharing.databricks.crossplane.io;
/// <summary>
/// Share is the Schema for the Shares API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ShareList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Share>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ShareList";
    public const string KubeGroup = "sharing.databricks.crossplane.io";
    public const string KubePluralName = "shares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sharing.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ShareList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Share objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Share> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ShareSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1ShareSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecForProviderObjectPartitionValue
{
    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to apply for the value, one of: EQUAL, LIKE</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The key of a Delta Sharing recipient&apos;s property. For example databricks-account-id. When this field is set, field value can not be set.</summary>
    [JsonPropertyName("recipientPropertyKey")]
    public string? RecipientPropertyKey { get; set; }

    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecForProviderObjectPartition
{
    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1ShareSpecForProviderObjectPartitionValue>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecForProviderObject
{
    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("cdfEnabled")]
    public bool? CdfEnabled { get; set; }

    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The content of the notebook file when the data object type is NOTEBOOK_FILE. This should be base64 encoded. Required for adding a NOTEBOOK_FILE, optional for updating, ignored for other types.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of the data object. Supported types: TABLE, FOREIGN_TABLE, SCHEMA, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, MODEL, NOTEBOOK_FILE, FUNCTION, FEATURE_SPEC, and VOLUME.</summary>
    [JsonPropertyName("dataObjectType")]
    public string? DataObjectType { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("historyDataSharingStatus")]
    public string? HistoryDataSharingStatus { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Array of partitions for the shared data.</summary>
    [JsonPropertyName("partition")]
    public IList<V1alpha1ShareSpecForProviderObjectPartition>? Partition { get; set; }

    /// <summary>A user-provided alias name for table-like data objects within the share. Use this field for: TABLE, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, FOREIGN_TABLE. Do not use this field for volumes, models, notebooks, or functions (use string_shared_as instead). If not provided, the object&apos;s original name will be used. Must be a 2-part name &lt;schema&gt;.&lt;table&gt; containing only alphanumeric characters and underscores. The shared_as name must be unique within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("sharedAs")]
    public string? SharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("startVersion")]
    public double? StartVersion { get; set; }

    /// <summary>A user-provided alias name for non-table data objects within the share. Use this field for: VOLUME, MODEL, NOTEBOOK_FILE, FUNCTION. Do not use this field for tables, views, or streaming tables (use shared_as instead). Format varies by type: For volumes, models, and functions use &lt;schema&gt;.&lt;name&gt; (2-part name); for notebooks use the file name. Names must contain only alphanumeric characters and underscores. The string_shared_as name must be unique for objects of the same type within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("stringSharedAs")]
    public string? StringSharedAs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecForProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("object")]
    public IList<V1alpha1ShareSpecForProviderObject>? Object { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1ShareSpecForProviderProviderConfig>? ProviderConfig { get; set; }

    [JsonPropertyName("storageRoot")]
    public string? StorageRoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecInitProviderObjectPartitionValue
{
    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to apply for the value, one of: EQUAL, LIKE</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The key of a Delta Sharing recipient&apos;s property. For example databricks-account-id. When this field is set, field value can not be set.</summary>
    [JsonPropertyName("recipientPropertyKey")]
    public string? RecipientPropertyKey { get; set; }

    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecInitProviderObjectPartition
{
    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1ShareSpecInitProviderObjectPartitionValue>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecInitProviderObject
{
    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("cdfEnabled")]
    public bool? CdfEnabled { get; set; }

    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The content of the notebook file when the data object type is NOTEBOOK_FILE. This should be base64 encoded. Required for adding a NOTEBOOK_FILE, optional for updating, ignored for other types.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of the data object. Supported types: TABLE, FOREIGN_TABLE, SCHEMA, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, MODEL, NOTEBOOK_FILE, FUNCTION, FEATURE_SPEC, and VOLUME.</summary>
    [JsonPropertyName("dataObjectType")]
    public string? DataObjectType { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("historyDataSharingStatus")]
    public string? HistoryDataSharingStatus { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Array of partitions for the shared data.</summary>
    [JsonPropertyName("partition")]
    public IList<V1alpha1ShareSpecInitProviderObjectPartition>? Partition { get; set; }

    /// <summary>A user-provided alias name for table-like data objects within the share. Use this field for: TABLE, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, FOREIGN_TABLE. Do not use this field for volumes, models, notebooks, or functions (use string_shared_as instead). If not provided, the object&apos;s original name will be used. Must be a 2-part name &lt;schema&gt;.&lt;table&gt; containing only alphanumeric characters and underscores. The shared_as name must be unique within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("sharedAs")]
    public string? SharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("startVersion")]
    public double? StartVersion { get; set; }

    /// <summary>A user-provided alias name for non-table data objects within the share. Use this field for: VOLUME, MODEL, NOTEBOOK_FILE, FUNCTION. Do not use this field for tables, views, or streaming tables (use shared_as instead). Format varies by type: For volumes, models, and functions use &lt;schema&gt;.&lt;name&gt; (2-part name); for notebooks use the file name. Names must contain only alphanumeric characters and underscores. The string_shared_as name must be unique for objects of the same type within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("stringSharedAs")]
    public string? StringSharedAs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecInitProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("object")]
    public IList<V1alpha1ShareSpecInitProviderObject>? Object { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1ShareSpecInitProviderProviderConfig>? ProviderConfig { get; set; }

    [JsonPropertyName("storageRoot")]
    public string? StorageRoot { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ShareSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1ShareSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ShareSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1ShareSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ShareSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1ShareSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1ShareSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1ShareSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ShareSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ShareSpec defines the desired state of Share</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareSpec
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
    public V1alpha1ShareSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1ShareSpecForProvider ForProvider { get; set; }

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
    public V1alpha1ShareSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1ShareSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ShareSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ShareSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatusAtProviderObjectPartitionValue
{
    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to apply for the value, one of: EQUAL, LIKE</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The key of a Delta Sharing recipient&apos;s property. For example databricks-account-id. When this field is set, field value can not be set.</summary>
    [JsonPropertyName("recipientPropertyKey")]
    public string? RecipientPropertyKey { get; set; }

    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatusAtProviderObjectPartition
{
    /// <summary>The value of the partition column. When this value is not set, it means null value. When this field is set, field recipient_property_key can not be set.</summary>
    [JsonPropertyName("value")]
    public IList<V1alpha1ShareStatusAtProviderObjectPartitionValue>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatusAtProviderObject
{
    [JsonPropertyName("addedAt")]
    public double? AddedAt { get; set; }

    [JsonPropertyName("addedBy")]
    public string? AddedBy { get; set; }

    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("cdfEnabled")]
    public bool? CdfEnabled { get; set; }

    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>The content of the notebook file when the data object type is NOTEBOOK_FILE. This should be base64 encoded. Required for adding a NOTEBOOK_FILE, optional for updating, ignored for other types.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Type of the data object. Supported types: TABLE, FOREIGN_TABLE, SCHEMA, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, MODEL, NOTEBOOK_FILE, FUNCTION, FEATURE_SPEC, and VOLUME.</summary>
    [JsonPropertyName("dataObjectType")]
    public string? DataObjectType { get; set; }

    /// <summary>Whether to enable Change Data Feed (cdf) on the shared object. When this field is set, field history_data_sharing_status can not be set.</summary>
    [JsonPropertyName("effectiveCdfEnabled")]
    public bool? EffectiveCdfEnabled { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("effectiveHistoryDataSharingStatus")]
    public string? EffectiveHistoryDataSharingStatus { get; set; }

    /// <summary>A user-provided alias name for table-like data objects within the share. Use this field for: TABLE, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, FOREIGN_TABLE. Do not use this field for volumes, models, notebooks, or functions (use string_shared_as instead). If not provided, the object&apos;s original name will be used. Must be a 2-part name &lt;schema&gt;.&lt;table&gt; containing only alphanumeric characters and underscores. The shared_as name must be unique within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("effectiveSharedAs")]
    public string? EffectiveSharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("effectiveStartVersion")]
    public double? EffectiveStartVersion { get; set; }

    /// <summary>A user-provided alias name for non-table data objects within the share. Use this field for: VOLUME, MODEL, NOTEBOOK_FILE, FUNCTION. Do not use this field for tables, views, or streaming tables (use shared_as instead). Format varies by type: For volumes, models, and functions use &lt;schema&gt;.&lt;name&gt; (2-part name); for notebooks use the file name. Names must contain only alphanumeric characters and underscores. The string_shared_as name must be unique for objects of the same type within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("effectiveStringSharedAs")]
    public string? EffectiveStringSharedAs { get; set; }

    /// <summary>Whether to enable history sharing, one of: ENABLED, DISABLED. When a table has history sharing enabled, recipients can query table data by version, starting from the current table version. If not specified, clients can only query starting from the version of the object at the time it was added to the share. NOTE: The start_version should be less than or equal the current version of the object. When this field is set, field cdf_enabled can not be set.</summary>
    [JsonPropertyName("historyDataSharingStatus")]
    public string? HistoryDataSharingStatus { get; set; }

    /// <summary>Name of share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Array of partitions for the shared data.</summary>
    [JsonPropertyName("partition")]
    public IList<V1alpha1ShareStatusAtProviderObjectPartition>? Partition { get; set; }

    /// <summary>A user-provided alias name for table-like data objects within the share. Use this field for: TABLE, VIEW, MATERIALIZED_VIEW, STREAMING_TABLE, FOREIGN_TABLE. Do not use this field for volumes, models, notebooks, or functions (use string_shared_as instead). If not provided, the object&apos;s original name will be used. Must be a 2-part name &lt;schema&gt;.&lt;table&gt; containing only alphanumeric characters and underscores. The shared_as name must be unique within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("sharedAs")]
    public string? SharedAs { get; set; }

    /// <summary>The start version associated with the object for cdf. This allows data providers to control the lowest object version that is accessible by clients.</summary>
    [JsonPropertyName("startVersion")]
    public double? StartVersion { get; set; }

    /// <summary>Status of the object, one of: ACTIVE, PERMISSION_DENIED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A user-provided alias name for non-table data objects within the share. Use this field for: VOLUME, MODEL, NOTEBOOK_FILE, FUNCTION. Do not use this field for tables, views, or streaming tables (use shared_as instead). Format varies by type: For volumes, models, and functions use &lt;schema&gt;.&lt;name&gt; (2-part name); for notebooks use the file name. Names must contain only alphanumeric characters and underscores. The string_shared_as name must be unique for objects of the same type within a share. Change forces creation of a new resource.</summary>
    [JsonPropertyName("stringSharedAs")]
    public string? StringSharedAs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatusAtProvider
{
    /// <summary>User-supplied free-form text.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time when the share was created.</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>The principal that created the share.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("effectiveOwner")]
    public string? EffectiveOwner { get; set; }

    /// <summary>the ID of the share, the same as name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("object")]
    public IList<V1alpha1ShareStatusAtProviderObject>? Object { get; set; }

    /// <summary>User name/group name/sp application_id of the share owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1ShareStatusAtProviderProviderConfig>? ProviderConfig { get; set; }

    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    [JsonPropertyName("storageRoot")]
    public string? StorageRoot { get; set; }

    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatusConditions
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

/// <summary>ShareStatus defines the observed state of Share.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1ShareStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1ShareStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ShareStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// Share is the Schema for the Shares API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Share : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ShareSpec>, IStatus<V1alpha1ShareStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Share";
    public const string KubeGroup = "sharing.databricks.crossplane.io";
    public const string KubePluralName = "shares";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sharing.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Share";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ShareSpec defines the desired state of Share</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ShareSpec Spec { get; set; }

    /// <summary>ShareStatus defines the observed state of Share.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ShareStatus? Status { get; set; }
}