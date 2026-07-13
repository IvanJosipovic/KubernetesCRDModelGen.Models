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
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2025-10-15/managedCassandra.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251015CassandraClusterList : IKubernetesObject<V1ListMeta>, IItems<V20251015CassandraCluster>
{
    public const string KubeApiVersion = "v20251015";
    public const string KubeKind = "CassandraClusterList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "cassandraclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v20251015";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CassandraClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251015CassandraCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251015CassandraCluster> Items { get; set; }
}

/// <summary>Type: The type of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251015CassandraClusterSpecIdentityTypeEnum>))]
public enum V20251015CassandraClusterSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned
}

/// <summary>Identity: Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecIdentity
{
    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public V20251015CassandraClusterSpecIdentityTypeEnum? Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20251015CassandraClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20251015CassandraClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecOwner
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251015CassandraClusterSpecPropertiesAuthenticationMethodEnum>))]
public enum V20251015CassandraClusterSpecPropertiesAuthenticationMethodEnum
{
    [EnumMember(Value = "Cassandra"), JsonStringEnumMemberName("Cassandra")]
    Cassandra,
    [EnumMember(Value = "Ldap"), JsonStringEnumMemberName("Ldap")]
    Ldap,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>AzureConnectionMethod: How to connect to the azure services needed for running the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251015CassandraClusterSpecPropertiesAzureConnectionMethodEnum>))]
public enum V20251015CassandraClusterSpecPropertiesAzureConnectionMethodEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "VPN"), JsonStringEnumMemberName("VPN")]
    VPN
}

/// <summary>Pem: PEM formatted public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesClientCertificatesPem
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesClientCertificates
{
    /// <summary>Pem: PEM formatted public key.</summary>
    [JsonPropertyName("pem")]
    public V20251015CassandraClusterSpecPropertiesClientCertificatesPem? Pem { get; set; }
}

/// <summary>
/// DelegatedManagementSubnetReference: Resource id of a subnet that this cluster&apos;s management service should have its
/// network interface attached to. The subnet must be routable to all subnets that will be delegated to data centers. The
/// resource id must be of the form &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource
/// group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt; &apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesDelegatedManagementSubnetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesExternalGossipCertificatesPem
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesExternalGossipCertificates
{
    /// <summary>Pem: PEM formatted public key.</summary>
    [JsonPropertyName("pem")]
    public V20251015CassandraClusterSpecPropertiesExternalGossipCertificatesPem? Pem { get; set; }
}

/// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesExternalSeedNodesIpAddressFromConfig
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesExternalSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddressFromConfig")]
    public V20251015CassandraClusterSpecPropertiesExternalSeedNodesIpAddressFromConfig? IpAddressFromConfig { get; set; }
}

/// <summary>
/// InitialCassandraAdminPassword: Initial password for clients connecting as admin to the cluster. Should be changed after
/// cluster creation. Returns null on GET. This field only applies when the authenticationMethod field is &apos;Cassandra&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesInitialCassandraAdminPassword
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesPrometheusEndpointIpAddressFromConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesPrometheusEndpoint
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IpAddressFromConfig: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddressFromConfig")]
    public V20251015CassandraClusterSpecPropertiesPrometheusEndpointIpAddressFromConfig? IpAddressFromConfig { get; set; }
}

/// <summary>
/// RestoreFromBackupReference: To create an empty cluster, omit this field or set it to null. To restore a backup into a
/// new cluster, set this field to the resource id of the backup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecPropertiesRestoreFromBackupReference
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

/// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpecProperties
{
    /// <summary>
    /// AuthenticationMethod: Which authentication method Cassandra should use to authenticate clients. &apos;None&apos; turns off
    /// authentication, so should not be used except in emergencies. &apos;Cassandra&apos; is the default password based authentication.
    /// The default is &apos;Cassandra&apos;.
    /// </summary>
    [JsonPropertyName("authenticationMethod")]
    public V20251015CassandraClusterSpecPropertiesAuthenticationMethodEnum? AuthenticationMethod { get; set; }

    /// <summary>AzureConnectionMethod: How to connect to the azure services needed for running the cluster</summary>
    [JsonPropertyName("azureConnectionMethod")]
    public V20251015CassandraClusterSpecPropertiesAzureConnectionMethodEnum? AzureConnectionMethod { get; set; }

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
    public IList<V20251015CassandraClusterSpecPropertiesClientCertificates>? ClientCertificates { get; set; }

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
    public V20251015CassandraClusterSpecPropertiesDelegatedManagementSubnetReference? DelegatedManagementSubnetReference { get; set; }

    /// <summary>
    /// ExternalGossipCertificates: List of TLS certificates used to authorize gossip from unmanaged data centers. The TLS
    /// certificates of all nodes in unmanaged data centers must be verifiable using one of the certificates provided in this
    /// property.
    /// </summary>
    [JsonPropertyName("externalGossipCertificates")]
    public IList<V20251015CassandraClusterSpecPropertiesExternalGossipCertificates>? ExternalGossipCertificates { get; set; }

    /// <summary>
    /// ExternalSeedNodes: List of IP addresses of seed nodes in unmanaged data centers. These will be added to the seed node
    /// lists of all managed nodes.
    /// </summary>
    [JsonPropertyName("externalSeedNodes")]
    public IList<V20251015CassandraClusterSpecPropertiesExternalSeedNodes>? ExternalSeedNodes { get; set; }

    /// <summary>HoursBetweenBackups: (Deprecated) Number of hours to wait between taking a backup of the cluster.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public int? HoursBetweenBackups { get; set; }

    /// <summary>
    /// InitialCassandraAdminPassword: Initial password for clients connecting as admin to the cluster. Should be changed after
    /// cluster creation. Returns null on GET. This field only applies when the authenticationMethod field is &apos;Cassandra&apos;.
    /// </summary>
    [JsonPropertyName("initialCassandraAdminPassword")]
    public V20251015CassandraClusterSpecPropertiesInitialCassandraAdminPassword? InitialCassandraAdminPassword { get; set; }

    /// <summary>
    /// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
    /// nodes can be reached.
    /// </summary>
    [JsonPropertyName("prometheusEndpoint")]
    public V20251015CassandraClusterSpecPropertiesPrometheusEndpoint? PrometheusEndpoint { get; set; }

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
    public V20251015CassandraClusterSpecPropertiesRestoreFromBackupReference? RestoreFromBackupReference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V20251015CassandraClusterSpecIdentity? Identity { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251015CassandraClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251015CassandraClusterSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
    [JsonPropertyName("properties")]
    public V20251015CassandraClusterSpecProperties? Properties { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusIdentity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesClientCertificates
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesExternalGossipCertificates
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesExternalSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesGossipCertificates
{
}

/// <summary>
/// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
/// nodes can be reached.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesPrometheusEndpoint
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>ProvisionError: Error related to resource provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesProvisionError
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusPropertiesSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatusProperties
{
    /// <summary>
    /// AuthenticationMethod: Which authentication method Cassandra should use to authenticate clients. &apos;None&apos; turns off
    /// authentication, so should not be used except in emergencies. &apos;Cassandra&apos; is the default password based authentication.
    /// The default is &apos;Cassandra&apos;.
    /// </summary>
    [JsonPropertyName("authenticationMethod")]
    public string? AuthenticationMethod { get; set; }

    /// <summary>AzureConnectionMethod: How to connect to the azure services needed for running the cluster</summary>
    [JsonPropertyName("azureConnectionMethod")]
    public string? AzureConnectionMethod { get; set; }

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
    public IList<V20251015CassandraClusterStatusPropertiesClientCertificates>? ClientCertificates { get; set; }

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

    /// <summary>
    /// ExternalGossipCertificates: List of TLS certificates used to authorize gossip from unmanaged data centers. The TLS
    /// certificates of all nodes in unmanaged data centers must be verifiable using one of the certificates provided in this
    /// property.
    /// </summary>
    [JsonPropertyName("externalGossipCertificates")]
    public IList<V20251015CassandraClusterStatusPropertiesExternalGossipCertificates>? ExternalGossipCertificates { get; set; }

    /// <summary>
    /// ExternalSeedNodes: List of IP addresses of seed nodes in unmanaged data centers. These will be added to the seed node
    /// lists of all managed nodes.
    /// </summary>
    [JsonPropertyName("externalSeedNodes")]
    public IList<V20251015CassandraClusterStatusPropertiesExternalSeedNodes>? ExternalSeedNodes { get; set; }

    /// <summary>
    /// GossipCertificates: List of TLS certificates that unmanaged nodes must trust for gossip with managed nodes. All managed
    /// nodes will present TLS client certificates that are verifiable using one of the certificates provided in this property.
    /// </summary>
    [JsonPropertyName("gossipCertificates")]
    public IList<V20251015CassandraClusterStatusPropertiesGossipCertificates>? GossipCertificates { get; set; }

    /// <summary>HoursBetweenBackups: (Deprecated) Number of hours to wait between taking a backup of the cluster.</summary>
    [JsonPropertyName("hoursBetweenBackups")]
    public int? HoursBetweenBackups { get; set; }

    /// <summary>
    /// PrivateLinkResourceId: If the Connection Method is VPN, this is the Id of the private link resource that the datacenters
    /// need to connect to.
    /// </summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary>
    /// PrometheusEndpoint: Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra
    /// nodes can be reached.
    /// </summary>
    [JsonPropertyName("prometheusEndpoint")]
    public V20251015CassandraClusterStatusPropertiesPrometheusEndpoint? PrometheusEndpoint { get; set; }

    /// <summary>ProvisionError: Error related to resource provisioning.</summary>
    [JsonPropertyName("provisionError")]
    public V20251015CassandraClusterStatusPropertiesProvisionError? ProvisionError { get; set; }

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

    /// <summary>
    /// SeedNodes: List of IP addresses of seed nodes in the managed data centers. These should be added to the seed node lists
    /// of all unmanaged nodes.
    /// </summary>
    [JsonPropertyName("seedNodes")]
    public IList<V20251015CassandraClusterStatusPropertiesSeedNodes>? SeedNodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraClusterStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20251015CassandraClusterStatusConditions>? Conditions { get; set; }

    /// <summary>Id: The unique resource identifier of the ARM resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V20251015CassandraClusterStatusIdentity? Identity { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the ARM resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Properties of a managed Cassandra cluster.</summary>
    [JsonPropertyName("properties")]
    public V20251015CassandraClusterStatusProperties? Properties { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2025-10-15/managedCassandra.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251015CassandraCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V20251015CassandraClusterSpec?>, IStatus<V20251015CassandraClusterStatus?>
{
    public const string KubeApiVersion = "v20251015";
    public const string KubeKind = "CassandraCluster";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "cassandraclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v20251015";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CassandraCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20251015CassandraClusterSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20251015CassandraClusterStatus? Status { get; set; }
}