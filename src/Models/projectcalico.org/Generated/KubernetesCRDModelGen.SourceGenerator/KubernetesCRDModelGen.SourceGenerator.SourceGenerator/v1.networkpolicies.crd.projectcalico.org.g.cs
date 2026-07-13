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
public partial class V1NetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1NetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "NetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "networkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1NetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1NetworkPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1NetworkPolicySpecEgressActionEnum>))]
public enum V1NetworkPolicySpecEgressActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Pass"), JsonStringEnumMemberName("Pass")]
    Pass
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressDestination
{
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1NetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1NetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgressSource
{
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1NetworkPolicySpecEgressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecEgress
{
    [JsonPropertyName("action")]
    public required V1NetworkPolicySpecEgressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1NetworkPolicySpecEgressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1NetworkPolicySpecEgressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1NetworkPolicySpecEgressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1NetworkPolicySpecEgressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1NetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1NetworkPolicySpecEgressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1NetworkPolicySpecIngressActionEnum>))]
public enum V1NetworkPolicySpecIngressActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Pass"), JsonStringEnumMemberName("Pass")]
    Pass
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressDestination
{
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1NetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1NetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngressSource
{
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccounts")]
    public V1NetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1NetworkPolicySpecIngressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpecIngress
{
    [JsonPropertyName("action")]
    public required V1NetworkPolicySpecIngressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1NetworkPolicySpecIngressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1NetworkPolicySpecIngressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1NetworkPolicySpecIngressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1NetworkPolicySpecIngressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1NetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1NetworkPolicySpecIngressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1NetworkPolicySpecPerformanceHintsEnum>))]
public enum V1NetworkPolicySpecPerformanceHintsEnum
{
    [EnumMember(Value = "AssumeNeededOnEveryNode"), JsonStringEnumMemberName("AssumeNeededOnEveryNode")]
    AssumeNeededOnEveryNode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1NetworkPolicySpecTypesEnum>))]
public enum V1NetworkPolicySpecTypesEnum
{
    [EnumMember(Value = "Ingress"), JsonStringEnumMemberName("Ingress")]
    Ingress,
    [EnumMember(Value = "Egress"), JsonStringEnumMemberName("Egress")]
    Egress
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1NetworkPolicySpec
{
    [JsonPropertyName("egress")]
    public IList<V1NetworkPolicySpecEgress>? Egress { get; set; }

    [JsonPropertyName("ingress")]
    public IList<V1NetworkPolicySpecIngress>? Ingress { get; set; }

    [JsonPropertyName("order")]
    public double? Order { get; set; }

    [JsonPropertyName("performanceHints")]
    public IList<V1NetworkPolicySpecPerformanceHintsEnum>? PerformanceHints { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    [JsonPropertyName("types")]
    public IList<V1NetworkPolicySpecTypesEnum>? Types { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1NetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1NetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "NetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "networkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1NetworkPolicySpec? Spec { get; set; }
}