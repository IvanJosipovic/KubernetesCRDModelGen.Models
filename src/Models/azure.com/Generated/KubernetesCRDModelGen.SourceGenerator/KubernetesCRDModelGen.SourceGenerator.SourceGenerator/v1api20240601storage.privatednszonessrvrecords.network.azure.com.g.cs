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
/// Storage version of v1api20240601.PrivateDnsZonesSRVRecord
/// Generator information:
/// - Generated from: /privatedns/resource-manager/Microsoft.Network/PrivateDns/stable/2024-06-01/privatedns.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/SRV/{relativeRecordSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordList : IKubernetesObject<V1ListMeta>, IItems<V1api20240601storagePrivateDnsZonesSRVRecord>
{
    public const string KubeApiVersion = "v1api20240601storage";
    public const string KubeKind = "PrivateDnsZonesSRVRecordList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privatednszonessrvrecords";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateDnsZonesSRVRecordList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240601storagePrivateDnsZonesSRVRecord objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240601storagePrivateDnsZonesSRVRecord> Items { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecARecordsIpv4AddressFromConfig
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

/// <summary>
/// Storage version of v1api20240601.ARecord
/// An A record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecARecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("ipv4AddressFromConfig")]
    public V1api20240601storagePrivateDnsZonesSRVRecordSpecARecordsIpv4AddressFromConfig? Ipv4AddressFromConfig { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecAaaaRecordsIpv6AddressFromConfig
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

/// <summary>
/// Storage version of v1api20240601.AaaaRecord
/// An AAAA record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecAaaaRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("ipv6AddressFromConfig")]
    public V1api20240601storagePrivateDnsZonesSRVRecordSpecAaaaRecordsIpv6AddressFromConfig? Ipv6AddressFromConfig { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.CnameRecord
/// A CNAME record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecCnameRecord
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.MxRecord
/// An MX record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecMxRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

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
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240601.PrivateDnsZonesSRVRecordOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/PrivateDnsZone resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.PtrRecord
/// A PTR record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecPtrRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.SoaRecord
/// An SOA record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecSoaRecord
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("expireTime")]
    public int? ExpireTime { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("minimumTtl")]
    public int? MinimumTtl { get; set; }

    [JsonPropertyName("refreshTime")]
    public int? RefreshTime { get; set; }

    [JsonPropertyName("retryTime")]
    public int? RetryTime { get; set; }

    [JsonPropertyName("serialNumber")]
    public int? SerialNumber { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.SrvRecord
/// An SRV record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecSrvRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.TxtRecord
/// A TXT record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpecTxtRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

/// <summary>Storage version of v1api20240601.PrivateDnsZonesSRVRecord_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("aRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecARecords>? ARecords { get; set; }

    [JsonPropertyName("aaaaRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecAaaaRecords>? AaaaRecords { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20240601.CnameRecord
    /// A CNAME record.
    /// </summary>
    [JsonPropertyName("cnameRecord")]
    public V1api20240601storagePrivateDnsZonesSRVRecordSpecCnameRecord? CnameRecord { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("mxRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecMxRecords>? MxRecords { get; set; }

    /// <summary>
    /// Storage version of v1api20240601.PrivateDnsZonesSRVRecordOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240601storagePrivateDnsZonesSRVRecordSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/PrivateDnsZone resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240601storagePrivateDnsZonesSRVRecordSpecOwner Owner { get; set; }

    [JsonPropertyName("ptrRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecPtrRecords>? PtrRecords { get; set; }

    /// <summary>
    /// Storage version of v1api20240601.SoaRecord
    /// An SOA record.
    /// </summary>
    [JsonPropertyName("soaRecord")]
    public V1api20240601storagePrivateDnsZonesSRVRecordSpecSoaRecord? SoaRecord { get; set; }

    [JsonPropertyName("srvRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecSrvRecords>? SrvRecords { get; set; }

    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    [JsonPropertyName("txtRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordSpecTxtRecords>? TxtRecords { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.ARecord_STATUS
/// An A record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusARecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.AaaaRecord_STATUS
/// An AAAA record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusAaaaRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.CnameRecord_STATUS
/// A CNAME record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusCnameRecord
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusConditions
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

/// <summary>
/// Storage version of v1api20240601.MxRecord_STATUS
/// An MX record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusMxRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.PtrRecord_STATUS
/// A PTR record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusPtrRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.SoaRecord_STATUS
/// An SOA record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusSoaRecord
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("expireTime")]
    public int? ExpireTime { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("minimumTtl")]
    public int? MinimumTtl { get; set; }

    [JsonPropertyName("refreshTime")]
    public int? RefreshTime { get; set; }

    [JsonPropertyName("retryTime")]
    public int? RetryTime { get; set; }

    [JsonPropertyName("serialNumber")]
    public int? SerialNumber { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.SrvRecord_STATUS
/// An SRV record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusSrvRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.TxtRecord_STATUS
/// A TXT record.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatusTxtRecords
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

/// <summary>Storage version of v1api20240601.PrivateDnsZonesSRVRecord_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240601storagePrivateDnsZonesSRVRecordStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("aRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusARecords>? ARecords { get; set; }

    [JsonPropertyName("aaaaRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusAaaaRecords>? AaaaRecords { get; set; }

    /// <summary>
    /// Storage version of v1api20240601.CnameRecord_STATUS
    /// A CNAME record.
    /// </summary>
    [JsonPropertyName("cnameRecord")]
    public V1api20240601storagePrivateDnsZonesSRVRecordStatusCnameRecord? CnameRecord { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isAutoRegistered")]
    public bool? IsAutoRegistered { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("mxRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusMxRecords>? MxRecords { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ptrRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusPtrRecords>? PtrRecords { get; set; }

    /// <summary>
    /// Storage version of v1api20240601.SoaRecord_STATUS
    /// An SOA record.
    /// </summary>
    [JsonPropertyName("soaRecord")]
    public V1api20240601storagePrivateDnsZonesSRVRecordStatusSoaRecord? SoaRecord { get; set; }

    [JsonPropertyName("srvRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusSrvRecords>? SrvRecords { get; set; }

    /// <summary>
    /// Storage version of v1api20240601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20240601storagePrivateDnsZonesSRVRecordStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }

    [JsonPropertyName("txtRecords")]
    public IList<V1api20240601storagePrivateDnsZonesSRVRecordStatusTxtRecords>? TxtRecords { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240601.PrivateDnsZonesSRVRecord
/// Generator information:
/// - Generated from: /privatedns/resource-manager/Microsoft.Network/PrivateDns/stable/2024-06-01/privatedns.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateZoneName}/SRV/{relativeRecordSetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240601storagePrivateDnsZonesSRVRecord : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240601storagePrivateDnsZonesSRVRecordSpec?>, IStatus<V1api20240601storagePrivateDnsZonesSRVRecordStatus?>
{
    public const string KubeApiVersion = "v1api20240601storage";
    public const string KubeKind = "PrivateDnsZonesSRVRecord";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "privatednszonessrvrecords";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateDnsZonesSRVRecord";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240601.PrivateDnsZonesSRVRecord_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240601storagePrivateDnsZonesSRVRecordSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240601.PrivateDnsZonesSRVRecord_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240601storagePrivateDnsZonesSRVRecordStatus? Status { get; set; }
}