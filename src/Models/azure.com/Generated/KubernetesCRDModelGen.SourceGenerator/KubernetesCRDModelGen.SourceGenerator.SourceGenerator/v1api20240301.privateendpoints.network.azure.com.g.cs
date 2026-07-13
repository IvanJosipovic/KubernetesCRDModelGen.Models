#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/privateEndpoint.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301PrivateEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301PrivateEndpoint>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "PrivateEndpointList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privateendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301PrivateEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301PrivateEndpoint> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecApplicationSecurityGroupsReference
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

/// <summary>An application security group in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecApplicationSecurityGroups
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301PrivateEndpointSpecApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301PrivateEndpointSpecExtendedLocationTypeEnum>))]
public enum V1api20240301PrivateEndpointSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20240301PrivateEndpointSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>An IP Configuration of the private endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecIpConfigurations
{
    /// <summary>GroupId: The ID of a group obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>MemberName: The member name of a group obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAddress: A private ip address obtained from the private endpoint&apos;s subnet.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }
}

/// <summary>
/// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: A message indicating if changes on the service provider require any updates on the consumer.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The reason for approval/rejection of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceReference
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

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

/// <summary>PrivateLinkServiceConnection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecManualPrivateLinkServiceConnections
{
    /// <summary>GroupIds: The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
    /// resource.
    /// </summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20240301PrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
    [JsonPropertyName("privateLinkServiceReference")]
    public V1api20240301PrivateEndpointSpecManualPrivateLinkServiceConnectionsPrivateLinkServiceReference? PrivateLinkServiceReference { get; set; }

    /// <summary>
    /// RequestMessage: A message passed to the owner of the remote resource with this connection request. Restricted to 140
    /// chars.
    /// </summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecOperatorSpecConfigMapExpressions
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
/// PrimaryNicPrivateIpAddress: indicates where the PrimaryNicPrivateIpAddress config map should be placed. If omitted, no
/// config map will be created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecOperatorSpecConfigMapsPrimaryNicPrivateIpAddress
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// PrimaryNicPrivateIpAddress: indicates where the PrimaryNicPrivateIpAddress config map should be placed. If omitted, no
    /// config map will be created.
    /// </summary>
    [JsonPropertyName("primaryNicPrivateIpAddress")]
    public V1api20240301PrivateEndpointSpecOperatorSpecConfigMapsPrimaryNicPrivateIpAddress? PrimaryNicPrivateIpAddress { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecOperatorSpecSecretExpressions
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
public partial class V1api20240301PrivateEndpointSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301PrivateEndpointSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20240301PrivateEndpointSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301PrivateEndpointSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: A message indicating if changes on the service provider require any updates on the consumer.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The reason for approval/rejection of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceReference
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

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

/// <summary>PrivateLinkServiceConnection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecPrivateLinkServiceConnections
{
    /// <summary>GroupIds: The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
    /// resource.
    /// </summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20240301PrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>PrivateLinkServiceReference: The resource id of private link service.</summary>
    [JsonPropertyName("privateLinkServiceReference")]
    public V1api20240301PrivateEndpointSpecPrivateLinkServiceConnectionsPrivateLinkServiceReference? PrivateLinkServiceReference { get; set; }

    /// <summary>
    /// RequestMessage: A message passed to the owner of the remote resource with this connection request. Restricted to 140
    /// chars.
    /// </summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecSubnetReference
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

/// <summary>Subnet: The ID of the subnet from which the private IP will be allocated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpecSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301PrivateEndpointSpecSubnetReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointSpec
{
    /// <summary>ApplicationSecurityGroups: Application security groups in which the private endpoint IP configuration is included.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20240301PrivateEndpointSpecApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CustomNetworkInterfaceName: The custom name of the network interface attached to the private endpoint.</summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301PrivateEndpointSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// IpConfigurations: A list of IP configurations of the private endpoint. This will be used to map to the First Party
    /// Service&apos;s endpoints.
    /// </summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20240301PrivateEndpointSpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManualPrivateLinkServiceConnections: A grouping of information about the connection to the remote resource. Used when
    /// the network admin does not have access to approve connections to the remote resource.
    /// </summary>
    [JsonPropertyName("manualPrivateLinkServiceConnections")]
    public IList<V1api20240301PrivateEndpointSpecManualPrivateLinkServiceConnections>? ManualPrivateLinkServiceConnections { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301PrivateEndpointSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301PrivateEndpointSpecOwner Owner { get; set; }

    /// <summary>PrivateLinkServiceConnections: A grouping of information about the connection to the remote resource.</summary>
    [JsonPropertyName("privateLinkServiceConnections")]
    public IList<V1api20240301PrivateEndpointSpecPrivateLinkServiceConnections>? PrivateLinkServiceConnections { get; set; }

    /// <summary>Subnet: The ID of the subnet from which the private IP will be allocated.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301PrivateEndpointSpecSubnet? Subnet { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An application security group in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusApplicationSecurityGroups
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusConditions
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

/// <summary>Contains custom Dns resolution configuration from customer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusCustomDnsConfigs
{
    /// <summary>Fqdn: Fqdn that resolves to private endpoint ip address.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>IpAddresses: A list of private ip addresses of the private endpoint.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An IP Configuration of the private endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusIpConfigurations
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GroupId: The ID of a group obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>MemberName: The member name of a group obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAddress: A private ip address obtained from the private endpoint&apos;s subnet.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: A message indicating if changes on the service provider require any updates on the consumer.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The reason for approval/rejection of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PrivateLinkServiceConnection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusManualPrivateLinkServiceConnections
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GroupIds: The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
    /// resource.
    /// </summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20240301PrivateEndpointStatusManualPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>PrivateLinkServiceId: The resource id of private link service.</summary>
    [JsonPropertyName("privateLinkServiceId")]
    public string? PrivateLinkServiceId { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the private link service connection resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RequestMessage: A message passed to the owner of the remote resource with this connection request. Restricted to 140
    /// chars.
    /// </summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A network interface in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusNetworkInterfaces
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: A message indicating if changes on the service provider require any updates on the consumer.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The reason for approval/rejection of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>PrivateLinkServiceConnection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusPrivateLinkServiceConnections
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GroupIds: The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PrivateLinkServiceConnectionState: A collection of read-only information about the state of the connection to the remote
    /// resource.
    /// </summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20240301PrivateEndpointStatusPrivateLinkServiceConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>PrivateLinkServiceId: The resource id of private link service.</summary>
    [JsonPropertyName("privateLinkServiceId")]
    public string? PrivateLinkServiceId { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the private link service connection resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RequestMessage: A message passed to the owner of the remote resource with this connection request. Restricted to 140
    /// chars.
    /// </summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Subnet: The ID of the subnet from which the private IP will be allocated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatusSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Private endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301PrivateEndpointStatus
{
    /// <summary>ApplicationSecurityGroups: Application security groups in which the private endpoint IP configuration is included.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20240301PrivateEndpointStatusApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301PrivateEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>CustomDnsConfigs: An array of custom dns configurations.</summary>
    [JsonPropertyName("customDnsConfigs")]
    public IList<V1api20240301PrivateEndpointStatusCustomDnsConfigs>? CustomDnsConfigs { get; set; }

    /// <summary>CustomNetworkInterfaceName: The custom name of the network interface attached to the private endpoint.</summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301PrivateEndpointStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IpConfigurations: A list of IP configurations of the private endpoint. This will be used to map to the First Party
    /// Service&apos;s endpoints.
    /// </summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20240301PrivateEndpointStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManualPrivateLinkServiceConnections: A grouping of information about the connection to the remote resource. Used when
    /// the network admin does not have access to approve connections to the remote resource.
    /// </summary>
    [JsonPropertyName("manualPrivateLinkServiceConnections")]
    public IList<V1api20240301PrivateEndpointStatusManualPrivateLinkServiceConnections>? ManualPrivateLinkServiceConnections { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkInterfaces: An array of references to the network interfaces created for this private endpoint.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20240301PrivateEndpointStatusNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary>PrivateLinkServiceConnections: A grouping of information about the connection to the remote resource.</summary>
    [JsonPropertyName("privateLinkServiceConnections")]
    public IList<V1api20240301PrivateEndpointStatusPrivateLinkServiceConnections>? PrivateLinkServiceConnections { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the private endpoint resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Subnet: The ID of the subnet from which the private IP will be allocated.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301PrivateEndpointStatusSubnet? Subnet { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/privateEndpoint.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301PrivateEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301PrivateEndpointSpec?>, IStatus<V1api20240301PrivateEndpointStatus?>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "PrivateEndpoint";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privateendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240301PrivateEndpointSpec? Spec { get; set; }

    /// <summary>Private endpoint resource.</summary>
    [JsonPropertyName("status")]
    public V1api20240301PrivateEndpointStatus? Status { get; set; }
}