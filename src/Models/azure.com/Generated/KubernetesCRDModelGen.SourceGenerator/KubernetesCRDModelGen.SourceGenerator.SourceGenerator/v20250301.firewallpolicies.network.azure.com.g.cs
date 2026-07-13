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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301FirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V20250301FirewallPolicy>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "FirewallPolicyList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301FirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301FirewallPolicy> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecBasePolicyReference
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

/// <summary>BasePolicy: The parent firewall policy from which rules are inherited.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecBasePolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301FirewallPolicySpecBasePolicyReference? Reference { get; set; }
}

/// <summary>DnsSettings: DNS Proxy Settings definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecDnsSettings
{
    /// <summary>EnableProxy: Enable DNS Proxy on Firewalls attached to the Firewall Policy.</summary>
    [JsonPropertyName("enableProxy")]
    public bool? EnableProxy { get; set; }

    /// <summary>RequireProxyForNetworkRules: FQDNs in Network Rules are supported when set to true.</summary>
    [JsonPropertyName("requireProxyForNetworkRules")]
    public bool? RequireProxyForNetworkRules { get; set; }

    /// <summary>Servers: List of Custom DNS Servers.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>ExplicitProxy: Explicit Proxy Settings definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecExplicitProxy
{
    /// <summary>EnableExplicitProxy: When set to true, explicit proxy mode is enabled.</summary>
    [JsonPropertyName("enableExplicitProxy")]
    public bool? EnableExplicitProxy { get; set; }

    /// <summary>EnablePacFile: When set to true, pac file port and url needs to be provided.</summary>
    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    /// <summary>HttpPort: Port number for explicit proxy http protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary>HttpsPort: Port number for explicit proxy https protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary>PacFile: SAS URL for PAC file.</summary>
    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    /// <summary>PacFilePort: Port number for firewall to serve PAC file.</summary>
    [JsonPropertyName("pacFilePort")]
    public int? PacFilePort { get; set; }
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
/// machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecIdentityTypeEnum>))]
public enum V20250301FirewallPolicySpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250301FirewallPolicySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the firewall policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public V20250301FirewallPolicySpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250301FirewallPolicySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceIdReference
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

/// <summary>DefaultWorkspaceId: The default workspace Id for Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceId
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceIdReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceIdReference
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

/// <summary>WorkspaceId: The workspace Id for Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceId
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceIdReference? Reference { get; set; }
}

/// <summary>Log Analytics Workspace for Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesWorkspaces
{
    /// <summary>Region: Region to configure the Workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>WorkspaceId: The workspace Id for Firewall Policy Insights.</summary>
    [JsonPropertyName("workspaceId")]
    public V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesWorkspacesWorkspaceId? WorkspaceId { get; set; }
}

/// <summary>LogAnalyticsResources: Workspaces needed to configure the Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsightsLogAnalyticsResources
{
    /// <summary>DefaultWorkspaceId: The default workspace Id for Firewall Policy Insights.</summary>
    [JsonPropertyName("defaultWorkspaceId")]
    public V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesDefaultWorkspaceId? DefaultWorkspaceId { get; set; }

    /// <summary>Workspaces: List of workspaces for Firewall Policy Insights.</summary>
    [JsonPropertyName("workspaces")]
    public IList<V20250301FirewallPolicySpecInsightsLogAnalyticsResourcesWorkspaces>? Workspaces { get; set; }
}

/// <summary>Insights: Insights on Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecInsights
{
    /// <summary>IsEnabled: A flag to indicate if the insights are enabled on the policy.</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>LogAnalyticsResources: Workspaces needed to configure the Firewall Policy Insights.</summary>
    [JsonPropertyName("logAnalyticsResources")]
    public V20250301FirewallPolicySpecInsightsLogAnalyticsResources? LogAnalyticsResources { get; set; }

    /// <summary>RetentionDays: Number of days the insights should be enabled on the policy.</summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }
}

/// <summary>Protocol: The rule bypass protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettingsProtocolEnum>))]
public enum V20250301FirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettingsProtocolEnum
{
    [EnumMember(Value = "ANY"), JsonStringEnumMemberName("ANY")]
    ANY,
    [EnumMember(Value = "ICMP"), JsonStringEnumMemberName("ICMP")]
    ICMP,
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>Intrusion detection bypass traffic specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettings
{
    /// <summary>Description: Description of the bypass traffic rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or ranges for this rule.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationIpGroups: List of destination IpGroups for this rule.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>DestinationPorts: List of destination ports or ranges.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Name: Name of the bypass traffic rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The rule bypass protocol.</summary>
    [JsonPropertyName("protocol")]
    public V20250301FirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettingsProtocolEnum? Protocol { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses or ranges for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Mode: The signature state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecIntrusionDetectionConfigurationSignatureOverridesModeEnum>))]
public enum V20250301FirewallPolicySpecIntrusionDetectionConfigurationSignatureOverridesModeEnum
{
    [EnumMember(Value = "Alert"), JsonStringEnumMemberName("Alert")]
    Alert,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Off"), JsonStringEnumMemberName("Off")]
    Off
}

/// <summary>Intrusion detection signatures specification states.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIntrusionDetectionConfigurationSignatureOverrides
{
    /// <summary>Id: Signature id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Mode: The signature state.</summary>
    [JsonPropertyName("mode")]
    public V20250301FirewallPolicySpecIntrusionDetectionConfigurationSignatureOverridesModeEnum? Mode { get; set; }
}

/// <summary>Configuration: Intrusion detection configuration properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIntrusionDetectionConfiguration
{
    /// <summary>BypassTrafficSettings: List of rules for traffic to bypass.</summary>
    [JsonPropertyName("bypassTrafficSettings")]
    public IList<V20250301FirewallPolicySpecIntrusionDetectionConfigurationBypassTrafficSettings>? BypassTrafficSettings { get; set; }

    /// <summary>
    /// PrivateRanges: IDPS Private IP address ranges are used to identify traffic direction (i.e. inbound, outbound, etc.). By
    /// default, only ranges defined by IANA RFC 1918 are considered private IP addresses. To modify default ranges, specify
    /// your Private IP address ranges with this property
    /// </summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    /// <summary>SignatureOverrides: List of specific signatures states.</summary>
    [JsonPropertyName("signatureOverrides")]
    public IList<V20250301FirewallPolicySpecIntrusionDetectionConfigurationSignatureOverrides>? SignatureOverrides { get; set; }
}

/// <summary>
/// Mode: Intrusion detection general state. When attached to a parent policy, the firewall&apos;s effective IDPS mode is the
/// stricter mode of the two.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecIntrusionDetectionModeEnum>))]
public enum V20250301FirewallPolicySpecIntrusionDetectionModeEnum
{
    [EnumMember(Value = "Alert"), JsonStringEnumMemberName("Alert")]
    Alert,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Off"), JsonStringEnumMemberName("Off")]
    Off
}

/// <summary>
/// Profile: IDPS profile name. When attached to a parent policy, the firewall&apos;s effective profile is the profile name of
/// the parent policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecIntrusionDetectionProfileEnum>))]
public enum V20250301FirewallPolicySpecIntrusionDetectionProfileEnum
{
    [EnumMember(Value = "Advanced"), JsonStringEnumMemberName("Advanced")]
    Advanced,
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Extended"), JsonStringEnumMemberName("Extended")]
    Extended,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>IntrusionDetection: The configuration for Intrusion detection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecIntrusionDetection
{
    /// <summary>Configuration: Intrusion detection configuration properties.</summary>
    [JsonPropertyName("configuration")]
    public V20250301FirewallPolicySpecIntrusionDetectionConfiguration? Configuration { get; set; }

    /// <summary>
    /// Mode: Intrusion detection general state. When attached to a parent policy, the firewall&apos;s effective IDPS mode is the
    /// stricter mode of the two.
    /// </summary>
    [JsonPropertyName("mode")]
    public V20250301FirewallPolicySpecIntrusionDetectionModeEnum? Mode { get; set; }

    /// <summary>
    /// Profile: IDPS profile name. When attached to a parent policy, the firewall&apos;s effective profile is the profile name of
    /// the parent policy.
    /// </summary>
    [JsonPropertyName("profile")]
    public V20250301FirewallPolicySpecIntrusionDetectionProfileEnum? Profile { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V20250301FirewallPolicySpecOperatorSpecSecretExpressions
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
public partial class V20250301FirewallPolicySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301FirewallPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301FirewallPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Tier: Tier of Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecSkuTierEnum>))]
public enum V20250301FirewallPolicySpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The Firewall Policy SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecSku
{
    /// <summary>Tier: Tier of Firewall Policy.</summary>
    [JsonPropertyName("tier")]
    public V20250301FirewallPolicySpecSkuTierEnum? Tier { get; set; }
}

/// <summary>AutoLearnPrivateRanges: The operation mode for automatically learning private ranges to not be SNAT</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecSnatAutoLearnPrivateRangesEnum>))]
public enum V20250301FirewallPolicySpecSnatAutoLearnPrivateRangesEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Snat: The private IP addresses/IP ranges to which traffic will not be SNAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecSnat
{
    /// <summary>AutoLearnPrivateRanges: The operation mode for automatically learning private ranges to not be SNAT</summary>
    [JsonPropertyName("autoLearnPrivateRanges")]
    public V20250301FirewallPolicySpecSnatAutoLearnPrivateRangesEnum? AutoLearnPrivateRanges { get; set; }

    /// <summary>PrivateRanges: List of private IP addresses/IP address ranges to not be SNAT.</summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }
}

/// <summary>Sql: SQL Settings definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecSql
{
    /// <summary>
    /// AllowSqlRedirect: A flag to indicate if SQL Redirect traffic filtering is enabled. Turning on the flag requires no rule
    /// using port 11000-11999.
    /// </summary>
    [JsonPropertyName("allowSqlRedirect")]
    public bool? AllowSqlRedirect { get; set; }
}

/// <summary>ThreatIntelMode: The operation mode for Threat Intelligence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301FirewallPolicySpecThreatIntelModeEnum>))]
public enum V20250301FirewallPolicySpecThreatIntelModeEnum
{
    [EnumMember(Value = "Alert"), JsonStringEnumMemberName("Alert")]
    Alert,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Off"), JsonStringEnumMemberName("Off")]
    Off
}

/// <summary>ThreatIntelWhitelist: ThreatIntel Whitelist for Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecThreatIntelWhitelist
{
    /// <summary>Fqdns: List of FQDNs for the ThreatIntel Whitelist.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>IpAddresses: List of IP addresses for the ThreatIntel Whitelist.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>CertificateAuthority: The CA used for intermediate CA generation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecTransportSecurityCertificateAuthority
{
    /// <summary>KeyVaultSecretId: Secret Id of (base-64 encoded unencrypted pfx) &apos;Secret&apos; or &apos;Certificate&apos; object stored in KeyVault.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>Name: Name of the CA certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>TransportSecurity: TLS Configuration definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpecTransportSecurity
{
    /// <summary>CertificateAuthority: The CA used for intermediate CA generation.</summary>
    [JsonPropertyName("certificateAuthority")]
    public V20250301FirewallPolicySpecTransportSecurityCertificateAuthority? CertificateAuthority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicySpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BasePolicy: The parent firewall policy from which rules are inherited.</summary>
    [JsonPropertyName("basePolicy")]
    public V20250301FirewallPolicySpecBasePolicy? BasePolicy { get; set; }

    /// <summary>DnsSettings: DNS Proxy Settings definition.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20250301FirewallPolicySpecDnsSettings? DnsSettings { get; set; }

    /// <summary>ExplicitProxy: Explicit Proxy Settings definition.</summary>
    [JsonPropertyName("explicitProxy")]
    public V20250301FirewallPolicySpecExplicitProxy? ExplicitProxy { get; set; }

    /// <summary>Identity: The identity of the firewall policy.</summary>
    [JsonPropertyName("identity")]
    public V20250301FirewallPolicySpecIdentity? Identity { get; set; }

    /// <summary>Insights: Insights on Firewall Policy.</summary>
    [JsonPropertyName("insights")]
    public V20250301FirewallPolicySpecInsights? Insights { get; set; }

    /// <summary>IntrusionDetection: The configuration for Intrusion detection.</summary>
    [JsonPropertyName("intrusionDetection")]
    public V20250301FirewallPolicySpecIntrusionDetection? IntrusionDetection { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301FirewallPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301FirewallPolicySpecOwner Owner { get; set; }

    /// <summary>Sku: The Firewall Policy SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250301FirewallPolicySpecSku? Sku { get; set; }

    /// <summary>Snat: The private IP addresses/IP ranges to which traffic will not be SNAT.</summary>
    [JsonPropertyName("snat")]
    public V20250301FirewallPolicySpecSnat? Snat { get; set; }

    /// <summary>Sql: SQL Settings definition.</summary>
    [JsonPropertyName("sql")]
    public V20250301FirewallPolicySpecSql? Sql { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ThreatIntelMode: The operation mode for Threat Intelligence.</summary>
    [JsonPropertyName("threatIntelMode")]
    public V20250301FirewallPolicySpecThreatIntelModeEnum? ThreatIntelMode { get; set; }

    /// <summary>ThreatIntelWhitelist: ThreatIntel Whitelist for Firewall Policy.</summary>
    [JsonPropertyName("threatIntelWhitelist")]
    public V20250301FirewallPolicySpecThreatIntelWhitelist? ThreatIntelWhitelist { get; set; }

    /// <summary>TransportSecurity: TLS Configuration definition.</summary>
    [JsonPropertyName("transportSecurity")]
    public V20250301FirewallPolicySpecTransportSecurity? TransportSecurity { get; set; }
}

/// <summary>BasePolicy: The parent firewall policy from which rules are inherited.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusBasePolicy
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusChildPolicies
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusConditions
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

/// <summary>DnsSettings: DNS Proxy Settings definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusDnsSettings
{
    /// <summary>EnableProxy: Enable DNS Proxy on Firewalls attached to the Firewall Policy.</summary>
    [JsonPropertyName("enableProxy")]
    public bool? EnableProxy { get; set; }

    /// <summary>RequireProxyForNetworkRules: FQDNs in Network Rules are supported when set to true.</summary>
    [JsonPropertyName("requireProxyForNetworkRules")]
    public bool? RequireProxyForNetworkRules { get; set; }

    /// <summary>Servers: List of Custom DNS Servers.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>ExplicitProxy: Explicit Proxy Settings definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusExplicitProxy
{
    /// <summary>EnableExplicitProxy: When set to true, explicit proxy mode is enabled.</summary>
    [JsonPropertyName("enableExplicitProxy")]
    public bool? EnableExplicitProxy { get; set; }

    /// <summary>EnablePacFile: When set to true, pac file port and url needs to be provided.</summary>
    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    /// <summary>HttpPort: Port number for explicit proxy http protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary>HttpsPort: Port number for explicit proxy https protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary>PacFile: SAS URL for PAC file.</summary>
    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    /// <summary>PacFilePort: Port number for firewall to serve PAC file.</summary>
    [JsonPropertyName("pacFilePort")]
    public int? PacFilePort { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusFirewalls
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the firewall policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250301FirewallPolicyStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>DefaultWorkspaceId: The default workspace Id for Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusInsightsLogAnalyticsResourcesDefaultWorkspaceId
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>WorkspaceId: The workspace Id for Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspacesWorkspaceId
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Log Analytics Workspace for Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspaces
{
    /// <summary>Region: Region to configure the Workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>WorkspaceId: The workspace Id for Firewall Policy Insights.</summary>
    [JsonPropertyName("workspaceId")]
    public V20250301FirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspacesWorkspaceId? WorkspaceId { get; set; }
}

/// <summary>LogAnalyticsResources: Workspaces needed to configure the Firewall Policy Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusInsightsLogAnalyticsResources
{
    /// <summary>DefaultWorkspaceId: The default workspace Id for Firewall Policy Insights.</summary>
    [JsonPropertyName("defaultWorkspaceId")]
    public V20250301FirewallPolicyStatusInsightsLogAnalyticsResourcesDefaultWorkspaceId? DefaultWorkspaceId { get; set; }

    /// <summary>Workspaces: List of workspaces for Firewall Policy Insights.</summary>
    [JsonPropertyName("workspaces")]
    public IList<V20250301FirewallPolicyStatusInsightsLogAnalyticsResourcesWorkspaces>? Workspaces { get; set; }
}

/// <summary>Insights: Insights on Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusInsights
{
    /// <summary>IsEnabled: A flag to indicate if the insights are enabled on the policy.</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    /// <summary>LogAnalyticsResources: Workspaces needed to configure the Firewall Policy Insights.</summary>
    [JsonPropertyName("logAnalyticsResources")]
    public V20250301FirewallPolicyStatusInsightsLogAnalyticsResources? LogAnalyticsResources { get; set; }

    /// <summary>RetentionDays: Number of days the insights should be enabled on the policy.</summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }
}

/// <summary>Intrusion detection bypass traffic specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusIntrusionDetectionConfigurationBypassTrafficSettings
{
    /// <summary>Description: Description of the bypass traffic rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or ranges for this rule.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationIpGroups: List of destination IpGroups for this rule.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>DestinationPorts: List of destination ports or ranges.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Name: Name of the bypass traffic rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The rule bypass protocol.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses or ranges for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Intrusion detection signatures specification states.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusIntrusionDetectionConfigurationSignatureOverrides
{
    /// <summary>Id: Signature id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Mode: The signature state.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Configuration: Intrusion detection configuration properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusIntrusionDetectionConfiguration
{
    /// <summary>BypassTrafficSettings: List of rules for traffic to bypass.</summary>
    [JsonPropertyName("bypassTrafficSettings")]
    public IList<V20250301FirewallPolicyStatusIntrusionDetectionConfigurationBypassTrafficSettings>? BypassTrafficSettings { get; set; }

    /// <summary>
    /// PrivateRanges: IDPS Private IP address ranges are used to identify traffic direction (i.e. inbound, outbound, etc.). By
    /// default, only ranges defined by IANA RFC 1918 are considered private IP addresses. To modify default ranges, specify
    /// your Private IP address ranges with this property
    /// </summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    /// <summary>SignatureOverrides: List of specific signatures states.</summary>
    [JsonPropertyName("signatureOverrides")]
    public IList<V20250301FirewallPolicyStatusIntrusionDetectionConfigurationSignatureOverrides>? SignatureOverrides { get; set; }
}

/// <summary>IntrusionDetection: The configuration for Intrusion detection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusIntrusionDetection
{
    /// <summary>Configuration: Intrusion detection configuration properties.</summary>
    [JsonPropertyName("configuration")]
    public V20250301FirewallPolicyStatusIntrusionDetectionConfiguration? Configuration { get; set; }

    /// <summary>
    /// Mode: Intrusion detection general state. When attached to a parent policy, the firewall&apos;s effective IDPS mode is the
    /// stricter mode of the two.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Profile: IDPS profile name. When attached to a parent policy, the firewall&apos;s effective profile is the profile name of
    /// the parent policy.
    /// </summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusRuleCollectionGroups
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The Firewall Policy SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusSku
{
    /// <summary>Tier: Tier of Firewall Policy.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Snat: The private IP addresses/IP ranges to which traffic will not be SNAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusSnat
{
    /// <summary>AutoLearnPrivateRanges: The operation mode for automatically learning private ranges to not be SNAT</summary>
    [JsonPropertyName("autoLearnPrivateRanges")]
    public string? AutoLearnPrivateRanges { get; set; }

    /// <summary>PrivateRanges: List of private IP addresses/IP address ranges to not be SNAT.</summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }
}

/// <summary>Sql: SQL Settings definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusSql
{
    /// <summary>
    /// AllowSqlRedirect: A flag to indicate if SQL Redirect traffic filtering is enabled. Turning on the flag requires no rule
    /// using port 11000-11999.
    /// </summary>
    [JsonPropertyName("allowSqlRedirect")]
    public bool? AllowSqlRedirect { get; set; }
}

/// <summary>ThreatIntelWhitelist: ThreatIntel Whitelist for Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusThreatIntelWhitelist
{
    /// <summary>Fqdns: List of FQDNs for the ThreatIntel Whitelist.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>IpAddresses: List of IP addresses for the ThreatIntel Whitelist.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>CertificateAuthority: The CA used for intermediate CA generation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusTransportSecurityCertificateAuthority
{
    /// <summary>KeyVaultSecretId: Secret Id of (base-64 encoded unencrypted pfx) &apos;Secret&apos; or &apos;Certificate&apos; object stored in KeyVault.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>Name: Name of the CA certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>TransportSecurity: TLS Configuration definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatusTransportSecurity
{
    /// <summary>CertificateAuthority: The CA used for intermediate CA generation.</summary>
    [JsonPropertyName("certificateAuthority")]
    public V20250301FirewallPolicyStatusTransportSecurityCertificateAuthority? CertificateAuthority { get; set; }
}

/// <summary>FirewallPolicy Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301FirewallPolicyStatus
{
    /// <summary>BasePolicy: The parent firewall policy from which rules are inherited.</summary>
    [JsonPropertyName("basePolicy")]
    public V20250301FirewallPolicyStatusBasePolicy? BasePolicy { get; set; }

    /// <summary>ChildPolicies: List of references to Child Firewall Policies.</summary>
    [JsonPropertyName("childPolicies")]
    public IList<V20250301FirewallPolicyStatusChildPolicies>? ChildPolicies { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301FirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>DnsSettings: DNS Proxy Settings definition.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20250301FirewallPolicyStatusDnsSettings? DnsSettings { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExplicitProxy: Explicit Proxy Settings definition.</summary>
    [JsonPropertyName("explicitProxy")]
    public V20250301FirewallPolicyStatusExplicitProxy? ExplicitProxy { get; set; }

    /// <summary>Firewalls: List of references to Azure Firewalls that this Firewall Policy is associated with.</summary>
    [JsonPropertyName("firewalls")]
    public IList<V20250301FirewallPolicyStatusFirewalls>? Firewalls { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the firewall policy.</summary>
    [JsonPropertyName("identity")]
    public V20250301FirewallPolicyStatusIdentity? Identity { get; set; }

    /// <summary>Insights: Insights on Firewall Policy.</summary>
    [JsonPropertyName("insights")]
    public V20250301FirewallPolicyStatusInsights? Insights { get; set; }

    /// <summary>IntrusionDetection: The configuration for Intrusion detection.</summary>
    [JsonPropertyName("intrusionDetection")]
    public V20250301FirewallPolicyStatusIntrusionDetection? IntrusionDetection { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the firewall policy resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RuleCollectionGroups: List of references to FirewallPolicyRuleCollectionGroups.</summary>
    [JsonPropertyName("ruleCollectionGroups")]
    public IList<V20250301FirewallPolicyStatusRuleCollectionGroups>? RuleCollectionGroups { get; set; }

    /// <summary>Size: A read-only string that represents the size of the FirewallPolicyPropertiesFormat in MB. (ex 0.5MB)</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Sku: The Firewall Policy SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250301FirewallPolicyStatusSku? Sku { get; set; }

    /// <summary>Snat: The private IP addresses/IP ranges to which traffic will not be SNAT.</summary>
    [JsonPropertyName("snat")]
    public V20250301FirewallPolicyStatusSnat? Snat { get; set; }

    /// <summary>Sql: SQL Settings definition.</summary>
    [JsonPropertyName("sql")]
    public V20250301FirewallPolicyStatusSql? Sql { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ThreatIntelMode: The operation mode for Threat Intelligence.</summary>
    [JsonPropertyName("threatIntelMode")]
    public string? ThreatIntelMode { get; set; }

    /// <summary>ThreatIntelWhitelist: ThreatIntel Whitelist for Firewall Policy.</summary>
    [JsonPropertyName("threatIntelWhitelist")]
    public V20250301FirewallPolicyStatusThreatIntelWhitelist? ThreatIntelWhitelist { get; set; }

    /// <summary>TransportSecurity: TLS Configuration definition.</summary>
    [JsonPropertyName("transportSecurity")]
    public V20250301FirewallPolicyStatusTransportSecurity? TransportSecurity { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301FirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301FirewallPolicySpec?>, IStatus<V20250301FirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "FirewallPolicy";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301FirewallPolicySpec? Spec { get; set; }

    /// <summary>FirewallPolicy Resource.</summary>
    [JsonPropertyName("status")]
    public V20250301FirewallPolicyStatus? Status { get; set; }
}