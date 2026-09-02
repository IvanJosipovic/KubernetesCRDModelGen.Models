#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgres.databricks.crossplane.io;
/// <summary>PostgresBranch is the Schema for the PostgresBranchs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresBranchList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PostgresBranch>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresBranchList";
    public const string KubeGroup = "postgres.databricks.crossplane.io";
    public const string KubePluralName = "postgresbranches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresBranchList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PostgresBranch objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PostgresBranch> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecDeletionPolicyEnum>))]
public enum V1beta1PostgresBranchSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecForProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1PostgresBranchSpecForProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecForProviderParentRefPolicyResolveEnum>))]
public enum V1beta1PostgresBranchSpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresBranchSpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresBranchSpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PostgresProject in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresBranchSpecForProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecForProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1PostgresBranchSpecForProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecForProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1PostgresBranchSpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresBranchSpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresBranchSpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PostgresProject in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProviderParentSelector
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
    public V1beta1PostgresBranchSpecForProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The spec contains the branch configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProviderSpec
{
    /// <summary>
    /// Absolute expiration timestamp. When set, the branch will expire at this time.
    /// Mutually exclusive with ttl and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>When set to true, protects the branch from deletion and reset. Associated compute endpoints and the project cannot be deleted while the branch is protected</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>
    /// Explicitly disable expiration. When set to true, the branch will not expire.
    /// If set to false, the request is invalid; provide either ttl or expire_time instead.
    /// Mutually exclusive with expire_time and ttl. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("noExpiry")]
    public bool? NoExpiry { get; set; }

    /// <summary>
    /// The name of the source branch from which this branch was created (data lineage for point-in-time recovery).
    /// If not specified, defaults to the project&apos;s default branch.
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("sourceBranch")]
    public string? SourceBranch { get; set; }

    /// <summary>The Log Sequence Number (LSN) on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchLsn")]
    public string? SourceBranchLsn { get; set; }

    /// <summary>The point in time on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchTime")]
    public string? SourceBranchTime { get; set; }

    /// <summary>
    /// Relative time-to-live duration. When set, the branch will expire at creation_time + ttl.
    /// Mutually exclusive with expire_time and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecForProvider
{
    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("branchId")]
    public string? BranchId { get; set; }

    /// <summary>
    /// The project containing this branch (API resource hierarchy).
    /// Format: projects/{project_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a PostgresProject in postgres to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1PostgresBranchSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a PostgresProject in postgres to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1PostgresBranchSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresBranchSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>If true, permanently delete the branch; if false, soft delete</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>If true, update the branch if it already exists instead of returning an error</summary>
    [JsonPropertyName("replaceExisting")]
    public bool? ReplaceExisting { get; set; }

    /// <summary>The spec contains the branch configuration</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresBranchSpecForProviderSpec? Spec { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecInitProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1PostgresBranchSpecInitProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecInitProviderParentRefPolicyResolveEnum>))]
public enum V1beta1PostgresBranchSpecInitProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecInitProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresBranchSpecInitProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresBranchSpecInitProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PostgresProject in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresBranchSpecInitProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecInitProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1PostgresBranchSpecInitProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecInitProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1PostgresBranchSpecInitProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecInitProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresBranchSpecInitProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresBranchSpecInitProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PostgresProject in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecInitProviderParentSelector
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
    public V1beta1PostgresBranchSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The spec contains the branch configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecInitProviderSpec
{
    /// <summary>
    /// Absolute expiration timestamp. When set, the branch will expire at this time.
    /// Mutually exclusive with ttl and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>When set to true, protects the branch from deletion and reset. Associated compute endpoints and the project cannot be deleted while the branch is protected</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>
    /// Explicitly disable expiration. When set to true, the branch will not expire.
    /// If set to false, the request is invalid; provide either ttl or expire_time instead.
    /// Mutually exclusive with expire_time and ttl. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("noExpiry")]
    public bool? NoExpiry { get; set; }

    /// <summary>
    /// The name of the source branch from which this branch was created (data lineage for point-in-time recovery).
    /// If not specified, defaults to the project&apos;s default branch.
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("sourceBranch")]
    public string? SourceBranch { get; set; }

    /// <summary>The Log Sequence Number (LSN) on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchLsn")]
    public string? SourceBranchLsn { get; set; }

    /// <summary>The point in time on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchTime")]
    public string? SourceBranchTime { get; set; }

    /// <summary>
    /// Relative time-to-live duration. When set, the branch will expire at creation_time + ttl.
    /// Mutually exclusive with expire_time and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
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
public partial class V1beta1PostgresBranchSpecInitProvider
{
    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("branchId")]
    public string? BranchId { get; set; }

    /// <summary>
    /// The project containing this branch (API resource hierarchy).
    /// Format: projects/{project_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a PostgresProject in postgres to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1PostgresBranchSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a PostgresProject in postgres to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1PostgresBranchSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresBranchSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>If true, permanently delete the branch; if false, soft delete</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>If true, update the branch if it already exists instead of returning an error</summary>
    [JsonPropertyName("replaceExisting")]
    public bool? ReplaceExisting { get; set; }

    /// <summary>The spec contains the branch configuration</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresBranchSpecInitProviderSpec? Spec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecManagementPoliciesEnum>))]
public enum V1beta1PostgresBranchSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1PostgresBranchSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresBranchSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1PostgresBranchSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresBranchSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresBranchSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresBranchSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PostgresBranchSpec defines the desired state of PostgresBranch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchSpec
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
    public V1beta1PostgresBranchSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1PostgresBranchSpecForProvider ForProvider { get; set; }

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
    public V1beta1PostgresBranchSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1PostgresBranchSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PostgresBranchSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PostgresBranchSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>The spec contains the branch configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchStatusAtProviderSpec
{
    /// <summary>
    /// Absolute expiration timestamp. When set, the branch will expire at this time.
    /// Mutually exclusive with ttl and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>When set to true, protects the branch from deletion and reset. Associated compute endpoints and the project cannot be deleted while the branch is protected</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>
    /// Explicitly disable expiration. When set to true, the branch will not expire.
    /// If set to false, the request is invalid; provide either ttl or expire_time instead.
    /// Mutually exclusive with expire_time and ttl. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("noExpiry")]
    public bool? NoExpiry { get; set; }

    /// <summary>
    /// The name of the source branch from which this branch was created (data lineage for point-in-time recovery).
    /// If not specified, defaults to the project&apos;s default branch.
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("sourceBranch")]
    public string? SourceBranch { get; set; }

    /// <summary>The Log Sequence Number (LSN) on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchLsn")]
    public string? SourceBranchLsn { get; set; }

    /// <summary>The point in time on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchTime")]
    public string? SourceBranchTime { get; set; }

    /// <summary>
    /// Relative time-to-live duration. When set, the branch will expire at creation_time + ttl.
    /// Mutually exclusive with expire_time and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

/// <summary>The current status of a Branch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchStatusAtProviderStatus
{
    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("branchId")]
    public string? BranchId { get; set; }

    /// <summary>The branch&apos;s state, indicating if it is initializing, ready for use, or archived. Possible values are: ARCHIVED, DELETED, IMPORTING, INIT, READY, RESETTING</summary>
    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    /// <summary>Whether the branch is the project&apos;s default branch</summary>
    [JsonPropertyName("default")]
    public bool? Default { get; set; }

    /// <summary>
    /// A timestamp indicating when the branch was deleted.
    /// Empty if the branch is not deleted
    /// </summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>
    /// Absolute expiration timestamp. When set, the branch will expire at this time.
    /// Mutually exclusive with ttl and no_expiry. When updating, use spec.expiration in the update_mask
    /// </summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>When set to true, protects the branch from deletion and reset. Associated compute endpoints and the project cannot be deleted while the branch is protected</summary>
    [JsonPropertyName("isProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>The logical size of the branch</summary>
    [JsonPropertyName("logicalSizeBytes")]
    public double? LogicalSizeBytes { get; set; }

    /// <summary>The pending state of the branch, if a state transition is in progress. Possible values are: ARCHIVED, DELETED, IMPORTING, INIT, READY, RESETTING</summary>
    [JsonPropertyName("pendingState")]
    public string? PendingState { get; set; }

    /// <summary>
    /// A timestamp indicating when the branch is scheduled to be purged.
    /// Empty if the branch is not deleted, otherwise set to a timestamp in the future
    /// </summary>
    [JsonPropertyName("purgeTime")]
    public string? PurgeTime { get; set; }

    /// <summary>
    /// The name of the source branch from which this branch was created (data lineage for point-in-time recovery).
    /// If not specified, defaults to the project&apos;s default branch.
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("sourceBranch")]
    public string? SourceBranch { get; set; }

    /// <summary>The Log Sequence Number (LSN) on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchLsn")]
    public string? SourceBranchLsn { get; set; }

    /// <summary>The point in time on the source branch from which this branch was created</summary>
    [JsonPropertyName("sourceBranchTime")]
    public string? SourceBranchTime { get; set; }

    /// <summary>A timestamp indicating when the current_state began</summary>
    [JsonPropertyName("stateChangeTime")]
    public string? StateChangeTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchStatusAtProvider
{
    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("branchId")]
    public string? BranchId { get; set; }

    /// <summary>A timestamp indicating when the branch was created</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The project containing this branch (API resource hierarchy).
    /// Format: projects/{project_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresBranchStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>If true, permanently delete the branch; if false, soft delete</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>If true, update the branch if it already exists instead of returning an error</summary>
    [JsonPropertyName("replaceExisting")]
    public bool? ReplaceExisting { get; set; }

    /// <summary>The spec contains the branch configuration</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresBranchStatusAtProviderSpec? Spec { get; set; }

    /// <summary>The current status of a Branch</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresBranchStatusAtProviderStatus? Status { get; set; }

    /// <summary>System-generated unique ID for the branch</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>A timestamp indicating when the branch was last updated</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchStatusConditions
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

/// <summary>PostgresBranchStatus defines the observed state of PostgresBranch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresBranchStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PostgresBranchStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PostgresBranchStatusConditions>? Conditions { get; set; }

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

/// <summary>PostgresBranch is the Schema for the PostgresBranchs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresBranch : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PostgresBranchSpec>, IStatus<V1beta1PostgresBranchStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresBranch";
    public const string KubeGroup = "postgres.databricks.crossplane.io";
    public const string KubePluralName = "postgresbranches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresBranch";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PostgresBranchSpec defines the desired state of PostgresBranch</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PostgresBranchSpec Spec { get; set; }

    /// <summary>PostgresBranchStatus defines the observed state of PostgresBranch.</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresBranchStatus? Status { get; set; }
}