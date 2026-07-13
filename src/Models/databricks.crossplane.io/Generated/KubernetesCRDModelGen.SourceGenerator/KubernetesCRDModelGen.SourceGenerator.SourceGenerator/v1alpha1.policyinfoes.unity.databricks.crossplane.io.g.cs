#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary>
/// PolicyInfo is the Schema for the PolicyInfos API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PolicyInfoList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PolicyInfo>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PolicyInfoList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "policyinfoes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyInfoList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PolicyInfo objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PolicyInfo> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PolicyInfoSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1PolicyInfoSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProviderColumnMaskUsing
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>A constant literal</summary>
    [JsonPropertyName("constant")]
    public string? Constant { get; set; }
}

/// <summary>
/// Options for column mask policies. Valid only if policy_type is POLICY_TYPE_COLUMN_MASK.
/// Required on create and optional on update. When specified on update,
/// the new options will replace the existing options as a whole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProviderColumnMask
{
    /// <summary>
    /// The fully qualified name of the column mask function.
    /// The function is called on each row of the target table.
    /// The function&apos;s first argument and its return type should match the type of the masked column.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// The alias of the column to be masked. The alias must refer to one of matched columns.
    /// The values of the column is passed to the column mask function as the first argument.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("onColumn")]
    public string? OnColumn { get; set; }

    /// <summary>
    /// Optional list of column aliases or constant literals to be passed as additional arguments to the column mask function.
    /// The type of each column should match the positional argument of the column mask function
    /// </summary>
    [JsonPropertyName("using")]
    public IList<V1alpha1PolicyInfoSpecForProviderColumnMaskUsing>? Using { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProviderMatchColumns
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>The condition expression used to match a table column</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProviderRowFilterUsing
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>A constant literal</summary>
    [JsonPropertyName("constant")]
    public string? Constant { get; set; }
}

/// <summary>
/// Options for row filter policies. Valid only if policy_type is POLICY_TYPE_ROW_FILTER.
/// Required on create and optional on update. When specified on update,
/// the new options will replace the existing options as a whole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProviderRowFilter
{
    /// <summary>
    /// The fully qualified name of the column mask function.
    /// The function is called on each row of the target table.
    /// The function&apos;s first argument and its return type should match the type of the masked column.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// Optional list of column aliases or constant literals to be passed as additional arguments to the column mask function.
    /// The type of each column should match the positional argument of the column mask function
    /// </summary>
    [JsonPropertyName("using")]
    public IList<V1alpha1PolicyInfoSpecForProviderRowFilterUsing>? Using { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecForProvider
{
    /// <summary>
    /// Options for column mask policies. Valid only if policy_type is POLICY_TYPE_COLUMN_MASK.
    /// Required on create and optional on update. When specified on update,
    /// the new options will replace the existing options as a whole
    /// </summary>
    [JsonPropertyName("columnMask")]
    public V1alpha1PolicyInfoSpecForProviderColumnMask? ColumnMask { get; set; }

    /// <summary>Optional description of the policy</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Optional list of user or group names that should be excluded from the policy</summary>
    [JsonPropertyName("exceptPrincipals")]
    public IList<string>? ExceptPrincipals { get; set; }

    /// <summary>
    /// Type of securables that the policy should take effect on.
    /// Only TABLE is supported at this moment.
    /// Required on create and optional on update. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("forSecurableType")]
    public string? ForSecurableType { get; set; }

    /// <summary>
    /// Optional list of condition expressions used to match table columns.
    /// Only valid when for_securable_type is TABLE.
    /// When specified, the policy only applies to tables whose columns satisfy all match conditions
    /// </summary>
    [JsonPropertyName("matchColumns")]
    public IList<V1alpha1PolicyInfoSpecForProviderMatchColumns>? MatchColumns { get; set; }

    /// <summary>
    /// Full name of the securable on which the policy is defined.
    /// Required on create
    /// </summary>
    [JsonPropertyName("onSecurableFullname")]
    public string? OnSecurableFullname { get; set; }

    /// <summary>
    /// Type of the securable on which the policy is defined.
    /// Only CATALOG, SCHEMA and TABLE are supported at this moment.
    /// Required on create. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("onSecurableType")]
    public string? OnSecurableType { get; set; }

    /// <summary>Type of the policy. Required on create. Possible values are: POLICY_TYPE_COLUMN_MASK, POLICY_TYPE_ROW_FILTER</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1alpha1PolicyInfoSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// Options for row filter policies. Valid only if policy_type is POLICY_TYPE_ROW_FILTER.
    /// Required on create and optional on update. When specified on update,
    /// the new options will replace the existing options as a whole
    /// </summary>
    [JsonPropertyName("rowFilter")]
    public V1alpha1PolicyInfoSpecForProviderRowFilter? RowFilter { get; set; }

    /// <summary>
    /// List of user or group names that the policy applies to.
    /// Required on create and optional on update
    /// </summary>
    [JsonPropertyName("toPrincipals")]
    public IList<string>? ToPrincipals { get; set; }

    /// <summary>Optional condition when the policy should take effect</summary>
    [JsonPropertyName("whenCondition")]
    public string? WhenCondition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecInitProviderColumnMaskUsing
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>A constant literal</summary>
    [JsonPropertyName("constant")]
    public string? Constant { get; set; }
}

/// <summary>
/// Options for column mask policies. Valid only if policy_type is POLICY_TYPE_COLUMN_MASK.
/// Required on create and optional on update. When specified on update,
/// the new options will replace the existing options as a whole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecInitProviderColumnMask
{
    /// <summary>
    /// The fully qualified name of the column mask function.
    /// The function is called on each row of the target table.
    /// The function&apos;s first argument and its return type should match the type of the masked column.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// The alias of the column to be masked. The alias must refer to one of matched columns.
    /// The values of the column is passed to the column mask function as the first argument.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("onColumn")]
    public string? OnColumn { get; set; }

    /// <summary>
    /// Optional list of column aliases or constant literals to be passed as additional arguments to the column mask function.
    /// The type of each column should match the positional argument of the column mask function
    /// </summary>
    [JsonPropertyName("using")]
    public IList<V1alpha1PolicyInfoSpecInitProviderColumnMaskUsing>? Using { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecInitProviderMatchColumns
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>The condition expression used to match a table column</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecInitProviderRowFilterUsing
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>A constant literal</summary>
    [JsonPropertyName("constant")]
    public string? Constant { get; set; }
}

/// <summary>
/// Options for row filter policies. Valid only if policy_type is POLICY_TYPE_ROW_FILTER.
/// Required on create and optional on update. When specified on update,
/// the new options will replace the existing options as a whole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecInitProviderRowFilter
{
    /// <summary>
    /// The fully qualified name of the column mask function.
    /// The function is called on each row of the target table.
    /// The function&apos;s first argument and its return type should match the type of the masked column.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// Optional list of column aliases or constant literals to be passed as additional arguments to the column mask function.
    /// The type of each column should match the positional argument of the column mask function
    /// </summary>
    [JsonPropertyName("using")]
    public IList<V1alpha1PolicyInfoSpecInitProviderRowFilterUsing>? Using { get; set; }
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
public partial class V1alpha1PolicyInfoSpecInitProvider
{
    /// <summary>
    /// Options for column mask policies. Valid only if policy_type is POLICY_TYPE_COLUMN_MASK.
    /// Required on create and optional on update. When specified on update,
    /// the new options will replace the existing options as a whole
    /// </summary>
    [JsonPropertyName("columnMask")]
    public V1alpha1PolicyInfoSpecInitProviderColumnMask? ColumnMask { get; set; }

    /// <summary>Optional description of the policy</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Optional list of user or group names that should be excluded from the policy</summary>
    [JsonPropertyName("exceptPrincipals")]
    public IList<string>? ExceptPrincipals { get; set; }

    /// <summary>
    /// Type of securables that the policy should take effect on.
    /// Only TABLE is supported at this moment.
    /// Required on create and optional on update. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("forSecurableType")]
    public string? ForSecurableType { get; set; }

    /// <summary>
    /// Optional list of condition expressions used to match table columns.
    /// Only valid when for_securable_type is TABLE.
    /// When specified, the policy only applies to tables whose columns satisfy all match conditions
    /// </summary>
    [JsonPropertyName("matchColumns")]
    public IList<V1alpha1PolicyInfoSpecInitProviderMatchColumns>? MatchColumns { get; set; }

    /// <summary>
    /// Full name of the securable on which the policy is defined.
    /// Required on create
    /// </summary>
    [JsonPropertyName("onSecurableFullname")]
    public string? OnSecurableFullname { get; set; }

    /// <summary>
    /// Type of the securable on which the policy is defined.
    /// Only CATALOG, SCHEMA and TABLE are supported at this moment.
    /// Required on create. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("onSecurableType")]
    public string? OnSecurableType { get; set; }

    /// <summary>Type of the policy. Required on create. Possible values are: POLICY_TYPE_COLUMN_MASK, POLICY_TYPE_ROW_FILTER</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1alpha1PolicyInfoSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// Options for row filter policies. Valid only if policy_type is POLICY_TYPE_ROW_FILTER.
    /// Required on create and optional on update. When specified on update,
    /// the new options will replace the existing options as a whole
    /// </summary>
    [JsonPropertyName("rowFilter")]
    public V1alpha1PolicyInfoSpecInitProviderRowFilter? RowFilter { get; set; }

    /// <summary>
    /// List of user or group names that the policy applies to.
    /// Required on create and optional on update
    /// </summary>
    [JsonPropertyName("toPrincipals")]
    public IList<string>? ToPrincipals { get; set; }

    /// <summary>Optional condition when the policy should take effect</summary>
    [JsonPropertyName("whenCondition")]
    public string? WhenCondition { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PolicyInfoSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1PolicyInfoSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PolicyInfoSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1PolicyInfoSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1PolicyInfoSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1PolicyInfoSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1alpha1PolicyInfoSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1PolicyInfoSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1PolicyInfoSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1PolicyInfoSpecProviderConfigRefPolicy? Policy { get; set; }
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
public partial class V1alpha1PolicyInfoSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PolicyInfoSpec defines the desired state of PolicyInfo</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoSpec
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
    public V1alpha1PolicyInfoSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1PolicyInfoSpecForProvider ForProvider { get; set; }

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
    public V1alpha1PolicyInfoSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1PolicyInfoSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1PolicyInfoSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1PolicyInfoSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProviderColumnMaskUsing
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>A constant literal</summary>
    [JsonPropertyName("constant")]
    public string? Constant { get; set; }
}

/// <summary>
/// Options for column mask policies. Valid only if policy_type is POLICY_TYPE_COLUMN_MASK.
/// Required on create and optional on update. When specified on update,
/// the new options will replace the existing options as a whole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProviderColumnMask
{
    /// <summary>
    /// The fully qualified name of the column mask function.
    /// The function is called on each row of the target table.
    /// The function&apos;s first argument and its return type should match the type of the masked column.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// The alias of the column to be masked. The alias must refer to one of matched columns.
    /// The values of the column is passed to the column mask function as the first argument.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("onColumn")]
    public string? OnColumn { get; set; }

    /// <summary>
    /// Optional list of column aliases or constant literals to be passed as additional arguments to the column mask function.
    /// The type of each column should match the positional argument of the column mask function
    /// </summary>
    [JsonPropertyName("using")]
    public IList<V1alpha1PolicyInfoStatusAtProviderColumnMaskUsing>? Using { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProviderMatchColumns
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>The condition expression used to match a table column</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProviderRowFilterUsing
{
    /// <summary>The alias of a matched column</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>A constant literal</summary>
    [JsonPropertyName("constant")]
    public string? Constant { get; set; }
}

/// <summary>
/// Options for row filter policies. Valid only if policy_type is POLICY_TYPE_ROW_FILTER.
/// Required on create and optional on update. When specified on update,
/// the new options will replace the existing options as a whole
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProviderRowFilter
{
    /// <summary>
    /// The fully qualified name of the column mask function.
    /// The function is called on each row of the target table.
    /// The function&apos;s first argument and its return type should match the type of the masked column.
    /// Required on create and update
    /// </summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>
    /// Optional list of column aliases or constant literals to be passed as additional arguments to the column mask function.
    /// The type of each column should match the positional argument of the column mask function
    /// </summary>
    [JsonPropertyName("using")]
    public IList<V1alpha1PolicyInfoStatusAtProviderRowFilterUsing>? Using { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusAtProvider
{
    /// <summary>
    /// Options for column mask policies. Valid only if policy_type is POLICY_TYPE_COLUMN_MASK.
    /// Required on create and optional on update. When specified on update,
    /// the new options will replace the existing options as a whole
    /// </summary>
    [JsonPropertyName("columnMask")]
    public V1alpha1PolicyInfoStatusAtProviderColumnMask? ColumnMask { get; set; }

    /// <summary>Optional description of the policy</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Time at which the policy was created, in epoch milliseconds. Output only</summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary>Username of the user who created the policy. Output only</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Optional list of user or group names that should be excluded from the policy</summary>
    [JsonPropertyName("exceptPrincipals")]
    public IList<string>? ExceptPrincipals { get; set; }

    /// <summary>
    /// Type of securables that the policy should take effect on.
    /// Only TABLE is supported at this moment.
    /// Required on create and optional on update. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("forSecurableType")]
    public string? ForSecurableType { get; set; }

    /// <summary>Unique identifier of the policy. This field is output only and is generated by the system</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Optional list of condition expressions used to match table columns.
    /// Only valid when for_securable_type is TABLE.
    /// When specified, the policy only applies to tables whose columns satisfy all match conditions
    /// </summary>
    [JsonPropertyName("matchColumns")]
    public IList<V1alpha1PolicyInfoStatusAtProviderMatchColumns>? MatchColumns { get; set; }

    /// <summary>
    /// Full name of the securable on which the policy is defined.
    /// Required on create
    /// </summary>
    [JsonPropertyName("onSecurableFullname")]
    public string? OnSecurableFullname { get; set; }

    /// <summary>
    /// Type of the securable on which the policy is defined.
    /// Only CATALOG, SCHEMA and TABLE are supported at this moment.
    /// Required on create. Possible values are: CATALOG, CLEAN_ROOM, CONNECTION, CREDENTIAL, EXTERNAL_LOCATION, EXTERNAL_METADATA, FUNCTION, METASTORE, PIPELINE, PROVIDER, RECIPIENT, SCHEMA, SHARE, STAGING_TABLE, STORAGE_CREDENTIAL, TABLE, VOLUME
    /// </summary>
    [JsonPropertyName("onSecurableType")]
    public string? OnSecurableType { get; set; }

    /// <summary>Type of the policy. Required on create. Possible values are: POLICY_TYPE_COLUMN_MASK, POLICY_TYPE_ROW_FILTER</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1alpha1PolicyInfoStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// Options for row filter policies. Valid only if policy_type is POLICY_TYPE_ROW_FILTER.
    /// Required on create and optional on update. When specified on update,
    /// the new options will replace the existing options as a whole
    /// </summary>
    [JsonPropertyName("rowFilter")]
    public V1alpha1PolicyInfoStatusAtProviderRowFilter? RowFilter { get; set; }

    /// <summary>
    /// List of user or group names that the policy applies to.
    /// Required on create and optional on update
    /// </summary>
    [JsonPropertyName("toPrincipals")]
    public IList<string>? ToPrincipals { get; set; }

    /// <summary>Time at which the policy was last modified, in epoch milliseconds. Output only</summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary>Username of the user who last modified the policy. Output only</summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary>Optional condition when the policy should take effect</summary>
    [JsonPropertyName("whenCondition")]
    public string? WhenCondition { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatusConditions
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

/// <summary>PolicyInfoStatus defines the observed state of PolicyInfo.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1PolicyInfoStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1PolicyInfoStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PolicyInfoStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// PolicyInfo is the Schema for the PolicyInfos API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PolicyInfo : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PolicyInfoSpec>, IStatus<V1alpha1PolicyInfoStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PolicyInfo";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "policyinfoes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyInfo";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicyInfoSpec defines the desired state of PolicyInfo</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1PolicyInfoSpec Spec { get; set; }

    /// <summary>PolicyInfoStatus defines the observed state of PolicyInfo.</summary>
    [JsonPropertyName("status")]
    public V1alpha1PolicyInfoStatus? Status { get; set; }
}