#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.cnrm.cloud.google.com;
/// <summary>SpannerBackupSchedule is the Schema for the SpannerBackupSchedule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpannerBackupScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpannerBackupSchedule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpannerBackupScheduleList";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerbackupschedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpannerBackupScheduleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SpannerBackupSchedule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SpannerBackupSchedule> Items { get; set; }
}

/// <summary>Optional. The Cloud KMS key that will be used to protect the backup. This field should be set only when [encryption_type][google.spanner.admin.database.v1.CreateBackupEncryptionConfig.encryption_type] is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form `projects/&lt;project&gt;/locations/&lt;location&gt;/keyRings/&lt;key_ring&gt;/cryptoKeys/&lt;kms_key_name&gt;`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRefs
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The encryption configuration that will be used to encrypt the backup. If this field is not specified, the backup will use the same encryption configuration as the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecEncryptionConfig
{
    /// <summary>Required. The encryption type of the backup.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Optional. The Cloud KMS key that will be used to protect the backup. This field should be set only when [encryption_type][google.spanner.admin.database.v1.CreateBackupEncryptionConfig.encryption_type] is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form `projects/&lt;project&gt;/locations/&lt;location&gt;/keyRings/&lt;key_ring&gt;/cryptoKeys/&lt;kms_key_name&gt;`.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// Optional. Specifies the KMS configuration for the one or more keys used to
    ///  protect the backup. Values are of the form
    ///  `projects/&lt;project&gt;/locations/&lt;location&gt;/keyRings/&lt;key_ring&gt;/cryptoKeys/&lt;kms_key_name&gt;`.
    /// 
    ///  The keys referenced by kms_key_names must fully cover all
    ///  regions of the backup&apos;s instance configuration. Some examples:
    ///  * For single region instance configs, specify a single regional
    ///  location KMS key.
    ///  * For multi-regional instance configs of type GOOGLE_MANAGED,
    ///  either specify a multi-regional location KMS key or multiple regional
    ///  location KMS keys that cover all regions in the instance config.
    ///  * For an instance config of type USER_MANAGED, please specify only
    ///  regional location KMS keys to cover each region in the instance config.
    ///  Multi-regional location KMS keys are not supported for USER_MANAGED
    ///  instance configs.
    /// </summary>
    [JsonPropertyName("kmsKeyRefs")]
    public IList<V1beta1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRefs>? KmsKeyRefs { get; set; }
}

/// <summary>The schedule creates only full backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecFullBackupSpec
{
}

/// <summary>The schedule creates incremental backup chains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecIncrementalBackupSpec
{
}

/// <summary>Required. The Spanner Database that this backup applies to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecSpannerDatabaseRef
{
    /// <summary>A reference to an externally managed SpannerDatabase resource. Should be in the format &quot;projects/{{projectID}}/instances/{{instanceID}}/databases/{{databaseID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SpannerDatabase resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SpannerDatabase resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Cron style schedule specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecSpecCronSpec
{
    /// <summary>
    /// Required. Textual representation of the crontab. User can customize the
    ///  backup frequency and the backup version time using the cron
    ///  expression. The version time must be in UTC timzeone.
    /// 
    ///  The backup will contain an externally consistent copy of the
    ///  database at the version time. Allowed frequencies are 12 hour, 1 day,
    ///  1 week and 1 month. Examples of valid cron specifications:
    ///    * `0 2/12 * * * ` : every 12 hours at (2, 14) hours past midnight in UTC.
    ///    * `0 2,14 * * * ` : every 12 hours at (2,14) hours past midnight in UTC.
    ///    * `0 2 * * * `    : once a day at 2 past midnight in UTC.
    ///    * `0 2 * * 0 `    : once a week every Sunday at 2 past midnight in UTC.
    ///    * `0 2 8 * * `    : once a month on 8th day at 2 past midnight in UTC.
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Optional. The schedule specification based on which the backup creations are triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpecSpec
{
    /// <summary>Cron style schedule specification.</summary>
    [JsonPropertyName("cronSpec")]
    public V1beta1SpannerBackupScheduleSpecSpecCronSpec? CronSpec { get; set; }
}

/// <summary>SpannerBackupScheduleSpec defines the desired state of SpannerBackupSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleSpec
{
    /// <summary>Optional. The encryption configuration that will be used to encrypt the backup. If this field is not specified, the backup will use the same encryption configuration as the database.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1SpannerBackupScheduleSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The schedule creates only full backups.</summary>
    [JsonPropertyName("fullBackupSpec")]
    public V1beta1SpannerBackupScheduleSpecFullBackupSpec? FullBackupSpec { get; set; }

    /// <summary>The schedule creates incremental backup chains.</summary>
    [JsonPropertyName("incrementalBackupSpec")]
    public V1beta1SpannerBackupScheduleSpecIncrementalBackupSpec? IncrementalBackupSpec { get; set; }

    /// <summary>The SpannerBackupSchedule name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The retention duration of a backup that must be at least 6 hours and at most 366 days. The backup is eligible to be automatically deleted once the retention period has elapsed.</summary>
    [JsonPropertyName("retentionDuration")]
    public string? RetentionDuration { get; set; }

    /// <summary>Required. The Spanner Database that this backup applies to.</summary>
    [JsonPropertyName("spannerDatabaseRef")]
    public V1beta1SpannerBackupScheduleSpecSpannerDatabaseRef? SpannerDatabaseRef { get; set; }

    /// <summary>Optional. The schedule specification based on which the backup creations are triggered.</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpannerBackupScheduleSpecSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Cron style schedule specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleStatusObservedStateCronSpec
{
    /// <summary>Output only. Schedule backups will contain an externally consistent copy of the database at the version time specified in `schedule_spec.cron_spec`. However, Spanner may not initiate the creation of the scheduled backups at that version time. Spanner will initiate the creation of scheduled backups within the time window bounded by the version_time specified in `schedule_spec.cron_spec` and version_time + `creation_window`.</summary>
    [JsonPropertyName("creationWindow")]
    public string? CreationWindow { get; set; }

    /// <summary>Output only. The time zone of the times in `CrontabSpec.text`. Currently only UTC is supported.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleStatusObservedState
{
    /// <summary>Cron style schedule specification.</summary>
    [JsonPropertyName("cronSpec")]
    public V1beta1SpannerBackupScheduleStatusObservedStateCronSpec? CronSpec { get; set; }

    /// <summary>Output only. The timestamp at which the schedule was last updated. If the schedule has never been updated, this field contains the timestamp when the schedule was first created.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>SpannerBackupScheduleStatus defines the config connector machine state of SpannerBackupSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpannerBackupScheduleStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpannerBackupScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SpannerBackupSchedule resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1SpannerBackupScheduleStatusObservedState? ObservedState { get; set; }
}

/// <summary>SpannerBackupSchedule is the Schema for the SpannerBackupSchedule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpannerBackupSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpannerBackupScheduleSpec>, IStatus<V1beta1SpannerBackupScheduleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpannerBackupSchedule";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerbackupschedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpannerBackupSchedule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpannerBackupScheduleSpec defines the desired state of SpannerBackupSchedule</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SpannerBackupScheduleSpec Spec { get; set; }

    /// <summary>SpannerBackupScheduleStatus defines the config connector machine state of SpannerBackupSchedule</summary>
    [JsonPropertyName("status")]
    public V1beta1SpannerBackupScheduleStatus? Status { get; set; }
}