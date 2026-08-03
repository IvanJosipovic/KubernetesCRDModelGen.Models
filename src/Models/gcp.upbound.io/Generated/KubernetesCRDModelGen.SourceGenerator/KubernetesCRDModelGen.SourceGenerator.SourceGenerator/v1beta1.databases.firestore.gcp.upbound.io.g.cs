#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.gcp.upbound.io;
/// <summary>Database is the Schema for the Databases API. A Cloud Firestore Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Database>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatabaseList";
    public const string KubeGroup = "firestore.gcp.upbound.io";
    public const string KubePluralName = "databases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Database objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Database> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecDeletionPolicyEnum>))]
public enum V1beta1DatabaseSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelector
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
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The CMEK (Customer Managed Encryption Key) configuration for a Firestore
/// database. If not present, the database is secured by the default Google
/// encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProviderCmekConfig
{
    /// <summary>
    /// The resource ID of a Cloud KMS key. If set, the database created will
    /// be a Customer-managed Encryption Key (CMEK) database encrypted with
    /// this key. This feature is allowlist only in initial launch.
    /// Only keys in the same location as this database are allowed to be used
    /// for encryption. For Firestore&apos;s nam5 multi-region, this corresponds to Cloud KMS
    /// multi-region us. For Firestore&apos;s eur3 multi-region, this corresponds to
    /// Cloud KMS multi-region europe. See https://cloud.google.com/kms/docs/locations.
    /// This value should be the KMS key resource ID in the format of
    /// projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// How to retrieve this resource ID is listed at
    /// https://cloud.google.com/kms/docs/getting-resource-ids#getting_the_id_for_a_key_and_version.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1DatabaseSpecForProviderCmekConfigKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecForProvider
{
    /// <summary>
    /// The App Engine integration mode to use for this database.
    /// Possible values are: ENABLED, DISABLED.
    /// </summary>
    [JsonPropertyName("appEngineIntegrationMode")]
    public string? AppEngineIntegrationMode { get; set; }

    /// <summary>
    /// The CMEK (Customer Managed Encryption Key) configuration for a Firestore
    /// database. If not present, the database is secured by the default Google
    /// encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cmekConfig")]
    public V1beta1DatabaseSpecForProviderCmekConfig? CmekConfig { get; set; }

    /// <summary>
    /// The concurrency control mode to use for this database.
    /// Possible values are: OPTIMISTIC, PESSIMISTIC, OPTIMISTIC_WITH_ENTITY_GROUPS.
    /// </summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>
    /// The database edition. When set to &apos;ENTERPRISE&apos;, then type must be set to
    /// &apos;FIRESTORE_NATIVE&apos;.
    /// Possible values are: STANDARD, ENTERPRISE.
    /// </summary>
    [JsonPropertyName("databaseEdition")]
    public string? DatabaseEdition { get; set; }

    /// <summary>
    /// State of delete protection for the database.
    /// When delete protection is enabled, this database cannot be deleted.
    /// The default value is DELETE_PROTECTION_STATE_UNSPECIFIED, which is currently equivalent to DELETE_PROTECTION_DISABLED.
    /// Possible values are: DELETE_PROTECTION_STATE_UNSPECIFIED, DELETE_PROTECTION_ENABLED, DELETE_PROTECTION_DISABLED.
    /// </summary>
    [JsonPropertyName("deleteProtectionState")]
    public string? DeleteProtectionState { get; set; }

    /// <summary>
    /// Defaults to ABANDON.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The Firestore API data access mode to use for this database. Can only be
    /// specified for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: DATA_ACCESS_MODE_ENABLED, DATA_ACCESS_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("firestoreDataAccessMode")]
    public string? FirestoreDataAccessMode { get; set; }

    /// <summary>
    /// The location of the database. Available locations are listed at
    /// https://cloud.google.com/firestore/docs/locations.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>
    /// The MongoDB compatible API data access mode to use for this database. Can
    /// only be specified for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: DATA_ACCESS_MODE_ENABLED, DATA_ACCESS_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("mongodbCompatibleDataAccessMode")]
    public string? MongodbCompatibleDataAccessMode { get; set; }

    /// <summary>
    /// Whether to enable the PITR feature on this database.
    /// If POINT_IN_TIME_RECOVERY_ENABLED is selected, reads are supported on selected versions of the data from within the past 7 days.
    /// versionRetentionPeriod and earliestVersionTime can be used to determine the supported versions. These include reads against any timestamp within the past hour
    /// and reads against 1-minute snapshots beyond 1 hour and within 7 days.
    /// If POINT_IN_TIME_RECOVERY_DISABLED is selected, reads are supported on any version of the data from within the past 1 hour.
    /// Default value is POINT_IN_TIME_RECOVERY_DISABLED.
    /// Possible values are: POINT_IN_TIME_RECOVERY_ENABLED, POINT_IN_TIME_RECOVERY_DISABLED.
    /// </summary>
    [JsonPropertyName("pointInTimeRecoveryEnablement")]
    public string? PointInTimeRecoveryEnablement { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Realtime Updates mode to use for this database. Can only be specified
    /// for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: REALTIME_UPDATES_MODE_ENABLED, REALTIME_UPDATES_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("realtimeUpdatesMode")]
    public string? RealtimeUpdatesMode { get; set; }

    /// <summary>
    /// Input only. A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// The field is ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. To apply tags to an existing resource, see
    /// the google_tags_tag_value resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The type of the database.
    /// See https://cloud.google.com/datastore/docs/firestore-or-datastore
    /// for information about how to choose.
    /// Possible values are: FIRESTORE_NATIVE, DATASTORE_MODE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicyResolutionEnum>))]
public enum V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicyResolveEnum>))]
public enum V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicyResolutionEnum>))]
public enum V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicyResolveEnum>))]
public enum V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelector
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
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The CMEK (Customer Managed Encryption Key) configuration for a Firestore
/// database. If not present, the database is secured by the default Google
/// encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecInitProviderCmekConfig
{
    /// <summary>
    /// The resource ID of a Cloud KMS key. If set, the database created will
    /// be a Customer-managed Encryption Key (CMEK) database encrypted with
    /// this key. This feature is allowlist only in initial launch.
    /// Only keys in the same location as this database are allowed to be used
    /// for encryption. For Firestore&apos;s nam5 multi-region, this corresponds to Cloud KMS
    /// multi-region us. For Firestore&apos;s eur3 multi-region, this corresponds to
    /// Cloud KMS multi-region europe. See https://cloud.google.com/kms/docs/locations.
    /// This value should be the KMS key resource ID in the format of
    /// projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// How to retrieve this resource ID is listed at
    /// https://cloud.google.com/kms/docs/getting-resource-ids#getting_the_id_for_a_key_and_version.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameRef")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameRef? KmsKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKeyName.</summary>
    [JsonPropertyName("kmsKeyNameSelector")]
    public V1beta1DatabaseSpecInitProviderCmekConfigKmsKeyNameSelector? KmsKeyNameSelector { get; set; }
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
public partial class V1beta1DatabaseSpecInitProvider
{
    /// <summary>
    /// The App Engine integration mode to use for this database.
    /// Possible values are: ENABLED, DISABLED.
    /// </summary>
    [JsonPropertyName("appEngineIntegrationMode")]
    public string? AppEngineIntegrationMode { get; set; }

    /// <summary>
    /// The CMEK (Customer Managed Encryption Key) configuration for a Firestore
    /// database. If not present, the database is secured by the default Google
    /// encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cmekConfig")]
    public V1beta1DatabaseSpecInitProviderCmekConfig? CmekConfig { get; set; }

    /// <summary>
    /// The concurrency control mode to use for this database.
    /// Possible values are: OPTIMISTIC, PESSIMISTIC, OPTIMISTIC_WITH_ENTITY_GROUPS.
    /// </summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>
    /// The database edition. When set to &apos;ENTERPRISE&apos;, then type must be set to
    /// &apos;FIRESTORE_NATIVE&apos;.
    /// Possible values are: STANDARD, ENTERPRISE.
    /// </summary>
    [JsonPropertyName("databaseEdition")]
    public string? DatabaseEdition { get; set; }

    /// <summary>
    /// State of delete protection for the database.
    /// When delete protection is enabled, this database cannot be deleted.
    /// The default value is DELETE_PROTECTION_STATE_UNSPECIFIED, which is currently equivalent to DELETE_PROTECTION_DISABLED.
    /// Possible values are: DELETE_PROTECTION_STATE_UNSPECIFIED, DELETE_PROTECTION_ENABLED, DELETE_PROTECTION_DISABLED.
    /// </summary>
    [JsonPropertyName("deleteProtectionState")]
    public string? DeleteProtectionState { get; set; }

    /// <summary>
    /// Defaults to ABANDON.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The Firestore API data access mode to use for this database. Can only be
    /// specified for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: DATA_ACCESS_MODE_ENABLED, DATA_ACCESS_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("firestoreDataAccessMode")]
    public string? FirestoreDataAccessMode { get; set; }

    /// <summary>
    /// The location of the database. Available locations are listed at
    /// https://cloud.google.com/firestore/docs/locations.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>
    /// The MongoDB compatible API data access mode to use for this database. Can
    /// only be specified for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: DATA_ACCESS_MODE_ENABLED, DATA_ACCESS_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("mongodbCompatibleDataAccessMode")]
    public string? MongodbCompatibleDataAccessMode { get; set; }

    /// <summary>
    /// Whether to enable the PITR feature on this database.
    /// If POINT_IN_TIME_RECOVERY_ENABLED is selected, reads are supported on selected versions of the data from within the past 7 days.
    /// versionRetentionPeriod and earliestVersionTime can be used to determine the supported versions. These include reads against any timestamp within the past hour
    /// and reads against 1-minute snapshots beyond 1 hour and within 7 days.
    /// If POINT_IN_TIME_RECOVERY_DISABLED is selected, reads are supported on any version of the data from within the past 1 hour.
    /// Default value is POINT_IN_TIME_RECOVERY_DISABLED.
    /// Possible values are: POINT_IN_TIME_RECOVERY_ENABLED, POINT_IN_TIME_RECOVERY_DISABLED.
    /// </summary>
    [JsonPropertyName("pointInTimeRecoveryEnablement")]
    public string? PointInTimeRecoveryEnablement { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Realtime Updates mode to use for this database. Can only be specified
    /// for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: REALTIME_UPDATES_MODE_ENABLED, REALTIME_UPDATES_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("realtimeUpdatesMode")]
    public string? RealtimeUpdatesMode { get; set; }

    /// <summary>
    /// Input only. A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// The field is ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. To apply tags to an existing resource, see
    /// the google_tags_tag_value resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The type of the database.
    /// See https://cloud.google.com/datastore/docs/firestore-or-datastore
    /// for information about how to choose.
    /// Possible values are: FIRESTORE_NATIVE, DATASTORE_MODE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecManagementPoliciesEnum>))]
public enum V1beta1DatabaseSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1DatabaseSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1DatabaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DatabaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DatabaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DatabaseSpec defines the desired state of Database</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseSpec
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
    public V1beta1DatabaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1DatabaseSpecForProvider ForProvider { get; set; }

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
    public V1beta1DatabaseSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1DatabaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The CMEK (Customer Managed Encryption Key) configuration for a Firestore
/// database. If not present, the database is secured by the default Google
/// encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatusAtProviderCmekConfig
{
    /// <summary>
    /// (Output)
    /// Currently in-use KMS key versions (https://cloud.google.com/kms/docs/resource-hierarchy#key_versions).
    /// During key rotation (https://cloud.google.com/kms/docs/key-rotation), there can be
    /// multiple in-use key versions.
    /// The expected format is
    /// projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{key_version}.
    /// </summary>
    [JsonPropertyName("activeKeyVersion")]
    public IList<string>? ActiveKeyVersion { get; set; }

    /// <summary>
    /// The resource ID of a Cloud KMS key. If set, the database created will
    /// be a Customer-managed Encryption Key (CMEK) database encrypted with
    /// this key. This feature is allowlist only in initial launch.
    /// Only keys in the same location as this database are allowed to be used
    /// for encryption. For Firestore&apos;s nam5 multi-region, this corresponds to Cloud KMS
    /// multi-region us. For Firestore&apos;s eur3 multi-region, this corresponds to
    /// Cloud KMS multi-region europe. See https://cloud.google.com/kms/docs/locations.
    /// This value should be the KMS key resource ID in the format of
    /// projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// How to retrieve this resource ID is listed at
    /// https://cloud.google.com/kms/docs/getting-resource-ids#getting_the_id_for_a_key_and_version.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatusAtProvider
{
    /// <summary>
    /// The App Engine integration mode to use for this database.
    /// Possible values are: ENABLED, DISABLED.
    /// </summary>
    [JsonPropertyName("appEngineIntegrationMode")]
    public string? AppEngineIntegrationMode { get; set; }

    /// <summary>
    /// The CMEK (Customer Managed Encryption Key) configuration for a Firestore
    /// database. If not present, the database is secured by the default Google
    /// encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cmekConfig")]
    public V1beta1DatabaseStatusAtProviderCmekConfig? CmekConfig { get; set; }

    /// <summary>
    /// The concurrency control mode to use for this database.
    /// Possible values are: OPTIMISTIC, PESSIMISTIC, OPTIMISTIC_WITH_ENTITY_GROUPS.
    /// </summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>Output only. The timestamp at which this database was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// The database edition. When set to &apos;ENTERPRISE&apos;, then type must be set to
    /// &apos;FIRESTORE_NATIVE&apos;.
    /// Possible values are: STANDARD, ENTERPRISE.
    /// </summary>
    [JsonPropertyName("databaseEdition")]
    public string? DatabaseEdition { get; set; }

    /// <summary>
    /// State of delete protection for the database.
    /// When delete protection is enabled, this database cannot be deleted.
    /// The default value is DELETE_PROTECTION_STATE_UNSPECIFIED, which is currently equivalent to DELETE_PROTECTION_DISABLED.
    /// Possible values are: DELETE_PROTECTION_STATE_UNSPECIFIED, DELETE_PROTECTION_ENABLED, DELETE_PROTECTION_DISABLED.
    /// </summary>
    [JsonPropertyName("deleteProtectionState")]
    public string? DeleteProtectionState { get; set; }

    /// <summary>
    /// Defaults to ABANDON.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// Output only. The earliest timestamp at which older versions of the data can be read from the database. See versionRetentionPeriod above; this field is populated with now - versionRetentionPeriod.
    /// This value is continuously updated, and becomes stale the moment it is queried. If you are using this value to recover data, make sure to account for the time from the moment when the value is queried to the moment when you initiate the recovery.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("earliestVersionTime")]
    public string? EarliestVersionTime { get; set; }

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an
    /// up-to-date value before proceeding.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// The Firestore API data access mode to use for this database. Can only be
    /// specified for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: DATA_ACCESS_MODE_ENABLED, DATA_ACCESS_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("firestoreDataAccessMode")]
    public string? FirestoreDataAccessMode { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/databases/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Output only. The keyPrefix for this database.
    /// This keyPrefix is used, in combination with the project id (&quot;~&quot;) to construct the application id
    /// that is returned from the Cloud Datastore APIs in Google App Engine first generation runtimes.
    /// This value may be empty in which case the appid to use for URL-encoded keys is the project_id (eg: foo instead of v~foo).
    /// </summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }

    /// <summary>
    /// The location of the database. Available locations are listed at
    /// https://cloud.google.com/firestore/docs/locations.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>
    /// The MongoDB compatible API data access mode to use for this database. Can
    /// only be specified for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: DATA_ACCESS_MODE_ENABLED, DATA_ACCESS_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("mongodbCompatibleDataAccessMode")]
    public string? MongodbCompatibleDataAccessMode { get; set; }

    /// <summary>
    /// Whether to enable the PITR feature on this database.
    /// If POINT_IN_TIME_RECOVERY_ENABLED is selected, reads are supported on selected versions of the data from within the past 7 days.
    /// versionRetentionPeriod and earliestVersionTime can be used to determine the supported versions. These include reads against any timestamp within the past hour
    /// and reads against 1-minute snapshots beyond 1 hour and within 7 days.
    /// If POINT_IN_TIME_RECOVERY_DISABLED is selected, reads are supported on any version of the data from within the past 1 hour.
    /// Default value is POINT_IN_TIME_RECOVERY_DISABLED.
    /// Possible values are: POINT_IN_TIME_RECOVERY_ENABLED, POINT_IN_TIME_RECOVERY_DISABLED.
    /// </summary>
    [JsonPropertyName("pointInTimeRecoveryEnablement")]
    public string? PointInTimeRecoveryEnablement { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Realtime Updates mode to use for this database. Can only be specified
    /// for &apos;ENTERPRISE&apos; edition databases.
    /// Possible values are: REALTIME_UPDATES_MODE_ENABLED, REALTIME_UPDATES_MODE_DISABLED.
    /// </summary>
    [JsonPropertyName("realtimeUpdatesMode")]
    public string? RealtimeUpdatesMode { get; set; }

    /// <summary>
    /// Input only. A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// The field is ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. To apply tags to an existing resource, see
    /// the google_tags_tag_value resource.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The type of the database.
    /// See https://cloud.google.com/datastore/docs/firestore-or-datastore
    /// for information about how to choose.
    /// Possible values are: FIRESTORE_NATIVE, DATASTORE_MODE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Output only. The system-generated UUID4 for this Database.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The timestamp at which this database was most recently updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Output only. The period during which past versions of data are retained in the database.
    /// Any read or query can specify a readTime within this window, and will read the state of the database at that time.
    /// If the PITR feature is enabled, the retention period is 7 days. Otherwise, the retention period is 1 hour.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatabaseStatusConditions>? Conditions { get; set; }

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

/// <summary>Database is the Schema for the Databases API. A Cloud Firestore Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Database : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatabaseSpec>, IStatus<V1beta1DatabaseStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Database";
    public const string KubeGroup = "firestore.gcp.upbound.io";
    public const string KubePluralName = "databases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Database";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatabaseSpec defines the desired state of Database</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DatabaseSpec Spec { get; set; }

    /// <summary>DatabaseStatus defines the observed state of Database.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatabaseStatus? Status { get; set; }
}