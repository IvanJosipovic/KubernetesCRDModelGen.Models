#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.services.k8s.aws;
/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Cluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "kafka.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Cluster> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecAssociatedSCRAMSecretRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecAssociatedSCRAMSecretRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecAssociatedSCRAMSecretRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoClientSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoClientSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoClientSubnetRefsFrom? From { get; set; }
}

/// <summary>Public access control for brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Information about the broker access configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoConnectivityInfo
{
    /// <summary>
    /// The network type of the cluster, which is IPv4 or DUAL. The DUAL network
    /// type uses both IPv4 and IPv6 addresses for your cluster and its resources.
    /// 
    /// By default, a cluster uses the IPv4 network type.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Public access control for brokers.</summary>
    [JsonPropertyName("publicAccess")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// Contains information about provisioned throughput for EBS storage volumes
/// attached to kafka broker nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("volumeThroughput")]
    public long? VolumeThroughput { get; set; }
}

/// <summary>
/// Contains information about the EBS storage volumes attached to Apache Kafka
/// broker nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>
    /// Contains information about provisioned throughput for EBS storage volumes
    /// attached to kafka broker nodes.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public long? VolumeSize { get; set; }
}

/// <summary>Contains information about storage volumes attached to MSK broker nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfoStorageInfo
{
    /// <summary>
    /// Contains information about the EBS storage volumes attached to Apache Kafka
    /// broker nodes.
    /// </summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Information about the broker nodes in the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecBrokerNodeGroupInfo
{
    /// <summary>
    /// The distribution of broker nodes across Availability Zones. This is an optional
    /// parameter. If you don&apos;t specify it, Amazon MSK gives it the value DEFAULT.
    /// You can also explicitly set this parameter to the value DEFAULT. No other
    /// values are currently allowed.
    /// 
    /// Amazon MSK distributes the broker nodes evenly across the Availability Zones
    /// that correspond to the subnets you provide when you create the cluster.
    /// </summary>
    [JsonPropertyName("brokerAZDistribution")]
    public string? BrokerAZDistribution { get; set; }

    /// <summary>Reference field for ClientSubnets</summary>
    [JsonPropertyName("clientSubnetRefs")]
    public IList<V1alpha1ClusterSpecBrokerNodeGroupInfoClientSubnetRefs>? ClientSubnetRefs { get; set; }

    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>Information about the broker access configuration.</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Reference field for SecurityGroups</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ClusterSpecBrokerNodeGroupInfoSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Contains information about storage volumes attached to MSK broker nodes.</summary>
    [JsonPropertyName("storageInfo")]
    public V1alpha1ClusterSpecBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>Details for IAM access control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecClientAuthenticationSaslIam
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Details for SASL/SCRAM client authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecClientAuthenticationSaslScram
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Details for client authentication using SASL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecClientAuthenticationSasl
{
    /// <summary>Details for IAM access control.</summary>
    [JsonPropertyName("iam")]
    public V1alpha1ClusterSpecClientAuthenticationSaslIam? Iam { get; set; }

    /// <summary>Details for SASL/SCRAM client authentication.</summary>
    [JsonPropertyName("scram")]
    public V1alpha1ClusterSpecClientAuthenticationSaslScram? Scram { get; set; }
}

/// <summary>Details for client authentication using TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecClientAuthenticationTls
{
    [JsonPropertyName("certificateAuthorityARNList")]
    public IList<string>? CertificateAuthorityARNList { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecClientAuthenticationUnauthenticated
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Includes all client authentication related information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecClientAuthentication
{
    /// <summary>Details for client authentication using SASL.</summary>
    [JsonPropertyName("sasl")]
    public V1alpha1ClusterSpecClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Details for client authentication using TLS.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1ClusterSpecClientAuthenticationTls? Tls { get; set; }

    [JsonPropertyName("unauthenticated")]
    public V1alpha1ClusterSpecClientAuthenticationUnauthenticated? Unauthenticated { get; set; }
}

/// <summary>
/// Represents the configuration that you want MSK to use for the brokers in
/// a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecConfigurationInfo
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("revision")]
    public long? Revision { get; set; }
}

/// <summary>The data-volume encryption details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionInfoEncryptionAtRest
{
    [JsonPropertyName("dataVolumeKMSKeyID")]
    public string? DataVolumeKMSKeyID { get; set; }
}

/// <summary>The settings for encrypting data in transit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionInfoEncryptionInTransit
{
    /// <summary>Client-broker encryption in transit setting.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>Includes all encryption-related information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecEncryptionInfo
{
    /// <summary>The data-volume encryption details.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public V1alpha1ClusterSpecEncryptionInfoEncryptionAtRest? EncryptionAtRest { get; set; }

    /// <summary>The settings for encrypting data in transit.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1alpha1ClusterSpecEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLoggingInfoBrokerLogsCloudWatchLogs
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLoggingInfoBrokerLogsFirehose
{
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLoggingInfoBrokerLogsS3
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLoggingInfoBrokerLogs
{
    [JsonPropertyName("cloudWatchLogs")]
    public V1alpha1ClusterSpecLoggingInfoBrokerLogsCloudWatchLogs? CloudWatchLogs { get; set; }

    [JsonPropertyName("firehose")]
    public V1alpha1ClusterSpecLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1ClusterSpecLoggingInfoBrokerLogsS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecLoggingInfo
{
    [JsonPropertyName("brokerLogs")]
    public V1alpha1ClusterSpecLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Indicates whether you want to turn on or turn off the JMX Exporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecOpenMonitoringPrometheusJmxExporter
{
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Indicates whether you want to turn on or turn off the Node Exporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecOpenMonitoringPrometheusNodeExporter
{
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Prometheus settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecOpenMonitoringPrometheus
{
    /// <summary>Indicates whether you want to turn on or turn off the JMX Exporter.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1alpha1ClusterSpecOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Indicates whether you want to turn on or turn off the Node Exporter.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1alpha1ClusterSpecOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>The settings for open monitoring.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecOpenMonitoring
{
    /// <summary>Prometheus settings.</summary>
    [JsonPropertyName("prometheus")]
    public V1alpha1ClusterSpecOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary>
/// Specifies if intelligent rebalancing should be turned on for the new MSK
/// Provisioned cluster with Express brokers. By default, intelligent rebalancing
/// status is ACTIVE for all new clusters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecRebalancing
{
    /// <summary>
    /// Intelligent rebalancing status. The default intelligent rebalancing status
    /// is ACTIVE for all new Express-based clusters.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// ClusterSpec defines the desired state of Cluster.
/// 
/// Returns information about a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpec
{
    [JsonPropertyName("associatedSCRAMSecretRefs")]
    public IList<V1alpha1ClusterSpecAssociatedSCRAMSecretRefs>? AssociatedSCRAMSecretRefs { get; set; }

    [JsonPropertyName("associatedSCRAMSecrets")]
    public IList<string>? AssociatedSCRAMSecrets { get; set; }

    /// <summary>Information about the broker nodes in the cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public required V1alpha1ClusterSpecBrokerNodeGroupInfo BrokerNodeGroupInfo { get; set; }

    /// <summary>Includes all client authentication related information.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1alpha1ClusterSpecClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>
    /// Represents the configuration that you want MSK to use for the brokers in
    /// a cluster.
    /// </summary>
    [JsonPropertyName("configurationInfo")]
    public V1alpha1ClusterSpecConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>Includes all encryption-related information.</summary>
    [JsonPropertyName("encryptionInfo")]
    public V1alpha1ClusterSpecEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>
    /// Specifies the level of monitoring for the MSK cluster. The possible values
    /// are DEFAULT, PER_BROKER, PER_TOPIC_PER_BROKER, and PER_TOPIC_PER_PARTITION.
    /// </summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    /// <summary>The version of Apache Kafka.</summary>
    [JsonPropertyName("kafkaVersion")]
    public required string KafkaVersion { get; set; }

    [JsonPropertyName("loggingInfo")]
    public V1alpha1ClusterSpecLoggingInfo? LoggingInfo { get; set; }

    /// <summary>The name of the cluster.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The number of broker nodes in the cluster.</summary>
    [JsonPropertyName("numberOfBrokerNodes")]
    public required long NumberOfBrokerNodes { get; set; }

    /// <summary>The settings for open monitoring.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1alpha1ClusterSpecOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>
    /// Specifies if intelligent rebalancing should be turned on for the new MSK
    /// Provisioned cluster with Express brokers. By default, intelligent rebalancing
    /// status is ACTIVE for all new clusters.
    /// </summary>
    [JsonPropertyName("rebalancing")]
    public V1alpha1ClusterSpecRebalancing? Rebalancing { get; set; }

    /// <summary>This controls storage mode for supported storage tiers.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }

    /// <summary>Create tags when creating the cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAckResourceMetadata
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
public partial class V1alpha1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    [JsonPropertyName("bootstrapBrokerString")]
    public string? BootstrapBrokerString { get; set; }

    [JsonPropertyName("bootstrapBrokerStringPublicSASLIAM")]
    public string? BootstrapBrokerStringPublicSASLIAM { get; set; }

    [JsonPropertyName("bootstrapBrokerStringPublicSASLSCRAM")]
    public string? BootstrapBrokerStringPublicSASLSCRAM { get; set; }

    [JsonPropertyName("bootstrapBrokerStringPublicTLS")]
    public string? BootstrapBrokerStringPublicTLS { get; set; }

    [JsonPropertyName("bootstrapBrokerStringSASLIAM")]
    public string? BootstrapBrokerStringSASLIAM { get; set; }

    [JsonPropertyName("bootstrapBrokerStringSASLSCRAM")]
    public string? BootstrapBrokerStringSASLSCRAM { get; set; }

    [JsonPropertyName("bootstrapBrokerStringTLS")]
    public string? BootstrapBrokerStringTLS { get; set; }

    [JsonPropertyName("bootstrapBrokerStringVPCConnectivitySASLIAM")]
    public string? BootstrapBrokerStringVPCConnectivitySASLIAM { get; set; }

    [JsonPropertyName("bootstrapBrokerStringVPCConnectivitySASLSCRAM")]
    public string? BootstrapBrokerStringVPCConnectivitySASLSCRAM { get; set; }

    [JsonPropertyName("bootstrapBrokerStringVPCConnectivityTLS")]
    public string? BootstrapBrokerStringVPCConnectivityTLS { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The current version of the MSK cluster.</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>
    /// The state of the cluster. The possible states are ACTIVE, CREATING, DELETING,
    /// FAILED, HEALING, MAINTENANCE, REBOOTING_BROKER, and UPDATING.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("zookeeperConnectString")]
    public string? ZookeeperConnectString { get; set; }

    [JsonPropertyName("zookeeperConnectStringTLS")]
    public string? ZookeeperConnectStringTLS { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterSpec?>, IStatus<V1alpha1ClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "kafka.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ClusterSpec defines the desired state of Cluster.
    /// 
    /// Returns information about a cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterSpec? Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterStatus? Status { get; set; }
}