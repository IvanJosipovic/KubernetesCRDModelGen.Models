#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.crossplane.io;
/// <summary>MwsNetworkConnectivityConfig is the Schema for the MwsNetworkConnectivityConfigs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MwsNetworkConnectivityConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MwsNetworkConnectivityConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MwsNetworkConnectivityConfigList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnetworkconnectivityconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsNetworkConnectivityConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MwsNetworkConnectivityConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MwsNetworkConnectivityConfig> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsNetworkConnectivityConfigSpecDeletionPolicyEnum>))]
public enum V1beta1MwsNetworkConnectivityConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAwsStableIpRule
{
    /// <summary>list of IP CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }
}

/// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAzureServiceEndpointRule
{
    /// <summary>list of subnets from which Databricks network traffic originates when accessing your Azure resources.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>the Azure region in which this service endpoint rule applies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }

    /// <summary>the Azure services to which this service endpoint rule applies to.</summary>
    [JsonPropertyName("targetServices")]
    public IList<string>? TargetServices { get; set; }
}

/// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRules
{
    /// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
    [JsonPropertyName("awsStableIpRule")]
    public V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAwsStableIpRule? AwsStableIpRule { get; set; }

    /// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
    [JsonPropertyName("azureServiceEndpointRule")]
    public V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRulesAzureServiceEndpointRule? AzureServiceEndpointRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAwsPrivateEndpointRules
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAzurePrivateEndpointRules
{
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}

/// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRules
{
    /// <summary>list containing information about configure AWS Private Endpoints.</summary>
    [JsonPropertyName("awsPrivateEndpointRules")]
    public IList<V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAwsPrivateEndpointRules>? AwsPrivateEndpointRules { get; set; }

    /// <summary>list containing information about configure Azure Private Endpoints.</summary>
    [JsonPropertyName("azurePrivateEndpointRules")]
    public IList<V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRulesAzurePrivateEndpointRules>? AzurePrivateEndpointRules { get; set; }
}

/// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfig
{
    /// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
    [JsonPropertyName("defaultRules")]
    public V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigDefaultRules? DefaultRules { get; set; }

    /// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
    [JsonPropertyName("targetRules")]
    public V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfigTargetRules? TargetRules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecForProvider
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
    [JsonPropertyName("egressConfig")]
    public V1beta1MwsNetworkConnectivityConfigSpecForProviderEgressConfig? EgressConfig { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>Region of the Network Connectivity Config. NCCs can only be referenced by your workspaces in the same region. Change forces creation of a new resource.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}

/// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAwsStableIpRule
{
    /// <summary>list of IP CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }
}

/// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAzureServiceEndpointRule
{
    /// <summary>list of subnets from which Databricks network traffic originates when accessing your Azure resources.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>the Azure region in which this service endpoint rule applies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }

    /// <summary>the Azure services to which this service endpoint rule applies to.</summary>
    [JsonPropertyName("targetServices")]
    public IList<string>? TargetServices { get; set; }
}

/// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRules
{
    /// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
    [JsonPropertyName("awsStableIpRule")]
    public V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAwsStableIpRule? AwsStableIpRule { get; set; }

    /// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
    [JsonPropertyName("azureServiceEndpointRule")]
    public V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRulesAzureServiceEndpointRule? AzureServiceEndpointRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAwsPrivateEndpointRules
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAzurePrivateEndpointRules
{
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}

/// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRules
{
    /// <summary>list containing information about configure AWS Private Endpoints.</summary>
    [JsonPropertyName("awsPrivateEndpointRules")]
    public IList<V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAwsPrivateEndpointRules>? AwsPrivateEndpointRules { get; set; }

    /// <summary>list containing information about configure Azure Private Endpoints.</summary>
    [JsonPropertyName("azurePrivateEndpointRules")]
    public IList<V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRulesAzurePrivateEndpointRules>? AzurePrivateEndpointRules { get; set; }
}

/// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfig
{
    /// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
    [JsonPropertyName("defaultRules")]
    public V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigDefaultRules? DefaultRules { get; set; }

    /// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
    [JsonPropertyName("targetRules")]
    public V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfigTargetRules? TargetRules { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecInitProvider
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
    [JsonPropertyName("egressConfig")]
    public V1beta1MwsNetworkConnectivityConfigSpecInitProviderEgressConfig? EgressConfig { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>Region of the Network Connectivity Config. NCCs can only be referenced by your workspaces in the same region. Change forces creation of a new resource.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsNetworkConnectivityConfigSpecManagementPoliciesEnum>))]
public enum V1beta1MwsNetworkConnectivityConfigSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MwsNetworkConnectivityConfigSpec defines the desired state of MwsNetworkConnectivityConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1MwsNetworkConnectivityConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1MwsNetworkConnectivityConfigSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MwsNetworkConnectivityConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MwsNetworkConnectivityConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MwsNetworkConnectivityConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MwsNetworkConnectivityConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAwsStableIpRule
{
    /// <summary>list of IP CIDR blocks.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<string>? CidrBlocks { get; set; }
}

/// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAzureServiceEndpointRule
{
    /// <summary>list of subnets from which Databricks network traffic originates when accessing your Azure resources.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>the Azure region in which this service endpoint rule applies.</summary>
    [JsonPropertyName("targetRegion")]
    public string? TargetRegion { get; set; }

    /// <summary>the Azure services to which this service endpoint rule applies to.</summary>
    [JsonPropertyName("targetServices")]
    public IList<string>? TargetServices { get; set; }
}

/// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRules
{
    /// <summary>block with information about stable AWS IP CIDR blocks. You can use these to configure the firewall of your resources to allow traffic from your Databricks workspace.  Consists of the following fields:</summary>
    [JsonPropertyName("awsStableIpRule")]
    public V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAwsStableIpRule? AwsStableIpRule { get; set; }

    /// <summary>block with information about stable Azure service endpoints. You can configure the firewall of your Azure resources to allow traffic from your Databricks serverless compute resources.  Consists of the following fields:</summary>
    [JsonPropertyName("azureServiceEndpointRule")]
    public V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRulesAzureServiceEndpointRule? AzureServiceEndpointRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAwsPrivateEndpointRules
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAzurePrivateEndpointRules
{
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}

/// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRules
{
    /// <summary>list containing information about configure AWS Private Endpoints.</summary>
    [JsonPropertyName("awsPrivateEndpointRules")]
    public IList<V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAwsPrivateEndpointRules>? AwsPrivateEndpointRules { get; set; }

    /// <summary>list containing information about configure Azure Private Endpoints.</summary>
    [JsonPropertyName("azurePrivateEndpointRules")]
    public IList<V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRulesAzurePrivateEndpointRules>? AzurePrivateEndpointRules { get; set; }
}

/// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfig
{
    /// <summary>block describing network connectivity rules that are applied by default without resource specific configurations.  Consists of the following fields:</summary>
    [JsonPropertyName("defaultRules")]
    public V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigDefaultRules? DefaultRules { get; set; }

    /// <summary>block describing network connectivity rules that configured for each destinations. These rules override default rules.  Consists of the following fields:</summary>
    [JsonPropertyName("targetRules")]
    public V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfigTargetRules? TargetRules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusAtProvider
{
    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>block containing information about network connectivity rules that apply to network traffic from your serverless compute resources. Consists of the following fields:</summary>
    [JsonPropertyName("egressConfig")]
    public V1beta1MwsNetworkConnectivityConfigStatusAtProviderEgressConfig? EgressConfig { get; set; }

    /// <summary>combination of account_id and network_connectivity_config_id separated by / character</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the network connectivity configuration. The name can contain alphanumeric characters, hyphens, and underscores. The length must be between 3 and 30 characters. The name must match the regular expression ^[0-9a-zA-Z-_]{3,30}$. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>Region of the Network Connectivity Config. NCCs can only be referenced by your workspaces in the same region. Change forces creation of a new resource.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>MwsNetworkConnectivityConfigStatus defines the observed state of MwsNetworkConnectivityConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsNetworkConnectivityConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MwsNetworkConnectivityConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MwsNetworkConnectivityConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MwsNetworkConnectivityConfig is the Schema for the MwsNetworkConnectivityConfigs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MwsNetworkConnectivityConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MwsNetworkConnectivityConfigSpec>, IStatus<V1beta1MwsNetworkConnectivityConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MwsNetworkConnectivityConfig";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnetworkconnectivityconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsNetworkConnectivityConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsNetworkConnectivityConfigSpec defines the desired state of MwsNetworkConnectivityConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MwsNetworkConnectivityConfigSpec Spec { get; set; }

    /// <summary>MwsNetworkConnectivityConfigStatus defines the observed state of MwsNetworkConnectivityConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1MwsNetworkConnectivityConfigStatus? Status { get; set; }
}