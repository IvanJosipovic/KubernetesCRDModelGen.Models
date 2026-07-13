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
public partial class V1StagedGlobalNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1StagedGlobalNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedGlobalNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedglobalnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedGlobalNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1StagedGlobalNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1StagedGlobalNetworkPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecEgressActionEnum>))]
public enum V1StagedGlobalNetworkPolicySpecEgressActionEnum
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
public partial class V1StagedGlobalNetworkPolicySpecEgressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressDestination
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
    public V1StagedGlobalNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1StagedGlobalNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressSource
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
    public V1StagedGlobalNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecEgressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgress
{
    [JsonPropertyName("action")]
    public required V1StagedGlobalNetworkPolicySpecEgressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1StagedGlobalNetworkPolicySpecEgressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1StagedGlobalNetworkPolicySpecEgressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1StagedGlobalNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1StagedGlobalNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1StagedGlobalNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1StagedGlobalNetworkPolicySpecEgressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecIngressActionEnum>))]
public enum V1StagedGlobalNetworkPolicySpecIngressActionEnum
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
public partial class V1StagedGlobalNetworkPolicySpecIngressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressDestination
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
    public V1StagedGlobalNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1StagedGlobalNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressSource
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
    public V1StagedGlobalNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecIngressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngress
{
    [JsonPropertyName("action")]
    public required V1StagedGlobalNetworkPolicySpecIngressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1StagedGlobalNetworkPolicySpecIngressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1StagedGlobalNetworkPolicySpecIngressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1StagedGlobalNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1StagedGlobalNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1StagedGlobalNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1StagedGlobalNetworkPolicySpecIngressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecPerformanceHintsEnum>))]
public enum V1StagedGlobalNetworkPolicySpecPerformanceHintsEnum
{
    [EnumMember(Value = "AssumeNeededOnEveryNode"), JsonStringEnumMemberName("AssumeNeededOnEveryNode")]
    AssumeNeededOnEveryNode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecStagedActionEnum>))]
public enum V1StagedGlobalNetworkPolicySpecStagedActionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecTypesEnum>))]
public enum V1StagedGlobalNetworkPolicySpecTypesEnum
{
    [EnumMember(Value = "Ingress"), JsonStringEnumMemberName("Ingress")]
    Ingress,
    [EnumMember(Value = "Egress"), JsonStringEnumMemberName("Egress")]
    Egress
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpec
{
    [JsonPropertyName("applyOnForward")]
    public bool? ApplyOnForward { get; set; }

    [JsonPropertyName("doNotTrack")]
    public bool? DoNotTrack { get; set; }

    [JsonPropertyName("egress")]
    public IList<V1StagedGlobalNetworkPolicySpecEgress>? Egress { get; set; }

    [JsonPropertyName("ingress")]
    public IList<V1StagedGlobalNetworkPolicySpecIngress>? Ingress { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    [JsonPropertyName("order")]
    public double? Order { get; set; }

    [JsonPropertyName("performanceHints")]
    public IList<V1StagedGlobalNetworkPolicySpecPerformanceHintsEnum>? PerformanceHints { get; set; }

    [JsonPropertyName("preDNAT")]
    public bool? PreDNAT { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    [JsonPropertyName("stagedAction")]
    public V1StagedGlobalNetworkPolicySpecStagedActionEnum? StagedAction { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    [JsonPropertyName("types")]
    public IList<V1StagedGlobalNetworkPolicySpecTypesEnum>? Types { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedGlobalNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedGlobalNetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedGlobalNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedglobalnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedGlobalNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1StagedGlobalNetworkPolicySpec? Spec { get; set; }
}