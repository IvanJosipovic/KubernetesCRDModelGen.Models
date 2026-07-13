#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.upbound.io;
/// <summary>ManagementPolicy is the Schema for the ManagementPolicys API. Manages an Azure Storage Account Management Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ManagementPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagementPolicyList";
    public const string KubeGroup = "storage.azure.upbound.io";
    public const string KubePluralName = "managementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagementPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ManagementPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ManagementPolicy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecDeletionPolicyEnum>))]
public enum V1beta2ManagementPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A base_blob block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRuleActionsBaseBlob
{
    /// <summary>Whether a blob should automatically be tiered from cool back to hot if it&apos;s accessed again after being tiered to cool. Defaults to false.</summary>
    [JsonPropertyName("autoTierToHotFromCoolEnabled")]
    public bool? AutoTierToHotFromCoolEnabled { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceModificationGreaterThan")]
    public double? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceCreationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceModificationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceModificationGreaterThan")]
    public double? TierToColdAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceCreationGreaterThan")]
    public double? TierToCoolAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceModificationGreaterThan")]
    public double? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }
}

/// <summary>A snapshot block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRuleActionsSnapshot
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>A version block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRuleActionsVersion
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob version. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreation")]
    public double? DeleteAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>An actions block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRuleActions
{
    /// <summary>A base_blob block as documented below.</summary>
    [JsonPropertyName("baseBlob")]
    public V1beta2ManagementPolicySpecForProviderRuleActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>A snapshot block as documented below.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta2ManagementPolicySpecForProviderRuleActionsSnapshot? Snapshot { get; set; }

    /// <summary>A version block as documented below.</summary>
    [JsonPropertyName("version")]
    public V1beta2ManagementPolicySpecForProviderRuleActionsVersion? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRuleFiltersMatchBlobIndexTag
{
    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The comparison operator which is used for object comparison and filtering. Possible value is ==. Defaults to ==.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The filter tag value used for tag based filtering for blob objects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A filters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRuleFilters
{
    /// <summary>An array of predefined values. Valid options are blockBlob and appendBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A match_blob_index_tag block as defined below. The block defines the blob index tag based filtering for blob objects.</summary>
    [JsonPropertyName("matchBlobIndexTag")]
    public IList<V1beta2ManagementPolicySpecForProviderRuleFiltersMatchBlobIndexTag>? MatchBlobIndexTag { get; set; }

    /// <summary>An array of strings for prefixes to be matched.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderRule
{
    /// <summary>An actions block as documented below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2ManagementPolicySpecForProviderRuleActions? Actions { get; set; }

    /// <summary>Boolean to specify whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A filters block as documented below.</summary>
    [JsonPropertyName("filters")]
    public V1beta2ManagementPolicySpecForProviderRuleFilters? Filters { get; set; }

    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProviderStorageAccountIdSelector
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
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecForProvider
{
    /// <summary>A rule block as documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2ManagementPolicySpecForProviderRule>? Rule { get; set; }

    /// <summary>Specifies the id of the storage account to apply the management policy to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta2ManagementPolicySpecForProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>A base_blob block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRuleActionsBaseBlob
{
    /// <summary>Whether a blob should automatically be tiered from cool back to hot if it&apos;s accessed again after being tiered to cool. Defaults to false.</summary>
    [JsonPropertyName("autoTierToHotFromCoolEnabled")]
    public bool? AutoTierToHotFromCoolEnabled { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceModificationGreaterThan")]
    public double? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceCreationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceModificationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceModificationGreaterThan")]
    public double? TierToColdAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceCreationGreaterThan")]
    public double? TierToCoolAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceModificationGreaterThan")]
    public double? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }
}

/// <summary>A snapshot block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRuleActionsSnapshot
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>A version block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRuleActionsVersion
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob version. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreation")]
    public double? DeleteAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>An actions block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRuleActions
{
    /// <summary>A base_blob block as documented below.</summary>
    [JsonPropertyName("baseBlob")]
    public V1beta2ManagementPolicySpecInitProviderRuleActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>A snapshot block as documented below.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta2ManagementPolicySpecInitProviderRuleActionsSnapshot? Snapshot { get; set; }

    /// <summary>A version block as documented below.</summary>
    [JsonPropertyName("version")]
    public V1beta2ManagementPolicySpecInitProviderRuleActionsVersion? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRuleFiltersMatchBlobIndexTag
{
    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The comparison operator which is used for object comparison and filtering. Possible value is ==. Defaults to ==.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The filter tag value used for tag based filtering for blob objects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A filters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRuleFilters
{
    /// <summary>An array of predefined values. Valid options are blockBlob and appendBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A match_blob_index_tag block as defined below. The block defines the blob index tag based filtering for blob objects.</summary>
    [JsonPropertyName("matchBlobIndexTag")]
    public IList<V1beta2ManagementPolicySpecInitProviderRuleFiltersMatchBlobIndexTag>? MatchBlobIndexTag { get; set; }

    /// <summary>An array of strings for prefixes to be matched.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderRule
{
    /// <summary>An actions block as documented below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2ManagementPolicySpecInitProviderRuleActions? Actions { get; set; }

    /// <summary>Boolean to specify whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A filters block as documented below.</summary>
    [JsonPropertyName("filters")]
    public V1beta2ManagementPolicySpecInitProviderRuleFilters? Filters { get; set; }

    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicyResolveEnum>))]
public enum V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelector
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
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2ManagementPolicySpecInitProvider
{
    /// <summary>A rule block as documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2ManagementPolicySpecInitProviderRule>? Rule { get; set; }

    /// <summary>Specifies the id of the storage account to apply the management policy to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdRef")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdRef? StorageAccountIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountId.</summary>
    [JsonPropertyName("storageAccountIdSelector")]
    public V1beta2ManagementPolicySpecInitProviderStorageAccountIdSelector? StorageAccountIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecManagementPoliciesEnum>))]
public enum V1beta2ManagementPolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ManagementPolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ManagementPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ManagementPolicySpec defines the desired state of ManagementPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicySpec
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
    public V1beta2ManagementPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ManagementPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2ManagementPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ManagementPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ManagementPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ManagementPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A base_blob block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRuleActionsBaseBlob
{
    /// <summary>Whether a blob should automatically be tiered from cool back to hot if it&apos;s accessed again after being tiered to cool. Defaults to false.</summary>
    [JsonPropertyName("autoTierToHotFromCoolEnabled")]
    public bool? AutoTierToHotFromCoolEnabled { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? DeleteAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to delete the blob. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceModificationGreaterThan")]
    public double? DeleteAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceCreationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to archive storage. Supports blob currently at Hot or Cool tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceModificationGreaterThan")]
    public double? TierToArchiveAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToColdAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceModificationGreaterThan")]
    public double? TierToColdAfterDaysSinceModificationGreaterThan { get; set; }

    /// <summary>The age in days after creation to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceCreationGreaterThan")]
    public double? TierToCoolAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last access time to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceLastAccessTimeGreaterThan")]
    public double? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan { get; set; }

    /// <summary>The age in days after last modification to tier blobs to cool storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToCoolAfterDaysSinceModificationGreaterThan")]
    public double? TierToCoolAfterDaysSinceModificationGreaterThan { get; set; }
}

/// <summary>A snapshot block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRuleActionsSnapshot
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob snapshot. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreationGreaterThan")]
    public double? DeleteAfterDaysSinceCreationGreaterThan { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>A version block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRuleActionsVersion
{
    /// <summary>The age in days after creation to tier blob version to archive storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToArchiveAfterDaysSinceCreation")]
    public double? ChangeTierToArchiveAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days creation create to tier blob version to cool storage. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("changeTierToCoolAfterDaysSinceCreation")]
    public double? ChangeTierToCoolAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after creation to delete the blob version. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("deleteAfterDaysSinceCreation")]
    public double? DeleteAfterDaysSinceCreation { get; set; }

    /// <summary>The age in days after last tier change to the blobs to skip to be archived. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToArchiveAfterDaysSinceLastTierChangeGreaterThan")]
    public double? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan { get; set; }

    /// <summary>The age in days after creation to cold storage. Supports blob currently at Hot tier. Must be between 0 and 99999. Defaults to -1.</summary>
    [JsonPropertyName("tierToColdAfterDaysSinceCreationGreaterThan")]
    public double? TierToColdAfterDaysSinceCreationGreaterThan { get; set; }
}

/// <summary>An actions block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRuleActions
{
    /// <summary>A base_blob block as documented below.</summary>
    [JsonPropertyName("baseBlob")]
    public V1beta2ManagementPolicyStatusAtProviderRuleActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>A snapshot block as documented below.</summary>
    [JsonPropertyName("snapshot")]
    public V1beta2ManagementPolicyStatusAtProviderRuleActionsSnapshot? Snapshot { get; set; }

    /// <summary>A version block as documented below.</summary>
    [JsonPropertyName("version")]
    public V1beta2ManagementPolicyStatusAtProviderRuleActionsVersion? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRuleFiltersMatchBlobIndexTag
{
    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The comparison operator which is used for object comparison and filtering. Possible value is ==. Defaults to ==.</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The filter tag value used for tag based filtering for blob objects.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A filters block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRuleFilters
{
    /// <summary>An array of predefined values. Valid options are blockBlob and appendBlob.</summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>A match_blob_index_tag block as defined below. The block defines the blob index tag based filtering for blob objects.</summary>
    [JsonPropertyName("matchBlobIndexTag")]
    public IList<V1beta2ManagementPolicyStatusAtProviderRuleFiltersMatchBlobIndexTag>? MatchBlobIndexTag { get; set; }

    /// <summary>An array of strings for prefixes to be matched.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProviderRule
{
    /// <summary>An actions block as documented below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2ManagementPolicyStatusAtProviderRuleActions? Actions { get; set; }

    /// <summary>Boolean to specify whether the rule is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A filters block as documented below.</summary>
    [JsonPropertyName("filters")]
    public V1beta2ManagementPolicyStatusAtProviderRuleFilters? Filters { get; set; }

    /// <summary>The name of the rule. Rule name is case-sensitive. It must be unique within a policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusAtProvider
{
    /// <summary>The ID of the Storage Account Management Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A rule block as documented below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2ManagementPolicyStatusAtProviderRule>? Rule { get; set; }

    /// <summary>Specifies the id of the storage account to apply the management policy to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatusConditions
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

/// <summary>ManagementPolicyStatus defines the observed state of ManagementPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ManagementPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ManagementPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagementPolicy is the Schema for the ManagementPolicys API. Manages an Azure Storage Account Management Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ManagementPolicySpec>, IStatus<V1beta2ManagementPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagementPolicy";
    public const string KubeGroup = "storage.azure.upbound.io";
    public const string KubePluralName = "managementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagementPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagementPolicySpec defines the desired state of ManagementPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ManagementPolicySpec Spec { get; set; }

    /// <summary>ManagementPolicyStatus defines the observed state of ManagementPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2ManagementPolicyStatus? Status { get; set; }
}