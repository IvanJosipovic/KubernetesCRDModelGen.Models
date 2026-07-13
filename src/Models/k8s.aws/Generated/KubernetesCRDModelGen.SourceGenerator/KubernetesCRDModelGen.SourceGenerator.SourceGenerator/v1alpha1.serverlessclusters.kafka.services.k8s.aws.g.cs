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
/// <summary>ServerlessCluster is the Schema for the ServerlessClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServerlessClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServerlessCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServerlessClusterList";
    public const string KubeGroup = "kafka.services.k8s.aws";
    public const string KubePluralName = "serverlessclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerlessClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ServerlessCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ServerlessCluster> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecAssociatedSCRAMSecretRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecAssociatedSCRAMSecretRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessClusterSpecAssociatedSCRAMSecretRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoClientSubnetRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoClientSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoClientSubnetRefsFrom? From { get; set; }
}

/// <summary>Public access control for brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoConnectivityInfoPublicAccess
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Information about the broker access configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoConnectivityInfo
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
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoConnectivityInfoPublicAccess? PublicAccess { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoSecurityGroupRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// Contains information about provisioned throughput for EBS storage volumes
/// attached to kafka broker nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoStorageInfoEbsStorageInfo
{
    /// <summary>
    /// Contains information about provisioned throughput for EBS storage volumes
    /// attached to kafka broker nodes.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public long? VolumeSize { get; set; }
}

/// <summary>Contains information about storage volumes attached to MSK broker nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoStorageInfo
{
    /// <summary>
    /// Contains information about the EBS storage volumes attached to Apache Kafka
    /// broker nodes.
    /// </summary>
    [JsonPropertyName("ebsStorageInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo { get; set; }
}

/// <summary>Describes the setup to be used for Apache Kafka broker nodes in the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfo
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
    public IList<V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoClientSubnetRefs>? ClientSubnetRefs { get; set; }

    [JsonPropertyName("clientSubnets")]
    public IList<string>? ClientSubnets { get; set; }

    /// <summary>Information about the broker access configuration.</summary>
    [JsonPropertyName("connectivityInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Reference field for SecurityGroups</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Contains information about storage volumes attached to MSK broker nodes.</summary>
    [JsonPropertyName("storageInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfoStorageInfo? StorageInfo { get; set; }
}

/// <summary>Details for IAM access control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationSaslIam
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Details for SASL/SCRAM client authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationSaslScram
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Details for client authentication using SASL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationSasl
{
    /// <summary>Details for IAM access control.</summary>
    [JsonPropertyName("iam")]
    public V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationSaslIam? Iam { get; set; }

    /// <summary>Details for SASL/SCRAM client authentication.</summary>
    [JsonPropertyName("scram")]
    public V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationSaslScram? Scram { get; set; }
}

/// <summary>Details for client authentication using TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationTls
{
    [JsonPropertyName("certificateAuthorityARNList")]
    public IList<string>? CertificateAuthorityARNList { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationUnauthenticated
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Includes all client authentication information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedClientAuthentication
{
    /// <summary>Details for client authentication using SASL.</summary>
    [JsonPropertyName("sasl")]
    public V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationSasl? Sasl { get; set; }

    /// <summary>Details for client authentication using TLS.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationTls? Tls { get; set; }

    [JsonPropertyName("unauthenticated")]
    public V1alpha1ServerlessClusterSpecProvisionedClientAuthenticationUnauthenticated? Unauthenticated { get; set; }
}

/// <summary>Specifies the configuration to use for the brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedConfigurationInfo
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("revision")]
    public long? Revision { get; set; }
}

/// <summary>The data-volume encryption details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedEncryptionInfoEncryptionAtRest
{
    [JsonPropertyName("dataVolumeKMSKeyID")]
    public string? DataVolumeKMSKeyID { get; set; }
}

/// <summary>The settings for encrypting data in transit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedEncryptionInfoEncryptionInTransit
{
    /// <summary>Client-broker encryption in transit setting.</summary>
    [JsonPropertyName("clientBroker")]
    public string? ClientBroker { get; set; }

    [JsonPropertyName("inCluster")]
    public bool? InCluster { get; set; }
}

/// <summary>
/// Includes encryption-related information, such as the AWS KMS key used for
/// encrypting data at rest and whether you want MSK to encrypt your data in
/// transit.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedEncryptionInfo
{
    /// <summary>The data-volume encryption details.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public V1alpha1ServerlessClusterSpecProvisionedEncryptionInfoEncryptionAtRest? EncryptionAtRest { get; set; }

    /// <summary>The settings for encrypting data in transit.</summary>
    [JsonPropertyName("encryptionInTransit")]
    public V1alpha1ServerlessClusterSpecProvisionedEncryptionInfoEncryptionInTransit? EncryptionInTransit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogsCloudWatchLogs
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogsFirehose
{
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogsS3
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogs
{
    [JsonPropertyName("cloudWatchLogs")]
    public V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogsCloudWatchLogs? CloudWatchLogs { get; set; }

    [JsonPropertyName("firehose")]
    public V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogsFirehose? Firehose { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogsS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedLoggingInfo
{
    [JsonPropertyName("brokerLogs")]
    public V1alpha1ServerlessClusterSpecProvisionedLoggingInfoBrokerLogs? BrokerLogs { get; set; }
}

/// <summary>Indicates whether you want to turn on or turn off the JMX Exporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedOpenMonitoringPrometheusJmxExporter
{
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Indicates whether you want to turn on or turn off the Node Exporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedOpenMonitoringPrometheusNodeExporter
{
    [JsonPropertyName("enabledInBroker")]
    public bool? EnabledInBroker { get; set; }
}

/// <summary>Prometheus settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedOpenMonitoringPrometheus
{
    /// <summary>Indicates whether you want to turn on or turn off the JMX Exporter.</summary>
    [JsonPropertyName("jmxExporter")]
    public V1alpha1ServerlessClusterSpecProvisionedOpenMonitoringPrometheusJmxExporter? JmxExporter { get; set; }

    /// <summary>Indicates whether you want to turn on or turn off the Node Exporter.</summary>
    [JsonPropertyName("nodeExporter")]
    public V1alpha1ServerlessClusterSpecProvisionedOpenMonitoringPrometheusNodeExporter? NodeExporter { get; set; }
}

/// <summary>JMX and Node monitoring for the MSK cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedOpenMonitoring
{
    /// <summary>Prometheus settings.</summary>
    [JsonPropertyName("prometheus")]
    public V1alpha1ServerlessClusterSpecProvisionedOpenMonitoringPrometheus? Prometheus { get; set; }
}

/// <summary>
/// Specifies whether or not intelligent rebalancing is turned on for a newly
/// created MSK Provisioned cluster with Express brokers. Intelligent rebalancing
/// performs automatic partition balancing operations when you scale your clusters
/// up or down. By default, intelligent rebalancing is ACTIVE for all new Express-based
/// clusters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisionedRebalancing
{
    /// <summary>
    /// Intelligent rebalancing status. The default intelligent rebalancing status
    /// is ACTIVE for all new Express-based clusters.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Information about the provisioned cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecProvisioned
{
    /// <summary>Describes the setup to be used for Apache Kafka broker nodes in the cluster.</summary>
    [JsonPropertyName("brokerNodeGroupInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedBrokerNodeGroupInfo? BrokerNodeGroupInfo { get; set; }

    /// <summary>Includes all client authentication information.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1alpha1ServerlessClusterSpecProvisionedClientAuthentication? ClientAuthentication { get; set; }

    /// <summary>Specifies the configuration to use for the brokers.</summary>
    [JsonPropertyName("configurationInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedConfigurationInfo? ConfigurationInfo { get; set; }

    /// <summary>
    /// Includes encryption-related information, such as the AWS KMS key used for
    /// encrypting data at rest and whether you want MSK to encrypt your data in
    /// transit.
    /// </summary>
    [JsonPropertyName("encryptionInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedEncryptionInfo? EncryptionInfo { get; set; }

    /// <summary>
    /// Specifies which metrics are gathered for the MSK cluster. This property has
    /// the following possible values: DEFAULT, PER_BROKER, PER_TOPIC_PER_BROKER,
    /// and PER_TOPIC_PER_PARTITION. For a list of the metrics associated with each
    /// of these levels of monitoring, see Monitoring (https://docs.aws.amazon.com/msk/latest/developerguide/monitoring.html).
    /// </summary>
    [JsonPropertyName("enhancedMonitoring")]
    public string? EnhancedMonitoring { get; set; }

    [JsonPropertyName("kafkaVersion")]
    public string? KafkaVersion { get; set; }

    [JsonPropertyName("loggingInfo")]
    public V1alpha1ServerlessClusterSpecProvisionedLoggingInfo? LoggingInfo { get; set; }

    [JsonPropertyName("numberOfBrokerNodes")]
    public long? NumberOfBrokerNodes { get; set; }

    /// <summary>JMX and Node monitoring for the MSK cluster.</summary>
    [JsonPropertyName("openMonitoring")]
    public V1alpha1ServerlessClusterSpecProvisionedOpenMonitoring? OpenMonitoring { get; set; }

    /// <summary>
    /// Specifies whether or not intelligent rebalancing is turned on for a newly
    /// created MSK Provisioned cluster with Express brokers. Intelligent rebalancing
    /// performs automatic partition balancing operations when you scale your clusters
    /// up or down. By default, intelligent rebalancing is ACTIVE for all new Express-based
    /// clusters.
    /// </summary>
    [JsonPropertyName("rebalancing")]
    public V1alpha1ServerlessClusterSpecProvisionedRebalancing? Rebalancing { get; set; }

    /// <summary>Controls storage mode for various supported storage tiers.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

/// <summary>Details for IAM access control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecServerlessClientAuthenticationSaslIam
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Details for client authentication using SASL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecServerlessClientAuthenticationSasl
{
    /// <summary>Details for IAM access control.</summary>
    [JsonPropertyName("iam")]
    public V1alpha1ServerlessClusterSpecServerlessClientAuthenticationSaslIam? Iam { get; set; }
}

/// <summary>Includes all client authentication information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecServerlessClientAuthentication
{
    /// <summary>Details for client authentication using SASL.</summary>
    [JsonPropertyName("sasl")]
    public V1alpha1ServerlessClusterSpecServerlessClientAuthenticationSasl? Sasl { get; set; }
}

/// <summary>The configuration of the Amazon VPCs for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecServerlessVpcConfigs
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }
}

/// <summary>Information about the serverless cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpecServerless
{
    /// <summary>Includes all client authentication information.</summary>
    [JsonPropertyName("clientAuthentication")]
    public V1alpha1ServerlessClusterSpecServerlessClientAuthentication? ClientAuthentication { get; set; }

    [JsonPropertyName("vpcConfigs")]
    public IList<V1alpha1ServerlessClusterSpecServerlessVpcConfigs>? VpcConfigs { get; set; }
}

/// <summary>ServerlessClusterSpec defines the desired state of ServerlessCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterSpec
{
    [JsonPropertyName("associatedSCRAMSecretRefs")]
    public IList<V1alpha1ServerlessClusterSpecAssociatedSCRAMSecretRefs>? AssociatedSCRAMSecretRefs { get; set; }

    [JsonPropertyName("associatedSCRAMSecrets")]
    public IList<string>? AssociatedSCRAMSecrets { get; set; }

    /// <summary>The name of the cluster.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Information about the provisioned cluster.</summary>
    [JsonPropertyName("provisioned")]
    public V1alpha1ServerlessClusterSpecProvisioned? Provisioned { get; set; }

    /// <summary>Information about the serverless cluster.</summary>
    [JsonPropertyName("serverless")]
    public V1alpha1ServerlessClusterSpecServerless? Serverless { get; set; }

    /// <summary>A map of tags that you want the cluster to have.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterStatusConditions
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

/// <summary>ServerlessClusterStatus defines the observed state of ServerlessCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ServerlessClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServerlessClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The current version of the MSK cluster.</summary>
    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    /// <summary>
    /// The state of the cluster. The possible states are ACTIVE, CREATING, DELETING,
    /// FAILED, HEALING, MAINTENANCE, REBOOTING_BROKER, and UPDATING.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The type of the cluster. The possible states are PROVISIONED or SERVERLESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ServerlessCluster is the Schema for the ServerlessClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServerlessCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServerlessClusterSpec?>, IStatus<V1alpha1ServerlessClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServerlessCluster";
    public const string KubeGroup = "kafka.services.k8s.aws";
    public const string KubePluralName = "serverlessclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerlessCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServerlessClusterSpec defines the desired state of ServerlessCluster.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServerlessClusterSpec? Spec { get; set; }

    /// <summary>ServerlessClusterStatus defines the observed state of ServerlessCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ServerlessClusterStatus? Status { get; set; }
}