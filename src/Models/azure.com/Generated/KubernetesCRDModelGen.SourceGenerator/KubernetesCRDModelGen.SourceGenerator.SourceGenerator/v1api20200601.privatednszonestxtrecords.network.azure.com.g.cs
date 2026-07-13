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
/// - Generated from: /privatedns/resource-manager/Microsoft.Network/PrivateDns/stable/2020-06-01/privatedns.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/TXT/{relativeRecordSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601PrivateDnsZonesTXTRecordList : IKubernetesObject<V1ListMeta>, IItems<V1api20200601PrivateDnsZonesTXTRecord>
{
    public const string KubeApiVersion = "v1api20200601";
    public const string KubeKind = "PrivateDnsZonesTXTRecordList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privatednszonestxtrecords";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20200601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateDnsZonesTXTRecordList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200601PrivateDnsZonesTXTRecord objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200601PrivateDnsZonesTXTRecord> Items { get; set; }
}

/// <summary>Ipv4AddressFromConfig: The IPv4 address of this A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecARecordsIpv4AddressFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>An A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecARecords
{
    /// <summary>Ipv4Address: The IPv4 address of this A record.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }

    /// <summary>Ipv4AddressFromConfig: The IPv4 address of this A record.</summary>
    [JsonPropertyName("ipv4AddressFromConfig")]
    public V1api20200601PrivateDnsZonesTXTRecordSpecARecordsIpv4AddressFromConfig? Ipv4AddressFromConfig { get; set; }
}

/// <summary>Ipv6AddressFromConfig: The IPv6 address of this AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecAaaaRecordsIpv6AddressFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>An AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecAaaaRecords
{
    /// <summary>Ipv6Address: The IPv6 address of this AAAA record.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>Ipv6AddressFromConfig: The IPv6 address of this AAAA record.</summary>
    [JsonPropertyName("ipv6AddressFromConfig")]
    public V1api20200601PrivateDnsZonesTXTRecordSpecAaaaRecordsIpv6AddressFromConfig? Ipv6AddressFromConfig { get; set; }
}

/// <summary>CnameRecord: The CNAME record in the record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecCnameRecord
{
    /// <summary>Cname: The canonical name for this CNAME record.</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>An MX record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecMxRecords
{
    /// <summary>Exchange: The domain name of the mail host for this MX record.</summary>
    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    /// <summary>Preference: The preference value for this MX record.</summary>
    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecOperatorSpecSecretExpressions
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
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/PrivateDnsZone resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A PTR record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecPtrRecords
{
    /// <summary>Ptrdname: The PTR target domain name for this PTR record.</summary>
    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>SoaRecord: The SOA record in the record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecSoaRecord
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

    /// <summary>MinimumTtl: The minimum value for this SOA record. By convention this is used to determine the negative caching duration.</summary>
    [JsonPropertyName("minimumTtl")]
    public int? MinimumTtl { get; set; }

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
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecSrvRecords
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
public partial class V1api20200601PrivateDnsZonesTXTRecordSpecTxtRecords
{
    /// <summary>Value: The text value of this TXT record.</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordSpec
{
    /// <summary>ARecords: The list of A records in the record set.</summary>
    [JsonPropertyName("aRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecARecords>? ARecords { get; set; }

    /// <summary>AaaaRecords: The list of AAAA records in the record set.</summary>
    [JsonPropertyName("aaaaRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecAaaaRecords>? AaaaRecords { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CnameRecord: The CNAME record in the record set.</summary>
    [JsonPropertyName("cnameRecord")]
    public V1api20200601PrivateDnsZonesTXTRecordSpecCnameRecord? CnameRecord { get; set; }

    /// <summary>Etag: The ETag of the record set.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Metadata: The metadata attached to the record set.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>MxRecords: The list of MX records in the record set.</summary>
    [JsonPropertyName("mxRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecMxRecords>? MxRecords { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200601PrivateDnsZonesTXTRecordSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/PrivateDnsZone resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200601PrivateDnsZonesTXTRecordSpecOwner Owner { get; set; }

    /// <summary>PtrRecords: The list of PTR records in the record set.</summary>
    [JsonPropertyName("ptrRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecPtrRecords>? PtrRecords { get; set; }

    /// <summary>SoaRecord: The SOA record in the record set.</summary>
    [JsonPropertyName("soaRecord")]
    public V1api20200601PrivateDnsZonesTXTRecordSpecSoaRecord? SoaRecord { get; set; }

    /// <summary>SrvRecords: The list of SRV records in the record set.</summary>
    [JsonPropertyName("srvRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecSrvRecords>? SrvRecords { get; set; }

    /// <summary>Ttl: The TTL (time-to-live) of the records in the record set.</summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>TxtRecords: The list of TXT records in the record set.</summary>
    [JsonPropertyName("txtRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordSpecTxtRecords>? TxtRecords { get; set; }
}

/// <summary>An A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusARecords
{
    /// <summary>Ipv4Address: The IPv4 address of this A record.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>An AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusAaaaRecords
{
    /// <summary>Ipv6Address: The IPv6 address of this AAAA record.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>CnameRecord: The CNAME record in the record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusCnameRecord
{
    /// <summary>Cname: The canonical name for this CNAME record.</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusConditions
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

/// <summary>An MX record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusMxRecords
{
    /// <summary>Exchange: The domain name of the mail host for this MX record.</summary>
    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    /// <summary>Preference: The preference value for this MX record.</summary>
    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>A PTR record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusPtrRecords
{
    /// <summary>Ptrdname: The PTR target domain name for this PTR record.</summary>
    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>SoaRecord: The SOA record in the record set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusSoaRecord
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

    /// <summary>MinimumTtl: The minimum value for this SOA record. By convention this is used to determine the negative caching duration.</summary>
    [JsonPropertyName("minimumTtl")]
    public int? MinimumTtl { get; set; }

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
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusSrvRecords
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
public partial class V1api20200601PrivateDnsZonesTXTRecordStatusTxtRecords
{
    /// <summary>Value: The text value of this TXT record.</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601PrivateDnsZonesTXTRecordStatus
{
    /// <summary>ARecords: The list of A records in the record set.</summary>
    [JsonPropertyName("aRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusARecords>? ARecords { get; set; }

    /// <summary>AaaaRecords: The list of AAAA records in the record set.</summary>
    [JsonPropertyName("aaaaRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusAaaaRecords>? AaaaRecords { get; set; }

    /// <summary>CnameRecord: The CNAME record in the record set.</summary>
    [JsonPropertyName("cnameRecord")]
    public V1api20200601PrivateDnsZonesTXTRecordStatusCnameRecord? CnameRecord { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: The ETag of the record set.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Fqdn: Fully qualified domain name of the record set.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>
    /// Id: Fully qualified resource Id for the resource. Example -
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateDnsZoneName}&apos;.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsAutoRegistered: Is the record set auto-registered in the Private DNS zone through a virtual network link?</summary>
    [JsonPropertyName("isAutoRegistered")]
    public bool? IsAutoRegistered { get; set; }

    /// <summary>Metadata: The metadata attached to the record set.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>MxRecords: The list of MX records in the record set.</summary>
    [JsonPropertyName("mxRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusMxRecords>? MxRecords { get; set; }

    /// <summary>Name: The name of the record set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PtrRecords: The list of PTR records in the record set.</summary>
    [JsonPropertyName("ptrRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusPtrRecords>? PtrRecords { get; set; }

    /// <summary>SoaRecord: The SOA record in the record set.</summary>
    [JsonPropertyName("soaRecord")]
    public V1api20200601PrivateDnsZonesTXTRecordStatusSoaRecord? SoaRecord { get; set; }

    /// <summary>SrvRecords: The list of SRV records in the record set.</summary>
    [JsonPropertyName("srvRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusSrvRecords>? SrvRecords { get; set; }

    /// <summary>Ttl: The TTL (time-to-live) of the records in the record set.</summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    /// <summary>TxtRecords: The list of TXT records in the record set.</summary>
    [JsonPropertyName("txtRecords")]
    public IList<V1api20200601PrivateDnsZonesTXTRecordStatusTxtRecords>? TxtRecords { get; set; }

    /// <summary>Type: The type of the resource. Example - &apos;Microsoft.Network/privateDnsZones&apos;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /privatedns/resource-manager/Microsoft.Network/PrivateDns/stable/2020-06-01/privatedns.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/TXT/{relativeRecordSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601PrivateDnsZonesTXTRecord : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200601PrivateDnsZonesTXTRecordSpec?>, IStatus<V1api20200601PrivateDnsZonesTXTRecordStatus?>
{
    public const string KubeApiVersion = "v1api20200601";
    public const string KubeKind = "PrivateDnsZonesTXTRecord";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privatednszonestxtrecords";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20200601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateDnsZonesTXTRecord";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20200601PrivateDnsZonesTXTRecordSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20200601PrivateDnsZonesTXTRecordStatus? Status { get; set; }
}