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
public partial class V1StagedKubernetesNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1StagedKubernetesNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedKubernetesNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedkubernetesnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedKubernetesNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1StagedKubernetesNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1StagedKubernetesNetworkPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressPorts
{
    [JsonPropertyName("endPort")]
    public int? EndPort { get; set; }

    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToIpBlock
{
    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToPodSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToPodSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressToPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressTo
{
    [JsonPropertyName("ipBlock")]
    public V1StagedKubernetesNetworkPolicySpecEgressToIpBlock? IpBlock { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecEgressToPodSelector? PodSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgress
{
    [JsonPropertyName("ports")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressPorts>? Ports { get; set; }

    [JsonPropertyName("to")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressTo>? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromIpBlock
{
    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromPodSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromPodSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFromPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFrom
{
    [JsonPropertyName("ipBlock")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromIpBlock? IpBlock { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromPodSelector? PodSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressPorts
{
    [JsonPropertyName("endPort")]
    public int? EndPort { get; set; }

    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngress
{
    [JsonPropertyName("from")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFrom>? From { get; set; }

    [JsonPropertyName("ports")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressPorts>? Ports { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecPodSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecPodSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedKubernetesNetworkPolicySpecStagedActionEnum>))]
public enum V1StagedKubernetesNetworkPolicySpecStagedActionEnum
{
    [EnumMember(Value = "Set"), JsonStringEnumMemberName("Set")]
    Set,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Learn"), JsonStringEnumMemberName("Learn")]
    Learn,
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpec
{
    [JsonPropertyName("egress")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgress>? Egress { get; set; }

    [JsonPropertyName("ingress")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngress>? Ingress { get; set; }

    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecPodSelector? PodSelector { get; set; }

    [JsonPropertyName("policyTypes")]
    public IList<string>? PolicyTypes { get; set; }

    [JsonPropertyName("stagedAction")]
    public V1StagedKubernetesNetworkPolicySpecStagedActionEnum? StagedAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedKubernetesNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedKubernetesNetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedKubernetesNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedkubernetesnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedKubernetesNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1StagedKubernetesNetworkPolicySpec? Spec { get; set; }
}