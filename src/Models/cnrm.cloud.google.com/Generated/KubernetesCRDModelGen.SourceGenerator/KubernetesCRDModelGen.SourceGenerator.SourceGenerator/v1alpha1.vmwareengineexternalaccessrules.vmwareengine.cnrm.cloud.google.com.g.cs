#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vmwareengine.cnrm.cloud.google.com;
/// <summary>VMwareEngineExternalAccessRule is the Schema for the VMwareEngineExternalAccessRule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEngineExternalAccessRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VMwareEngineExternalAccessRule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEngineExternalAccessRuleList";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineexternalaccessrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vmwareengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VMwareEngineExternalAccessRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VMwareEngineExternalAccessRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VMwareEngineExternalAccessRule> Items { get; set; }
}

/// <summary>The name of an `ExternalAddress` resource. The external address must have been reserved in the scope of this external access rule&apos;s parent network policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleSpecDestinationIPRangesExternalAddressRef
{
    /// <summary>A reference to an externally managed VMwareEngineExternalAddress resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/privateClouds/{{privatecloudID}}/externalAddresses/{{externaladdressID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineExternalAddress resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineExternalAddress resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleSpecDestinationIPRanges
{
    /// <summary>The name of an `ExternalAddress` resource. The external address must have been reserved in the scope of this external access rule&apos;s parent network policy.</summary>
    [JsonPropertyName("externalAddressRef")]
    public V1alpha1VMwareEngineExternalAccessRuleSpecDestinationIPRangesExternalAddressRef? ExternalAddressRef { get; set; }

    /// <summary>A single IP address. For example: `10.0.0.5`.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>An IP address range in the CIDR format. For example: `10.0.0.0/24`.</summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }
}

/// <summary>Required. The resource name of the network policy to create a new external access firewall rule in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleSpecNetworkPolicyRef
{
    /// <summary>A reference to an externally managed VMwareEngineNetworkPolicy resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/networkPolicies/{{networkpolicyID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineNetworkPolicy resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineNetworkPolicy resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of an `ExternalAddress` resource. The external address must have been reserved in the scope of this external access rule&apos;s parent network policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleSpecSourceIPRangesExternalAddressRef
{
    /// <summary>A reference to an externally managed VMwareEngineExternalAddress resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/privateClouds/{{privatecloudID}}/externalAddresses/{{externaladdressID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineExternalAddress resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineExternalAddress resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleSpecSourceIPRanges
{
    /// <summary>The name of an `ExternalAddress` resource. The external address must have been reserved in the scope of this external access rule&apos;s parent network policy.</summary>
    [JsonPropertyName("externalAddressRef")]
    public V1alpha1VMwareEngineExternalAccessRuleSpecSourceIPRangesExternalAddressRef? ExternalAddressRef { get; set; }

    /// <summary>A single IP address. For example: `10.0.0.5`.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>An IP address range in the CIDR format. For example: `10.0.0.0/24`.</summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }
}

/// <summary>VMwareEngineExternalAccessRuleSpec defines the desired state of VMwareEngineExternalAccessRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleSpec
{
    /// <summary>The action that the external access rule performs.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>User-provided description for this external access rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If destination ranges are specified, the external access rule applies only to the traffic that has a destination IP address in these ranges. The specified IP addresses must have reserved external IP addresses in the scope of the parent network policy. To match all external IP addresses in the scope of the parent network policy, specify `0.0.0.0/0`. To match a specific external IP address, specify it using the `IpRange.external_address` property.</summary>
    [JsonPropertyName("destinationIPRanges")]
    public IList<V1alpha1VMwareEngineExternalAccessRuleSpecDestinationIPRanges>? DestinationIPRanges { get; set; }

    /// <summary>A list of destination ports to which the external access rule applies. This field is only applicable for the UDP or TCP protocol. Each entry must be either an integer or a range. For example: `[&quot;22&quot;]`, `[&quot;80&quot;,&quot;443&quot;]`, or `[&quot;12345-12349&quot;]`. To match all destination ports, specify `[&quot;0-65535&quot;]`.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>The IP protocol to which the external access rule applies. This value can be one of the following three protocol strings (not case-sensitive): `tcp`, `udp`, or `icmp`.</summary>
    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    /// <summary>Required. The resource name of the network policy to create a new external access firewall rule in.</summary>
    [JsonPropertyName("networkPolicyRef")]
    public required V1alpha1VMwareEngineExternalAccessRuleSpecNetworkPolicyRef NetworkPolicyRef { get; set; }

    /// <summary>External access rule priority, which determines the external access rule to use when multiple rules apply. If multiple rules have the same priority, their ordering is non-deterministic. If specific ordering is required, assign unique priorities to enforce such ordering. The external access rule priority is an integer from 100 to 4096, both inclusive. Lower integers indicate higher precedence. For example, a rule with priority `100` has higher precedence than a rule with priority `101`.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>The VMwareEngineExternalAccessRule name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>If source ranges are specified, the external access rule applies only to traffic that has a source IP address in these ranges. These ranges can either be expressed in the CIDR format or as an IP address. As only inbound rules are supported, `ExternalAddress` resources cannot be the source IP addresses of an external access rule. To match all source addresses, specify `0.0.0.0/0`.</summary>
    [JsonPropertyName("sourceIPRanges")]
    public IList<V1alpha1VMwareEngineExternalAccessRuleSpecSourceIPRanges>? SourceIPRanges { get; set; }

    /// <summary>A list of source ports to which the external access rule applies. This field is only applicable for the UDP or TCP protocol. Each entry must be either an integer or a range. For example: `[&quot;22&quot;]`, `[&quot;80&quot;,&quot;443&quot;]`, or `[&quot;12345-12349&quot;]`. To match all source ports, specify `[&quot;0-65535&quot;]`.</summary>
    [JsonPropertyName("sourcePorts")]
    public IList<string>? SourcePorts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleStatusObservedState
{
    /// <summary>Output only. Creation time of this resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The state of the resource.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-generated unique identifier for the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Last update time of this resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VMwareEngineExternalAccessRuleStatus defines the config connector machine state of VMwareEngineExternalAccessRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineExternalAccessRuleStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VMwareEngineExternalAccessRuleStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VMwareEngineExternalAccessRule resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VMwareEngineExternalAccessRuleStatusObservedState? ObservedState { get; set; }
}

/// <summary>VMwareEngineExternalAccessRule is the Schema for the VMwareEngineExternalAccessRule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEngineExternalAccessRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VMwareEngineExternalAccessRuleSpec>, IStatus<V1alpha1VMwareEngineExternalAccessRuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEngineExternalAccessRule";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareengineexternalaccessrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vmwareengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VMwareEngineExternalAccessRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VMwareEngineExternalAccessRuleSpec defines the desired state of VMwareEngineExternalAccessRule</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VMwareEngineExternalAccessRuleSpec Spec { get; set; }

    /// <summary>VMwareEngineExternalAccessRuleStatus defines the config connector machine state of VMwareEngineExternalAccessRule</summary>
    [JsonPropertyName("status")]
    public V1alpha1VMwareEngineExternalAccessRuleStatus? Status { get; set; }
}