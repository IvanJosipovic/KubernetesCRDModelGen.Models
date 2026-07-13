#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeOrganizationSecurityPolicyRule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeOrganizationSecurityPolicyRuleList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeorganizationsecuritypolicyrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeOrganizationSecurityPolicyRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ComputeOrganizationSecurityPolicyRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ComputeOrganizationSecurityPolicyRule> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleSpecMatchConfigLayer4Config
{
    /// <summary>
    /// The IP protocol to which this rule applies. The protocol
    /// type is required when creating a firewall rule.
    /// This value can either be one of the following well
    /// known protocol strings (tcp, udp, icmp, esp, ah, ipip, sctp),
    /// or the IP protocol number.
    /// </summary>
    [JsonPropertyName("ipProtocol")]
    public required string IpProtocol { get; set; }

    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// 
    /// Example inputs include: [&quot;22&quot;], [&quot;80&quot;,&quot;443&quot;], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }
}

/// <summary>The configuration options for matching the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleSpecMatchConfig
{
    /// <summary>
    /// Destination IP address range in CIDR format. Required for
    /// EGRESS rules.
    /// </summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Pairs of IP protocols and ports that the rule should match.</summary>
    [JsonPropertyName("layer4Config")]
    public required IList<V1alpha1ComputeOrganizationSecurityPolicyRuleSpecMatchConfigLayer4Config> Layer4Config { get; set; }

    /// <summary>
    /// Source IP address range in CIDR format. Required for
    /// INGRESS rules.
    /// </summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleSpecMatch
{
    /// <summary>The configuration options for matching the rule.</summary>
    [JsonPropertyName("config")]
    public required V1alpha1ComputeOrganizationSecurityPolicyRuleSpecMatchConfig Config { get; set; }

    /// <summary>A description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Preconfigured versioned expression. For organization security policy rules,
    /// the only supported type is &quot;FIREWALL&quot;. Default value: &quot;FIREWALL&quot; Possible values: [&quot;FIREWALL&quot;].
    /// </summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleSpec
{
    /// <summary>
    /// The Action to perform when the client connection triggers the rule. Can currently be either
    /// &quot;allow&quot;, &quot;deny&quot; or &quot;goto_next&quot;.
    /// </summary>
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    /// <summary>A description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The direction in which this rule applies. If unspecified an INGRESS rule is created. Possible values: [&quot;INGRESS&quot;, &quot;EGRESS&quot;].</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether to enable logging for a particular rule.
    /// If logging is enabled, logs will be exported to the
    /// configured export destination in Stackdriver.
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.</summary>
    [JsonPropertyName("match")]
    public required V1alpha1ComputeOrganizationSecurityPolicyRuleSpecMatch Match { get; set; }

    /// <summary>Immutable. The ID of the OrganizationSecurityPolicy this rule applies to.</summary>
    [JsonPropertyName("policyId")]
    public required string PolicyId { get; set; }

    /// <summary>If set to true, the specified action is not enforced.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>Immutable. Optional. The priority of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// A list of network resource URLs to which this rule applies.
    /// This field allows you to control which network&apos;s VMs get
    /// this rule. If this field is left blank, all VMs
    /// within the organization will receive the rule.
    /// </summary>
    [JsonPropertyName("targetResources")]
    public IList<string>? TargetResources { get; set; }

    /// <summary>
    /// A list of service accounts indicating the sets of
    /// instances that are applied with this rule.
    /// </summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRuleStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeOrganizationSecurityPolicyRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeOrganizationSecurityPolicyRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeOrganizationSecurityPolicyRuleSpec>, IStatus<V1alpha1ComputeOrganizationSecurityPolicyRuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeOrganizationSecurityPolicyRule";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeorganizationsecuritypolicyrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeOrganizationSecurityPolicyRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1ComputeOrganizationSecurityPolicyRuleSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1ComputeOrganizationSecurityPolicyRuleStatus? Status { get; set; }
}