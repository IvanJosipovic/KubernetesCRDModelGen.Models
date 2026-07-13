#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /dns/resource-manager/Microsoft.Network/Dns/stable/2018-05-01/dns.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SRV/{relativeRecordSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180501DnsZonesSRVRecordList : IKubernetesObject<V1ListMeta>, IItems<V1api20180501DnsZonesSRVRecord>
{
    public const string KubeApiVersion = "v1api20180501";
    public const string KubeKind = "DnsZonesSRVRecordList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "dnszonessrvrecords";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20180501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DnsZonesSRVRecordList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20180501DnsZonesSRVRecord objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20180501DnsZonesSRVRecord> Items { get; set; }
}

/// <summary>An AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecAAAARecords
{
    /// <summary>Ipv6Address: The IPv6 address of this AAAA record.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>An A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecARecords
{
    /// <summary>Ipv4Address: The IPv4 address of this A record.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>CNAMERecord: The CNAME record in the  record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecCNAMERecord
{
    /// <summary>Cname: The canonical name for this CNAME record.</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>An MX record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecMXRecords
{
    /// <summary>Exchange: The domain name of the mail host for this MX record.</summary>
    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    /// <summary>Preference: The preference value for this MX record.</summary>
    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>An NS record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecNSRecords
{
    /// <summary>Nsdname: The name server name for this NS record.</summary>
    [JsonPropertyName("nsdname")]
    public string? Nsdname { get; set; }
}

/// <summary>A PTR record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecPTRRecords
{
    /// <summary>Ptrdname: The PTR target domain name for this PTR record.</summary>
    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>SOARecord: The SOA record in the record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecSOARecord
{
    /// <summary>Email: The email contact for this SOA record.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ExpireTime: The expire time for this SOA record.</summary>
    [JsonPropertyName("expireTime")]
    public int? ExpireTime { get; set; }

    /// <summary>Host: The domain name of the authoritative name server for this SOA record.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>MinimumTTL: The minimum value for this SOA record. By convention this is used to determine the negative caching duration.</summary>
    [JsonPropertyName("minimumTTL")]
    public int? MinimumTTL { get; set; }

    /// <summary>RefreshTime: The refresh value for this SOA record.</summary>
    [JsonPropertyName("refreshTime")]
    public int? RefreshTime { get; set; }

    /// <summary>RetryTime: The retry time for this SOA record.</summary>
    [JsonPropertyName("retryTime")]
    public int? RetryTime { get; set; }

    /// <summary>SerialNumber: The serial number for this SOA record.</summary>
    [JsonPropertyName("serialNumber")]
    public int? SerialNumber { get; set; }
}

/// <summary>An SRV record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecSRVRecords
{
    /// <summary>Port: The port value for this SRV record.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Priority: The priority value for this SRV record.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Target: The target domain name for this SRV record.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Weight: The weight value for this SRV record.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>A TXT record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecTXTRecords
{
    /// <summary>Value: The text value of this TXT record.</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

/// <summary>A CAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecCaaRecords
{
    /// <summary>Flags: The flags for this CAA record as an integer between 0 and 255.</summary>
    [JsonPropertyName("flags")]
    public int? Flags { get; set; }

    /// <summary>Tag: The tag for this CAA record.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Value: The value for this CAA record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20180501DnsZonesSRVRecordSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20180501DnsZonesSRVRecordSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/DnsZone resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecTargetResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>TargetResource: A reference to an azure resource from where the dns resource value is taken.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpecTargetResource
{
    /// <summary>Reference: Resource Id.</summary>
    [JsonPropertyName("reference")]
    public V1api20180501DnsZonesSRVRecordSpecTargetResourceReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordSpec
{
    /// <summary>AAAARecords: The list of AAAA records in the record set.</summary>
    [JsonPropertyName("AAAARecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecAAAARecords>? AAAARecords { get; set; }

    /// <summary>ARecords: The list of A records in the record set.</summary>
    [JsonPropertyName("ARecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecARecords>? ARecords { get; set; }

    /// <summary>CNAMERecord: The CNAME record in the  record set.</summary>
    [JsonPropertyName("CNAMERecord")]
    public V1api20180501DnsZonesSRVRecordSpecCNAMERecord? CNAMERecord { get; set; }

    /// <summary>MXRecords: The list of MX records in the record set.</summary>
    [JsonPropertyName("MXRecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecMXRecords>? MXRecords { get; set; }

    /// <summary>NSRecords: The list of NS records in the record set.</summary>
    [JsonPropertyName("NSRecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecNSRecords>? NSRecords { get; set; }

    /// <summary>PTRRecords: The list of PTR records in the record set.</summary>
    [JsonPropertyName("PTRRecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecPTRRecords>? PTRRecords { get; set; }

    /// <summary>SOARecord: The SOA record in the record set.</summary>
    [JsonPropertyName("SOARecord")]
    public V1api20180501DnsZonesSRVRecordSpecSOARecord? SOARecord { get; set; }

    /// <summary>SRVRecords: The list of SRV records in the record set.</summary>
    [JsonPropertyName("SRVRecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecSRVRecords>? SRVRecords { get; set; }

    /// <summary>TTL: The TTL (time-to-live) of the records in the record set.</summary>
    [JsonPropertyName("TTL")]
    public int? TTL { get; set; }

    /// <summary>TXTRecords: The list of TXT records in the record set.</summary>
    [JsonPropertyName("TXTRecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecTXTRecords>? TXTRecords { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CaaRecords: The list of CAA records in the record set.</summary>
    [JsonPropertyName("caaRecords")]
    public IList<V1api20180501DnsZonesSRVRecordSpecCaaRecords>? CaaRecords { get; set; }

    /// <summary>Metadata: The metadata attached to the record set.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20180501DnsZonesSRVRecordSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/DnsZone resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20180501DnsZonesSRVRecordSpecOwner Owner { get; set; }

    /// <summary>TargetResource: A reference to an azure resource from where the dns resource value is taken.</summary>
    [JsonPropertyName("targetResource")]
    public V1api20180501DnsZonesSRVRecordSpecTargetResource? TargetResource { get; set; }
}

/// <summary>An AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusAAAARecords
{
    /// <summary>Ipv6Address: The IPv6 address of this AAAA record.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>An A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusARecords
{
    /// <summary>Ipv4Address: The IPv4 address of this A record.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>CNAMERecord: The CNAME record in the  record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusCNAMERecord
{
    /// <summary>Cname: The canonical name for this CNAME record.</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>An MX record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusMXRecords
{
    /// <summary>Exchange: The domain name of the mail host for this MX record.</summary>
    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    /// <summary>Preference: The preference value for this MX record.</summary>
    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>An NS record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusNSRecords
{
    /// <summary>Nsdname: The name server name for this NS record.</summary>
    [JsonPropertyName("nsdname")]
    public string? Nsdname { get; set; }
}

/// <summary>A PTR record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusPTRRecords
{
    /// <summary>Ptrdname: The PTR target domain name for this PTR record.</summary>
    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>SOARecord: The SOA record in the record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusSOARecord
{
    /// <summary>Email: The email contact for this SOA record.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ExpireTime: The expire time for this SOA record.</summary>
    [JsonPropertyName("expireTime")]
    public int? ExpireTime { get; set; }

    /// <summary>Host: The domain name of the authoritative name server for this SOA record.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>MinimumTTL: The minimum value for this SOA record. By convention this is used to determine the negative caching duration.</summary>
    [JsonPropertyName("minimumTTL")]
    public int? MinimumTTL { get; set; }

    /// <summary>RefreshTime: The refresh value for this SOA record.</summary>
    [JsonPropertyName("refreshTime")]
    public int? RefreshTime { get; set; }

    /// <summary>RetryTime: The retry time for this SOA record.</summary>
    [JsonPropertyName("retryTime")]
    public int? RetryTime { get; set; }

    /// <summary>SerialNumber: The serial number for this SOA record.</summary>
    [JsonPropertyName("serialNumber")]
    public int? SerialNumber { get; set; }
}

/// <summary>An SRV record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusSRVRecords
{
    /// <summary>Port: The port value for this SRV record.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Priority: The priority value for this SRV record.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Target: The target domain name for this SRV record.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Weight: The weight value for this SRV record.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>A TXT record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusTXTRecords
{
    /// <summary>Value: The text value of this TXT record.</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

/// <summary>A CAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusCaaRecords
{
    /// <summary>Flags: The flags for this CAA record as an integer between 0 and 255.</summary>
    [JsonPropertyName("flags")]
    public int? Flags { get; set; }

    /// <summary>Tag: The tag for this CAA record.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Value: The value for this CAA record.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>TargetResource: A reference to an azure resource from where the dns resource value is taken.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatusTargetResource
{
    /// <summary>Id: Resource Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501DnsZonesSRVRecordStatus
{
    /// <summary>AAAARecords: The list of AAAA records in the record set.</summary>
    [JsonPropertyName("AAAARecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusAAAARecords>? AAAARecords { get; set; }

    /// <summary>ARecords: The list of A records in the record set.</summary>
    [JsonPropertyName("ARecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusARecords>? ARecords { get; set; }

    /// <summary>CNAMERecord: The CNAME record in the  record set.</summary>
    [JsonPropertyName("CNAMERecord")]
    public V1api20180501DnsZonesSRVRecordStatusCNAMERecord? CNAMERecord { get; set; }

    /// <summary>MXRecords: The list of MX records in the record set.</summary>
    [JsonPropertyName("MXRecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusMXRecords>? MXRecords { get; set; }

    /// <summary>NSRecords: The list of NS records in the record set.</summary>
    [JsonPropertyName("NSRecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusNSRecords>? NSRecords { get; set; }

    /// <summary>PTRRecords: The list of PTR records in the record set.</summary>
    [JsonPropertyName("PTRRecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusPTRRecords>? PTRRecords { get; set; }

    /// <summary>SOARecord: The SOA record in the record set.</summary>
    [JsonPropertyName("SOARecord")]
    public V1api20180501DnsZonesSRVRecordStatusSOARecord? SOARecord { get; set; }

    /// <summary>SRVRecords: The list of SRV records in the record set.</summary>
    [JsonPropertyName("SRVRecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusSRVRecords>? SRVRecords { get; set; }

    /// <summary>TTL: The TTL (time-to-live) of the records in the record set.</summary>
    [JsonPropertyName("TTL")]
    public int? TTL { get; set; }

    /// <summary>TXTRecords: The list of TXT records in the record set.</summary>
    [JsonPropertyName("TXTRecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusTXTRecords>? TXTRecords { get; set; }

    /// <summary>CaaRecords: The list of CAA records in the record set.</summary>
    [JsonPropertyName("caaRecords")]
    public IList<V1api20180501DnsZonesSRVRecordStatusCaaRecords>? CaaRecords { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180501DnsZonesSRVRecordStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: The etag of the record set.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Fqdn: Fully qualified domain name of the record set.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Id: The ID of the record set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Metadata: The metadata attached to the record set.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name: The name of the record set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: provisioning State of the record set.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>TargetResource: A reference to an azure resource from where the dns resource value is taken.</summary>
    [JsonPropertyName("targetResource")]
    public V1api20180501DnsZonesSRVRecordStatusTargetResource? TargetResource { get; set; }

    /// <summary>Type: The type of the record set.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /dns/resource-manager/Microsoft.Network/Dns/stable/2018-05-01/dns.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/SRV/{relativeRecordSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180501DnsZonesSRVRecord : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180501DnsZonesSRVRecordSpec?>, IStatus<V1api20180501DnsZonesSRVRecordStatus?>
{
    public const string KubeApiVersion = "v1api20180501";
    public const string KubeKind = "DnsZonesSRVRecord";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "dnszonessrvrecords";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20180501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DnsZonesSRVRecord";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20180501DnsZonesSRVRecordSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20180501DnsZonesSRVRecordStatus? Status { get; set; }
}