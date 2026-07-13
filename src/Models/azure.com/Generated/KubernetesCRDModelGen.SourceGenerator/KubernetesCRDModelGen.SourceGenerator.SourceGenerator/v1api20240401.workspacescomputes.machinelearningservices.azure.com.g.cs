#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/machineLearningServices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401WorkspacesComputeList : IKubernetesObject<V1ListMeta>, IItems<V1api20240401WorkspacesCompute>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "WorkspacesComputeList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacescomputes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesComputeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240401WorkspacesCompute objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240401WorkspacesCompute> Items { get; set; }
}

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecIdentityTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240401WorkspacesComputeSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V1api20240401WorkspacesComputeSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240401WorkspacesComputeSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240401WorkspacesComputeSpecOperatorSpecSecretExpressions
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
public partial class V1api20240401WorkspacesComputeSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240401WorkspacesComputeSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240401WorkspacesComputeSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a machinelearningservices.azure.com/Workspace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAksComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAksComputeTypeEnum
{
    [EnumMember(Value = "AKS"), JsonStringEnumMemberName("AKS")]
    AKS
}

/// <summary>SubnetReference: Virtual network subnet resource ID the compute nodes belong to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference
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

/// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration
{
    /// <summary>
    /// DnsServiceIP: An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address
    /// range specified in serviceCidr.
    /// </summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary>
    /// DockerBridgeCidr: A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP
    /// ranges or the Kubernetes service address range.
    /// </summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>
    /// ServiceCidr: A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP
    /// ranges.
    /// </summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>SubnetReference: Virtual network subnet resource ID the compute nodes belong to</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference? SubnetReference { get; set; }
}

/// <summary>ClusterPurpose: Intended usage of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesClusterPurposeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesClusterPurposeEnum
{
    [EnumMember(Value = "DenseProd"), JsonStringEnumMemberName("DenseProd")]
    DenseProd,
    [EnumMember(Value = "DevTest"), JsonStringEnumMemberName("DevTest")]
    DevTest,
    [EnumMember(Value = "FastProd"), JsonStringEnumMemberName("FastProd")]
    FastProd
}

/// <summary>LoadBalancerSubnetReference: Load Balancer Subnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerSubnetReference
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

/// <summary>LoadBalancerType: Load Balancer Type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerTypeEnum
{
    [EnumMember(Value = "InternalLoadBalancer"), JsonStringEnumMemberName("InternalLoadBalancer")]
    InternalLoadBalancer,
    [EnumMember(Value = "PublicIp"), JsonStringEnumMemberName("PublicIp")]
    PublicIp
}

/// <summary>Cert: Cert data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationCert
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

/// <summary>Key: Key data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationKey
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

/// <summary>Status: Enable or disable ssl for scoring</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationStatusEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationStatusEnum
{
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SslConfiguration: SSL configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration
{
    /// <summary>Cert: Cert data</summary>
    [JsonPropertyName("cert")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationCert? Cert { get; set; }

    /// <summary>Cname: CNAME of the cert</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>Key: Key data</summary>
    [JsonPropertyName("key")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationKey? Key { get; set; }

    /// <summary>LeafDomainLabel: Leaf domain label of public endpoint</summary>
    [JsonPropertyName("leafDomainLabel")]
    public string? LeafDomainLabel { get; set; }

    /// <summary>OverwriteExistingDomain: Indicates whether to overwrite existing domain label.</summary>
    [JsonPropertyName("overwriteExistingDomain")]
    public bool? OverwriteExistingDomain { get; set; }

    /// <summary>Status: Enable or disable ssl for scoring</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationStatusEnum? Status { get; set; }
}

/// <summary>Properties: AKS properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksProperties
{
    /// <summary>AgentCount: Number of agents</summary>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }

    /// <summary>AgentVmSize: Agent virtual machine size</summary>
    [JsonPropertyName("agentVmSize")]
    public string? AgentVmSize { get; set; }

    /// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

    /// <summary>ClusterFqdn: Cluster full qualified domain name</summary>
    [JsonPropertyName("clusterFqdn")]
    public string? ClusterFqdn { get; set; }

    /// <summary>ClusterPurpose: Intended usage of the cluster</summary>
    [JsonPropertyName("clusterPurpose")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesClusterPurposeEnum? ClusterPurpose { get; set; }

    /// <summary>LoadBalancerSubnetReference: Load Balancer Subnet</summary>
    [JsonPropertyName("loadBalancerSubnetReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerSubnetReference? LoadBalancerSubnetReference { get; set; }

    /// <summary>LoadBalancerType: Load Balancer Type</summary>
    [JsonPropertyName("loadBalancerType")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerTypeEnum? LoadBalancerType { get; set; }

    /// <summary>SslConfiguration: SSL configuration</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAksResourceReference
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

/// <summary>AKS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAks
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesAksComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Properties: AKS properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesAksResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAmlComputeComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAmlComputeComputeTypeEnum
{
    [EnumMember(Value = "AmlCompute"), JsonStringEnumMemberName("AmlCompute")]
    AmlCompute
}

/// <summary>OsType: Compute OS Type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesOsTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// RemoteLoginPortPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh
/// port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the
/// cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined,
/// else is open all public nodes. It can be default only during cluster creation time, after creation it will be either
/// enabled or disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesRemoteLoginPortPublicAccessEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesRemoteLoginPortPublicAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "NotSpecified"), JsonStringEnumMemberName("NotSpecified")]
    NotSpecified
}

/// <summary>ScaleSettings: Scale settings for AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings
{
    /// <summary>MaxNodeCount: Max number of nodes to use</summary>
    [JsonPropertyName("maxNodeCount")]
    public required int MaxNodeCount { get; set; }

    /// <summary>MinNodeCount: Min number of nodes to use</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }

    /// <summary>NodeIdleTimeBeforeScaleDown: Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.</summary>
    [JsonPropertyName("nodeIdleTimeBeforeScaleDown")]
    public string? NodeIdleTimeBeforeScaleDown { get; set; }
}

/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference
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

/// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet
{
    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public required V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference Reference { get; set; }
}

/// <summary>AdminUserPassword: Password of the administrator user account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword
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

/// <summary>AdminUserSshPublicKey: SSH public key of the administrator user account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey
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

/// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>AdminUserName: Name of the administrator user account which can be used to SSH to nodes.</summary>
    [JsonPropertyName("adminUserName")]
    public required string AdminUserName { get; set; }

    /// <summary>AdminUserPassword: Password of the administrator user account.</summary>
    [JsonPropertyName("adminUserPassword")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword? AdminUserPassword { get; set; }

    /// <summary>AdminUserSshPublicKey: SSH public key of the administrator user account.</summary>
    [JsonPropertyName("adminUserSshPublicKey")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey? AdminUserSshPublicKey { get; set; }
}

/// <summary>Reference: Virtual Machine image path</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference
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

/// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>Reference: Virtual Machine image path</summary>
    [JsonPropertyName("reference")]
    public required V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference Reference { get; set; }
}

/// <summary>VmPriority: Virtual Machine priority</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVmPriorityEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVmPriorityEnum
{
    [EnumMember(Value = "Dedicated"), JsonStringEnumMemberName("Dedicated")]
    Dedicated,
    [EnumMember(Value = "LowPriority"), JsonStringEnumMemberName("LowPriority")]
    LowPriority
}

/// <summary>Properties: Properties of AmlCompute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputeProperties
{
    /// <summary>
    /// EnableNodePublicIp: Enable or disable node public IP address provisioning. Possible values are: Possible values are:
    /// true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will
    /// have a private endpoint and no public IPs.
    /// </summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>IsolatedNetwork: Network is isolated or not</summary>
    [JsonPropertyName("isolatedNetwork")]
    public bool? IsolatedNetwork { get; set; }

    /// <summary>OsType: Compute OS Type</summary>
    [JsonPropertyName("osType")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesOsTypeEnum? OsType { get; set; }

    /// <summary>PropertyBag: A property bag containing additional properties.</summary>
    [JsonPropertyName("propertyBag")]
    public IDictionary<string, JsonNode>? PropertyBag { get; set; }

    /// <summary>
    /// RemoteLoginPortPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh
    /// port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the
    /// cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined,
    /// else is open all public nodes. It can be default only during cluster creation time, after creation it will be either
    /// enabled or disabled.
    /// </summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesRemoteLoginPortPublicAccessEnum? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>ScaleSettings: Scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary>VmPriority: Virtual Machine priority</summary>
    [JsonPropertyName("vmPriority")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputePropertiesVmPriorityEnum? VmPriority { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlComputeResourceReference
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

/// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesAmlCompute
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesAmlComputeComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Properties: Properties of AmlCompute</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlComputeResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceComputeTypeEnum
{
    [EnumMember(Value = "ComputeInstance"), JsonStringEnumMemberName("ComputeInstance")]
    ComputeInstance
}

/// <summary>
/// ApplicationSharingPolicy: Policy for sharing applications on this compute instance among users of parent workspace. If
/// Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access
/// applications on this instance depending on his/her assigned role.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesApplicationSharingPolicyEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesApplicationSharingPolicyEnum
{
    [EnumMember(Value = "Personal"), JsonStringEnumMemberName("Personal")]
    Personal,
    [EnumMember(Value = "Shared"), JsonStringEnumMemberName("Shared")]
    Shared
}

/// <summary>ComputeInstanceAuthorizationType: The Compute Instance Authorization type. Available values are personal (default).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesComputeInstanceAuthorizationTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesComputeInstanceAuthorizationTypeEnum
{
    [EnumMember(Value = "personal"), JsonStringEnumMemberName("personal")]
    Personal
}

/// <summary>Docker: Describes the docker settings for the image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesDocker
{
    /// <summary>Privileged: Indicate whether container shall run in privileged or non-privileged mode.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }
}

/// <summary>Protocol: Protocol over which communication will happen over this endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpointsProtocolEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpointsProtocolEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "tcp"), JsonStringEnumMemberName("tcp")]
    Tcp,
    [EnumMember(Value = "udp"), JsonStringEnumMemberName("udp")]
    Udp
}

/// <summary>Describes the endpoint configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpoints
{
    /// <summary>HostIp: Host IP over which the application is exposed from the container</summary>
    [JsonPropertyName("hostIp")]
    public string? HostIp { get; set; }

    /// <summary>Name: Name of the Endpoint</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: Protocol over which communication will happen over this endpoint</summary>
    [JsonPropertyName("protocol")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpointsProtocolEnum? Protocol { get; set; }

    /// <summary>Published: Port over which the application is exposed from container.</summary>
    [JsonPropertyName("published")]
    public int? Published { get; set; }

    /// <summary>Target: Application port inside the container.</summary>
    [JsonPropertyName("target")]
    public int? Target { get; set; }
}

/// <summary>Type: Type of the Environment Variable. Possible values are: local - For local variable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariablesTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariablesTypeEnum
{
    [EnumMember(Value = "local"), JsonStringEnumMemberName("local")]
    Local
}

/// <summary>Environment Variables for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables
{
    /// <summary>Type: Type of the Environment Variable. Possible values are: local - For local variable</summary>
    [JsonPropertyName("type")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariablesTypeEnum? Type { get; set; }

    /// <summary>Value: Value of the Environment variable</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type: Type of the image. Possible values are: docker - For docker images. azureml - For AzureML images</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImageTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImageTypeEnum
{
    [EnumMember(Value = "azureml"), JsonStringEnumMemberName("azureml")]
    Azureml,
    [EnumMember(Value = "docker"), JsonStringEnumMemberName("docker")]
    Docker
}

/// <summary>Image: Describes the Image Specifications</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImage
{
    /// <summary>Reference: Image reference</summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    /// <summary>Type: Type of the image. Possible values are: docker - For docker images. azureml - For AzureML images</summary>
    [JsonPropertyName("type")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImageTypeEnum? Type { get; set; }
}

/// <summary>Bind: Bind Options of the mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesBind
{
    /// <summary>CreateHostPath: Indicate whether to create host path.</summary>
    [JsonPropertyName("createHostPath")]
    public bool? CreateHostPath { get; set; }

    /// <summary>Propagation: Type of Bind Option</summary>
    [JsonPropertyName("propagation")]
    public string? Propagation { get; set; }

    /// <summary>Selinux: Mention the selinux options.</summary>
    [JsonPropertyName("selinux")]
    public string? Selinux { get; set; }
}

/// <summary>Tmpfs: tmpfs option of the mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs
{
    /// <summary>Size: Mention the Tmpfs size</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary>Type: Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTypeEnum
{
    [EnumMember(Value = "bind"), JsonStringEnumMemberName("bind")]
    Bind,
    [EnumMember(Value = "npipe"), JsonStringEnumMemberName("npipe")]
    Npipe,
    [EnumMember(Value = "tmpfs"), JsonStringEnumMemberName("tmpfs")]
    Tmpfs,
    [EnumMember(Value = "volume"), JsonStringEnumMemberName("volume")]
    Volume
}

/// <summary>Volume: Volume Options of the mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesVolume
{
    /// <summary>Nocopy: Indicate whether volume is nocopy</summary>
    [JsonPropertyName("nocopy")]
    public bool? Nocopy { get; set; }
}

/// <summary>Describes the volume configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumes
{
    /// <summary>Bind: Bind Options of the mount</summary>
    [JsonPropertyName("bind")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesBind? Bind { get; set; }

    /// <summary>Consistency: Consistency of the volume</summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary>ReadOnly: Indicate whether to mount volume as readOnly. Default value for this is false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Source: Source of the mount. For bind mounts this is the host path.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Target: Target of the mount. For bind mounts this is the path in the container.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Tmpfs: tmpfs option of the mount</summary>
    [JsonPropertyName("tmpfs")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs? Tmpfs { get; set; }

    /// <summary>Type: Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe</summary>
    [JsonPropertyName("type")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesTypeEnum? Type { get; set; }

    /// <summary>Volume: Volume Options of the mount</summary>
    [JsonPropertyName("volume")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumesVolume? Volume { get; set; }
}

/// <summary>Specifies the custom service configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServices
{
    /// <summary>Docker: Describes the docker settings for the image</summary>
    [JsonPropertyName("docker")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesDocker? Docker { get; set; }

    /// <summary>Endpoints: Configuring the endpoints for the container</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEndpoints>? Endpoints { get; set; }

    /// <summary>EnvironmentVariables: Environment Variable for the container</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Image: Describes the Image Specifications</summary>
    [JsonPropertyName("image")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesImage? Image { get; set; }

    /// <summary>Name: Name of the Custom Service</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Volumes: Configuring the volumes for the container</summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServicesVolumes>? Volumes { get; set; }
}

/// <summary>ObjectIdFromConfig: User’s AAD Object Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserObjectIdFromConfig
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

/// <summary>TenantIdFromConfig: User’s AAD Tenant Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserTenantIdFromConfig
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

/// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
{
    /// <summary>ObjectId: User’s AAD Object Id.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: User’s AAD Object Id.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>TenantId: User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>TenantIdFromConfig: User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantIdFromConfig")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUserTenantIdFromConfig? TenantIdFromConfig { get; set; }
}

/// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}

/// <summary>Action: [Required] The compute power action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopActionEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopActionEnum
{
    [EnumMember(Value = "Start"), JsonStringEnumMemberName("Start")]
    Start,
    [EnumMember(Value = "Stop"), JsonStringEnumMemberName("Stop")]
    Stop
}

/// <summary>Cron: Required if triggerType is Cron.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron
{
    /// <summary>
    /// Expression: [Required] Specifies cron expression of schedule.
    /// The expression should follow NCronTab format.
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>StartTime: The start time in yyyy-MM-ddTHH:mm:ss format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// TimeZone: Specifies time zone in which the schedule runs.
    /// TimeZone should follow Windows time zone format. Refer:
    /// https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Frequency: [Required] The frequency to trigger schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceFrequencyEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceFrequencyEnum
{
    [EnumMember(Value = "Day"), JsonStringEnumMemberName("Day")]
    Day,
    [EnumMember(Value = "Hour"), JsonStringEnumMemberName("Hour")]
    Hour,
    [EnumMember(Value = "Minute"), JsonStringEnumMemberName("Minute")]
    Minute,
    [EnumMember(Value = "Month"), JsonStringEnumMemberName("Month")]
    Month,
    [EnumMember(Value = "Week"), JsonStringEnumMemberName("Week")]
    Week
}

/// <summary>Enum of weekday</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceScheduleWeekDaysEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceScheduleWeekDaysEnum
{
    [EnumMember(Value = "Friday"), JsonStringEnumMemberName("Friday")]
    Friday,
    [EnumMember(Value = "Monday"), JsonStringEnumMemberName("Monday")]
    Monday,
    [EnumMember(Value = "Saturday"), JsonStringEnumMemberName("Saturday")]
    Saturday,
    [EnumMember(Value = "Sunday"), JsonStringEnumMemberName("Sunday")]
    Sunday,
    [EnumMember(Value = "Thursday"), JsonStringEnumMemberName("Thursday")]
    Thursday,
    [EnumMember(Value = "Tuesday"), JsonStringEnumMemberName("Tuesday")]
    Tuesday,
    [EnumMember(Value = "Wednesday"), JsonStringEnumMemberName("Wednesday")]
    Wednesday
}

/// <summary>Schedule: [Required] The recurrence schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule
{
    /// <summary>Hours: [Required] List of hours for the schedule.</summary>
    [JsonPropertyName("hours")]
    public required IList<int> Hours { get; set; }

    /// <summary>Minutes: [Required] List of minutes for the schedule.</summary>
    [JsonPropertyName("minutes")]
    public required IList<int> Minutes { get; set; }

    /// <summary>MonthDays: List of month days for the schedule</summary>
    [JsonPropertyName("monthDays")]
    public IList<int>? MonthDays { get; set; }

    /// <summary>WeekDays: List of days for the schedule.</summary>
    [JsonPropertyName("weekDays")]
    public IList<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceScheduleWeekDaysEnum>? WeekDays { get; set; }
}

/// <summary>Recurrence: Required if triggerType is Recurrence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence
{
    /// <summary>Frequency: [Required] The frequency to trigger schedule.</summary>
    [JsonPropertyName("frequency")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceFrequencyEnum? Frequency { get; set; }

    /// <summary>Interval: [Required] Specifies schedule interval in conjunction with frequency</summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>Schedule: [Required] The recurrence schedule.</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule? Schedule { get; set; }

    /// <summary>StartTime: The start time in yyyy-MM-ddTHH:mm:ss format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// TimeZone: Specifies time zone in which the schedule runs.
    /// TimeZone should follow Windows time zone format. Refer:
    /// https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>ProvisioningStatus: The current deployment state of schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleProvisioningStatusEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleProvisioningStatusEnum
{
    [EnumMember(Value = "Completed"), JsonStringEnumMemberName("Completed")]
    Completed,
    [EnumMember(Value = "Failed"), JsonStringEnumMemberName("Failed")]
    Failed,
    [EnumMember(Value = "Provisioning"), JsonStringEnumMemberName("Provisioning")]
    Provisioning
}

/// <summary>Reference: A system assigned id for the schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleReference
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

/// <summary>Status: Is the schedule enabled or disabled?</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleStatusEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Schedule: [Deprecated] Not used any more.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule
{
    /// <summary>ProvisioningStatus: The current deployment state of schedule.</summary>
    [JsonPropertyName("provisioningStatus")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleProvisioningStatusEnum? ProvisioningStatus { get; set; }

    /// <summary>Reference: A system assigned id for the schedule.</summary>
    [JsonPropertyName("reference")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleReference? Reference { get; set; }

    /// <summary>Status: Is the schedule enabled or disabled?</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopScheduleStatusEnum? Status { get; set; }
}

/// <summary>Status: Is the schedule enabled or disabled?</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopStatusEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>TriggerType: [Required] The schedule trigger type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopTriggerTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopTriggerTypeEnum
{
    [EnumMember(Value = "Cron"), JsonStringEnumMemberName("Cron")]
    Cron,
    [EnumMember(Value = "Recurrence"), JsonStringEnumMemberName("Recurrence")]
    Recurrence
}

/// <summary>Compute start stop schedule properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStop
{
    /// <summary>Action: [Required] The compute power action.</summary>
    [JsonPropertyName("action")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopActionEnum? Action { get; set; }

    /// <summary>Cron: Required if triggerType is Cron.</summary>
    [JsonPropertyName("cron")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron? Cron { get; set; }

    /// <summary>Recurrence: Required if triggerType is Recurrence.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence? Recurrence { get; set; }

    /// <summary>Schedule: [Deprecated] Not used any more.</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule? Schedule { get; set; }

    /// <summary>Status: Is the schedule enabled or disabled?</summary>
    [JsonPropertyName("status")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopStatusEnum? Status { get; set; }

    /// <summary>TriggerType: [Required] The schedule trigger type.</summary>
    [JsonPropertyName("triggerType")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStopTriggerTypeEnum? TriggerType { get; set; }
}

/// <summary>Schedules: The list of schedules to be applied on the computes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedules
{
    /// <summary>ComputeStartStop: The list of compute start stop schedules to be applied.</summary>
    [JsonPropertyName("computeStartStop")]
    public IList<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedulesComputeStartStop>? ComputeStartStop { get; set; }
}

/// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Scripts: Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
    [JsonPropertyName("creationScript")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
    [JsonPropertyName("startupScript")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}

/// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>Scripts: Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}

/// <summary>
/// SshPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is
/// closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the
/// VNet/subnet policy if applicable.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettingsSshPublicAccessEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettingsSshPublicAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings
{
    /// <summary>
    /// AdminPublicKey: Specifies the SSH rsa public key file as a string. Use &quot;ssh-keygen -t rsa -b 2048&quot; to generate your SSH
    /// key pairs.
    /// </summary>
    [JsonPropertyName("adminPublicKey")]
    public string? AdminPublicKey { get; set; }

    /// <summary>
    /// SshPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is
    /// closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the
    /// VNet/subnet policy if applicable.
    /// </summary>
    [JsonPropertyName("sshPublicAccess")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettingsSshPublicAccessEnum? SshPublicAccess { get; set; }
}

/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference
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

/// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public required V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference Reference { get; set; }
}

/// <summary>Properties: Properties of ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceProperties
{
    /// <summary>
    /// ApplicationSharingPolicy: Policy for sharing applications on this compute instance among users of parent workspace. If
    /// Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access
    /// applications on this instance depending on his/her assigned role.
    /// </summary>
    [JsonPropertyName("applicationSharingPolicy")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesApplicationSharingPolicyEnum? ApplicationSharingPolicy { get; set; }

    /// <summary>ComputeInstanceAuthorizationType: The Compute Instance Authorization type. Available values are personal (default).</summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesComputeInstanceAuthorizationTypeEnum? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>CustomServices: List of Custom Services added to the compute.</summary>
    [JsonPropertyName("customServices")]
    public IList<V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesCustomServices>? CustomServices { get; set; }

    /// <summary>
    /// EnableNodePublicIp: Enable or disable node public IP address provisioning. Possible values are: Possible values are:
    /// true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will
    /// have a private endpoint and no public IPs.
    /// </summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>Schedules: The list of schedules to be applied on the computes.</summary>
    [JsonPropertyName("schedules")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSchedules? Schedules { get; set; }

    /// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceResourceReference
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

/// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesComputeInstance
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Properties: Properties of ComputeInstance</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstanceResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesDataFactoryComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesDataFactoryComputeTypeEnum
{
    [EnumMember(Value = "DataFactory"), JsonStringEnumMemberName("DataFactory")]
    DataFactory
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDataFactoryResourceReference
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

/// <summary>DataFactory: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDataFactory
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesDataFactoryComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesDataFactoryResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsComputeTypeEnum
{
    [EnumMember(Value = "DataLakeAnalytics"), JsonStringEnumMemberName("DataLakeAnalytics")]
    DataLakeAnalytics
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties
{
    /// <summary>DataLakeStoreAccountName: DataLake Store Account Name</summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference
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

/// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalytics
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesDatabricksComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesDatabricksComputeTypeEnum
{
    [EnumMember(Value = "Databricks"), JsonStringEnumMemberName("Databricks")]
    Databricks
}

/// <summary>DatabricksAccessToken: Databricks access token</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDatabricksPropertiesDatabricksAccessToken
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

/// <summary>Properties: Properties of Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDatabricksProperties
{
    /// <summary>DatabricksAccessToken: Databricks access token</summary>
    [JsonPropertyName("databricksAccessToken")]
    public V1api20240401WorkspacesComputeSpecPropertiesDatabricksPropertiesDatabricksAccessToken? DatabricksAccessToken { get; set; }

    /// <summary>WorkspaceUrl: Workspace Url</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDatabricksResourceReference
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

/// <summary>Databricks: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesDatabricks
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesDatabricksComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Properties: Properties of Databricks</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesDatabricksResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesHdInsightComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesHdInsightComputeTypeEnum
{
    [EnumMember(Value = "HDInsight"), JsonStringEnumMemberName("HDInsight")]
    HDInsight
}

/// <summary>Password: Password of admin account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword
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

/// <summary>PrivateKeyData: Private key data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPrivateKeyData
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

/// <summary>PublicKeyData: Public key data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPublicKeyData
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

/// <summary>AdministratorAccount: Admin credentials for master node of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>Password: Password of admin account</summary>
    [JsonPropertyName("password")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary>PrivateKeyData: Private key data</summary>
    [JsonPropertyName("privateKeyData")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPrivateKeyData? PrivateKeyData { get; set; }

    /// <summary>PublicKeyData: Public key data</summary>
    [JsonPropertyName("publicKeyData")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPublicKeyData? PublicKeyData { get; set; }

    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Properties: HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsightProperties
{
    /// <summary>Address: Public IP address of the master node of the cluster.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for master node of the cluster</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>SshPort: Port open for ssh connections on the master node of the cluster.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsightResourceReference
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

/// <summary>HDInsight: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesHdInsight
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesHdInsightComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Properties: HDInsight compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsightResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesKubernetesComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesKubernetesComputeTypeEnum
{
    [EnumMember(Value = "Kubernetes"), JsonStringEnumMemberName("Kubernetes")]
    Kubernetes
}

/// <summary>ExtensionPrincipalIdFromConfig: Extension principal-id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesExtensionPrincipalIdFromConfig
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

/// <summary>Resources: Resource requests/limits for this instance type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources
{
    /// <summary>Limits: Resource limits for this instance type</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Requests: Resource requests for this instance type</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Instance type schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>NodeSelector: Node Selector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Resources: Resource requests/limits for this instance type</summary>
    [JsonPropertyName("resources")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}

/// <summary>RelayConnectionString: Relay connection string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString
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

/// <summary>ServiceBusConnectionString: ServiceBus connection string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString
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

/// <summary>Properties: Properties of Kubernetes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesProperties
{
    /// <summary>DefaultInstanceType: Default instance type</summary>
    [JsonPropertyName("defaultInstanceType")]
    public string? DefaultInstanceType { get; set; }

    /// <summary>ExtensionInstanceReleaseTrain: Extension instance release train.</summary>
    [JsonPropertyName("extensionInstanceReleaseTrain")]
    public string? ExtensionInstanceReleaseTrain { get; set; }

    /// <summary>ExtensionPrincipalId: Extension principal-id.</summary>
    [JsonPropertyName("extensionPrincipalId")]
    public string? ExtensionPrincipalId { get; set; }

    /// <summary>ExtensionPrincipalIdFromConfig: Extension principal-id.</summary>
    [JsonPropertyName("extensionPrincipalIdFromConfig")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesExtensionPrincipalIdFromConfig? ExtensionPrincipalIdFromConfig { get; set; }

    /// <summary>InstanceTypes: Instance Type Schema</summary>
    [JsonPropertyName("instanceTypes")]
    public IDictionary<string, V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary>Namespace: Compute namespace</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>RelayConnectionString: Relay connection string.</summary>
    [JsonPropertyName("relayConnectionString")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString? RelayConnectionString { get; set; }

    /// <summary>ServiceBusConnectionString: ServiceBus connection string.</summary>
    [JsonPropertyName("serviceBusConnectionString")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString? ServiceBusConnectionString { get; set; }

    /// <summary>VcName: VC name.</summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetesResourceReference
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

/// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesKubernetes
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesKubernetesComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>Properties: Properties of Kubernetes</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetesResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkComputeTypeEnum
{
    [EnumMember(Value = "SynapseSpark"), JsonStringEnumMemberName("SynapseSpark")]
    SynapseSpark
}

/// <summary>AutoPauseProperties: Auto pause properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties
{
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutoScaleProperties: Auto scale properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkProperties
{
    /// <summary>AutoPauseProperties: Auto pause properties.</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>AutoScaleProperties: Auto scale properties.</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

    /// <summary>NodeCount: The number of compute nodes currently assigned to the compute.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>NodeSize: Node size.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>NodeSizeFamily: Node size family.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>PoolName: Pool name.</summary>
    [JsonPropertyName("poolName")]
    public string? PoolName { get; set; }

    /// <summary>ResourceGroup: Name of the resource group in which workspace is located.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SparkVersion: Spark version.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SubscriptionId: Azure subscription identifier.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>WorkspaceName: Name of Azure Machine Learning workspace.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkResourceReference
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

/// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesSynapseSpark
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesSynapseSparkResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineComputeTypeEnum>))]
public enum V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineComputeTypeEnum
{
    [EnumMember(Value = "VirtualMachine"), JsonStringEnumMemberName("VirtualMachine")]
    VirtualMachine
}

/// <summary>Password: Password of admin account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword
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

/// <summary>PrivateKeyData: Private key data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPrivateKeyData
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

/// <summary>PublicKeyData: Public key data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPublicKeyData
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

/// <summary>AdministratorAccount: Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>Password: Password of admin account</summary>
    [JsonPropertyName("password")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary>PrivateKeyData: Private key data</summary>
    [JsonPropertyName("privateKeyData")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPrivateKeyData? PrivateKeyData { get; set; }

    /// <summary>PublicKeyData: Public key data</summary>
    [JsonPropertyName("publicKeyData")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPublicKeyData? PublicKeyData { get; set; }

    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineProperties
{
    /// <summary>Address: Public IP address of the virtual machine.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>IsNotebookInstanceCompute: Indicates whether this compute will be used for running notebooks.</summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

    /// <summary>NotebookServerPort: Notebook server port open for ssh connections.</summary>
    [JsonPropertyName("notebookServerPort")]
    public int? NotebookServerPort { get; set; }

    /// <summary>SshPort: Port open for ssh connections.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary>VirtualMachineSize: Virtual Machine size</summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineResourceReference
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

/// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecPropertiesVirtualMachine
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineComputeTypeEnum ComputeType { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachineResourceReference? ResourceReference { get; set; }
}

/// <summary>Properties: Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecProperties
{
    /// <summary>AKS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("aks")]
    public V1api20240401WorkspacesComputeSpecPropertiesAks? Aks { get; set; }

    /// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20240401WorkspacesComputeSpecPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20240401WorkspacesComputeSpecPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>DataFactory: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20240401WorkspacesComputeSpecPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20240401WorkspacesComputeSpecPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Databricks: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("databricks")]
    public V1api20240401WorkspacesComputeSpecPropertiesDatabricks? Databricks { get; set; }

    /// <summary>HDInsight: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20240401WorkspacesComputeSpecPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20240401WorkspacesComputeSpecPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20240401WorkspacesComputeSpecPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20240401WorkspacesComputeSpecPropertiesVirtualMachine? VirtualMachine { get; set; }
}

/// <summary>
/// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
/// not  required on a PUT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240401WorkspacesComputeSpecSkuTierEnum>))]
public enum V1api20240401WorkspacesComputeSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpecSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not  required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20240401WorkspacesComputeSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240401WorkspacesComputeSpecIdentity? Identity { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240401WorkspacesComputeSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a machinelearningservices.azure.com/Workspace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240401WorkspacesComputeSpecOwner Owner { get; set; }

    /// <summary>Properties: Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeSpecProperties? Properties { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20240401WorkspacesComputeSpecSku? Sku { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusConditions
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

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240401WorkspacesComputeStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration
{
    /// <summary>
    /// DnsServiceIP: An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address
    /// range specified in serviceCidr.
    /// </summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary>
    /// DockerBridgeCidr: A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP
    /// ranges or the Kubernetes service address range.
    /// </summary>
    [JsonPropertyName("dockerBridgeCidr")]
    public string? DockerBridgeCidr { get; set; }

    /// <summary>
    /// ServiceCidr: A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP
    /// ranges.
    /// </summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>SubnetId: Virtual network subnet resource ID the compute nodes belong to</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>SslConfiguration: SSL configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration
{
    /// <summary>Cname: CNAME of the cert</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>LeafDomainLabel: Leaf domain label of public endpoint</summary>
    [JsonPropertyName("leafDomainLabel")]
    public string? LeafDomainLabel { get; set; }

    /// <summary>OverwriteExistingDomain: Indicates whether to overwrite existing domain label.</summary>
    [JsonPropertyName("overwriteExistingDomain")]
    public bool? OverwriteExistingDomain { get; set; }

    /// <summary>Status: Enable or disable ssl for scoring</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A system service running on a compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksPropertiesSystemServices
{
    /// <summary>PublicIpAddress: Public IP address</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>SystemServiceType: The type of this system service.</summary>
    [JsonPropertyName("systemServiceType")]
    public string? SystemServiceType { get; set; }

    /// <summary>Version: The version for this type.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Properties: AKS properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksProperties
{
    /// <summary>AgentCount: Number of agents</summary>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }

    /// <summary>AgentVmSize: Agent virtual machine size</summary>
    [JsonPropertyName("agentVmSize")]
    public string? AgentVmSize { get; set; }

    /// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20240401WorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

    /// <summary>ClusterFqdn: Cluster full qualified domain name</summary>
    [JsonPropertyName("clusterFqdn")]
    public string? ClusterFqdn { get; set; }

    /// <summary>ClusterPurpose: Intended usage of the cluster</summary>
    [JsonPropertyName("clusterPurpose")]
    public string? ClusterPurpose { get; set; }

    /// <summary>LoadBalancerSubnet: Load Balancer Subnet</summary>
    [JsonPropertyName("loadBalancerSubnet")]
    public string? LoadBalancerSubnet { get; set; }

    /// <summary>LoadBalancerType: Load Balancer Type</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }

    /// <summary>SslConfiguration: SSL configuration</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20240401WorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }

    /// <summary>SystemServices: System services</summary>
    [JsonPropertyName("systemServices")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAksPropertiesSystemServices>? SystemServices { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrorsError? Error { get; set; }
}

/// <summary>AKS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAks
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Properties: AKS properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesAksProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAksProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError? Error { get; set; }
}

/// <summary>NodeStateCounts: Counts of various node states on the compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts
{
    /// <summary>IdleNodeCount: Number of compute nodes in idle state.</summary>
    [JsonPropertyName("idleNodeCount")]
    public int? IdleNodeCount { get; set; }

    /// <summary>LeavingNodeCount: Number of compute nodes which are leaving the amlCompute.</summary>
    [JsonPropertyName("leavingNodeCount")]
    public int? LeavingNodeCount { get; set; }

    /// <summary>PreemptedNodeCount: Number of compute nodes which are in preempted state.</summary>
    [JsonPropertyName("preemptedNodeCount")]
    public int? PreemptedNodeCount { get; set; }

    /// <summary>PreparingNodeCount: Number of compute nodes which are being prepared.</summary>
    [JsonPropertyName("preparingNodeCount")]
    public int? PreparingNodeCount { get; set; }

    /// <summary>RunningNodeCount: Number of compute nodes which are running jobs.</summary>
    [JsonPropertyName("runningNodeCount")]
    public int? RunningNodeCount { get; set; }

    /// <summary>UnusableNodeCount: Number of compute nodes which are in unusable state.</summary>
    [JsonPropertyName("unusableNodeCount")]
    public int? UnusableNodeCount { get; set; }
}

/// <summary>ScaleSettings: Scale settings for AML Compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings
{
    /// <summary>MaxNodeCount: Max number of nodes to use</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>MinNodeCount: Min number of nodes to use</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }

    /// <summary>NodeIdleTimeBeforeScaleDown: Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.</summary>
    [JsonPropertyName("nodeIdleTimeBeforeScaleDown")]
    public string? NodeIdleTimeBeforeScaleDown { get; set; }
}

/// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet
{
    /// <summary>Id: The ID of the resource</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>AdminUserName: Name of the administrator user account which can be used to SSH to nodes.</summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }
}

/// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>Id: Virtual Machine image path</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Properties: Properties of AmlCompute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProperties
{
    /// <summary>
    /// AllocationState: Allocation state of the compute. Possible values are: steady - Indicates that the compute is not
    /// resizing. There are no changes to the number of compute nodes in the compute in progress. A compute enters this state
    /// when it is created and when no operations are being performed on the compute to change the number of compute nodes.
    /// resizing - Indicates that the compute is resizing; that is, compute nodes are being added to or removed from the compute.
    /// </summary>
    [JsonPropertyName("allocationState")]
    public string? AllocationState { get; set; }

    /// <summary>AllocationStateTransitionTime: The time at which the compute entered its current allocation state.</summary>
    [JsonPropertyName("allocationStateTransitionTime")]
    public string? AllocationStateTransitionTime { get; set; }

    /// <summary>CurrentNodeCount: The number of compute nodes currently assigned to the compute.</summary>
    [JsonPropertyName("currentNodeCount")]
    public int? CurrentNodeCount { get; set; }

    /// <summary>
    /// EnableNodePublicIp: Enable or disable node public IP address provisioning. Possible values are: Possible values are:
    /// true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will
    /// have a private endpoint and no public IPs.
    /// </summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>Errors: Collection of errors encountered by various compute nodes during node setup.</summary>
    [JsonPropertyName("errors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesErrors>? Errors { get; set; }

    /// <summary>IsolatedNetwork: Network is isolated or not</summary>
    [JsonPropertyName("isolatedNetwork")]
    public bool? IsolatedNetwork { get; set; }

    /// <summary>NodeStateCounts: Counts of various node states on the compute.</summary>
    [JsonPropertyName("nodeStateCounts")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts? NodeStateCounts { get; set; }

    /// <summary>OsType: Compute OS Type</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>PropertyBag: A property bag containing additional properties.</summary>
    [JsonPropertyName("propertyBag")]
    public IDictionary<string, JsonNode>? PropertyBag { get; set; }

    /// <summary>
    /// RemoteLoginPortPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh
    /// port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the
    /// cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined,
    /// else is open all public nodes. It can be default only during cluster creation time, after creation it will be either
    /// enabled or disabled.
    /// </summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public string? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>ScaleSettings: Scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary>
    /// TargetNodeCount: The target number of compute nodes for the compute. If the allocationState is resizing, this property
    /// denotes the target node count for the ongoing resize operation. If the allocationState is steady, this property denotes
    /// the target node count for the previous resize operation.
    /// </summary>
    [JsonPropertyName("targetNodeCount")]
    public int? TargetNodeCount { get; set; }

    /// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary>VmPriority: Virtual Machine priority</summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError? Error { get; set; }
}

/// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesAmlCompute
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Properties: Properties of AmlCompute</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Defines an Aml Instance application and its connectivity endpoint URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications
{
    /// <summary>DisplayName: Name of the ComputeInstance application.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>EndpointUri: Application&apos; endpoint URI.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }
}

/// <summary>ConnectivityEndpoints: Describes all connectivity endpoints available for this ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints
{
    /// <summary>
    /// PrivateIpAddress: Private IP Address of this ComputeInstance (local to the VNET in which the compute instance is
    /// deployed).
    /// </summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>PublicIpAddress: Public IP Address of this ComputeInstance.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }
}

/// <summary>Environment: Environment information of this container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesContainersEnvironment
{
    /// <summary>Name: name of environment.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Version: version of environment.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Defines an Aml Instance container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesContainers
{
    /// <summary>Autosave: Auto save settings.</summary>
    [JsonPropertyName("autosave")]
    public string? Autosave { get; set; }

    /// <summary>Environment: Environment information of this container.</summary>
    [JsonPropertyName("environment")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesContainersEnvironment? Environment { get; set; }

    /// <summary>Gpu: Information of GPU.</summary>
    [JsonPropertyName("gpu")]
    public string? Gpu { get; set; }

    /// <summary>Name: Name of the ComputeInstance container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Network: network of this container.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Services: services of this containers.</summary>
    [JsonPropertyName("services")]
    public IList<IDictionary<string, JsonNode>>? Services { get; set; }
}

/// <summary>CreatedBy: Describes information on user who created this ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy
{
    /// <summary>UserId: Uniquely identifies the user within his/her organization.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>UserName: Name of the user.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>UserOrgId: Uniquely identifies user&apos; Azure Active Directory organization.</summary>
    [JsonPropertyName("userOrgId")]
    public string? UserOrgId { get; set; }
}

/// <summary>Docker: Describes the docker settings for the image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesDocker
{
    /// <summary>Privileged: Indicate whether container shall run in privileged or non-privileged mode.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }
}

/// <summary>Describes the endpoint configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEndpoints
{
    /// <summary>HostIp: Host IP over which the application is exposed from the container</summary>
    [JsonPropertyName("hostIp")]
    public string? HostIp { get; set; }

    /// <summary>Name: Name of the Endpoint</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: Protocol over which communication will happen over this endpoint</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Published: Port over which the application is exposed from container.</summary>
    [JsonPropertyName("published")]
    public int? Published { get; set; }

    /// <summary>Target: Application port inside the container.</summary>
    [JsonPropertyName("target")]
    public int? Target { get; set; }
}

/// <summary>Environment Variables for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables
{
    /// <summary>Type: Type of the Environment Variable. Possible values are: local - For local variable</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the Environment variable</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Image: Describes the Image Specifications</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesImage
{
    /// <summary>Reference: Image reference</summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    /// <summary>Type: Type of the image. Possible values are: docker - For docker images. azureml - For AzureML images</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Bind: Bind Options of the mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesBind
{
    /// <summary>CreateHostPath: Indicate whether to create host path.</summary>
    [JsonPropertyName("createHostPath")]
    public bool? CreateHostPath { get; set; }

    /// <summary>Propagation: Type of Bind Option</summary>
    [JsonPropertyName("propagation")]
    public string? Propagation { get; set; }

    /// <summary>Selinux: Mention the selinux options.</summary>
    [JsonPropertyName("selinux")]
    public string? Selinux { get; set; }
}

/// <summary>Tmpfs: tmpfs option of the mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs
{
    /// <summary>Size: Mention the Tmpfs size</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary>Volume: Volume Options of the mount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesVolume
{
    /// <summary>Nocopy: Indicate whether volume is nocopy</summary>
    [JsonPropertyName("nocopy")]
    public bool? Nocopy { get; set; }
}

/// <summary>Describes the volume configuration for the container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumes
{
    /// <summary>Bind: Bind Options of the mount</summary>
    [JsonPropertyName("bind")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesBind? Bind { get; set; }

    /// <summary>Consistency: Consistency of the volume</summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary>ReadOnly: Indicate whether to mount volume as readOnly. Default value for this is false.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Source: Source of the mount. For bind mounts this is the host path.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Target: Target of the mount. For bind mounts this is the path in the container.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Tmpfs: tmpfs option of the mount</summary>
    [JsonPropertyName("tmpfs")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesTmpfs? Tmpfs { get; set; }

    /// <summary>Type: Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Volume: Volume Options of the mount</summary>
    [JsonPropertyName("volume")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumesVolume? Volume { get; set; }
}

/// <summary>Specifies the custom service configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServices
{
    /// <summary>Docker: Describes the docker settings for the image</summary>
    [JsonPropertyName("docker")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesDocker? Docker { get; set; }

    /// <summary>Endpoints: Configuring the endpoints for the container</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEndpoints>? Endpoints { get; set; }

    /// <summary>EnvironmentVariables: Environment Variable for the container</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Image: Describes the Image Specifications</summary>
    [JsonPropertyName("image")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesImage? Image { get; set; }

    /// <summary>Name: Name of the Custom Service</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Volumes: Configuring the volumes for the container</summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServicesVolumes>? Volumes { get; set; }
}

/// <summary>Defines an Aml Instance DataDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesDataDisks
{
    /// <summary>Caching: Caching type of Data Disk.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>DiskSizeGB: The initial disk size in gigabytes.</summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Lun: The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun.</summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>StorageAccountType: type of this storage account.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Defines an Aml Instance DataMount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesDataMounts
{
    /// <summary>CreatedBy: who this data mount created by.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Error: Error of this data mount.</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>MountAction: Mount Action.</summary>
    [JsonPropertyName("mountAction")]
    public string? MountAction { get; set; }

    /// <summary>MountName: name of the ComputeInstance data mount.</summary>
    [JsonPropertyName("mountName")]
    public string? MountName { get; set; }

    /// <summary>MountPath: Path of this data mount.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>MountState: Mount state.</summary>
    [JsonPropertyName("mountState")]
    public string? MountState { get; set; }

    /// <summary>MountedOn: The time when the disk mounted.</summary>
    [JsonPropertyName("mountedOn")]
    public string? MountedOn { get; set; }

    /// <summary>Source: Source of the ComputeInstance data mount.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>SourceType: Data source type.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError? Error { get; set; }
}

/// <summary>LastOperation: The last operation on ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation
{
    /// <summary>OperationName: Name of the last operation.</summary>
    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>OperationStatus: Operation status.</summary>
    [JsonPropertyName("operationStatus")]
    public string? OperationStatus { get; set; }

    /// <summary>OperationTime: Time of the last operation.</summary>
    [JsonPropertyName("operationTime")]
    public string? OperationTime { get; set; }

    /// <summary>OperationTrigger: Trigger of operation.</summary>
    [JsonPropertyName("operationTrigger")]
    public string? OperationTrigger { get; set; }
}

/// <summary>OsImageMetadata: Returns metadata about the operating system image for this compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesOsImageMetadata
{
    /// <summary>CurrentImageVersion: Specifies the current operating system image version this compute instance is running on.</summary>
    [JsonPropertyName("currentImageVersion")]
    public string? CurrentImageVersion { get; set; }

    /// <summary>IsLatestOsImageVersion: Specifies whether this compute instance is running on the latest operating system image.</summary>
    [JsonPropertyName("isLatestOsImageVersion")]
    public bool? IsLatestOsImageVersion { get; set; }

    /// <summary>LatestImageVersion: Specifies the latest available operating system image version.</summary>
    [JsonPropertyName("latestImageVersion")]
    public string? LatestImageVersion { get; set; }
}

/// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
{
    /// <summary>ObjectId: User’s AAD Object Id.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>TenantId: User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}

/// <summary>Cron: Required if triggerType is Cron.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron
{
    /// <summary>
    /// Expression: [Required] Specifies cron expression of schedule.
    /// The expression should follow NCronTab format.
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>StartTime: The start time in yyyy-MM-ddTHH:mm:ss format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// TimeZone: Specifies time zone in which the schedule runs.
    /// TimeZone should follow Windows time zone format. Refer:
    /// https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Schedule: [Required] The recurrence schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule
{
    /// <summary>Hours: [Required] List of hours for the schedule.</summary>
    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    /// <summary>Minutes: [Required] List of minutes for the schedule.</summary>
    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    /// <summary>MonthDays: List of month days for the schedule</summary>
    [JsonPropertyName("monthDays")]
    public IList<int>? MonthDays { get; set; }

    /// <summary>WeekDays: List of days for the schedule.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}

/// <summary>Recurrence: Required if triggerType is Recurrence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence
{
    /// <summary>Frequency: [Required] The frequency to trigger schedule.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Interval: [Required] Specifies schedule interval in conjunction with frequency</summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>Schedule: [Required] The recurrence schedule.</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrenceSchedule? Schedule { get; set; }

    /// <summary>StartTime: The start time in yyyy-MM-ddTHH:mm:ss format.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// TimeZone: Specifies time zone in which the schedule runs.
    /// TimeZone should follow Windows time zone format. Refer:
    /// https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Schedule: [Deprecated] Not used any more.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule
{
    /// <summary>Id: A system assigned id for the schedule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ProvisioningStatus: The current deployment state of schedule.</summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary>Status: Is the schedule enabled or disabled?</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Compute start stop schedule properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStop
{
    /// <summary>Action: [Required] The compute power action.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Cron: Required if triggerType is Cron.</summary>
    [JsonPropertyName("cron")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopCron? Cron { get; set; }

    /// <summary>Id: A system assigned id for the schedule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ProvisioningStatus: The current deployment state of schedule.</summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary>Recurrence: Required if triggerType is Recurrence.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopRecurrence? Recurrence { get; set; }

    /// <summary>Schedule: [Deprecated] Not used any more.</summary>
    [JsonPropertyName("schedule")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStopSchedule? Schedule { get; set; }

    /// <summary>Status: Is the schedule enabled or disabled?</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>TriggerType: [Required] The schedule trigger type.</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>Schedules: The list of schedules to be applied on the computes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedules
{
    /// <summary>ComputeStartStop: The list of compute start stop schedules to be applied.</summary>
    [JsonPropertyName("computeStartStop")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedulesComputeStartStop>? ComputeStartStop { get; set; }
}

/// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Scripts: Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
    [JsonPropertyName("creationScript")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
    [JsonPropertyName("startupScript")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}

/// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>Scripts: Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}

/// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings
{
    /// <summary>
    /// AdminPublicKey: Specifies the SSH rsa public key file as a string. Use &quot;ssh-keygen -t rsa -b 2048&quot; to generate your SSH
    /// key pairs.
    /// </summary>
    [JsonPropertyName("adminPublicKey")]
    public string? AdminPublicKey { get; set; }

    /// <summary>AdminUserName: Describes the admin user name.</summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }

    /// <summary>SshPort: Describes the port for connecting through SSH.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary>
    /// SshPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is
    /// closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the
    /// VNet/subnet policy if applicable.
    /// </summary>
    [JsonPropertyName("sshPublicAccess")]
    public string? SshPublicAccess { get; set; }
}

/// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>Id: The ID of the resource</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Versions: ComputeInstance version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesVersions
{
    /// <summary>Runtime: Runtime of compute instance.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }
}

/// <summary>Properties: Properties of ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProperties
{
    /// <summary>
    /// ApplicationSharingPolicy: Policy for sharing applications on this compute instance among users of parent workspace. If
    /// Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access
    /// applications on this instance depending on his/her assigned role.
    /// </summary>
    [JsonPropertyName("applicationSharingPolicy")]
    public string? ApplicationSharingPolicy { get; set; }

    /// <summary>Applications: Describes available applications and their endpoints on this ComputeInstance.</summary>
    [JsonPropertyName("applications")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications>? Applications { get; set; }

    /// <summary>ComputeInstanceAuthorizationType: The Compute Instance Authorization type. Available values are personal (default).</summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public string? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>ConnectivityEndpoints: Describes all connectivity endpoints available for this ComputeInstance.</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints? ConnectivityEndpoints { get; set; }

    /// <summary>Containers: Describes informations of containers on this ComputeInstance.</summary>
    [JsonPropertyName("containers")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesContainers>? Containers { get; set; }

    /// <summary>CreatedBy: Describes information on user who created this ComputeInstance.</summary>
    [JsonPropertyName("createdBy")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy? CreatedBy { get; set; }

    /// <summary>CustomServices: List of Custom Services added to the compute.</summary>
    [JsonPropertyName("customServices")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesCustomServices>? CustomServices { get; set; }

    /// <summary>DataDisks: Describes informations of dataDisks on this ComputeInstance.</summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesDataDisks>? DataDisks { get; set; }

    /// <summary>DataMounts: Describes informations of dataMounts on this ComputeInstance.</summary>
    [JsonPropertyName("dataMounts")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesDataMounts>? DataMounts { get; set; }

    /// <summary>
    /// EnableNodePublicIp: Enable or disable node public IP address provisioning. Possible values are: Possible values are:
    /// true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will
    /// have a private endpoint and no public IPs.
    /// </summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>Errors: Collection of errors encountered on this ComputeInstance.</summary>
    [JsonPropertyName("errors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors>? Errors { get; set; }

    /// <summary>LastOperation: The last operation on ComputeInstance.</summary>
    [JsonPropertyName("lastOperation")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation? LastOperation { get; set; }

    /// <summary>OsImageMetadata: Returns metadata about the operating system image for this compute instance.</summary>
    [JsonPropertyName("osImageMetadata")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesOsImageMetadata? OsImageMetadata { get; set; }

    /// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>Schedules: The list of schedules to be applied on the computes.</summary>
    [JsonPropertyName("schedules")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSchedules? Schedules { get; set; }

    /// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary>State: The current state of this ComputeInstance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary>Versions: ComputeInstance version.</summary>
    [JsonPropertyName("versions")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstancePropertiesVersions? Versions { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError? Error { get; set; }
}

/// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesComputeInstance
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Properties: Properties of ComputeInstance</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError? Error { get; set; }
}

/// <summary>DataFactory: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataFactory
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties
{
    /// <summary>DataLakeStoreAccountName: DataLake Store Account Name</summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError? Error { get; set; }
}

/// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalytics
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Properties: Properties of Databricks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricksProperties
{
    /// <summary>WorkspaceUrl: Workspace Url</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError? Error { get; set; }
}

/// <summary>Databricks: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesDatabricks
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Properties: Properties of Databricks</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesDatabricksProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>AdministratorAccount: Admin credentials for master node of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Properties: HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightProperties
{
    /// <summary>Address: Public IP address of the master node of the cluster.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for master node of the cluster</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401WorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>SshPort: Port open for ssh connections on the master node of the cluster.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError? Error { get; set; }
}

/// <summary>HDInsight: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesHdInsight
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Properties: HDInsight compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesHdInsightProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Resources: Resource requests/limits for this instance type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources
{
    /// <summary>Limits: Resource limits for this instance type</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    /// <summary>Requests: Resource requests for this instance type</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Instance type schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>NodeSelector: Node Selector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Resources: Resource requests/limits for this instance type</summary>
    [JsonPropertyName("resources")]
    public V1api20240401WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}

/// <summary>Properties: Properties of Kubernetes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesProperties
{
    /// <summary>DefaultInstanceType: Default instance type</summary>
    [JsonPropertyName("defaultInstanceType")]
    public string? DefaultInstanceType { get; set; }

    /// <summary>ExtensionInstanceReleaseTrain: Extension instance release train.</summary>
    [JsonPropertyName("extensionInstanceReleaseTrain")]
    public string? ExtensionInstanceReleaseTrain { get; set; }

    /// <summary>ExtensionPrincipalId: Extension principal-id.</summary>
    [JsonPropertyName("extensionPrincipalId")]
    public string? ExtensionPrincipalId { get; set; }

    /// <summary>InstanceTypes: Instance Type Schema</summary>
    [JsonPropertyName("instanceTypes")]
    public IDictionary<string, V1api20240401WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary>Namespace: Compute namespace</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>VcName: VC name.</summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError? Error { get; set; }
}

/// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesKubernetes
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    /// <summary>Properties: Properties of Kubernetes</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesKubernetesProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>AutoPauseProperties: Auto pause properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties
{
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutoScaleProperties: Auto scale properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProperties
{
    /// <summary>AutoPauseProperties: Auto pause properties.</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>AutoScaleProperties: Auto scale properties.</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

    /// <summary>NodeCount: The number of compute nodes currently assigned to the compute.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>NodeSize: Node size.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>NodeSizeFamily: Node size family.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>PoolName: Pool name.</summary>
    [JsonPropertyName("poolName")]
    public string? PoolName { get; set; }

    /// <summary>ResourceGroup: Name of the resource group in which workspace is located.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>SparkVersion: Spark version.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SubscriptionId: Azure subscription identifier.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>WorkspaceName: Name of Azure Machine Learning workspace.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError? Error { get; set; }
}

/// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesSynapseSpark
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>AdministratorAccount: Admin credentials for virtual machine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProperties
{
    /// <summary>Address: Public IP address of the virtual machine.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20240401WorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>IsNotebookInstanceCompute: Indicates whether this compute will be used for running notebooks.</summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

    /// <summary>NotebookServerPort: Notebook server port open for ssh connections.</summary>
    [JsonPropertyName("notebookServerPort")]
    public int? NotebookServerPort { get; set; }

    /// <summary>SshPort: Port open for ssh connections.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }

    /// <summary>VirtualMachineSize: Virtual Machine size</summary>
    [JsonPropertyName("virtualMachineSize")]
    public string? VirtualMachineSize { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also
/// follows the OData error response format.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError? Error { get; set; }
}

/// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusPropertiesVirtualMachine
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public string? ComputeType { get; set; }

    /// <summary>CreatedOn: The time at which the compute was created.</summary>
    [JsonPropertyName("createdOn")]
    public string? CreatedOn { get; set; }

    /// <summary>Description: The description of the Machine Learning compute.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DisableLocalAuth: Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for
    /// authentication.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// IsAttachedCompute: Indicating whether the compute was provisioned by user and brought from outside if true, or machine
    /// learning service provisioned it if false.
    /// </summary>
    [JsonPropertyName("isAttachedCompute")]
    public bool? IsAttachedCompute { get; set; }

    /// <summary>ModifiedOn: The time at which the compute was last modified.</summary>
    [JsonPropertyName("modifiedOn")]
    public string? ModifiedOn { get; set; }

    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20240401WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors>? ProvisioningErrors { get; set; }

    /// <summary>
    /// ProvisioningState: The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and
    /// Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceId: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Properties: Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusProperties
{
    /// <summary>AKS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("aks")]
    public V1api20240401WorkspacesComputeStatusPropertiesAks? Aks { get; set; }

    /// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20240401WorkspacesComputeStatusPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20240401WorkspacesComputeStatusPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>DataFactory: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20240401WorkspacesComputeStatusPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20240401WorkspacesComputeStatusPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Databricks: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("databricks")]
    public V1api20240401WorkspacesComputeStatusPropertiesDatabricks? Databricks { get; set; }

    /// <summary>HDInsight: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20240401WorkspacesComputeStatusPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20240401WorkspacesComputeStatusPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20240401WorkspacesComputeStatusPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20240401WorkspacesComputeStatusPropertiesVirtualMachine? VirtualMachine { get; set; }
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not  required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240401WorkspacesComputeStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240401WorkspacesComputeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240401WorkspacesComputeStatusIdentity? Identity { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20240401WorkspacesComputeStatusProperties? Properties { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20240401WorkspacesComputeStatusSku? Sku { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240401WorkspacesComputeStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/machineLearningServices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240401WorkspacesCompute : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240401WorkspacesComputeSpec?>, IStatus<V1api20240401WorkspacesComputeStatus?>
{
    public const string KubeApiVersion = "v1api20240401";
    public const string KubeKind = "WorkspacesCompute";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacescomputes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20240401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesCompute";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240401WorkspacesComputeSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240401WorkspacesComputeStatus? Status { get; set; }
}