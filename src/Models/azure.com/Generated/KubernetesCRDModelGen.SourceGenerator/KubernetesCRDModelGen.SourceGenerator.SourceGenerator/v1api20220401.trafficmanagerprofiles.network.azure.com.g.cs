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
/// - Generated from: /trafficmanager/resource-manager/Microsoft.Network/TrafficManager/stable/2022-04-01/trafficmanager.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401TrafficManagerProfileList : IKubernetesObject<V1ListMeta>, IItems<V1api20220401TrafficManagerProfile>
{
    public const string KubeApiVersion = "v1api20220401";
    public const string KubeKind = "TrafficManagerProfileList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20220401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficManagerProfileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220401TrafficManagerProfile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220401TrafficManagerProfile> Items { get; set; }
}

/// <summary>The allowed type DNS record types for this profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfileSpecAllowedEndpointRecordTypesEnum>))]
public enum V1api20220401TrafficManagerProfileSpecAllowedEndpointRecordTypesEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "DomainName"), JsonStringEnumMemberName("DomainName")]
    DomainName,
    [EnumMember(Value = "IPv4Address"), JsonStringEnumMemberName("IPv4Address")]
    IPv4Address,
    [EnumMember(Value = "IPv6Address"), JsonStringEnumMemberName("IPv6Address")]
    IPv6Address
}

/// <summary>DnsConfig: The DNS settings of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecDnsConfig
{
    /// <summary>
    /// RelativeName: The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain
    /// name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile.
    /// </summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary>
    /// Ttl: The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS
    /// responses provided by this Traffic Manager profile.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }
}

/// <summary>Custom header name and value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecMonitorConfigCustomHeaders
{
    /// <summary>Name: Header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Min and max value of a status code range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecMonitorConfigExpectedStatusCodeRanges
{
    /// <summary>Max: Max status code.</summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>Min: Min status code.</summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>ProfileMonitorStatus: The profile-level monitoring status of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfileSpecMonitorConfigProfileMonitorStatusEnum>))]
public enum V1api20220401TrafficManagerProfileSpecMonitorConfigProfileMonitorStatusEnum
{
    [EnumMember(Value = "CheckingEndpoints"), JsonStringEnumMemberName("CheckingEndpoints")]
    CheckingEndpoints,
    [EnumMember(Value = "Degraded"), JsonStringEnumMemberName("Degraded")]
    Degraded,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive,
    [EnumMember(Value = "Online"), JsonStringEnumMemberName("Online")]
    Online
}

/// <summary>Protocol: The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfileSpecMonitorConfigProtocolEnum>))]
public enum V1api20220401TrafficManagerProfileSpecMonitorConfigProtocolEnum
{
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    HTTP,
    [EnumMember(Value = "HTTPS"), JsonStringEnumMemberName("HTTPS")]
    HTTPS,
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP
}

/// <summary>MonitorConfig: The endpoint monitoring settings of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecMonitorConfig
{
    /// <summary>CustomHeaders: List of custom headers.</summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401TrafficManagerProfileSpecMonitorConfigCustomHeaders>? CustomHeaders { get; set; }

    /// <summary>ExpectedStatusCodeRanges: List of expected status code ranges.</summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<V1api20220401TrafficManagerProfileSpecMonitorConfigExpectedStatusCodeRanges>? ExpectedStatusCodeRanges { get; set; }

    /// <summary>
    /// IntervalInSeconds: The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager
    /// will check the health of each endpoint in this profile.
    /// </summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary>Path: The path relative to the endpoint domain name used to probe for endpoint health.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port: The TCP port used to probe for endpoint health.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProfileMonitorStatus: The profile-level monitoring status of the Traffic Manager profile.</summary>
    [JsonPropertyName("profileMonitorStatus")]
    public V1api20220401TrafficManagerProfileSpecMonitorConfigProfileMonitorStatusEnum? ProfileMonitorStatus { get; set; }

    /// <summary>Protocol: The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health.</summary>
    [JsonPropertyName("protocol")]
    public V1api20220401TrafficManagerProfileSpecMonitorConfigProtocolEnum? Protocol { get; set; }

    /// <summary>
    /// TimeoutInSeconds: The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows
    /// endpoints in this profile to response to the health check.
    /// </summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>
    /// ToleratedNumberOfFailures: The number of consecutive failed health check that Traffic Manager tolerates before declaring
    /// an endpoint in this profile Degraded after the next failed health check.
    /// </summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public int? ToleratedNumberOfFailures { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecOperatorSpecConfigMapExpressions
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

/// <summary>DnsConfigFqdn: indicates where the DnsConfigFqdn config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecOperatorSpecConfigMapsDnsConfigFqdn
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecOperatorSpecConfigMaps
{
    /// <summary>DnsConfigFqdn: indicates where the DnsConfigFqdn config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("dnsConfigFqdn")]
    public V1api20220401TrafficManagerProfileSpecOperatorSpecConfigMapsDnsConfigFqdn? DnsConfigFqdn { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220401TrafficManagerProfileSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20220401TrafficManagerProfileSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220401TrafficManagerProfileSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ProfileStatus: The status of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfileSpecProfileStatusEnum>))]
public enum V1api20220401TrafficManagerProfileSpecProfileStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>TrafficRoutingMethod: The traffic routing method of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfileSpecTrafficRoutingMethodEnum>))]
public enum V1api20220401TrafficManagerProfileSpecTrafficRoutingMethodEnum
{
    [EnumMember(Value = "Geographic"), JsonStringEnumMemberName("Geographic")]
    Geographic,
    [EnumMember(Value = "MultiValue"), JsonStringEnumMemberName("MultiValue")]
    MultiValue,
    [EnumMember(Value = "Performance"), JsonStringEnumMemberName("Performance")]
    Performance,
    [EnumMember(Value = "Priority"), JsonStringEnumMemberName("Priority")]
    Priority,
    [EnumMember(Value = "Subnet"), JsonStringEnumMemberName("Subnet")]
    Subnet,
    [EnumMember(Value = "Weighted"), JsonStringEnumMemberName("Weighted")]
    Weighted
}

/// <summary>
/// TrafficViewEnrollmentStatus: Indicates whether Traffic View is &apos;Enabled&apos; or &apos;Disabled&apos; for the Traffic Manager profile.
/// Null, indicates &apos;Disabled&apos;. Enabling this feature will increase the cost of the Traffic Manage profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfileSpecTrafficViewEnrollmentStatusEnum>))]
public enum V1api20220401TrafficManagerProfileSpecTrafficViewEnrollmentStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileSpec
{
    /// <summary>AllowedEndpointRecordTypes: The list of allowed endpoint record types.</summary>
    [JsonPropertyName("allowedEndpointRecordTypes")]
    public IList<V1api20220401TrafficManagerProfileSpecAllowedEndpointRecordTypesEnum>? AllowedEndpointRecordTypes { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DnsConfig: The DNS settings of the Traffic Manager profile.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20220401TrafficManagerProfileSpecDnsConfig? DnsConfig { get; set; }

    /// <summary>Location: The Azure Region where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaxReturn: Maximum number of endpoints to be returned for MultiValue routing type.</summary>
    [JsonPropertyName("maxReturn")]
    public int? MaxReturn { get; set; }

    /// <summary>MonitorConfig: The endpoint monitoring settings of the Traffic Manager profile.</summary>
    [JsonPropertyName("monitorConfig")]
    public V1api20220401TrafficManagerProfileSpecMonitorConfig? MonitorConfig { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220401TrafficManagerProfileSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220401TrafficManagerProfileSpecOwner Owner { get; set; }

    /// <summary>ProfileStatus: The status of the Traffic Manager profile.</summary>
    [JsonPropertyName("profileStatus")]
    public V1api20220401TrafficManagerProfileSpecProfileStatusEnum? ProfileStatus { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TrafficRoutingMethod: The traffic routing method of the Traffic Manager profile.</summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public V1api20220401TrafficManagerProfileSpecTrafficRoutingMethodEnum? TrafficRoutingMethod { get; set; }

    /// <summary>
    /// TrafficViewEnrollmentStatus: Indicates whether Traffic View is &apos;Enabled&apos; or &apos;Disabled&apos; for the Traffic Manager profile.
    /// Null, indicates &apos;Disabled&apos;. Enabling this feature will increase the cost of the Traffic Manage profile.
    /// </summary>
    [JsonPropertyName("trafficViewEnrollmentStatus")]
    public V1api20220401TrafficManagerProfileSpecTrafficViewEnrollmentStatusEnum? TrafficViewEnrollmentStatus { get; set; }

    /// <summary>Type: The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusConditions
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

/// <summary>DnsConfig: The DNS settings of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusDnsConfig
{
    /// <summary>
    /// Fqdn: The fully-qualified domain name (FQDN) of the Traffic Manager profile. This is formed from the concatenation of
    /// the RelativeName with the DNS domain used by Azure Traffic Manager.
    /// </summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>
    /// RelativeName: The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain
    /// name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile.
    /// </summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary>
    /// Ttl: The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS
    /// responses provided by this Traffic Manager profile.
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; set; }
}

/// <summary>Custom header name and value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusEndpointsCustomHeaders
{
    /// <summary>Name: Header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Subnet first address, scope, and/or last address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusEndpointsSubnets
{
    /// <summary>First: First address in the subnet.</summary>
    [JsonPropertyName("first")]
    public string? First { get; set; }

    /// <summary>Last: Last address in the subnet.</summary>
    [JsonPropertyName("last")]
    public string? Last { get; set; }

    /// <summary>Scope: Block size (number of leading bits in the subnet mask).</summary>
    [JsonPropertyName("scope")]
    public int? Scope { get; set; }
}

/// <summary>Class representing a Traffic Manager endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusEndpoints
{
    /// <summary>
    /// AlwaysServe: If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in
    /// the traffic routing method.
    /// </summary>
    [JsonPropertyName("alwaysServe")]
    public string? AlwaysServe { get; set; }

    /// <summary>CustomHeaders: List of custom headers.</summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401TrafficManagerProfileStatusEndpointsCustomHeaders>? CustomHeaders { get; set; }

    /// <summary>
    /// EndpointLocation: Specifies the location of the external or nested endpoints when using the &apos;Performance&apos; traffic
    /// routing method.
    /// </summary>
    [JsonPropertyName("endpointLocation")]
    public string? EndpointLocation { get; set; }

    /// <summary>EndpointMonitorStatus: The monitoring status of the endpoint.</summary>
    [JsonPropertyName("endpointMonitorStatus")]
    public string? EndpointMonitorStatus { get; set; }

    /// <summary>
    /// EndpointStatus: The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included
    /// in the traffic routing method.
    /// </summary>
    [JsonPropertyName("endpointStatus")]
    public string? EndpointStatus { get; set; }

    /// <summary>
    /// GeoMapping: The list of countries/regions mapped to this endpoint when using the &apos;Geographic&apos; traffic routing method.
    /// Please consult Traffic Manager Geographic documentation for a full list of accepted values.
    /// </summary>
    [JsonPropertyName("geoMapping")]
    public IList<string>? GeoMapping { get; set; }

    /// <summary>
    /// Id: Fully qualified resource Id for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// MinChildEndpoints: The minimum number of endpoints that must be available in the child profile in order for the parent
    /// profile to be considered available. Only applicable to endpoint of type &apos;NestedEndpoints&apos;.
    /// </summary>
    [JsonPropertyName("minChildEndpoints")]
    public int? MinChildEndpoints { get; set; }

    /// <summary>
    /// MinChildEndpointsIPv4: The minimum number of IPv4 (DNS record type A) endpoints that must be available in the child
    /// profile in order for the parent profile to be considered available. Only applicable to endpoint of type
    /// &apos;NestedEndpoints&apos;.
    /// </summary>
    [JsonPropertyName("minChildEndpointsIPv4")]
    public int? MinChildEndpointsIPv4 { get; set; }

    /// <summary>
    /// MinChildEndpointsIPv6: The minimum number of IPv6 (DNS record type AAAA) endpoints that must be available in the child
    /// profile in order for the parent profile to be considered available. Only applicable to endpoint of type
    /// &apos;NestedEndpoints&apos;.
    /// </summary>
    [JsonPropertyName("minChildEndpointsIPv6")]
    public int? MinChildEndpointsIPv6 { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Priority: The priority of this endpoint when using the &apos;Priority&apos; traffic routing method. Possible values are from 1 to
    /// 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all
    /// endpoints, and no two endpoints can share the same priority value.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Subnets: The list of subnets, IP addresses, and/or address ranges mapped to this endpoint when using the &apos;Subnet&apos;
    /// traffic routing method. An empty list will match all ranges not covered by other endpoints.
    /// </summary>
    [JsonPropertyName("subnets")]
    public IList<V1api20220401TrafficManagerProfileStatusEndpointsSubnets>? Subnets { get; set; }

    /// <summary>
    /// Target: The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses
    /// to direct traffic to this endpoint.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>TargetResourceId: The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type &apos;ExternalEndpoints&apos;.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Type: The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Weight: The weight of this endpoint when using the &apos;Weighted&apos; traffic routing method. Possible values are from 1 to 1000.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Custom header name and value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusMonitorConfigCustomHeaders
{
    /// <summary>Name: Header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Min and max value of a status code range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusMonitorConfigExpectedStatusCodeRanges
{
    /// <summary>Max: Max status code.</summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>Min: Min status code.</summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>MonitorConfig: The endpoint monitoring settings of the Traffic Manager profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatusMonitorConfig
{
    /// <summary>CustomHeaders: List of custom headers.</summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401TrafficManagerProfileStatusMonitorConfigCustomHeaders>? CustomHeaders { get; set; }

    /// <summary>ExpectedStatusCodeRanges: List of expected status code ranges.</summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<V1api20220401TrafficManagerProfileStatusMonitorConfigExpectedStatusCodeRanges>? ExpectedStatusCodeRanges { get; set; }

    /// <summary>
    /// IntervalInSeconds: The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager
    /// will check the health of each endpoint in this profile.
    /// </summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary>Path: The path relative to the endpoint domain name used to probe for endpoint health.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port: The TCP port used to probe for endpoint health.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProfileMonitorStatus: The profile-level monitoring status of the Traffic Manager profile.</summary>
    [JsonPropertyName("profileMonitorStatus")]
    public string? ProfileMonitorStatus { get; set; }

    /// <summary>Protocol: The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// TimeoutInSeconds: The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows
    /// endpoints in this profile to response to the health check.
    /// </summary>
    [JsonPropertyName("timeoutInSeconds")]
    public int? TimeoutInSeconds { get; set; }

    /// <summary>
    /// ToleratedNumberOfFailures: The number of consecutive failed health check that Traffic Manager tolerates before declaring
    /// an endpoint in this profile Degraded after the next failed health check.
    /// </summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public int? ToleratedNumberOfFailures { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfileStatus
{
    /// <summary>AllowedEndpointRecordTypes: The list of allowed endpoint record types.</summary>
    [JsonPropertyName("allowedEndpointRecordTypes")]
    public IList<string>? AllowedEndpointRecordTypes { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220401TrafficManagerProfileStatusConditions>? Conditions { get; set; }

    /// <summary>DnsConfig: The DNS settings of the Traffic Manager profile.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20220401TrafficManagerProfileStatusDnsConfig? DnsConfig { get; set; }

    /// <summary>Endpoints: The list of endpoints in the Traffic Manager profile.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1api20220401TrafficManagerProfileStatusEndpoints>? Endpoints { get; set; }

    /// <summary>
    /// Id: Fully qualified resource Id for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The Azure Region where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaxReturn: Maximum number of endpoints to be returned for MultiValue routing type.</summary>
    [JsonPropertyName("maxReturn")]
    public int? MaxReturn { get; set; }

    /// <summary>MonitorConfig: The endpoint monitoring settings of the Traffic Manager profile.</summary>
    [JsonPropertyName("monitorConfig")]
    public V1api20220401TrafficManagerProfileStatusMonitorConfig? MonitorConfig { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProfileStatus: The status of the Traffic Manager profile.</summary>
    [JsonPropertyName("profileStatus")]
    public string? ProfileStatus { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TrafficRoutingMethod: The traffic routing method of the Traffic Manager profile.</summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public string? TrafficRoutingMethod { get; set; }

    /// <summary>
    /// TrafficViewEnrollmentStatus: Indicates whether Traffic View is &apos;Enabled&apos; or &apos;Disabled&apos; for the Traffic Manager profile.
    /// Null, indicates &apos;Disabled&apos;. Enabling this feature will increase the cost of the Traffic Manage profile.
    /// </summary>
    [JsonPropertyName("trafficViewEnrollmentStatus")]
    public string? TrafficViewEnrollmentStatus { get; set; }

    /// <summary>Type: The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /trafficmanager/resource-manager/Microsoft.Network/TrafficManager/stable/2022-04-01/trafficmanager.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401TrafficManagerProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220401TrafficManagerProfileSpec?>, IStatus<V1api20220401TrafficManagerProfileStatus?>
{
    public const string KubeApiVersion = "v1api20220401";
    public const string KubeKind = "TrafficManagerProfile";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20220401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficManagerProfile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220401TrafficManagerProfileSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20220401TrafficManagerProfileStatus? Status { get; set; }
}