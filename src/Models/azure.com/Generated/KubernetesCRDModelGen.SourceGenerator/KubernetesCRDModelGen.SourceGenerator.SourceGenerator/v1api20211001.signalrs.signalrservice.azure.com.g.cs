#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /signalr/resource-manager/Microsoft.SignalRService/SignalRService/stable/2021-10-01/signalr.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211001SignalRList : IKubernetesObject<V1ListMeta>, IItems<V1api20211001SignalR>
{
    public const string KubeApiVersion = "v1api20211001";
    public const string KubeKind = "SignalRList";
    public const string KubeGroup = "signalrservice.azure.com";
    public const string KubePluralName = "signalrs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "signalrservice.azure.com/v1api20211001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SignalRList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211001SignalR objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211001SignalR> Items { get; set; }
}

/// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecCors
{
    /// <summary>
    /// AllowedOrigins: Gets or sets the list of origins that should be allowed to make cross-origin calls (for example:
    /// http://example.com:12345). Use &quot;*&quot; to allow all. If omitted, allow all by default.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}

/// <summary>
/// Flag: FeatureFlags is the supported features of Azure SignalR service.
/// - ServiceMode: Flag for backend server for SignalR  service. Values allowed: &quot;Default&quot;: have your own backend server;
/// &quot;Serverless&quot;: your application doesn&apos;t have a backend  server; &quot;Classic&quot;: for backward compatibility. Support both
/// Default and Serverless mode but not recommended;  &quot;PredefinedOnly&quot;: for future use.
/// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log  category respectively.
/// - EnableMessagingLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category  respectively.
/// - EnableLiveTrace: Live Trace allows you to know what&apos;s happening inside Azure SignalR service, it will  give you live
/// traces in real time, it will be helpful when you developing your own Azure SignalR based web application  or
/// self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged.
/// Values allowed: &quot;true&quot;/&quot;false&quot;, to enable/disable live trace feature.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecFeaturesFlagEnum>))]
public enum V1api20211001SignalRSpecFeaturesFlagEnum
{
    [EnumMember(Value = "EnableConnectivityLogs"), JsonStringEnumMemberName("EnableConnectivityLogs")]
    EnableConnectivityLogs,
    [EnumMember(Value = "EnableLiveTrace"), JsonStringEnumMemberName("EnableLiveTrace")]
    EnableLiveTrace,
    [EnumMember(Value = "EnableMessagingLogs"), JsonStringEnumMemberName("EnableMessagingLogs")]
    EnableMessagingLogs,
    [EnumMember(Value = "ServiceMode"), JsonStringEnumMemberName("ServiceMode")]
    ServiceMode
}

/// <summary>Feature of a resource, which controls the runtime behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecFeatures
{
    /// <summary>
    /// Flag: FeatureFlags is the supported features of Azure SignalR service.
    /// - ServiceMode: Flag for backend server for SignalR  service. Values allowed: &quot;Default&quot;: have your own backend server;
    /// &quot;Serverless&quot;: your application doesn&apos;t have a backend  server; &quot;Classic&quot;: for backward compatibility. Support both
    /// Default and Serverless mode but not recommended;  &quot;PredefinedOnly&quot;: for future use.
    /// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log  category respectively.
    /// - EnableMessagingLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category  respectively.
    /// - EnableLiveTrace: Live Trace allows you to know what&apos;s happening inside Azure SignalR service, it will  give you live
    /// traces in real time, it will be helpful when you developing your own Azure SignalR based web application  or
    /// self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged.
    /// Values allowed: &quot;true&quot;/&quot;false&quot;, to enable/disable live trace feature.
    /// </summary>
    [JsonPropertyName("flag")]
    public required V1api20211001SignalRSpecFeaturesFlagEnum Flag { get; set; }

    /// <summary>Properties: Optional properties related to this feature.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// Value: Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for
    /// allowed values.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Type: Represents the identity type: systemAssigned, userAssigned, None</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecIdentityTypeEnum>))]
public enum V1api20211001SignalRSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20211001SignalRSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211001SignalRSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: A class represent managed identities used for request and response</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecIdentity
{
    /// <summary>Type: Represents the identity type: systemAssigned, userAssigned, None</summary>
    [JsonPropertyName("type")]
    public V1api20211001SignalRSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: Get or set the user assigned identities</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211001SignalRSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Kind: The kind of the service, it can be SignalR or RawWebSockets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecKindEnum>))]
public enum V1api20211001SignalRSpecKindEnum
{
    [EnumMember(Value = "RawWebSockets"), JsonStringEnumMemberName("RawWebSockets")]
    RawWebSockets,
    [EnumMember(Value = "SignalR"), JsonStringEnumMemberName("SignalR")]
    SignalR
}

/// <summary>DefaultAction: Azure Networking ACL Action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecNetworkACLsDefaultActionEnum>))]
public enum V1api20211001SignalRSpecNetworkACLsDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>The incoming request type to the service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecNetworkACLsPrivateEndpointsAllowEnum>))]
public enum V1api20211001SignalRSpecNetworkACLsPrivateEndpointsAllowEnum
{
    [EnumMember(Value = "ClientConnection"), JsonStringEnumMemberName("ClientConnection")]
    ClientConnection,
    [EnumMember(Value = "RESTAPI"), JsonStringEnumMemberName("RESTAPI")]
    RESTAPI,
    [EnumMember(Value = "ServerConnection"), JsonStringEnumMemberName("ServerConnection")]
    ServerConnection,
    [EnumMember(Value = "Trace"), JsonStringEnumMemberName("Trace")]
    Trace
}

/// <summary>The incoming request type to the service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecNetworkACLsPrivateEndpointsDenyEnum>))]
public enum V1api20211001SignalRSpecNetworkACLsPrivateEndpointsDenyEnum
{
    [EnumMember(Value = "ClientConnection"), JsonStringEnumMemberName("ClientConnection")]
    ClientConnection,
    [EnumMember(Value = "RESTAPI"), JsonStringEnumMemberName("RESTAPI")]
    RESTAPI,
    [EnumMember(Value = "ServerConnection"), JsonStringEnumMemberName("ServerConnection")]
    ServerConnection,
    [EnumMember(Value = "Trace"), JsonStringEnumMemberName("Trace")]
    Trace
}

/// <summary>ACL for a private endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecNetworkACLsPrivateEndpoints
{
    /// <summary>Allow: Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("allow")]
    public IList<V1api20211001SignalRSpecNetworkACLsPrivateEndpointsAllowEnum>? Allow { get; set; }

    /// <summary>Deny: Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("deny")]
    public IList<V1api20211001SignalRSpecNetworkACLsPrivateEndpointsDenyEnum>? Deny { get; set; }

    /// <summary>Name: Name of the private endpoint connection</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The incoming request type to the service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecNetworkACLsPublicNetworkAllowEnum>))]
public enum V1api20211001SignalRSpecNetworkACLsPublicNetworkAllowEnum
{
    [EnumMember(Value = "ClientConnection"), JsonStringEnumMemberName("ClientConnection")]
    ClientConnection,
    [EnumMember(Value = "RESTAPI"), JsonStringEnumMemberName("RESTAPI")]
    RESTAPI,
    [EnumMember(Value = "ServerConnection"), JsonStringEnumMemberName("ServerConnection")]
    ServerConnection,
    [EnumMember(Value = "Trace"), JsonStringEnumMemberName("Trace")]
    Trace
}

/// <summary>The incoming request type to the service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecNetworkACLsPublicNetworkDenyEnum>))]
public enum V1api20211001SignalRSpecNetworkACLsPublicNetworkDenyEnum
{
    [EnumMember(Value = "ClientConnection"), JsonStringEnumMemberName("ClientConnection")]
    ClientConnection,
    [EnumMember(Value = "RESTAPI"), JsonStringEnumMemberName("RESTAPI")]
    RESTAPI,
    [EnumMember(Value = "ServerConnection"), JsonStringEnumMemberName("ServerConnection")]
    ServerConnection,
    [EnumMember(Value = "Trace"), JsonStringEnumMemberName("Trace")]
    Trace
}

/// <summary>PublicNetwork: Network ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecNetworkACLsPublicNetwork
{
    /// <summary>Allow: Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("allow")]
    public IList<V1api20211001SignalRSpecNetworkACLsPublicNetworkAllowEnum>? Allow { get; set; }

    /// <summary>Deny: Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("deny")]
    public IList<V1api20211001SignalRSpecNetworkACLsPublicNetworkDenyEnum>? Deny { get; set; }
}

/// <summary>NetworkACLs: Network ACLs for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecNetworkACLs
{
    /// <summary>DefaultAction: Azure Networking ACL Action.</summary>
    [JsonPropertyName("defaultAction")]
    public V1api20211001SignalRSpecNetworkACLsDefaultActionEnum? DefaultAction { get; set; }

    /// <summary>PrivateEndpoints: ACLs for requests from private endpoints</summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20211001SignalRSpecNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>PublicNetwork: Network ACL</summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20211001SignalRSpecNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211001SignalRSpecOperatorSpecSecretExpressions
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
/// PrimaryConnectionString: indicates where the PrimaryConnectionString secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpecSecretsPrimaryConnectionString
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
/// Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpecSecretsPrimaryKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecondaryConnectionString: indicates where the SecondaryConnectionString secret should be placed. If omitted, the secret
/// will not be retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpecSecretsSecondaryConnectionString
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpecSecrets
{
    /// <summary>
    /// PrimaryConnectionString: indicates where the PrimaryConnectionString secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20211001SignalRSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>
    /// PrimaryKey: indicates where the PrimaryKey secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20211001SignalRSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecondaryConnectionString: indicates where the SecondaryConnectionString secret should be placed. If omitted, the secret
    /// will not be retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20211001SignalRSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>
    /// SecondaryKey: indicates where the SecondaryKey secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20211001SignalRSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211001SignalRSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211001SignalRSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20211001SignalRSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Resource log category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecResourceLogConfigurationCategories
{
    /// <summary>
    /// Enabled: Indicates whether or the resource log category is enabled.
    /// Available values: true, false.
    /// Case insensitive.
    /// </summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    /// <summary>
    /// Name: Gets or sets the resource log category&apos;s name.
    /// Available values: ConnectivityLogs, MessagingLogs.
    /// Case insensitive.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceLogConfiguration: Resource log configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecResourceLogConfiguration
{
    /// <summary>Categories: Gets or sets the list of category configurations.</summary>
    [JsonPropertyName("categories")]
    public IList<V1api20211001SignalRSpecResourceLogConfigurationCategories>? Categories { get; set; }
}

/// <summary>
/// Tier: Optional tier of this particular SKU. &apos;Standard&apos; or &apos;Free&apos;.
/// `Basic` is deprecated, use `Standard` instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecSkuTierEnum>))]
public enum V1api20211001SignalRSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The billing information of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecSku
{
    /// <summary>
    /// Capacity: Optional, integer. The unit count of the resource. 1 by default.
    /// If present, following values are allowed:
    /// Free: 1
    /// Standard: 1,2,5,10,20,50,100
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>
    /// Name: The name of the SKU. Required.
    /// Allowed values: Standard_S1, Free_F1
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Tier: Optional tier of this particular SKU. &apos;Standard&apos; or &apos;Free&apos;.
    /// `Basic` is deprecated, use `Standard` instead.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20211001SignalRSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>Tls: TLS settings for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecTls
{
    /// <summary>ClientCertEnabled: Request client certificate during TLS handshake if enabled</summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}

/// <summary>ManagedIdentity: Managed identity settings for upstream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>
    /// Resource: The Resource indicating the App ID URI of the target resource.
    /// It also appears in the aud (audience) claim of the issued token.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Type: Upstream auth type enum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001SignalRSpecUpstreamTemplatesAuthTypeEnum>))]
public enum V1api20211001SignalRSpecUpstreamTemplatesAuthTypeEnum
{
    [EnumMember(Value = "ManagedIdentity"), JsonStringEnumMemberName("ManagedIdentity")]
    ManagedIdentity,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Auth: Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecUpstreamTemplatesAuth
{
    /// <summary>ManagedIdentity: Managed identity settings for upstream.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20211001SignalRSpecUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>Type: Upstream auth type enum.</summary>
    [JsonPropertyName("type")]
    public V1api20211001SignalRSpecUpstreamTemplatesAuthTypeEnum? Type { get; set; }
}

/// <summary>
/// Upstream template item settings. It defines the Upstream URL of the incoming requests.
/// The template defines the pattern
/// of the event, the hub or the category of the incoming request that matches current URL template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecUpstreamTemplates
{
    /// <summary>Auth: Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    [JsonPropertyName("auth")]
    public V1api20211001SignalRSpecUpstreamTemplatesAuth? Auth { get; set; }

    /// <summary>
    /// CategoryPattern: Gets or sets the matching pattern for category names. If not set, it matches any category.
    /// There are 3 kind of patterns supported:
    /// 1. &quot;*&quot;, it to matches any category name
    /// 2. Combine multiple categories with &quot;,&quot;, for example &quot;connections,messages&quot;, it matches category &quot;connections&quot; and
    /// &quot;messages&quot;
    /// 3. The single category name, for example, &quot;connections&quot;, it matches the category &quot;connections&quot;
    /// </summary>
    [JsonPropertyName("categoryPattern")]
    public string? CategoryPattern { get; set; }

    /// <summary>
    /// EventPattern: Gets or sets the matching pattern for event names. If not set, it matches any event.
    /// There are 3 kind of patterns supported:
    /// 1. &quot;*&quot;, it to matches any event name
    /// 2. Combine multiple events with &quot;,&quot;, for example &quot;connect,disconnect&quot;, it matches event &quot;connect&quot; and &quot;disconnect&quot;
    /// 3. The single event name, for example, &quot;connect&quot;, it matches &quot;connect&quot;
    /// </summary>
    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    /// <summary>
    /// HubPattern: Gets or sets the matching pattern for hub names. If not set, it matches any hub.
    /// There are 3 kind of patterns supported:
    /// 1. &quot;*&quot;, it to matches any hub name
    /// 2. Combine multiple hubs with &quot;,&quot;, for example &quot;hub1,hub2&quot;, it matches &quot;hub1&quot; and &quot;hub2&quot;
    /// 3. The single hub name, for example, &quot;hub1&quot;, it matches &quot;hub1&quot;
    /// </summary>
    [JsonPropertyName("hubPattern")]
    public string? HubPattern { get; set; }

    /// <summary>
    /// UrlTemplate: Gets or sets the Upstream URL template. You can use 3 predefined parameters {hub}, {category} {event}
    /// inside the template, the value of the Upstream URL is dynamically calculated when the client request comes in.
    /// For example, if the urlTemplate is `http://example.com/{hub}/api/{event}`, with a client request from hub `chat`
    /// connects, it will first POST to this URL: `http://example.com/chat/api/connect`.
    /// </summary>
    [JsonPropertyName("urlTemplate")]
    public required string UrlTemplate { get; set; }
}

/// <summary>Upstream: The settings for the Upstream when the service is in server-less mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpecUpstream
{
    /// <summary>Templates: Gets or sets the list of Upstream URL templates. Order matters, and the first matching template takes effects.</summary>
    [JsonPropertyName("templates")]
    public IList<V1api20211001SignalRSpecUpstreamTemplates>? Templates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20211001SignalRSpecCors? Cors { get; set; }

    /// <summary>
    /// DisableAadAuth: DisableLocalAuth
    /// Enable or disable aad auth
    /// When set as true, connection with AuthType=aad won&apos;t work.
    /// </summary>
    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    /// <summary>
    /// DisableLocalAuth: DisableLocalAuth
    /// Enable or disable local auth with AccessKey
    /// When set as true, connection with AccessKey=xxx won&apos;t work.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>
    /// Features: List of the featureFlags.
    /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
    /// And the response will only include featureFlags that are explicitly set.
    /// When a featureFlag is not explicitly set, its globally default value will be used
    /// But keep in mind, the default value doesn&apos;t mean &quot;false&quot;. It varies in terms of different FeatureFlags.
    /// </summary>
    [JsonPropertyName("features")]
    public IList<V1api20211001SignalRSpecFeatures>? Features { get; set; }

    /// <summary>Identity: A class represent managed identities used for request and response</summary>
    [JsonPropertyName("identity")]
    public V1api20211001SignalRSpecIdentity? Identity { get; set; }

    /// <summary>Kind: The kind of the service, it can be SignalR or RawWebSockets</summary>
    [JsonPropertyName("kind")]
    public V1api20211001SignalRSpecKindEnum? Kind { get; set; }

    /// <summary>Location: The GEO location of the resource. e.g. West US | East US | North Central US | South Central US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>NetworkACLs: Network ACLs for the resource</summary>
    [JsonPropertyName("networkACLs")]
    public V1api20211001SignalRSpecNetworkACLs? NetworkACLs { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211001SignalRSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211001SignalRSpecOwner Owner { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Enable or disable public network access. Default to &quot;Enabled&quot;.
    /// When it&apos;s Enabled, network ACLs still apply.
    /// When it&apos;s Disabled, public network access is always disabled no matter what you set in network ACLs.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>ResourceLogConfiguration: Resource log configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20211001SignalRSpecResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    /// <summary>Sku: The billing information of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20211001SignalRSpecSku? Sku { get; set; }

    /// <summary>Tags: Tags of the service which is a list of key value pairs that describe the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tls: TLS settings for the resource</summary>
    [JsonPropertyName("tls")]
    public V1api20211001SignalRSpecTls? Tls { get; set; }

    /// <summary>Upstream: The settings for the Upstream when the service is in server-less mode.</summary>
    [JsonPropertyName("upstream")]
    public V1api20211001SignalRSpecUpstream? Upstream { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusConditions
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

/// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusCors
{
    /// <summary>
    /// AllowedOrigins: Gets or sets the list of origins that should be allowed to make cross-origin calls (for example:
    /// http://example.com:12345). Use &quot;*&quot; to allow all. If omitted, allow all by default.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}

/// <summary>Feature of a resource, which controls the runtime behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusFeatures
{
    /// <summary>
    /// Flag: FeatureFlags is the supported features of Azure SignalR service.
    /// - ServiceMode: Flag for backend server for SignalR  service. Values allowed: &quot;Default&quot;: have your own backend server;
    /// &quot;Serverless&quot;: your application doesn&apos;t have a backend  server; &quot;Classic&quot;: for backward compatibility. Support both
    /// Default and Serverless mode but not recommended;  &quot;PredefinedOnly&quot;: for future use.
    /// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log  category respectively.
    /// - EnableMessagingLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category  respectively.
    /// - EnableLiveTrace: Live Trace allows you to know what&apos;s happening inside Azure SignalR service, it will  give you live
    /// traces in real time, it will be helpful when you developing your own Azure SignalR based web application  or
    /// self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged.
    /// Values allowed: &quot;true&quot;/&quot;false&quot;, to enable/disable live trace feature.
    /// </summary>
    [JsonPropertyName("flag")]
    public string? Flag { get; set; }

    /// <summary>Properties: Optional properties related to this feature.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// Value: Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for
    /// allowed values.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Properties of user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: Get the client id for the user assigned identity</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: Get the principal id for the user assigned identity</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: A class represent managed identities used for request and response</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusIdentity
{
    /// <summary>
    /// PrincipalId: Get the principal id for the system assigned identity.
    /// Only be used in response.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: Get the tenant id for the system assigned identity.
    /// Only be used in response
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Represents the identity type: systemAssigned, userAssigned, None</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: Get or set the user assigned identities</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211001SignalRStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ACL for a private endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusNetworkACLsPrivateEndpoints
{
    /// <summary>Allow: Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    /// <summary>Deny: Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }

    /// <summary>Name: Name of the private endpoint connection</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetwork: Network ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusNetworkACLsPublicNetwork
{
    /// <summary>Allow: Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    /// <summary>Deny: Denied request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.</summary>
    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }
}

/// <summary>NetworkACLs: Network ACLs for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusNetworkACLs
{
    /// <summary>DefaultAction: Azure Networking ACL Action.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>PrivateEndpoints: ACLs for requests from private endpoints</summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20211001SignalRStatusNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>PublicNetwork: Network ACL</summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20211001SignalRStatusNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}

/// <summary>A private endpoint connection to an azure resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusPrivateEndpointConnections
{
    /// <summary>Id: Fully qualified resource Id for the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Resource log category configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusResourceLogConfigurationCategories
{
    /// <summary>
    /// Enabled: Indicates whether or the resource log category is enabled.
    /// Available values: true, false.
    /// Case insensitive.
    /// </summary>
    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    /// <summary>
    /// Name: Gets or sets the resource log category&apos;s name.
    /// Available values: ConnectivityLogs, MessagingLogs.
    /// Case insensitive.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceLogConfiguration: Resource log configuration of a Microsoft.SignalRService resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusResourceLogConfiguration
{
    /// <summary>Categories: Gets or sets the list of category configurations.</summary>
    [JsonPropertyName("categories")]
    public IList<V1api20211001SignalRStatusResourceLogConfigurationCategories>? Categories { get; set; }
}

/// <summary>Describes a Shared Private Link Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusSharedPrivateLinkResources
{
    /// <summary>Id: Fully qualified resource Id for the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The billing information of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusSku
{
    /// <summary>
    /// Capacity: Optional, integer. The unit count of the resource. 1 by default.
    /// If present, following values are allowed:
    /// Free: 1
    /// Standard: 1,2,5,10,20,50,100
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Not used. Retained for future use.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// Name: The name of the SKU. Required.
    /// Allowed values: Standard_S1, Free_F1
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Not used. Retained for future use.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: Optional tier of this particular SKU. &apos;Standard&apos; or &apos;Free&apos;.
    /// `Basic` is deprecated, use `Standard` instead.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Tls: TLS settings for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusTls
{
    /// <summary>ClientCertEnabled: Request client certificate during TLS handshake if enabled</summary>
    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}

/// <summary>ManagedIdentity: Managed identity settings for upstream.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>
    /// Resource: The Resource indicating the App ID URI of the target resource.
    /// It also appears in the aud (audience) claim of the issued token.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>Auth: Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusUpstreamTemplatesAuth
{
    /// <summary>ManagedIdentity: Managed identity settings for upstream.</summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20211001SignalRStatusUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    /// <summary>Type: Upstream auth type enum.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Upstream template item settings. It defines the Upstream URL of the incoming requests.
/// The template defines the pattern
/// of the event, the hub or the category of the incoming request that matches current URL template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusUpstreamTemplates
{
    /// <summary>Auth: Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    [JsonPropertyName("auth")]
    public V1api20211001SignalRStatusUpstreamTemplatesAuth? Auth { get; set; }

    /// <summary>
    /// CategoryPattern: Gets or sets the matching pattern for category names. If not set, it matches any category.
    /// There are 3 kind of patterns supported:
    /// 1. &quot;*&quot;, it to matches any category name
    /// 2. Combine multiple categories with &quot;,&quot;, for example &quot;connections,messages&quot;, it matches category &quot;connections&quot; and
    /// &quot;messages&quot;
    /// 3. The single category name, for example, &quot;connections&quot;, it matches the category &quot;connections&quot;
    /// </summary>
    [JsonPropertyName("categoryPattern")]
    public string? CategoryPattern { get; set; }

    /// <summary>
    /// EventPattern: Gets or sets the matching pattern for event names. If not set, it matches any event.
    /// There are 3 kind of patterns supported:
    /// 1. &quot;*&quot;, it to matches any event name
    /// 2. Combine multiple events with &quot;,&quot;, for example &quot;connect,disconnect&quot;, it matches event &quot;connect&quot; and &quot;disconnect&quot;
    /// 3. The single event name, for example, &quot;connect&quot;, it matches &quot;connect&quot;
    /// </summary>
    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    /// <summary>
    /// HubPattern: Gets or sets the matching pattern for hub names. If not set, it matches any hub.
    /// There are 3 kind of patterns supported:
    /// 1. &quot;*&quot;, it to matches any hub name
    /// 2. Combine multiple hubs with &quot;,&quot;, for example &quot;hub1,hub2&quot;, it matches &quot;hub1&quot; and &quot;hub2&quot;
    /// 3. The single hub name, for example, &quot;hub1&quot;, it matches &quot;hub1&quot;
    /// </summary>
    [JsonPropertyName("hubPattern")]
    public string? HubPattern { get; set; }

    /// <summary>
    /// UrlTemplate: Gets or sets the Upstream URL template. You can use 3 predefined parameters {hub}, {category} {event}
    /// inside the template, the value of the Upstream URL is dynamically calculated when the client request comes in.
    /// For example, if the urlTemplate is `http://example.com/{hub}/api/{event}`, with a client request from hub `chat`
    /// connects, it will first POST to this URL: `http://example.com/chat/api/connect`.
    /// </summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>Upstream: The settings for the Upstream when the service is in server-less mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatusUpstream
{
    /// <summary>Templates: Gets or sets the list of Upstream URL templates. Order matters, and the first matching template takes effects.</summary>
    [JsonPropertyName("templates")]
    public IList<V1api20211001SignalRStatusUpstreamTemplates>? Templates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001SignalRStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211001SignalRStatusConditions>? Conditions { get; set; }

    /// <summary>Cors: Cross-Origin Resource Sharing (CORS) settings.</summary>
    [JsonPropertyName("cors")]
    public V1api20211001SignalRStatusCors? Cors { get; set; }

    /// <summary>
    /// DisableAadAuth: DisableLocalAuth
    /// Enable or disable aad auth
    /// When set as true, connection with AuthType=aad won&apos;t work.
    /// </summary>
    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    /// <summary>
    /// DisableLocalAuth: DisableLocalAuth
    /// Enable or disable local auth with AccessKey
    /// When set as true, connection with AccessKey=xxx won&apos;t work.
    /// </summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>ExternalIP: The publicly accessible IP of the resource.</summary>
    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    /// <summary>
    /// Features: List of the featureFlags.
    /// FeatureFlags that are not included in the parameters for the update operation will not be modified.
    /// And the response will only include featureFlags that are explicitly set.
    /// When a featureFlag is not explicitly set, its globally default value will be used
    /// But keep in mind, the default value doesn&apos;t mean &quot;false&quot;. It varies in terms of different FeatureFlags.
    /// </summary>
    [JsonPropertyName("features")]
    public IList<V1api20211001SignalRStatusFeatures>? Features { get; set; }

    /// <summary>HostName: FQDN of the service instance.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HostNamePrefix: Deprecated.</summary>
    [JsonPropertyName("hostNamePrefix")]
    public string? HostNamePrefix { get; set; }

    /// <summary>Id: Fully qualified resource Id for the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: A class represent managed identities used for request and response</summary>
    [JsonPropertyName("identity")]
    public V1api20211001SignalRStatusIdentity? Identity { get; set; }

    /// <summary>Kind: The kind of the service, it can be SignalR or RawWebSockets</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: The GEO location of the resource. e.g. West US | East US | North Central US | South Central US.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkACLs: Network ACLs for the resource</summary>
    [JsonPropertyName("networkACLs")]
    public V1api20211001SignalRStatusNetworkACLs? NetworkACLs { get; set; }

    /// <summary>PrivateEndpointConnections: Private endpoint connections to the resource.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20211001SignalRStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Enable or disable public network access. Default to &quot;Enabled&quot;.
    /// When it&apos;s Enabled, network ACLs still apply.
    /// When it&apos;s Disabled, public network access is always disabled no matter what you set in network ACLs.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PublicPort: The publicly accessible port of the resource which is designed for browser/client side usage.</summary>
    [JsonPropertyName("publicPort")]
    public int? PublicPort { get; set; }

    /// <summary>ResourceLogConfiguration: Resource log configuration of a Microsoft.SignalRService resource.</summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20211001SignalRStatusResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    /// <summary>ServerPort: The publicly accessible port of the resource which is designed for customer server side usage.</summary>
    [JsonPropertyName("serverPort")]
    public int? ServerPort { get; set; }

    /// <summary>SharedPrivateLinkResources: The list of shared private link resources.</summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20211001SignalRStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Sku: The billing information of the resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20211001SignalRStatusSku? Sku { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20211001SignalRStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Tags of the service which is a list of key value pairs that describe the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tls: TLS settings for the resource</summary>
    [JsonPropertyName("tls")]
    public V1api20211001SignalRStatusTls? Tls { get; set; }

    /// <summary>Type: The type of the resource - e.g. &quot;Microsoft.SignalRService/SignalR&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Upstream: The settings for the Upstream when the service is in server-less mode.</summary>
    [JsonPropertyName("upstream")]
    public V1api20211001SignalRStatusUpstream? Upstream { get; set; }

    /// <summary>Version: Version of the resource. Probably you need the same or higher version of client SDKs.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /signalr/resource-manager/Microsoft.SignalRService/SignalRService/stable/2021-10-01/signalr.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211001SignalR : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211001SignalRSpec?>, IStatus<V1api20211001SignalRStatus?>
{
    public const string KubeApiVersion = "v1api20211001";
    public const string KubeKind = "SignalR";
    public const string KubeGroup = "signalrservice.azure.com";
    public const string KubePluralName = "signalrs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "signalrservice.azure.com/v1api20211001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SignalR";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211001SignalRSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20211001SignalRStatus? Status { get; set; }
}