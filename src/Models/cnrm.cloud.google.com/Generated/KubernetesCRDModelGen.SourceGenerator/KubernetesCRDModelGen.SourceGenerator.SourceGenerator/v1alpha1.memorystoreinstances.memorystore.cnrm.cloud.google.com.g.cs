#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorystore.cnrm.cloud.google.com;
/// <summary>MemorystoreInstance is the Schema for the MemorystoreInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MemorystoreInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MemorystoreInstance>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MemorystoreInstanceList";
    public const string KubeGroup = "memorystore.cnrm.cloud.google.com";
    public const string KubePluralName = "memorystoreinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemorystoreInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MemorystoreInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MemorystoreInstance> Items { get; set; }
}

/// <summary>Required. The start time of every automated backup in UTC. It must be set to the start of an hour. This field is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecAutomatedBackupConfigFixedFrequencyScheduleStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &quot;24:00:00&quot; for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}

/// <summary>Optional. Trigger automated backups at a fixed frequency.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecAutomatedBackupConfigFixedFrequencySchedule
{
    /// <summary>Required. The start time of every automated backup in UTC. It must be set to the start of an hour. This field is required.</summary>
    [JsonPropertyName("startTime")]
    public V1alpha1MemorystoreInstanceSpecAutomatedBackupConfigFixedFrequencyScheduleStartTime? StartTime { get; set; }
}

/// <summary>Optional. The automated backup config for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecAutomatedBackupConfig
{
    /// <summary>Optional. The automated backup mode. If the mode is disabled, the other fields will be ignored.</summary>
    [JsonPropertyName("automatedBackupMode")]
    public string? AutomatedBackupMode { get; set; }

    /// <summary>Optional. Trigger automated backups at a fixed frequency.</summary>
    [JsonPropertyName("fixedFrequencySchedule")]
    public V1alpha1MemorystoreInstanceSpecAutomatedBackupConfigFixedFrequencySchedule? FixedFrequencySchedule { get; set; }

    /// <summary>Optional. How long to keep automated backups before the backups are deleted. The value should be between 1 day and 365 days. If not specified, the default value is 35 days.</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }
}

/// <summary>Optional. The full resource path of the remote instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecCrossInstanceReplicationConfigPrimaryInstanceInstanceRef
{
    /// <summary>A reference to an externally managed MemorystoreInstance resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a MemorystoreInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a MemorystoreInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Optional. Details of the primary instance that is used as the replication
///  source for this secondary instance.
/// 
///  This field is only set for a secondary instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecCrossInstanceReplicationConfigPrimaryInstance
{
    /// <summary>Optional. The full resource path of the remote instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1alpha1MemorystoreInstanceSpecCrossInstanceReplicationConfigPrimaryInstanceInstanceRef? InstanceRef { get; set; }
}

/// <summary>Optional. The cross instance replication config for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecCrossInstanceReplicationConfig
{
    /// <summary>Required. The role of the instance in cross instance replication.</summary>
    [JsonPropertyName("instanceRole")]
    public string? InstanceRole { get; set; }

    /// <summary>
    /// Optional. Details of the primary instance that is used as the replication
    ///  source for this secondary instance.
    /// 
    ///  This field is only set for a secondary instance.
    /// </summary>
    [JsonPropertyName("primaryInstance")]
    public V1alpha1MemorystoreInstanceSpecCrossInstanceReplicationConfigPrimaryInstance? PrimaryInstance { get; set; }
}

/// <summary>Required. The network where the PSC endpoints are created, in the form of projects/{project_id}/global/networks/{network_id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnectionNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The consumer project_id where PSC connections are established. This should be the same project_id that the instance is being created in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnectionProjectRef
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

/// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnection
{
    /// <summary>Required. The network where the PSC endpoints are created, in the form of projects/{project_id}/global/networks/{network_id}.</summary>
    [JsonPropertyName("networkRef")]
    public required V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnectionNetworkRef NetworkRef { get; set; }

    /// <summary>Required. The consumer project_id where PSC connections are established. This should be the same project_id that the instance is being created in.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnectionProjectRef ProjectRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnections
{
    /// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
    [JsonPropertyName("pscAutoConnection")]
    public V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnection? PscAutoConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpoints
{
    /// <summary>Optional. A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.</summary>
    [JsonPropertyName("connections")]
    public IList<V1alpha1MemorystoreInstanceSpecEndpointsConnections>? Connections { get; set; }
}

/// <summary>Optional. AOF configuration. This field will be ignored if mode is not AOF.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecPersistenceConfigAofConfig
{
    /// <summary>Optional. The fsync mode.</summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>Optional. RDB configuration. This field will be ignored if mode is not RDB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecPersistenceConfigRdbConfig
{
    /// <summary>Optional. Period between RDB snapshots.</summary>
    [JsonPropertyName("rdbSnapshotPeriod")]
    public string? RdbSnapshotPeriod { get; set; }

    /// <summary>Optional. Time that the first snapshot was/will be attempted, and to which future snapshots will be aligned. If not provided, the current time will be used.</summary>
    [JsonPropertyName("rdbSnapshotStartTime")]
    public string? RdbSnapshotStartTime { get; set; }
}

/// <summary>Optional. Persistence configuration of the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecPersistenceConfig
{
    /// <summary>Optional. AOF configuration. This field will be ignored if mode is not AOF.</summary>
    [JsonPropertyName("aofConfig")]
    public V1alpha1MemorystoreInstanceSpecPersistenceConfigAofConfig? AofConfig { get; set; }

    /// <summary>Optional. Current persistence mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Optional. RDB configuration. This field will be ignored if mode is not RDB.</summary>
    [JsonPropertyName("rdbConfig")]
    public V1alpha1MemorystoreInstanceSpecPersistenceConfigRdbConfig? RdbConfig { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecProjectRef
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

/// <summary>Optional. Immutable. Zone distribution configuration of the instance for node allocation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecZoneDistributionConfig
{
    /// <summary>Optional. Current zone distribution mode. Defaults to MULTI_ZONE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Optional. Defines zone where all resources will be allocated with SINGLE_ZONE mode. Ignored for MULTI_ZONE mode.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>MemorystoreInstanceSpec defines the desired state of MemorystoreInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpec
{
    /// <summary>Optional. Immutable. Authorization mode of the instance.</summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

    /// <summary>Optional. The automated backup config for the instance.</summary>
    [JsonPropertyName("automatedBackupConfig")]
    public V1alpha1MemorystoreInstanceSpecAutomatedBackupConfig? AutomatedBackupConfig { get; set; }

    /// <summary>Optional. The cross instance replication config for the instance.</summary>
    [JsonPropertyName("crossInstanceReplicationConfig")]
    public V1alpha1MemorystoreInstanceSpecCrossInstanceReplicationConfig? CrossInstanceReplicationConfig { get; set; }

    /// <summary>Optional. If set to true deletion of the instance will fail.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Optional. Endpoints for the instance.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1alpha1MemorystoreInstanceSpecEndpoints>? Endpoints { get; set; }

    /// <summary>Optional. User-provided engine configurations for the instance.</summary>
    [JsonPropertyName("engineConfigs")]
    public IDictionary<string, string>? EngineConfigs { get; set; }

    /// <summary>Optional. Immutable. Engine version of the instance.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Optional. Labels to represent user-provided metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. The maintenance version of the instance.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>Optional. The mode config for the instance.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Optional. Immutable. Machine type for individual nodes of the instance.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>Optional. Persistence configuration of the instance.</summary>
    [JsonPropertyName("persistenceConfig")]
    public V1alpha1MemorystoreInstanceSpecPersistenceConfig? PersistenceConfig { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1MemorystoreInstanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Number of replica nodes per shard. If omitted the default is 0 replicas.</summary>
    [JsonPropertyName("replicaCount")]
    public int? ReplicaCount { get; set; }

    /// <summary>The MemorystoreInstance name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Number of shards for the instance.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }

    /// <summary>Optional. Immutable. In-transit encryption mode of the instance.</summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }

    /// <summary>Optional. Immutable. Zone distribution configuration of the instance for node allocation.</summary>
    [JsonPropertyName("zoneDistributionConfig")]
    public V1alpha1MemorystoreInstanceSpecZoneDistributionConfig? ZoneDistributionConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusConditions
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

/// <summary>Output only. The primary instance that acts as the source of replication for the secondary instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigMembershipPrimaryInstance
{
    /// <summary>Optional. The full resource path of the remote instance.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. The unique identifier of the remote instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigMembershipSecondaryInstances
{
    /// <summary>Optional. The full resource path of the remote instance.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. The unique identifier of the remote instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Output only. An output only view of all the member instances participating in the cross instance replication. This view will be provided by every member instance irrespective of its instance role(primary or secondary).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigMembership
{
    /// <summary>Output only. The primary instance that acts as the source of replication for the secondary instances.</summary>
    [JsonPropertyName("primaryInstance")]
    public V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigMembershipPrimaryInstance? PrimaryInstance { get; set; }

    /// <summary>Output only. The list of secondary instances replicating from the primary instance.</summary>
    [JsonPropertyName("secondaryInstances")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigMembershipSecondaryInstances>? SecondaryInstances { get; set; }
}

/// <summary>
/// Optional. Details of the primary instance that is used as the replication
///  source for this secondary instance.
/// 
///  This field is only set for a secondary instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigPrimaryInstance
{
    /// <summary>Optional. The full resource path of the remote instance.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. The unique identifier of the remote instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigSecondaryInstances
{
    /// <summary>Optional. The full resource path of the remote instance.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Output only. The unique identifier of the remote instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Optional. The cross instance replication config for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfig
{
    /// <summary>Output only. An output only view of all the member instances participating in the cross instance replication. This view will be provided by every member instance irrespective of its instance role(primary or secondary).</summary>
    [JsonPropertyName("membership")]
    public V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigMembership? Membership { get; set; }

    /// <summary>
    /// Optional. Details of the primary instance that is used as the replication
    ///  source for this secondary instance.
    /// 
    ///  This field is only set for a secondary instance.
    /// </summary>
    [JsonPropertyName("primaryInstance")]
    public V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigPrimaryInstance? PrimaryInstance { get; set; }

    /// <summary>
    /// Optional. List of secondary instances that are replicating from this
    ///  primary instance.
    /// 
    ///  This field is only set for a primary instance.
    /// </summary>
    [JsonPropertyName("secondaryInstances")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfigSecondaryInstances>? SecondaryInstances { get; set; }
}

/// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnectionsPscAutoConnection
{
    /// <summary>Output only. Type of the PSC connection.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Output only. The URI of the consumer side forwarding rule. Format: projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}</summary>
    [JsonPropertyName("forwardingRule")]
    public string? ForwardingRule { get; set; }

    /// <summary>Output only. The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Optional. Output only. port will only be set for Primary/Reader or Discovery endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Output only. The PSC connection id of the forwarding rule connected to the service attachment.</summary>
    [JsonPropertyName("pscConnectionID")]
    public string? PscConnectionID { get; set; }

    /// <summary>Output only. The status of the PSC connection: whether a connection exists and ACTIVE or it no longer exists. Please note that this value is updated periodically. Please use Private Service Connect APIs for the latest status.</summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }

    /// <summary>Output only. The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnections
{
    /// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
    [JsonPropertyName("pscAutoConnection")]
    public V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnectionsPscAutoConnection? PscAutoConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateEndpoints
{
    /// <summary>Optional. A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.</summary>
    [JsonPropertyName("connections")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnections>? Connections { get; set; }
}

/// <summary>Output only. Configuration of individual nodes of the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateNodeConfig
{
    /// <summary>Output only. Memory size in GB of the node.</summary>
    [JsonPropertyName("sizeGB")]
    public double? SizeGB { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStatePscAttachmentDetails
{
    /// <summary>Output only. Type of Psc endpoint.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Output only. Service attachment URI which your self-created PscConnection should use as target.</summary>
    [JsonPropertyName("serviceAttachment")]
    public string? ServiceAttachment { get; set; }
}

/// <summary>Output only. Describes ongoing update when instance state is UPDATING.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateStateInfoUpdateInfo
{
    /// <summary>Output only. Target number of replica nodes per shard for the instance.</summary>
    [JsonPropertyName("targetReplicaCount")]
    public int? TargetReplicaCount { get; set; }

    /// <summary>Output only. Target number of shards for the instance.</summary>
    [JsonPropertyName("targetShardCount")]
    public int? TargetShardCount { get; set; }
}

/// <summary>Output only. Additional information about the state of the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateStateInfo
{
    /// <summary>Output only. Describes ongoing update when instance state is UPDATING.</summary>
    [JsonPropertyName("updateInfo")]
    public V1alpha1MemorystoreInstanceStatusObservedStateStateInfoUpdateInfo? UpdateInfo { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedState
{
    /// <summary>Output only. The list of available maintenance versions for the instance.</summary>
    [JsonPropertyName("availableMaintenanceVersions")]
    public IList<string>? AvailableMaintenanceVersions { get; set; }

    /// <summary>Output only. Creation timestamp of the instance.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. The cross instance replication config for the instance.</summary>
    [JsonPropertyName("crossInstanceReplicationConfig")]
    public V1alpha1MemorystoreInstanceStatusObservedStateCrossInstanceReplicationConfig? CrossInstanceReplicationConfig { get; set; }

    /// <summary>Output only. The current version of the maintenance schedule.</summary>
    [JsonPropertyName("effectiveMaintenanceVersion")]
    public string? EffectiveMaintenanceVersion { get; set; }

    /// <summary>Optional. Endpoints for the instance.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStateEndpoints>? Endpoints { get; set; }

    /// <summary>Output only. Configuration of individual nodes of the instance.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1alpha1MemorystoreInstanceStatusObservedStateNodeConfig? NodeConfig { get; set; }

    /// <summary>Output only. List of PSC connections for the instance.</summary>
    [JsonPropertyName("pscAttachmentDetails")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStatePscAttachmentDetails>? PscAttachmentDetails { get; set; }

    /// <summary>Output only. Current state of the instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the state of the instance.</summary>
    [JsonPropertyName("stateInfo")]
    public V1alpha1MemorystoreInstanceStatusObservedStateStateInfo? StateInfo { get; set; }

    /// <summary>Output only. System assigned, unique identifier for the instance.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Latest update timestamp of the instance.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>MemorystoreInstanceStatus defines the config connector machine state of MemorystoreInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MemorystoreInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the MemorystoreInstance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1MemorystoreInstanceStatusObservedState? ObservedState { get; set; }
}

/// <summary>MemorystoreInstance is the Schema for the MemorystoreInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MemorystoreInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MemorystoreInstanceSpec>, IStatus<V1alpha1MemorystoreInstanceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MemorystoreInstance";
    public const string KubeGroup = "memorystore.cnrm.cloud.google.com";
    public const string KubePluralName = "memorystoreinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemorystoreInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MemorystoreInstanceSpec defines the desired state of MemorystoreInstance</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MemorystoreInstanceSpec Spec { get; set; }

    /// <summary>MemorystoreInstanceStatus defines the config connector machine state of MemorystoreInstance</summary>
    [JsonPropertyName("status")]
    public V1alpha1MemorystoreInstanceStatus? Status { get; set; }
}