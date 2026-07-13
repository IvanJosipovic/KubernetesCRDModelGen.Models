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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1StagedNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagednetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1StagedNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1StagedNetworkPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedNetworkPolicySpecEgressActionEnum>))]
public enum V1StagedNetworkPolicySpecEgressActionEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressDestination
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
    public V1StagedNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1StagedNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgressSource
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
    public V1StagedNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecEgressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecEgress
{
    [JsonPropertyName("action")]
    public required V1StagedNetworkPolicySpecEgressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1StagedNetworkPolicySpecEgressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1StagedNetworkPolicySpecEgressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1StagedNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1StagedNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1StagedNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1StagedNetworkPolicySpecEgressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedNetworkPolicySpecIngressActionEnum>))]
public enum V1StagedNetworkPolicySpecIngressActionEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressDestinationServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressDestinationServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressDestination
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
    public V1StagedNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressHttp
{
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1StagedNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressIcmp
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressNotICMP
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressSourceServiceAccounts
{
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressSourceServices
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngressSource
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
    public V1StagedNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    [JsonPropertyName("services")]
    public V1StagedNetworkPolicySpecIngressSourceServices? Services { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpecIngress
{
    [JsonPropertyName("action")]
    public required V1StagedNetworkPolicySpecIngressActionEnum Action { get; set; }

    [JsonPropertyName("destination")]
    public V1StagedNetworkPolicySpecIngressDestination? Destination { get; set; }

    [JsonPropertyName("http")]
    public V1StagedNetworkPolicySpecIngressHttp? Http { get; set; }

    [JsonPropertyName("icmp")]
    public V1StagedNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    [JsonPropertyName("metadata")]
    public V1StagedNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    [JsonPropertyName("notICMP")]
    public V1StagedNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    [JsonPropertyName("source")]
    public V1StagedNetworkPolicySpecIngressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedNetworkPolicySpecPerformanceHintsEnum>))]
public enum V1StagedNetworkPolicySpecPerformanceHintsEnum
{
    [EnumMember(Value = "AssumeNeededOnEveryNode"), JsonStringEnumMemberName("AssumeNeededOnEveryNode")]
    AssumeNeededOnEveryNode
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedNetworkPolicySpecStagedActionEnum>))]
public enum V1StagedNetworkPolicySpecStagedActionEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedNetworkPolicySpecTypesEnum>))]
public enum V1StagedNetworkPolicySpecTypesEnum
{
    [EnumMember(Value = "Ingress"), JsonStringEnumMemberName("Ingress")]
    Ingress,
    [EnumMember(Value = "Egress"), JsonStringEnumMemberName("Egress")]
    Egress
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedNetworkPolicySpec
{
    [JsonPropertyName("egress")]
    public IList<V1StagedNetworkPolicySpecEgress>? Egress { get; set; }

    [JsonPropertyName("ingress")]
    public IList<V1StagedNetworkPolicySpecIngress>? Ingress { get; set; }

    [JsonPropertyName("order")]
    public double? Order { get; set; }

    [JsonPropertyName("performanceHints")]
    public IList<V1StagedNetworkPolicySpecPerformanceHintsEnum>? PerformanceHints { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    [JsonPropertyName("stagedAction")]
    public V1StagedNetworkPolicySpecStagedActionEnum? StagedAction { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    [JsonPropertyName("types")]
    public IList<V1StagedNetworkPolicySpecTypesEnum>? Types { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedNetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagednetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1StagedNetworkPolicySpec? Spec { get; set; }
}