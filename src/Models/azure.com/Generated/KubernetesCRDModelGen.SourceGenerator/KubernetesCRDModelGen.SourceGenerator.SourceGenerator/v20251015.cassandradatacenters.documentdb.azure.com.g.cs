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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251015CassandraDataCenterList : IKubernetesObject<V1ListMeta>, IItems<V20251015CassandraDataCenter>
{
    public const string KubeApiVersion = "v20251015";
    public const string KubeKind = "CassandraDataCenterList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "cassandradatacenters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v20251015";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CassandraDataCenterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251015CassandraDataCenter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251015CassandraDataCenter> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecOperatorSpecConfigMapExpressions
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
public partial class V20251015CassandraDataCenterSpecOperatorSpecSecretExpressions
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
public partial class V20251015CassandraDataCenterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20251015CassandraDataCenterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20251015CassandraDataCenterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a documentdb.azure.com/CassandraCluster resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Pem: PEM formatted public key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapPropertiesServerCertificatesPem
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
public partial class V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapPropertiesServerCertificates
{
    /// <summary>Pem: PEM formatted public key.</summary>
    [JsonPropertyName("pem")]
    public V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapPropertiesServerCertificatesPem? Pem { get; set; }
}

/// <summary>ServiceUserPassword: Password of the look up user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapPropertiesServiceUserPassword
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

/// <summary>AuthenticationMethodLdapProperties: Ldap authentication method properties. This feature is in preview.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapProperties
{
    /// <summary>ConnectionTimeoutInMs: Timeout for connecting to the LDAP server in miliseconds. The default is 5000 ms.</summary>
    [JsonPropertyName("connectionTimeoutInMs")]
    public int? ConnectionTimeoutInMs { get; set; }

    /// <summary>SearchBaseDistinguishedName: Distinguished name of the object to start the recursive search of users from.</summary>
    [JsonPropertyName("searchBaseDistinguishedName")]
    public string? SearchBaseDistinguishedName { get; set; }

    /// <summary>
    /// SearchFilterTemplate: Template to use for searching. Defaults to (cn=%s) where %s will be replaced by the username used
    /// to login.
    /// </summary>
    [JsonPropertyName("searchFilterTemplate")]
    public string? SearchFilterTemplate { get; set; }

    [JsonPropertyName("serverCertificates")]
    public IList<V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapPropertiesServerCertificates>? ServerCertificates { get; set; }

    /// <summary>ServerHostname: Hostname of the LDAP server.</summary>
    [JsonPropertyName("serverHostname")]
    public string? ServerHostname { get; set; }

    /// <summary>ServerPort: Port of the LDAP server.</summary>
    [JsonPropertyName("serverPort")]
    public int? ServerPort { get; set; }

    /// <summary>
    /// ServiceUserDistinguishedName: Distinguished name of the look up user account, who can look up user details on
    /// authentication.
    /// </summary>
    [JsonPropertyName("serviceUserDistinguishedName")]
    public string? ServiceUserDistinguishedName { get; set; }

    /// <summary>ServiceUserPassword: Password of the look up user.</summary>
    [JsonPropertyName("serviceUserPassword")]
    public V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapPropertiesServiceUserPassword? ServiceUserPassword { get; set; }
}

/// <summary>
/// BackupStorageCustomerKeyUriFromConfig: Indicates the Key Uri of the customer key to use for encryption of the backup
/// storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesBackupStorageCustomerKeyUriFromConfig
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
/// DelegatedSubnetReference: Resource id of a subnet the nodes in this data center should have their network interfaces
/// connected to. The subnet must be in the same region specified in &apos;dataCenterLocation&apos; and must be able to route to the
/// subnet specified in the cluster&apos;s &apos;delegatedManagementSubnetId&apos; property. This resource id will be of the form
/// &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual
/// network&gt;/subnets/&lt;subnet&gt; &apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesDelegatedSubnetReference
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

/// <summary>
/// ManagedDiskCustomerKeyUriReference: Key uri to use for encryption of managed disks. Ensure the system assigned identity
/// of the cluster has been assigned appropriate permissions(key get/wrap/unwrap permissions) on the key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesManagedDiskCustomerKeyUriReference
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

/// <summary>PrivateEndpointIpAddressFromConfig: Ip of the VPN Endpoint for this data center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecPropertiesPrivateEndpointIpAddressFromConfig
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

/// <summary>Properties: Properties of a managed Cassandra data center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpecProperties
{
    /// <summary>AuthenticationMethodLdapProperties: Ldap authentication method properties. This feature is in preview.</summary>
    [JsonPropertyName("authenticationMethodLdapProperties")]
    public V20251015CassandraDataCenterSpecPropertiesAuthenticationMethodLdapProperties? AuthenticationMethodLdapProperties { get; set; }

    /// <summary>
    /// AvailabilityZone: If the data center has Availability Zone support, apply it to the Virtual Machine ScaleSet that host
    /// the cassandra data center virtual machines.
    /// </summary>
    [JsonPropertyName("availabilityZone")]
    public bool? AvailabilityZone { get; set; }

    /// <summary>
    /// BackupStorageCustomerKeyUri: Indicates the Key Uri of the customer key to use for encryption of the backup storage
    /// account.
    /// </summary>
    [JsonPropertyName("backupStorageCustomerKeyUri")]
    public string? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>
    /// BackupStorageCustomerKeyUriFromConfig: Indicates the Key Uri of the customer key to use for encryption of the backup
    /// storage account.
    /// </summary>
    [JsonPropertyName("backupStorageCustomerKeyUriFromConfig")]
    public V20251015CassandraDataCenterSpecPropertiesBackupStorageCustomerKeyUriFromConfig? BackupStorageCustomerKeyUriFromConfig { get; set; }

    /// <summary>
    /// Base64EncodedCassandraYamlFragment: A fragment of a cassandra.yaml configuration file to be included in the
    /// cassandra.yaml for all nodes in this data center. The fragment should be Base64 encoded, and only a subset of keys are
    /// allowed.
    /// </summary>
    [JsonPropertyName("base64EncodedCassandraYamlFragment")]
    public string? Base64EncodedCassandraYamlFragment { get; set; }

    /// <summary>DataCenterLocation: The region this data center should be created in.</summary>
    [JsonPropertyName("dataCenterLocation")]
    public string? DataCenterLocation { get; set; }

    /// <summary>
    /// DelegatedSubnetReference: Resource id of a subnet the nodes in this data center should have their network interfaces
    /// connected to. The subnet must be in the same region specified in &apos;dataCenterLocation&apos; and must be able to route to the
    /// subnet specified in the cluster&apos;s &apos;delegatedManagementSubnetId&apos; property. This resource id will be of the form
    /// &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual
    /// network&gt;/subnets/&lt;subnet&gt; &apos;.
    /// </summary>
    [JsonPropertyName("delegatedSubnetReference")]
    public V20251015CassandraDataCenterSpecPropertiesDelegatedSubnetReference? DelegatedSubnetReference { get; set; }

    /// <summary>DiskCapacity: Number of disks attached to each node. Default is 4.</summary>
    [JsonPropertyName("diskCapacity")]
    public int? DiskCapacity { get; set; }

    /// <summary>DiskSku: Disk SKU used for data centers. Default value is P30.</summary>
    [JsonPropertyName("diskSku")]
    public string? DiskSku { get; set; }

    /// <summary>
    /// ManagedDiskCustomerKeyUriReference: Key uri to use for encryption of managed disks. Ensure the system assigned identity
    /// of the cluster has been assigned appropriate permissions(key get/wrap/unwrap permissions) on the key.
    /// </summary>
    [JsonPropertyName("managedDiskCustomerKeyUriReference")]
    public V20251015CassandraDataCenterSpecPropertiesManagedDiskCustomerKeyUriReference? ManagedDiskCustomerKeyUriReference { get; set; }

    /// <summary>
    /// NodeCount: The number of nodes the data center should have. This is the desired number. After it is set, it may take
    /// some time for the data center to be scaled to match. To monitor the number of nodes and their status, use the
    /// fetchNodeStatus method on the cluster.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>PrivateEndpointIpAddress: Ip of the VPN Endpoint for this data center.</summary>
    [JsonPropertyName("privateEndpointIpAddress")]
    public string? PrivateEndpointIpAddress { get; set; }

    /// <summary>PrivateEndpointIpAddressFromConfig: Ip of the VPN Endpoint for this data center.</summary>
    [JsonPropertyName("privateEndpointIpAddressFromConfig")]
    public V20251015CassandraDataCenterSpecPropertiesPrivateEndpointIpAddressFromConfig? PrivateEndpointIpAddressFromConfig { get; set; }

    /// <summary>Sku: Virtual Machine SKU used for data centers. Default value is Standard_DS14_v2</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251015CassandraDataCenterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/CassandraCluster resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251015CassandraDataCenterSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of a managed Cassandra data center.</summary>
    [JsonPropertyName("properties")]
    public V20251015CassandraDataCenterSpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterStatusPropertiesAuthenticationMethodLdapPropertiesServerCertificates
{
}

/// <summary>AuthenticationMethodLdapProperties: Ldap authentication method properties. This feature is in preview.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterStatusPropertiesAuthenticationMethodLdapProperties
{
    /// <summary>ConnectionTimeoutInMs: Timeout for connecting to the LDAP server in miliseconds. The default is 5000 ms.</summary>
    [JsonPropertyName("connectionTimeoutInMs")]
    public int? ConnectionTimeoutInMs { get; set; }

    /// <summary>SearchBaseDistinguishedName: Distinguished name of the object to start the recursive search of users from.</summary>
    [JsonPropertyName("searchBaseDistinguishedName")]
    public string? SearchBaseDistinguishedName { get; set; }

    /// <summary>
    /// SearchFilterTemplate: Template to use for searching. Defaults to (cn=%s) where %s will be replaced by the username used
    /// to login.
    /// </summary>
    [JsonPropertyName("searchFilterTemplate")]
    public string? SearchFilterTemplate { get; set; }

    [JsonPropertyName("serverCertificates")]
    public IList<V20251015CassandraDataCenterStatusPropertiesAuthenticationMethodLdapPropertiesServerCertificates>? ServerCertificates { get; set; }

    /// <summary>ServerHostname: Hostname of the LDAP server.</summary>
    [JsonPropertyName("serverHostname")]
    public string? ServerHostname { get; set; }

    /// <summary>ServerPort: Port of the LDAP server.</summary>
    [JsonPropertyName("serverPort")]
    public int? ServerPort { get; set; }

    /// <summary>
    /// ServiceUserDistinguishedName: Distinguished name of the look up user account, who can look up user details on
    /// authentication.
    /// </summary>
    [JsonPropertyName("serviceUserDistinguishedName")]
    public string? ServiceUserDistinguishedName { get; set; }
}

/// <summary>ProvisionError: Error related to resource provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterStatusPropertiesProvisionError
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
public partial class V20251015CassandraDataCenterStatusPropertiesSeedNodes
{
    /// <summary>IpAddress: IP address of this seed node.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>Properties: Properties of a managed Cassandra data center.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterStatusProperties
{
    /// <summary>AuthenticationMethodLdapProperties: Ldap authentication method properties. This feature is in preview.</summary>
    [JsonPropertyName("authenticationMethodLdapProperties")]
    public V20251015CassandraDataCenterStatusPropertiesAuthenticationMethodLdapProperties? AuthenticationMethodLdapProperties { get; set; }

    /// <summary>
    /// AvailabilityZone: If the data center has Availability Zone support, apply it to the Virtual Machine ScaleSet that host
    /// the cassandra data center virtual machines.
    /// </summary>
    [JsonPropertyName("availabilityZone")]
    public bool? AvailabilityZone { get; set; }

    /// <summary>
    /// BackupStorageCustomerKeyUri: Indicates the Key Uri of the customer key to use for encryption of the backup storage
    /// account.
    /// </summary>
    [JsonPropertyName("backupStorageCustomerKeyUri")]
    public string? BackupStorageCustomerKeyUri { get; set; }

    /// <summary>
    /// Base64EncodedCassandraYamlFragment: A fragment of a cassandra.yaml configuration file to be included in the
    /// cassandra.yaml for all nodes in this data center. The fragment should be Base64 encoded, and only a subset of keys are
    /// allowed.
    /// </summary>
    [JsonPropertyName("base64EncodedCassandraYamlFragment")]
    public string? Base64EncodedCassandraYamlFragment { get; set; }

    /// <summary>DataCenterLocation: The region this data center should be created in.</summary>
    [JsonPropertyName("dataCenterLocation")]
    public string? DataCenterLocation { get; set; }

    /// <summary>Deallocated: Whether the data center has been deallocated.</summary>
    [JsonPropertyName("deallocated")]
    public bool? Deallocated { get; set; }

    /// <summary>
    /// DelegatedSubnetId: Resource id of a subnet the nodes in this data center should have their network interfaces connected
    /// to. The subnet must be in the same region specified in &apos;dataCenterLocation&apos; and must be able to route to the subnet
    /// specified in the cluster&apos;s &apos;delegatedManagementSubnetId&apos; property. This resource id will be of the form
    /// &apos;/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual
    /// network&gt;/subnets/&lt;subnet&gt; &apos;.
    /// </summary>
    [JsonPropertyName("delegatedSubnetId")]
    public string? DelegatedSubnetId { get; set; }

    /// <summary>DiskCapacity: Number of disks attached to each node. Default is 4.</summary>
    [JsonPropertyName("diskCapacity")]
    public int? DiskCapacity { get; set; }

    /// <summary>DiskSku: Disk SKU used for data centers. Default value is P30.</summary>
    [JsonPropertyName("diskSku")]
    public string? DiskSku { get; set; }

    /// <summary>
    /// ManagedDiskCustomerKeyUri: Key uri to use for encryption of managed disks. Ensure the system assigned identity of the
    /// cluster has been assigned appropriate permissions(key get/wrap/unwrap permissions) on the key.
    /// </summary>
    [JsonPropertyName("managedDiskCustomerKeyUri")]
    public string? ManagedDiskCustomerKeyUri { get; set; }

    /// <summary>
    /// NodeCount: The number of nodes the data center should have. This is the desired number. After it is set, it may take
    /// some time for the data center to be scaled to match. To monitor the number of nodes and their status, use the
    /// fetchNodeStatus method on the cluster.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>PrivateEndpointIpAddress: Ip of the VPN Endpoint for this data center.</summary>
    [JsonPropertyName("privateEndpointIpAddress")]
    public string? PrivateEndpointIpAddress { get; set; }

    /// <summary>ProvisionError: Error related to resource provisioning.</summary>
    [JsonPropertyName("provisionError")]
    public V20251015CassandraDataCenterStatusPropertiesProvisionError? ProvisionError { get; set; }

    /// <summary>ProvisioningState: The status of the resource at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// SeedNodes: IP addresses for seed nodes in this data center. This is for reference. Generally you will want to use the
    /// seedNodes property on the cluster, which aggregates the seed nodes from all data centers in the cluster.
    /// </summary>
    [JsonPropertyName("seedNodes")]
    public IList<V20251015CassandraDataCenterStatusPropertiesSeedNodes>? SeedNodes { get; set; }

    /// <summary>Sku: Virtual Machine SKU used for data centers. Default value is Standard_DS14_v2</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251015CassandraDataCenterStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20251015CassandraDataCenterStatusConditions>? Conditions { get; set; }

    /// <summary>Id: The unique resource identifier of the database account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the database account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Properties of a managed Cassandra data center.</summary>
    [JsonPropertyName("properties")]
    public V20251015CassandraDataCenterStatusProperties? Properties { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2025-10-15/managedCassandra.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251015CassandraDataCenter : IKubernetesObject<V1ObjectMeta>, ISpec<V20251015CassandraDataCenterSpec?>, IStatus<V20251015CassandraDataCenterStatus?>
{
    public const string KubeApiVersion = "v20251015";
    public const string KubeKind = "CassandraDataCenter";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "cassandradatacenters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v20251015";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CassandraDataCenter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20251015CassandraDataCenterSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20251015CassandraDataCenterStatus? Status { get; set; }
}