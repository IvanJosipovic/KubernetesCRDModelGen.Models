#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPPoolList : IKubernetesObject<V1ListMeta>, IItems<V1IPPool>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPoolList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1IPPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1IPPool> Items { get; set; }
}

/// <summary>
/// IPPoolAllowedUse defines the allowed uses for an IP pool.
/// It can be one of &quot;Workload&quot;, &quot;Tunnel&quot;, or &quot;LoadBalancer&quot;.
/// - &quot;Workload&quot; means the pool is used for workload IP addresses.
/// - &quot;Tunnel&quot; means the pool is used for tunnel IP addresses.
/// - &quot;LoadBalancer&quot; means the pool is used for load balancer IP addresses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecAllowedUsesEnum>))]
public enum V1IPPoolSpecAllowedUsesEnum
{
    [EnumMember(Value = "Workload"), JsonStringEnumMemberName("Workload")]
    Workload,
    [EnumMember(Value = "Tunnel"), JsonStringEnumMemberName("Tunnel")]
    Tunnel,
    [EnumMember(Value = "LoadBalancer"), JsonStringEnumMemberName("LoadBalancer")]
    LoadBalancer
}

/// <summary>Determines the mode how IP addresses should be assigned from this pool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecAssignmentModeEnum>))]
public enum V1IPPoolSpecAssignmentModeEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>
/// Contains configuration for IPIP tunneling for this pool.
/// For IPv6 pools, IPIP tunneling must be disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecIpipModeEnum>))]
public enum V1IPPoolSpecIpipModeEnum
{
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "CrossSubnet"), JsonStringEnumMemberName("CrossSubnet")]
    CrossSubnet
}

/// <summary>Contains configuration for VXLAN tunneling for this pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolSpecVxlanModeEnum>))]
public enum V1IPPoolSpecVxlanModeEnum
{
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "CrossSubnet"), JsonStringEnumMemberName("CrossSubnet")]
    CrossSubnet
}

/// <summary>IPPoolSpec contains the specification for an IPPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPPoolSpec
{
    /// <summary>
    /// AllowedUses controls what the IP pool will be used for. If not specified or empty, defaults to
    /// [&quot;Tunnel&quot;, &quot;Workload&quot;] for back-compatibility. Valid values: &quot;Tunnel&quot;, &quot;Workload&quot;, &quot;LoadBalancer&quot;.
    /// </summary>
    [JsonPropertyName("allowedUses")]
    public IList<V1IPPoolSpecAllowedUsesEnum>? AllowedUses { get; set; }

    /// <summary>Determines the mode how IP addresses should be assigned from this pool</summary>
    [JsonPropertyName("assignmentMode")]
    public V1IPPoolSpecAssignmentModeEnum? AssignmentMode { get; set; }

    /// <summary>
    /// The block size to use for IP address assignments from this pool. Defaults to 26 for IPv4 and 122 for IPv6.
    /// The block size must be between 20 and 32 for IPv4 and between 116 and 128 for IPv6. It must also be smaller
    /// than or equal to the size of the pool CIDR.
    /// </summary>
    [JsonPropertyName("blockSize")]
    public int? BlockSize { get; set; }

    /// <summary>The pool CIDR.</summary>
    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    /// <summary>Disable exporting routes from this IP Pool&apos;s CIDR over BGP. [Default: false]</summary>
    [JsonPropertyName("disableBGPExport")]
    public bool? DisableBGPExport { get; set; }

    /// <summary>When disabled is true, Calico IPAM will not assign addresses from this pool.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Contains configuration for IPIP tunneling for this pool.
    /// For IPv6 pools, IPIP tunneling must be disabled.
    /// </summary>
    [JsonPropertyName("ipipMode")]
    public V1IPPoolSpecIpipModeEnum? IpipMode { get; set; }

    /// <summary>
    /// Allows IPPool to allocate for a specific namespace by label selector.
    /// If specified, both namespaceSelector and nodeSelector must match for the pool to be used.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>
    /// When natOutgoing is true, packets sent from Calico networked containers in
    /// this pool to destinations outside of this pool will be masqueraded.
    /// </summary>
    [JsonPropertyName("natOutgoing")]
    public bool? NatOutgoing { get; set; }

    /// <summary>Allows IPPool to allocate for a specific node by label selector.</summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    /// <summary>Contains configuration for VXLAN tunneling for this pool.</summary>
    [JsonPropertyName("vxlanMode")]
    public V1IPPoolSpecVxlanModeEnum? VxlanMode { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1IPPoolStatusConditionsStatusEnum>))]
public enum V1IPPoolStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPPoolStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1IPPoolStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPPoolStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1IPPoolStatusConditions>? Conditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPPoolSpec?>, IStatus<V1IPPoolStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPPool";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ippools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IPPoolSpec contains the specification for an IPPool resource.</summary>
    [JsonPropertyName("spec")]
    public V1IPPoolSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1IPPoolStatus? Status { get; set; }
}