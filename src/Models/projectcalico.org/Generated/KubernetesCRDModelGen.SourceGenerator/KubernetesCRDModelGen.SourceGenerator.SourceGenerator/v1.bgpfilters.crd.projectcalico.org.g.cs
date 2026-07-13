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
public partial class V1BGPFilterList : IKubernetesObject<V1ListMeta>, IItems<V1BGPFilter>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPFilterList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpfilters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPFilterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1BGPFilter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1BGPFilter> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4ActionEnum>))]
public enum V1BGPFilterSpecExportV4ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4Communities
{
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4MatchOperatorEnum>))]
public enum V1BGPFilterSpecExportV4MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4OperationsAddCommunity
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4OperationsPrependASPath
{
    [JsonPropertyName("prefix")]
    public required IList<int> Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4OperationsSetPriority
{
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4Operations
{
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecExportV4OperationsAddCommunity? AddCommunity { get; set; }

    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecExportV4OperationsPrependASPath? PrependASPath { get; set; }

    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecExportV4OperationsSetPriority? SetPriority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4PeerTypeEnum>))]
public enum V1BGPFilterSpecExportV4PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4SourceEnum>))]
public enum V1BGPFilterSpecExportV4SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecExportV4ActionEnum Action { get; set; }

    [JsonPropertyName("asPathPrefix")]
    public IList<int>? AsPathPrefix { get; set; }

    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("communities")]
    public V1BGPFilterSpecExportV4Communities? Communities { get; set; }

    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecExportV4MatchOperatorEnum? MatchOperator { get; set; }

    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecExportV4Operations>? Operations { get; set; }

    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecExportV4PeerTypeEnum? PeerType { get; set; }

    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecExportV4PrefixLength? PrefixLength { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("source")]
    public V1BGPFilterSpecExportV4SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6ActionEnum>))]
public enum V1BGPFilterSpecExportV6ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6Communities
{
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6MatchOperatorEnum>))]
public enum V1BGPFilterSpecExportV6MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6OperationsAddCommunity
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6OperationsPrependASPath
{
    [JsonPropertyName("prefix")]
    public required IList<int> Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6OperationsSetPriority
{
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6Operations
{
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecExportV6OperationsAddCommunity? AddCommunity { get; set; }

    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecExportV6OperationsPrependASPath? PrependASPath { get; set; }

    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecExportV6OperationsSetPriority? SetPriority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6PeerTypeEnum>))]
public enum V1BGPFilterSpecExportV6PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6SourceEnum>))]
public enum V1BGPFilterSpecExportV6SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecExportV6ActionEnum Action { get; set; }

    [JsonPropertyName("asPathPrefix")]
    public IList<int>? AsPathPrefix { get; set; }

    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("communities")]
    public V1BGPFilterSpecExportV6Communities? Communities { get; set; }

    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecExportV6MatchOperatorEnum? MatchOperator { get; set; }

    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecExportV6Operations>? Operations { get; set; }

    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecExportV6PeerTypeEnum? PeerType { get; set; }

    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecExportV6PrefixLength? PrefixLength { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("source")]
    public V1BGPFilterSpecExportV6SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4ActionEnum>))]
public enum V1BGPFilterSpecImportV4ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4Communities
{
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4MatchOperatorEnum>))]
public enum V1BGPFilterSpecImportV4MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4OperationsAddCommunity
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4OperationsPrependASPath
{
    [JsonPropertyName("prefix")]
    public required IList<int> Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4OperationsSetPriority
{
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4Operations
{
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecImportV4OperationsAddCommunity? AddCommunity { get; set; }

    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecImportV4OperationsPrependASPath? PrependASPath { get; set; }

    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecImportV4OperationsSetPriority? SetPriority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4PeerTypeEnum>))]
public enum V1BGPFilterSpecImportV4PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4SourceEnum>))]
public enum V1BGPFilterSpecImportV4SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecImportV4ActionEnum Action { get; set; }

    [JsonPropertyName("asPathPrefix")]
    public IList<int>? AsPathPrefix { get; set; }

    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("communities")]
    public V1BGPFilterSpecImportV4Communities? Communities { get; set; }

    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecImportV4MatchOperatorEnum? MatchOperator { get; set; }

    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecImportV4Operations>? Operations { get; set; }

    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecImportV4PeerTypeEnum? PeerType { get; set; }

    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecImportV4PrefixLength? PrefixLength { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("source")]
    public V1BGPFilterSpecImportV4SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6ActionEnum>))]
public enum V1BGPFilterSpecImportV6ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6Communities
{
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6MatchOperatorEnum>))]
public enum V1BGPFilterSpecImportV6MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6OperationsAddCommunity
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6OperationsPrependASPath
{
    [JsonPropertyName("prefix")]
    public required IList<int> Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6OperationsSetPriority
{
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6Operations
{
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecImportV6OperationsAddCommunity? AddCommunity { get; set; }

    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecImportV6OperationsPrependASPath? PrependASPath { get; set; }

    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecImportV6OperationsSetPriority? SetPriority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6PeerTypeEnum>))]
public enum V1BGPFilterSpecImportV6PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6SourceEnum>))]
public enum V1BGPFilterSpecImportV6SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecImportV6ActionEnum Action { get; set; }

    [JsonPropertyName("asPathPrefix")]
    public IList<int>? AsPathPrefix { get; set; }

    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    [JsonPropertyName("communities")]
    public V1BGPFilterSpecImportV6Communities? Communities { get; set; }

    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecImportV6MatchOperatorEnum? MatchOperator { get; set; }

    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecImportV6Operations>? Operations { get; set; }

    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecImportV6PeerTypeEnum? PeerType { get; set; }

    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecImportV6PrefixLength? PrefixLength { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("source")]
    public V1BGPFilterSpecImportV6SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpec
{
    [JsonPropertyName("exportV4")]
    public IList<V1BGPFilterSpecExportV4>? ExportV4 { get; set; }

    [JsonPropertyName("exportV6")]
    public IList<V1BGPFilterSpecExportV6>? ExportV6 { get; set; }

    [JsonPropertyName("importV4")]
    public IList<V1BGPFilterSpecImportV4>? ImportV4 { get; set; }

    [JsonPropertyName("importV6")]
    public IList<V1BGPFilterSpecImportV6>? ImportV6 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPFilter : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPFilterSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPFilter";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpfilters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPFilter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1BGPFilterSpec? Spec { get; set; }
}