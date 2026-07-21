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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Required. The network where the PSC endpoints are created, in the form of projects/{project_id}/global/networks/{network_id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnectionNetworkRef
{
    /// <summary>A reference to an externally-managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The consumer project_id where PSC connections are established. This should be the same project_id that the instance is being created in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Required. The consumer network where the IP address resides, in the form of projects/{project_id}/global/networks/{network_id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscConnectionNetworkRef
{
    /// <summary>A reference to an externally-managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscConnectionServiceAttachmentRef
{
    /// <summary>The ComputeServiceAttachment selflink in the form &quot;projects/{{project}}/regions/{{region}}/serviceAttachments/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeServiceAttachment` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Detailed information of a PSC connection that is created by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscConnection
{
    /// <summary>Required. The IP allocated on the consumer network for the PSC forwarding rule.</summary>
    [JsonPropertyName("ipAddress")]
    public required string IpAddress { get; set; }

    /// <summary>Required. The consumer network where the IP address resides, in the form of projects/{project_id}/global/networks/{network_id}.</summary>
    [JsonPropertyName("networkRef")]
    public required V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscConnectionNetworkRef NetworkRef { get; set; }

    /// <summary>Required. The PSC connection id of the forwarding rule connected to the service attachment.</summary>
    [JsonPropertyName("pscConnectionID")]
    public string? PscConnectionID { get; set; }

    /// <summary>Required. The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.</summary>
    [JsonPropertyName("serviceAttachmentRef")]
    public required V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscConnectionServiceAttachmentRef ServiceAttachmentRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpointsConnections
{
    /// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
    [JsonPropertyName("pscAutoConnection")]
    public V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscAutoConnection? PscAutoConnection { get; set; }

    /// <summary>Detailed information of a PSC connection that is created by the user.</summary>
    [JsonPropertyName("pscConnection")]
    public V1alpha1MemorystoreInstanceSpecEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecEndpoints
{
    /// <summary>Optional. A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.</summary>
    [JsonPropertyName("connections")]
    public IList<V1alpha1MemorystoreInstanceSpecEndpointsConnections>? Connections { get; set; }
}

/// <summary>Optional. AOF configuration. This field will be ignored if mode is not AOF.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpecPersistenceConfigAofConfig
{
    /// <summary>Optional. The fsync mode.</summary>
    [JsonPropertyName("appendFsync")]
    public string? AppendFsync { get; set; }
}

/// <summary>Optional. RDB configuration. This field will be ignored if mode is not RDB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceSpec
{
    /// <summary>Optional. Immutable. Authorization mode of the instance.</summary>
    [JsonPropertyName("authorizationMode")]
    public string? AuthorizationMode { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>Detailed information of a PSC connection that is created by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnectionsPscConnection
{
    /// <summary>Output only. Type of the PSC connection.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Output only. The consumer project_id where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Output only. The status of the PSC connection: whether a connection exists and ACTIVE or it no longer exists. Please note that this value is updated periodically. Please use Private Service Connect APIs for the latest status.</summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnections
{
    /// <summary>Detailed information of a PSC connection that is created through service connectivity automation.</summary>
    [JsonPropertyName("pscAutoConnection")]
    public V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnectionsPscAutoConnection? PscAutoConnection { get; set; }

    /// <summary>Detailed information of a PSC connection that is created by the user.</summary>
    [JsonPropertyName("pscConnection")]
    public V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateEndpoints
{
    /// <summary>Optional. A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.</summary>
    [JsonPropertyName("connections")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStateEndpointsConnections>? Connections { get; set; }
}

/// <summary>Output only. Configuration of individual nodes of the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateNodeConfig
{
    /// <summary>Output only. Memory size in GB of the node.</summary>
    [JsonPropertyName("sizeGB")]
    public double? SizeGB { get; set; }
}

/// <summary>Output only. Describes ongoing update when instance state is UPDATING.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateStateInfoUpdateInfo
{
}

/// <summary>Output only. Additional information about the state of the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedStateStateInfo
{
    /// <summary>Output only. Describes ongoing update when instance state is UPDATING.</summary>
    [JsonPropertyName("updateInfo")]
    public V1alpha1MemorystoreInstanceStatusObservedStateStateInfoUpdateInfo? UpdateInfo { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceStatusObservedState
{
    /// <summary>Output only. Creation timestamp of the instance.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Endpoints for the instance.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1alpha1MemorystoreInstanceStatusObservedStateEndpoints>? Endpoints { get; set; }

    /// <summary>Output only. Configuration of individual nodes of the instance.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1alpha1MemorystoreInstanceStatusObservedStateNodeConfig? NodeConfig { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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