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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2022-07-01/applicationGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220701ApplicationGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1api20220701ApplicationGateway>
{
    public const string KubeApiVersion = "v1api20220701";
    public const string KubeKind = "ApplicationGatewayList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "applicationgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20220701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220701ApplicationGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220701ApplicationGateway> Items { get; set; }
}

/// <summary>Data: Certificate public data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecAuthenticationCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Authentication certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecAuthenticationCertificates
{
    /// <summary>Data: Certificate public data.</summary>
    [JsonPropertyName("data")]
    public V1api20220701ApplicationGatewaySpecAuthenticationCertificatesData? Data { get; set; }

    /// <summary>Name: Name of the authentication certificate that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>AutoscaleConfiguration: Autoscale Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecAutoscaleConfiguration
{
    /// <summary>MaxCapacity: Upper bound on number of Application Gateway capacity.</summary>
    [JsonPropertyName("maxCapacity")]
    public int? MaxCapacity { get; set; }

    /// <summary>MinCapacity: Lower bound on number of Application Gateway capacity.</summary>
    [JsonPropertyName("minCapacity")]
    public required int MinCapacity { get; set; }
}

/// <summary>Backend address of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendAddressPoolsBackendAddresses
{
    /// <summary>Fqdn: Fully qualified domain name (FQDN).</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>IpAddress: IP address.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>Backend Address Pool of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendAddressPools
{
    /// <summary>BackendAddresses: Backend addresses.</summary>
    [JsonPropertyName("backendAddresses")]
    public IList<V1api20220701ApplicationGatewaySpecBackendAddressPoolsBackendAddresses>? BackendAddresses { get; set; }

    /// <summary>Name: Name of the backend address pool that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificatesReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificates
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificatesReference? Reference { get; set; }
}

/// <summary>ConnectionDraining: Connection draining of the backend http settings resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionConnectionDraining
{
    /// <summary>
    /// DrainTimeoutInSec: The number of seconds connection draining is active. Acceptable values are from 1 second to 3600
    /// seconds.
    /// </summary>
    [JsonPropertyName("drainTimeoutInSec")]
    public required int DrainTimeoutInSec { get; set; }

    /// <summary>Enabled: Whether connection draining is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>CookieBasedAffinity: Cookie based affinity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionCookieBasedAffinityEnum>))]
public enum V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionCookieBasedAffinityEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProbeReference
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

/// <summary>Probe: Probe resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProbe
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProbeReference? Reference { get; set; }
}

/// <summary>Protocol: The protocol used to communicate with the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProtocolEnum>))]
public enum V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Tls"), JsonStringEnumMemberName("Tls")]
    Tls
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificatesReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificates
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificatesReference? Reference { get; set; }
}

/// <summary>Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollection
{
    /// <summary>AffinityCookieName: Cookie name to use for the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>AuthenticationCertificates: Array of references to application gateway authentication certificates.</summary>
    [JsonPropertyName("authenticationCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionAuthenticationCertificates>? AuthenticationCertificates { get; set; }

    /// <summary>ConnectionDraining: Connection draining of the backend http settings resource.</summary>
    [JsonPropertyName("connectionDraining")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionConnectionDraining? ConnectionDraining { get; set; }

    /// <summary>CookieBasedAffinity: Cookie based affinity.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionCookieBasedAffinityEnum? CookieBasedAffinity { get; set; }

    /// <summary>HostName: Host header to be sent to the backend servers.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Name: Name of the backend http settings that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path: Path which should be used as a prefix for all HTTP requests. Null means no path will be prefixed. Default value is
    /// null.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// PickHostNameFromBackendAddress: Whether to pick host header should be picked from the host name of the backend server.
    /// Default value is false.
    /// </summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>Port: The destination port on the backend.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Probe: Probe resource of an application gateway.</summary>
    [JsonPropertyName("probe")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProbe? Probe { get; set; }

    /// <summary>ProbeEnabled: Whether the probe is enabled. Default value is false.</summary>
    [JsonPropertyName("probeEnabled")]
    public bool? ProbeEnabled { get; set; }

    /// <summary>Protocol: The protocol used to communicate with the backend.</summary>
    [JsonPropertyName("protocol")]
    public V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionProtocolEnum? Protocol { get; set; }

    /// <summary>
    /// RequestTimeout: Request timeout in seconds. Application Gateway will fail the request if response is not received within
    /// RequestTimeout. Acceptable values are from 1 second to 86400 seconds.
    /// </summary>
    [JsonPropertyName("requestTimeout")]
    public int? RequestTimeout { get; set; }

    /// <summary>TrustedRootCertificates: Array of references to application gateway trusted root certificates.</summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollectionTrustedRootCertificates>? TrustedRootCertificates { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProbeReference
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

/// <summary>Probe: Probe resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProbe
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProbeReference? Reference { get; set; }
}

/// <summary>Protocol: The protocol used to communicate with the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProtocolEnum>))]
public enum V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Tls"), JsonStringEnumMemberName("Tls")]
    Tls
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificatesReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificates
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificatesReference? Reference { get; set; }
}

/// <summary>Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecBackendSettingsCollection
{
    /// <summary>HostName: Server name indication to be sent to the backend servers for Tls protocol.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Name: Name of the backend settings that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PickHostNameFromBackendAddress: Whether to pick server name indication from the host name of the backend server for Tls
    /// protocol. Default value is false.
    /// </summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>Port: The destination port on the backend.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Probe: Probe resource of an application gateway.</summary>
    [JsonPropertyName("probe")]
    public V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProbe? Probe { get; set; }

    /// <summary>Protocol: The protocol used to communicate with the backend.</summary>
    [JsonPropertyName("protocol")]
    public V1api20220701ApplicationGatewaySpecBackendSettingsCollectionProtocolEnum? Protocol { get; set; }

    /// <summary>
    /// Timeout: Connection timeout in seconds. Application Gateway will fail the request if response is not received within
    /// ConnectionTimeout. Acceptable values are from 1 second to 86400 seconds.
    /// </summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    /// <summary>TrustedRootCertificates: Array of references to application gateway trusted root certificates.</summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecBackendSettingsCollectionTrustedRootCertificates>? TrustedRootCertificates { get; set; }
}

/// <summary>StatusCode: Status code of the application gateway customer error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecCustomErrorConfigurationsStatusCodeEnum>))]
public enum V1api20220701ApplicationGatewaySpecCustomErrorConfigurationsStatusCodeEnum
{
    [EnumMember(Value = "HttpStatus403"), JsonStringEnumMemberName("HttpStatus403")]
    HttpStatus403,
    [EnumMember(Value = "HttpStatus502"), JsonStringEnumMemberName("HttpStatus502")]
    HttpStatus502
}

/// <summary>Customer error of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecCustomErrorConfigurations
{
    /// <summary>CustomErrorPageUrl: Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>StatusCode: Status code of the application gateway customer error.</summary>
    [JsonPropertyName("statusCode")]
    public V1api20220701ApplicationGatewaySpecCustomErrorConfigurationsStatusCodeEnum? StatusCode { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFirewallPolicyReference
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

/// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFirewallPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecFirewallPolicyReference? Reference { get; set; }
}

/// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum>))]
public enum V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfigurationReference
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

/// <summary>PrivateLinkConfiguration: Reference to the application gateway private link configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddressReference
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

/// <summary>PublicIPAddress: Reference to the PublicIP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsSubnetReference
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

/// <summary>Subnet: Reference to the subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Frontend IP configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendIPConfigurations
{
    /// <summary>Name: Name of the frontend IP configuration that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAddress: PrivateIPAddress of the network interface IP Configuration.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum? PrivateIPAllocationMethod { get; set; }

    /// <summary>PrivateLinkConfiguration: Reference to the application gateway private link configuration.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPrivateLinkConfiguration? PrivateLinkConfiguration { get; set; }

    /// <summary>PublicIPAddress: Reference to the PublicIP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: Reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220701ApplicationGatewaySpecFrontendIPConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Frontend port of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecFrontendPorts
{
    /// <summary>Name: Name of the frontend port that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Port: Frontend port.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecGatewayIPConfigurationsSubnetReference
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

/// <summary>Subnet: Reference to the subnet resource. A subnet from where application gateway gets its private address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecGatewayIPConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecGatewayIPConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecGatewayIPConfigurations
{
    /// <summary>Name: Name of the IP configuration that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Subnet: Reference to the subnet resource. A subnet from where application gateway gets its private address.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220701ApplicationGatewaySpecGatewayIPConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>GlobalConfiguration: Global Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecGlobalConfiguration
{
    /// <summary>EnableRequestBuffering: Enable request buffering.</summary>
    [JsonPropertyName("enableRequestBuffering")]
    public bool? EnableRequestBuffering { get; set; }

    /// <summary>EnableResponseBuffering: Enable response buffering.</summary>
    [JsonPropertyName("enableResponseBuffering")]
    public bool? EnableResponseBuffering { get; set; }
}

/// <summary>StatusCode: Status code of the application gateway customer error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecHttpListenersCustomErrorConfigurationsStatusCodeEnum>))]
public enum V1api20220701ApplicationGatewaySpecHttpListenersCustomErrorConfigurationsStatusCodeEnum
{
    [EnumMember(Value = "HttpStatus403"), JsonStringEnumMemberName("HttpStatus403")]
    HttpStatus403,
    [EnumMember(Value = "HttpStatus502"), JsonStringEnumMemberName("HttpStatus502")]
    HttpStatus502
}

/// <summary>Customer error of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersCustomErrorConfigurations
{
    /// <summary>CustomErrorPageUrl: Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>StatusCode: Status code of the application gateway customer error.</summary>
    [JsonPropertyName("statusCode")]
    public V1api20220701ApplicationGatewaySpecHttpListenersCustomErrorConfigurationsStatusCodeEnum? StatusCode { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersFirewallPolicyReference
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

/// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersFirewallPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecHttpListenersFirewallPolicyReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersFrontendIPConfigurationReference
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

/// <summary>FrontendIPConfiguration: Frontend IP configuration resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecHttpListenersFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersFrontendPortReference
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

/// <summary>FrontendPort: Frontend port resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersFrontendPort
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecHttpListenersFrontendPortReference? Reference { get; set; }
}

/// <summary>Protocol: Protocol of the HTTP listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecHttpListenersProtocolEnum>))]
public enum V1api20220701ApplicationGatewaySpecHttpListenersProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Tls"), JsonStringEnumMemberName("Tls")]
    Tls
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersSslCertificateReference
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

/// <summary>SslCertificate: SSL certificate resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersSslCertificate
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecHttpListenersSslCertificateReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersSslProfileReference
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

/// <summary>SslProfile: SSL profile resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListenersSslProfile
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecHttpListenersSslProfileReference? Reference { get; set; }
}

/// <summary>Http listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecHttpListeners
{
    /// <summary>CustomErrorConfigurations: Custom error configurations of the HTTP listener.</summary>
    [JsonPropertyName("customErrorConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecHttpListenersCustomErrorConfigurations>? CustomErrorConfigurations { get; set; }

    /// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701ApplicationGatewaySpecHttpListenersFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>FrontendIPConfiguration: Frontend IP configuration resource of an application gateway.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20220701ApplicationGatewaySpecHttpListenersFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>FrontendPort: Frontend port resource of an application gateway.</summary>
    [JsonPropertyName("frontendPort")]
    public V1api20220701ApplicationGatewaySpecHttpListenersFrontendPort? FrontendPort { get; set; }

    /// <summary>HostName: Host name of HTTP listener.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HostNames: List of Host names for HTTP Listener that allows special wildcard characters as well.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>Name: Name of the HTTP listener that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: Protocol of the HTTP listener.</summary>
    [JsonPropertyName("protocol")]
    public V1api20220701ApplicationGatewaySpecHttpListenersProtocolEnum? Protocol { get; set; }

    /// <summary>RequireServerNameIndication: Applicable only if protocol is https. Enables SNI for multi-hosting.</summary>
    [JsonPropertyName("requireServerNameIndication")]
    public bool? RequireServerNameIndication { get; set; }

    /// <summary>SslCertificate: SSL certificate resource of an application gateway.</summary>
    [JsonPropertyName("sslCertificate")]
    public V1api20220701ApplicationGatewaySpecHttpListenersSslCertificate? SslCertificate { get; set; }

    /// <summary>SslProfile: SSL profile resource of the application gateway.</summary>
    [JsonPropertyName("sslProfile")]
    public V1api20220701ApplicationGatewaySpecHttpListenersSslProfile? SslProfile { get; set; }
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
/// machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecIdentityTypeEnum>))]
public enum V1api20220701ApplicationGatewaySpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the application gateway, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20220701ApplicationGatewaySpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220701ApplicationGatewaySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersFrontendIPConfigurationReference
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

/// <summary>FrontendIPConfiguration: Frontend IP configuration resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecListenersFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersFrontendPortReference
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

/// <summary>FrontendPort: Frontend port resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersFrontendPort
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecListenersFrontendPortReference? Reference { get; set; }
}

/// <summary>Protocol: Protocol of the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecListenersProtocolEnum>))]
public enum V1api20220701ApplicationGatewaySpecListenersProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Tls"), JsonStringEnumMemberName("Tls")]
    Tls
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersSslCertificateReference
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

/// <summary>SslCertificate: SSL certificate resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersSslCertificate
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecListenersSslCertificateReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersSslProfileReference
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

/// <summary>SslProfile: SSL profile resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListenersSslProfile
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecListenersSslProfileReference? Reference { get; set; }
}

/// <summary>Listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecListeners
{
    /// <summary>FrontendIPConfiguration: Frontend IP configuration resource of an application gateway.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20220701ApplicationGatewaySpecListenersFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>FrontendPort: Frontend port resource of an application gateway.</summary>
    [JsonPropertyName("frontendPort")]
    public V1api20220701ApplicationGatewaySpecListenersFrontendPort? FrontendPort { get; set; }

    /// <summary>Name: Name of the listener that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: Protocol of the listener.</summary>
    [JsonPropertyName("protocol")]
    public V1api20220701ApplicationGatewaySpecListenersProtocolEnum? Protocol { get; set; }

    /// <summary>SslCertificate: SSL certificate resource of an application gateway.</summary>
    [JsonPropertyName("sslCertificate")]
    public V1api20220701ApplicationGatewaySpecListenersSslCertificate? SslCertificate { get; set; }

    /// <summary>SslProfile: SSL profile resource of the application gateway.</summary>
    [JsonPropertyName("sslProfile")]
    public V1api20220701ApplicationGatewaySpecListenersSslProfile? SslProfile { get; set; }
}

/// <summary>LoadDistributionAlgorithm: Load Distribution Targets resource of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionAlgorithmEnum>))]
public enum V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionAlgorithmEnum
{
    [EnumMember(Value = "IpHash"), JsonStringEnumMemberName("IpHash")]
    IpHash,
    [EnumMember(Value = "LeastConnections"), JsonStringEnumMemberName("LeastConnections")]
    LeastConnections,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargetsReference
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

/// <summary>Load Distribution Target of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargets
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargetsReference? Reference { get; set; }
}

/// <summary>Load Distribution Policy of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecLoadDistributionPolicies
{
    /// <summary>LoadDistributionAlgorithm: Load Distribution Targets resource of an application gateway.</summary>
    [JsonPropertyName("loadDistributionAlgorithm")]
    public V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionAlgorithmEnum? LoadDistributionAlgorithm { get; set; }

    /// <summary>LoadDistributionTargets: Load Distribution Targets resource of an application gateway.</summary>
    [JsonPropertyName("loadDistributionTargets")]
    public IList<V1api20220701ApplicationGatewaySpecLoadDistributionPoliciesLoadDistributionTargets>? LoadDistributionTargets { get; set; }

    /// <summary>Name: Name of the load distribution policy that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220701ApplicationGatewaySpecOperatorSpecSecretExpressions
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
public partial class V1api20220701ApplicationGatewaySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220701ApplicationGatewaySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220701ApplicationGatewaySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurationsReference
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

/// <summary>The application gateway private link ip configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurationsReference? Reference { get; set; }
}

/// <summary>Private Link Configuration on an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecPrivateLinkConfigurations
{
    /// <summary>IpConfigurations: An array of application gateway private link ip configurations.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecPrivateLinkConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Name: Name of the private link configuration that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Match: Criterion for classifying a healthy probe response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecProbesMatch
{
    /// <summary>Body: Body that must be contained in the health response. Default value is empty.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>StatusCodes: Allowed ranges of healthy status codes. Default range of healthy status codes is 200-399.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<string>? StatusCodes { get; set; }
}

/// <summary>Protocol: The protocol used for the probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecProbesProtocolEnum>))]
public enum V1api20220701ApplicationGatewaySpecProbesProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Tls"), JsonStringEnumMemberName("Tls")]
    Tls
}

/// <summary>Probe of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecProbes
{
    /// <summary>Host: Host name to send the probe to.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Interval: The probing interval in seconds. This is the time interval between two consecutive probes. Acceptable values
    /// are from 1 second to 86400 seconds.
    /// </summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; set; }

    /// <summary>Match: Criterion for classifying a healthy probe response.</summary>
    [JsonPropertyName("match")]
    public V1api20220701ApplicationGatewaySpecProbesMatch? Match { get; set; }

    /// <summary>MinServers: Minimum number of servers that are always marked healthy. Default value is 0.</summary>
    [JsonPropertyName("minServers")]
    public int? MinServers { get; set; }

    /// <summary>Name: Name of the probe that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path: Relative path of probe. Valid path starts from &apos;/&apos;. Probe is sent to &lt;Protocol&gt;://&lt;host&gt;:&lt;port&gt; &lt;path&gt;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// PickHostNameFromBackendHttpSettings: Whether the host header should be picked from the backend http settings. Default
    /// value is false.
    /// </summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>
    /// PickHostNameFromBackendSettings: Whether the server name indication should be picked from the backend settings for Tls
    /// protocol. Default value is false.
    /// </summary>
    [JsonPropertyName("pickHostNameFromBackendSettings")]
    public bool? PickHostNameFromBackendSettings { get; set; }

    /// <summary>
    /// Port: Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case
    /// not set, port from http settings will be used. This property is valid for Standard_v2 and WAF_v2 only.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Protocol: The protocol used for the probe.</summary>
    [JsonPropertyName("protocol")]
    public V1api20220701ApplicationGatewaySpecProbesProtocolEnum? Protocol { get; set; }

    /// <summary>
    /// Timeout: The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout
    /// period. Acceptable values are from 1 second to 86400 seconds.
    /// </summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// UnhealthyThreshold: The probe retry count. Backend server is marked down after consecutive probe failure count reaches
    /// UnhealthyThreshold. Acceptable values are from 1 second to 20.
    /// </summary>
    [JsonPropertyName("unhealthyThreshold")]
    public int? UnhealthyThreshold { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsPathRulesReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsPathRules
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRedirectConfigurationsPathRulesReference? Reference { get; set; }
}

/// <summary>RedirectType: HTTP redirection type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecRedirectConfigurationsRedirectTypeEnum>))]
public enum V1api20220701ApplicationGatewaySpecRedirectConfigurationsRedirectTypeEnum
{
    [EnumMember(Value = "Found"), JsonStringEnumMemberName("Found")]
    Found,
    [EnumMember(Value = "Permanent"), JsonStringEnumMemberName("Permanent")]
    Permanent,
    [EnumMember(Value = "SeeOther"), JsonStringEnumMemberName("SeeOther")]
    SeeOther,
    [EnumMember(Value = "Temporary"), JsonStringEnumMemberName("Temporary")]
    Temporary
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsRequestRoutingRulesReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsRequestRoutingRules
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRedirectConfigurationsRequestRoutingRulesReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsTargetListenerReference
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

/// <summary>TargetListener: Reference to a listener to redirect the request to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsTargetListener
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRedirectConfigurationsTargetListenerReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsUrlPathMapsReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurationsUrlPathMaps
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRedirectConfigurationsUrlPathMapsReference? Reference { get; set; }
}

/// <summary>Redirect configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRedirectConfigurations
{
    /// <summary>IncludePath: Include path in the redirected url.</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>IncludeQueryString: Include query string in the redirected url.</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Name: Name of the redirect configuration that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PathRules: Path rules specifying redirect configuration.</summary>
    [JsonPropertyName("pathRules")]
    public IList<V1api20220701ApplicationGatewaySpecRedirectConfigurationsPathRules>? PathRules { get; set; }

    /// <summary>RedirectType: HTTP redirection type.</summary>
    [JsonPropertyName("redirectType")]
    public V1api20220701ApplicationGatewaySpecRedirectConfigurationsRedirectTypeEnum? RedirectType { get; set; }

    /// <summary>RequestRoutingRules: Request routing specifying redirect configuration.</summary>
    [JsonPropertyName("requestRoutingRules")]
    public IList<V1api20220701ApplicationGatewaySpecRedirectConfigurationsRequestRoutingRules>? RequestRoutingRules { get; set; }

    /// <summary>TargetListener: Reference to a listener to redirect the request to.</summary>
    [JsonPropertyName("targetListener")]
    public V1api20220701ApplicationGatewaySpecRedirectConfigurationsTargetListener? TargetListener { get; set; }

    /// <summary>TargetUrl: Url to redirect the request to.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }

    /// <summary>UrlPathMaps: Url path maps specifying default redirect configuration.</summary>
    [JsonPropertyName("urlPathMaps")]
    public IList<V1api20220701ApplicationGatewaySpecRedirectConfigurationsUrlPathMaps>? UrlPathMaps { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendAddressPoolReference
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

/// <summary>BackendAddressPool: Backend address pool resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendHttpSettingsReference
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

/// <summary>BackendHttpSettings: Backend http settings resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendHttpSettings
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendHttpSettingsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesHttpListenerReference
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

/// <summary>HttpListener: Http listener resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesHttpListener
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesHttpListenerReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicyReference
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

/// <summary>LoadDistributionPolicy: Load Distribution Policy resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicyReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesRedirectConfigurationReference
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

/// <summary>RedirectConfiguration: Redirect configuration resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesRedirectConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesRedirectConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesRewriteRuleSetReference
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

/// <summary>RewriteRuleSet: Rewrite Rule Set resource in Basic rule of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesRewriteRuleSet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesRewriteRuleSetReference? Reference { get; set; }
}

/// <summary>RuleType: Rule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecRequestRoutingRulesRuleTypeEnum>))]
public enum V1api20220701ApplicationGatewaySpecRequestRoutingRulesRuleTypeEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "PathBasedRouting"), JsonStringEnumMemberName("PathBasedRouting")]
    PathBasedRouting
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesUrlPathMapReference
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

/// <summary>UrlPathMap: URL path map resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRulesUrlPathMap
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesUrlPathMapReference? Reference { get; set; }
}

/// <summary>Request routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRequestRoutingRules
{
    /// <summary>BackendAddressPool: Backend address pool resource of the application gateway.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>BackendHttpSettings: Backend http settings resource of the application gateway.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesBackendHttpSettings? BackendHttpSettings { get; set; }

    /// <summary>HttpListener: Http listener resource of the application gateway.</summary>
    [JsonPropertyName("httpListener")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesHttpListener? HttpListener { get; set; }

    /// <summary>LoadDistributionPolicy: Load Distribution Policy resource of the application gateway.</summary>
    [JsonPropertyName("loadDistributionPolicy")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesLoadDistributionPolicy? LoadDistributionPolicy { get; set; }

    /// <summary>Name: Name of the request routing rule that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the request routing rule.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RedirectConfiguration: Redirect configuration resource of the application gateway.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesRedirectConfiguration? RedirectConfiguration { get; set; }

    /// <summary>RewriteRuleSet: Rewrite Rule Set resource in Basic rule of the application gateway.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesRewriteRuleSet? RewriteRuleSet { get; set; }

    /// <summary>RuleType: Rule type.</summary>
    [JsonPropertyName("ruleType")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesRuleTypeEnum? RuleType { get; set; }

    /// <summary>UrlPathMap: URL path map resource of the application gateway.</summary>
    [JsonPropertyName("urlPathMap")]
    public V1api20220701ApplicationGatewaySpecRequestRoutingRulesUrlPathMap? UrlPathMap { get; set; }
}

/// <summary>Header configuration of the Actions set in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetRequestHeaderConfigurations
{
    /// <summary>HeaderName: Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>HeaderValue: Header value of the header configuration.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>Header configuration of the Actions set in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetResponseHeaderConfigurations
{
    /// <summary>HeaderName: Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>HeaderValue: Header value of the header configuration.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>UrlConfiguration: Url Configuration Action in the Action Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetUrlConfiguration
{
    /// <summary>
    /// ModifiedPath: Url path which user has provided for url rewrite. Null means no path will be updated. Default value is
    /// null.
    /// </summary>
    [JsonPropertyName("modifiedPath")]
    public string? ModifiedPath { get; set; }

    /// <summary>
    /// ModifiedQueryString: Query string which user has provided for url rewrite. Null means no query string will be updated.
    /// Default value is null.
    /// </summary>
    [JsonPropertyName("modifiedQueryString")]
    public string? ModifiedQueryString { get; set; }

    /// <summary>
    /// Reroute: If set as true, it will re-evaluate the url path map provided in path based request routing rules using
    /// modified path. Default value is false.
    /// </summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

/// <summary>ActionSet: Set of actions to be done as part of the rewrite Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSet
{
    /// <summary>RequestHeaderConfigurations: Request Header Actions in the Action Set.</summary>
    [JsonPropertyName("requestHeaderConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetRequestHeaderConfigurations>? RequestHeaderConfigurations { get; set; }

    /// <summary>ResponseHeaderConfigurations: Response Header Actions in the Action Set.</summary>
    [JsonPropertyName("responseHeaderConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetResponseHeaderConfigurations>? ResponseHeaderConfigurations { get; set; }

    /// <summary>UrlConfiguration: Url Configuration Action in the Action Set.</summary>
    [JsonPropertyName("urlConfiguration")]
    public V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSetUrlConfiguration? UrlConfiguration { get; set; }
}

/// <summary>Set of conditions in the Rewrite Rule in Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesConditions
{
    /// <summary>IgnoreCase: Setting this parameter to truth value with force the pattern to do a case in-sensitive comparison.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate: Setting this value as truth will force to check the negation of the condition given by the user.</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>Pattern: The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>Variable: The condition parameter of the RewriteRuleCondition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

/// <summary>Rewrite rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRules
{
    /// <summary>ActionSet: Set of actions to be done as part of the rewrite Rule.</summary>
    [JsonPropertyName("actionSet")]
    public V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesActionSet? ActionSet { get; set; }

    /// <summary>Conditions: Conditions based on which the action set execution will be evaluated.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRulesConditions>? Conditions { get; set; }

    /// <summary>Name: Name of the rewrite rule that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// RuleSequence: Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a
    /// RewriteRuleSet.
    /// </summary>
    [JsonPropertyName("ruleSequence")]
    public int? RuleSequence { get; set; }
}

/// <summary>Rewrite rule set of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRewriteRuleSets
{
    /// <summary>Name: Name of the rewrite rule set that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RewriteRules: Rewrite rules in the rewrite rule set.</summary>
    [JsonPropertyName("rewriteRules")]
    public IList<V1api20220701ApplicationGatewaySpecRewriteRuleSetsRewriteRules>? RewriteRules { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRulesBackendAddressPoolReference
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

/// <summary>BackendAddressPool: Backend address pool resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRulesBackendSettingsReference
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

/// <summary>BackendSettings: Backend settings resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRulesBackendSettings
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesBackendSettingsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRulesListenerReference
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

/// <summary>Listener: Listener resource of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRulesListener
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesListenerReference? Reference { get; set; }
}

/// <summary>RuleType: Rule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecRoutingRulesRuleTypeEnum>))]
public enum V1api20220701ApplicationGatewaySpecRoutingRulesRuleTypeEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "PathBasedRouting"), JsonStringEnumMemberName("PathBasedRouting")]
    PathBasedRouting
}

/// <summary>Routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecRoutingRules
{
    /// <summary>BackendAddressPool: Backend address pool resource of the application gateway.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>BackendSettings: Backend settings resource of the application gateway.</summary>
    [JsonPropertyName("backendSettings")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesBackendSettings? BackendSettings { get; set; }

    /// <summary>Listener: Listener resource of the application gateway.</summary>
    [JsonPropertyName("listener")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesListener? Listener { get; set; }

    /// <summary>Name: Name of the routing rule that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the routing rule.</summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; set; }

    /// <summary>RuleType: Rule type.</summary>
    [JsonPropertyName("ruleType")]
    public V1api20220701ApplicationGatewaySpecRoutingRulesRuleTypeEnum? RuleType { get; set; }
}

/// <summary>Name: Name of an application gateway SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSkuNameEnum>))]
public enum V1api20220701ApplicationGatewaySpecSkuNameEnum
{
    [EnumMember(Value = "Standard_Large"), JsonStringEnumMemberName("Standard_Large")]
    StandardLarge,
    [EnumMember(Value = "Standard_Medium"), JsonStringEnumMemberName("Standard_Medium")]
    StandardMedium,
    [EnumMember(Value = "Standard_Small"), JsonStringEnumMemberName("Standard_Small")]
    StandardSmall,
    [EnumMember(Value = "Standard_v2"), JsonStringEnumMemberName("Standard_v2")]
    StandardV2,
    [EnumMember(Value = "WAF_Large"), JsonStringEnumMemberName("WAF_Large")]
    WAFLarge,
    [EnumMember(Value = "WAF_Medium"), JsonStringEnumMemberName("WAF_Medium")]
    WAFMedium,
    [EnumMember(Value = "WAF_v2"), JsonStringEnumMemberName("WAF_v2")]
    WAFV2
}

/// <summary>Tier: Tier of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSkuTierEnum>))]
public enum V1api20220701ApplicationGatewaySpecSkuTierEnum
{
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard,
    [EnumMember(Value = "Standard_v2"), JsonStringEnumMemberName("Standard_v2")]
    StandardV2,
    [EnumMember(Value = "WAF"), JsonStringEnumMemberName("WAF")]
    WAF,
    [EnumMember(Value = "WAF_v2"), JsonStringEnumMemberName("WAF_v2")]
    WAFV2
}

/// <summary>Sku: SKU of the application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSku
{
    /// <summary>Capacity: Capacity (instance count) of an application gateway.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: Name of an application gateway SKU.</summary>
    [JsonPropertyName("name")]
    public V1api20220701ApplicationGatewaySpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Tier of an application gateway.</summary>
    [JsonPropertyName("tier")]
    public V1api20220701ApplicationGatewaySpecSkuTierEnum? Tier { get; set; }
}

/// <summary>Data: Base-64 encoded pfx certificate. Only applicable in PUT Request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Password: Password for the pfx file specified in data. Only applicable in PUT request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslCertificatesPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SSL certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslCertificates
{
    /// <summary>Data: Base-64 encoded pfx certificate. Only applicable in PUT Request.</summary>
    [JsonPropertyName("data")]
    public V1api20220701ApplicationGatewaySpecSslCertificatesData? Data { get; set; }

    /// <summary>KeyVaultSecretId: Secret Id of (base-64 encoded unencrypted pfx) &apos;Secret&apos; or &apos;Certificate&apos; object stored in KeyVault.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>Name: Name of the SSL certificate that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Password: Password for the pfx file specified in data. Only applicable in PUT request.</summary>
    [JsonPropertyName("password")]
    public V1api20220701ApplicationGatewaySpecSslCertificatesPassword? Password { get; set; }
}

/// <summary>Ssl cipher suites enums.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslPolicyCipherSuitesEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslPolicyCipherSuitesEnum
{
    [EnumMember(Value = "TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA")]
    TLSDHEDSSWITH3DESEDECBCSHA,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_128_CBC_SHA")]
    TLSDHEDSSWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_128_CBC_SHA256")]
    TLSDHEDSSWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_256_CBC_SHA")]
    TLSDHEDSSWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_256_CBC_SHA256")]
    TLSDHEDSSWITHAES256CBCSHA256,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_128_CBC_SHA")]
    TLSDHERSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_128_GCM_SHA256")]
    TLSDHERSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_256_CBC_SHA")]
    TLSDHERSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_256_GCM_SHA384")]
    TLSDHERSAWITHAES256GCMSHA384,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA")]
    TLSECDHEECDSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256")]
    TLSECDHEECDSAWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256")]
    TLSECDHEECDSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA")]
    TLSECDHEECDSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384")]
    TLSECDHEECDSAWITHAES256CBCSHA384,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384")]
    TLSECDHEECDSAWITHAES256GCMSHA384,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA")]
    TLSECDHERSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256")]
    TLSECDHERSAWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256")]
    TLSECDHERSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA")]
    TLSECDHERSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384")]
    TLSECDHERSAWITHAES256CBCSHA384,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384")]
    TLSECDHERSAWITHAES256GCMSHA384,
    [EnumMember(Value = "TLS_RSA_WITH_3DES_EDE_CBC_SHA"), JsonStringEnumMemberName("TLS_RSA_WITH_3DES_EDE_CBC_SHA")]
    TLSRSAWITH3DESEDECBCSHA,
    [EnumMember(Value = "TLS_RSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_128_CBC_SHA")]
    TLSRSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_RSA_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_128_CBC_SHA256")]
    TLSRSAWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_RSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_128_GCM_SHA256")]
    TLSRSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_RSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_256_CBC_SHA")]
    TLSRSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_RSA_WITH_AES_256_CBC_SHA256"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_256_CBC_SHA256")]
    TLSRSAWITHAES256CBCSHA256,
    [EnumMember(Value = "TLS_RSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_256_GCM_SHA384")]
    TLSRSAWITHAES256GCMSHA384
}

/// <summary>Ssl protocol enums.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslPolicyDisabledSslProtocolsEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslPolicyDisabledSslProtocolsEnum
{
    [EnumMember(Value = "TLSv1_0"), JsonStringEnumMemberName("TLSv1_0")]
    TLSv10,
    [EnumMember(Value = "TLSv1_1"), JsonStringEnumMemberName("TLSv1_1")]
    TLSv11,
    [EnumMember(Value = "TLSv1_2"), JsonStringEnumMemberName("TLSv1_2")]
    TLSv12,
    [EnumMember(Value = "TLSv1_3"), JsonStringEnumMemberName("TLSv1_3")]
    TLSv13
}

/// <summary>MinProtocolVersion: Minimum version of Ssl protocol to be supported on application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslPolicyMinProtocolVersionEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslPolicyMinProtocolVersionEnum
{
    [EnumMember(Value = "TLSv1_0"), JsonStringEnumMemberName("TLSv1_0")]
    TLSv10,
    [EnumMember(Value = "TLSv1_1"), JsonStringEnumMemberName("TLSv1_1")]
    TLSv11,
    [EnumMember(Value = "TLSv1_2"), JsonStringEnumMemberName("TLSv1_2")]
    TLSv12,
    [EnumMember(Value = "TLSv1_3"), JsonStringEnumMemberName("TLSv1_3")]
    TLSv13
}

/// <summary>PolicyName: Name of Ssl predefined policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslPolicyPolicyNameEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslPolicyPolicyNameEnum
{
    [EnumMember(Value = "AppGwSslPolicy20150501"), JsonStringEnumMemberName("AppGwSslPolicy20150501")]
    AppGwSslPolicy20150501,
    [EnumMember(Value = "AppGwSslPolicy20170401"), JsonStringEnumMemberName("AppGwSslPolicy20170401")]
    AppGwSslPolicy20170401,
    [EnumMember(Value = "AppGwSslPolicy20170401S"), JsonStringEnumMemberName("AppGwSslPolicy20170401S")]
    AppGwSslPolicy20170401S,
    [EnumMember(Value = "AppGwSslPolicy20220101"), JsonStringEnumMemberName("AppGwSslPolicy20220101")]
    AppGwSslPolicy20220101,
    [EnumMember(Value = "AppGwSslPolicy20220101S"), JsonStringEnumMemberName("AppGwSslPolicy20220101S")]
    AppGwSslPolicy20220101S
}

/// <summary>PolicyType: Type of Ssl Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslPolicyPolicyTypeEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslPolicyPolicyTypeEnum
{
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "CustomV2"), JsonStringEnumMemberName("CustomV2")]
    CustomV2,
    [EnumMember(Value = "Predefined"), JsonStringEnumMemberName("Predefined")]
    Predefined
}

/// <summary>SslPolicy: SSL policy of the application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslPolicy
{
    /// <summary>CipherSuites: Ssl cipher suites to be enabled in the specified order to application gateway.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<V1api20220701ApplicationGatewaySpecSslPolicyCipherSuitesEnum>? CipherSuites { get; set; }

    /// <summary>DisabledSslProtocols: Ssl protocols to be disabled on application gateway.</summary>
    [JsonPropertyName("disabledSslProtocols")]
    public IList<V1api20220701ApplicationGatewaySpecSslPolicyDisabledSslProtocolsEnum>? DisabledSslProtocols { get; set; }

    /// <summary>MinProtocolVersion: Minimum version of Ssl protocol to be supported on application gateway.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public V1api20220701ApplicationGatewaySpecSslPolicyMinProtocolVersionEnum? MinProtocolVersion { get; set; }

    /// <summary>PolicyName: Name of Ssl predefined policy.</summary>
    [JsonPropertyName("policyName")]
    public V1api20220701ApplicationGatewaySpecSslPolicyPolicyNameEnum? PolicyName { get; set; }

    /// <summary>PolicyType: Type of Ssl Policy.</summary>
    [JsonPropertyName("policyType")]
    public V1api20220701ApplicationGatewaySpecSslPolicyPolicyTypeEnum? PolicyType { get; set; }
}

/// <summary>VerifyClientRevocation: Verify client certificate revocation status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslProfilesClientAuthConfigurationVerifyClientRevocationEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslProfilesClientAuthConfigurationVerifyClientRevocationEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "OCSP"), JsonStringEnumMemberName("OCSP")]
    OCSP
}

/// <summary>ClientAuthConfiguration: Client authentication configuration of the application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslProfilesClientAuthConfiguration
{
    /// <summary>VerifyClientCertIssuerDN: Verify client certificate issuer name on the application gateway.</summary>
    [JsonPropertyName("verifyClientCertIssuerDN")]
    public bool? VerifyClientCertIssuerDN { get; set; }

    /// <summary>VerifyClientRevocation: Verify client certificate revocation status.</summary>
    [JsonPropertyName("verifyClientRevocation")]
    public V1api20220701ApplicationGatewaySpecSslProfilesClientAuthConfigurationVerifyClientRevocationEnum? VerifyClientRevocation { get; set; }
}

/// <summary>Ssl cipher suites enums.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyCipherSuitesEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyCipherSuitesEnum
{
    [EnumMember(Value = "TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA")]
    TLSDHEDSSWITH3DESEDECBCSHA,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_128_CBC_SHA")]
    TLSDHEDSSWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_128_CBC_SHA256")]
    TLSDHEDSSWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_256_CBC_SHA")]
    TLSDHEDSSWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_DHE_DSS_WITH_AES_256_CBC_SHA256"), JsonStringEnumMemberName("TLS_DHE_DSS_WITH_AES_256_CBC_SHA256")]
    TLSDHEDSSWITHAES256CBCSHA256,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_128_CBC_SHA")]
    TLSDHERSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_128_GCM_SHA256")]
    TLSDHERSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_256_CBC_SHA")]
    TLSDHERSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_DHE_RSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_DHE_RSA_WITH_AES_256_GCM_SHA384")]
    TLSDHERSAWITHAES256GCMSHA384,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA")]
    TLSECDHEECDSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256")]
    TLSECDHEECDSAWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256")]
    TLSECDHEECDSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA")]
    TLSECDHEECDSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384")]
    TLSECDHEECDSAWITHAES256CBCSHA384,
    [EnumMember(Value = "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384")]
    TLSECDHEECDSAWITHAES256GCMSHA384,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA")]
    TLSECDHERSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256")]
    TLSECDHERSAWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256")]
    TLSECDHERSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA")]
    TLSECDHERSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384")]
    TLSECDHERSAWITHAES256CBCSHA384,
    [EnumMember(Value = "TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384")]
    TLSECDHERSAWITHAES256GCMSHA384,
    [EnumMember(Value = "TLS_RSA_WITH_3DES_EDE_CBC_SHA"), JsonStringEnumMemberName("TLS_RSA_WITH_3DES_EDE_CBC_SHA")]
    TLSRSAWITH3DESEDECBCSHA,
    [EnumMember(Value = "TLS_RSA_WITH_AES_128_CBC_SHA"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_128_CBC_SHA")]
    TLSRSAWITHAES128CBCSHA,
    [EnumMember(Value = "TLS_RSA_WITH_AES_128_CBC_SHA256"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_128_CBC_SHA256")]
    TLSRSAWITHAES128CBCSHA256,
    [EnumMember(Value = "TLS_RSA_WITH_AES_128_GCM_SHA256"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_128_GCM_SHA256")]
    TLSRSAWITHAES128GCMSHA256,
    [EnumMember(Value = "TLS_RSA_WITH_AES_256_CBC_SHA"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_256_CBC_SHA")]
    TLSRSAWITHAES256CBCSHA,
    [EnumMember(Value = "TLS_RSA_WITH_AES_256_CBC_SHA256"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_256_CBC_SHA256")]
    TLSRSAWITHAES256CBCSHA256,
    [EnumMember(Value = "TLS_RSA_WITH_AES_256_GCM_SHA384"), JsonStringEnumMemberName("TLS_RSA_WITH_AES_256_GCM_SHA384")]
    TLSRSAWITHAES256GCMSHA384
}

/// <summary>Ssl protocol enums.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyDisabledSslProtocolsEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyDisabledSslProtocolsEnum
{
    [EnumMember(Value = "TLSv1_0"), JsonStringEnumMemberName("TLSv1_0")]
    TLSv10,
    [EnumMember(Value = "TLSv1_1"), JsonStringEnumMemberName("TLSv1_1")]
    TLSv11,
    [EnumMember(Value = "TLSv1_2"), JsonStringEnumMemberName("TLSv1_2")]
    TLSv12,
    [EnumMember(Value = "TLSv1_3"), JsonStringEnumMemberName("TLSv1_3")]
    TLSv13
}

/// <summary>MinProtocolVersion: Minimum version of Ssl protocol to be supported on application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyMinProtocolVersionEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyMinProtocolVersionEnum
{
    [EnumMember(Value = "TLSv1_0"), JsonStringEnumMemberName("TLSv1_0")]
    TLSv10,
    [EnumMember(Value = "TLSv1_1"), JsonStringEnumMemberName("TLSv1_1")]
    TLSv11,
    [EnumMember(Value = "TLSv1_2"), JsonStringEnumMemberName("TLSv1_2")]
    TLSv12,
    [EnumMember(Value = "TLSv1_3"), JsonStringEnumMemberName("TLSv1_3")]
    TLSv13
}

/// <summary>PolicyName: Name of Ssl predefined policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyPolicyNameEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyPolicyNameEnum
{
    [EnumMember(Value = "AppGwSslPolicy20150501"), JsonStringEnumMemberName("AppGwSslPolicy20150501")]
    AppGwSslPolicy20150501,
    [EnumMember(Value = "AppGwSslPolicy20170401"), JsonStringEnumMemberName("AppGwSslPolicy20170401")]
    AppGwSslPolicy20170401,
    [EnumMember(Value = "AppGwSslPolicy20170401S"), JsonStringEnumMemberName("AppGwSslPolicy20170401S")]
    AppGwSslPolicy20170401S,
    [EnumMember(Value = "AppGwSslPolicy20220101"), JsonStringEnumMemberName("AppGwSslPolicy20220101")]
    AppGwSslPolicy20220101,
    [EnumMember(Value = "AppGwSslPolicy20220101S"), JsonStringEnumMemberName("AppGwSslPolicy20220101S")]
    AppGwSslPolicy20220101S
}

/// <summary>PolicyType: Type of Ssl Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyPolicyTypeEnum>))]
public enum V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyPolicyTypeEnum
{
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "CustomV2"), JsonStringEnumMemberName("CustomV2")]
    CustomV2,
    [EnumMember(Value = "Predefined"), JsonStringEnumMemberName("Predefined")]
    Predefined
}

/// <summary>SslPolicy: SSL policy of the application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslProfilesSslPolicy
{
    /// <summary>CipherSuites: Ssl cipher suites to be enabled in the specified order to application gateway.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyCipherSuitesEnum>? CipherSuites { get; set; }

    /// <summary>DisabledSslProtocols: Ssl protocols to be disabled on application gateway.</summary>
    [JsonPropertyName("disabledSslProtocols")]
    public IList<V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyDisabledSslProtocolsEnum>? DisabledSslProtocols { get; set; }

    /// <summary>MinProtocolVersion: Minimum version of Ssl protocol to be supported on application gateway.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyMinProtocolVersionEnum? MinProtocolVersion { get; set; }

    /// <summary>PolicyName: Name of Ssl predefined policy.</summary>
    [JsonPropertyName("policyName")]
    public V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyPolicyNameEnum? PolicyName { get; set; }

    /// <summary>PolicyType: Type of Ssl Policy.</summary>
    [JsonPropertyName("policyType")]
    public V1api20220701ApplicationGatewaySpecSslProfilesSslPolicyPolicyTypeEnum? PolicyType { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslProfilesTrustedClientCertificatesReference
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

/// <summary>Reference to another ARM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslProfilesTrustedClientCertificates
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecSslProfilesTrustedClientCertificatesReference? Reference { get; set; }
}

/// <summary>SSL profile of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecSslProfiles
{
    /// <summary>ClientAuthConfiguration: Client authentication configuration of the application gateway resource.</summary>
    [JsonPropertyName("clientAuthConfiguration")]
    public V1api20220701ApplicationGatewaySpecSslProfilesClientAuthConfiguration? ClientAuthConfiguration { get; set; }

    /// <summary>Name: Name of the SSL profile that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SslPolicy: SSL policy of the application gateway resource.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1api20220701ApplicationGatewaySpecSslProfilesSslPolicy? SslPolicy { get; set; }

    /// <summary>TrustedClientCertificates: Array of references to application gateway trusted client certificates.</summary>
    [JsonPropertyName("trustedClientCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecSslProfilesTrustedClientCertificates>? TrustedClientCertificates { get; set; }
}

/// <summary>Data: Certificate public data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecTrustedClientCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Trusted client certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecTrustedClientCertificates
{
    /// <summary>Data: Certificate public data.</summary>
    [JsonPropertyName("data")]
    public V1api20220701ApplicationGatewaySpecTrustedClientCertificatesData? Data { get; set; }

    /// <summary>Name: Name of the trusted client certificate that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Data: Certificate public data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecTrustedRootCertificatesData
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Trusted Root certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecTrustedRootCertificates
{
    /// <summary>Data: Certificate public data.</summary>
    [JsonPropertyName("data")]
    public V1api20220701ApplicationGatewaySpecTrustedRootCertificatesData? Data { get; set; }

    /// <summary>KeyVaultSecretId: Secret Id of (base-64 encoded unencrypted pfx) &apos;Secret&apos; or &apos;Certificate&apos; object stored in KeyVault.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>Name: Name of the trusted root certificate that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPoolReference
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

/// <summary>DefaultBackendAddressPool: Default backend address pool resource of URL path map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettingsReference
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

/// <summary>DefaultBackendHttpSettings: Default backend http settings resource of URL path map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettings
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettingsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicyReference
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

/// <summary>DefaultLoadDistributionPolicy: Default Load Distribution Policy resource of URL path map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicyReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRedirectConfigurationReference
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

/// <summary>DefaultRedirectConfiguration: Default redirect configuration resource of URL path map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRedirectConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRedirectConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSetReference
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

/// <summary>DefaultRewriteRuleSet: Default Rewrite rule set resource of URL path map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPoolReference
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

/// <summary>BackendAddressPool: Backend address pool resource of URL path map path rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettingsReference
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

/// <summary>BackendHttpSettings: Backend http settings resource of URL path map path rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettings
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettingsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicyReference
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

/// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicyReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicyReference
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

/// <summary>LoadDistributionPolicy: Load Distribution Policy resource of URL path map path rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicyReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfigurationReference
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

/// <summary>RedirectConfiguration: Redirect configuration resource of URL path map path rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSetReference
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

/// <summary>RewriteRuleSet: Rewrite rule set resource of URL path map path rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSetReference? Reference { get; set; }
}

/// <summary>Path rule of URL path map of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMapsPathRules
{
    /// <summary>BackendAddressPool: Backend address pool resource of URL path map path rule.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>BackendHttpSettings: Backend http settings resource of URL path map path rule.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesBackendHttpSettings? BackendHttpSettings { get; set; }

    /// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>LoadDistributionPolicy: Load Distribution Policy resource of URL path map path rule.</summary>
    [JsonPropertyName("loadDistributionPolicy")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesLoadDistributionPolicy? LoadDistributionPolicy { get; set; }

    /// <summary>Name: Name of the path rule that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Paths: Path rules of URL path map.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>RedirectConfiguration: Redirect configuration resource of URL path map path rule.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRedirectConfiguration? RedirectConfiguration { get; set; }

    /// <summary>RewriteRuleSet: Rewrite rule set resource of URL path map path rule.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsPathRulesRewriteRuleSet? RewriteRuleSet { get; set; }
}

/// <summary>UrlPathMaps give a url path to the backend mapping information for PathBasedRouting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecUrlPathMaps
{
    /// <summary>DefaultBackendAddressPool: Default backend address pool resource of URL path map.</summary>
    [JsonPropertyName("defaultBackendAddressPool")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendAddressPool? DefaultBackendAddressPool { get; set; }

    /// <summary>DefaultBackendHttpSettings: Default backend http settings resource of URL path map.</summary>
    [JsonPropertyName("defaultBackendHttpSettings")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultBackendHttpSettings? DefaultBackendHttpSettings { get; set; }

    /// <summary>DefaultLoadDistributionPolicy: Default Load Distribution Policy resource of URL path map.</summary>
    [JsonPropertyName("defaultLoadDistributionPolicy")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultLoadDistributionPolicy? DefaultLoadDistributionPolicy { get; set; }

    /// <summary>DefaultRedirectConfiguration: Default redirect configuration resource of URL path map.</summary>
    [JsonPropertyName("defaultRedirectConfiguration")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRedirectConfiguration? DefaultRedirectConfiguration { get; set; }

    /// <summary>DefaultRewriteRuleSet: Default Rewrite rule set resource of URL path map.</summary>
    [JsonPropertyName("defaultRewriteRuleSet")]
    public V1api20220701ApplicationGatewaySpecUrlPathMapsDefaultRewriteRuleSet? DefaultRewriteRuleSet { get; set; }

    /// <summary>Name: Name of the URL path map that is unique within an Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PathRules: Path rule of URL path map resource.</summary>
    [JsonPropertyName("pathRules")]
    public IList<V1api20220701ApplicationGatewaySpecUrlPathMapsPathRules>? PathRules { get; set; }
}

/// <summary>Allows to disable rules within a rule group or an entire rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationDisabledRuleGroups
{
    /// <summary>RuleGroupName: The name of the rule group that will be disabled.</summary>
    [JsonPropertyName("ruleGroupName")]
    public required string RuleGroupName { get; set; }

    /// <summary>Rules: The list of rules that will be disabled. If null, all rules of the rule group will be disabled.</summary>
    [JsonPropertyName("rules")]
    public IList<int>? Rules { get; set; }
}

/// <summary>Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationExclusions
{
    /// <summary>MatchVariable: The variable to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public required string MatchVariable { get; set; }

    /// <summary>
    /// Selector: When matchVariable is a collection, operator used to specify which elements in the collection this exclusion
    /// applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public required string Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
    /// collection this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public required string SelectorMatchOperator { get; set; }
}

/// <summary>FirewallMode: Web application firewall mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationFirewallModeEnum>))]
public enum V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationFirewallModeEnum
{
    [EnumMember(Value = "Detection"), JsonStringEnumMemberName("Detection")]
    Detection,
    [EnumMember(Value = "Prevention"), JsonStringEnumMemberName("Prevention")]
    Prevention
}

/// <summary>WebApplicationFirewallConfiguration: Web application firewall configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfiguration
{
    /// <summary>DisabledRuleGroups: The disabled rule groups.</summary>
    [JsonPropertyName("disabledRuleGroups")]
    public IList<V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationDisabledRuleGroups>? DisabledRuleGroups { get; set; }

    /// <summary>Enabled: Whether the web application firewall is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>Exclusions: The exclusion list.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationExclusions>? Exclusions { get; set; }

    /// <summary>FileUploadLimitInMb: Maximum file upload size in Mb for WAF.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary>FirewallMode: Web application firewall mode.</summary>
    [JsonPropertyName("firewallMode")]
    public required V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfigurationFirewallModeEnum FirewallMode { get; set; }

    /// <summary>MaxRequestBodySize: Maximum request body size for WAF.</summary>
    [JsonPropertyName("maxRequestBodySize")]
    public int? MaxRequestBodySize { get; set; }

    /// <summary>MaxRequestBodySizeInKb: Maximum request body size in Kb for WAF.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary>RequestBodyCheck: Whether allow WAF to check request Body.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>RuleSetType: The type of the web application firewall rule set. Possible values are: &apos;OWASP&apos;.</summary>
    [JsonPropertyName("ruleSetType")]
    public required string RuleSetType { get; set; }

    /// <summary>RuleSetVersion: The version of the rule set type.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public required string RuleSetVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewaySpec
{
    /// <summary>
    /// AuthenticationCertificates: Authentication certificates of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("authenticationCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecAuthenticationCertificates>? AuthenticationCertificates { get; set; }

    /// <summary>AutoscaleConfiguration: Autoscale Configuration.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1api20220701ApplicationGatewaySpecAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// BackendAddressPools: Backend address pool of the application gateway resource. For default limits, see [Application
    /// Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20220701ApplicationGatewaySpecBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>
    /// BackendHttpSettingsCollection: Backend http settings of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("backendHttpSettingsCollection")]
    public IList<V1api20220701ApplicationGatewaySpecBackendHttpSettingsCollection>? BackendHttpSettingsCollection { get; set; }

    /// <summary>
    /// BackendSettingsCollection: Backend settings of the application gateway resource. For default limits, see [Application
    /// Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("backendSettingsCollection")]
    public IList<V1api20220701ApplicationGatewaySpecBackendSettingsCollection>? BackendSettingsCollection { get; set; }

    /// <summary>CustomErrorConfigurations: Custom error configurations of the application gateway resource.</summary>
    [JsonPropertyName("customErrorConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecCustomErrorConfigurations>? CustomErrorConfigurations { get; set; }

    /// <summary>EnableFips: Whether FIPS is enabled on the application gateway resource.</summary>
    [JsonPropertyName("enableFips")]
    public bool? EnableFips { get; set; }

    /// <summary>EnableHttp2: Whether HTTP2 is enabled on the application gateway resource.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701ApplicationGatewaySpecFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>
    /// ForceFirewallPolicyAssociation: If true, associates a firewall policy with an application gateway regardless whether the
    /// policy differs from the WAF Config.
    /// </summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>
    /// FrontendIPConfigurations: Frontend IP addresses of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>
    /// FrontendPorts: Frontend ports of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("frontendPorts")]
    public IList<V1api20220701ApplicationGatewaySpecFrontendPorts>? FrontendPorts { get; set; }

    /// <summary>
    /// GatewayIPConfigurations: Subnets of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("gatewayIPConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecGatewayIPConfigurations>? GatewayIPConfigurations { get; set; }

    /// <summary>GlobalConfiguration: Global Configuration.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1api20220701ApplicationGatewaySpecGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary>
    /// HttpListeners: Http listeners of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("httpListeners")]
    public IList<V1api20220701ApplicationGatewaySpecHttpListeners>? HttpListeners { get; set; }

    /// <summary>Identity: The identity of the application gateway, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20220701ApplicationGatewaySpecIdentity? Identity { get; set; }

    /// <summary>
    /// Listeners: Listeners of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220701ApplicationGatewaySpecListeners>? Listeners { get; set; }

    /// <summary>LoadDistributionPolicies: Load distribution policies of the application gateway resource.</summary>
    [JsonPropertyName("loadDistributionPolicies")]
    public IList<V1api20220701ApplicationGatewaySpecLoadDistributionPolicies>? LoadDistributionPolicies { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220701ApplicationGatewaySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220701ApplicationGatewaySpecOwner Owner { get; set; }

    /// <summary>PrivateLinkConfigurations: PrivateLink configurations on application gateway.</summary>
    [JsonPropertyName("privateLinkConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecPrivateLinkConfigurations>? PrivateLinkConfigurations { get; set; }

    /// <summary>Probes: Probes of the application gateway resource.</summary>
    [JsonPropertyName("probes")]
    public IList<V1api20220701ApplicationGatewaySpecProbes>? Probes { get; set; }

    /// <summary>
    /// RedirectConfigurations: Redirect configurations of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("redirectConfigurations")]
    public IList<V1api20220701ApplicationGatewaySpecRedirectConfigurations>? RedirectConfigurations { get; set; }

    /// <summary>RequestRoutingRules: Request routing rules of the application gateway resource.</summary>
    [JsonPropertyName("requestRoutingRules")]
    public IList<V1api20220701ApplicationGatewaySpecRequestRoutingRules>? RequestRoutingRules { get; set; }

    /// <summary>RewriteRuleSets: Rewrite rules for the application gateway resource.</summary>
    [JsonPropertyName("rewriteRuleSets")]
    public IList<V1api20220701ApplicationGatewaySpecRewriteRuleSets>? RewriteRuleSets { get; set; }

    /// <summary>RoutingRules: Routing rules of the application gateway resource.</summary>
    [JsonPropertyName("routingRules")]
    public IList<V1api20220701ApplicationGatewaySpecRoutingRules>? RoutingRules { get; set; }

    /// <summary>Sku: SKU of the application gateway resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20220701ApplicationGatewaySpecSku? Sku { get; set; }

    /// <summary>
    /// SslCertificates: SSL certificates of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("sslCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecSslCertificates>? SslCertificates { get; set; }

    /// <summary>SslPolicy: SSL policy of the application gateway resource.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1api20220701ApplicationGatewaySpecSslPolicy? SslPolicy { get; set; }

    /// <summary>
    /// SslProfiles: SSL profiles of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("sslProfiles")]
    public IList<V1api20220701ApplicationGatewaySpecSslProfiles>? SslProfiles { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TrustedClientCertificates: Trusted client certificates of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("trustedClientCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecTrustedClientCertificates>? TrustedClientCertificates { get; set; }

    /// <summary>
    /// TrustedRootCertificates: Trusted Root certificates of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701ApplicationGatewaySpecTrustedRootCertificates>? TrustedRootCertificates { get; set; }

    /// <summary>
    /// UrlPathMaps: URL path map of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("urlPathMaps")]
    public IList<V1api20220701ApplicationGatewaySpecUrlPathMaps>? UrlPathMaps { get; set; }

    /// <summary>WebApplicationFirewallConfiguration: Web application firewall configuration.</summary>
    [JsonPropertyName("webApplicationFirewallConfiguration")]
    public V1api20220701ApplicationGatewaySpecWebApplicationFirewallConfiguration? WebApplicationFirewallConfiguration { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Authentication certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusAuthenticationCertificates
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>AutoscaleConfiguration: Autoscale Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusAutoscaleConfiguration
{
    /// <summary>MaxCapacity: Upper bound on number of Application Gateway capacity.</summary>
    [JsonPropertyName("maxCapacity")]
    public int? MaxCapacity { get; set; }

    /// <summary>MinCapacity: Lower bound on number of Application Gateway capacity.</summary>
    [JsonPropertyName("minCapacity")]
    public int? MinCapacity { get; set; }
}

/// <summary>Backend Address Pool of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusBackendAddressPools
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusBackendHttpSettingsCollection
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Backend address pool settings of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusBackendSettingsCollection
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusConditions
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

/// <summary>Customer error of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusCustomErrorConfigurations
{
    /// <summary>CustomErrorPageUrl: Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>StatusCode: Status code of the application gateway customer error.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusFirewallPolicy
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Frontend IP configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusFrontendIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Frontend port of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusFrontendPorts
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusGatewayIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>GlobalConfiguration: Global Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusGlobalConfiguration
{
    /// <summary>EnableRequestBuffering: Enable request buffering.</summary>
    [JsonPropertyName("enableRequestBuffering")]
    public bool? EnableRequestBuffering { get; set; }

    /// <summary>EnableResponseBuffering: Enable response buffering.</summary>
    [JsonPropertyName("enableResponseBuffering")]
    public bool? EnableResponseBuffering { get; set; }
}

/// <summary>Http listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusHttpListeners
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the application gateway, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20220701ApplicationGatewayStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Listener of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusListeners
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Load Distribution Policy of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusLoadDistributionPolicies
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Private Endpoint connection on an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusPrivateEndpointConnections
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Private Link Configuration on an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusPrivateLinkConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Probe of the application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusProbes
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Redirect configuration of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusRedirectConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Request routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusRequestRoutingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Rewrite rule set of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusRewriteRuleSets
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Routing rule of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusRoutingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: SKU of the application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusSku
{
    /// <summary>Capacity: Capacity (instance count) of an application gateway.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: Name of an application gateway SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of an application gateway.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SSL certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusSslCertificates
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SslPolicy: SSL policy of the application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusSslPolicy
{
    /// <summary>CipherSuites: Ssl cipher suites to be enabled in the specified order to application gateway.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>DisabledSslProtocols: Ssl protocols to be disabled on application gateway.</summary>
    [JsonPropertyName("disabledSslProtocols")]
    public IList<string>? DisabledSslProtocols { get; set; }

    /// <summary>MinProtocolVersion: Minimum version of Ssl protocol to be supported on application gateway.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>PolicyName: Name of Ssl predefined policy.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>PolicyType: Type of Ssl Policy.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>SSL profile of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusSslProfiles
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Trusted client certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusTrustedClientCertificates
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Trusted Root certificates of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusTrustedRootCertificates
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>UrlPathMaps give a url path to the backend mapping information for PathBasedRouting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusUrlPathMaps
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Allows to disable rules within a rule group or an entire rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusWebApplicationFirewallConfigurationDisabledRuleGroups
{
    /// <summary>RuleGroupName: The name of the rule group that will be disabled.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>Rules: The list of rules that will be disabled. If null, all rules of the rule group will be disabled.</summary>
    [JsonPropertyName("rules")]
    public IList<int>? Rules { get; set; }
}

/// <summary>Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusWebApplicationFirewallConfigurationExclusions
{
    /// <summary>MatchVariable: The variable to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>
    /// Selector: When matchVariable is a collection, operator used to specify which elements in the collection this exclusion
    /// applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
    /// collection this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>WebApplicationFirewallConfiguration: Web application firewall configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatusWebApplicationFirewallConfiguration
{
    /// <summary>DisabledRuleGroups: The disabled rule groups.</summary>
    [JsonPropertyName("disabledRuleGroups")]
    public IList<V1api20220701ApplicationGatewayStatusWebApplicationFirewallConfigurationDisabledRuleGroups>? DisabledRuleGroups { get; set; }

    /// <summary>Enabled: Whether the web application firewall is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Exclusions: The exclusion list.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220701ApplicationGatewayStatusWebApplicationFirewallConfigurationExclusions>? Exclusions { get; set; }

    /// <summary>FileUploadLimitInMb: Maximum file upload size in Mb for WAF.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary>FirewallMode: Web application firewall mode.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>MaxRequestBodySize: Maximum request body size for WAF.</summary>
    [JsonPropertyName("maxRequestBodySize")]
    public int? MaxRequestBodySize { get; set; }

    /// <summary>MaxRequestBodySizeInKb: Maximum request body size in Kb for WAF.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary>RequestBodyCheck: Whether allow WAF to check request Body.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>RuleSetType: The type of the web application firewall rule set. Possible values are: &apos;OWASP&apos;.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>RuleSetVersion: The version of the rule set type.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>Application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220701ApplicationGatewayStatus
{
    /// <summary>
    /// AuthenticationCertificates: Authentication certificates of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("authenticationCertificates")]
    public IList<V1api20220701ApplicationGatewayStatusAuthenticationCertificates>? AuthenticationCertificates { get; set; }

    /// <summary>AutoscaleConfiguration: Autoscale Configuration.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1api20220701ApplicationGatewayStatusAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>
    /// BackendAddressPools: Backend address pool of the application gateway resource. For default limits, see [Application
    /// Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20220701ApplicationGatewayStatusBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>
    /// BackendHttpSettingsCollection: Backend http settings of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("backendHttpSettingsCollection")]
    public IList<V1api20220701ApplicationGatewayStatusBackendHttpSettingsCollection>? BackendHttpSettingsCollection { get; set; }

    /// <summary>
    /// BackendSettingsCollection: Backend settings of the application gateway resource. For default limits, see [Application
    /// Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("backendSettingsCollection")]
    public IList<V1api20220701ApplicationGatewayStatusBackendSettingsCollection>? BackendSettingsCollection { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220701ApplicationGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>CustomErrorConfigurations: Custom error configurations of the application gateway resource.</summary>
    [JsonPropertyName("customErrorConfigurations")]
    public IList<V1api20220701ApplicationGatewayStatusCustomErrorConfigurations>? CustomErrorConfigurations { get; set; }

    /// <summary>EnableFips: Whether FIPS is enabled on the application gateway resource.</summary>
    [JsonPropertyName("enableFips")]
    public bool? EnableFips { get; set; }

    /// <summary>EnableHttp2: Whether HTTP2 is enabled on the application gateway resource.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FirewallPolicy: Reference to the FirewallPolicy resource.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1api20220701ApplicationGatewayStatusFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>
    /// ForceFirewallPolicyAssociation: If true, associates a firewall policy with an application gateway regardless whether the
    /// policy differs from the WAF Config.
    /// </summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>
    /// FrontendIPConfigurations: Frontend IP addresses of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20220701ApplicationGatewayStatusFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>
    /// FrontendPorts: Frontend ports of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("frontendPorts")]
    public IList<V1api20220701ApplicationGatewayStatusFrontendPorts>? FrontendPorts { get; set; }

    /// <summary>
    /// GatewayIPConfigurations: Subnets of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("gatewayIPConfigurations")]
    public IList<V1api20220701ApplicationGatewayStatusGatewayIPConfigurations>? GatewayIPConfigurations { get; set; }

    /// <summary>GlobalConfiguration: Global Configuration.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1api20220701ApplicationGatewayStatusGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary>
    /// HttpListeners: Http listeners of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("httpListeners")]
    public IList<V1api20220701ApplicationGatewayStatusHttpListeners>? HttpListeners { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the application gateway, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20220701ApplicationGatewayStatusIdentity? Identity { get; set; }

    /// <summary>
    /// Listeners: Listeners of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220701ApplicationGatewayStatusListeners>? Listeners { get; set; }

    /// <summary>LoadDistributionPolicies: Load distribution policies of the application gateway resource.</summary>
    [JsonPropertyName("loadDistributionPolicies")]
    public IList<V1api20220701ApplicationGatewayStatusLoadDistributionPolicies>? LoadDistributionPolicies { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OperationalState: Operational state of the application gateway resource.</summary>
    [JsonPropertyName("operationalState")]
    public string? OperationalState { get; set; }

    /// <summary>PrivateEndpointConnections: Private Endpoint connections on application gateway.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20220701ApplicationGatewayStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>PrivateLinkConfigurations: PrivateLink configurations on application gateway.</summary>
    [JsonPropertyName("privateLinkConfigurations")]
    public IList<V1api20220701ApplicationGatewayStatusPrivateLinkConfigurations>? PrivateLinkConfigurations { get; set; }

    /// <summary>Probes: Probes of the application gateway resource.</summary>
    [JsonPropertyName("probes")]
    public IList<V1api20220701ApplicationGatewayStatusProbes>? Probes { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the application gateway resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RedirectConfigurations: Redirect configurations of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("redirectConfigurations")]
    public IList<V1api20220701ApplicationGatewayStatusRedirectConfigurations>? RedirectConfigurations { get; set; }

    /// <summary>RequestRoutingRules: Request routing rules of the application gateway resource.</summary>
    [JsonPropertyName("requestRoutingRules")]
    public IList<V1api20220701ApplicationGatewayStatusRequestRoutingRules>? RequestRoutingRules { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the application gateway resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>RewriteRuleSets: Rewrite rules for the application gateway resource.</summary>
    [JsonPropertyName("rewriteRuleSets")]
    public IList<V1api20220701ApplicationGatewayStatusRewriteRuleSets>? RewriteRuleSets { get; set; }

    /// <summary>RoutingRules: Routing rules of the application gateway resource.</summary>
    [JsonPropertyName("routingRules")]
    public IList<V1api20220701ApplicationGatewayStatusRoutingRules>? RoutingRules { get; set; }

    /// <summary>Sku: SKU of the application gateway resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20220701ApplicationGatewayStatusSku? Sku { get; set; }

    /// <summary>
    /// SslCertificates: SSL certificates of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("sslCertificates")]
    public IList<V1api20220701ApplicationGatewayStatusSslCertificates>? SslCertificates { get; set; }

    /// <summary>SslPolicy: SSL policy of the application gateway resource.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1api20220701ApplicationGatewayStatusSslPolicy? SslPolicy { get; set; }

    /// <summary>
    /// SslProfiles: SSL profiles of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("sslProfiles")]
    public IList<V1api20220701ApplicationGatewayStatusSslProfiles>? SslProfiles { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TrustedClientCertificates: Trusted client certificates of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("trustedClientCertificates")]
    public IList<V1api20220701ApplicationGatewayStatusTrustedClientCertificates>? TrustedClientCertificates { get; set; }

    /// <summary>
    /// TrustedRootCertificates: Trusted Root certificates of the application gateway resource. For default limits, see
    /// [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("trustedRootCertificates")]
    public IList<V1api20220701ApplicationGatewayStatusTrustedRootCertificates>? TrustedRootCertificates { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UrlPathMaps: URL path map of the application gateway resource. For default limits, see [Application Gateway
    /// limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
    /// </summary>
    [JsonPropertyName("urlPathMaps")]
    public IList<V1api20220701ApplicationGatewayStatusUrlPathMaps>? UrlPathMaps { get; set; }

    /// <summary>WebApplicationFirewallConfiguration: Web application firewall configuration.</summary>
    [JsonPropertyName("webApplicationFirewallConfiguration")]
    public V1api20220701ApplicationGatewayStatusWebApplicationFirewallConfiguration? WebApplicationFirewallConfiguration { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2022-07-01/applicationGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220701ApplicationGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220701ApplicationGatewaySpec?>, IStatus<V1api20220701ApplicationGatewayStatus?>
{
    public const string KubeApiVersion = "v1api20220701";
    public const string KubeKind = "ApplicationGateway";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "applicationgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20220701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220701ApplicationGatewaySpec? Spec { get; set; }

    /// <summary>Application gateway resource.</summary>
    [JsonPropertyName("status")]
    public V1api20220701ApplicationGatewayStatus? Status { get; set; }
}