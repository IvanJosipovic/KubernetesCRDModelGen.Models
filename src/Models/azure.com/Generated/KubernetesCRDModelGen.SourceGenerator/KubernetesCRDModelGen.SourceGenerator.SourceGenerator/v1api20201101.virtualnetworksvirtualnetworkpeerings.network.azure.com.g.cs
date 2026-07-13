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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringList : IKubernetesObject<V1ListMeta>, IItems<V1api20201101VirtualNetworksVirtualNetworkPeering>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeeringList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksVirtualNetworkPeeringList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201101VirtualNetworksVirtualNetworkPeering objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201101VirtualNetworksVirtualNetworkPeering> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions
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
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/VirtualNetwork resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PeeringState: The status of the virtual network peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworksVirtualNetworkPeeringSpecPeeringStateEnum>))]
public enum V1api20201101VirtualNetworksVirtualNetworkPeeringSpecPeeringStateEnum
{
    [EnumMember(Value = "Connected"), JsonStringEnumMemberName("Connected")]
    Connected,
    [EnumMember(Value = "Disconnected"), JsonStringEnumMemberName("Disconnected")]
    Disconnected,
    [EnumMember(Value = "Initiated"), JsonStringEnumMemberName("Initiated")]
    Initiated
}

/// <summary>RemoteAddressSpace: The reference to the remote virtual network address space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities
{
    /// <summary>VirtualNetworkCommunity: The BGP community associated with the virtual network.</summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public required string VirtualNetworkCommunity { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference
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
/// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
/// different region (preview). See here to register for the preview and learn more
/// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringSpec
{
    /// <summary>
    /// AllowForwardedTraffic: Whether the forwarded traffic from the VMs in the local virtual network will be
    /// allowed/disallowed in remote virtual network.
    /// </summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>AllowGatewayTransit: If gateway links can be used in remote virtual networking to link to this virtual network.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>
    /// AllowVirtualNetworkAccess: Whether the VMs in the local virtual network space would be able to access the VMs in remote
    /// virtual network space.
    /// </summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DoNotVerifyRemoteGateways: If we need to verify the provisioning state of the remote gateway.</summary>
    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/VirtualNetwork resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201101VirtualNetworksVirtualNetworkPeeringSpecOwner Owner { get; set; }

    /// <summary>PeeringState: The status of the virtual network peering.</summary>
    [JsonPropertyName("peeringState")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpecPeeringStateEnum? PeeringState { get; set; }

    /// <summary>RemoteAddressSpace: The reference to the remote virtual network address space.</summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    /// <summary>
    /// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
    /// different region (preview). See here to register for the preview and learn more
    /// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
    /// </summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>
    /// UseRemoteGateways: If remote gateways can be used on this virtual network. If the flag is set to true, and
    /// allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for
    /// transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a
    /// gateway.
    /// </summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringStatusConditions
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

/// <summary>RemoteAddressSpace: The reference to the remote virtual network address space.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities
{
    /// <summary>RegionalCommunity: The BGP community associated with the region of the virtual network.</summary>
    [JsonPropertyName("regionalCommunity")]
    public string? RegionalCommunity { get; set; }

    /// <summary>VirtualNetworkCommunity: The BGP community associated with the virtual network.</summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}

/// <summary>
/// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
/// different region (preview). See here to register for the preview and learn more
/// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeeringStatus
{
    /// <summary>
    /// AllowForwardedTraffic: Whether the forwarded traffic from the VMs in the local virtual network will be
    /// allowed/disallowed in remote virtual network.
    /// </summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>AllowGatewayTransit: If gateway links can be used in remote virtual networking to link to this virtual network.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>
    /// AllowVirtualNetworkAccess: Whether the VMs in the local virtual network space would be able to access the VMs in remote
    /// virtual network space.
    /// </summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201101VirtualNetworksVirtualNetworkPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>DoNotVerifyRemoteGateways: If we need to verify the provisioning state of the remote gateway.</summary>
    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PeeringState: The status of the virtual network peering.</summary>
    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the virtual network peering resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RemoteAddressSpace: The reference to the remote virtual network address space.</summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    /// <summary>
    /// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
    /// different region (preview). See here to register for the preview and learn more
    /// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
    /// </summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>ResourceGuid: The resourceGuid property of the Virtual Network peering resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UseRemoteGateways: If remote gateways can be used on this virtual network. If the flag is set to true, and
    /// allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for
    /// transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a
    /// gateway.
    /// </summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101VirtualNetworksVirtualNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101VirtualNetworksVirtualNetworkPeeringSpec?>, IStatus<V1api20201101VirtualNetworksVirtualNetworkPeeringStatus?>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeering";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksVirtualNetworkPeering";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20201101VirtualNetworksVirtualNetworkPeeringStatus? Status { get; set; }
}