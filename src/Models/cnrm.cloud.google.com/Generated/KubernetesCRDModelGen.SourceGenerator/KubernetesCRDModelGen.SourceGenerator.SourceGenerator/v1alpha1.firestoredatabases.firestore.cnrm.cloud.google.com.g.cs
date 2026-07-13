#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.cnrm.cloud.google.com;
/// <summary>FirestoreDatabase is the Schema for the FirestoreDatabase API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirestoreDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FirestoreDatabase>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirestoreDatabaseList";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestoredatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FirestoreDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FirestoreDatabase> Items { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreDatabaseSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>FirestoreDatabaseSpec defines the desired state of FirestoreDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreDatabaseSpec
{
    /// <summary>The concurrency control mode to use for this database. See https://cloud.google.com/firestore/docs/reference/rest/v1/projects.databases#concurrencymode for more info.</summary>
    [JsonPropertyName("concurrencyMode")]
    public string? ConcurrencyMode { get; set; }

    /// <summary>State of delete protection for the database.</summary>
    [JsonPropertyName("deleteProtectionState")]
    public string? DeleteProtectionState { get; set; }

    /// <summary>The location of the database. Available locations are listed at https://cloud.google.com/firestore/docs/locations.</summary>
    [JsonPropertyName("locationID")]
    public string? LocationID { get; set; }

    /// <summary>Whether to enable the PITR feature on this database. See https://cloud.google.com/firestore/docs/reference/rest/v1/projects.databases#pointintimerecoveryenablement for more info.</summary>
    [JsonPropertyName("pointInTimeRecoveryEnablement")]
    public string? PointInTimeRecoveryEnablement { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1FirestoreDatabaseSpecProjectRef ProjectRef { get; set; }

    /// <summary>The FirestoreDatabase name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreDatabaseStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreDatabaseStatusObservedState
{
    /// <summary>Output only. The timestamp at which this database was created. Databases created before 2016 do not populate create_time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Output only. The earliest timestamp at which older versions of the data can
    ///  be read from the database. See [version_retention_period] above; this field
    ///  is populated with `now - version_retention_period`.
    /// 
    ///  This value is continuously updated, and becomes stale the moment it is
    ///  queried. If you are using this value to recover data, make sure to account
    ///  for the time from the moment when the value is queried to the moment when
    ///  you initiate the recovery.
    /// </summary>
    [JsonPropertyName("earliestVersionTime")]
    public string? EarliestVersionTime { get; set; }

    /// <summary>This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Output only. The key_prefix for this database. This key_prefix is used, in
    ///  combination with the project id (&quot; &lt;key prefix&gt;~&lt;project id&gt; &quot;) to construct
    ///  the application id that is returned from the Cloud Datastore APIs in Google
    ///  App Engine first generation runtimes.
    /// 
    ///  This value may be empty in which case the appid to use for URL-encoded keys
    ///  is the project_id (eg: foo instead of v~foo).
    /// </summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }

    /// <summary>Output only. The system-generated UUID4 for this Database.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The timestamp at which this database was most recently updated. Note this only includes updates to the database resource and not data contained by the database.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Output only. The period during which past versions of data are retained in
    ///  the database.
    /// 
    ///  Any [read][google.firestore.v1.GetDocumentRequest.read_time]
    ///  or [query][google.firestore.v1.ListDocumentsRequest.read_time] can specify
    ///  a `read_time` within this window, and will read the state of the database
    ///  at that time.
    /// 
    ///  If the PITR feature is enabled, the retention period is 7 days. Otherwise,
    ///  the retention period is 1 hour.
    /// </summary>
    [JsonPropertyName("versionRetentionPeriod")]
    public string? VersionRetentionPeriod { get; set; }
}

/// <summary>FirestoreDatabaseStatus defines the config connector machine state of FirestoreDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreDatabaseStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirestoreDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the FirestoreDatabase resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1FirestoreDatabaseStatusObservedState? ObservedState { get; set; }
}

/// <summary>FirestoreDatabase is the Schema for the FirestoreDatabase API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirestoreDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirestoreDatabaseSpec?>, IStatus<V1alpha1FirestoreDatabaseStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirestoreDatabase";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestoredatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirestoreDatabaseSpec defines the desired state of FirestoreDatabase</summary>
    [JsonPropertyName("spec")]
    public V1alpha1FirestoreDatabaseSpec? Spec { get; set; }

    /// <summary>FirestoreDatabaseStatus defines the config connector machine state of FirestoreDatabase</summary>
    [JsonPropertyName("status")]
    public V1alpha1FirestoreDatabaseStatus? Status { get; set; }
}