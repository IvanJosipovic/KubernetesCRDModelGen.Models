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
public partial class V1GlobalNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1GlobalNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GlobalNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "globalnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GlobalNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1GlobalNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1GlobalNetworkPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GlobalNetworkPolicySpecEgressActionEnum>))]
public enum V1GlobalNetworkPolicySpecEgressActionEnum
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
public partial class V1GlobalNetworkPolicySpecEgressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressDestination
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
    public V1GlobalNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1GlobalNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgressSource
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
    public V1GlobalNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecEgressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecEgress
{
    [JsonPropertyName("action")]
    public required V1GlobalNetworkPolicySpecEgressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1GlobalNetworkPolicySpecEgressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1GlobalNetworkPolicySpecEgressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1GlobalNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1GlobalNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1GlobalNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1GlobalNetworkPolicySpecEgressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GlobalNetworkPolicySpecIngressActionEnum>))]
public enum V1GlobalNetworkPolicySpecIngressActionEnum
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
public partial class V1GlobalNetworkPolicySpecIngressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressDestination
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
    public V1GlobalNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1GlobalNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngressSource
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
    public V1GlobalNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1GlobalNetworkPolicySpecIngressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpecIngress
{
    [JsonPropertyName("action")]
    public required V1GlobalNetworkPolicySpecIngressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1GlobalNetworkPolicySpecIngressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1GlobalNetworkPolicySpecIngressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1GlobalNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1GlobalNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1GlobalNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1GlobalNetworkPolicySpecIngressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GlobalNetworkPolicySpecPerformanceHintsEnum>))]
public enum V1GlobalNetworkPolicySpecPerformanceHintsEnum
{
    [EnumMember(Value = "AssumeNeededOnEveryNode"), JsonStringEnumMemberName("AssumeNeededOnEveryNode")]
    AssumeNeededOnEveryNode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GlobalNetworkPolicySpecTypesEnum>))]
public enum V1GlobalNetworkPolicySpecTypesEnum
{
    [EnumMember(Value = "Ingress"), JsonStringEnumMemberName("Ingress")]
    Ingress,
    [EnumMember(Value = "Egress"), JsonStringEnumMemberName("Egress")]
    Egress
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GlobalNetworkPolicySpec
{
    [JsonPropertyName("applyOnForward")]
    public bool? ApplyOnForward { get; set; }

    [JsonPropertyName("doNotTrack")]
    public bool? DoNotTrack { get; set; }

    [JsonPropertyName("egress")]
    public IList<V1GlobalNetworkPolicySpecEgress>? Egress { get; set; }

    [JsonPropertyName("ingress")]
    public IList<V1GlobalNetworkPolicySpecIngress>? Ingress { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("order")]
    public double? Order { get; set; }

    [JsonPropertyName("performanceHints")]
    public IList<V1GlobalNetworkPolicySpecPerformanceHintsEnum>? PerformanceHints { get; set; }

    [JsonPropertyName("preDNAT")]
    public bool? PreDNAT { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    [JsonPropertyName("types")]
    public IList<V1GlobalNetworkPolicySpecTypesEnum>? Types { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GlobalNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1GlobalNetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GlobalNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "globalnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GlobalNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1GlobalNetworkPolicySpec? Spec { get; set; }
}