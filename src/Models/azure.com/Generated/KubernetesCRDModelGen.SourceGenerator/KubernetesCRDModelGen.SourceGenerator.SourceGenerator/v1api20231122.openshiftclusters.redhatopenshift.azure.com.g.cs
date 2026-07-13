#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redhatopenshift.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /redhatopenshift/resource-manager/Microsoft.RedHatOpenShift/OpenShiftClusters/stable/2023-11-22/redhatopenshift.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RedHatOpenShift/openShiftClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231122OpenShiftClusterList : IKubernetesObject<V1ListMeta>, IItems<V1api20231122OpenShiftCluster>
{
    public const string KubeApiVersion = "v1api20231122";
    public const string KubeKind = "OpenShiftClusterList";
    public const string KubeGroup = "redhatopenshift.azure.com";
    public const string KubePluralName = "openshiftclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "redhatopenshift.azure.com/v1api20231122";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OpenShiftClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231122OpenShiftCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231122OpenShiftCluster> Items { get; set; }
}

/// <summary>Visibility: API server visibility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecApiserverProfileVisibilityEnum>))]
public enum V1api20231122OpenShiftClusterSpecApiserverProfileVisibilityEnum
{
    [EnumMember(Value = "Private"), JsonStringEnumMemberName("Private")]
    Private,
    [EnumMember(Value = "Public"), JsonStringEnumMemberName("Public")]
    Public
}

/// <summary>ApiserverProfile: The cluster API server profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecApiserverProfile
{
    /// <summary>Visibility: API server visibility.</summary>
    [JsonPropertyName("visibility")]
    public V1api20231122OpenShiftClusterSpecApiserverProfileVisibilityEnum? Visibility { get; set; }
}

/// <summary>FipsValidatedModules: If FIPS validated crypto modules are used</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecClusterProfileFipsValidatedModulesEnum>))]
public enum V1api20231122OpenShiftClusterSpecClusterProfileFipsValidatedModulesEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PullSecret: The pull secret for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecClusterProfilePullSecret
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

/// <summary>ClusterProfile: The cluster profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecClusterProfile
{
    /// <summary>Domain: The domain for the cluster.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>FipsValidatedModules: If FIPS validated crypto modules are used</summary>
    [JsonPropertyName("fipsValidatedModules")]
    public V1api20231122OpenShiftClusterSpecClusterProfileFipsValidatedModulesEnum? FipsValidatedModules { get; set; }

    /// <summary>PullSecret: The pull secret for the cluster.</summary>
    [JsonPropertyName("pullSecret")]
    public V1api20231122OpenShiftClusterSpecClusterProfilePullSecret? PullSecret { get; set; }

    /// <summary>ResourceGroupId: The ID of the cluster resource group.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Version: The version of the cluster.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Visibility: Ingress visibility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecIngressProfilesVisibilityEnum>))]
public enum V1api20231122OpenShiftClusterSpecIngressProfilesVisibilityEnum
{
    [EnumMember(Value = "Private"), JsonStringEnumMemberName("Private")]
    Private,
    [EnumMember(Value = "Public"), JsonStringEnumMemberName("Public")]
    Public
}

/// <summary>IngressProfile represents an ingress profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecIngressProfiles
{
    /// <summary>Name: The ingress profile name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Visibility: Ingress visibility.</summary>
    [JsonPropertyName("visibility")]
    public V1api20231122OpenShiftClusterSpecIngressProfilesVisibilityEnum? Visibility { get; set; }
}

/// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecMasterProfileDiskEncryptionSetReference
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

/// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecMasterProfileEncryptionAtHostEnum>))]
public enum V1api20231122OpenShiftClusterSpecMasterProfileEncryptionAtHostEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SubnetReference: The Azure resource ID of the master subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecMasterProfileSubnetReference
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

/// <summary>MasterProfile: The cluster master profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecMasterProfile
{
    /// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20231122OpenShiftClusterSpecMasterProfileDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
    [JsonPropertyName("encryptionAtHost")]
    public V1api20231122OpenShiftClusterSpecMasterProfileEncryptionAtHostEnum? EncryptionAtHost { get; set; }

    /// <summary>SubnetReference: The Azure resource ID of the master subnet.</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20231122OpenShiftClusterSpecMasterProfileSubnetReference? SubnetReference { get; set; }

    /// <summary>VmSize: The size of the master VMs.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>ManagedOutboundIps: The desired managed outbound IPs for the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIps
{
    /// <summary>
    /// Count: Count represents the desired number of IPv4 outbound IPs created and managed by Azure for the cluster public load
    /// balancer.  Allowed values are in the range of 1 - 20.  The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>LoadBalancerProfile: The cluster load balancer profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>ManagedOutboundIps: The desired managed outbound IPs for the cluster public load balancer.</summary>
    [JsonPropertyName("managedOutboundIps")]
    public V1api20231122OpenShiftClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIps? ManagedOutboundIps { get; set; }
}

/// <summary>OutboundType: The OutboundType used for egress traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecNetworkProfileOutboundTypeEnum>))]
public enum V1api20231122OpenShiftClusterSpecNetworkProfileOutboundTypeEnum
{
    [EnumMember(Value = "Loadbalancer"), JsonStringEnumMemberName("Loadbalancer")]
    Loadbalancer,
    [EnumMember(Value = "UserDefinedRouting"), JsonStringEnumMemberName("UserDefinedRouting")]
    UserDefinedRouting
}

/// <summary>PreconfiguredNSG: Specifies whether subnets are pre-attached with an NSG</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecNetworkProfilePreconfiguredNSGEnum>))]
public enum V1api20231122OpenShiftClusterSpecNetworkProfilePreconfiguredNSGEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>NetworkProfile: The cluster network profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecNetworkProfile
{
    /// <summary>LoadBalancerProfile: The cluster load balancer profile.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20231122OpenShiftClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>OutboundType: The OutboundType used for egress traffic.</summary>
    [JsonPropertyName("outboundType")]
    public V1api20231122OpenShiftClusterSpecNetworkProfileOutboundTypeEnum? OutboundType { get; set; }

    /// <summary>PodCidr: The CIDR used for OpenShift/Kubernetes Pods.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>PreconfiguredNSG: Specifies whether subnets are pre-attached with an NSG</summary>
    [JsonPropertyName("preconfiguredNSG")]
    public V1api20231122OpenShiftClusterSpecNetworkProfilePreconfiguredNSGEnum? PreconfiguredNSG { get; set; }

    /// <summary>ServiceCidr: The CIDR used for OpenShift/Kubernetes Services.</summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231122OpenShiftClusterSpecOperatorSpecSecretExpressions
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
/// AdminCredentials: indicates where the AdminCredentials secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOperatorSpecSecretsAdminCredentials
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Password: indicates where the Password secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOperatorSpecSecretsPassword
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Username: indicates where the Username secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOperatorSpecSecretsUsername
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOperatorSpecSecrets
{
    /// <summary>
    /// AdminCredentials: indicates where the AdminCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("adminCredentials")]
    public V1api20231122OpenShiftClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>Password: indicates where the Password secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("password")]
    public V1api20231122OpenShiftClusterSpecOperatorSpecSecretsPassword? Password { get; set; }

    /// <summary>Username: indicates where the Username secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("username")]
    public V1api20231122OpenShiftClusterSpecOperatorSpecSecretsUsername? Username { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231122OpenShiftClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231122OpenShiftClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20231122OpenShiftClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ClientIdFromConfig: The client ID used for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecServicePrincipalProfileClientIdFromConfig
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

/// <summary>ClientSecret: The client secret used for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecServicePrincipalProfileClientSecret
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

/// <summary>ServicePrincipalProfile: The cluster service principal profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecServicePrincipalProfile
{
    /// <summary>ClientId: The client ID used for the cluster.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID used for the cluster.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20231122OpenShiftClusterSpecServicePrincipalProfileClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ClientSecret: The client secret used for the cluster.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20231122OpenShiftClusterSpecServicePrincipalProfileClientSecret? ClientSecret { get; set; }
}

/// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecWorkerProfilesDiskEncryptionSetReference
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

/// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231122OpenShiftClusterSpecWorkerProfilesEncryptionAtHostEnum>))]
public enum V1api20231122OpenShiftClusterSpecWorkerProfilesEncryptionAtHostEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SubnetReference: The Azure resource ID of the worker subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecWorkerProfilesSubnetReference
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

/// <summary>WorkerProfile represents a worker profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpecWorkerProfiles
{
    /// <summary>Count: The number of worker VMs.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>DiskEncryptionSetReference: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20231122OpenShiftClusterSpecWorkerProfilesDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>DiskSizeGB: The disk size of the worker VMs.</summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
    [JsonPropertyName("encryptionAtHost")]
    public V1api20231122OpenShiftClusterSpecWorkerProfilesEncryptionAtHostEnum? EncryptionAtHost { get; set; }

    /// <summary>Name: The worker profile name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SubnetReference: The Azure resource ID of the worker subnet.</summary>
    [JsonPropertyName("subnetReference")]
    public V1api20231122OpenShiftClusterSpecWorkerProfilesSubnetReference? SubnetReference { get; set; }

    /// <summary>VmSize: The size of the worker VMs.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterSpec
{
    /// <summary>ApiserverProfile: The cluster API server profile.</summary>
    [JsonPropertyName("apiserverProfile")]
    public V1api20231122OpenShiftClusterSpecApiserverProfile? ApiserverProfile { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ClusterProfile: The cluster profile.</summary>
    [JsonPropertyName("clusterProfile")]
    public V1api20231122OpenShiftClusterSpecClusterProfile? ClusterProfile { get; set; }

    /// <summary>IngressProfiles: The cluster ingress profiles.</summary>
    [JsonPropertyName("ingressProfiles")]
    public IList<V1api20231122OpenShiftClusterSpecIngressProfiles>? IngressProfiles { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MasterProfile: The cluster master profile.</summary>
    [JsonPropertyName("masterProfile")]
    public V1api20231122OpenShiftClusterSpecMasterProfile? MasterProfile { get; set; }

    /// <summary>NetworkProfile: The cluster network profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20231122OpenShiftClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231122OpenShiftClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231122OpenShiftClusterSpecOwner Owner { get; set; }

    /// <summary>ServicePrincipalProfile: The cluster service principal profile.</summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20231122OpenShiftClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>WorkerProfiles: The cluster worker profiles.</summary>
    [JsonPropertyName("workerProfiles")]
    public IList<V1api20231122OpenShiftClusterSpecWorkerProfiles>? WorkerProfiles { get; set; }
}

/// <summary>ApiserverProfile: The cluster API server profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusApiserverProfile
{
    /// <summary>Ip: The IP of the cluster API server.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>Url: The URL to access the cluster API server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Visibility: API server visibility.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>ClusterProfile: The cluster profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusClusterProfile
{
    /// <summary>Domain: The domain for the cluster.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>FipsValidatedModules: If FIPS validated crypto modules are used</summary>
    [JsonPropertyName("fipsValidatedModules")]
    public string? FipsValidatedModules { get; set; }

    /// <summary>ResourceGroupId: The ID of the cluster resource group.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Version: The version of the cluster.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusConditions
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

/// <summary>ConsoleProfile: The console profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusConsoleProfile
{
    /// <summary>Url: The URL to access the cluster console.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>IngressProfile represents an ingress profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusIngressProfiles
{
    /// <summary>Ip: The IP of the ingress.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>Name: The ingress profile name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Visibility: Ingress visibility.</summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>MasterProfile: The cluster master profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusMasterProfile
{
    /// <summary>DiskEncryptionSetId: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary>SubnetId: The Azure resource ID of the master subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>VmSize: The size of the master VMs.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>EffectiveOutboundIP represents an effective outbound IP resource of the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIps
{
    /// <summary>Id: The fully qualified Azure resource id of an IP address resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIps: The desired managed outbound IPs for the cluster public load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIps
{
    /// <summary>
    /// Count: Count represents the desired number of IPv4 outbound IPs created and managed by Azure for the cluster public load
    /// balancer.  Allowed values are in the range of 1 - 20.  The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>LoadBalancerProfile: The cluster load balancer profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusNetworkProfileLoadBalancerProfile
{
    /// <summary>EffectiveOutboundIps: The list of effective outbound IP addresses of the public load balancer.</summary>
    [JsonPropertyName("effectiveOutboundIps")]
    public IList<V1api20231122OpenShiftClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIps>? EffectiveOutboundIps { get; set; }

    /// <summary>ManagedOutboundIps: The desired managed outbound IPs for the cluster public load balancer.</summary>
    [JsonPropertyName("managedOutboundIps")]
    public V1api20231122OpenShiftClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIps? ManagedOutboundIps { get; set; }
}

/// <summary>NetworkProfile: The cluster network profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusNetworkProfile
{
    /// <summary>LoadBalancerProfile: The cluster load balancer profile.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20231122OpenShiftClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>OutboundType: The OutboundType used for egress traffic.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>PodCidr: The CIDR used for OpenShift/Kubernetes Pods.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>PreconfiguredNSG: Specifies whether subnets are pre-attached with an NSG</summary>
    [JsonPropertyName("preconfiguredNSG")]
    public string? PreconfiguredNSG { get; set; }

    /// <summary>ServiceCidr: The CIDR used for OpenShift/Kubernetes Services.</summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }
}

/// <summary>ServicePrincipalProfile: The cluster service principal profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusServicePrincipalProfile
{
    /// <summary>ClientId: The client ID used for the cluster.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusSystemData
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

/// <summary>WorkerProfile represents a worker profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusWorkerProfiles
{
    /// <summary>Count: The number of worker VMs.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>DiskEncryptionSetId: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>DiskSizeGB: The disk size of the worker VMs.</summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary>Name: The worker profile name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SubnetId: The Azure resource ID of the worker subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>VmSize: The size of the worker VMs.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>WorkerProfile represents a worker profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatusWorkerProfilesStatus
{
    /// <summary>Count: The number of worker VMs.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>DiskEncryptionSetId: The resource ID of an associated DiskEncryptionSet, if applicable.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>DiskSizeGB: The disk size of the worker VMs.</summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>EncryptionAtHost: Whether master virtual machines are encrypted at host.</summary>
    [JsonPropertyName("encryptionAtHost")]
    public string? EncryptionAtHost { get; set; }

    /// <summary>Name: The worker profile name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SubnetId: The Azure resource ID of the worker subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>VmSize: The size of the worker VMs.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>OpenShiftCluster represents an Azure Red Hat OpenShift cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231122OpenShiftClusterStatus
{
    /// <summary>ApiserverProfile: The cluster API server profile.</summary>
    [JsonPropertyName("apiserverProfile")]
    public V1api20231122OpenShiftClusterStatusApiserverProfile? ApiserverProfile { get; set; }

    /// <summary>ClusterProfile: The cluster profile.</summary>
    [JsonPropertyName("clusterProfile")]
    public V1api20231122OpenShiftClusterStatusClusterProfile? ClusterProfile { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231122OpenShiftClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ConsoleProfile: The console profile.</summary>
    [JsonPropertyName("consoleProfile")]
    public V1api20231122OpenShiftClusterStatusConsoleProfile? ConsoleProfile { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IngressProfiles: The cluster ingress profiles.</summary>
    [JsonPropertyName("ingressProfiles")]
    public IList<V1api20231122OpenShiftClusterStatusIngressProfiles>? IngressProfiles { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MasterProfile: The cluster master profile.</summary>
    [JsonPropertyName("masterProfile")]
    public V1api20231122OpenShiftClusterStatusMasterProfile? MasterProfile { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: The cluster network profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20231122OpenShiftClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>ProvisioningState: The cluster provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ServicePrincipalProfile: The cluster service principal profile.</summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20231122OpenShiftClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231122OpenShiftClusterStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkerProfiles: The cluster worker profiles.</summary>
    [JsonPropertyName("workerProfiles")]
    public IList<V1api20231122OpenShiftClusterStatusWorkerProfiles>? WorkerProfiles { get; set; }

    /// <summary>WorkerProfilesStatus: The cluster worker profiles status.</summary>
    [JsonPropertyName("workerProfilesStatus")]
    public IList<V1api20231122OpenShiftClusterStatusWorkerProfilesStatus>? WorkerProfilesStatus { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /redhatopenshift/resource-manager/Microsoft.RedHatOpenShift/OpenShiftClusters/stable/2023-11-22/redhatopenshift.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RedHatOpenShift/openShiftClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231122OpenShiftCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231122OpenShiftClusterSpec?>, IStatus<V1api20231122OpenShiftClusterStatus?>
{
    public const string KubeApiVersion = "v1api20231122";
    public const string KubeKind = "OpenShiftCluster";
    public const string KubeGroup = "redhatopenshift.azure.com";
    public const string KubePluralName = "openshiftclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "redhatopenshift.azure.com/v1api20231122";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OpenShiftCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231122OpenShiftClusterSpec? Spec { get; set; }

    /// <summary>OpenShiftCluster represents an Azure Red Hat OpenShift cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20231122OpenShiftClusterStatus? Status { get; set; }
}