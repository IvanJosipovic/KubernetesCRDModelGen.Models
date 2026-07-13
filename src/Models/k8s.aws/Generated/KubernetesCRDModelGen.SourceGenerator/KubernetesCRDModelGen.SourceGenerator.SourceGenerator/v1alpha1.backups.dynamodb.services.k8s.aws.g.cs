#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dynamodb.services.k8s.aws;
/// <summary>Backup is the Schema for the Backups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Backup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupList";
    public const string KubeGroup = "dynamodb.services.k8s.aws";
    public const string KubePluralName = "backups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dynamodb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Backup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Backup> Items { get; set; }
}

/// <summary>BackupSpec defines the desired state of Backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupSpec
{
    /// <summary>
    /// Specified name for the backup.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9_.-]+$`
    /// </summary>
    [JsonPropertyName("backupName")]
    public required string BackupName { get; set; }

    /// <summary>
    /// The name of the table. You can also provide the Amazon Resource Name (ARN)
    /// of the table in this parameter.
    /// </summary>
    [JsonPropertyName("tableName")]
    public required string TableName { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>BackupStatus defines the observed state of Backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1BackupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>Time at which the backup was created. This is the request time of the backup.</summary>
    [JsonPropertyName("backupCreationDateTime")]
    public DateTime? BackupCreationDateTime { get; set; }

    /// <summary>
    /// Time at which the automatic on-demand backup created by DynamoDB will expire.
    /// This SYSTEM on-demand backup expires automatically 35 days after its creation.
    /// </summary>
    [JsonPropertyName("backupExpiryDateTime")]
    public DateTime? BackupExpiryDateTime { get; set; }

    /// <summary>
    /// Size of the backup in bytes. DynamoDB updates this value approximately every
    /// six hours. Recent changes might not be reflected in this value.
    /// </summary>
    [JsonPropertyName("backupSizeBytes")]
    public long? BackupSizeBytes { get; set; }

    /// <summary>Backup can be in one of the following states: CREATING, ACTIVE, DELETED.</summary>
    [JsonPropertyName("backupStatus")]
    public string? BackupStatus { get; set; }

    /// <summary>
    /// BackupType:
    /// 
    ///    * USER - You create and manage these using the on-demand backup feature.
    /// 
    ///    * SYSTEM - If you delete a table with point-in-time recovery enabled,
    ///    a SYSTEM backup is automatically created and is retained for 35 days (at
    ///    no additional cost). System backups allow you to restore the deleted table
    ///    to the state it was in just before the point of deletion.
    /// 
    ///    * AWS_BACKUP - On-demand backup created by you from Backup service.
    /// </summary>
    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BackupStatusConditions>? Conditions { get; set; }
}

/// <summary>Backup is the Schema for the Backups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Backup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BackupSpec?>, IStatus<V1alpha1BackupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Backup";
    public const string KubeGroup = "dynamodb.services.k8s.aws";
    public const string KubePluralName = "backups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dynamodb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupSpec defines the desired state of Backup.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BackupSpec? Spec { get; set; }

    /// <summary>BackupStatus defines the observed state of Backup</summary>
    [JsonPropertyName("status")]
    public V1alpha1BackupStatus? Status { get; set; }
}