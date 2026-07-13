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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/NestedEndpoints/{endpointName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1api20220401TrafficManagerProfilesNestedEndpoint>
{
    public const string KubeApiVersion = "v1api20220401";
    public const string KubeKind = "TrafficManagerProfilesNestedEndpointList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofilesnestedendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20220401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficManagerProfilesNestedEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220401TrafficManagerProfilesNestedEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220401TrafficManagerProfilesNestedEndpoint> Items { get; set; }
}

/// <summary>
/// AlwaysServe: If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in
/// the traffic routing method.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfilesNestedEndpointSpecAlwaysServeEnum>))]
public enum V1api20220401TrafficManagerProfilesNestedEndpointSpecAlwaysServeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Custom header name and value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecCustomHeaders
{
    /// <summary>Name: Header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>EndpointMonitorStatus: The monitoring status of the endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfilesNestedEndpointSpecEndpointMonitorStatusEnum>))]
public enum V1api20220401TrafficManagerProfilesNestedEndpointSpecEndpointMonitorStatusEnum
{
    [EnumMember(Value = "CheckingEndpoint"), JsonStringEnumMemberName("CheckingEndpoint")]
    CheckingEndpoint,
    [EnumMember(Value = "Degraded"), JsonStringEnumMemberName("Degraded")]
    Degraded,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Inactive"), JsonStringEnumMemberName("Inactive")]
    Inactive,
    [EnumMember(Value = "Online"), JsonStringEnumMemberName("Online")]
    Online,
    [EnumMember(Value = "Stopped"), JsonStringEnumMemberName("Stopped")]
    Stopped,
    [EnumMember(Value = "Unmonitored"), JsonStringEnumMemberName("Unmonitored")]
    Unmonitored
}

/// <summary>
/// EndpointStatus: The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included
/// in the traffic routing method.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220401TrafficManagerProfilesNestedEndpointSpecEndpointStatusEnum>))]
public enum V1api20220401TrafficManagerProfilesNestedEndpointSpecEndpointStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecOperatorSpecSecretExpressions
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
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/TrafficManagerProfile resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Subnet first address, scope, and/or last address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecSubnets
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

/// <summary>
/// TargetResourceReference: The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type
/// &apos;ExternalEndpoints&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpecTargetResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointSpec
{
    /// <summary>
    /// AlwaysServe: If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in
    /// the traffic routing method.
    /// </summary>
    [JsonPropertyName("alwaysServe")]
    public V1api20220401TrafficManagerProfilesNestedEndpointSpecAlwaysServeEnum? AlwaysServe { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CustomHeaders: List of custom headers.</summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointSpecCustomHeaders>? CustomHeaders { get; set; }

    /// <summary>
    /// EndpointLocation: Specifies the location of the external or nested endpoints when using the &apos;Performance&apos; traffic
    /// routing method.
    /// </summary>
    [JsonPropertyName("endpointLocation")]
    public string? EndpointLocation { get; set; }

    /// <summary>EndpointMonitorStatus: The monitoring status of the endpoint.</summary>
    [JsonPropertyName("endpointMonitorStatus")]
    public V1api20220401TrafficManagerProfilesNestedEndpointSpecEndpointMonitorStatusEnum? EndpointMonitorStatus { get; set; }

    /// <summary>
    /// EndpointStatus: The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included
    /// in the traffic routing method.
    /// </summary>
    [JsonPropertyName("endpointStatus")]
    public V1api20220401TrafficManagerProfilesNestedEndpointSpecEndpointStatusEnum? EndpointStatus { get; set; }

    /// <summary>
    /// GeoMapping: The list of countries/regions mapped to this endpoint when using the &apos;Geographic&apos; traffic routing method.
    /// Please consult Traffic Manager Geographic documentation for a full list of accepted values.
    /// </summary>
    [JsonPropertyName("geoMapping")]
    public IList<string>? GeoMapping { get; set; }

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

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220401TrafficManagerProfilesNestedEndpointSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/TrafficManagerProfile resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220401TrafficManagerProfilesNestedEndpointSpecOwner Owner { get; set; }

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
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointSpecSubnets>? Subnets { get; set; }

    /// <summary>
    /// Target: The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses
    /// to direct traffic to this endpoint.
    /// </summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>
    /// TargetResourceReference: The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type
    /// &apos;ExternalEndpoints&apos;.
    /// </summary>
    [JsonPropertyName("targetResourceReference")]
    public V1api20220401TrafficManagerProfilesNestedEndpointSpecTargetResourceReference? TargetResourceReference { get; set; }

    /// <summary>Type: The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Weight: The weight of this endpoint when using the &apos;Weighted&apos; traffic routing method. Possible values are from 1 to 1000.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointStatusConditions
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

/// <summary>Custom header name and value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointStatusCustomHeaders
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
public partial class V1api20220401TrafficManagerProfilesNestedEndpointStatusSubnets
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220401TrafficManagerProfilesNestedEndpointStatus
{
    /// <summary>
    /// AlwaysServe: If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in
    /// the traffic routing method.
    /// </summary>
    [JsonPropertyName("alwaysServe")]
    public string? AlwaysServe { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>CustomHeaders: List of custom headers.</summary>
    [JsonPropertyName("customHeaders")]
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointStatusCustomHeaders>? CustomHeaders { get; set; }

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
    public IList<V1api20220401TrafficManagerProfilesNestedEndpointStatusSubnets>? Subnets { get; set; }

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

/// <summary>
/// Generator information:
/// - Generated from: /trafficmanager/resource-manager/Microsoft.Network/TrafficManager/stable/2022-04-01/trafficmanager.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}/NestedEndpoints/{endpointName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220401TrafficManagerProfilesNestedEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220401TrafficManagerProfilesNestedEndpointSpec?>, IStatus<V1api20220401TrafficManagerProfilesNestedEndpointStatus?>
{
    public const string KubeApiVersion = "v1api20220401";
    public const string KubeKind = "TrafficManagerProfilesNestedEndpoint";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "trafficmanagerprofilesnestedendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20220401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficManagerProfilesNestedEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220401TrafficManagerProfilesNestedEndpointSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20220401TrafficManagerProfilesNestedEndpointStatus? Status { get; set; }
}