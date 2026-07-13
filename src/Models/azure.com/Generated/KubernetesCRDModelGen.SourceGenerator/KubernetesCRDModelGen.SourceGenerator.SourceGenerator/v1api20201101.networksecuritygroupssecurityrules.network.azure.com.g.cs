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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/networkSecurityGroup.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleList : IKubernetesObject<V1ListMeta>, IItems<V1api20201101NetworkSecurityGroupsSecurityRule>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "NetworkSecurityGroupsSecurityRuleList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "networksecuritygroupssecurityrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityGroupsSecurityRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201101NetworkSecurityGroupsSecurityRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201101NetworkSecurityGroupsSecurityRule> Items { get; set; }
}

/// <summary>Access: The network traffic is allowed or denied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101NetworkSecurityGroupsSecurityRuleSpecAccessEnum>))]
public enum V1api20201101NetworkSecurityGroupsSecurityRuleSpecAccessEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecDestinationApplicationSecurityGroupsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecDestinationApplicationSecurityGroups
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101NetworkSecurityGroupsSecurityRuleSpecDestinationApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Direction: The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101NetworkSecurityGroupsSecurityRuleSpecDirectionEnum>))]
public enum V1api20201101NetworkSecurityGroupsSecurityRuleSpecDirectionEnum
{
    [EnumMember(Value = "Inbound"), JsonStringEnumMemberName("Inbound")]
    Inbound,
    [EnumMember(Value = "Outbound"), JsonStringEnumMemberName("Outbound")]
    Outbound
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecOperatorSpecSecretExpressions
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
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/NetworkSecurityGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Protocol: Network protocol this rule applies to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101NetworkSecurityGroupsSecurityRuleSpecProtocolEnum>))]
public enum V1api20201101NetworkSecurityGroupsSecurityRuleSpecProtocolEnum
{
    [EnumMember(Value = "Ah"), JsonStringEnumMemberName("Ah")]
    Ah,
    [EnumMember(Value = "Esp"), JsonStringEnumMemberName("Esp")]
    Esp,
    [EnumMember(Value = "Icmp"), JsonStringEnumMemberName("Icmp")]
    Icmp,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option3,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Udp"), JsonStringEnumMemberName("Udp")]
    Udp
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecSourceApplicationSecurityGroupsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpecSourceApplicationSecurityGroups
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101NetworkSecurityGroupsSecurityRuleSpecSourceApplicationSecurityGroupsReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleSpec
{
    /// <summary>Access: The network traffic is allowed or denied.</summary>
    [JsonPropertyName("access")]
    public required V1api20201101NetworkSecurityGroupsSecurityRuleSpecAccessEnum Access { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Description: A description for this rule. Restricted to 140 chars.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DestinationAddressPrefix: The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to
    /// match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used.
    /// </summary>
    [JsonPropertyName("destinationAddressPrefix")]
    public string? DestinationAddressPrefix { get; set; }

    /// <summary>DestinationAddressPrefixes: The destination address prefixes. CIDR or destination IP ranges.</summary>
    [JsonPropertyName("destinationAddressPrefixes")]
    public IList<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>DestinationApplicationSecurityGroups: The application security group specified as destination.</summary>
    [JsonPropertyName("destinationApplicationSecurityGroups")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleSpecDestinationApplicationSecurityGroups>? DestinationApplicationSecurityGroups { get; set; }

    /// <summary>
    /// DestinationPortRange: The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used
    /// to match all ports.
    /// </summary>
    [JsonPropertyName("destinationPortRange")]
    public string? DestinationPortRange { get; set; }

    /// <summary>DestinationPortRanges: The destination port ranges.</summary>
    [JsonPropertyName("destinationPortRanges")]
    public IList<string>? DestinationPortRanges { get; set; }

    /// <summary>Direction: The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.</summary>
    [JsonPropertyName("direction")]
    public required V1api20201101NetworkSecurityGroupsSecurityRuleSpecDirectionEnum Direction { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201101NetworkSecurityGroupsSecurityRuleSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/NetworkSecurityGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201101NetworkSecurityGroupsSecurityRuleSpecOwner Owner { get; set; }

    /// <summary>
    /// Priority: The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each
    /// rule in the collection. The lower the priority number, the higher the priority of the rule.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Protocol: Network protocol this rule applies to.</summary>
    [JsonPropertyName("protocol")]
    public required V1api20201101NetworkSecurityGroupsSecurityRuleSpecProtocolEnum Protocol { get; set; }

    /// <summary>
    /// SourceAddressPrefix: The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags
    /// such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies
    /// where network traffic originates from.
    /// </summary>
    [JsonPropertyName("sourceAddressPrefix")]
    public string? SourceAddressPrefix { get; set; }

    /// <summary>SourceAddressPrefixes: The CIDR or source IP ranges.</summary>
    [JsonPropertyName("sourceAddressPrefixes")]
    public IList<string>? SourceAddressPrefixes { get; set; }

    /// <summary>SourceApplicationSecurityGroups: The application security group specified as source.</summary>
    [JsonPropertyName("sourceApplicationSecurityGroups")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleSpecSourceApplicationSecurityGroups>? SourceApplicationSecurityGroups { get; set; }

    /// <summary>
    /// SourcePortRange: The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match
    /// all ports.
    /// </summary>
    [JsonPropertyName("sourcePortRange")]
    public string? SourcePortRange { get; set; }

    /// <summary>SourcePortRanges: The source port ranges.</summary>
    [JsonPropertyName("sourcePortRanges")]
    public IList<string>? SourcePortRanges { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleStatusConditions
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

/// <summary>An application security group in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleStatusDestinationApplicationSecurityGroups
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>An application security group in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleStatusSourceApplicationSecurityGroups
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101NetworkSecurityGroupsSecurityRuleStatus
{
    /// <summary>Access: The network traffic is allowed or denied.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleStatusConditions>? Conditions { get; set; }

    /// <summary>Description: A description for this rule. Restricted to 140 chars.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// DestinationAddressPrefix: The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to
    /// match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used.
    /// </summary>
    [JsonPropertyName("destinationAddressPrefix")]
    public string? DestinationAddressPrefix { get; set; }

    /// <summary>DestinationAddressPrefixes: The destination address prefixes. CIDR or destination IP ranges.</summary>
    [JsonPropertyName("destinationAddressPrefixes")]
    public IList<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>DestinationApplicationSecurityGroups: The application security group specified as destination.</summary>
    [JsonPropertyName("destinationApplicationSecurityGroups")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleStatusDestinationApplicationSecurityGroups>? DestinationApplicationSecurityGroups { get; set; }

    /// <summary>
    /// DestinationPortRange: The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used
    /// to match all ports.
    /// </summary>
    [JsonPropertyName("destinationPortRange")]
    public string? DestinationPortRange { get; set; }

    /// <summary>DestinationPortRanges: The destination port ranges.</summary>
    [JsonPropertyName("destinationPortRanges")]
    public IList<string>? DestinationPortRanges { get; set; }

    /// <summary>Direction: The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Priority: The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each
    /// rule in the collection. The lower the priority number, the higher the priority of the rule.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Protocol: Network protocol this rule applies to.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the security rule resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// SourceAddressPrefix: The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags
    /// such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies
    /// where network traffic originates from.
    /// </summary>
    [JsonPropertyName("sourceAddressPrefix")]
    public string? SourceAddressPrefix { get; set; }

    /// <summary>SourceAddressPrefixes: The CIDR or source IP ranges.</summary>
    [JsonPropertyName("sourceAddressPrefixes")]
    public IList<string>? SourceAddressPrefixes { get; set; }

    /// <summary>SourceApplicationSecurityGroups: The application security group specified as source.</summary>
    [JsonPropertyName("sourceApplicationSecurityGroups")]
    public IList<V1api20201101NetworkSecurityGroupsSecurityRuleStatusSourceApplicationSecurityGroups>? SourceApplicationSecurityGroups { get; set; }

    /// <summary>
    /// SourcePortRange: The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match
    /// all ports.
    /// </summary>
    [JsonPropertyName("sourcePortRange")]
    public string? SourcePortRange { get; set; }

    /// <summary>SourcePortRanges: The source port ranges.</summary>
    [JsonPropertyName("sourcePortRanges")]
    public IList<string>? SourcePortRanges { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/networkSecurityGroup.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}/securityRules/{securityRuleName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101NetworkSecurityGroupsSecurityRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101NetworkSecurityGroupsSecurityRuleSpec?>, IStatus<V1api20201101NetworkSecurityGroupsSecurityRuleStatus?>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "NetworkSecurityGroupsSecurityRule";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "networksecuritygroupssecurityrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityGroupsSecurityRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20201101NetworkSecurityGroupsSecurityRuleSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20201101NetworkSecurityGroupsSecurityRuleStatus? Status { get; set; }
}