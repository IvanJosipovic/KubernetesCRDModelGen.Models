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
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2021-07-01/machineLearningServices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210701WorkspacesComputeList : IKubernetesObject<V1ListMeta>, IItems<V1api20210701WorkspacesCompute>
{
    public const string KubeApiVersion = "v1api20210701";
    public const string KubeKind = "WorkspacesComputeList";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacescomputes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20210701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesComputeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210701WorkspacesCompute objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210701WorkspacesCompute> Items { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecIdentityTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecIdentityTypeEnum
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
public partial class V1api20210701WorkspacesComputeSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20210701WorkspacesComputeSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210701WorkspacesComputeSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public V1api20210701WorkspacesComputeSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The user assigned identities associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210701WorkspacesComputeSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210701WorkspacesComputeSpecOperatorSpecSecretExpressions
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
public partial class V1api20210701WorkspacesComputeSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210701WorkspacesComputeSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210701WorkspacesComputeSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a machinelearningservices.azure.com/Workspace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAksComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAksComputeTypeEnum
{
    [EnumMember(Value = "AKS"), JsonStringEnumMemberName("AKS")]
    AKS
}

/// <summary>SubnetReference: Virtual network subnet resource ID the compute nodes belong to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration
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
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfigurationSubnetReference? SubnetReference { get; set; }
}

/// <summary>ClusterPurpose: Intended usage of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesClusterPurposeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesClusterPurposeEnum
{
    [EnumMember(Value = "DenseProd"), JsonStringEnumMemberName("DenseProd")]
    DenseProd,
    [EnumMember(Value = "DevTest"), JsonStringEnumMemberName("DevTest")]
    DevTest,
    [EnumMember(Value = "FastProd"), JsonStringEnumMemberName("FastProd")]
    FastProd
}

/// <summary>LoadBalancerType: Load Balancer Type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerTypeEnum
{
    [EnumMember(Value = "InternalLoadBalancer"), JsonStringEnumMemberName("InternalLoadBalancer")]
    InternalLoadBalancer,
    [EnumMember(Value = "PublicIp"), JsonStringEnumMemberName("PublicIp")]
    PublicIp
}

/// <summary>Cert: Cert data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationCert
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationKey
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationStatusEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationStatusEnum
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration
{
    /// <summary>Cert: Cert data</summary>
    [JsonPropertyName("cert")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationCert? Cert { get; set; }

    /// <summary>Cname: CNAME of the cert</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary>Key: Key data</summary>
    [JsonPropertyName("key")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationKey? Key { get; set; }

    /// <summary>LeafDomainLabel: Leaf domain label of public endpoint</summary>
    [JsonPropertyName("leafDomainLabel")]
    public string? LeafDomainLabel { get; set; }

    /// <summary>OverwriteExistingDomain: Indicates whether to overwrite existing domain label.</summary>
    [JsonPropertyName("overwriteExistingDomain")]
    public bool? OverwriteExistingDomain { get; set; }

    /// <summary>Status: Enable or disable ssl for scoring</summary>
    [JsonPropertyName("status")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfigurationStatusEnum? Status { get; set; }
}

/// <summary>Properties: AKS properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksProperties
{
    /// <summary>AgentCount: Number of agents</summary>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }

    /// <summary>AgentVmSize: Agent virtual machine size</summary>
    [JsonPropertyName("agentVmSize")]
    public string? AgentVmSize { get; set; }

    /// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

    /// <summary>ClusterFqdn: Cluster full qualified domain name</summary>
    [JsonPropertyName("clusterFqdn")]
    public string? ClusterFqdn { get; set; }

    /// <summary>ClusterPurpose: Intended usage of the cluster</summary>
    [JsonPropertyName("clusterPurpose")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesClusterPurposeEnum? ClusterPurpose { get; set; }

    /// <summary>LoadBalancerSubnet: Load Balancer Subnet</summary>
    [JsonPropertyName("loadBalancerSubnet")]
    public string? LoadBalancerSubnet { get; set; }

    /// <summary>LoadBalancerType: Load Balancer Type</summary>
    [JsonPropertyName("loadBalancerType")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesLoadBalancerTypeEnum? LoadBalancerType { get; set; }

    /// <summary>SslConfiguration: SSL configuration</summary>
    [JsonPropertyName("sslConfiguration")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAksResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAks
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesAksComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesAksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesAksResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAmlComputeComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAmlComputeComputeTypeEnum
{
    [EnumMember(Value = "AmlCompute"), JsonStringEnumMemberName("AmlCompute")]
    AmlCompute
}

/// <summary>OsType: Compute OS Type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesOsTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesOsTypeEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesRemoteLoginPortPublicAccessEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesRemoteLoginPortPublicAccessEnum
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet
{
    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public required V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnetReference Reference { get; set; }
}

/// <summary>AdminUserPassword: Password of the administrator user account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>AdminUserName: Name of the administrator user account which can be used to SSH to nodes.</summary>
    [JsonPropertyName("adminUserName")]
    public required string AdminUserName { get; set; }

    /// <summary>AdminUserPassword: Password of the administrator user account.</summary>
    [JsonPropertyName("adminUserPassword")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserPassword? AdminUserPassword { get; set; }

    /// <summary>AdminUserSshPublicKey: SSH public key of the administrator user account.</summary>
    [JsonPropertyName("adminUserSshPublicKey")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentialsAdminUserSshPublicKey? AdminUserSshPublicKey { get; set; }
}

/// <summary>Reference: Virtual Machine image path</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>Reference: Virtual Machine image path</summary>
    [JsonPropertyName("reference")]
    public required V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImageReference Reference { get; set; }
}

/// <summary>VmPriority: Virtual Machine priority</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVmPriorityEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVmPriorityEnum
{
    [EnumMember(Value = "Dedicated"), JsonStringEnumMemberName("Dedicated")]
    Dedicated,
    [EnumMember(Value = "LowPriority"), JsonStringEnumMemberName("LowPriority")]
    LowPriority
}

/// <summary>Properties: Properties of AmlCompute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputeProperties
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
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// RemoteLoginPortPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh
    /// port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the
    /// cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined,
    /// else is open all public nodes. It can be default only during cluster creation time, after creation it will be either
    /// enabled or disabled.
    /// </summary>
    [JsonPropertyName("remoteLoginPortPublicAccess")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesRemoteLoginPortPublicAccessEnum? RemoteLoginPortPublicAccess { get; set; }

    /// <summary>ScaleSettings: Scale settings for AML Compute</summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

    /// <summary>VmPriority: Virtual Machine priority</summary>
    [JsonPropertyName("vmPriority")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputePropertiesVmPriorityEnum? VmPriority { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlComputeResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesAmlCompute
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesAmlComputeComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlComputeResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceComputeTypeEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesApplicationSharingPolicyEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesApplicationSharingPolicyEnum
{
    [EnumMember(Value = "Personal"), JsonStringEnumMemberName("Personal")]
    Personal,
    [EnumMember(Value = "Shared"), JsonStringEnumMemberName("Shared")]
    Shared
}

/// <summary>ComputeInstanceAuthorizationType: The Compute Instance Authorization type. Available values are personal (default).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesComputeInstanceAuthorizationTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesComputeInstanceAuthorizationTypeEnum
{
    [EnumMember(Value = "personal"), JsonStringEnumMemberName("personal")]
    Personal
}

/// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
{
    /// <summary>ObjectId: User’s AAD Object Id.</summary>
    [JsonPropertyName("objectId")]
    public required string ObjectId { get; set; }

    /// <summary>TenantId: User’s AAD Tenant Id.</summary>
    [JsonPropertyName("tenantId")]
    public required string TenantId { get; set; }
}

/// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}

/// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: inline, workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: inline, workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Scripts: Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
    [JsonPropertyName("creationScript")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
    [JsonPropertyName("startupScript")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}

/// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>Scripts: Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}

/// <summary>
/// SshPublicAccess: State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is
/// closed on this instance. Enabled - Indicates that the public ssh port is open and accessible according to the
/// VNet/subnet policy if applicable.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettingsSshPublicAccessEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettingsSshPublicAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings
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
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettingsSshPublicAccessEnum? SshPublicAccess { get; set; }
}

/// <summary>Reference: The ID of the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>Reference: The ID of the resource</summary>
    [JsonPropertyName("reference")]
    public required V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnetReference Reference { get; set; }
}

/// <summary>Properties: Properties of ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceProperties
{
    /// <summary>
    /// ApplicationSharingPolicy: Policy for sharing applications on this compute instance among users of parent workspace. If
    /// Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access
    /// applications on this instance depending on his/her assigned role.
    /// </summary>
    [JsonPropertyName("applicationSharingPolicy")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesApplicationSharingPolicyEnum? ApplicationSharingPolicy { get; set; }

    /// <summary>ComputeInstanceAuthorizationType: The Compute Instance Authorization type. Available values are personal (default).</summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesComputeInstanceAuthorizationTypeEnum? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesComputeInstance
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstanceResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesDataFactoryComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesDataFactoryComputeTypeEnum
{
    [EnumMember(Value = "DataFactory"), JsonStringEnumMemberName("DataFactory")]
    DataFactory
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesDataFactoryResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesDataFactory
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesDataFactoryComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesDataFactoryResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsComputeTypeEnum
{
    [EnumMember(Value = "DataLakeAnalytics"), JsonStringEnumMemberName("DataLakeAnalytics")]
    DataLakeAnalytics
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties
{
    /// <summary>DataLakeStoreAccountName: DataLake Store Account Name</summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalytics
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalyticsResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesDatabricksComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesDatabricksComputeTypeEnum
{
    [EnumMember(Value = "Databricks"), JsonStringEnumMemberName("Databricks")]
    Databricks
}

/// <summary>DatabricksAccessToken: Databricks access token</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesDatabricksPropertiesDatabricksAccessToken
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesDatabricksProperties
{
    /// <summary>DatabricksAccessToken: Databricks access token</summary>
    [JsonPropertyName("databricksAccessToken")]
    public V1api20210701WorkspacesComputeSpecPropertiesDatabricksPropertiesDatabricksAccessToken? DatabricksAccessToken { get; set; }

    /// <summary>WorkspaceUrl: Workspace Url</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesDatabricksResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesDatabricks
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesDatabricksComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesDatabricksResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesHdInsightComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesHdInsightComputeTypeEnum
{
    [EnumMember(Value = "HDInsight"), JsonStringEnumMemberName("HDInsight")]
    HDInsight
}

/// <summary>Password: Password of admin account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPrivateKeyData
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPublicKeyData
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>Password: Password of admin account</summary>
    [JsonPropertyName("password")]
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary>PrivateKeyData: Private key data</summary>
    [JsonPropertyName("privateKeyData")]
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPrivateKeyData? PrivateKeyData { get; set; }

    /// <summary>PublicKeyData: Public key data</summary>
    [JsonPropertyName("publicKeyData")]
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccountPublicKeyData? PublicKeyData { get; set; }

    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Properties: HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsightProperties
{
    /// <summary>Address: Public IP address of the master node of the cluster.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for master node of the cluster</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>SshPort: Port open for ssh connections on the master node of the cluster.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsightResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesHdInsight
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesHdInsightComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsightResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesKubernetesComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesKubernetesComputeTypeEnum
{
    [EnumMember(Value = "Kubernetes"), JsonStringEnumMemberName("Kubernetes")]
    Kubernetes
}

/// <summary>Resources: Resource requests/limits for this instance type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>NodeSelector: Node Selector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Resources: Resource requests/limits for this instance type</summary>
    [JsonPropertyName("resources")]
    public V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}

/// <summary>RelayConnectionString: Relay connection string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetesProperties
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
    public IDictionary<string, V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

    /// <summary>Namespace: Compute namespace</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>RelayConnectionString: Relay connection string.</summary>
    [JsonPropertyName("relayConnectionString")]
    public V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesRelayConnectionString? RelayConnectionString { get; set; }

    /// <summary>ServiceBusConnectionString: ServiceBus connection string.</summary>
    [JsonPropertyName("serviceBusConnectionString")]
    public V1api20210701WorkspacesComputeSpecPropertiesKubernetesPropertiesServiceBusConnectionString? ServiceBusConnectionString { get; set; }

    /// <summary>VcName: VC name.</summary>
    [JsonPropertyName("vcName")]
    public string? VcName { get; set; }
}

/// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetesResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesKubernetes
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesKubernetesComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesKubernetesResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkComputeTypeEnum
{
    [EnumMember(Value = "SynapseSpark"), JsonStringEnumMemberName("SynapseSpark")]
    SynapseSpark
}

/// <summary>AutoPauseProperties: Auto pause properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties
{
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutoScaleProperties: Auto scale properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkProperties
{
    /// <summary>AutoPauseProperties: Auto pause properties.</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>AutoScaleProperties: Auto scale properties.</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

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
public partial class V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesSynapseSpark
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesSynapseSparkResourceReference? ResourceReference { get; set; }
}

/// <summary>ComputeType: The type of compute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineComputeTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineComputeTypeEnum
{
    [EnumMember(Value = "VirtualMachine"), JsonStringEnumMemberName("VirtualMachine")]
    VirtualMachine
}

/// <summary>Password: Password of admin account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPrivateKeyData
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPublicKeyData
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>Password: Password of admin account</summary>
    [JsonPropertyName("password")]
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPassword? Password { get; set; }

    /// <summary>PrivateKeyData: Private key data</summary>
    [JsonPropertyName("privateKeyData")]
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPrivateKeyData? PrivateKeyData { get; set; }

    /// <summary>PublicKeyData: Public key data</summary>
    [JsonPropertyName("publicKeyData")]
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccountPublicKeyData? PublicKeyData { get; set; }

    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineProperties
{
    /// <summary>Address: Public IP address of the virtual machine.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>IsNotebookInstanceCompute: Indicates whether this compute will be used for running notebooks.</summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

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
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineResourceReference
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
public partial class V1api20210701WorkspacesComputeSpecPropertiesVirtualMachine
{
    /// <summary>ComputeLocation: Location for the underlying compute</summary>
    [JsonPropertyName("computeLocation")]
    public string? ComputeLocation { get; set; }

    /// <summary>ComputeType: The type of compute</summary>
    [JsonPropertyName("computeType")]
    public required V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineComputeTypeEnum ComputeType { get; set; }

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
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary>ResourceReference: ARM resource id of the underlying compute</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachineResourceReference? ResourceReference { get; set; }
}

/// <summary>Properties: Compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecProperties
{
    /// <summary>AKS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("aks")]
    public V1api20210701WorkspacesComputeSpecPropertiesAks? Aks { get; set; }

    /// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20210701WorkspacesComputeSpecPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20210701WorkspacesComputeSpecPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>DataFactory: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20210701WorkspacesComputeSpecPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20210701WorkspacesComputeSpecPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Databricks: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("databricks")]
    public V1api20210701WorkspacesComputeSpecPropertiesDatabricks? Databricks { get; set; }

    /// <summary>HDInsight: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20210701WorkspacesComputeSpecPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20210701WorkspacesComputeSpecPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20210701WorkspacesComputeSpecPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20210701WorkspacesComputeSpecPropertiesVirtualMachine? VirtualMachine { get; set; }
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecSku
{
    /// <summary>Name: Name of the sku</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of the sku like Basic or Enterprise</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>CreatedByType: The type of identity that created the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecSystemDataCreatedByTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecSystemDataCreatedByTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210701WorkspacesComputeSpecSystemDataLastModifiedByTypeEnum>))]
public enum V1api20210701WorkspacesComputeSpecSystemDataLastModifiedByTypeEnum
{
    [EnumMember(Value = "Application"), JsonStringEnumMemberName("Application")]
    Application,
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>SystemData: System data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpecSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public V1api20210701WorkspacesComputeSpecSystemDataCreatedByTypeEnum? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public V1api20210701WorkspacesComputeSpecSystemDataLastModifiedByTypeEnum? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701WorkspacesComputeSpecIdentity? Identity { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210701WorkspacesComputeSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a machinelearningservices.azure.com/Workspace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210701WorkspacesComputeSpecOwner Owner { get; set; }

    /// <summary>Properties: Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701WorkspacesComputeSpecProperties? Properties { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20210701WorkspacesComputeSpecSku? Sku { get; set; }

    /// <summary>SystemData: System data</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701WorkspacesComputeSpecSystemData? SystemData { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusConditions
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

/// <summary>User Assigned Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The clientId(aka appId) of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of the user assigned identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The user assigned identities associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210701WorkspacesComputeStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksPropertiesSystemServices
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksProperties
{
    /// <summary>AgentCount: Number of agents</summary>
    [JsonPropertyName("agentCount")]
    public int? AgentCount { get; set; }

    /// <summary>AgentVmSize: Agent virtual machine size</summary>
    [JsonPropertyName("agentVmSize")]
    public string? AgentVmSize { get; set; }

    /// <summary>AksNetworkingConfiguration: AKS networking configuration for vnet</summary>
    [JsonPropertyName("aksNetworkingConfiguration")]
    public V1api20210701WorkspacesComputeStatusPropertiesAksPropertiesAksNetworkingConfiguration? AksNetworkingConfiguration { get; set; }

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
    public V1api20210701WorkspacesComputeStatusPropertiesAksPropertiesSslConfiguration? SslConfiguration { get; set; }

    /// <summary>SystemServices: System services</summary>
    [JsonPropertyName("systemServices")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAksPropertiesSystemServices>? SystemServices { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrorsError? Error { get; set; }
}

/// <summary>AKS: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAks
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
    public V1api20210701WorkspacesComputeStatusPropertiesAksProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAksProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrorsError? Error { get; set; }
}

/// <summary>NodeStateCounts: Counts of various node states on the compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet
{
    /// <summary>Id: The ID of the resource</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials
{
    /// <summary>AdminUserName: Name of the administrator user account which can be used to SSH to nodes.</summary>
    [JsonPropertyName("adminUserName")]
    public string? AdminUserName { get; set; }
}

/// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage
{
    /// <summary>Id: Virtual Machine image path</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Properties: Properties of AmlCompute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProperties
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
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesErrors>? Errors { get; set; }

    /// <summary>IsolatedNetwork: Network is isolated or not</summary>
    [JsonPropertyName("isolatedNetwork")]
    public bool? IsolatedNetwork { get; set; }

    /// <summary>NodeStateCounts: Counts of various node states on the compute.</summary>
    [JsonPropertyName("nodeStateCounts")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesNodeStateCounts? NodeStateCounts { get; set; }

    /// <summary>OsType: Compute OS Type</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

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
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesSubnet? Subnet { get; set; }

    /// <summary>
    /// TargetNodeCount: The target number of compute nodes for the compute. If the allocationState is resizing, this property
    /// denotes the target node count for the ongoing resize operation. If the allocationState is steady, this property denotes
    /// the target node count for the previous resize operation.
    /// </summary>
    [JsonPropertyName("targetNodeCount")]
    public int? TargetNodeCount { get; set; }

    /// <summary>UserAccountCredentials: Credentials for an administrator user account that will be created on each compute node.</summary>
    [JsonPropertyName("userAccountCredentials")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesUserAccountCredentials? UserAccountCredentials { get; set; }

    /// <summary>VirtualMachineImage: Virtual Machine image for AML Compute - windows only</summary>
    [JsonPropertyName("virtualMachineImage")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputePropertiesVirtualMachineImage? VirtualMachineImage { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrorsError? Error { get; set; }
}

/// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesAmlCompute
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
    public V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesAmlComputeProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints
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

/// <summary>CreatedBy: Describes information on user who created this ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy
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

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrorsError? Error { get; set; }
}

/// <summary>LastOperation: The last operation on ComputeInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation
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
}

/// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings
{
    /// <summary>AssignedUser: A user explicitly assigned to a personal compute instance.</summary>
    [JsonPropertyName("assignedUser")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettingsAssignedUser? AssignedUser { get; set; }
}

/// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: inline, workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript
{
    /// <summary>ScriptArguments: Optional command line arguments passed to the script to run.</summary>
    [JsonPropertyName("scriptArguments")]
    public string? ScriptArguments { get; set; }

    /// <summary>ScriptData: The location of scripts in the mounted volume.</summary>
    [JsonPropertyName("scriptData")]
    public string? ScriptData { get; set; }

    /// <summary>ScriptSource: The storage source of the script: inline, workspace.</summary>
    [JsonPropertyName("scriptSource")]
    public string? ScriptSource { get; set; }

    /// <summary>Timeout: Optional time period passed to timeout command.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Scripts: Customized setup scripts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts
{
    /// <summary>CreationScript: Script that&apos;s run only once during provision of the compute.</summary>
    [JsonPropertyName("creationScript")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsCreationScript? CreationScript { get; set; }

    /// <summary>StartupScript: Script that&apos;s run every time the machine starts.</summary>
    [JsonPropertyName("startupScript")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScriptsStartupScript? StartupScript { get; set; }
}

/// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts
{
    /// <summary>Scripts: Customized setup scripts</summary>
    [JsonPropertyName("scripts")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScriptsScripts? Scripts { get; set; }
}

/// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet
{
    /// <summary>Id: The ID of the resource</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Properties: Properties of ComputeInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProperties
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
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesApplications>? Applications { get; set; }

    /// <summary>ComputeInstanceAuthorizationType: The Compute Instance Authorization type. Available values are personal (default).</summary>
    [JsonPropertyName("computeInstanceAuthorizationType")]
    public string? ComputeInstanceAuthorizationType { get; set; }

    /// <summary>ConnectivityEndpoints: Describes all connectivity endpoints available for this ComputeInstance.</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesConnectivityEndpoints? ConnectivityEndpoints { get; set; }

    /// <summary>CreatedBy: Describes information on user who created this ComputeInstance.</summary>
    [JsonPropertyName("createdBy")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesCreatedBy? CreatedBy { get; set; }

    /// <summary>Errors: Collection of errors encountered on this ComputeInstance.</summary>
    [JsonPropertyName("errors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesErrors>? Errors { get; set; }

    /// <summary>LastOperation: The last operation on ComputeInstance.</summary>
    [JsonPropertyName("lastOperation")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesLastOperation? LastOperation { get; set; }

    /// <summary>PersonalComputeInstanceSettings: Settings for a personal compute instance.</summary>
    [JsonPropertyName("personalComputeInstanceSettings")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesPersonalComputeInstanceSettings? PersonalComputeInstanceSettings { get; set; }

    /// <summary>SetupScripts: Details of customized scripts to execute for setting up the cluster.</summary>
    [JsonPropertyName("setupScripts")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSetupScripts? SetupScripts { get; set; }

    /// <summary>SshSettings: Specifies policy and settings for SSH access.</summary>
    [JsonPropertyName("sshSettings")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSshSettings? SshSettings { get; set; }

    /// <summary>State: The current state of this ComputeInstance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Subnet: Virtual network subnet resource ID the compute nodes belong to.</summary>
    [JsonPropertyName("subnet")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstancePropertiesSubnet? Subnet { get; set; }

    /// <summary>VmSize: Virtual Machine Size</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrorsError? Error { get; set; }
}

/// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesComputeInstance
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
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesComputeInstanceProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrorsError? Error { get; set; }
}

/// <summary>DataFactory: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataFactory
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
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataFactoryProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties
{
    /// <summary>DataLakeStoreAccountName: DataLake Store Account Name</summary>
    [JsonPropertyName("dataLakeStoreAccountName")]
    public string? DataLakeStoreAccountName { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrorsError? Error { get; set; }
}

/// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalytics
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
    public V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalyticsProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricksProperties
{
    /// <summary>WorkspaceUrl: Workspace Url</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrorsError? Error { get; set; }
}

/// <summary>Databricks: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesDatabricks
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
    public V1api20210701WorkspacesComputeStatusPropertiesDatabricksProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesDatabricksProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount
{
    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Properties: HDInsight compute properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightProperties
{
    /// <summary>Address: Public IP address of the master node of the cluster.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for master node of the cluster</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701WorkspacesComputeStatusPropertiesHdInsightPropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>SshPort: Port open for ssh connections on the master node of the cluster.</summary>
    [JsonPropertyName("sshPort")]
    public int? SshPort { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrorsError? Error { get; set; }
}

/// <summary>HDInsight: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesHdInsight
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
    public V1api20210701WorkspacesComputeStatusPropertiesHdInsightProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesHdInsightProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes
{
    /// <summary>NodeSelector: Node Selector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>Resources: Resource requests/limits for this instance type</summary>
    [JsonPropertyName("resources")]
    public V1api20210701WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypesResources? Resources { get; set; }
}

/// <summary>Properties: Properties of Kubernetes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesProperties
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
    public IDictionary<string, V1api20210701WorkspacesComputeStatusPropertiesKubernetesPropertiesInstanceTypes>? InstanceTypes { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrorsError? Error { get; set; }
}

/// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesKubernetes
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
    public V1api20210701WorkspacesComputeStatusPropertiesKubernetesProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesKubernetesProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties
{
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutoScaleProperties: Auto scale properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProperties
{
    /// <summary>AutoPauseProperties: Auto pause properties.</summary>
    [JsonPropertyName("autoPauseProperties")]
    public V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoPauseProperties? AutoPauseProperties { get; set; }

    /// <summary>AutoScaleProperties: Auto scale properties.</summary>
    [JsonPropertyName("autoScaleProperties")]
    public V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkPropertiesAutoScaleProperties? AutoScaleProperties { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrorsError? Error { get; set; }
}

/// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesSynapseSpark
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
    public V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesSynapseSparkProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount
{
    /// <summary>Username: Username of admin account</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProperties
{
    /// <summary>Address: Public IP address of the virtual machine.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>AdministratorAccount: Admin credentials for virtual machine</summary>
    [JsonPropertyName("administratorAccount")]
    public V1api20210701WorkspacesComputeStatusPropertiesVirtualMachinePropertiesAdministratorAccount? AdministratorAccount { get; set; }

    /// <summary>IsNotebookInstanceCompute: Indicates whether this compute will be used for running notebooks.</summary>
    [JsonPropertyName("isNotebookInstanceCompute")]
    public bool? IsNotebookInstanceCompute { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo
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
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsErrorDetails>? Details { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors
{
    /// <summary>Error: The error object.</summary>
    [JsonPropertyName("error")]
    public V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrorsError? Error { get; set; }
}

/// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusPropertiesVirtualMachine
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
    public V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProperties? Properties { get; set; }

    /// <summary>ProvisioningErrors: Errors during provisioning</summary>
    [JsonPropertyName("provisioningErrors")]
    public IList<V1api20210701WorkspacesComputeStatusPropertiesVirtualMachineProvisioningErrors>? ProvisioningErrors { get; set; }

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
public partial class V1api20210701WorkspacesComputeStatusProperties
{
    /// <summary>AKS: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("aks")]
    public V1api20210701WorkspacesComputeStatusPropertiesAks? Aks { get; set; }

    /// <summary>AmlCompute: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("amlCompute")]
    public V1api20210701WorkspacesComputeStatusPropertiesAmlCompute? AmlCompute { get; set; }

    /// <summary>ComputeInstance: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("computeInstance")]
    public V1api20210701WorkspacesComputeStatusPropertiesComputeInstance? ComputeInstance { get; set; }

    /// <summary>DataFactory: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataFactory")]
    public V1api20210701WorkspacesComputeStatusPropertiesDataFactory? DataFactory { get; set; }

    /// <summary>DataLakeAnalytics: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dataLakeAnalytics")]
    public V1api20210701WorkspacesComputeStatusPropertiesDataLakeAnalytics? DataLakeAnalytics { get; set; }

    /// <summary>Databricks: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("databricks")]
    public V1api20210701WorkspacesComputeStatusPropertiesDatabricks? Databricks { get; set; }

    /// <summary>HDInsight: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hdInsight")]
    public V1api20210701WorkspacesComputeStatusPropertiesHdInsight? HdInsight { get; set; }

    /// <summary>Kubernetes: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("kubernetes")]
    public V1api20210701WorkspacesComputeStatusPropertiesKubernetes? Kubernetes { get; set; }

    /// <summary>SynapseSpark: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("synapseSpark")]
    public V1api20210701WorkspacesComputeStatusPropertiesSynapseSpark? SynapseSpark { get; set; }

    /// <summary>VirtualMachine: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20210701WorkspacesComputeStatusPropertiesVirtualMachine? VirtualMachine { get; set; }
}

/// <summary>Sku: The sku of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusSku
{
    /// <summary>Name: Name of the sku</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of the sku like Basic or Enterprise</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: System data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210701WorkspacesComputeStatusSystemData
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
public partial class V1api20210701WorkspacesComputeStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210701WorkspacesComputeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701WorkspacesComputeStatusIdentity? Identity { get; set; }

    /// <summary>Location: Specifies the location of the resource.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Compute properties</summary>
    [JsonPropertyName("properties")]
    public V1api20210701WorkspacesComputeStatusProperties? Properties { get; set; }

    /// <summary>Sku: The sku of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V1api20210701WorkspacesComputeStatusSku? Sku { get; set; }

    /// <summary>SystemData: System data</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701WorkspacesComputeStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Contains resource tags defined as key/value pairs.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2021-07-01/machineLearningServices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/computes/{computeName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210701WorkspacesCompute : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210701WorkspacesComputeSpec?>, IStatus<V1api20210701WorkspacesComputeStatus?>
{
    public const string KubeApiVersion = "v1api20210701";
    public const string KubeKind = "WorkspacesCompute";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspacescomputes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.com/v1api20210701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesCompute";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210701WorkspacesComputeSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210701WorkspacesComputeStatus? Status { get; set; }
}