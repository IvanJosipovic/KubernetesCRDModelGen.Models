#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.managedkafka.cnrm.cloud.google.com;
/// <summary>ManagedKafkaCluster is the Schema for the ManagedKafkaCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedKafkaClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedKafkaCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedKafkaClusterList";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "managedkafka.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedKafkaClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ManagedKafkaCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ManagedKafkaCluster> Items { get; set; }
}

/// <summary>Required. Capacity configuration for the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecCapacityConfig
{
    /// <summary>Required. The memory to provision for the cluster in bytes. The CPU:memory ratio (vCPU:GiB) must be between 1:1 and 1:8. Minimum: 3221225472 (3 GiB).</summary>
    [JsonPropertyName("memoryBytes")]
    public required long MemoryBytes { get; set; }

    /// <summary>Required. The number of vCPUs to provision for the cluster. Minimum: 3.</summary>
    [JsonPropertyName("vcpuCount")]
    public required long VcpuCount { get; set; }
}

/// <summary>
/// Required. Reference to the VPC subnet in which to create Private Service Connect
///  (PSC) endpoints for the Kafka brokers and bootstrap address.
/// 
///  The subnet must be located in the same region as the Kafka cluster. The
///  project may differ. Multiple subnets from the same parent network must not
///  be specified.
/// 
///  The CIDR range of the subnet must be within the IPv4 address ranges for
///  private networks, as specified in RFC 1918.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigsSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form &quot;projects/{{project}}/regions/{{region}}/subnetworks/{{name}}&quot;, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigs
{
    /// <summary>
    /// Required. Reference to the VPC subnet in which to create Private Service Connect
    ///  (PSC) endpoints for the Kafka brokers and bootstrap address.
    /// 
    ///  The subnet must be located in the same region as the Kafka cluster. The
    ///  project may differ. Multiple subnets from the same parent network must not
    ///  be specified.
    /// 
    ///  The CIDR range of the subnet must be within the IPv4 address ranges for
    ///  private networks, as specified in RFC 1918.
    /// </summary>
    [JsonPropertyName("subnetworkRef")]
    public required V1alpha1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigsSubnetworkRef SubnetworkRef { get; set; }
}

/// <summary>Required. Access configuration for the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecGcpConfigAccessConfig
{
    /// <summary>Required. Virtual Private Cloud (VPC) networks that must be granted direct access to the Kafka cluster. Minimum of 1 network is required. Maximum 10 networks can be specified.</summary>
    [JsonPropertyName("networkConfigs")]
    public required IList<V1alpha1ManagedKafkaClusterSpecGcpConfigAccessConfigNetworkConfigs> NetworkConfigs { get; set; }
}

/// <summary>Optional. Immutable. The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecGcpConfigKmsKeyRef
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

/// <summary>Required. Configuration properties for a Kafka cluster deployed to Google Cloud Platform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecGcpConfig
{
    /// <summary>Required. Access configuration for the Kafka cluster.</summary>
    [JsonPropertyName("accessConfig")]
    public required V1alpha1ManagedKafkaClusterSpecGcpConfigAccessConfig AccessConfig { get; set; }

    /// <summary>Optional. Immutable. The Cloud KMS Key name to use for encryption. The key must be located in the same region as the cluster and cannot be changed.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1ManagedKafkaClusterSpecGcpConfigKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecProjectRef
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

/// <summary>Optional. Rebalance configuration for the Kafka cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpecRebalanceConfig
{
    /// <summary>Optional. The rebalance behavior for the cluster. When not specified, defaults to `NO_REBALANCE`.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>ManagedKafkaClusterSpec defines the desired state of ManagedKafkaCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterSpec
{
    /// <summary>Required. Capacity configuration for the Kafka cluster.</summary>
    [JsonPropertyName("capacityConfig")]
    public required V1alpha1ManagedKafkaClusterSpecCapacityConfig CapacityConfig { get; set; }

    /// <summary>Required. Configuration properties for a Kafka cluster deployed to Google Cloud Platform.</summary>
    [JsonPropertyName("gcpConfig")]
    public required V1alpha1ManagedKafkaClusterSpecGcpConfig GcpConfig { get; set; }

    /// <summary>Optional. Labels as key value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ManagedKafkaClusterSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. Rebalance configuration for the Kafka cluster.</summary>
    [JsonPropertyName("rebalanceConfig")]
    public V1alpha1ManagedKafkaClusterSpecRebalanceConfig? RebalanceConfig { get; set; }

    /// <summary>The GCP resource identifier. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterStatusConditions
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
public partial class V1alpha1ManagedKafkaClusterStatusObservedState
{
    /// <summary>Output only. The time when the cluster was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The current state of the cluster.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time when the cluster was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ManagedKafkaClusterStatus defines the config connector machine state of ManagedKafkaCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedKafkaClusterStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ManagedKafkaClusterStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ManagedKafkaCluster resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ManagedKafkaClusterStatusObservedState? ObservedState { get; set; }
}

/// <summary>ManagedKafkaCluster is the Schema for the ManagedKafkaCluster API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedKafkaCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedKafkaClusterSpec>, IStatus<V1alpha1ManagedKafkaClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedKafkaCluster";
    public const string KubeGroup = "managedkafka.cnrm.cloud.google.com";
    public const string KubePluralName = "managedkafkaclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "managedkafka.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedKafkaCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedKafkaClusterSpec defines the desired state of ManagedKafkaCluster</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ManagedKafkaClusterSpec Spec { get; set; }

    /// <summary>ManagedKafkaClusterStatus defines the config connector machine state of ManagedKafkaCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedKafkaClusterStatus? Status { get; set; }
}