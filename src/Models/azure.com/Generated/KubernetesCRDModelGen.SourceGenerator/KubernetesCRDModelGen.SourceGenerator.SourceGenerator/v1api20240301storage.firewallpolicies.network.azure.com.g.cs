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
/// Storage version of v1api20240301.FirewallPolicy
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301storageFirewallPolicy>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "FirewallPolicyList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301storageFirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301storageFirewallPolicy> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecBasePolicyReference
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
/// Storage version of v1api20240301.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecBasePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageFirewallPolicySpecBasePolicyReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.DnsSettings
/// DNS Proxy Settings in Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecDnsSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableProxy")]
    public bool? EnableProxy { get; set; }

    [JsonPropertyName("requireProxyForNetworkRules")]
    public bool? RequireProxyForNetworkRules { get; set; }

    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ExplicitProxy
/// Explicit Proxy Settings in Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecExplicitProxy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableExplicitProxy")]
    public bool? EnableExplicitProxy { get; set; }

    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    [JsonPropertyName("pacFilePort")]
    public int? PacFilePort { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20240301.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageFirewallPolicySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedServiceIdentity
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240301storageFirewallPolicySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceIdReference
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
/// Storage version of v1api20240301.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceId
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceIdReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceIdReference
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
/// Storage version of v1api20240301.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceId
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceIdReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyLogAnalyticsWorkspace
/// Log Analytics Workspace for Firewall Policy Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesWorkspaces
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceId? WorkspaceId { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyLogAnalyticsResources
/// Log Analytics Resources for Firewall Policy Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("defaultWorkspaceId")]
    public V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceId? DefaultWorkspaceId { get; set; }

    [JsonPropertyName("workspaces")]
    public IList<V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResourcesWorkspaces>? Workspaces { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyInsights
/// Firewall Policy Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecInsights
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyLogAnalyticsResources
    /// Log Analytics Resources for Firewall Policy Insights.
    /// </summary>
    [JsonPropertyName("logAnalyticsResources")]
    public V1api20240301storageFirewallPolicySpecInsightsLogAnalyticsResources? LogAnalyticsResources { get; set; }

    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionBypassTrafficSpecifications
/// Intrusion detection bypass traffic specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionSignatureSpecification
/// Intrusion detection signatures specification states.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIntrusionDetectionConfigurationSignatureOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionConfiguration
/// The operation for configuring intrusion detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIntrusionDetectionConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bypassTrafficSettings")]
    public IList<V1api20240301storageFirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettings>? BypassTrafficSettings { get; set; }

    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    [JsonPropertyName("signatureOverrides")]
    public IList<V1api20240301storageFirewallPolicySpecIntrusionDetectionConfigurationSignatureOverrides>? SignatureOverrides { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetection
/// Configuration for intrusion detection mode and rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecIntrusionDetection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionConfiguration
    /// The operation for configuring intrusion detection.
    /// </summary>
    [JsonPropertyName("configuration")]
    public V1api20240301storageFirewallPolicySpecIntrusionDetectionConfiguration? Configuration { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240301storageFirewallPolicySpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240301.FirewallPolicyOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageFirewallPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageFirewallPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicySku
/// SKU of Firewall policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicySNAT
/// The private IP addresses/IP ranges to which traffic will not be SNAT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecSnat
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoLearnPrivateRanges")]
    public string? AutoLearnPrivateRanges { get; set; }

    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicySQL
/// SQL Settings in Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecSql
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowSqlRedirect")]
    public bool? AllowSqlRedirect { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyThreatIntelWhitelist
/// ThreatIntel Whitelist for Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecThreatIntelWhitelist
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyCertificateAuthority
/// Trusted Root certificates properties for tls.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecTransportSecurityCertificateAuthority
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyTransportSecurity
/// Configuration needed to perform TLS termination &amp; initiation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpecTransportSecurity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyCertificateAuthority
    /// Trusted Root certificates properties for tls.
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20240301storageFirewallPolicySpecTransportSecurityCertificateAuthority? CertificateAuthority { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicySpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("basePolicy")]
    public V1api20240301storageFirewallPolicySpecBasePolicy? BasePolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.DnsSettings
    /// DNS Proxy Settings in Firewall Policy.
    /// </summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20240301storageFirewallPolicySpecDnsSettings? DnsSettings { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ExplicitProxy
    /// Explicit Proxy Settings in Firewall Policy.
    /// </summary>
    [JsonPropertyName("explicitProxy")]
    public V1api20240301storageFirewallPolicySpecExplicitProxy? ExplicitProxy { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedServiceIdentity
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageFirewallPolicySpecIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyInsights
    /// Firewall Policy Insights.
    /// </summary>
    [JsonPropertyName("insights")]
    public V1api20240301storageFirewallPolicySpecInsights? Insights { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyIntrusionDetection
    /// Configuration for intrusion detection mode and rules.
    /// </summary>
    [JsonPropertyName("intrusionDetection")]
    public V1api20240301storageFirewallPolicySpecIntrusionDetection? IntrusionDetection { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageFirewallPolicySpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301storageFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicySku
    /// SKU of Firewall policy.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageFirewallPolicySpecSku? Sku { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicySNAT
    /// The private IP addresses/IP ranges to which traffic will not be SNAT.
    /// </summary>
    [JsonPropertyName("snat")]
    public V1api20240301storageFirewallPolicySpecSnat? Snat { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicySQL
    /// SQL Settings in Firewall Policy.
    /// </summary>
    [JsonPropertyName("sql")]
    public V1api20240301storageFirewallPolicySpecSql? Sql { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("threatIntelMode")]
    public string? ThreatIntelMode { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyThreatIntelWhitelist
    /// ThreatIntel Whitelist for Firewall Policy.
    /// </summary>
    [JsonPropertyName("threatIntelWhitelist")]
    public V1api20240301storageFirewallPolicySpecThreatIntelWhitelist? ThreatIntelWhitelist { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyTransportSecurity
    /// Configuration needed to perform TLS termination &amp; initiation.
    /// </summary>
    [JsonPropertyName("transportSecurity")]
    public V1api20240301storageFirewallPolicySpecTransportSecurity? TransportSecurity { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusBasePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusChildPolicies
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusConditions
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

/// <summary>
/// Storage version of v1api20240301.DnsSettings_STATUS
/// DNS Proxy Settings in Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusDnsSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableProxy")]
    public bool? EnableProxy { get; set; }

    [JsonPropertyName("requireProxyForNetworkRules")]
    public bool? RequireProxyForNetworkRules { get; set; }

    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ExplicitProxy_STATUS
/// Explicit Proxy Settings in Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusExplicitProxy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enableExplicitProxy")]
    public bool? EnableExplicitProxy { get; set; }

    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    [JsonPropertyName("pacFilePort")]
    public int? PacFilePort { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusFirewalls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedServiceIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedServiceIdentity_STATUS
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240301storageFirewallPolicyStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResourcesDefaultWorkspaceId
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspacesWorkspaceId
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyLogAnalyticsWorkspace_STATUS
/// Log Analytics Workspace for Firewall Policy Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspaces
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspacesWorkspaceId? WorkspaceId { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyLogAnalyticsResources_STATUS
/// Log Analytics Resources for Firewall Policy Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("defaultWorkspaceId")]
    public V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResourcesDefaultWorkspaceId? DefaultWorkspaceId { get; set; }

    [JsonPropertyName("workspaces")]
    public IList<V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspaces>? Workspaces { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyInsights_STATUS
/// Firewall Policy Insights.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusInsights
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyLogAnalyticsResources_STATUS
    /// Log Analytics Resources for Firewall Policy Insights.
    /// </summary>
    [JsonPropertyName("logAnalyticsResources")]
    public V1api20240301storageFirewallPolicyStatusInsightsLogAnalyticsResources? LogAnalyticsResources { get; set; }

    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionBypassTrafficSpecifications_STATUS
/// Intrusion detection bypass traffic specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusIntrusionDetectionConfigurationBypassTrafficSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionSignatureSpecification_STATUS
/// Intrusion detection signatures specification states.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusIntrusionDetectionConfigurationSignatureOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionConfiguration_STATUS
/// The operation for configuring intrusion detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusIntrusionDetectionConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bypassTrafficSettings")]
    public IList<V1api20240301storageFirewallPolicyStatusIntrusionDetectionConfigurationBypassTrafficSettings>? BypassTrafficSettings { get; set; }

    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    [JsonPropertyName("signatureOverrides")]
    public IList<V1api20240301storageFirewallPolicyStatusIntrusionDetectionConfigurationSignatureOverrides>? SignatureOverrides { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyIntrusionDetection_STATUS
/// Configuration for intrusion detection mode and rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusIntrusionDetection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyIntrusionDetectionConfiguration_STATUS
    /// The operation for configuring intrusion detection.
    /// </summary>
    [JsonPropertyName("configuration")]
    public V1api20240301storageFirewallPolicyStatusIntrusionDetectionConfiguration? Configuration { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusRuleCollectionGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicySku_STATUS
/// SKU of Firewall policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicySNAT_STATUS
/// The private IP addresses/IP ranges to which traffic will not be SNAT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusSnat
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoLearnPrivateRanges")]
    public string? AutoLearnPrivateRanges { get; set; }

    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicySQL_STATUS
/// SQL Settings in Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusSql
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowSqlRedirect")]
    public bool? AllowSqlRedirect { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyThreatIntelWhitelist_STATUS
/// ThreatIntel Whitelist for Firewall Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusThreatIntelWhitelist
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyCertificateAuthority_STATUS
/// Trusted Root certificates properties for tls.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusTransportSecurityCertificateAuthority
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyTransportSecurity_STATUS
/// Configuration needed to perform TLS termination &amp; initiation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatusTransportSecurity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyCertificateAuthority_STATUS
    /// Trusted Root certificates properties for tls.
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20240301storageFirewallPolicyStatusTransportSecurityCertificateAuthority? CertificateAuthority { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicy_STATUS
/// FirewallPolicy Resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPolicyStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("basePolicy")]
    public V1api20240301storageFirewallPolicyStatusBasePolicy? BasePolicy { get; set; }

    [JsonPropertyName("childPolicies")]
    public IList<V1api20240301storageFirewallPolicyStatusChildPolicies>? ChildPolicies { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.DnsSettings_STATUS
    /// DNS Proxy Settings in Firewall Policy.
    /// </summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20240301storageFirewallPolicyStatusDnsSettings? DnsSettings { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ExplicitProxy_STATUS
    /// Explicit Proxy Settings in Firewall Policy.
    /// </summary>
    [JsonPropertyName("explicitProxy")]
    public V1api20240301storageFirewallPolicyStatusExplicitProxy? ExplicitProxy { get; set; }

    [JsonPropertyName("firewalls")]
    public IList<V1api20240301storageFirewallPolicyStatusFirewalls>? Firewalls { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedServiceIdentity_STATUS
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageFirewallPolicyStatusIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyInsights_STATUS
    /// Firewall Policy Insights.
    /// </summary>
    [JsonPropertyName("insights")]
    public V1api20240301storageFirewallPolicyStatusInsights? Insights { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyIntrusionDetection_STATUS
    /// Configuration for intrusion detection mode and rules.
    /// </summary>
    [JsonPropertyName("intrusionDetection")]
    public V1api20240301storageFirewallPolicyStatusIntrusionDetection? IntrusionDetection { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("ruleCollectionGroups")]
    public IList<V1api20240301storageFirewallPolicyStatusRuleCollectionGroups>? RuleCollectionGroups { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicySku_STATUS
    /// SKU of Firewall policy.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageFirewallPolicyStatusSku? Sku { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicySNAT_STATUS
    /// The private IP addresses/IP ranges to which traffic will not be SNAT.
    /// </summary>
    [JsonPropertyName("snat")]
    public V1api20240301storageFirewallPolicyStatusSnat? Snat { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicySQL_STATUS
    /// SQL Settings in Firewall Policy.
    /// </summary>
    [JsonPropertyName("sql")]
    public V1api20240301storageFirewallPolicyStatusSql? Sql { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("threatIntelMode")]
    public string? ThreatIntelMode { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyThreatIntelWhitelist_STATUS
    /// ThreatIntel Whitelist for Firewall Policy.
    /// </summary>
    [JsonPropertyName("threatIntelWhitelist")]
    public V1api20240301storageFirewallPolicyStatusThreatIntelWhitelist? ThreatIntelWhitelist { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyTransportSecurity_STATUS
    /// Configuration needed to perform TLS termination &amp; initiation.
    /// </summary>
    [JsonPropertyName("transportSecurity")]
    public V1api20240301storageFirewallPolicyStatusTransportSecurity? TransportSecurity { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicy
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageFirewallPolicySpec?>, IStatus<V1api20240301storageFirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "FirewallPolicy";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageFirewallPolicySpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicy_STATUS
    /// FirewallPolicy Resource.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20240301storageFirewallPolicyStatus? Status { get; set; }
}