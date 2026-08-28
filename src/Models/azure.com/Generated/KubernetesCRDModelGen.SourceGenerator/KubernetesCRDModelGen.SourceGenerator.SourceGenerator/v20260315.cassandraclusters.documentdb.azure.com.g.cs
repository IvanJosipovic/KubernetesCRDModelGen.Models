#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2026-03-15/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20260315CassandraClusterList : IKubernetesObject<V1ListMeta>, IItems<V20260315CassandraCluster>
{
    public const string KubeApiVersion = "v20260315";
    public const string KubeKind = "CassandraClusterList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "cassandraclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v20260315";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CassandraClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20260315CassandraCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20260315CassandraCluster> Items { get; set; }
}

/// <summary>Type: The type of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20260315CassandraClusterSpecIdentityTypeEnum>))]
public enum V20260315CassandraClusterSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecIdentity
{
    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public V20260315CassandraClusterSpecIdentityTypeEnum? Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20260315CassandraClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20260315CassandraClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// AuthenticationMethod: Which authentication method Cassandra should use to authenticate clients. &apos;None&apos; turns off
/// authentication, so should not be used except in emergencies. &apos;Cassandra&apos; is the default password based authentication.
/// The default is &apos;Cassandra&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20260315CassandraClusterSpecPropertiesAuthenticationMethodEnum>))]
public enum V20260315CassandraClusterSpecPropertiesAuthenticationMethodEnum
{
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "Ldap"), JsonStringEnumMemberName("Ldap")]
    Ldap,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>AutoReplicate: The form of AutoReplicate that is being used by this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20260315CassandraClusterSpecPropertiesAutoReplicateEnum>))]
public enum V20260315CassandraClusterSpecPropertiesAutoReplicateEnum
{
    [EnumMember(Value = "AllKeyspaces"), JsonStringEnumMemberName("AllKeyspaces")]
    AllKeyspaces,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemKeyspaces"), JsonStringEnumMemberName("SystemKeyspaces")]
    SystemKeyspaces
}

/// <summary>AzureConnectionMethod: How to connect to the azure services needed for running the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20260315CassandraClusterSpecPropertiesAzureConnectionMethodEnum>))]
public enum V20260315CassandraClusterSpecPropertiesAzureConnectionMethodEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "VPN"), JsonStringEnumMemberName("VPN")]
    VPN
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesBackupSchedules
{
    /// <summary>CronExpression: The cron expression that defines when you want to back up your data.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>RetentionInHours: The retention period (hours) of the backups. If you want to retain data forever, set retention to 0.</summary>
    [JsonPropertyName("retentionInHours")]
    public int? RetentionInHours { get; set; }

    /// <summary>ScheduleName: The unique identifier of backup schedule.</summary>
    [JsonPropertyName("scheduleName")]
    public string? ScheduleName { get; set; }
}

/// <summary>Pem: PEM formatted public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesClientCertificatesPem
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesClientCertificates
{
    /// <summary>Pem: PEM formatted public key.</summary>
    [JsonPropertyName("pem")]
    public V20260315CassandraClusterSpecPropertiesClientCertificatesPem? Pem { get; set; }
}

/// <summary>
/// DelegatedManagementSubnetReference: Resource id of a subnet that this cluster&apos;s management service should have its
/// network interface attached to. The subnet must be routable to all subnets that will be delegated to data centers. The
/// resource id must be of the form &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource
/// group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt; &apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesDelegatedManagementSubnetReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Pem: PEM formatted public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesExternalGossipCertificatesPem
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesExternalGossipCertificates
{
    /// <summary>Pem: PEM formatted public key.</summary>
    [JsonPropertyName("pem")]
    public V20260315CassandraClusterSpecPropertiesExternalGossipCertificatesPem? Pem { get; set; }
}

/// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesExternalSeedNodesIpAddressFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesExternalSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddressFromConfig")]
    public V20260315CassandraClusterSpecPropertiesExternalSeedNodesIpAddressFromConfig? IpAddressFromConfig { get; set; }
}

/// <summary>
/// InitialCassandraAdminPassword: Initial password for clients connecting as admin to the cluster. Should be changed after
/// cluster creation. Returns null on GET. This field only applies when the authenticationMethod field is &apos;Cassandra&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesInitialCassandraAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesPrometheusEndpointIpAddressFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
/// nodes can be reached.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesPrometheusEndpoint
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddressFromConfig")]
    public V20260315CassandraClusterSpecPropertiesPrometheusEndpointIpAddressFromConfig? IpAddressFromConfig { get; set; }
}

/// <summary>
/// RestoreFromBackupReference: To create an empty cluster, omit this field or set it to null. To restore a backup into a
/// new cluster, set this field to the resource id of the backup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecPropertiesRestoreFromBackupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ScheduledEventStrategy: How the nodes in the cluster react to scheduled events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20260315CassandraClusterSpecPropertiesScheduledEventStrategyEnum>))]
public enum V20260315CassandraClusterSpecPropertiesScheduledEventStrategyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "StopAny"), JsonStringEnumMemberName("StopAny")]
    StopAny,
    [EnumMember(Value = "StopByRack"), JsonStringEnumMemberName("StopByRack")]
    StopByRack
}

/// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpecProperties
{
    /// <summary>
    /// AuthenticationMethod: Which authentication method Cassandra should use to authenticate clients. &apos;None&apos; turns off
    /// authentication, so should not be used except in emergencies. &apos;Cassandra&apos; is the default password based authentication.
    /// The default is &apos;Cassandra&apos;.
    /// </summary>
    [JsonPropertyName("authenticationMethod")]
    public V20260315CassandraClusterSpecPropertiesAuthenticationMethodEnum? AuthenticationMethod { get; set; }

    /// <summary>AutoReplicate: The form of AutoReplicate that is being used by this cluster.</summary>
    [JsonPropertyName("autoReplicate")]
    public V20260315CassandraClusterSpecPropertiesAutoReplicateEnum? AutoReplicate { get; set; }

    /// <summary>AzureConnectionMethod: How to connect to the azure services needed for running the cluster</summary>
    [JsonPropertyName("azureConnectionMethod")]
    public V20260315CassandraClusterSpecPropertiesAzureConnectionMethodEnum? AzureConnectionMethod { get; set; }

    /// <summary>BackupSchedules: List of backup schedules that define when you want to back up your data.</summary>
    [JsonPropertyName("backupSchedules")]
    public IList<V20260315CassandraClusterSpecPropertiesBackupSchedules>? BackupSchedules { get; set; }

    /// <summary>CassandraAuditLoggingEnabled: Whether Cassandra audit logging is enabled</summary>
    [JsonPropertyName("cassandraAuditLoggingEnabled")]
    public bool? CassandraAuditLoggingEnabled { get; set; }

    /// <summary>
    /// CassandraVersion: Which version of Cassandra should this cluster converge to running (e.g., 3.11). When updated, the
    /// cluster may take some time to migrate to the new version.
    /// </summary>
    [JsonPropertyName("cassandraVersion")]
    public string? CassandraVersion { get; set; }

    /// <summary>
    /// ClientCertificates: List of TLS certificates used to authorize clients connecting to the cluster. All connections are
    /// TLS encrypted whether clientCertificates is set or not, but if clientCertificates is set, the managed Cassandra cluster
    /// will reject all connections not bearing a TLS client certificate that can be validated from one or more of the public
    /// certificates in this property.
    /// </summary>
    [JsonPropertyName("clientCertificates")]
    public IList<V20260315CassandraClusterSpecPropertiesClientCertificates>? ClientCertificates { get; set; }

    /// <summary>
    /// ClusterNameOverride: If you need to set the clusterName property in cassandra.yaml to something besides the resource
    /// name of the cluster, set the value to use on this property.
    /// </summary>
    [JsonPropertyName("clusterNameOverride")]
    public string? ClusterNameOverride { get; set; }

    /// <summary>
    /// DelegatedManagementSubnetReference: Resource id of a subnet that this cluster&apos;s management service should have its
    /// network interface attached to. The subnet must be routable to all subnets that will be delegated to data centers. The
    /// resource id must be of the form &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource
    /// group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt; &apos;
    /// </summary>
    [JsonPropertyName("delegatedManagementSubnetReference")]
    public V20260315CassandraClusterSpecPropertiesDelegatedManagementSubnetReference? DelegatedManagementSubnetReference { get; set; }

    /// <summary>Extensions: Extensions to be added or updated on cluster.</summary>
    [JsonPropertyName("extensions")]
    public IList<string>? Extensions { get; set; }

    /// <summary>
    /// ExternalDataCenters: List of the data center names for unmanaged data centers in this cluster to be included in
    /// auto-replication.
    /// </summary>
    [JsonPropertyName("externalDataCenters")]
    public IList<string>? ExternalDataCenters { get; set; }

    /// <summary>
    /// ExternalGossipCertificates: List of TLS certificates used to authorize gossip from unmanaged data centers. The TLS
    /// certificates of all nodes in unmanaged data centers must be verifiable using one of the certificates provided in this
    /// property.
    /// </summary>
    [JsonPropertyName("externalGossipCertificates")]
    public IList<V20260315CassandraClusterSpecPropertiesExternalGossipCertificates>? ExternalGossipCertificates { get; set; }

    /// <summary>
    /// ExternalSeedNodes: List of IP addresses of seed nodes in unmanaged data centers. These will be added to the seed node
    /// lists of all managed nodes.
    /// </summary>
    [JsonPropertyName("externalSeedNodes")]
    public IList<V20260315CassandraClusterSpecPropertiesExternalSeedNodes>? ExternalSeedNodes { get; set; }

    /// <summary>HoursBetweenBackups: (Deprecated) Number of hours to wait between taking a backup of the cluster.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public int? HoursBetweenBackups { get; set; }

    /// <summary>
    /// InitialCassandraAdminPassword: Initial password for clients connecting as admin to the cluster. Should be changed after
    /// cluster creation. Returns null on GET. This field only applies when the authenticationMethod field is &apos;Cassandra&apos;.
    /// </summary>
    [JsonPropertyName("initialCassandraAdminPassword")]
    public V20260315CassandraClusterSpecPropertiesInitialCassandraAdminPassword? InitialCassandraAdminPassword { get; set; }

    /// <summary>
    /// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
    /// nodes can be reached.
    /// </summary>
    [JsonPropertyName("prometheusEndpoint")]
    public V20260315CassandraClusterSpecPropertiesPrometheusEndpoint? PrometheusEndpoint { get; set; }

    /// <summary>
    /// RepairEnabled: Should automatic repairs run on this cluster? If omitted, this is true, and should stay true unless you
    /// are running a hybrid cluster where you are already doing your own repairs.
    /// </summary>
    [JsonPropertyName("repairEnabled")]
    public bool? RepairEnabled { get; set; }

    /// <summary>
    /// RestoreFromBackupReference: To create an empty cluster, omit this field or set it to null. To restore a backup into a
    /// new cluster, set this field to the resource id of the backup.
    /// </summary>
    [JsonPropertyName("restoreFromBackupReference")]
    public V20260315CassandraClusterSpecPropertiesRestoreFromBackupReference? RestoreFromBackupReference { get; set; }

    /// <summary>ScheduledEventStrategy: How the nodes in the cluster react to scheduled events</summary>
    [JsonPropertyName("scheduledEventStrategy")]
    public V20260315CassandraClusterSpecPropertiesScheduledEventStrategyEnum? ScheduledEventStrategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V20260315CassandraClusterSpecIdentity? Identity { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20260315CassandraClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20260315CassandraClusterSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
    [JsonPropertyName("properties")]
    public V20260315CassandraClusterSpecProperties? Properties { get; set; }

    /// <summary>
    /// Tags: Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this
    /// resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no
    /// greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template
    /// type is set with \&quot;defaultExperience\&quot;: \&quot;Cassandra\&quot;. Current \&quot;defaultExperience\&quot; values also include \&quot;Table\&quot;,
    /// \&quot;Graph\&quot;, \&quot;DocumentDB\&quot;, and \&quot;MongoDB\&quot;.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusIdentity
{
    /// <summary>PrincipalId: The object id of the identity resource.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant id of the resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesBackupSchedules
{
    /// <summary>CronExpression: The cron expression that defines when you want to back up your data.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>RetentionInHours: The retention period (hours) of the backups. If you want to retain data forever, set retention to 0.</summary>
    [JsonPropertyName("retentionInHours")]
    public int? RetentionInHours { get; set; }

    /// <summary>ScheduleName: The unique identifier of backup schedule.</summary>
    [JsonPropertyName("scheduleName")]
    public string? ScheduleName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesClientCertificates
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesExternalGossipCertificates
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesExternalSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesGossipCertificates
{
}

/// <summary>
/// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
/// nodes can be reached.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesPrometheusEndpoint
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>ProvisionError: Error related to resource provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesProvisionError
{
    /// <summary>AdditionalErrorInfo: Additional information about the error.</summary>
    [JsonPropertyName("additionalErrorInfo")]
    public string? AdditionalErrorInfo { get; set; }

    /// <summary>Code: The code of error that occurred.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The message of the error.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target resource of the error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusPropertiesSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusProperties
{
    /// <summary>
    /// AuthenticationMethod: Which authentication method Cassandra should use to authenticate clients. &apos;None&apos; turns off
    /// authentication, so should not be used except in emergencies. &apos;Cassandra&apos; is the default password based authentication.
    /// The default is &apos;Cassandra&apos;.
    /// </summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>AutoReplicate: The form of AutoReplicate that is being used by this cluster.</summary>
    [JsonPropertyName("autoReplicate")]
    public string? AutoReplicate { get; set; }

    /// <summary>AzureConnectionMethod: How to connect to the azure services needed for running the cluster</summary>
    [JsonPropertyName("azureConnectionMethod")]
    public string? AzureConnectionMethod { get; set; }

    /// <summary>BackupSchedules: List of backup schedules that define when you want to back up your data.</summary>
    [JsonPropertyName("backupSchedules")]
    public IList<V20260315CassandraClusterStatusPropertiesBackupSchedules>? BackupSchedules { get; set; }

    /// <summary>CassandraAuditLoggingEnabled: Whether Cassandra audit logging is enabled</summary>
    [JsonPropertyName("cassandraAuditLoggingEnabled")]
    public bool? CassandraAuditLoggingEnabled { get; set; }

    /// <summary>
    /// CassandraVersion: Which version of Cassandra should this cluster converge to running (e.g., 3.11). When updated, the
    /// cluster may take some time to migrate to the new version.
    /// </summary>
    [JsonPropertyName("cassandraVersion")]
    public string? CassandraVersion { get; set; }

    /// <summary>
    /// ClientCertificates: List of TLS certificates used to authorize clients connecting to the cluster. All connections are
    /// TLS encrypted whether clientCertificates is set or not, but if clientCertificates is set, the managed Cassandra cluster
    /// will reject all connections not bearing a TLS client certificate that can be validated from one or more of the public
    /// certificates in this property.
    /// </summary>
    [JsonPropertyName("clientCertificates")]
    public IList<V20260315CassandraClusterStatusPropertiesClientCertificates>? ClientCertificates { get; set; }

    /// <summary>
    /// ClusterNameOverride: If you need to set the clusterName property in cassandra.yaml to something besides the resource
    /// name of the cluster, set the value to use on this property.
    /// </summary>
    [JsonPropertyName("clusterNameOverride")]
    public string? ClusterNameOverride { get; set; }

    /// <summary>Deallocated: Whether the cluster and associated data centers has been deallocated.</summary>
    [JsonPropertyName("deallocated")]
    public bool? Deallocated { get; set; }

    /// <summary>
    /// DelegatedManagementSubnetId: Resource id of a subnet that this cluster&apos;s management service should have its network
    /// interface attached to. The subnet must be routable to all subnets that will be delegated to data centers. The resource
    /// id must be of the form &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource
    /// group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt; &apos;
    /// </summary>
    [JsonPropertyName("delegatedManagementSubnetId")]
    public string? DelegatedManagementSubnetId { get; set; }

    /// <summary>Extensions: Extensions to be added or updated on cluster.</summary>
    [JsonPropertyName("extensions")]
    public IList<string>? Extensions { get; set; }

    /// <summary>
    /// ExternalDataCenters: List of the data center names for unmanaged data centers in this cluster to be included in
    /// auto-replication.
    /// </summary>
    [JsonPropertyName("externalDataCenters")]
    public IList<string>? ExternalDataCenters { get; set; }

    /// <summary>
    /// ExternalGossipCertificates: List of TLS certificates used to authorize gossip from unmanaged data centers. The TLS
    /// certificates of all nodes in unmanaged data centers must be verifiable using one of the certificates provided in this
    /// property.
    /// </summary>
    [JsonPropertyName("externalGossipCertificates")]
    public IList<V20260315CassandraClusterStatusPropertiesExternalGossipCertificates>? ExternalGossipCertificates { get; set; }

    /// <summary>
    /// ExternalSeedNodes: List of IP addresses of seed nodes in unmanaged data centers. These will be added to the seed node
    /// lists of all managed nodes.
    /// </summary>
    [JsonPropertyName("externalSeedNodes")]
    public IList<V20260315CassandraClusterStatusPropertiesExternalSeedNodes>? ExternalSeedNodes { get; set; }

    /// <summary>
    /// GossipCertificates: List of TLS certificates that unmanaged nodes must trust for gossip with managed nodes. All managed
    /// nodes will present TLS client certificates that are verifiable using one of the certificates provided in this property.
    /// </summary>
    [JsonPropertyName("gossipCertificates")]
    public IList<V20260315CassandraClusterStatusPropertiesGossipCertificates>? GossipCertificates { get; set; }

    /// <summary>HoursBetweenBackups: (Deprecated) Number of hours to wait between taking a backup of the cluster.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public int? HoursBetweenBackups { get; set; }

    /// <summary>
    /// PrivateLinkResourceId: If the Connection Method is Vpn, this is the Id of the private link resource that the datacenters
    /// need to connect to.
    /// </summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary>
    /// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
    /// nodes can be reached.
    /// </summary>
    [JsonPropertyName("prometheusEndpoint")]
    public V20260315CassandraClusterStatusPropertiesPrometheusEndpoint? PrometheusEndpoint { get; set; }

    /// <summary>ProvisionError: Error related to resource provisioning.</summary>
    [JsonPropertyName("provisionError")]
    public V20260315CassandraClusterStatusPropertiesProvisionError? ProvisionError { get; set; }

    /// <summary>ProvisioningState: The status of the resource at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RepairEnabled: Should automatic repairs run on this cluster? If omitted, this is true, and should stay true unless you
    /// are running a hybrid cluster where you are already doing your own repairs.
    /// </summary>
    [JsonPropertyName("repairEnabled")]
    public bool? RepairEnabled { get; set; }

    /// <summary>
    /// RestoreFromBackupId: To create an empty cluster, omit this field or set it to null. To restore a backup into a new
    /// cluster, set this field to the resource id of the backup.
    /// </summary>
    [JsonPropertyName("restoreFromBackupId")]
    public string? RestoreFromBackupId { get; set; }

    /// <summary>ScheduledEventStrategy: How the nodes in the cluster react to scheduled events</summary>
    [JsonPropertyName("scheduledEventStrategy")]
    public string? ScheduledEventStrategy { get; set; }

    /// <summary>
    /// SeedNodes: List of IP addresses of seed nodes in the managed data centers. These should be added to the seed node lists
    /// of all unmanaged nodes.
    /// </summary>
    [JsonPropertyName("seedNodes")]
    public IList<V20260315CassandraClusterStatusPropertiesSeedNodes>? SeedNodes { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20260315CassandraClusterStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20260315CassandraClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V20260315CassandraClusterStatusIdentity? Identity { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
    [JsonPropertyName("properties")]
    public V20260315CassandraClusterStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20260315CassandraClusterStatusSystemData? SystemData { get; set; }

    /// <summary>
    /// Tags: Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this
    /// resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no
    /// greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template
    /// type is set with \&quot;defaultExperience\&quot;: \&quot;Cassandra\&quot;. Current \&quot;defaultExperience\&quot; values also include \&quot;Table\&quot;,
    /// \&quot;Graph\&quot;, \&quot;DocumentDB\&quot;, and \&quot;MongoDB\&quot;.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2026-03-15/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20260315CassandraCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V20260315CassandraClusterSpec?>, IStatus<V20260315CassandraClusterStatus?>
{
    public const string KubeApiVersion = "v20260315";
    public const string KubeKind = "CassandraCluster";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "cassandraclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v20260315";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CassandraCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20260315CassandraClusterSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20260315CassandraClusterStatus? Status { get; set; }
}