#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>FirewallPolicy is the Schema for the FirewallPolicys API. Manages a Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FirewallPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FirewallPolicyList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FirewallPolicy> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecDeletionPolicyEnum>))]
public enum V1beta2FirewallPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A dns block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderDns
{
    /// <summary>Whether to enable DNS proxy on Firewalls attached to this Firewall Policy? Defaults to false.</summary>
    [JsonPropertyName("proxyEnabled")]
    public bool? ProxyEnabled { get; set; }

    /// <summary>A list of custom DNS servers&apos; IP addresses.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>A explicit_proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderExplicitProxy
{
    /// <summary>Whether the pac file port and url need to be provided.</summary>
    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    /// <summary>Whether the explicit proxy is enabled for this Firewall Policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The port number for explicit http protocol.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The port number for explicit proxy https protocol.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>Specifies a SAS URL for PAC file.</summary>
    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    /// <summary>Specifies a port number for firewall to serve PAC file.</summary>
    [JsonPropertyName("pacFilePort")]
    public double? PacFilePort { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Firewall Policy.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Firewall Policy. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderInsightsLogAnalyticsWorkspace
{
    /// <summary>The location of the Firewalls, that when matches this Log Analytics Workspace will be used to consume their logs.</summary>
    [JsonPropertyName("firewallLocation")]
    public string? FirewallLocation { get; set; }

    /// <summary>12-digit number (id) which identifies your signature.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>An insights block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderInsights
{
    /// <summary>The ID of the default Log Analytics Workspace that the Firewalls associated with this Firewall Policy will send their logs to, when there is no location matches in the log_analytics_workspace.</summary>
    [JsonPropertyName("defaultLogAnalyticsWorkspaceId")]
    public string? DefaultLogAnalyticsWorkspaceId { get; set; }

    /// <summary>Whether the insights functionality is enabled for this Firewall Policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of log_analytics_workspace block as defined below.</summary>
    [JsonPropertyName("logAnalyticsWorkspace")]
    public IList<V1beta2FirewallPolicySpecForProviderInsightsLogAnalyticsWorkspace>? LogAnalyticsWorkspace { get; set; }

    /// <summary>The log retention period in days.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderIntrusionDetectionSignatureOverrides
{
    /// <summary>12-digit number (id) which identifies your signature.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>state can be any of Off, Alert or Deny.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderIntrusionDetectionTrafficBypass
{
    /// <summary>The description for this bypass traffic setting.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination IP groups that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>Specifies a list of destination IP ports that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this bypass traffic setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The protocols any of ANY, TCP, ICMP, UDP that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a list of source addresses that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>A intrusion_detection block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderIntrusionDetection
{
    /// <summary>In which mode you want to run intrusion detection: Off, Alert or Deny.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>A list of Private IP address ranges to identify traffic direction. By default, only ranges defined by IANA RFC 1918 are considered private IP addresses.</summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    /// <summary>One or more signature_overrides blocks as defined below.</summary>
    [JsonPropertyName("signatureOverrides")]
    public IList<V1beta2FirewallPolicySpecForProviderIntrusionDetectionSignatureOverrides>? SignatureOverrides { get; set; }

    /// <summary>One or more traffic_bypass blocks as defined below.</summary>
    [JsonPropertyName("trafficBypass")]
    public IList<V1beta2FirewallPolicySpecForProviderIntrusionDetectionTrafficBypass>? TrafficBypass { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderResourceGroupNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A threat_intelligence_allowlist block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderThreatIntelligenceAllowlist
{
    /// <summary>A list of FQDNs that will be skipped for threat detection.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP addresses or CIDR ranges that will be skipped for threat detection.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>A tls_certificate block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderTlsCertificate
{
    /// <summary>The Secret Identifier (URI) of the certificate stored in Azure Key Vault, either as a secret or certificate.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProvider
{
    /// <summary>Whether enable auto learn private ip range.</summary>
    [JsonPropertyName("autoLearnPrivateRangesEnabled")]
    public bool? AutoLearnPrivateRangesEnabled { get; set; }

    /// <summary>The ID of the base Firewall Policy.</summary>
    [JsonPropertyName("basePolicyId")]
    public string? BasePolicyId { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public V1beta2FirewallPolicySpecForProviderDns? Dns { get; set; }

    /// <summary>A explicit_proxy block as defined below.</summary>
    [JsonPropertyName("explicitProxy")]
    public V1beta2FirewallPolicySpecForProviderExplicitProxy? ExplicitProxy { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2FirewallPolicySpecForProviderIdentity? Identity { get; set; }

    /// <summary>An insights block as defined below.</summary>
    [JsonPropertyName("insights")]
    public V1beta2FirewallPolicySpecForProviderInsights? Insights { get; set; }

    /// <summary>A intrusion_detection block as defined below.</summary>
    [JsonPropertyName("intrusionDetection")]
    public V1beta2FirewallPolicySpecForProviderIntrusionDetection? IntrusionDetection { get; set; }

    /// <summary>The Azure Region where the Firewall Policy should exist. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of private IP ranges to which traffic will not be SNAT.</summary>
    [JsonPropertyName("privateIpRanges")]
    public IList<string>? PrivateIpRanges { get; set; }

    /// <summary>The name of the Resource Group where the Firewall Policy should exist. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2FirewallPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU Tier of the Firewall Policy. Possible values are Standard, Premium and Basic. Defaults to Standard. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Whether SQL Redirect traffic filtering is allowed. Enabling this flag requires no rule using ports between 11000-11999.</summary>
    [JsonPropertyName("sqlRedirectAllowed")]
    public bool? SqlRedirectAllowed { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A threat_intelligence_allowlist block as defined below.</summary>
    [JsonPropertyName("threatIntelligenceAllowlist")]
    public V1beta2FirewallPolicySpecForProviderThreatIntelligenceAllowlist? ThreatIntelligenceAllowlist { get; set; }

    /// <summary>The operation mode for Threat Intelligence. Possible values are Alert, Deny and Off. Defaults to Alert.</summary>
    [JsonPropertyName("threatIntelligenceMode")]
    public string? ThreatIntelligenceMode { get; set; }

    /// <summary>A tls_certificate block as defined below.</summary>
    [JsonPropertyName("tlsCertificate")]
    public V1beta2FirewallPolicySpecForProviderTlsCertificate? TlsCertificate { get; set; }
}

/// <summary>A dns block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderDns
{
    /// <summary>Whether to enable DNS proxy on Firewalls attached to this Firewall Policy? Defaults to false.</summary>
    [JsonPropertyName("proxyEnabled")]
    public bool? ProxyEnabled { get; set; }

    /// <summary>A list of custom DNS servers&apos; IP addresses.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>A explicit_proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderExplicitProxy
{
    /// <summary>Whether the pac file port and url need to be provided.</summary>
    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    /// <summary>Whether the explicit proxy is enabled for this Firewall Policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The port number for explicit http protocol.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The port number for explicit proxy https protocol.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>Specifies a SAS URL for PAC file.</summary>
    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    /// <summary>Specifies a port number for firewall to serve PAC file.</summary>
    [JsonPropertyName("pacFilePort")]
    public double? PacFilePort { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Firewall Policy.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Firewall Policy. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderInsightsLogAnalyticsWorkspace
{
    /// <summary>The location of the Firewalls, that when matches this Log Analytics Workspace will be used to consume their logs.</summary>
    [JsonPropertyName("firewallLocation")]
    public string? FirewallLocation { get; set; }

    /// <summary>12-digit number (id) which identifies your signature.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>An insights block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderInsights
{
    /// <summary>The ID of the default Log Analytics Workspace that the Firewalls associated with this Firewall Policy will send their logs to, when there is no location matches in the log_analytics_workspace.</summary>
    [JsonPropertyName("defaultLogAnalyticsWorkspaceId")]
    public string? DefaultLogAnalyticsWorkspaceId { get; set; }

    /// <summary>Whether the insights functionality is enabled for this Firewall Policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of log_analytics_workspace block as defined below.</summary>
    [JsonPropertyName("logAnalyticsWorkspace")]
    public IList<V1beta2FirewallPolicySpecInitProviderInsightsLogAnalyticsWorkspace>? LogAnalyticsWorkspace { get; set; }

    /// <summary>The log retention period in days.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderIntrusionDetectionSignatureOverrides
{
    /// <summary>12-digit number (id) which identifies your signature.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>state can be any of Off, Alert or Deny.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderIntrusionDetectionTrafficBypass
{
    /// <summary>The description for this bypass traffic setting.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination IP groups that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>Specifies a list of destination IP ports that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this bypass traffic setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The protocols any of ANY, TCP, ICMP, UDP that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a list of source addresses that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>A intrusion_detection block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderIntrusionDetection
{
    /// <summary>In which mode you want to run intrusion detection: Off, Alert or Deny.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>A list of Private IP address ranges to identify traffic direction. By default, only ranges defined by IANA RFC 1918 are considered private IP addresses.</summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    /// <summary>One or more signature_overrides blocks as defined below.</summary>
    [JsonPropertyName("signatureOverrides")]
    public IList<V1beta2FirewallPolicySpecInitProviderIntrusionDetectionSignatureOverrides>? SignatureOverrides { get; set; }

    /// <summary>One or more traffic_bypass blocks as defined below.</summary>
    [JsonPropertyName("trafficBypass")]
    public IList<V1beta2FirewallPolicySpecInitProviderIntrusionDetectionTrafficBypass>? TrafficBypass { get; set; }
}

/// <summary>A threat_intelligence_allowlist block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderThreatIntelligenceAllowlist
{
    /// <summary>A list of FQDNs that will be skipped for threat detection.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP addresses or CIDR ranges that will be skipped for threat detection.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>A tls_certificate block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderTlsCertificate
{
    /// <summary>The Secret Identifier (URI) of the certificate stored in Azure Key Vault, either as a secret or certificate.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProvider
{
    /// <summary>Whether enable auto learn private ip range.</summary>
    [JsonPropertyName("autoLearnPrivateRangesEnabled")]
    public bool? AutoLearnPrivateRangesEnabled { get; set; }

    /// <summary>The ID of the base Firewall Policy.</summary>
    [JsonPropertyName("basePolicyId")]
    public string? BasePolicyId { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public V1beta2FirewallPolicySpecInitProviderDns? Dns { get; set; }

    /// <summary>A explicit_proxy block as defined below.</summary>
    [JsonPropertyName("explicitProxy")]
    public V1beta2FirewallPolicySpecInitProviderExplicitProxy? ExplicitProxy { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2FirewallPolicySpecInitProviderIdentity? Identity { get; set; }

    /// <summary>An insights block as defined below.</summary>
    [JsonPropertyName("insights")]
    public V1beta2FirewallPolicySpecInitProviderInsights? Insights { get; set; }

    /// <summary>A intrusion_detection block as defined below.</summary>
    [JsonPropertyName("intrusionDetection")]
    public V1beta2FirewallPolicySpecInitProviderIntrusionDetection? IntrusionDetection { get; set; }

    /// <summary>The Azure Region where the Firewall Policy should exist. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of private IP ranges to which traffic will not be SNAT.</summary>
    [JsonPropertyName("privateIpRanges")]
    public IList<string>? PrivateIpRanges { get; set; }

    /// <summary>The SKU Tier of the Firewall Policy. Possible values are Standard, Premium and Basic. Defaults to Standard. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Whether SQL Redirect traffic filtering is allowed. Enabling this flag requires no rule using ports between 11000-11999.</summary>
    [JsonPropertyName("sqlRedirectAllowed")]
    public bool? SqlRedirectAllowed { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A threat_intelligence_allowlist block as defined below.</summary>
    [JsonPropertyName("threatIntelligenceAllowlist")]
    public V1beta2FirewallPolicySpecInitProviderThreatIntelligenceAllowlist? ThreatIntelligenceAllowlist { get; set; }

    /// <summary>The operation mode for Threat Intelligence. Possible values are Alert, Deny and Off. Defaults to Alert.</summary>
    [JsonPropertyName("threatIntelligenceMode")]
    public string? ThreatIntelligenceMode { get; set; }

    /// <summary>A tls_certificate block as defined below.</summary>
    [JsonPropertyName("tlsCertificate")]
    public V1beta2FirewallPolicySpecInitProviderTlsCertificate? TlsCertificate { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecManagementPoliciesEnum>))]
public enum V1beta2FirewallPolicySpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FirewallPolicySpec defines the desired state of FirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpec
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
    public V1beta2FirewallPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FirewallPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2FirewallPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FirewallPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A dns block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderDns
{
    /// <summary>Whether to enable DNS proxy on Firewalls attached to this Firewall Policy? Defaults to false.</summary>
    [JsonPropertyName("proxyEnabled")]
    public bool? ProxyEnabled { get; set; }

    /// <summary>A list of custom DNS servers&apos; IP addresses.</summary>
    [JsonPropertyName("servers")]
    public IList<string>? Servers { get; set; }
}

/// <summary>A explicit_proxy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderExplicitProxy
{
    /// <summary>Whether the pac file port and url need to be provided.</summary>
    [JsonPropertyName("enablePacFile")]
    public bool? EnablePacFile { get; set; }

    /// <summary>Whether the explicit proxy is enabled for this Firewall Policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The port number for explicit http protocol.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The port number for explicit proxy https protocol.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>Specifies a SAS URL for PAC file.</summary>
    [JsonPropertyName("pacFile")]
    public string? PacFile { get; set; }

    /// <summary>Specifies a port number for firewall to serve PAC file.</summary>
    [JsonPropertyName("pacFilePort")]
    public double? PacFilePort { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Firewall Policy.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Firewall Policy.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Firewall Policy.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Firewall Policy. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderInsightsLogAnalyticsWorkspace
{
    /// <summary>The location of the Firewalls, that when matches this Log Analytics Workspace will be used to consume their logs.</summary>
    [JsonPropertyName("firewallLocation")]
    public string? FirewallLocation { get; set; }

    /// <summary>12-digit number (id) which identifies your signature.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>An insights block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderInsights
{
    /// <summary>The ID of the default Log Analytics Workspace that the Firewalls associated with this Firewall Policy will send their logs to, when there is no location matches in the log_analytics_workspace.</summary>
    [JsonPropertyName("defaultLogAnalyticsWorkspaceId")]
    public string? DefaultLogAnalyticsWorkspaceId { get; set; }

    /// <summary>Whether the insights functionality is enabled for this Firewall Policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A list of log_analytics_workspace block as defined below.</summary>
    [JsonPropertyName("logAnalyticsWorkspace")]
    public IList<V1beta2FirewallPolicyStatusAtProviderInsightsLogAnalyticsWorkspace>? LogAnalyticsWorkspace { get; set; }

    /// <summary>The log retention period in days.</summary>
    [JsonPropertyName("retentionInDays")]
    public double? RetentionInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderIntrusionDetectionSignatureOverrides
{
    /// <summary>12-digit number (id) which identifies your signature.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>state can be any of Off, Alert or Deny.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderIntrusionDetectionTrafficBypass
{
    /// <summary>The description for this bypass traffic setting.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies a list of destination IP addresses that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>Specifies a list of destination IP groups that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>Specifies a list of destination IP ports that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The name which should be used for this bypass traffic setting.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The protocols any of ANY, TCP, ICMP, UDP that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies a list of source addresses that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>Specifies a list of source IP groups that shall be bypassed by intrusion detection.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>A intrusion_detection block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderIntrusionDetection
{
    /// <summary>In which mode you want to run intrusion detection: Off, Alert or Deny.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>A list of Private IP address ranges to identify traffic direction. By default, only ranges defined by IANA RFC 1918 are considered private IP addresses.</summary>
    [JsonPropertyName("privateRanges")]
    public IList<string>? PrivateRanges { get; set; }

    /// <summary>One or more signature_overrides blocks as defined below.</summary>
    [JsonPropertyName("signatureOverrides")]
    public IList<V1beta2FirewallPolicyStatusAtProviderIntrusionDetectionSignatureOverrides>? SignatureOverrides { get; set; }

    /// <summary>One or more traffic_bypass blocks as defined below.</summary>
    [JsonPropertyName("trafficBypass")]
    public IList<V1beta2FirewallPolicyStatusAtProviderIntrusionDetectionTrafficBypass>? TrafficBypass { get; set; }
}

/// <summary>A threat_intelligence_allowlist block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderThreatIntelligenceAllowlist
{
    /// <summary>A list of FQDNs that will be skipped for threat detection.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP addresses or CIDR ranges that will be skipped for threat detection.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary>A tls_certificate block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderTlsCertificate
{
    /// <summary>The Secret Identifier (URI) of the certificate stored in Azure Key Vault, either as a secret or certificate.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProvider
{
    /// <summary>Whether enable auto learn private ip range.</summary>
    [JsonPropertyName("autoLearnPrivateRangesEnabled")]
    public bool? AutoLearnPrivateRangesEnabled { get; set; }

    /// <summary>The ID of the base Firewall Policy.</summary>
    [JsonPropertyName("basePolicyId")]
    public string? BasePolicyId { get; set; }

    /// <summary>A list of reference to child Firewall Policies of this Firewall Policy.</summary>
    [JsonPropertyName("childPolicies")]
    public IList<string>? ChildPolicies { get; set; }

    /// <summary>A dns block as defined below.</summary>
    [JsonPropertyName("dns")]
    public V1beta2FirewallPolicyStatusAtProviderDns? Dns { get; set; }

    /// <summary>A explicit_proxy block as defined below.</summary>
    [JsonPropertyName("explicitProxy")]
    public V1beta2FirewallPolicyStatusAtProviderExplicitProxy? ExplicitProxy { get; set; }

    /// <summary>A list of references to Azure Firewalls that this Firewall Policy is associated with.</summary>
    [JsonPropertyName("firewalls")]
    public IList<string>? Firewalls { get; set; }

    /// <summary>The ID of the Firewall Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2FirewallPolicyStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>An insights block as defined below.</summary>
    [JsonPropertyName("insights")]
    public V1beta2FirewallPolicyStatusAtProviderInsights? Insights { get; set; }

    /// <summary>A intrusion_detection block as defined below.</summary>
    [JsonPropertyName("intrusionDetection")]
    public V1beta2FirewallPolicyStatusAtProviderIntrusionDetection? IntrusionDetection { get; set; }

    /// <summary>The Azure Region where the Firewall Policy should exist. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of private IP ranges to which traffic will not be SNAT.</summary>
    [JsonPropertyName("privateIpRanges")]
    public IList<string>? PrivateIpRanges { get; set; }

    /// <summary>The name of the Resource Group where the Firewall Policy should exist. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A list of references to Firewall Policy Rule Collection Groups that belongs to this Firewall Policy.</summary>
    [JsonPropertyName("ruleCollectionGroups")]
    public IList<string>? RuleCollectionGroups { get; set; }

    /// <summary>The SKU Tier of the Firewall Policy. Possible values are Standard, Premium and Basic. Defaults to Standard. Changing this forces a new Firewall Policy to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Whether SQL Redirect traffic filtering is allowed. Enabling this flag requires no rule using ports between 11000-11999.</summary>
    [JsonPropertyName("sqlRedirectAllowed")]
    public bool? SqlRedirectAllowed { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A threat_intelligence_allowlist block as defined below.</summary>
    [JsonPropertyName("threatIntelligenceAllowlist")]
    public V1beta2FirewallPolicyStatusAtProviderThreatIntelligenceAllowlist? ThreatIntelligenceAllowlist { get; set; }

    /// <summary>The operation mode for Threat Intelligence. Possible values are Alert, Deny and Off. Defaults to Alert.</summary>
    [JsonPropertyName("threatIntelligenceMode")]
    public string? ThreatIntelligenceMode { get; set; }

    /// <summary>A tls_certificate block as defined below.</summary>
    [JsonPropertyName("tlsCertificate")]
    public V1beta2FirewallPolicyStatusAtProviderTlsCertificate? TlsCertificate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusConditions
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

/// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FirewallPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FirewallPolicy is the Schema for the FirewallPolicys API. Manages a Firewall Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FirewallPolicySpec>, IStatus<V1beta2FirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FirewallPolicy";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallPolicySpec defines the desired state of FirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FirewallPolicySpec Spec { get; set; }

    /// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2FirewallPolicyStatus? Status { get; set; }
}