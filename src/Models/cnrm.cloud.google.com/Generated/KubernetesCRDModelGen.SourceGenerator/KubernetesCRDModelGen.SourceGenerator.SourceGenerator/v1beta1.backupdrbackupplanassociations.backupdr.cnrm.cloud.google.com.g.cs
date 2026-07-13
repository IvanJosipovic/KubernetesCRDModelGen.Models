#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backupdr.cnrm.cloud.google.com;
/// <summary>BackupDRBackupPlanAssociation is the Schema for the BackupDRBackupPlanAssociation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupDRBackupPlanAssociationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BackupDRBackupPlanAssociation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupDRBackupPlanAssociationList";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplanassociations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "backupdr.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupDRBackupPlanAssociationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BackupDRBackupPlanAssociation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BackupDRBackupPlanAssociation> Items { get; set; }
}

/// <summary>Required. The backup plan which needs to be applied on workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationSpecBackupPlanRef
{
    /// <summary>A reference to an externally managed BackupDRBackupPlan resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/backupplans/{{backupplanID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BackupDRBackupPlan resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BackupDRBackupPlan resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationSpecProjectRef
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

/// <summary>InstanceRef defines the resource reference to ComputeInstance, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationSpecResourceComputeInstanceRef
{
    /// <summary>A reference to an externally managed ComputeInstance resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Immutable. Resource name of workload on which backupplan is applied</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationSpecResource
{
    /// <summary>InstanceRef defines the resource reference to ComputeInstance, which &quot;External&quot; field holds the GCP identifier for the KRM object.</summary>
    [JsonPropertyName("computeInstanceRef")]
    public V1beta1BackupDRBackupPlanAssociationSpecResourceComputeInstanceRef? ComputeInstanceRef { get; set; }
}

/// <summary>BackupDRBackupPlanAssociationSpec defines the desired state of BackupDRBackupPlanAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationSpec
{
    /// <summary>Required. The backup plan which needs to be applied on workload.</summary>
    [JsonPropertyName("backupPlanRef")]
    public required V1beta1BackupDRBackupPlanAssociationSpecBackupPlanRef BackupPlanRef { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1BackupDRBackupPlanAssociationSpecProjectRef ProjectRef { get; set; }

    /// <summary>Required. Immutable. Resource name of workload on which backupplan is applied</summary>
    [JsonPropertyName("resource")]
    public required V1beta1BackupDRBackupPlanAssociationSpecResource Resource { get; set; }

    /// <summary>The BackupDRBackupPlanAssociation name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Immutable. Resource type of workload on which backupplan is applied</summary>
    [JsonPropertyName("resourceType")]
    public required string ResourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupErrorDetails
{
    /// <summary>
    /// A URL/resource name that uniquely identifies the type of the serialized
    ///  protocol buffer message. This string must contain at least
    ///  one &quot;/&quot; character. The last segment of the URL&apos;s path must represent
    ///  the fully qualified name of the type (as in
    ///  `path/google.protobuf.Duration`). The name should be in a canonical form
    ///  (e.g., leading &quot;.&quot; is not accepted).
    /// 
    ///  In practice, teams usually precompile into the binary all types that they
    ///  expect it to use in the context of Any. However, for URLs which use the
    ///  scheme `http`, `https`, or no scheme, one can optionally set up a type
    ///  server that maps type URLs to message definitions as follows:
    /// 
    ///  * If no scheme is provided, `https` is assumed.
    ///  * An HTTP GET on the URL must yield a [google.protobuf.Type][]
    ///    value in binary format, or produce an error.
    ///  * Applications are allowed to cache lookup results based on the
    ///    URL, or have them precompiled into a binary to avoid any
    ///    lookup. Therefore, binary compatibility needs to be preserved
    ///    on changes to types. (Use versioned type names to manage
    ///    breaking changes.)
    /// 
    ///  Note: this functionality is not currently available in the official
    ///  protobuf release, and it is not used for type URLs beginning with
    ///  type.googleapis.com.
    /// 
    ///  Schemes other than `http`, `https` (or the empty scheme) might be
    ///  used with implementation specific semantics.
    /// </summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public byte[]? Value { get; set; }
}

/// <summary>Output only. google.rpc.Status object to store the last backup error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1beta1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupErrorDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfo
{
    /// <summary>Output only. google.rpc.Status object to store the last backup error.</summary>
    [JsonPropertyName("lastBackupError")]
    public V1beta1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfoLastBackupError? LastBackupError { get; set; }

    /// <summary>Output only. The last backup state for rule.</summary>
    [JsonPropertyName("lastBackupState")]
    public string? LastBackupState { get; set; }

    /// <summary>Output only. The point in time when the last successful backup was captured from the source.</summary>
    [JsonPropertyName("lastSuccessfulBackupConsistencyTime")]
    public string? LastSuccessfulBackupConsistencyTime { get; set; }

    /// <summary>Output only. Backup Rule id fetched from backup plan.</summary>
    [JsonPropertyName("ruleID")]
    public string? RuleID { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationStatusObservedState
{
    /// <summary>Output only. The time when the instance was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Resource name of data source which will be used as storage location for backups taken. Format : projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}</summary>
    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    /// <summary>Output only. The config info related to backup rules.</summary>
    [JsonPropertyName("rulesConfigInfo")]
    public IList<V1beta1BackupDRBackupPlanAssociationStatusObservedStateRulesConfigInfo>? RulesConfigInfo { get; set; }

    /// <summary>Output only. The BackupPlanAssociation resource state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the instance was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BackupDRBackupPlanAssociationStatus defines the config connector machine state of BackupDRBackupPlanAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanAssociationStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupDRBackupPlanAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BackupDRBackupPlanAssociation resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1BackupDRBackupPlanAssociationStatusObservedState? ObservedState { get; set; }
}

/// <summary>BackupDRBackupPlanAssociation is the Schema for the BackupDRBackupPlanAssociation API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupDRBackupPlanAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupDRBackupPlanAssociationSpec>, IStatus<V1beta1BackupDRBackupPlanAssociationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupDRBackupPlanAssociation";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplanassociations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "backupdr.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupDRBackupPlanAssociation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupDRBackupPlanAssociationSpec defines the desired state of BackupDRBackupPlanAssociation</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BackupDRBackupPlanAssociationSpec Spec { get; set; }

    /// <summary>BackupDRBackupPlanAssociationStatus defines the config connector machine state of BackupDRBackupPlanAssociation</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupDRBackupPlanAssociationStatus? Status { get; set; }
}